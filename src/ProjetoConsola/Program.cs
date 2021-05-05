// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroRegistos = 0;

            try
            {
                // Estabelecer uma ligação ao servidor de base de dados
                // Introduzir:
                //      endereço do servidor: 127.0.0.1 (localhost)
                //      utilizador: root
                //      password: (sem password)
                //      base de dados a utilizar: hipermercadogirassol
                using (var connection = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=hipermercadogirassol"))
                {
                    // Estabelecer a ligação
                    connection.Open();

                    Console.WriteLine("Ligação à base de dados executada com sucesso\n\n");

                    // Definir um comando SQL
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
                                    // Métodos utilizados para obter os valores dos campos:
                                    //      GetInt32(0) --> retorna o valor do campo ID em número inteiro
                                    //      GetString(1) --> retorna o valor do campo Designacao em string
                                    Console.WriteLine($"ID = {reader.GetInt32(0)} ; Designacao = {reader.GetString(1)}");

                                    ++numeroRegistos;
                                }
                            }

                            // Mostrar ao utilizador o número de registos obtidos
                            Console.WriteLine($"\nForam obtidos {numeroRegistos} registos");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: operação de base de dados\n  Erro: {0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
