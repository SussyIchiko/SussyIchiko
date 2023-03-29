﻿using AkaneFoodie.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkaneFoodie.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetRecipeCard([FromBody] List<Recipe> recipes)
        {
            return PartialView("_RecipeCard", recipes);
        }
        public IActionResult Search([FromQuery] string recipe)
        {
            ViewBag.Recipe = recipe;
            return View();
        }
        public IActionResult Order([FromQuery] string id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult ShowOrder([FromBody] OrderRecipeDetails details)
        {
            return PartialView("",details);
        }
    }

}
