using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_desenvolvimento
{
    public class AddPerson
    {
        PersonRepository personRepository;
        InputString inputString = new InputString();
        
        public AddPerson(PersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public void Add()
        {
            string firstName;
            string lastName;
            string birthday;

            try
            {
                firstName = inputString.InputStringFromUser("Digite o seu primeiro nome:");
                lastName = inputString.InputStringFromUser("Digite o seu sobrenome:");
                birthday = inputString.InputStringFromUser("Digite sua data de aniversário (formato: dd/mm/yyyy:)");

                Person p = new Person(firstName, lastName, birthday);

                personRepository.Adicionar(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
