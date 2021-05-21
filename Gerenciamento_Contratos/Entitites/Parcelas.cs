using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Contratos.Entitites
{
    class Parcelas
    {
        public DateTime Data_Vencimento { get; set; }
        public int Quantidade { get; set; }

        public Parcelas(int quantidade, DateTime data)
        {
            Quantidade = quantidade;
            Data_Vencimento = data;
        }

        public Parcelas(DateTime data)
        {
            Data_Vencimento = data;
        }
            
    }
}
