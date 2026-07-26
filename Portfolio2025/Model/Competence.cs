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
	public static List<Competence> All => [CSharp, Cpp, JavaScript, Php, Java, NetCore, Angular, Symfony, Qt, OpenGL, Unity, RabbitMq, SignalR, Docker];

    public static Competence CSharp { get; } = new()
    {
        Name = "C#",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/960px-Logo_C_sharp.svg.png",
        HtmlDescription = """
            J'ai initialement appris le C# en autodidacte pour utiliser Unity.<br>
            Je suis activement l'évolution du langage et de l'écosystème .Net.<br>
            J'ai eu l'occasion de travailler professionnellement avec le C# dans le cadre de mon stage et de mon alternance de BUT, ainsi que mon stage de Master.
            """,
        Category = CompetenceCategory.Languages,
    };

	public static Competence JavaScript { get; } = new()
	{
        Name = "JavaScript",
		Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/JavaScript-logo.png/960px-JavaScript-logo.png",
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
			J'ai appris le Java dans le cadre de mon BUT, puis en Master.<br>
			Je l'ai utilisé dans de nombreux projets universitaires.
			""",
        Category = CompetenceCategory.Languages,
    };

    public static Competence Cpp { get; } = new()
    {
        Name = "C++",
        Logo = "./images/Cpp.png",
        HtmlDescription = """
            J'ai initialement appris le C++ dans le cadre de mon BUT.<br>
            J'ai ensuite revu le langage plus en profondeur pendant mon Master, notamment pour du développement OpenGL
            et lors d'un projet universitaire avec le framework Qt.
            """,
        Category = CompetenceCategory.Languages,
    };

    public static Competence NetCore { get; } = new()
    {
        Name = ".Net Core",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/3840px-.NET_Core_Logo.svg.png",
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

    public static Competence Qt { get; } = new()
    {
        Name = "Qt",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Qt_logo_2016.svg/1280px-Qt_logo_2016.svg.png",
        HtmlDescription = """
            J'ai appris Qt pendant mon Master.<br>
            Je l'ai utilisé pour développer des applications desktop dans le cadre de projets universitaires.
            """,
        Category = CompetenceCategory.Frameworks,
    };

    public static Competence OpenGL { get; } = new()
    {
        Name = "OpenGL",
        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/OpenGL_logo.svg/3840px-OpenGL_logo.svg.png",
        HtmlDescription = """
            J'ai appris OpenGL pendant mon Master, après une petite introduction à WebGL en BUT.<br>
            Je l'ai utilisé avec du C++ dans le cadre de travaux pratiques de génération de maillages et de développement de shaders avec GLSL.
            """,
        Category = CompetenceCategory.Frameworks,
    };

    public static Competence Unity { get; } = new()
    {
        Name = "Unity",
        Logo = "https://cdn-icons-png.flaticon.com/512/5969/5969346.png",
        HtmlDescription = """
            J'apprends et je suis l'évolution de Unity depuis 2019.<br>
            J'ai eu l'occasion de participer à des Game Jams en 2023 et 2024.<br>
            Les jeux développés sont disponibles sur mon <a class="default-link" href="https://poldev.itch.io/">Itch.io</a>.
            J'ai eu l'occasion de travailler professionnellement avec Unity dans le cadre de mon stage de Master.
            """,
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
        Logo = "https://ilovedotnet.org/image/icons/signalr.webp",
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
            J’ai appris Docker dans le cadre de mon BUT.<br>
            Je l'ai utilisé dans des projets universitaires de contenarisation d'application.
            """,
        Category = CompetenceCategory.Other,
    };
}