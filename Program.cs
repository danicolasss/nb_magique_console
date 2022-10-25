using System;
namespace nb_magique_console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int nombreMagique = 5;
            Console.WriteLine("Devinez le nombre magique");
            string resultat =Console.ReadLine();

            int nombreUtilisateur = 0; 
            if (int.TryParse(resultat,out nombreUtilisateur))
                // la conversion c'est bien passée
            {
                if(nombreUtilisateur < nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus grand.");
                }
                else if (nombreUtilisateur > nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus petit.");
                }
                else
                {// égalite le joueur a gagné
                    Console.WriteLine("Bravo vous avez touvez le nombre magique");
                }
            }
            else
            //erreur de la conversion
            {
                Console.WriteLine("Erreur vous devez rentrer un nombre");
            }
        }
    }
}