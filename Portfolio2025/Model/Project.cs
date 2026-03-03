namespace Portfolio.Model;

public record Project
{
	public required string Name { get; init; }
	public required string Organization { get; init; }
	public required string Year { get; init; }
	public required string ShortHtmlDescription { get; init; }
	public required string HtmlDescription { get; init; }
}

public static class Projects
{
	public static Project Test => new() {
		Name = "test",
		Organization = "",
		Year = "",
		ShortHtmlDescription = "",
		HtmlDescription = ""
	};
}
