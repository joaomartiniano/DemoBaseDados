// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2
{
    class Produto
    {
        public int Id { get; set; }
        public string Designacao { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Volume { get; set; }
        public string Peso { get; set; }
        public int UnidadesStock { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }

        public Produto()
        { }

        public Produto(int id, string designacao, decimal preco, string descricao, string volume, string peso, int unidadesStock, string marca, string categoria)
        {
            Id = id;
            Designacao = designacao;
            Preco = preco;
            Descricao = descricao;
            Volume = volume;
            Peso = peso;
            UnidadesStock = unidadesStock;
            Marca = marca;
            Categoria = categoria;
        }
    }
}
