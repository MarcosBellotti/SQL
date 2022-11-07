using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {

        Consultas datosABuscar = new Consultas(); //instancia de la clase que establece la conexión con SQL
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //según el seleccionado en el cmb guaramos un string que sea select * from *VISTA*
            string vista = $"select * from {cmbConsultas.Text}";
            dgvDatos.DataSource = datosABuscar.Consulta(vista);           
        }
    }
}
