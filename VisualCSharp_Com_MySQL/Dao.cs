using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VisualCSharp_Com_MySQL
{
    class Dao
    {
        private MySqlConnection conexao;

        public void Cadastro(Modelo mo)
        {
            string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASS=";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = String.Format
                    ("INSERT INTO tbexemplo(nome, email) VALUES('{0}', '{1}');", mo.Nome, mo.Email);

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();

                conexao.Clone();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
