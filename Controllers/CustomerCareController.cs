using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller

{
    public IActionResult Index() 
    {
        return Ok("This is the index of the CustomerCareController");
    }

    [Route("Claims")]
    public IActionResult Quotes() 
    {
        return Ok("Claims");
    }

    [Route("Claims/fileclaim")]
    public IActionResult NewClaim() 
    {
        return Ok("NewClaim");
    }

    [Route("Claims/myclaims")]
    public IActionResult ClaimHistory() 
    {
        return Ok("ClaimHistory");
    }
}
