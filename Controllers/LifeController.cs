using Microsoft.AspNetCore.Mvc;

using FisherInsurance.Models;

public class LifeController : Controller

{
    public IActionResult Index() 
    {
        return Ok("This is the index of the LifeController");
    }

    public IActionResult Quote() 
    {
        Quote quote = new Quote

        {

            Id = 345,

            Product = "Life Insurance",

            ExpireDate = System.DateTime.Now.AddDays(45),

            Price = 45.00M

        };
        
        return View(quote);
    }
}
