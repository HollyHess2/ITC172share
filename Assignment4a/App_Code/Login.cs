using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; //allow comm with sql server
using System.Configuration;  //allow comm with web config file where the connection string is

/// <summary>
/// Summary description for Login
/// </summary>
public class Login
{
    SqlConnection connect;
    public Login()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }

    public int validateLogin(string user, string pass)
    {
        int result = 0;
        PasswordHash ph = new PasswordHash();
        string sql = "Select PersonKey, Personpasskey, PersonUserPassword from Person where PersonUsername=@User";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.Add("@User", user);

        SqlDataReader reader;
        int passCode = 0;
        Byte[] originalPassword = null;
        int personKey = 0;

        connect.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                passCode = (int)reader["Personpasskey"];
                originalPassword = (Byte[])reader["PersonUserPassword"];
                personKey = (int)reader["PersonKey"];
            }


            byte[] newHash = ph.HashIt(pass, passCode.ToString());
            if (newHash.SequenceEqual(originalPassword))
            {
                result = personKey;
            }

        }
        return result;
    }
}