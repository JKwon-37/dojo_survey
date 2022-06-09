using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index() 
    {
        return View();
    }

    [HttpPost("/method")]
    public RedirectToActionResult Method()
    {
        return RedirectToAction("Result", "Result");
    }

    [HttpGet("/result")]
    public ViewResult Result ()
    {
        return View();
    }


}