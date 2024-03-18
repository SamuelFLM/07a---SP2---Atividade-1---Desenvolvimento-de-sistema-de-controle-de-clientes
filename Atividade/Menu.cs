using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Menu
    {
        public void Inicial()
        {
            Console.Clear();
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▀ █░░ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █▄▄ █ ██▄ █░▀█ ░█░ ██▄" + "\n\n");

            Console.WriteLine(@"
█▀▄▀█ █▀▀ █▄░█ █░█
█░▀░█ ██▄ █░▀█ █▄█ ");
            Console.WriteLine("\n1 - Pessoa Fisica\n");
            Console.WriteLine("\n2 - Pessoa Jurídica\n");
            Console.Write("\nDigite: ");
        }
        public void InformacoesBasicas()
        {
            Console.Clear();
            Console.WriteLine(@"
█ █▄░█ █▀▀ █▀█ █▀█ █▀▄▀█ ▄▀█ █▀▀ █▀█ █▀▀ █▀   █▄▄ ▄▀█ █▀ █ █▀▀ ▄▀█ █▀
█ █░▀█ █▀░ █▄█ █▀▄ █░▀░█ █▀█ █▄▄ █▄█ ██▄ ▄█   █▄█ █▀█ ▄█ █ █▄▄ █▀█ ▄█" + "\n\n");
        }

        public void Fisica()
        {
            Console.Clear();
            Console.WriteLine(@"
█▀█ █▀▀ █▀ █▀ █▀█ ▄▀█   █▀▀ █ █▀ █ █▀▀ ▄▀█
█▀▀ ██▄ ▄█ ▄█ █▄█ █▀█   █▀░ █ ▄█ █ █▄▄ █▀█" + "\n\n");
        }
        public void Juridica()
        {
            Console.Clear();
            Console.WriteLine(@"
█▀█ █▀▀ █▀ █▀ █▀█ ▄▀█   ░░█ █░█ █▀█ █ █▀▄ █ █▀▀ ▄▀█
█▀▀ ██▄ ▄█ ▄█ █▄█ █▀█   █▄█ █▄█ █▀▄ █ █▄▀ █ █▄▄ █▀█" + "\n\n");
        }
    }
}