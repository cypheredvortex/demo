// See https://aka.ms/new-console-template for more information
using System;

public class Personne
{
    public String nom { get; set; }
    public String prenom { get; set; }
    public int age { get; set; }
    public Personne(String nom, String prenom, int age)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.age = age;
    }
    public override string ToString()
    {
        return $"Nom: {nom}, Prénom: {prenom}, Âge: {age}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Personne personne1 = new Personne("Dupont", "Jean", 30);
        Personne personne2 = new Personne("Martin", "Sophie", 25);
        Console.WriteLine(personne1.ToString());
        Console.WriteLine(personne2.ToString());
    }
}