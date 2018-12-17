using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instance = new List<Stylist> {};
    private int _id;
    private string _name;
    private List<Client> _clients;
    private int _clientId;


    public Stylist (string name, , int clientId, int id = 0)
    {
      _id = _instance.Add(this);
      _name = name;
      _clientId = clientId;
      _client = new List<Client>{};
    }

    public int GetId()
    {
      return 1;
    }

    public string GetName()
    {
      return "Vicky";
    }

    public int GetClientId()
    {
      return 1;
    }

    public void AddClient(Client client)
    {
      _clients.Add(client);
    }

    public static void ClearAll()
   {
     _instances.Clear();
   }

   public static List<Stylist> GetAll()
    {
      return _instances;
    }

    public static Stylist Find(int searchId)
   {
     return _instances[searchId-1];
   }


    public static List<Client> GetCients()
    {

      //*****not on to do list
      // List<Stylist> allStylists = new List<Stylist> {};
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"SELECT * FROM client;";
      // MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      // while(rdr.Read())
      // {
      //   int stylistId = rdr.GetInt32(0);
      //   string stylistName = rdr.GetString(1);
      //   string stylistClient = rdr.GetString(2);
      //   int clientId = rdr.GetInt32(3);
      //   Stylist newStylist = new Stylist(stylistId, stylistName);
      //   allstylist.Add(newStylist);
      // }
      // conn.Close();
      // if (conn != null)
      // {
      //   conn.Dispose();
      // }
      // return allStylists;
      return _clients;
    }


// *****Not listed on To DO list
  //   public static void ClearAll()
  //   {
  //     MySqlConnection conn = DB.Connection();
  //     conn.Open();
  //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
  //     cmd.CommandText = @"DELETE FROM stylist;";
  //     cmd.ExecuteNonQuery();
  //
  //     conn.Close();
  //     if (conn != null)
  //     {
  //       conn.Dispose();
  //     }
  //   }
  //
  //
  //   public void Save()
  // {
  //   MySqlConnection conn = DB.Connection();
  //   conn.Open();
  //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
  //   cmd.CommandText = @"INSERT INTO stylist (stylistName, stylistClient, clientId) VALUES (@StylistName, @StylistClient, @ClientId);";
  //
  //   MySqlParameter stylistName = new MySqlParameter();
  //   stylistName.ParameterName = "@StylistName";
  //   stylistName.Value = this._name;
  //   cmd.Parameters.Add(stylistName);
  //
  //   MySqlParameter stylistClient = new MySqlParameter();
  //   stylistClient.ParameterName = "@StylistClient";
  //   stylistClient.Value = this._client;
  //   cmd.Parameters.Add(stylistClient);
  //
  //   MySqlParameter clientId = new MySqlParameter();
  //   clientId.ParameterName = "@ClientId";
  //   clientId.Value = this._clientId;
  //   cmd.Parameters.Add(clientId);
  //
  //   //Add this command for above 3 lines of code
  //   cmd.Parameters.AddWithValue("@StylistName", this._name);
  //   cmd.Parameters.AddWithValue("@StylistClient", this._region);
  //   cmd.Parameters.AddWithValue("@ClientId", this._varietalId);
  //   cmd.ExecuteNonQuery();
  //   _id = (int) cmd.LastInsertedId;
  //
  //   conn.Close();
  //   if (conn != null)
  //   {
  //     conn.Dispose();
  //   }
  //
  //   public void Delete()
  //   {
  //     MySqlConnection conn = DB.Connection();
  //     conn.Open();
  //     MySqlCommand cmd = new MySqlCommand("DELETE FROM stylists WHERE id = @StylistId; DELETE FROM stylists_name WHERE stylist_name = @StylistName; DELETE FROM stylists_client WHERE stylist_client = @StylistClient; DELETE FROM stylists_clientId WHERE stylist_clientId = @ClientId", conn);
  //
  //     MySqlParameter stylistIdParameter = new MySqlParameter();
  //     stylistIdParameter.ParameterName = "@StylistId";
  //     stylistIdParameter.Value = this.GetId();
  //     cmd.Parameters.Add(stylistIdParameter);
  //     cmd.ExecuteNonQuery();
  //
  //     MySqlParameter StylistNameParameter = new MySqlParameter();
  //     StylistNameParameter.ParameterName = "@StylistName";
  //     StylistNameParameter.Value = this.GetId();
  //     cmd.Parameters.Add(StylistNameParameter);
  //     cmd.ExecuteNonQuery();
  //
  //     MySqlParameter StylistClientParameter = new MySqlParameter();
  //     StylistClientParameter.ParameterName = "@StylistClient";
  //     StylistClientParameter.Value = this.GetId();
  //     cmd.Parameters.Add(StylistClientParameter);
  //     cmd.ExecuteNonQuery();
  //
  //     MySqlParameter ClientIdParameter = new MySqlParameter();
  //     ClientIdParameter.ParameterName = "@ClientId";
  //     ClientIdParameter.Value = this.GetId();
  //     cmd.Parameters.Add(ClientIdParameter);
  //     cmd.ExecuteNonQuery();
  //
  //     if (conn != null)
  //     {
  //       conn.Close();
  //     }
  //   }
  }
}
