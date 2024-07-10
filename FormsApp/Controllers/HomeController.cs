using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.EntityFrameworkCore;



namespace FormsApp.Controllers;

public class HomeController : Controller
{
   
    public HomeController()
    {  
  
    }

    public IActionResult Index(string searchString)
    {
        var products = Repository.Products;

        if (!string.IsNullOrEmpty(searchString))
        {
            searchString = searchString.ToLower();

            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }
        return View(products);
    }



    public IActionResult Privacy()
    {
        return View();
    }


}