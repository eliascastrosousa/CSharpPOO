using System;

namespace ExercicioResolvido01.Entities
{
    internal class Departament
    {
        public string Name { get; set; }

        public Departament() //construtor padrão
        {

        }

        public Departament(string name)
        {
            Name = name;
        }


    }
}
