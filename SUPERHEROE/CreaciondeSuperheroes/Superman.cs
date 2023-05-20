using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciondeSuperheroes
{
    internal class Superman : ISuperheroe
    {
        public string nombre { get; set; }
        public int fuerza { get; set; }
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int agilidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void volar()
        {
            Console.WriteLine("Superman vuela");
        }

        public void salvarElMundo()
        {
            Console.WriteLine("Superman salva el mundo");
        }

        public void presentarse()
        { 
            Console.WriteLine("Hola Superman");
        }
    }
}
