using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    private int _id;
    private string _name;
    private string _stylist;
    private int _stylistlId;

    public Client(string name, string stylist, int stylistlId, int id = 0)
    {
      _id = id;
      _name = name;
      _stylist = stylist;
      _stylistlId = stylistlId;
    }
  }
}
