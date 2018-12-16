using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Stylist
  {
    private int _id;
    private string _name;
    private string _client;
    private List<Client> _client;
    private int _clientId;


public Stylist (string name, string client, int id = 0)
{
  _id = id;
  _name = name;
  _client = client;
  _clientId = clientId;
}

public int GetId()
{
  return 1;
}

public string GetName()
{
  return "Vicky";
}

public string GetClient()
{
  return "Tanvi";
}

public int GetClientId()
{
  return 1;
}

public static List<Client> GetAll()
{
  List<Client> allClients = new List<Client> {};
  MySqlConnection conn = DB.Connection();
  conn.Open();
  MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
  cmd.CommandText = @"SELECT * FROM client;";
  MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
  while(rdr.Read())
  {
    int stylistId = rdr.GetInt32(0);
    string stylistName = rdr.GetString(1);
    string stylistClient = rdr.GetString(2);
    int clientId = rdr.GetInt32(3);
    Stylist newStylist = new Stylist(stylistId, stylistName);
    allstylist.Add(newStylist);
  }
  conn.Close();
  if (conn != null)
  {
    conn.Dispose();
  }
  return allClients;
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
