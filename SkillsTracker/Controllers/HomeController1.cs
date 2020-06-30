using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        private string SelectBox(string name, string label)
        {
            return $"<label>{label}" +
                        $"<select name='{name}'>" +
                            "<option>--Select--</option>" +
                            "<option value='1'>Still Learning</option>" +
                            "<option value='2'>Makeing Apps</option>" +
                            "<option value='2'>I'm a Guru</option>" +
                        "</select>" +
                    "</label>";
        }
        /*public static string CreateMessage(string skills, string name)
        {
            string result = $"Hello {name}.";

            if (skills == "Spanish")
                result = $"Holla {name}.";

            if (skills == "French")
                result = $"Bonjour {name}.";

            if (skills == "Portuguese")
                result = $"Olá {name}.";

            if (skills == "Greek")
                result = $"Χαίρετε {name}.";

            return result;
        }*/

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            string html = "<form method='post' action='/skills'>" +
                "<h1>Date</h1>" +
                "<input type='date' name='mm/dd/yyyy' />" +
                "<h1>C#</h1>" +
                SelectBox("C#","Skill Level") +
                "<h1>Java</h2>"+
                SelectBox("Java", "Skill Level") +
                                "<h1>Java</h2>" +
                SelectBox("Java", "Skill Level") +


                /*
                "<h1>Python</h1>" +
                "<select name='Skill Level'>" +
                "<option value='Basic'>Learning Basics</option>" +
                "<option value=''>Building Apps</option>" +
                "<option value='Master'>Mastered the Language, I'm a Guru.</option>" +
                "<h1>F#</h1>" +
                "<select name='Skill Level'>" +
                "<option value='Basic'>Learning Basics</option>" +
                "<option value=''>Building Apps</option>" +
                "<option value='Master'>Mastered the Language, I'm a Guru.</option>" +
                */

                "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html"); ;
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        //[HttpGet]
        // POST: /<controller>/welcome
        //if()
       /* [HttpGet("welcome/{name?}")]

        [HttpPost]
        public IActionResult Welcome(string skills = "", string name = "World")
        {
            //return Content(CreateMessage(skills, name), "text/html");
        }
       */
    }
}

