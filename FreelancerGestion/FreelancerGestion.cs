using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace FreelancerGestion
{
    public class FreelancerGestion
    {
        public enum Status
        {
            Unknown,
            CheckedIn,
            CheckedOut
        }

        public Status currentStatus = Status.CheckedOut;

        public List<Check> checks = new List<Check>();

        public float tjm = 300.0f;
        public float heuresParJour = 8;
        public float tarifHoraire = 37.5f;

        public bool factureALaJournee = true;

        public List<ComptaEntry> entries = new List<ComptaEntry>();
        public static float defaultCharge = 55.0f;
        public float salaire = 2500.0f;

        public FreelancerGestion()
        {
            this.loadChecksInXml();
            this.loadEntriesInXml();
        }

        public TimeSpan getTotalHours()
        {
            TimeSpan total = new TimeSpan();

            for(int i = 0; i < this.checks.Count; i++)
            {
                Check check = this.checks[i];

                if (check.type == Status.CheckedIn)
                {
                    Check nextCheck = null;

                    if(i < this.checks.Count - 1 && this.checks[i + 1].type == Status.CheckedOut)
                    {
                        nextCheck = this.checks[i + 1];
                    }

                    TimeSpan totalSession;
                    if(nextCheck != null)
                    {
                        totalSession = nextCheck.date.Subtract(check.date);
                    }
                    else
                    {
                        totalSession = DateTime.Now.Subtract(check.date);
                    }
                    //System.Diagnostics.Debug.WriteLine("total session: " + totalSession.ToString());

                    total = total.Add(totalSession);
                }
            }

            return total;
        }

        public float getFactureTotale()
        {
            float result = 0.0f;

            if(this.factureALaJournee)
            {
                int numberOfWorkDays = (int)Math.Floor((float)this.getTotalHours().TotalHours / this.heuresParJour);
                result = this.tjm * numberOfWorkDays;
            }
            else
            {
                result = this.tarifHoraire * (float)this.getTotalHours().TotalHours;
            }

            return result;
        }

        public float getTreasury()
        {
            float result = 0.0f;

            foreach(ComptaEntry entry in this.entries)
            {
                result += entry.getReste();
            }

            return result;
        }

        public void loadChecksInXml()
        {
            if (File.Exists("checks.xml"))
            {
                System.Diagnostics.Debug.WriteLine("load from file");
                XmlDocument DocXml = new XmlDocument();
                DocXml.Load("checks.xml");
                XmlNode body = DocXml.SelectSingleNode("checks");

                foreach (XmlNode checkElement in body.ChildNodes)
                {
                    DateTime date = DateTime.Parse(checkElement.ChildNodes[0].InnerText);
                    FreelancerGestion.Status type = FreelancerGestion.Status.Unknown;
                    if(checkElement.ChildNodes[1].InnerText == "CheckedIn")
                    {
                        type = Status.CheckedIn;
                    }
                    else if(checkElement.ChildNodes[1].InnerText == "CheckedOut")
                    {
                        type = Status.CheckedOut;
                    }
                    string origin = checkElement.ChildNodes[2].InnerText;

                    Check newCheck = new Check(date, type, origin);
                    this.checks.Add(newCheck);
                }

                //System.Diagnostics.Debug.WriteLine("last check is "+ this.checks[this.checks.Count - 1].type.ToString());
                if (this.checks[this.checks.Count - 1].type == Status.CheckedIn)
                {
                    this.currentStatus = Status.CheckedIn;
                }
            }
        }

        public void loadEntriesInXml()
        {
            if (File.Exists("entries.xml"))
            {
                System.Diagnostics.Debug.WriteLine("load from file");
                XmlDocument DocXml = new XmlDocument();
                DocXml.Load("entries.xml");
                XmlNode body = DocXml.SelectSingleNode("entries");

                foreach (XmlNode entryElement in body.ChildNodes)
                {
                    ComptaEntry comptaEntry = new ComptaEntry(
                        entryElement.ChildNodes[0].InnerText,
                        DateTime.Parse(entryElement.ChildNodes[1].InnerText),
                        float.Parse(entryElement.ChildNodes[2].InnerText),
                        float.Parse(entryElement.ChildNodes[3].InnerText)
                    );

                    this.entries.Add(comptaEntry);

                    //this.entries.Add(new ComptaEntry("Restant couveuse", DateTime.Now, 30.0f, 0.0f));
                }
            }
        }

        public void saveChecksInXml()
        {
            if (File.Exists("checks.xml"))
            {
                System.Diagnostics.Debug.WriteLine("open file");
                XmlDocument DocXml = new XmlDocument();
                DocXml.Load("checks.xml");
                XmlNode body = DocXml.SelectSingleNode("checks");
                body.RemoveAll();

                foreach (Check check in this.checks)
                {
                    XmlNode checkElement = DocXml.CreateElement("check");

                    XmlNode dateElement = DocXml.CreateElement("date");
                    dateElement.InnerText = check.date.ToString();
                    checkElement.AppendChild(dateElement);

                    XmlNode typeElement = DocXml.CreateElement("type");
                    typeElement.InnerText = check.type.ToString();
                    checkElement.AppendChild(typeElement);

                    XmlNode originElement = DocXml.CreateElement("origin");
                    originElement.InnerText = check.origin;
                    checkElement.AppendChild(originElement);

                    body.AppendChild(checkElement);
                }

                DocXml.Save("checks.xml");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("create file");
                using (XmlWriter writer = XmlWriter.Create("checks.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("checks");
                    foreach (Check check in this.checks)
                    {
                        writer.WriteStartElement("check");

                        writer.WriteElementString("date", check.date.ToString());
                        writer.WriteElementString("type", check.type.ToString());
                        writer.WriteElementString("origin", check.origin);

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }

        public void saveEntriesInXml()
        {
            if (File.Exists("entries.xml"))
            {
                System.Diagnostics.Debug.WriteLine("open file");
                XmlDocument DocXml = new XmlDocument();
                DocXml.Load("entries.xml");
                XmlNode body = DocXml.SelectSingleNode("entries");
                body.RemoveAll();

                foreach (ComptaEntry entry in this.entries)
                {
                    XmlNode entryElement = DocXml.CreateElement("entry");

                    XmlNode libelleElement = DocXml.CreateElement("libelle");
                    libelleElement.InnerText = entry.libelle;
                    entryElement.AppendChild(libelleElement);

                    XmlNode dateElement = DocXml.CreateElement("date");
                    dateElement.InnerText = entry.date.ToShortDateString();
                    entryElement.AppendChild(dateElement);

                    XmlNode typeElement = DocXml.CreateElement("montant");
                    typeElement.InnerText = entry.amount.ToString();
                    entryElement.AppendChild(typeElement);

                    XmlNode originElement = DocXml.CreateElement("origin");
                    originElement.InnerText = entry.chargesPourcent.ToString();
                    entryElement.AppendChild(originElement);

                    body.AppendChild(entryElement);
                }

                DocXml.Save("entries.xml");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("create file");
                using (XmlWriter writer = XmlWriter.Create("entries.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("entries");
                    foreach (ComptaEntry entry in this.entries)
                    {
                        writer.WriteStartElement("entry");

                        writer.WriteElementString("libelle", entry.libelle);
                        writer.WriteElementString("date", entry.date.ToShortDateString());
                        writer.WriteElementString("montant", entry.amount.ToString());
                        writer.WriteElementString("origin", entry.chargesPourcent.ToString());

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }

        public static string GetCurrentIpAddress()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ips = Dns.GetHostAddresses(hostname);
            string ip = String.Empty;
            if (ips.Length > 0)
            {
                ip = ips[0].ToString();
            }
            return ip;
        }

        public static IPAddress GetIPAddress(string hostName)
        {
            Ping ping = new Ping();
            var replay = ping.Send(hostName);

            if (replay.Status == IPStatus.Success)
            {
                System.Diagnostics.Debug.WriteLine("my address is "+replay.Address);
                return replay.Address;
            }
            return null;
        }

        public static IPAddress GetExternalIp()
        {
            string whatIsMyIp = "http://www.my-ip-address.net/";
            //string getIpRegex = @"(?<=<h3>.*)\d*\.\d*\.\d*\.\d*(?=</h3>)";
            string getIpRegex = @"\d*\.\d*\.\d*\.\d*";
            WebClient wc = new WebClient();
            UTF8Encoding utf8 = new UTF8Encoding();
            string requestHtml = "";
            try
            {
                requestHtml = utf8.GetString(wc.DownloadData(whatIsMyIp));
                //System.Diagnostics.Debug.WriteLine("requestHtml: "+requestHtml);
            }
            catch (WebException we)
            {
                // do something with exception
                //Console.Write(we.ToString());
                System.Diagnostics.Debug.WriteLine(we.ToString());
            }
            Regex r = new Regex(getIpRegex);
            Match m = r.Match(requestHtml);
            IPAddress externalIp = null;
            if (m.Success)
            {
                externalIp = IPAddress.Parse(m.Value);
            }
            //System.Diagnostics.Debug.WriteLine("externalIp: " + externalIp);
            return externalIp;
        }
    }
}
