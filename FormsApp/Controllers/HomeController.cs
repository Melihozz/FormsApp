using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;



namespace FormsApp.Controllers;

public class HomeController : Controller
{
   
    public HomeController()
    {  
  
    }

    public IActionResult Index(string searchString, string category)
    {
        var products = Repository.Products;

        if (!string.IsNullOrEmpty(searchString))    
        {
            searchString = searchString.ToLower();
            ViewBag.searchString = searchString;
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }

        if (!string.IsNullOrEmpty(category) && category != "0" )
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        //ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        var model = new ProductViewModel
        {
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        
        
        return View(model);
    }



    public IActionResult Privacy()
    {
        return View();
    }


}