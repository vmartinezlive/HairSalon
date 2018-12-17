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


    public Stylist (string name, int clientId, int id = 0)
    {
      _name = name;
      _instances.add(this);
      _id = _instance.Count;
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

      return _clients;
    }

  }
}
