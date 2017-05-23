using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Descripción breve de UserDetails
/// </summary>
public class UserDetails
{

    private string m_UserName,m_Password,m_Country,m_Email;
    public UserDetails()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Password
    {
        get
        {
            return m_Password;
        }

        set
        {
            m_Password = value;
        }
    }

    public string UserName
    {
        get
        {
            return m_UserName;
        }

        set
        {
            m_UserName = value;
        }
    }

    public string Country
    {
        get
        {
            return m_Country;
        }

        set
        {
            m_Country = value;
        }
    }

    public string Email
    {
        get
        {
            return m_Email;
        }

        set
        {
            m_Email = value;
        }
    }


    public int CreateUser() {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        int counter = 0;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[UserDetails_Insert]";

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Country", Country);
            cmd.Parameters.AddWithValue("@Email", Email);

            cn.Open();
            counter = cmd.ExecuteNonQuery();//INSERT,UPDATE,DELETE
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally {
            if (cn != null) {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
        return counter;
    }

    public DataSet CheckCredentials() {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        DataSet dSet = null;
        SqlDataAdapter sda = null;
        //int counter = 0;

        try
        {
            cn = new SqlConnection();
            //cn.ConnectionString = GetConnectionString();
            //cn.ConnectionString = GetCS();

            cn.ConnectionString = GetCSFromWebConfig();
            //cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[CheckCredentials]";

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            cn.Open();
            sda = new SqlDataAdapter(cmd);
            dSet = new DataSet();
            sda.Fill(dSet);
            //counter = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
        return(dSet);
    }

    public int ChangePassword(){
        SqlConnection cn = null;
        SqlCommand cmd = null;
        int counter = 0;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[ChangePassword]";

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            cn.Open();
            counter = cmd.ExecuteNonQuery();//INSERT,UPDATE,DELETE
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
        return counter;
    }

    public int DeleteUser() {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        int counter = 0;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[UnsubscribeUser]";

            cmd.Parameters.AddWithValue("@UserName", UserName);

            cn.Open();
            counter = cmd.ExecuteNonQuery();//INSERT,UPDATE,DELETE
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
        return counter;
    }

    public int UpdateUser()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        int Counter = 0;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[UpdateUser]";

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Country", Country);
            cmd.Parameters.AddWithValue("@Email", Email);

            cn.Open();
            Counter = cmd.ExecuteNonQuery();//I,U,D

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
        return (Counter);
    }

    public DataSet GetUserInfo()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dSet = null;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=asptraining;integrated security=true;";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectUser";
            cmd.Parameters.AddWithValue("@UserName", UserName);

            sda = new SqlDataAdapter(cmd);
            dSet = new DataSet("Users");
            sda.Fill(dSet, "User");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return (dSet);
    }


    private string GetConnectionString()
    {
        string str = "data source=.;initial catalog=asptraining;integrated security=true;";
        return (str);
    }
    private string GetCS()
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        scsb.DataSource = ".";
        scsb.InitialCatalog = "asptraining";
        scsb.IntegratedSecurity = true;
        return (scsb.ToString());

    }
    private string GetCSFromWebConfig()
    {
        string str = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
        return (str);
    }

    //arquitectura no orientada a la conexion
    public DataSet GetListOfAllUsers()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dSet = null;

        try
        {
            cn = new SqlConnection();
            //cn.ConnectionString = GetConnectionString();
            //cn.ConnectionString = GetCS();

            cn.ConnectionString = GetCSFromWebConfig();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetListOfAllUsers]";

            sda = new SqlDataAdapter(cmd);
            dSet = new DataSet("Users");
            sda.Fill(dSet, "User");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return (dSet);
    }

    //arquitectura orientada a la conexion
    //read-only
    //fordward only direction
    public SqlDataReader GetListOfAllUsersUsigReader()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;


        try
        {
            cn = new SqlConnection();
            //cn.ConnectionString = GetConnectionString();
            //cn.ConnectionString = GetCS();

            cn.ConnectionString = GetCSFromWebConfig();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetListOfAllUsers]";

            cn.Open();
            sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return (sdr);
    }

    public DataSet GetListOfAllCountries()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dSet = null;

        try
        {
            cn = new SqlConnection();
            //cn.ConnectionString = GetConnectionString();
            //cn.ConnectionString = GetCS();

            cn.ConnectionString = GetCSFromWebConfig();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[GetCountries]";

            sda = new SqlDataAdapter(cmd);
            dSet = new DataSet("Users");
            sda.Fill(dSet, "User");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return (dSet);
    }

    public DataSet GetCountryWiseUsers()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dSet = null;

        try
        {
            cn = new SqlConnection();
            //cn.ConnectionString = GetConnectionString();
            //cn.ConnectionString = GetCS();

            cn.ConnectionString = GetCSFromWebConfig();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetCountryWiseUsers";
            cmd.Parameters.AddWithValue("@Country", Country);

            sda = new SqlDataAdapter(cmd);
            dSet = new DataSet("Users");
            sda.Fill(dSet, "User");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return (dSet);
    }

    public void Calculate(int a, int b, out int c, out int d, out int e, out int f)
    {

        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlParameter p1 = null;
        SqlParameter p2 = null;
        SqlParameter p3 = null;
        SqlParameter p4 = null;
        SqlParameter p5 = null;
        SqlParameter p6 = null;

        try
        {
            c = d = e = f = 0;

            cn = new SqlConnection();
            cn.ConnectionString = GetCSFromWebConfig();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Calculate";


            p1 = new SqlParameter("@a", SqlDbType.Int);
            p2 = new SqlParameter("@b", SqlDbType.Int);

            p3 = new SqlParameter("@c", SqlDbType.Int);
            p4 = new SqlParameter("@d", SqlDbType.Int);
            p5 = new SqlParameter("@e", SqlDbType.Int);
            p6 = new SqlParameter("@f", SqlDbType.Int);
            //p6 = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            p3.Direction = ParameterDirection.Output;
            p4.Direction = ParameterDirection.Output;
            p5.Direction = ParameterDirection.Output;
            p6.Direction = ParameterDirection.Output;
            p1.Value = a;
            p2.Value = b;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);



            cn.Open();
            int Counter = cmd.ExecuteNonQuery();

            c = Convert.ToInt32(p3.Value.ToString());
            d = Convert.ToInt32(p4.Value.ToString());
            e = Convert.ToInt32(p5.Value.ToString());
            f = Convert.ToInt32(p6.Value.ToString());

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
        }
    }
}