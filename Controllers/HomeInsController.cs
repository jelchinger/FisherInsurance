using Microsoft.AspNetCore.Mvc;

public class HomeInsController : Controller

{
    public IActionResult Index() 
    {
        return Ok("This is the index of the HomeInsController");
    }

    public IActionResult Quote() 
    {
        return Ok("Quote");
    }
}
