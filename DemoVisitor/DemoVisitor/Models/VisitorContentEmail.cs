namespace DemoVisitor.Models
{
	public sealed class VisitorContentEmail
	{
		public int Id { get; set; }
		public int ContentType { get; set; }
		public string ContentText { get; set; } = null!;
		public string LocationIds { get; set; } = null!;
	}
}
