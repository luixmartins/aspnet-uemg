using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class calculator_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Number(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if (lbl_total.Text != "0")
                lbl_total.Text += number.Text;
            else 
                lbl_total.Text = number.Text;
        }

        protected void btn_ponto_Click(object sender, EventArgs e)
        {
            bool aux = false;
            for(int i = 0; i < lbl_total.Text.Length; i++)
            {
                if (lbl_total.Text[i] == '.')
                    aux = true;
            }
            if (!aux)
                lbl_total.Text += ".";
        }

        protected void op_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            hd_operacao.Value = op.Text.ToString();

            if(hd_total.Value != "")
            {
                if (op.Text.ToString() == "+")
                {
                    hd_total.Value = Convert.ToString(Convert.ToDouble(hd_total.Value) + Convert.ToDouble(lbl_total.Text));
                    lbl_total.Text = "0";
                } else if (op.Text.ToString() == "-")
                {
                    hd_total.Value = Convert.ToString(Convert.ToDouble(hd_total.Value) - Convert.ToDouble(lbl_total.Text));
                    lbl_total.Text = "0";
                } else if (op.Text.ToString() == "*")
                {
                    hd_total.Value = Convert.ToString(Convert.ToDouble(hd_total.Value) - Convert.ToDouble(lbl_total.Text));
                    lbl_total.Text = "0";
                } else if (op.Text.ToString() == "/")
                {
                    if(lbl_total.Text != "0")
                    {
                        hd_total.Value = Convert.ToString(Convert.ToDouble(hd_total.Value) / Convert.ToDouble(lbl_total.Text));
                        lbl_total.Text = "0";
                    } else
                    {
                        lbl_total.Text = "0";
                        hd_operacao.Value = "";
                        hd_total.Value = "";
                    }
                }
            } else
            {
                hd_total.Value = lbl_total.Text;
                lbl_total.Text = "0";
            }
        }

        protected void btn_result_Click(object sender, EventArgs e)
        {
            if (hd_operacao.Value.Equals("+"))
                lbl_total.Text = Convert.ToString(Convert.ToDouble(hd_total.Value) + Convert.ToDouble(lbl_total.Text));
            if (hd_operacao.Value.Equals("-"))
                lbl_total.Text = Convert.ToString(Convert.ToDouble(hd_total.Value) - Convert.ToDouble(lbl_total.Text));
            if (hd_operacao.Value.Equals("*"))
                lbl_total.Text = Convert.ToString(Convert.ToDouble(hd_total.Value) * Convert.ToDouble(lbl_total.Text));
            if (hd_operacao.Value.Equals("/"))
            {
                if (lbl_total.Text == "0")
                    lbl_total.Text = "0";
                else
                    lbl_total.Text = Convert.ToString(Convert.ToDouble(hd_total.Value) / Convert.ToDouble(lbl_total.Text));
            }

            hd_total.Value = "";
            hd_operacao.Value = "";

        }

        protected void Clean_Values(object sender, EventArgs e)
        {
            Button cleaner = (Button)sender;

            if (cleaner.Text == "C")
            {
                hd_operacao.Value = "";
                hd_total.Value = "";
                lbl_total.Text = "0";
            } else if (cleaner.Text == "CE")
            {
                lbl_total.Text = "0";
            } else if(cleaner.Text == "<<")
            {
                if (lbl_total.Text != "0")
                {
                    lbl_total.Text = lbl_total.Text.Remove(lbl_total.Text.Length - 1);
                }
            }
        }
    }
}