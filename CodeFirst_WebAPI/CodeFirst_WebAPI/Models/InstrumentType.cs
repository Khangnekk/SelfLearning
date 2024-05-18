namespace CodeFirst_WebAPI.Models
{
	public class InstrumentType
	{
		public int InstrumentTypeId { get; set; }
		public string Name { get; set; }

		public List<PlayerInstrument> Players { get; set; }
	}
}
