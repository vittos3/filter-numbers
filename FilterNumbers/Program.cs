namespace FilterNumbers 
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

            List<int> listNumbers = numbersListGenerate(start, end);

            
        }

        //Cria lista de números pares
        static List<int> evenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach(int number in numbers) { 
                if(number % 2 == 0)
                    evenNumbers.Add(number);
            }
            return evenNumbers; 
        }


        //Cria lista de números dentro do intervalo
        static List<int> numbersListGenerate(int start, int end) 
        {
            List<int> listInterval = new List<int>();  

            for(int i = start; i <= end; i++) 
            { 
                listInterval.Add(i);
            }
                
            return listInterval;
        }


        
    }
}