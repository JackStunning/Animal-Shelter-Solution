// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using AnimalShelter.Models;

// namespace AnimalShelter.Controllers
// {
//   public class CategoriesController : Controller
//   {
//     [HttpGet("/categories")]
//     public ActionResult Index()
//     {
//       List<Category> allCategories = Category.GetAll();
//       return View(allCategories);
//     }

//     [HttpGet("/categories/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/categories")]
//     public ActionResult Create(string categoryName)
//     {
//       Category newCategory = new Category(categoryName);
//       return RedirectToAction("Index");
//     }

//     [HttpGet("/categories/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Category selectedCategory = Category.Find(id);
//       List<Item> categoryItems = selectedCategory.Items;
//       model.Add("category", selectedCategory);
//       model.Add("animals", categoryItems);
//       return View(model);
//     }

//     // This one creates new Items within a given Category, not new Categories:
//     [HttpPost("/categories/{categoryId}/items")]
//     public ActionResult Create(int animalId, string animalName, string animalGender, string animalDate, string animalBreed)
//     {
//         Dictionary<string, object> model = new Dictionary<string, object>();
//         Category foundCategory = Category.Find(AnimalId);
//         Animal newAnimal = new Animal(animalName, animalGender, animalDate, animalBreed);
//         newAnimal.Save();
//         foundAnimal.AddAnimal(newAnimal);
//         List<Animal> categoryAnimals = foundAnimal.Animals;
//         model.Add("animals", categoryAnimals);
//         model.Add("animals", foundAnimal);
//         return View("Show", model);
//     }
//   }
// }


    
