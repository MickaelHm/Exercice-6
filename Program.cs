﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecrivez votre Nom");
            string lastname = (Console.ReadLine());

            Console.WriteLine("Ecrivez votre Prénom");
            string name = (Console.ReadLine());

            Console.WriteLine("Ecrivez votre année de naissance");
            int birthday = int.Parse(Console.ReadLine());

            Console.WriteLine("Fiche de renseignement" + Environment.NewLine + Environment.NewLine + lastname + Environment.NewLine + name + Environment.NewLine + (DateTime.Now.Year - birthday));

        }
    }
}
