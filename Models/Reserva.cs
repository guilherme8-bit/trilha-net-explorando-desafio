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
            //Implementado !!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Implementado !!!
                throw new InvalidOperationException("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementado !!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //Implementado !!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //Implementado !!!
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 10 / 100);
            }

            return valor;
        }
    }
}