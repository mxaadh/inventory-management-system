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
    }
}
