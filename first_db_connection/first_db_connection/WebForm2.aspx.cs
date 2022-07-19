using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        protected void btn_pdf_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = banco.fazerconexao();

            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader result;

                cmd.Connection = cn;

                cmd.CommandText = "Select * from aula1 order by nome;";

                result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    string arquivo_pdf = "D:\\relatorio_teste.pdf";

                    Document doc = new Document();

                    FileStream fs = new FileStream(arquivo_pdf, FileMode.Create, FileAccess.Write, 
                        FileShare.None);

                    PdfWriter.GetInstance(doc, fs);

                    doc.Open();

                    while (result.Read())
                    {
                        doc.Add(new Paragraph("Nome: " + result["nome"].ToString()));
                        doc.Add(new Paragraph("Email: " + result["email"].ToString()));
                        doc.Add(new Paragraph("-----------------------"));
                    }

                    doc.Close();
                    cn.Close();

                    Response.Redirect(arquivo_pdf);
                }

            } catch(MySqlException err)
            {
                lbl_text.Text = err.Message;
            }
        }

        protected void btn_gerar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = banco.fazerconexao();

            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader result;

                cmd.Connection = cn;

                cmd.CommandText = "Select * from aula1 order by nome;";

                result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    using (MemoryStream ms = new MemoryStream())
                    using (Document doc = new Document(PageSize.A4, 25, 25, 30, 30))
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, ms))
                    {
                        doc.Open();

                        while (result.Read())
                        {
                            doc.Add(new Paragraph("Nome: " + result["nome"].ToString()));
                            doc.Add(new Paragraph("Email: " + result["email"].ToString()));
                            doc.Add(new Paragraph("-----------------------"));
                        }

                        
                        Response.ContentType = "pdf/application";
                        Response.AddHeader("content-disposition", "attachment; filename=relatorio.pdf");
                        Response.OutputStream.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
                        
                        doc.Close();
                        writer.Close();
                        ms.Close();
                        cn.Close();
                    }
     
                }

            }
            catch (MySqlException err)
            {
                lbl_text.Text = err.Message;
            }
        }
    }
}