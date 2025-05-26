using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1EJEMPLO.Paginas
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad;


            if (int.TryParse(txtEdad.Text, out edad))

            {
                lblMensaje.Text = "se connvirtio la edad";
                if (edad < 0)
                {
                    lblMensaje.Text += " edad no valida";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (edad < 18)
                    {
                        lblMensaje.Text = " todavia no cumples la mayoria de edad";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblMensaje.Text = " tienes acceso";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;
                    }
                }
                
            }
            else
            {

                lblMensaje.Text = " NO se connvirtio la edad";
            }



        }
    }
}