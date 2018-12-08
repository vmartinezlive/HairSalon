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
    private int _stylistId;

    public Client(string name, string stylist, int stylistId, int id = 0)
    {
      _id = id;
      _name = name;
      _stylist = stylist;
      _stylistId = stylistId;
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

    public int GetStylistId()
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
      // List<Client> allClients = new List<Client> {newClient};

      List<Client> allClients = new List<Client> {};
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"SELECT * FROM client;";
      // MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      // while(rdr.Read())
      // {
      //   int ClientId = rdr.GetInt32(0);
      //   string ClientName = rdr.GetString(1);
      //   string ClientStylist = rdr.GetString(2);
      //   int ClientStylistId = rdr.GetInt32(3);
      //   Client newClient = new Client(ClientName, ClientStylist, ClientStylistId, ClientId);
      //   allClients.Add(newClient);
      // }
      // conn.Close();
      // if (conn != null)
      // {
      //   conn.Dispose();
      // }
      return allClients;
    }

    // public void Save()
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"INSERT INTO client (name, stylist, client_id) VALUES (@ClientName, @ClientStylist, @StylistId);";
    //
    //   MySqlParameter clientName = new MySqlParameter();
    //   clientName.ParameterName = "@ClientName";
    //   clientName.Value = this._name;
    //   cmd.Parameters.Add(clientName);
    //
    //   MySqlParameter clientStylist = new MySqlParameter();
    //   clientStylist.ParameterName = "@ClientStylist";
    //   clientStylist.Value = this._stylist;
    //   cmd.Parameters.Add(clientStylist);
    //
    //   MySqlParameter stylistId = new MySqlParameter();
    //   stylistId.ParameterName = "@StylistId";
    //   stylistId.Value = this._stylistId;
    //   cmd.Parameters.Add(stylistId);
    //
    //   //Add this command for above 3 lines of code
    //   cmd.Parameters.AddWithValue("@ClientName", this._name);
    //   cmd.Parameters.AddWithValue("@ClientStylist", this._stylist);
    //   cmd.Parameters.AddWithValue("@StylistId", this._stylistId);
    //   cmd.ExecuteNonQuery();
    //   _id = (int) cmd.LastInsertedId;
    //
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
      //To fail Saves to database method - declare method and keep it empty
      //To fail Save AssignsId test -
      //do not add the "_id = (int) cmd.LastInsertedId;" line
    // }

  }
}
