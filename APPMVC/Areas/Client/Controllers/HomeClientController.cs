﻿using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Client.Controllers
{
	[Area("Client")]
	public class HomeClientController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}