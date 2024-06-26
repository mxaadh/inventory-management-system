﻿using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ims.CRUD
{
    internal class Insertion
    {
        public Insertion() => Main.con.Open();

        public void InsertUser(string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_name", name);
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                cmd.Parameters.AddWithValue("@_usr_phone", phone);
                cmd.Parameters.AddWithValue("@_usr_email", email);
                cmd.Parameters.AddWithValue("@_usr_status", status);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("User Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting User. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }

        public void InsertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategorie", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_cat_name", name);
                cmd.Parameters.AddWithValue("@_cat_status", status);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Category Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting Category. " + ex.Message, "Error", "Error");
            }
            
            Main.con.Close();
        }

        public void InsertProduct(int catID, string name, string barcode, float price, short status, DateTime? expiryDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProducts", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_pro_cat_id", catID);
                cmd.Parameters.AddWithValue("@_pro_name", name);
                cmd.Parameters.AddWithValue("@_pro_barcode", barcode);
                if (expiryDate == null)
                {
                    cmd.Parameters.AddWithValue("@_pro_expiry_date", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@_pro_expiry_date", expiryDate);
                }
                cmd.Parameters.AddWithValue("@_pro_price", price);
                cmd.Parameters.AddWithValue("@_pro_status", status);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Product Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting Product. " + ex.Message, "Error", "Error");
            }
            
            Main.con.Close();
        }

        public void InsertSupplier(string name, string contectPerson, string phone1, string address, short status, string? phone2, string? ntn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSuppliers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_sup_name", name);
                cmd.Parameters.AddWithValue("@_sup_contect_person", contectPerson);
                cmd.Parameters.AddWithValue("@_sup_phone1", phone1);
                cmd.Parameters.AddWithValue("@_sup_phone2", (phone2 == null) ? DBNull.Value : phone2);
                cmd.Parameters.AddWithValue("@_sup_address", address);
                cmd.Parameters.AddWithValue("@_sup_ntn", (ntn == null) ? DBNull.Value : ntn);
                cmd.Parameters.AddWithValue("@_sup_status", status);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Supplier Inserted Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Inserting Supplier. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }
    }
}
