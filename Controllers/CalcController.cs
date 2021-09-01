using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }


        [HttpPost]

        public ActionResult Index(calc c,string calculate)
        {
            if (calculate == "С")
            {
                c.number1= 0;
                c.number2 = 0;
                c.result = 0;
                c.exception = "";
            }

            if (calculate == "add")
            {
                c.result = c.number1 + c.number2;
                c.exception = "";
            }
            else if (calculate == "min")
            {
                c.result = c.number1 - c.number2;
                c.exception = "";

            }
            else if (calculate == "multiplication")
            {
                c.result = c.number1 * c.number2;
                c.exception = "";

            }
            else if (calculate == "division")
            {
                if (c.number2 == 0)
                {
                    c.exception = "На ноль делить нельзя";
                }
                else
                { 
                    c.result = c.number1 / c.number2;
                    c.exception = "";
                }
            }
            return View(c);
        }
    }
}