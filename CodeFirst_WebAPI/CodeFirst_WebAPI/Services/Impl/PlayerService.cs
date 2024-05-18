using CodeFirst_WebAPI.Context;
using CodeFirst_WebAPI.DTO.Player;
using CodeFirst_WebAPI.DTO.PlayerInstrument;
using CodeFirst_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_WebAPI.Services.Impl
{
	public class PlayerService : IPlayerService
	{
		private readonly CodeFirstDemoContext _context;

		public PlayerService(CodeFirstDemoContext context)
		{
			_context = context ?? new CodeFirstDemoContext();
		}

		public async Task CreatePlayerAsync(CreatePlayerRequest request)
		{
			if (request != null)
			{
				List<PlayerInstrument> playerInstruments = new List<PlayerInstrument>();
				// Sau nay se toi uu code bang AutoMapper, noi dung cua bai nay chi noi ve codefirst va webapi
				foreach (var item in request.playerInstrumentRequests)
				{
					playerInstruments.Add(new PlayerInstrument
					{
						Level = item.Level,
						ModelName = item.ModelName,
						PlayerId = item.PlayerId,
						InstrumentTypeId = item.InstrumentTypeId,
					});
				}
				Player player = new Player
				{
					NickName = request.NickName,
					Instruments = playerInstruments
				};

				_context.Players.Add(player);
				_context.SaveChangesAsync();
			}
		}

		public async Task<bool> DeletePlayerAsync(int id)
		{
			Player player = _context.Players.FirstOrDefault(p => p.PlayerId == id);
			if (player == null)
			{
				return false;
			}
			else
			{
				_context.Players.Remove(player);
				_context.SaveChangesAsync();
				return true;
			}
		}

		public async Task<List<GetPlayerResponse>> GetPlayerAsync()
		{
			List<Player> players = _context.Players.Include(x => x.Instruments).ToList();
			List<GetPlayerResponse> getPlayerResponses = new List<GetPlayerResponse>();
			// Sau nay se toi uu code bang AutoMapper, noi dung cua bai nay chi noi ve codefirst va webapi
			foreach (var player in players)
			{
				getPlayerResponses.Add(
					new GetPlayerResponse
					{
						InstrumentSubmittedCount = player.Instruments.Count,
						NickName = player.NickName,
						JoinedDate = player.JoinedDate,
						PlayerId = player.PlayerId
					}
					);
			}
			return getPlayerResponses;
		}

		public async Task<GetPlayerDetailResponse> GetPlayerDetailAsync(int id)
		{
			Player players = _context.Players.Include(x => x.Instruments).FirstOrDefault(p => p.PlayerId == id);
			List<GetPlayerInstrumentResponse> playerInstrumentResponses = new List<GetPlayerInstrumentResponse>();
			foreach (var instrument in players.Instruments)
			{
				playerInstrumentResponses.Add(new GetPlayerInstrumentResponse
				{
					InstrumentTypeId = instrument.InstrumentTypeId,
					Level = instrument.Level,
					ModelName = instrument.ModelName,
				});
			}
			GetPlayerDetailResponse getPlayerDetailResponse = new GetPlayerDetailResponse
			{
				NickName = players.NickName,
				JoinedDate = players.JoinedDate,
				PlayerInstrumentResponses = playerInstrumentResponses
			};

			return getPlayerDetailResponse;
		}

		public async Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest updatePlayerRequest)
		{
			Player player = _context.Players.FirstOrDefault(p => p.PlayerId == id);
			if (player != null)
			{
				player.NickName = updatePlayerRequest.NickName;
				_context.Players.Update(player);
				_context.SaveChangesAsync();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
