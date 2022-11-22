
using Helpers;
using TP3_desenvolvimento;

public class Programa
{
    
    static void Main(string[] args) {

        PersonRepository personRepository = new();
        AddPerson addPerson = new(personRepository);
        SearchPerson searchPerson = new(personRepository);
        InputNumber inputNumber = new();
        int userOperationChoice = 0;

        while(userOperationChoice != 4)
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Pesquisar pessoas");
            Console.WriteLine("2 - Listar todas as pessoas");
            Console.WriteLine("3 - Adicionar pessoa");
            Console.WriteLine("4 - Sair");
            userOperationChoice = (int)inputNumber.InputNumberFromUser("______________");

            switch (userOperationChoice)
            {
                case 1:
                    searchPerson.Search();
                    Console.WriteLine("__________");
                    break;
                case 2:
                    searchPerson.ListAll();
                    Console.WriteLine("__________");
                    break;
                case 3:
                    addPerson.Add();
                    Console.WriteLine("__________");
                    break;
                case 4:
                    Console.WriteLine(">>> Tchau. Volte sempre.");
                    break;
            }
        }

    }
}