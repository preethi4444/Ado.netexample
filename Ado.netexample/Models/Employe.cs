using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ado.netexample.Models
{
    public class Employe
    {
    
        public string Name { get; set; }
        public int Mobileno{ get; set; }
        SqlConnection obj;

        public Employe()
        {
             obj = new SqlConnection(ConfigurationManager.ConnectionStrings["Employecon"].ConnectionString);

        }
        public void Add_records(Employe e)
        {
            SqlCommand com = new SqlCommand("AddNewEmpDetails", obj);
            com.CommandType = CommandType.StoredProcedure;
            
            com.Parameters.AddWithValue("@Name", e.Name);
            com.Parameters.AddWithValue("@Mobileno", e.Mobileno);
            obj.Open();
            com.ExecuteNonQuery();
          
        }
    }
}