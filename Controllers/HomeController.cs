using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Elijah Dave", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Mang kanoru", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Mike Tyson", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
