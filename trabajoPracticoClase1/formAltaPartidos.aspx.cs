using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trabajoPracticoClase1
{
    public partial class formAltaPartidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string getCriterio()
        {
            string criterio = RadioButtonList1.SelectedItem.Value;
            return criterio;
        }
        protected void botonEnviar_Click(object sender, EventArgs e)
        {
            if (txtNombreA.Text != "" && txtPuntosA.Text != "" && txtPuntosB.Text != "" && txtNombreB.Text != "" && RadioButtonList1.SelectedIndex >= 0)
            {
                string nombreEquipoA = txtNombreA.Text;
                string puntosEquipoA = txtPuntosA.Text;
                string nombreEquipoB = txtNombreB.Text;
                string puntosEquipoB = txtPuntosB.Text;

                int ptsEquipoA = int.Parse(txtPuntosA.Text);
                int ptsEquipoB = int.Parse(txtPuntosB.Text);
                string ganador = "";
                int diferenciaPuntos = 0;
                string criterio = getCriterio();

                if (criterio == "mas")
                {
                    if (ptsEquipoA > ptsEquipoB)
                    {
                        ganador = nombreEquipoA;
                        diferenciaPuntos = ptsEquipoA - ptsEquipoB;
                    }
                    else if (ptsEquipoB > ptsEquipoA)
                    {
                        ganador = nombreEquipoB;
                        diferenciaPuntos = ptsEquipoB - ptsEquipoA;
                    }
                    else
                    {
                        ganador = "Empate";
                    }
                }
                else if (criterio == "menos")
                {
                    if (ptsEquipoA < ptsEquipoB)
                    {
                        ganador = nombreEquipoA;
                        diferenciaPuntos = ptsEquipoB - ptsEquipoA;
                    }
                    else if (ptsEquipoB < ptsEquipoA)
                    {
                        ganador = nombreEquipoB;
                        diferenciaPuntos = ptsEquipoA - ptsEquipoB;
                    }
                    else
                    {
                        ganador = "Empate";
                    }
                }

                



                labelDatos.Text = $"Equipo A: Nombre={nombreEquipoA}, Puntos={puntosEquipoA}<br /><br />";
                labelDatos.Text += $"Equipo B: Nombre={nombreEquipoB}, Puntos={puntosEquipoB}<br /><br />";
                labelDatos.Text += $"Criterio: {RadioButtonList1.SelectedItem.Text}<br /><br />";

                if (ganador == "Empate")
                {
                    labelDatos.Text += $"Resultado: {nombreEquipoA} {puntosEquipoA} - {puntosEquipoB} {nombreEquipoB} . {ganador}";
                }
                else if(diferenciaPuntos != 1)
                {
                    labelDatos.Text += $"Resultado: {nombreEquipoA} {puntosEquipoA} - {puntosEquipoB} {nombreEquipoB} . Gano {ganador} por una diferencia de {diferenciaPuntos} puntos";
                } else
                {
                    labelDatos.Text += $"Resultado: {nombreEquipoA} {puntosEquipoA} - {puntosEquipoB} {nombreEquipoB} . Gano {ganador} por una diferencia de {diferenciaPuntos} punto";
                }
                
            }
            else
            {
                labelDatos.Text = "Por favor complete y seleccione todos los datos antes de enviar";
            }
        }
    }
}