using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen2.UI.Consultar;
using RegistroExamen2.UI.Registro;

namespace RegistroExamen2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroGrupo ver = new RegistroGrupo();
            ver.Show();
        }

        private void consultarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar ver = new Consultar();
            ver.Show();
        }
    }
}
