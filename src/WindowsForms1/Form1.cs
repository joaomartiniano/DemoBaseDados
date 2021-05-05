// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        private List<Categoria> Categorias = new List<Categoria>();

        public Form1()
        {
            InitializeComponent();

            // Ler os dados a partir da base de dados
            LerDadosDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Colocar dados no controlo ListBox
            ListaCategorias1.DataSource = Categorias;
            ListaCategorias1.DisplayMember = "Designacao";
            // Mostrar o número de registos devolvidos pela base de dados
            //NumeroRegistosCategorias1.Text = "Registos: " + Categorias.Count().ToString();

            // Colocar dados no controlo ListView
            ListaCategorias2.View = View.Details;
            ListaCategorias2.FullRowSelect = true;
            ListaCategorias2.Columns.Add("ID", 40, HorizontalAlignment.Left);
            ListaCategorias2.Columns.Add("Designação", -2, HorizontalAlignment.Left);

            foreach (Categoria categoria in Categorias)
            {
                ListViewItem item = new ListViewItem(new string[] { categoria.Id.ToString(), categoria.Designacao });
                ListaCategorias2.Items.Add(item);
            }

            // Colocar dados no controlo ComboBox
            ListaCategorias3.DataSource = Categorias;
            ListaCategorias3.DisplayMember = "Designacao";
        }

        /// <summary>
        /// Ler dados da base de dados
        /// </summary>
        private bool LerDadosDB()
        {
            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT * FROM categorias;", connection))
                    {
                        // Executar o comando SQL
                        // (os dados devolvidos pelo comando são colocados na variável reader)
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Determinar se foram devolvidos dados
                            if (reader.HasRows)
                            {
                                // Percorrer os registos obtidos a partir da base de dados
                                while (reader.Read())
                                {
                                    // Adicionar um item à lista de categorias
                                    Categorias.Add(new Categoria(reader.GetInt32(0), reader.GetString(1)));
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
