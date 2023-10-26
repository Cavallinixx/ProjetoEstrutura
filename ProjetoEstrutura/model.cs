using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {
        public double[] notas;//Declaração de um vetor
        public int[] vetor;
        public int[] num;
        public int[] numMaior;
        public int i;
        private double[] numDouble;
        public int impar;
        private double soma;
       

        public Model()
        {
            notas = new double[10];
            vetor = new int[5];//Instanciar = Existir 
            num = new int[10];
            numDouble = new double[20];
            numMaior = new int[25];
            i = 0;
            ConsultarSoma = 0;
            impar = 0;
          
            
        }//fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { this.soma = value; }
        }//fim do get set

        //Exercicio teste - Guardar 10 notas de 10 alunos diferentes
        public double MediaNotas()
        {
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }//fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//fim do for
            return ConsultarSoma / i;
        }//fim método

        //Exercicio 1 Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for (i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo o vetor
            }//fim do for
        }//fim do método

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + vetor[i]);
            }//fim do for
        }//fim do mostrar

        // Exercicio 2 - Ler e mostrar somente os números pares
        public void PreencherNum()
            {
                for (i = 0; i <10; i++)
                {
                    Console.Write((i + 1) + "° Número: ");
                    num[i] = Convert.ToInt32((Console.ReadLine()));
                }//fim for
            }
        public void NumPar()
        {
            for (i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Os pares são: ");
                }
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
                else
                {
                    impar = impar + 1;
                }
                if (impar == 10)
                {
                    Console.WriteLine(" Não existe números impares");
                }
            }//fim for 
        }//fim metodo
        
        public double MediaAlunos()
        {
            for (i = 0; i < 20; i++)
            {
                    Console.WriteLine((i + 1) + " ª nota : ");
                    numDouble[i] = Convert.ToInt32((Console.ReadLine()));
                do
                {
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }//fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));

                ConsultarSoma = ConsultarSoma + numDouble[i];
            }
            return ConsultarSoma / i;
        }// fim do método 
        
        //Exercicio 03 - Ler os números e mostrar o Maior  

        public void MostrarPosicao()
        {
            for (i = 0; i < 25; i++)
            {
                Console.WriteLine((i + 1) + " º número: ");
                numMaior[i] = Convert.ToInt32((Console.ReadLine()));

                do
                {
                    if (numMaior[i] < 0)
                    {
                        Console.WriteLine("Informe um número positivo!!");
                    }// Fim validação
                } while (numMaior < 0);
            
            
            }// fim for
            return MostrarPosicao();
        }// fim metodo 

    }//fim da classe
}//fim do projeto