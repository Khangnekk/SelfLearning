namespace CodeFirst_WebAPI.DTO.PlayerInstrument
{
	public class CreatePlayerInstrumentRequest
	{
		public int PlayerInstrumentId { get; set; }
		public int PlayerId { get; set; }
		public int InstrumentTypeId { get; set; }
		public string ModelName { get; set; }
		public string Level { get; set; }
	}
}
