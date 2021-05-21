using System;
using System.Collections.Generic;
using System.Text;
using Gerenciamento_Contratos.Entitites;
using System.Globalization;

namespace Gerenciamento_Contratos.Services
{
    class Processamento_Contratos_Service
    {
        public Parcelas Parcelas { get; set; }
        public Contratos Contratos { get; set; }

        public double ValorParcelas { get; set; }

        public int Meses { get; set; }

        private IPagamentosService _pagamentosService;

        public Processamento_Contratos_Service(Contratos contratos, Parcelas parcelas, double valorParcelas, IPagamentosService pagamentosService, int meses)
        {
            Contratos = contratos;
            Parcelas = parcelas;
            ValorParcelas = valorParcelas;
            _pagamentosService = pagamentosService;
            Meses = meses;

        }

        public Processamento_Contratos_Service(Contratos contratos, Parcelas parcelas)
        {
            Parcelas = parcelas;
            Contratos = contratos;
        }


        public double calcular_Parcelas()
        {
            ValorParcelas = Contratos.Valor / Parcelas.Quantidade;
            return ValorParcelas;
        }

        public override string ToString()
        {
            //int parcelas = Parcelas.Quantidade;

            //for (int c = 1; c <= parcelas; c++)
            //{
                double parcelamento = _pagamentosService.processar_Pagamentos(ValorParcelas, Meses);
            //Console.WriteLine(Contratos.Data.AddMonths(Meses).ToString("dd/MM/yyyy") + " - " + parcelamento.ToString("F2", CultureInfo.InvariantCulture));
            //}



            return Contratos.Data.AddMonths(Meses).ToString("dd/MM/yyyy") 
                + " - " 
                + parcelamento.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
