using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice21
{
    class Program
    {
        static void Main(string[] args)
        {
            char couleur;
            // boucle sur le choix des couleurs tant que le bon caractère n'a pas été saisi
            do
            {
                Console.Write("Saisir une couleur de feu (Rouge=Rouge/O=Orange/V=Vert) = ");
                couleur = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (couleur != 'R' && couleur != 'O' && couleur != 'V');
         /*   
            if (couleur == 'R')
            {
                Console.Write("S'arrêter !");
            }
            else
            {
                if (couleur == 'O')
                {
                    Console.Write("Ralentir...");
                }
                else
                {
                    Console.Write("Passer !!!");
                }
            }
          */
         switch (couleur)
            {
                case 'R':
                    Console.Write("S'arrêter !");
                    break;
                case 'O':
                    Console.Write("Ralentir...");
                    break;
                case 'V':
                    Console.Write("Passer !!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
