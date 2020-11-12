using System;

namespace algoritmo_semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORITMO SEMAFORO
            Console.WriteLine("Algoritmo para definir o que deve se fazer para cada cor de semaforo");
            Console.WriteLine("Para Inciarmos escreva a cor do semaforo para receber as instruções");
            Console.WriteLine(" verde,vermelho ou amarelo ");
            string cor=(Console.ReadLine());


        
            string refazer="sim";
           while(refazer=="sim"){
            
                if(cor == "vermelho"){
                    Console.WriteLine("Pare e espere o sinal verde");
                }

                if(cor == "amarelo"+"amar"){
                    Console.WriteLine("Desacelere e espere");
                }

                else{
                    Console.WriteLine("Prosiga");
                }        
            

           Console.WriteLine("Deseja refazer?");
           string refaze=(Console.ReadLine());

                if (refaze=="nao") { }
                else
                {
                    break;
                }
            }
           
            


        }
    }
}
