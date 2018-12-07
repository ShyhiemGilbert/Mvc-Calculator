using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Mvc_Calculator.Controllers
{
	public class Control_calcController : Controller
	{
		// GET: Control_calc
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Total()
		{
			return View();
		}

		//For when calculate button is pressed
		[HttpPost]
		public ActionResult Total(int value1, int value2, String calci)
		{
			int Total = 0;
			switch(calci)
			{
				case "+":
					Total = value1 + value2;
					break;
				case "-":
					Total = value1 - value2;
					break;
				case "*":
					Total = value1 * value2;
					break;
				case "/":
					Total = value1 / value2;
					break;
				//case "^":
				//	Total = (int)Math.Pow(value1,value2);
				//	break;
				//case "%":
				//	Total = value1 % value2;
				//	break;
				default:
					break;
			}
			return Content("The Answer Is" + " "+ Total);

		}
	}
}