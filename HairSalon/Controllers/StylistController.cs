using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;
using System;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    [HttpGet("/stylists")]
    public ActionResult Index()
    {
      List<Stylist> allStylists = Stylist.GetAll();
      return View(allStylists);
    }

    [HttpGet("/stylists/new")]
   public ActionResult New()
   {
     return View();
   }

   [HttpPost("/stylists")]
   public ActionResult Create(string stylistName)
   {
     Stylist newStylist = new Stylist(stylistName);
     List<Stylist> allStylists = Stylist.GetAll();
     return View("Index", allStylists);
   }


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

    [HttpPost("/stylists/{stylistId}/clients")]
    public ActionResult Create(int stylistId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(stylistId);
      Client newClient = new Client(itemDescription);
      newClient.Save();
      foundStylist.AddClient(newClient);
      List<Client> stylistClients = foundStylist.GetClients();
      model.Add("client", stylistClients);
      model.Add("stylist", foundStylist);
      return View("Show", model);
    }

  }
}
