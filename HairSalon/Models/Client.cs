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
    private List<Client> _instance = new List<Client> {};
    private int _stylistId;

    public Client(string name, string stylist, int stylistId, int id = 0)
    {
      _id = -instances.Count;
      _name = name;
      _stylist = stylist;
      _instances.Add(this);
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

    public static List<Client> GetAll()
   {
     return _instances;
   }

    public int GetStylistId()
    {
      return 1;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Client Find(int searchId)
   {
     return _instances[searchId-1];
   }

    // public static List<Client> GetAll()
    // {
    //   List<Client> allClients = new List<Client> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM client;";
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     int clienttId = rdr.GetInt32(0);
    //     string clientName = rdr.GetString(1);
    //     string clientStylist = rdr.GetString(2);
    //     int stylistId = rdr.GetInt32(3);
    //     Client newClient = new Client(clientId, clientName, clientStylist, stylistId);
    //     allclient.Add(newClient);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allClients;
    // }

    //   public override bool Equals(System.Object otherClient)
    // {
    //   if (!(otherClient is Client))
    //   {
    //     return false;
    //   }
    //   else
    //   {
    //     Client newClient = (Client) otherClient;
    //     bool idEquality = (this.GetId() == newClient.GetId());
    //     bool nameEquality = (this.GetName() == newClient.GetName());
    //     bool stylistEquality = (this.GetStylist() == newClient.GetStylist());
    //     bool stylistIdEquality = this.GetStylistId() == newClient.GetStylistId();
    //     return (idEquality && nameEquality && stylistEquality && stylistIdEquality);
    //     //fail the Equals test by not adding the Equals method
    //   }
    // }
   //*****Not on the to do list ******
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
    //   // To fail Saves to database method - declare method and keep it empty
    //   // To fail Save AssignsId test -
    //   // do not add the "_id = (int) cmd.LastInsertedId;" line
    // }
   // *****Not in to do list

   public static void ClearAll()
   {
     MySqlConnection conn = DB.Connection();
     conn.Open();
     var cmd = conn.CreateCommand() as MySqlCommand;
     cmd.CommandText = @"DELETE FROM clients;";
     cmd.ExecuteNonQuery();
     conn.Close();
     if (conn != null)
     {
      conn.Dispose();
     }
   }

   // public static Client Find(int searchId)
   //  {
   //    // Temporarily returning dummy item to get beyond compiler errors, until we refactor to work with database.
   //    Client dummyClient = new Client("dummy client");
   //    return dummyClient;
   //  }


  }
}
