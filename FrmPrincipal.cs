using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaEtapa6
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        bool auto;
        int TimerMovimiento;



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAuto.CrearAuto();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnGenrarVehiculos_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(70, 1);
            Controls.Add(objAuto.pctAuto);
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            int cantidadAutos = (int)nud.Value; // Obtener la cantidad seleccionada en el NumericUpDown

            // Limpiar todos los autos existentes antes de generar nuevos
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag?.ToString() == "Auto")
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Generar la cantidad de autos seleccionada
            for (int i = 0; i < cantidadAutos; i++)
            {
                PictureBox pctAuto = new PictureBox();
                pctAuto.SizeMode = PictureBoxSizeMode.Zoom;
                pctAuto.Width = 200;
                pctAuto.Height = 200;
                pctAuto.BackColor = Color.Transparent;
                string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Auto-removebg.png");
                pctAuto.ImageLocation = ruta;
                pctAuto.Tag = "Auto"; // Etiqueta para identificar que es un auto

                // Calcular la posición horizontal para evitar superposiciones
                int xPosition = 70 + i * (pctAuto.Width + 10);
                pctAuto.Location = new Point(xPosition, 1); // Distribuir los autos horizontalmente
                Controls.Add(pctAuto);


            }
        }
    }
}
