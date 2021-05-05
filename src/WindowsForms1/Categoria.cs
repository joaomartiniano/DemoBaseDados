// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms1
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Designacao { get; set; }

        public Categoria(int id, string designacao)
        {
            Id = id;
            Designacao = designacao;
        }
    }
}
