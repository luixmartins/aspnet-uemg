using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace first_db_connection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MySqlConnection cn = banco.fazerconexao();
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT * FROM `aula1` order by nome";
                    MySqlDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        lst_dadis.Items.Add(new ListItem(rs["nome"].ToString(), rs["id"].ToString()));
                    }
                    cn.Close();
                }
                catch (MySqlException err)
                {
                    if (err.ErrorCode == -2147467259)
                        lbl_msgerro.Text = "Confira a string de conexão";
                    else
                        lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
                }
            }
        }

        protected void btn_procurar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = banco.fazerconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM `aula1` where nome like '%" + txt_procurar.Text + "%' order by nome";
                MySqlDataReader rs = cmd.ExecuteReader();
                lst_dadis.Items.Clear();
                while (rs.Read())
                {
                    lst_dadis.Items.Add(new ListItem(rs["nome"].ToString(), rs["id"].ToString()));
                }
                cn.Close();
            }
            catch (MySqlException err)
            {
                if (err.ErrorCode == -2147467259)
                    lbl_msgerro.Text = "Confira a string de conexão";
                else
                    lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
            }
        }

        protected void btn_adcionar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "" && txt_nome.Text != "")
            {
                MySqlConnection cn = banco.fazerconexao();
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO `aula1` (nome, email) VALUES ('" + txt_nome.Text + "', '" + txt_email.Text + "');";
                    cmd.ExecuteNonQuery();

                    lst_dadis.Items.Clear();

                    cmd.CommandText = "SELECT * FROM `aula1` order by nome";
                    MySqlDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        lst_dadis.Items.Add(new ListItem(rs["nome"].ToString(), rs["id"].ToString()));
                    }

                    cn.Close();

                    txt_nome.Text = "";
                    txt_email.Text = "";

                    txt_nome.Focus();

                    Response.Redirect("WebForm2.aspx");
                }
                catch(MySqlException err)
                {
                    if (err.ErrorCode == -2147467259)
                        lbl_msgerro.Text = "Confira a string de conexão";
                    else
                        lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
                }
            } else
            {
                lbl_msgerro.Text = "Preencha todos os campos!";
                txt_nome.Focus();
            }
        }

        protected void btn_limpa_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_email.Text = "";
        }

        protected void lst_dadis_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection cn = banco.fazerconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM `aula1` where id = " + lst_dadis.SelectedValue;
                MySqlDataReader rs = cmd.ExecuteReader();

                rs.Read();

                txt_nome.Text = rs["nome"].ToString();
                txt_email.Text = rs["email"].ToString();

                cn.Close();
            }
            catch (MySqlException err)
            {
                if (err.ErrorCode == -2147467259)
                    lbl_msgerro.Text = "Confira a string de conexão";
                else
                    lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
            }
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "" && txt_nome.Text != "" && lst_dadis.SelectedIndex > -1)
            {
                MySqlConnection cn = banco.fazerconexao();
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = cn;
                    cmd.CommandText = "UPDATE `aula1` SET nome = '" + txt_nome.Text + "', email = '" + txt_email.Text + "' where id = " + lst_dadis.SelectedValue;
                    cmd.ExecuteNonQuery();

                    lst_dadis.Items.Clear();

                    cmd.CommandText = "SELECT * FROM `aula1` order by nome";
                    MySqlDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        lst_dadis.Items.Add(new ListItem(rs["nome"].ToString(), rs["id"].ToString()));
                    }

                    cn.Close();

                    txt_nome.Text = "";
                    txt_email.Text = "";

                    txt_nome.Focus();

                    Response.Redirect("WebForm2.aspx");
                }
                catch (MySqlException err)
                {
                    if (err.ErrorCode == -2147467259)
                        lbl_msgerro.Text = "Confira a string de conexão";
                    else
                        lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
                }
            }
            else
            {
                lbl_msgerro.Text = "Selecione uma pessoa e preencha todos os campos!";
                txt_nome.Focus();
            }
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            if (lst_dadis.SelectedIndex > -1)
            {
                MySqlConnection cn = banco.fazerconexao();
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = cn;
                    cmd.CommandText = "DELETE FROM `aula1` where id = " + lst_dadis.SelectedValue;
                    cmd.ExecuteNonQuery();

                    lst_dadis.Items.Clear();

                    cmd.CommandText = "SELECT * FROM `aula1` order by nome";
                    MySqlDataReader rs = cmd.ExecuteReader();
                    while (rs.Read())
                    {
                        lst_dadis.Items.Add(new ListItem(rs["nome"].ToString(), rs["id"].ToString()));
                    }

                    cn.Close();

                    txt_nome.Text = "";
                    txt_email.Text = "";

                    txt_nome.Focus();

                    Response.Redirect("WebForm2.aspx");
                }
                catch (MySqlException err)
                {
                    if (err.ErrorCode == -2147467259)
                        lbl_msgerro.Text = "Confira a string de conexão";
                    else
                        lbl_msgerro.Text = err.ErrorCode + " - " + err.Message;
                }
            }
            else
            {
                lbl_msgerro.Text = "Selecione uma pessoa para excluir!";
                txt_nome.Focus();
            }
        }

    }
}