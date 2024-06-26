﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.CRUD
{
    internal class Deletion
    {
        public Deletion() => Main.con.Open();

        public void Delete(string procedure, string key, int value)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(key, value);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Data Deleted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Deleting. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }
    }
}
