using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace name_registration
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_adc_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "")
                if (listBox_nomes.Items.FindByText(txt_nome.Text) == null)
                    listBox_nomes.Items.Add(txt_nome.Text);
                else
                    txt_nome.Text = "Já existe o nome :)";
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            if (listBox_nomes.SelectedIndex != -1)
                listBox_nomes.Items.Remove(listBox_nomes.SelectedItem);
            
        }

        protected void btn_excluir_mult_Click(object sender, EventArgs e)
        {
            for(int i = listBox_nomes.Items.Count - 1; i >= 0; i--)
            {
                if (listBox_nomes.Items[i].Selected)
                    listBox_nomes.Items.Remove(listBox_nomes.Items[i]);
            }
        }

        protected void btn_pesquisa_Click(object sender, EventArgs e)
        {   
            for (int i = 0; i < listBox_nomes.Items.Count; i++)
                listBox_nomes.Items [i].Selected = false;

            if(txt_nome.Text != "")
            {
 
                foreach(ListItem item in listBox_nomes.Items)
                {
                    if (item.Text == txt_nome.Text)
                    {
                        item.Selected = true;
                        break;
                    } 
                }
            }
        }
    }
}