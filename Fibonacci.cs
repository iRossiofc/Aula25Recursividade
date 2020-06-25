namespace Aula25Recursividade
{
    public class Fibonacci
    {

        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){
            if(vezes  > 0){
                System.Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes -1);
            }
        }

        //metodo para gera numero fatorial
        
        public int GerarFatorial(int numero){
            //se o numero for = 1 logo o fatorial desse numero vai ser 1
            if(numero == 1){
                return  1;
            }else{
                //se o numero for diferente de 1 ele vai entrar nesse caso e gerar o fatorial
                //conta matematica para o numero fatorial 
                return numero * GerarFatorial(numero - 1);
            }
        }

    }
}