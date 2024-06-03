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
                    cmd.Parameters.AddWithValue("@q", q);
                }
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
            } catch(Exception ex)
            {

            }
        }
    }
}
