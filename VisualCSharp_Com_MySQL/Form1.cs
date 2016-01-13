using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCSharp_Com_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            Dao dao = new Dao();

            mo.Nome = textBoxNome.Text;
            mo.Email = textBoxEmail.Text;

            dao.Cadastro(mo);


            textBoxEmail.Text = "";
            textBoxNome.Text = "";

        }
    }
}
