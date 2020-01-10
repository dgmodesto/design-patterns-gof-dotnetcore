using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Animal
    {
        public string nome { get; set; }
        public string classe { get; set; }

        public Animal(string nome, string classe)
        {
            this.nome = nome;
            this.classe = classe;
        }
    }
}
