using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Contratos.Services
{
    class Servico_Pagamento_Service : IPagamentosService
    {

        public double processar_Pagamentos(double valor_parcela, int parcela)
        {

            double valor = valor_parcela;
            valor += valor * 0.01 * parcela;
            valor += valor * 0.02;

            return valor;


        }
    }
}
