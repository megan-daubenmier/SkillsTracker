using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>"
                + "<h2>Coding languages to learn:</h2>"
                + "<ol>"
                + "<li>C#</li>"
                + "<li>JavaScript</li>"
                + "<li>Python</li>"
                + "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet]
        public IActionResult Form()
        {
            string form = "<form method='post' action='form'>"
                + "<label for='date'>Date:<br></label>"
                + "<input type='date' name='date' value='mm/dd/yyyy'>"
                + "<br><label for='cSharpLevel'>C#:<br></label>"
                + "<select name='cSharpLevel'>"
                + "<option value='learning basics'>learning basics</option>"
                + "<option value='making apps'>making apps</option>"
                + "<option value='master coder'>master coder</option>"
                + "</select>"
                + "<br><label for='javaScript'>JavaScript:<br></label>"
                + "<select name='javaScriptLevel'>"
                + "<option value='learning basics'>learning basics</option>"
                + "<option value='making apps'>making apps</option>"
                + "<option value='master coder'>master coder</option>"
                + "</select>"
                + "<br><label for='pythonLevel'>Python:<br></label>"
                + "<select name='pythonLevel'>"
                + "<option value='learning basics'>learning basics</option>"
                + "<option value='making apps'>making apps</option>"
                + "<option value='master coder'>master coder</option>"
                + "</select>"
                + "<br><br><button>Submit</Button>";

            return Content(form, "text/html");

        }

        [HttpPost("skills/form")]
        public IActionResult Submit(string date, string cSharpLevel, string javaScriptLevel, string pythonLevel)
        {
            string html = "<h1>" + date + "</h1>"
                + "<h2>Coding languages to learn:</h2>"
                + "<ol>"
                + "<li>C#: " + cSharpLevel + "</li>"
                + "<li>JavaScript: " + javaScriptLevel + "</li>"
                + "<li>Python: " + pythonLevel + "</li>"
                + "</ol>";
            return Content(html, "text/html");
        }
    }
}
