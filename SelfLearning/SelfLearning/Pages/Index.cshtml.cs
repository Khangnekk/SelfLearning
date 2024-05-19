using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SelfLearning.Models;

namespace SelfLearning.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public IFormFile FormFile { get; set; }
		private readonly ILogger<IndexModel> _logger;
		private readonly SelfLearningContext _context = new SelfLearningContext();
		public User CurrentUser { get; set; }
		[BindProperty]
		public string Name { get; set; }
		[BindProperty]
		public int Id { get; set; }
		public string Message { get; set; }
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;

		}

		public void OnGet()
		{

		}

		public void OnPostUpdate()
		{
			CurrentUser = _context.Users.FirstOrDefault(u => u.Id == Id);
			if (CurrentUser == null)
			{
				Message = "Not exist";
				return;
			}
		}

		public void OnPostCreateUser()
		{
			CurrentUser = new User
			{
				Name = Name
			};
			var users = _context.Users.Where(u => u.Name == Name).ToList();
			if (users.Count() >= 1)
			{
				Message = "Name Existed";
				CurrentUser = null;
			}
			else
			{
				_context.Users.Add(CurrentUser);
				_context.SaveChanges();
				Message = "Create success";
				Id = _context.Users.FirstOrDefault(u => u.Name == CurrentUser.Name).Id;
				Name = CurrentUser.Name;
			}
		}

		public void OnPostUpdateUser()
		{
			var user = _context.Users.FirstOrDefault(u => u.Id == Id);
			user.Name = Name;
			CurrentUser = user;
			_context.SaveChanges();
		}

		public void OnPostUpdateAvatar()
		{
			if (FormFile != null && FormFile.Length > 0)
			{
				using (var memoryStream = new MemoryStream())
				{
					FormFile.CopyTo(memoryStream);
					var imageByteArray = memoryStream.ToArray();

					// Upload the file if less than 2 MB
					if (memoryStream.Length < 2097152)
					{
						var updateAvatarUser = _context.Users.FirstOrDefault(u => u.Id == Id);

						if (updateAvatarUser == null)
						{
							_logger.LogError($"User with Id {Id} not found.");
							ModelState.AddModelError("FormFile", "User not found.");
							Message = "User not found";
						}
						else
						{
							updateAvatarUser.Avatar = imageByteArray;
							CurrentUser = updateAvatarUser;
							_context.SaveChanges();
							_logger.LogInformation($"User {Id} avatar updated successfully.");
							Message = $"User {Id} avatar updated successfully.";
						}
					}
					else
					{
						ModelState.AddModelError("FormFile", "The file is too large.");
						_logger.LogWarning("The file is too large to be uploaded.");
						Message = "The file is too large to be uploaded.";
					}
				}
			}
			else
			{
				_logger.LogWarning("FormFile is null or empty.");
				ModelState.AddModelError("FormFile", "Please select a file.");
				Message = "Please select a file";
			}
		}


		public IActionResult OnGetUserImage(int userId)
		{
			var user = _context.Users.FirstOrDefault(u => u.Id == userId);
			if (user?.Avatar != null)
			{
				return File(user.Avatar, "image/jpeg");
			}
			return NotFound();
		}


	}
}
