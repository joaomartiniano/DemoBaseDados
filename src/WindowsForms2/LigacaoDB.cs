// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2
{
    /// <summary>
    /// Contém os dados de ligação a uma base de dados.
    /// </summary>
    static class LigacaoDB
    {
        /// <summary>
        /// Endereço do servidor.
        /// </summary>
        /// <remarks>Atenção: classe estática (não instanciável).</remarks>
        public static string Servidor { get; private set; } = "127.0.0.1";

        /// <summary>
        /// Nome do utilizador.
        /// </summary>
        public static string Utilizador { get; private set; } = "root";

        /// <summary>
        /// Password do utilizador.
        /// </summary>
        public static string Password { get; private set; } = string.Empty;

        /// <summary>
        /// Base de dados a utilizar.
        /// </summary>
        public static string DB { get; private set; } = "hipermercadogirassol";

        /// <summary>
        /// Obter a string de ligação (connection string) ao servidor de base de dados.
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return $"server={Servidor};uid={Utilizador};pwd={Password};database={DB}";
        }
    }
}
