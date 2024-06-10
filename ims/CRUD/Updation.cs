using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ims.CRUD
{
    internal class Updation
    {
        public Updation() => Main.con.Open();

        public void UpdateUser(int id, string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_name", name);
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                cmd.Parameters.AddWithValue("@_usr_phone", email);
                cmd.Parameters.AddWithValue("@_usr_email", phone);
                cmd.Parameters.AddWithValue("@_usr_status", status);
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("User Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating User. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }

        public void UpdateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategories", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_cat_name", name);
                cmd.Parameters.AddWithValue("@_cat_status", status);
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Category Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating Category. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }

        public void UpdateProduct(int id, int catID, string name, string barcode, float price, short status, DateTime? expiryDate = null)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("st_updateProducts", Main.con);
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
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Product Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating Product. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }

        public void UpdateSupplier(int id, string name, string contectPerson, string phone1, string address, short status, string? phone2, string? ntn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSuppliers", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_sup_name", name);
                cmd.Parameters.AddWithValue("@_sup_contect_person", contectPerson);
                cmd.Parameters.AddWithValue("@_sup_phone1", phone1);
                cmd.Parameters.AddWithValue("@_sup_phone2", (phone2 == null) ? DBNull.Value : phone2);
                cmd.Parameters.AddWithValue("@_sup_address", address);
                cmd.Parameters.AddWithValue("@_sup_ntn", (ntn == null) ? DBNull.Value : ntn);
                cmd.Parameters.AddWithValue("@_sup_status", status);
                cmd.Parameters.AddWithValue("@_id", id);
                cmd.ExecuteNonQuery();
                Main.ShowMSG("Supplier Updated Successfully", "Success", "Success");
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Error While Updating Supplier. " + ex.Message, "Error", "Error");
            }

            Main.con.Close();
        }
    }
}
