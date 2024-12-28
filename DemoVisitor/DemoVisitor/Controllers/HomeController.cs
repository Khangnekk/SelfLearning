using DemoVisitor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace DemoVisitor.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly demoVisitorContext _demoVisitorContext;

		public HomeController(ILogger<HomeController> logger, demoVisitorContext demoVisitorContext)
		{
			_logger = logger;
			_demoVisitorContext = demoVisitorContext;
		}

		public IActionResult Index()
		{
			var model = _demoVisitorContext.VisitorContentEmails.ToList();
			var jsonData = JsonSerializer.Serialize(model);
			ViewData["JsonData"] = jsonData;
			return View("./Views/Home/Index.cshtml", model);
		}

		[HttpPost]
		public IActionResult Save([FromBody] List<VisitorContentEmail> data)
		{
			foreach (var item in data)
			{
				var existingRecord = _demoVisitorContext.VisitorContentEmails.Find(item.Id);
				if (existingRecord != null)
				{
					existingRecord.ContentText = item.ContentText;
					existingRecord.LocationIds = item.LocationIds;
					existingRecord.ContentType = item.ContentType;
				}
				else
				{
					_demoVisitorContext.VisitorContentEmails.Add(new VisitorContentEmail
					{
						ContentText = item.ContentText,
						ContentType = item.ContentType,
						LocationIds = item.LocationIds
					});
				}
			}

			_demoVisitorContext.SaveChanges();

			return Json(new { success = true });
		}

		[HttpGet]
		public IActionResult ListAll(int? pageIndex, string? keyword)
		{
			pageIndex ??= 1;
			int pageSize = 10;

			var query = _demoVisitorContext.VisitorContentEmails.AsQueryable();

			if (!string.IsNullOrEmpty(keyword))
			{
				query = query.Where(x => x.ContentText != null && x.ContentText.ToLower().Contains(keyword.ToLower()));
			}

			var totalRecords = query.Count();
			var totalPage = (int)Math.Ceiling(totalRecords / (double)pageSize);

			pageIndex = Math.Max(1, Math.Min(pageIndex.Value, totalPage));

			var lists = query
				.Skip((pageIndex.Value - 1) * pageSize)
				.Take(pageSize)
				.ToList();

			ViewBag.TotalPage = totalPage;
			ViewBag.CurrentPage = pageIndex;
			ViewBag.Keyword = keyword;

			return View("./Views/Home/ListAll.cshtml", lists);
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
