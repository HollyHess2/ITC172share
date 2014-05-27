using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManageContributor
/// </summary>
public class ManageContributor
{
	//Customer c;
    //int id;
    SqlConnection connect;

	public ManageContributor(/*int customerID*/)
	{
       
        //id=customerID;
        //Customer cust;
        connect = new SqlConnection
            (ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
	}

    /*private SqlCommand WritePerson()
    {
    string sqlPerson = "Insert into Person (LastName, FirstName) Values (@LastName, @FirstName)";
    SqlCommand personCmd = new SqlCommand(sqlPerson, connect);
    personCmd.Parameters.AddWithValue("@LastName", c.LastName);
    personCmd.Parameters.AddWithValue("@FirstName", c.FirstName);
     return personCmd;
    }*/

    public void WriteContributor(NewContributor ncont)
    {
        //this.cust=c;
        //SqlTransaction tran = null;
        //SqlCommand pCmd = WritePerson();
        string sqlPerson = "Insert into Person (PersonLastName, PersonFirstName, PersonUsername, PersonPlainPassword, Personpasskey, PersonUserPassword) "+
            "Values (@LastName, @FirstName, @Username, @PlainPW, @PersonPassKey, @PersonUserPassword)";
        string sqlPersonAddress = "Insert into PersonAddress (Street, City, State, Zip, PersonKey) "+
            "Values(@Street, @City, @State, @Zip, ident_Current('Person'))";
        //string sqlRegisteredCustomer = "Insert into customer.RegisteredCustomer(Email, CustomerPassCode, CustomerPassword, CustomerHashedPassword, PersonKey) " +
            //"Values(@Email, @Passcode, @password, @hashedpass, ident_Current('Person'))";

        PasscodeGenerator pg = new PasscodeGenerator();
        PasswordHash ph = new PasswordHash();
        int passcode = pg.GetPasscode();

        SqlCommand newContributorCmd = new SqlCommand(sqlPerson, connect);
        newContributorCmd.Parameters.AddWithValue("@LastName", ncont.lastName);
        newContributorCmd.Parameters.AddWithValue("@FirstName", ncont.firstName);
        newContributorCmd.Parameters.AddWithValue("@Username", ncont.email);
        newContributorCmd.Parameters.AddWithValue("@PlainPW", ncont.plainTextPassword);
        newContributorCmd.Parameters.AddWithValue("@PersonPassKey", passcode);
        newContributorCmd.Parameters.AddWithValue("@PersonUserPassword", ph.HashIt(ncont.plainTextPassword, passcode.ToString()));

        //SqlCommand regCustomerCmd = new SqlCommand(sqlRegisteredCustomer, connect);
        //regCustomerCmd.Parameters.AddWithValue("@Passcode", passcode);
        //regCustomerCmd.Parameters.AddWithValue("@password", c.PlainPassword);
        //regCustomerCmd.Parameters.AddWithValue("@hashedpass", ph.HashIt(c.PlainPassword, passcode.ToString()));

        SqlCommand personAddressCmd = new SqlCommand(sqlPersonAddress, connect);
        personAddressCmd.Parameters.AddWithValue("@Street", ncont.streetAddress);
        personAddressCmd.Parameters.AddWithValue("@City", ncont.city);
        personAddressCmd.Parameters.AddWithValue("@State", ncont.state);
        personAddressCmd.Parameters.AddWithValue("@Zip", ncont.postalCode);


        connect.Open();
        //try { 
        //tran = commenct.BeginTransation();
        //pCmd.Transaction = tran;
        //pCmd.ExecuteNonQuery();
        //tran.Commit();
        newContributorCmd.ExecuteNonQuery();
        personAddressCmd.ExecuteNonQuery();
 

        //}catch(Exception ex){
        //tran.Rollback();
        //throw ex;
        //}finally{
        connect.Close();
        //}
    }

    /*public Customer GetCustomer()
    {
        //same pattern. 
        //1. Create Sql String
        //2. Create command object
        //3. give values to any parameters
        //4. create a reader object
        //5. open the connection
        //6. Execute the reader
        //7. loop through the reader to get the data
        //8. Close reader
        //9. Close Connection
        //10. return the object containing the data


        Customer c = new Customer();
        string sql = "Select LastName, FirstName, email "
            + "from Person p "
            + "Inner Join Customer.RegisteredCustomer rc "
            + "on p.PersonKey=rc.PersonKey "
            + "Where p.PersonKey=@customerID";

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@CustomerID", id);
        SqlDataReader reader;

        connect.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                c.LastName = reader["LastName"].ToString();
                c.FirstName = reader["FirstName"].ToString();
                c.email = reader["email"].ToString();
            }
        }
        reader.Close();
        connect.Close();

        return c;
    }*/
}