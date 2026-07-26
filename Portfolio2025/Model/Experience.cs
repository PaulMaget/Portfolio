namespace Portfolio.Model;

public record Experience
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Nature { get; set; }
    public required string Organization { get; set; }
    public required string Year { get; set; }
    public required string ShortHtmlDescription { get; set; }
    public required string HtmlDescription { get; set; }
    public string? ImageUrl { get; set; }// = "https://placehold.co/50x50";
    public List<Competence> Competences { get; set; } = [];
    public List<string> HardSkills { get; set; } = [];
    public List<string> SoftSkills { get; set; } = [];
}

public static class ExperienceExtensions
{
    public static string GetId(this Experience experience)
    {
        return experience.Id;
    }
}

public static class Experiences
{
    public static List<Experience> All => [StageMJC, OrganizingHistory, AlternanceAlpilink, StageNeofid];

    public static Experience StageMJC { get; } = new()
    {
        Id = "stage-mjc",
        Name = "Animation de stages de jeux vidéo",
        Nature = "Bénévolat",
        Organization = "MJC Manosque",
        Year = "2022",
        Competences = [
            Competences.Unity,
        ],
        HardSkills = [
            "Développement Unity 2D/3D",
            "URP",
        ],
        SoftSkills = [
            "Préparation d’un projet",
            "Pédagogie",
            "Gestion de projet",
        ],
        ShortHtmlDescription = """
        <p>
            Animation de deux stages de création de jeux vidéo pour des jeunes de 12 à 25 ans.
        </p>
        """,
        HtmlDescription = """
        <p>
            En 2022, avec l'accord de la MJC de Manosque, j'ai animé à deux reprises des stages de création de jeux vidéo d'une semaine pour des jeunes de 12 à 25 ans avec le logiciel Unity.
        </p>
        <img src="./images/MJC_photo1.png" alt="Photo prise lors d'un des stages" style="width: 50%" />
        <p>
            À chaque fois, je me préparais plusieurs semaines à l'avance afin de définir le sujet et d’adapter ma pédagogie.
        </p>
        <p>
            Le premier jeu était en 2D et le second en 3D. En raison du temps limité, nous avons utilisé des ressources gratuites et j’ai limité les programmes complexes en privilégiant le visual scripting.
        </p>
        <img src="./images/MJC_photo2.png" alt="Photo prise lors d'un des stages" style="width: 30%" />
        <p>
            Ces stages ont permis d’initier les participants à l’utilisation d’Unity et à la conception de jeux vidéo. De mon côté, ils m'ont formé au rôle de pédagogue et de chef de projet, des compétences qui m'ont ensuite été précieuses en BUT.
        </p>
        """,
        ImageUrl = "./images/MJC_photo1.png",
    };

    public static Experience OrganizingHistory { get; } = new()
    {
        Id = "organizing-history",
        Name = "Développement d'un jeu ludo-éducatif en ligne",
        Nature = "Projet universitaire",
        Organization = "IUT2, dep. INFO, UGA, Grenoble (38)",
        Year = "2023-2024",
        Competences = [
            Competences.Php,
            Competences.Symfony,
            Competences.JavaScript,
        ],
        HardSkills = [
            "Développement web fullstack",
            "Conception d’architecture",
            "Système d’authentification",
        ],
        SoftSkills = [
            "Travail en équipe",
            "Gestion de projet",
        ],
        ShortHtmlDescription = """
        <p>
            Création d'un jeu ludo-éducatif en ligne, sécurisé, pour aider les collégiens à réviser leurs cours d'histoire.
        </p>
        """,
        HtmlDescription = """
        <p>
            En deuxième année de BUT, il nous a été demandé de développer un jeu ludo-éducatif en ligne.
            Le site devait être sécurisé avec un système d'authentification pour les enseignants et les élèves, avec une interface d'administration pour les enseignants.
            Mon groupe a choisi d'orienter le jeu vers les cours d'histoire de troisième, pour permettre aux collégiens de réviser leur Brevet de manière ludique.
        </p>
        <p>
            Le projet était en groupe de huit, pour une durée de trois mois.<br>
            Dans mon équipe, j'ai proposé le concept du jeu, j'ai supervisé l'aspect technique et j'ai aidé à répartir les tâches pendant la réalisation.
        </p>
        <img src="./images/OrganizingHistory_home.png" alt="Capture de l'écran d'accueil du site" style="width: 50%" />
        <p>
            Nous avons choisi d'utiliser le framework Symfony pour le backend et JavaScript vanilla pour le frontend.
        </p>
        <img src="./images/OrganizingHistory_game.png" alt="Capture de l'écran du jeu" style="width: 50%" />
        <p>
            Notre projet a remporté le 3<sup>e</sup> prix du meilleur prototype parmi tous les projets de la promotion. À la suite d'un vote de la promotion, nous avons aussi remporté le prix du public parmi les 3 projets qui étaient présentés.
        </p>
        """,
        ImageUrl = "./images/OrganizingHistory_home.png",
    };

    public static Experience AlternanceAlpilink { get; } = new()
    {
        Id = "alternance-alpilink",
        Name = "Développement backend borne",
        Nature = "Alternance",
        Organization = "Alpilink",
        Year = "2024-2025",
        Competences = [
            Competences.CSharp,
            Competences.NetCore,
            Competences.RabbitMq,
            Competences.SignalR,
        ],
        HardSkills = [
            "Backend C#",
            "Conception d’architecture",
            "Communication Serial Port",
            "Communication SignalR",
            "Communication RabbitMQ",
            "Développement d’un framework de test",
        ],
        SoftSkills = [
            "Travail en équipe",
            "Méthode agile",
            "Prise d’initiative",
            "Rédaction de documentation",
        ],
        ShortHtmlDescription = """
        <p>
            Développement de l’application backend pour le nouveau système de bornes de vente d’Alpilink.
        </p>
        """,
        HtmlDescription = """
        <p>
            En BUT, j’ai pu faire un stage puis une alternance d'un an dans l’entreprise <a class="default-link" href="https://www.alpilink.fr/">Alpilink</a>,
            spécialisée dans la vente de forfaits en ligne pour les stations de ski.
        </p>
        <p>
            Ma mission était de concevoir, développer et documenter une nouvelle application backend pour les bornes de vente de l’entreprise.
            Ces bornes sont principalement vendues à des stations de ski pour permettre une vente et une distribution de forfaits automatiques.
        </p>
        <img src="./images/Kiosk-light.jpg" alt="Photo d'une borne" style="width: 50%" />
        <p>
            Je suis intervenu sur la partie backend de l'application, qui fait l'interface entre l'application visuelle et les périphériques de la borne par Serial Port.
            Le backend a été écrit en C# avec le framework ASP .Net et utilise des technologies comme RabbitMQ et SignalR pour communiquer avec l’application frontend et un serveur distant.
        </p>
        <p>
            En raison des sommes d'argent en jeu, j’ai été particulièrement prudent lors de la communication avec le module monétique et pour la gestion des erreurs. Pour cette raison, j'ai développé un framework de test permettant aux testeurs de simuler des périphériques matériels.
        </p>
        <img src="./images/borne-click-and-collect.jpg" alt="Photo d'une borne" style="width: 50%" />
        """,
        ImageUrl = "./images/Kiosk-light.jpg",
    };

    public static Experience StageNeofid { get; } = new()
    {
        Id = "stage-neofid",
        Name = "Développement d'un jeu vidéo",
        Nature = "Stage",
        Organization = "Neofid Studios",
        Year = "2026",
        Competences = [
            Competences.CSharp,
            Competences.Unity,
        ],
        HardSkills = [
            "Développement Unity 2D",
            "URP",
            "UiTookit",
            "Programmation C#",
            "Conception d’architecture",
        ],
        SoftSkills = [
            "Travail en équipe",
            "Participation à la conception du jeu",
            "Prise d’initiative",
        ],
        ShortHtmlDescription = """
        <p>
            Développement d'une vertical slice de jeu vidéo avec Unity.
        </p>
        """,
        HtmlDescription = """
        <p>
            Pour conclure ma première année de Master, j'ai pu faire un stage dans l'entreprise <a class="default-link" href="https://neofid-studios.com/fr">Neofid Studios</a>.
            Le studio est spécialisé dans le développement de jeux "rétro", mais souhaitait faire un premier pas dans les jeux modernes.
            Neofid m'a initialement contacté en 2024, après que des amis m'aient recommandé pour mes compétences avec Unity.
        </p>
        <img src="./images/DiveDeeper.png" alt="Capture du prototype visuel réalisé pendant le stage" style="width: 50%" />
        <p>
            Le jeu est en 2D, en vue de côté, inspiré de titres comme "Animal Well", "Resident Evil" ou "Hollow Knight".
            Le joueur incarne un astronaute qui doit explorer et naviguer dans des grottes et des structures extraterrestres, remplies de créatures hostiles et de ressources à collecter.
            Le jeu se démarque particulièrement par son esthétique qui est inspirée de jeux rétros, tout en y ajoutant des effets visuels modernes comme de l'éclairage, des normal maps, ainsi que de nombreux effets de particules et de post-traitement.
            Le joueur a de nombreuses capacités de mouvements lui permettant de parcourir l'univers du jeu et de lutter contre des ennemis variés.
        </p>
        <p>
            Ma mission était de développer un ensemble de prototype, puis une vertical slice du jeu, en utilisant le moteur Unity et le langage C#.
        </p>
        <p>
            Étant l'unique programmeur sur ce projet, j'ai communiqué étroitement avec les game designers et les artistes pour comprendre leurs besoins et implémenter leur travail dans le jeu.
            J'étais particulièrement prudent lors de la conception de l'architecture pour permettre un maximum de flexibilité, afin de pouvoir faire évoluer le projet facilement lors des changements de game design.
        </p>
        """,
        ImageUrl = "./images/DiveDeeper.png",
    };
}