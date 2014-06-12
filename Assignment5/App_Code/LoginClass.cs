using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; //allow comm with sql server
using System.Configuration;  //allow comm with web config file where the connection string is

/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    string user;
    string pass;
    int personkey = 0;
    Byte[] hashed;
    CommunityAssistEntities ent = new CommunityAssistEntities();

    public LoginClass(string userName, string pWord)
    {
        user = userName;
        pass = pWord;
        //System.Diagnostics.Debug.WriteLine(user);
    }

    //get the passcode from the database
    private int GetPassCode()
    {
        int passcode = 0;
        //this is linq syntax for a query
        var code = from c in ent.People
                   where c.PersonUsername == user
                   select new { c.PersonKey, c.Personpasskey, c.PersonUserPassword };
        //we loop through the result and assign some values
        foreach (var v in code)
        {
            passcode = (int)v.Personpasskey;
            personkey = (int)v.PersonKey;
            hashed = (Byte[])v.PersonUserPassword;
        }
        return passcode;
    }
    // this method hashes the password and matches the database hash
    //to the new hash
    public int Authenticate()
    {
        int passcode = GetPassCode();
        PasswordHash ph = new PasswordHash();
        Byte[] newHash = ph.HashIt(pass, passcode.ToString());
        int pk = 0;

        if (hashed.SequenceEqual(newHash))
        {
            pk = personkey;
        }

        return pk;
    }
}

    
