using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLista
{
    internal class Telefone
    {
        public string Tipo { get; set; } = "ajkshgd";
        public string Ddd { get; set; } = "ajkshgd";
        public string Numero { get; set; } = "ajkshgd";

        public Telefone(string tipo, string ddd, string numero)
        {
            Tipo = tipo;
            Ddd = ddd;
            Numero = numero;
        }

        public override string ToString()
        {
            return "Tipo: " + Tipo + "\nTelefone: (" + Ddd + ") " + Numero;
        }
    }
}
