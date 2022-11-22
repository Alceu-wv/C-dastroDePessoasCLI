using Data;

public class PersonRepository
{
    private List<Person> _lstPessoa = new List<Person>();
    private DummyPersons dummyPersons = new DummyPersons();

    public PersonRepository() { AdicionarDummyPersons(); }

    private void AdicionarDummyPersons()
    {
        foreach (Person person in dummyPersons.GetDummyPersons)
        {
            _lstPessoa.Add(person);
        }
    }

    public void Adicionar(Person pessoa)
    {
        _lstPessoa.Add(pessoa);
        Console.WriteLine(">>> " + pessoa.FirstName + " adicionado com sucesso.");
    }

    public List<Person> Listar()
    {
        return _lstPessoa;
    }

    public void Remover(Person pessoa)
    {
        _lstPessoa.Remove(pessoa);
        Console.WriteLine(">>> " + pessoa.FirstName + " removido com sucesso.");
    }

    public void PrintarNaTela()
    {
        foreach (Person x in _lstPessoa)
        {
            Console.WriteLine("__________");
            Console.WriteLine(x.FirstName);
            Console.WriteLine(x.LastName);
            Console.WriteLine(x.Birthday);

        }
    }
    public Person Pesquisar(string? firstName, string? lastName)
    {
        return _lstPessoa.Find(x => x.FirstName == firstName && x.LastName == lastName);

        //foreach (Person x in _lstPessoa)
        //{
        //    if (x.FirstName == firstName && x.LastName == lastName)
        //    {
        //        return x;
        //    }
        //}
    }
}
