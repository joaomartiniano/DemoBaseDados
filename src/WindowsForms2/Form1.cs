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

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        private List<Produto> Produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();

            // Ler os dados a partir da base de dados
            LerDadosDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IdProduto.Text = string.Empty;

            NumeroRegistos.Text = $"{Produtos.Count} registos";

            // Colocar dados no controlo ListView
            ListaProdutos.View = View.Details;
            ListaProdutos.FullRowSelect = true;
            ListaProdutos.Columns.Add("ID", 40, HorizontalAlignment.Left);
            ListaProdutos.Columns.Add("Designação", -2, HorizontalAlignment.Left);

            foreach (Produto produto in Produtos)
            {
                ListViewItem item = new ListViewItem(new string[] { produto.Id.ToString(), produto.Designacao });
                ListaProdutos.Items.Add(item);
            }
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

                    using (var command = new MySqlCommand("SELECT P.ID, P.Designacao AS 'DesignacaoProduto', P.Preco, P.Descricao, P.Volume, P.Peso, P.UnidadesStock, M.Designacao AS 'Marca', C.Designacao AS 'Categoria' FROM produtos P, categorias C, marcas M WHERE P.Categoria_ID = C.ID AND P.Marca_ID = M.ID;", connection))
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
                                    // Declarar um novo produto (vazio)
                                    Produto p = new Produto();

                                    // Nota Importante:
                                    //   Utilizar o método IsDBNull() para verificar se cada campo contém
                                    //   um valor NULL.
                                    //   Apenas ler o valor do campo se NÃO contiver o valor NULL.

                                    if (!reader.IsDBNull(0))
                                    {
                                        p.Id = reader.GetInt32(0);
                                    }
                                    
                                    if (!reader.IsDBNull(1))
                                    {
                                        p.Designacao = reader.GetString(1);
                                    }
                                    
                                    if (!reader.IsDBNull(2))
                                    {
                                        p.Preco = reader.GetDecimal(2);
                                    }
                                    
                                    if (!reader.IsDBNull(3))
                                    {
                                        p.Descricao = reader.GetString(3);
                                    }
                                    
                                    if (!reader.IsDBNull(4))
                                    {
                                        p.Volume = reader.GetString(4);
                                    }
                                    
                                    if (!reader.IsDBNull(5))
                                    {
                                        p.Peso = reader.GetString(5);
                                    }

                                    if (!reader.IsDBNull(6))
                                    {
                                        p.UnidadesStock = reader.GetInt32(6);
                                    }
                                    
                                    if (!reader.IsDBNull(7))
                                    {
                                        p.Marca = reader.GetString(7);
                                    }

                                    if (!reader.IsDBNull(8))
                                    {
                                        p.Categoria = reader.GetString(8);
                                    }

                                    // Adicionar o produto à lista de produtos
                                    Produtos.Add(p);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Ocorreu um erro ao efetuar a ligação ao servidor de base de dados ou ao executar uma query.\n\nCódigo do erro: {e.Number}\n\nDetalhes do erro: {e.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Este evento ocorre sempre que é selecionado um item na lista de produtos.
        /// Executar o método BindProduto() para atualizar os controlos na form, com os dados do produto selecionado.
        /// </summary>
        private void ListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaProdutos.SelectedItems.Count > 0)
            {
                // Obter o ID do produto selecionado
                BindProduto(int.Parse(ListaProdutos.SelectedItems[0].SubItems[0].Text));
            }
        }

        /// <summary>
        /// Atualizar os controlos na form com os dados de um produto.
        /// </summary>
        /// <param name="produtoId">A chave primária do produto.</param>
        private void BindProduto(int produtoId)
        {
            // Validar o id do produto
            if ((produtoId < 1) || (produtoId > Produtos.Count))
            {
                return;
            }

            // Atenção:
            //    O ID dos registos de uma base de dados começa em 1.
            //    O índice dos elementos de arrays, listas, etc., começa em 0.
            //    Portanto, ao aceder à lista de produtos, é necessário subtrair o valor 1 ao ID do produto.
            //
            //    Por exemplo, obter a designação do produto com ID 5: Produtos[4].Designacao

            IdProduto.Text = produtoId.ToString();
            DesignacaoProduto.Text = Produtos[produtoId - 1].Designacao;
            PrecoProduto.Text = Produtos[produtoId - 1].Preco.ToString("F"); // Arredondar para 2 casas decimais
            DescricaoProduto.Text = Produtos[produtoId - 1].Descricao;
            VolumeProduto.Text = Produtos[produtoId - 1].Volume;
            PesoProduto.Text = Produtos[produtoId - 1].Peso;
            UnidadesStockProduto.Text = Produtos[produtoId - 1].UnidadesStock.ToString();
            MarcaProduto.Text = Produtos[produtoId - 1].Marca;
            CategoriaProduto.Text = Produtos[produtoId - 1].Categoria;
        }
    }
}
