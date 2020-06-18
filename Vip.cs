namespace Aula19Fixação
{
    public class Vip : Ingresso
    {
        string resposta;
        public float Valoradicional { get; set; }

        public float Valorfinal { get; set; }

        public void ImprimirVip(){

            Valorfinal = Valor + Valoradicional;

            System.Console.WriteLine($"O valor a ser pago pego ingresso VIP é de R${Valorfinal}.");
        }
    }
}