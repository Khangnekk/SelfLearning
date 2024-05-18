using CodeFirst_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_WebAPI.Context
{
	public static class DbSeeder
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<InstrumentType>().HasData(
				new InstrumentType
				{
					InstrumentTypeId = 1,
					Name = "Acoustic Guitar",
				},
				new InstrumentType
				{
					InstrumentTypeId = 2,
					Name = "Electric Guitar",
				},
				new InstrumentType
				{
					InstrumentTypeId = 3,
					Name = "Drums",
				},
				new InstrumentType
				{
					InstrumentTypeId = 4,
					Name = "Bass",
				},
				new InstrumentType
				{
					InstrumentTypeId = 5,
					Name = "Keyboard",
				}
				);
			modelBuilder.Entity<Player>().HasData(
				new Player
				{
					PlayerId = 1,
					NickName = "Khang",
					JoinedDate = DateTime.Now
				},
				new Player
				{
					PlayerId = 2,
					NickName = "Hoang",
					JoinedDate = DateTime.Now
				}
				);
			modelBuilder.Entity<PlayerInstrument>().HasData(
				new PlayerInstrument
				{
					PlayerInstrumentId = 1,
					InstrumentTypeId = 1,
					PlayerId = 1,
					Level = "Good",
					ModelName = "Gui"
				},
				new PlayerInstrument
				{
					PlayerInstrumentId = 2,
					InstrumentTypeId = 1,
					PlayerId = 2,
					Level = "Good",
					ModelName = "Gui"
				},
				new PlayerInstrument
				{
					PlayerInstrumentId = 3,
					InstrumentTypeId = 2,
					PlayerId = 2,
					Level = "Good",
					ModelName = "Gui"
				}
				);
		}
	}
}
