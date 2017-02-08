using Microsoft.AspNetCore.Mvc;

using FisherInsurance.Models;

public class HomeInsController : Controller

{
    public IActionResult Index() 
    {
        return Ok("This is the index of the HomeInsController");
    }

    public IActionResult Quote() 
    {
        Quote quote = new Quote

        {

            Id = 345,

            Product = "Home Insurance",

            ExpireDate = System.DateTime.Now.AddDays(45),

            Price = 45.00M

        };
        
        return View(quote);
    }
}
