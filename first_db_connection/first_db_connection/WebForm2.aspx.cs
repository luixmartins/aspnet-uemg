using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace first_db_connection
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            preenche_grid();
        }

        private void preenche_grid()
        {
            MySqlConnection cn = banco.fazerconexao();

            try
            {
                cn.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `aula1` order by nome", cn);
                DataTable dt = new DataTable();

                adp.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }

                cn.Close();
            } 
            catch(MySqlException e)
            {
                lbl_text.Text = e.Message;
            }

            

        }
    }
}