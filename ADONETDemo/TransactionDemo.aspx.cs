using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADONETDemo_TransactionDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ExecuteSqlTransaction();
    }

    public void ExecuteSqlTransaction()
    {
        string str = "data source=.;initial catalog=asptraining;integrated security=true;";
        using (SqlConnection connection = new SqlConnection(str))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction;


            transaction = connection.BeginTransaction("SampleTransaction");


            command.Connection = connection;
            command.Transaction = transaction;

            try
            {
                command.CommandType = CommandType.Text;
                command.CommandText =
                    "Insert into UserDetails (UserName,Password) VALUES ('Chris Cairns', 'Auckland')";
                command.ExecuteNonQuery();

                command.CommandText =
                    "Insert into Region (RegionID, RegionDecription) VALUES (106, 'Description')";
                command.ExecuteNonQuery();


                transaction.Commit();

            }
            catch (Exception ex)
            {



                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    throw new Exception(ex2.Message);
                }
                throw new Exception(ex.Message);
            }
        }
    }
}