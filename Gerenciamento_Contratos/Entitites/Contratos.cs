using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Contratos.Entitites
{
    class Contratos
    {
        public int Numero { get; set; }
        public DateTime  Data { get; set; }

        public double Valor { get; set; }

        public List<Parcelas> parcelas { get; set; } = new List<Parcelas>();

        public Contratos(int numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
        }

    }
}
