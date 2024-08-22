namespace FilterNumbers 
{
    class Program { 
        static void Main(string[] args) {

            ListGenerate(5,15,3,3);            
        }

        static void ListGenerate(int start, int end, int codOperation, int multNumber = 0) 
        {
            List<int> listNumbers = NumbersListGenerate(start, end);
            List<int> oddNumbers = OddNumbers(listNumbers);
            List<int> evenNumbers = EvenNumbers(listNumbers);
            List<int> multipleNumbers = [];

            if(start > end)  
            { 
                Console.WriteLine("O número inicial não pode ser maior que o final.");
                return;
            }

            if(codOperation == 3) 
            { 
                if(multNumber == 0) 
                { 
                    Console.WriteLine("Não é possível realizar a operação. O número passado foi 0");
                    return;
                } 
                else 
                { 
                    multipleNumbers  = MultipleNumber(listNumbers,multNumber);
                }   
            }
           
            
            switch(codOperation) 
            { 
                case 1: 
                    Console.WriteLine(string.Join(", ", oddNumbers)); 
                    break; 
                case 2: 
                    Console.WriteLine(string.Join(", ", evenNumbers)); 
                    break;
                case 3: 
                    Console.WriteLine(string.Join(", ", multipleNumbers)); 
                    break; 
                default: 
                     Console.WriteLine("Não foi possível realizar a operação. Tente novamente");
                     break;
            }
        }

        static List<int> MultipleNumber(List<int> numbers, int numberM)  {

                List<int> multipleListNumbers = [];

                foreach (int number in numbers) {
                    if(number % numberM  == 0) { 
                        multipleListNumbers.Add(number);
                    }
                }


                return multipleListNumbers;
            }

        //Cria lista de números dentro do intervalo
        static List<int> NumbersListGenerate(int start, int end) 
        {
            List<int> listInterval = new List<int>();  

            for(int i = start + 1; i < end; i++) 
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

        //Retorna lista de números que são multiplos de numberM
        
    }
}