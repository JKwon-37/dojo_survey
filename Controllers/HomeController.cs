using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index() 
    {
        return View();
    }

    [HttpPost("/method")]
    public RedirectToActionResult Method(string Name, string Location, string Language, string Comments)
    {
        return RedirectToAction("Result", new
        {
            Name = Name,
            Location = Location,
            Language = Language,
            Comments = Comments
        });
    }

    [HttpGet("/result")]
    public ViewResult Result (string Name, string Location, string Language, string Comments)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comments = Comments;
        return View("Result");
    }


}