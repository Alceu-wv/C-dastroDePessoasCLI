using System;


public class Person
    {
        private string? _firstName;
        private string? _lastName;
        private string? _birthday;

        public Person() { }
        public Person(string firstName, string lastName, string birthday)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthday = birthday;
        }


        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string? LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string? Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                //if ((value != "Masculino") && (value != "Feminino"))
                //{
                //    throw new Exception("Valor inválido para Sexo.");
                //}
                _birthday= value;
            }
        }
    }