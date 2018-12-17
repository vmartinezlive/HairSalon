using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {

    [HttpGet("/stylists/{stylistyId}/clients/new")]
   public ActionResult New(int stylistId)
   {
      Stylist stylist = Stylist.Find(stylistId);
      return View(stylist);
   }

   [HttpGet("/stylists/{stylistyId}/clients/{clientsId}")]
   public ActionResult Show(int stylistId, int clientId)
   {
     Client client = Client.Find(clientId);
     Dictionary<string, object> model = new Dictionary<string, object>();
     Stylist stylist = Stylist.Find(stylistId);
     model.Add("item", client);
     model.Add("stylist", stylist);
     return View(model);
   }

   [HttpPost("/clients/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }


  }
}
