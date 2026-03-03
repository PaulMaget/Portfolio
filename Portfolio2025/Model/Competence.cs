using MudBlazor;
using System.Runtime.CompilerServices;

namespace Portfolio.Model;

public record Competence
{
    public required string Name { get; set; }
	public required string Logo { get; set; }
	public required string HtmlDescription { get; set; }
	public required CompetenceCategory Category { get; set; }
}

public enum CompetenceCategory
{
	Languages,
	Frameworks,
    Tools,
    Other,
}

public static class CompetenceExtensions
{
	public static string GetName(this CompetenceCategory category) {
		return category switch {
			CompetenceCategory.Languages => "Langages",
			CompetenceCategory.Frameworks => "Frameworks",
			CompetenceCategory.Tools => "Outils",
			CompetenceCategory.Other => "Autres technologies",
			_ => "",
		};
	}

    public static int GetId(this Competence competence)
    {
        return Competences.All.Select((c, i) => new { c, i })
            .FirstOrDefault(x => x.c == competence)?.i ?? -1;
    }
}

public static class Competences
{
	public static List<Competence> All => [CSharp, JavaScript, Php, Java, Cpp, NetCore, Angular, Symfony, Unity, RabbitMq, SignalR, Docker];

    public static Competence CSharp { get; } = new()
    {
        Name = "C#",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png",
        HtmlDescription = """
            J'ai initialement appris le C# en autodidacte pour utiliser Unity.<br>
            Je suis activement le développement du langage et de l'écosystème .Net.<br>
            J'ai eu l'occasion de travailler professionnellement avec C# dans le cadre de mon stage et de mon alternance de BUT.
            """,
        Category = CompetenceCategory.Languages,
    };

	public static Competence JavaScript { get; } = new()
	{
        Name = "JavaScript",
		Logo = "https://lh3.googleusercontent.com/proxy/nuWxyZIEBmlwkLPiIpq_bJ4eXDw9uozT2D6WSBxvR4NYB3bMZ9T1TrYNao1zQL9MivRNV33D9QeJiDbVManBCLt2Yw8muTBeeOF3ghlbhT2NiQFFScHqgFbwGqFMTKHop6gMf6jQz9kqkPH42mdpaJcx",
        HtmlDescription = """
			J'ai appris le JavaScript pendant mon BUT.<br>
			Je l'ai utilisé dans plusieurs projets universitaires, en vanilla et avec le framework Angular.
			""",
		Category = CompetenceCategory.Languages,
	};

    public static Competence Php { get; } = new()
    {
        Name = "Php",
        Logo = "https://images.seeklogo.com/logo-png/10/2/php-logo-png_seeklogo-108600.png",
        HtmlDescription = """
			J'ai appris le PHP dans le cadre de mon BUT.<br>
			Je l'ai utilisé dans plusieurs projets universitaires, notamment avec le framework Symfony.
			""",
        Category = CompetenceCategory.Languages,
    };

    public static Competence Java { get; } = new()
    {
        Name = "Java",
        Logo = "./images/Java.png",
        HtmlDescription = """
			J'ai appris le Java dans le cadre de mon BUT.
			Je l'ai utilisé dans plusieurs projets universitaires.
			""",
        Category = CompetenceCategory.Languages,
    };

    public static Competence Cpp { get; } = new()
    {
        Name = "C++",
        Logo = "./images/Cpp.png",
        HtmlDescription = """
			J'ai appris le C++ dans le cadre de mon BUT.
			""",
        Category = CompetenceCategory.Languages,
    };

    public static Competence NetCore { get; } = new()
    {
        Name = ".Net Core",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png",
        HtmlDescription = """
			J'ai appris .Net en autodidacte avant de l'utiliser avec ASP .Net pendant mon stage et mon alternance de BUT.<br>
			Je suis passionné par l'écosystème .Net et je continue à apprendre et à expérimenter avec les possibilités qu'il offre.
			""",
        Category = CompetenceCategory.Frameworks,
    };

    public static Competence Angular { get; } = new()
	{
        Name = "Angular",
		Logo = "https://brandlogos.net/wp-content/uploads/2025/04/angular_icon-logo_brandlogos.net_jn7wi-512x542.png",
		HtmlDescription = """
			J'ai appris Angular dans le cadre de mon BUT.<br>
			Je l'ai utilisé dans un projet universitaire, avec une base de données Firebase.
			""",
		Category = CompetenceCategory.Frameworks,
	};

    public static Competence Symfony { get; } = new()
    {
        Name = "Symfony",
        Logo = "./images/Symfony.png",
        HtmlDescription = """
            J'ai commencé à apprendre Symfony en autodidacte pour un projet universitaire.<br>
            J'ai ensuite eu des cours sur ce framework dans le cadre de mon BUT.
            """,
        Category = CompetenceCategory.Frameworks,
    };

    public static Competence Unity { get; } = new()
    {
        Name = "Unity",
        Logo = "https://cdn-icons-png.flaticon.com/512/5969/5969346.png",   // ./images/Unity.png
        HtmlDescription = """
            J'apprends et je suis le développement d'Unity depuis 2019.<br>
            J'ai eu l'occasion de participer à des Game Jams en 2023 et 2024.<br>
            Les jeux développés sont disponibles sur mon <a class="default-link" href="https://poldev.itch.io/">Itch.io</a>.
            """,
        // J'expérimente avec le moteur pour comprendre ses fonctionnalités, ses bonnes pratiques
        // et je développe des outils visant à améliorer la rapidité de développement.<br>
        Category = CompetenceCategory.Tools,
    };

    public static Competence RabbitMq { get; } = new()
    {
        Name = "RabbitMQ",
        Logo = "./images/RabbitMQ.png",
        HtmlDescription = """
			J’ai appris RabbitMQ pendant mon alternance de BUT.<br>
			J’ai conçu et implémenté une topologie pour faire communiquer une borne de vente avec un serveur distant.
			""",
        Category = CompetenceCategory.Other,
    };

    public static Competence SignalR { get; } = new()
    {
        Name = "SignalR",
        Logo = "https://sofa1.at/wp-content/uploads/2023/03/SignalR-Logo.png",
        HtmlDescription = """
            J’ai appris SignalR pendant mon alternance de BUT.<br>
            Je l’ai utilisé pour mettre en place une communication par événements entre des applications backend et frontend.
            """,
        Category = CompetenceCategory.Other,
    };

    public static Competence Docker { get; } = new()
    {
        Name = "Docker",
        Logo = "./images/Docker.png",
        HtmlDescription = """
            J’ai appris Docker dans le cadre de mon BUT.
            """,
        Category = CompetenceCategory.Other,
    };
}