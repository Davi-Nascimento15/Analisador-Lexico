﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    internal class Token
    {
        string atributo;
        string valor;
        Token()
        {
            atributo = "";
            valor = "";
        }

        public string AtributoGet { get { return atributo; } }
        public string AtributoSet { set { atributo = value; } }
        public string ValorGet { get { return valor; } }
        public string ValorSet { set { valor = value; } }
    }
}
