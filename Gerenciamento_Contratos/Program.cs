using System;
using Gerenciamento_Contratos.Entitites;
using System.Globalization;
using Gerenciamento_Contratos.Services;

namespace Gerenciamento_Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Número : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy) : ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato : ");
            double valor_Contrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o número de parcelas : ");
            int meses = int.Parse(Console.ReadLine());

            Contratos contratos = new Contratos(numero, data, valor_Contrato);
            Parcelas parcelas = new Parcelas(meses, data);

            Processamento_Contratos_Service processamento_Contratos_Service = new Processamento_Contratos_Service(contratos, parcelas);
            double valorParcelas = processamento_Contratos_Service.calcular_Parcelas();
           

            for(int c=1;c<=parcelas.Quantidade;c++)
            {
                processamento_Contratos_Service = new Processamento_Contratos_Service(contratos, parcelas, valorParcelas, new Servico_Pagamento_Service(), c);
                Console.WriteLine(processamento_Contratos_Service.ToString());
            }
            

            //                                 Outra solução sem o Tostring()
            //double valor_parcelas = processamento_Contratos_Service.calcular_Parcelas();

            //IPagamentosService pagamentos = new Servico_Pagamento_Service();

            //for (int c = 1; c <= parcelas.Quantidade; c++)
            //{
            //    double parcelamento = pagamentos.processar_Pagamentos(valor_parcelas, c);
            //    Console.WriteLine(contratos.Data.AddMonths(c).ToString("dd/MM/yyyy") + " - "+parcelamento.ToString("F2", CultureInfo.InvariantCulture));
            //}
        }
    }
}
