# forax
Logiciel de gestion de temps (pointeuse) et de comptabilité pour freelance

<em>Copie de l'article sur le site officiel de twothirds : http://twothirds.fr/forax-logiciel-gratuit-de-gestion-de-temps-pointeuse-et-de-comptabilite/</em>

Forax est un logiciel réalisé en C# sur .NET qui permet à un freelance de pointer, calculer ses heures de travail et connaitre son prix de facturation.

<img src="http://twothirds.fr/medias/logo-300x173.png" alt="fornax-logo">

Nous avons développé cet outil car nous avions besoin de calculer efficacement les heures que nous passions sur un projet et notamment si nous sommes en mission dans les locaux même du client. Nommé d’après la constellation, Fornax est le « fourneau » grâce auquel nous forgeons nos factures 😉

Un simple clic « Check In » permet de démarrer la journée de travail et le décompte commence. C’est la pause de midi ? Un clic sur « Check out » et votre temps n’est plus décompté. A la fin de journée, vous aurez le total à la minute près que vous avez travaillé entre les check in et check out. Cela nous permet efficacement de savoir si notre temps de travail est trop ou pas assez élevé pour la journée. Cela peut s’avérer également utile pour les freelances qui facturent à l’heure puisqu’ils ont le décompte total des heures et des minutes.

<img src="http://twothirds.fr/medias/fornax-screenshot.png" alt="fornax-screenshot"">

Intéressant également : la prise d’adresse IP. Il faut que votre ordinateur soit connecté à Internet pour utiliser les check in et check out de Fornax. Cela vous permet, à chaque check, de récupérer votre adresse IP actuelle, qui peut faire foi de votre présence dans les locaux du client.

Un clic sur « Taux horaire » permet de voir combien vous devriez facturer en fonction du total d’heures travaillé et de votre taux horaire. Un clic sur « Facturation à la journée » fera apparaître votre prix à facturer en fonction de votre total d’heures, de votre TJM (Tarif Journalier Moyen) et de vos heures visées par journée.

Un clic sur le bouton « Comptabilité » fera apparaître une nouvelle fenêtre avec une gestion basique de comptabilité avec rentrées d’argent et frais, incluant un système de charges (si je gagne 100€ avec 10% de charges, le logiciel considère que vous avez gagné 90€).

La liste des checks et la liste des écritures comptables sont sauvegardées dans deux fichiers respectifs : checks.xml et entries.xml qui seront créés dans le dossier où vous placer l’exécutable dès vos premiers checks et vos premières écritures. Si vous souhaitez sauvegarder ces fichiers ailleurs, il suffit de les copier coller à un autre endroit. Si vous souhaitez reprendre à zéro, il suffit de les renommer ou de les supprimer. Le logiciel cherchera uniquement ces fichiers en fonction des noms « checks.xml » et « entries.xml » au sein de son propre dossier.

Le logiciel en est à sa toute première version et les fonctionnalités sont basiques mais efficaces car nous n’avions pas besoin de plus. Nous avons pensé qu’il pourrait être utile pour d’autres entreprises ou freelances et c’est pourquoi nous le publions actuellement sous license Apache 2.0. Le projet est disponible sur GitHub : https://github.com/twothirdsFR/forax

La solution Microsoft Visual Studio est disponible sur GitHub, ainsi que l’exécutable Windows qui permet de télécharger le logiciel compilé.
