using Microsoft.AspNetCore.Mvc;

public class ResultController : Controller
{
    [HttpGet("result")]
    public ViewResult Result() 
    {
        return View();
    }
}