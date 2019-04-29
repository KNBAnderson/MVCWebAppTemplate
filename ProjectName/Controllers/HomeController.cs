using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {

    [Route("/input")]
    public ActionResult Input() { return View(); }

    [Route("/output")]
    public ActionResult Output(string recipient, string sender)
    {
      ProjectVariable myProjectVariable = new ProjectVariable();
      myProjectVariable.SetRecipient(recipient);
      myProjectVariable.SetSender(sender);
      return View(myProjectVariable);
    }

  }
}
