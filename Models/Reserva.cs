using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            if (hospedes.Count <= Suite.Capacidade) // ****** PAREI AQUI *******
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*

                // NÃO CONSEGUI IMPLEMENTAR A EXCEÇÃO.
                // SEMPRE QUE MUDO O VALOR DA CAPACIDADE, RECEBO A EXCEÇÃO ...
                // ... Unhandled exception. System.Exception: ...
                
                //Console.WriteLine("A quantidade de hóspedes é maior que a capacidade da suíte");
                throw new Exception("A quantidade de hóspedes é maior do que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() // *IMPLEMENTADO*
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() // *IMPLEMENTADO*
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;
            double desconto = Convert.ToDouble(valor);
            desconto = desconto * 0.9;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                valor = Convert.ToDecimal(desconto);
            }

            return valor;
        }
    }
}