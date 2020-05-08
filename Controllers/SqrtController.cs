using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    public class SqrtController : Controller
    {
       
        [HttpGet]
        public ActionResult Root()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Root(string firstNumber, string secondNumber)
        {
            double firstNum = double.Parse(firstNumber);
            double secondNum = double.Parse(secondNumber);

            double numberOne = Math.Sqrt(firstNum);
            double numberTwo = Math.Sqrt(secondNum);
            double value;

            if (numberOne > numberTwo)
            {
                ViewBag.Result = "Your number " + firstNum + "Square root is " + numberOne +
                    " has a higher square root than the number " + secondNum + "Square root" + numberTwo;
            }
            else if (numberTwo > numberOne)
            {
                ViewBag.Result = "The number " + secondNum + " Square root is " + numberTwo +
                    " has a higher square root than the number " + firstNum + "sSuare root " + numberOne;
            }
            else if (numberOne == numberTwo)
            {
                ViewBag.Result = "First number and the Second number are the same square root, please enter another number";
            }
            else if (firstNum <1 || secondNum <1)
            {
                ViewBag.Result = "You entered a negative number, please try again";
            }
            else if (double.TryParse(firstNumber, out value))
            {
                ViewBag.Result = "Numbers only, please try again";
            }
            return View();
        }
    }
}