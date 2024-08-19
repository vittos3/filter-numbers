﻿namespace FilterNumbers 
{
    class Program { 
        static void Main(string[] args) {

        }

        static void ListGenerate(int start, int end) 
        {
            if(start > end)  
            { 
                Console.WriteLine("O número inicial não pode ser maior que o final.");
                return;
            }

            List<int> listNumbers = NumbersListGenerate(start, end);

            
        }

    

        //Cria lista de números dentro do intervalo
        static List<int> NumbersListGenerate(int start, int end) 
        {
            List<int> listInterval = new List<int>();  

            for(int i = start; i <= end; i++) 
            { 
                listInterval.Add(i);
            }
                
            return listInterval;
        }


            //Cria lista de números pares
        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach(int number in numbers) { 
                if(number % 2 == 0)
                    evenNumbers.Add(number);
            }
            return evenNumbers; 
        }

        //Cria lista de números ímpares     
        static List<int> OddNumbers(List<int> numbers) 
         {
            List<int> oddNumbers = new List<int>();

            foreach(int number in numbers) { 
                if(number % 2 != 0)
                    oddNumbers.Add(number);
            }

            return oddNumbers; 
        }

        
        static List<int> multipleNumber(List<int> numbers, int numberM)  {

            List<int> multipleListNumbers = new List<int>();


            foreach (int number in numbers) {

                if(number % numberM == 2) { 
                    multipleListNumbers.Add(number);
                }
            }


            return multipleListNumbers;
        }
    }
}