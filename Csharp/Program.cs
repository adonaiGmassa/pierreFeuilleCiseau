using System;

class Program
{
    #region Variables
    // Choix possible 
    public string[] choix = { "Pierre", "Feuille", "Ciseau" };
    Random rand = new Random();
    // Choix de l'ordinateur
    static int choixOrdiIndex = rand.Next(Choix.Length);
    static string choixOrdi = Choix[choixOrdiIndex];

    // Fonction pour mettre la première lettre en majuscule
    static string CapitalizeFirstLetter(string input)
    {
        return char.ToUpper(input[0]) + input.Substring(1);
    }
    #endregion
        
    
}
static void Main()
    {

    }

    