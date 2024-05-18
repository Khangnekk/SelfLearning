using CodeFirst_WebAPI.DTO.Player;
using CodeFirst_WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst_WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlayerController : ControllerBase
	{
		private readonly IPlayerService playerService;

		public PlayerController(IPlayerService playerService)
		{
			this.playerService = playerService;
		}
		[HttpGet]
		public async Task<IActionResult> GetPlayerAsync()
		{
			var data = await playerService.GetPlayerAsync();
			return Ok(data);
		}
		[HttpGet("{id:long}/detail")]
		public async Task<IActionResult> GetActionResultAsync(int id)
		{
			var data = await playerService.GetPlayerDetailAsync(id);
			return Ok(data);
		}
		[HttpPost]
		public async Task<IActionResult> PostPlayerAsync([FromBody] CreatePlayerRequest playerRequest)
		{
			var data = playerService.CreatePlayerAsync(playerRequest);
			return Ok(data);
		}
		[HttpPut]
		public async Task<IActionResult> PutPlayerAsync(int id, [FromBody] UpdatePlayerRequest playerRequest)
		{
			var data = playerService.UpdatePlayerAsync(id, playerRequest);
			return Ok(data);
		}
		[HttpDelete("{id:long}")]
		public async Task<IActionResult> DeletePlayerAsync(int id)
		{
			var data = playerService.DeletePlayerAsync(id);
			return Ok(data);
		}
	}
}
