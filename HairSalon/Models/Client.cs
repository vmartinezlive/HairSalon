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

    public int GetId()
    {
      return 1;
    }

    public string GetName()
    {
      return "Vicky";
    }

    public string GetStylist()
    {
      return "Tanvi";
    }

    public int GetStylistlId()
    {
      return 1;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM client;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<Client> GetAll()
    {
      // Client newClient = new Client("anystring", "clientName", "ClientStylist", ClientStylistId, ClientId);
      // List<Client> allClients = new List<Client> {newClient};  **How to fail**

      List<Client> allClients = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM client;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int ClientId = rdr.GetInt32(0);
        string ClientName = rdr.GetString(1);
        string ClientStylist = rdr.GetString(2);
        int ClientStylistId = rdr.GetInt32(3);
        Client newClient = new Client(ClientName, ClientStylist, ClientStylistId, ClientId);
        allClients.Add(newClient);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allClients;
    }

  }
}
