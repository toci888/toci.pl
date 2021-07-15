using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toci.Pl.Models.Outsourceing;

namespace Toci.Pl.Controllers
{
    public class OutsourceingController : Controller
    {
        public IActionResult Index()
        {
            
            List<DevsModel> developers = new List<DevsModel>()
            {
                new DevsModel() 
                { 
                    Level = "Junior",
                    Name = "Damian",
                    Technologies = new List<string>() { "C#"}
                },
                new DevsModel()
                {
                    Level = "Middle",
                    Name = "Kacper",
                    Technologies = new List<string>() { "C#", "Python" }
                },
            };


            return View(developers);
        }
    }
}
