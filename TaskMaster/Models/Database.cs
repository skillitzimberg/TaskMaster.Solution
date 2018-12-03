using System;
using MySql.Data.MySqlClient;
using TaskMaster;

namespace TaskMaster.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
