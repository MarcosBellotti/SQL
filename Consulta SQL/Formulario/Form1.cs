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
            dgvDatos.DataSource = datosABuscar.Consulta(cmbConsultas.Text);
            //podemos hacer un cmb con lo que queremos buscar y se busca la vista en SQL
        }
    }
}
