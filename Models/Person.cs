namespace DesafioProjetoHospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string nome, string lastName)
    {
        Name = nome;
        LastName = lastName;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string CompleteName => $"{Name} {LastName}".ToUpper();
}