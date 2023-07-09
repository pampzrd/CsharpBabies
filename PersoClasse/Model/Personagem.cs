using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersoClasse.Model
{
    public class Personagem
    {
        public  string Nome { get; set; }
        public  string Apelido { get; set; }
        public int Idade { get; set; }
    
        public void Fala()
        {
            Console.WriteLine($"Eu sou o {Nome}, também conhecido como {Apelido}. Tenho {Idade} anos.");
        }
    }
}