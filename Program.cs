using System;
namespace nb_magique_console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int nombreDeVies = 0;
            Random r = new Random();
            const int max = 10;
            const int min = 1;
            int nbRandom = r.Next(min,max);
            int nombreMagique = nbRandom;
            const int NOMBRE_DE_VIES = 4;
            for(nombreDeVies = NOMBRE_DE_VIES;nombreDeVies > 0;nombreDeVies--)
            {
                Console.WriteLine("Devinez le nombre magique compris entre "+min+" et "+ max+" (il vous reste "+ nombreDeVies +" vies ): ");
                string resultat = Console.ReadLine();
                int nombreUtilisateur = 0;
                if (int.TryParse(resultat, out nombreUtilisateur))
                // la conversion c'est bien passée
                {
                    if ((nombreUtilisateur > max )|| (nombreUtilisateur < min))
                    {
                        Console.WriteLine("Attention le nombre magique est compris entre " + min + " et " + max);
                        nombreDeVies++;
                       
                    }
                    else
                    {
                        if (nombreUtilisateur < nombreMagique)
                        {
                            Console.Write("Le nombre magique est plus grand: ");
                        }
                        else if (nombreUtilisateur > nombreMagique)
                        {
                            Console.WriteLine("Le nombre magique est plus petit.");
                        }
                        else
                        {// égalite le joueur a gagné
                            Console.WriteLine("Bravo vous avez touvez le nombre magique");
                            break;
                        }
                    }
                    
                }
                else
                //erreur de la conversion
                {
                    Console.WriteLine("Erreur vous devez rentrer un nombre");
                }
                Console.WriteLine("");
            }
            // sortie de la boucle
            if(nombreDeVies == 0)
            {
                Console.WriteLine("Désolé, vous avez perdu le nombre magique était "+ nombreMagique);
            }
            
        }
    }
}