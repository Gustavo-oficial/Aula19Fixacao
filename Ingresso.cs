namespace Aula19Fixação
{
    public class Ingresso
    {
        public float Valor { get; set; }

        public void ImprimirIngressocomum(){
            System.Console.WriteLine($"O valor do ingresso é de R${Valor}.");
        }
    }
}