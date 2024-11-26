using System;

class Program
{
    public string[] choices = { "Pierre", "Feuille", "Ciseau" };
    Random rand = new Random();
    // Choix de l'ordinateur
    int computerChoiceIndex = rand.Next(choices.Length);
    string computerChoice = choices[computerChoiceIndex];

    // Fonction pour mettre la première lettre en majuscule
    static string CapitalizeFirstLetter(string input)
    {
        return char.ToUpper(input[0]) + input.Substring(1);
    }
        
    
}


    static void Main()
    {

    }

    