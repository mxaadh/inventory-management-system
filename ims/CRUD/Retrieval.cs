using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.CRUD
{
    internal class Retrieval
    {
        public static bool checkLogin = false;
        public static int? usr_id { get; private set; }
        public static string? usr_name { get; private set; }

        public static bool authUser(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_loginUser", Main.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_usr_username", username);
                cmd.Parameters.AddWithValue("@_usr_password", password);
                Main.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        usr_id = Convert.ToInt32(dr["ID"].ToString());
                        usr_name = dr["Name"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    Main.ShowMSG("Incorrect Username or Password", "Login Failed", "Error");
                }
            }
            catch (Exception ex)
            {
                Main.ShowMSG("Unable to login. " + ex.Message, "Login Failed", "Error");
            }

            Main.con.Close();
            return checkLogin;
        }

        public void showUser(
            DataGridView gv, 
            DataGridViewColumn userIDGV, 
            DataGridViewColumn nameGV, 
            DataGridViewColumn usernameGV, 
            DataGridViewColumn passGV,
            DataGridViewColumn emailGV, 
            DataGridViewColumn phoneGV, 
            DataGridViewColumn statusGV,
            string? q = null
        ) {
           
            try
            {
                SqlCommand cmd;
                if (q == null)
                {
                    cmd = new SqlCommand("st_getUsersData", Main.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchUsersData", Main.con);
                    cmd.Parameters.AddWithValue("@_q", q);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                

                gv.DataSource = dt;
            }
            catch (Exception) { throw; }
        }

        public void showCategory(
            DataGridView gv,
            DataGridViewColumn catIDGV,
            DataGridViewColumn nameGV,
            DataGridViewColumn statusGV,
            string? q = null
        ) {
            try
            {
                SqlCommand cmd;
                if (q == null)
                {
                    cmd = new SqlCommand("st_getCategoiesData", Main.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchCategoiesData", Main.con);
                    cmd.Parameters.AddWithValue("@_q", q);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception) { throw; }
        }

        public void getDropDownList(string procedure, ComboBox cb)
        {
            try
            {
                // cb.Items.Clear();
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(procedure, Main.con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select ..." };
                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = "Name";
                cb.ValueMember = "ID";
                cb.DataSource = dt;
            } catch (Exception) { throw; }
        }

        public void showProduct(
            DataGridView gv,
            DataGridViewColumn proIDGV,
            DataGridViewColumn catIDGV,
            DataGridViewColumn nameGV,
            DataGridViewColumn barcodeGV,
            DataGridViewColumn expiryDateGV,
            DataGridViewColumn priceGV,
            DataGridViewColumn categoryGV,
            DataGridViewColumn statusGV,
            string? q = null
        ) {
            try
            {
                SqlCommand cmd;
                if (q == null)
                {
                    cmd = new SqlCommand("st_getProductsData", Main.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchProductsData", Main.con);
                    cmd.Parameters.AddWithValue("@_q", q);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryDateGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            } catch (Exception) { throw; }
        }

        public void showSupplier(
            DataGridView gv,
            DataGridViewColumn supIDGV,
            DataGridViewColumn NameGV,
            DataGridViewColumn ContectPersonGV,
            DataGridViewColumn Phone1GV,
            DataGridViewColumn Phone2GV,
            DataGridViewColumn AddressGV,
            DataGridViewColumn NTNGV,
            DataGridViewColumn StatusGV,
            string? q = null
        )
        {
            try
            {
                SqlCommand cmd;
                if (q == null)
                {
                    cmd = new SqlCommand("st_getSuppliersDate", Main.con);
                }
                else
                {
                    cmd = new SqlCommand("st_searchSuppliersDate", Main.con);
                    cmd.Parameters.AddWithValue("@_q", q);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                supIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                ContectPersonGV.DataPropertyName = dt.Columns["Contect Person"].ToString();
                Phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                Phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                AddressGV.DataPropertyName = dt.Columns["Address"].ToString();
                NTNGV.DataPropertyName = dt.Columns["NTN"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception) { throw; }
        }
    }
}
