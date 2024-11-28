using System;

class Program
{

    #region Variables
    
    // Liste de choix possible 
    public string[] choix = { "Pierre", "Feuille", "Ciseau" };

    // Choix de l'ordinateur
    static int choixOrdiIndex = rand.Next(Choix.Length);
    static string choixOrdi = Choix[choixOrdiIndex];
    static string choixUtilisateur="";
    Random rand = new Random();

    // Fonction pour mettre la première lettre en majuscule
    static string CapitalizeFirstLetter(string input)
    {
        return char.ToUpper(input[0]) + input.Substring(1);
    }

    #endregion
    
    static void choixJoueur()
    {
        do
        {
            // Demander à l'utilisateur de faire un choix
            Console.Write("Entrez votre choix entre Pierre, Feuille ou Ciseau : ");
            choixUtilisateur = Console.ReadLine();

            // Vérification si l'utilisateur a entré quelque chose 
            if (string.IsNullOrEmpty(choixUtilisateur))
            {
                Console.WriteLine("Veuille rentre un choix");
            }

            // Vérification si l'utilisateur a entré un choix valide
            if (Array.IndexOf(choixPossibles, choixUtilisateur) == -1)
            {
                Console.WriteLine("Choix invalide. Essayez encore.");
            }

        }
        while(Array.IndexOf(choixPossibles, choixUtilisateur) == -1 || string.IsNullOrEmpty(choixUtilisateur))
    }
    
    static void Main()
    {
        //choixJoueur();
        //choixOrdinateur();
        //jeu();
    }
    
}


    