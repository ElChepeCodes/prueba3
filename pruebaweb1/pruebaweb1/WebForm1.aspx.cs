using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pruebaweb1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddColores.Items.Count == 0)
            {
                ddColores.Items.Add("Rojo");
                ddColores.Items.Add("Verde");
                ddColores.Items.Add("Rosa");
                ddColores.Items.Add("Morado");
            }

            if (rbSabores.Items.Count == 0)
            {
                rbSabores.Items.Add("Vainilla");
                rbSabores.Items.Add("Chocolate");
                rbSabores.Items.Add("Fresa");
                rbSabores.Items.Add("Mango");
                rbSabores.Items.Add("Sandia");
            }
            if (cbCafe.Items.Count == 0)
            {
                cbCafe.Items.Add("americano");
                cbCafe.Items.Add("latte");
                cbCafe.Items.Add("capucino");
                cbCafe.Items.Add("moka");
            }
        }

        protected void ddColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = ddColores.SelectedIndex;
            lbColores.Text = "Indice seleccionado: " + seleccion.ToString();

            Session["controles"] = "cambio al DropDownList";
            lbSesion.Text = Session["controles"].ToString();
        }

        protected void rbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndiceS.Text = "Indice seleccionado: " + rbSabores.SelectedIndex.ToString();
            lbContenidoS.Text = "Valor del indice seleccionado: " + rbSabores.SelectedValue.ToString();
            Session["controles"] = "cambio al Radio Button";
            lbSesion.Text = Session["controles"].ToString();
        }

        protected void cbCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            for (i = 0; i < cbCafe.Items.Count; i++)
            {
                if (cbCafe.Items[i].Selected)
                {
                    ListBox1.Items.Add(i.ToString());
                    ListBox2.Items.Add(cbCafe.Items[i].ToString());
                }
            }
            Session["controles"] = "cambio al CheckBox List";
            lbSesion.Text = Session["controles"].ToString();
        }
    }
}