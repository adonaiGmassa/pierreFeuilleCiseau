using System;

class Program
{
    
    #region Variables
    
    // Liste des choix possibles
    static string[] choix = { "Pierre", "Feuille", "Ciseau" };

    // Choix de l'ordinateur
    static string choixOrdi = "";
    static string choixUtilisateur = "";

    static Random rand = new Random();

    #endregion
    
    // Fonction pour mettre la première lettre en majuscule
    static string CapitalizeFirstLetter(string input)
    {
        return char.ToUpper(input[0]) + input.Substring(1).ToLower();
    }

    static void choixJoueur() s
    {
        do
        {
            // Demander à l'utilisateur de faire un choix
            Console.Write("Entrez votre choix entre Pierre, Feuille ou Ciseau : ");
            choixUtilisateur = Console.ReadLine();

            // Mettre la première lettre en majuscule
            choixUtilisateur = CapitalizeFirstLetter(choixUtilisateur);

            // Vérification si l'utilisateur a entré un choix valide
            if (Array.IndexOf(choix, choixUtilisateur) == -1)
            {
                Console.WriteLine("Choix invalide. Essayez encore.");
            }
            else
            {
                break;
            }

        }
        while (Array.IndexOf(choixPossibles, choixUtilisateur) == -1 || string.IsNullOrEmpty(choixUtilisateur));
    }

    static void choixOrdinateur()
    {
        // Générer un choix aléatoire pour l'ordinateur
        int choixOrdiIndex = rand.Next(choix.Length);
        choixOrdi = choix[choixOrdiIndex];
        
        // Affichage du choix de l'ordinateur
        Console.WriteLine("L'ordinateur a choisi : " + choixOrdi);
    }

    static void jeu()
    {
        // Comparaison des choix de l'utilisateur et de l'ordinateur
        if (choixUtilisateur == choixOrdi)
        {
            Console.WriteLine("C'est une égalité!");
        }
        else
        {
            if ((choixUtilisateur == "Pierre" && choixOrdi == "Ciseau") || 
                (choixUtilisateur == "Feuille" && choixOrdi == "Pierre") ||
                (choixUtilisateur == "Ciseau" && choixOrdi == "Feuille"))
            {
                Console.WriteLine("Vous avez gagné!");
            }
            else
            {
                Console.WriteLine("L'ordinateur a gagné !");
            }
        }
    }

    static void Main()
    {
        // Appeler les différentes fonctions pour jouer
        choixJoueur();
        choixOrdinateur();
        //jeu();
    }

}


    