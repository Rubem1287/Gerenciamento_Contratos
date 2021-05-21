using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Contratos.Services
{
    interface IPagamentosService
    {
        double processar_Pagamentos(double valor_Parcela, int parcela);
    }
}
