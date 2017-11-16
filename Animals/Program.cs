using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Land l = new Land("Dog", 20);
            Sea s = new Sea("Fish", 10);
            Air b = new Air("Bird", 5);

            l.Move();
            s.Move();
            b.Move();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        //public DateTime Dob { get; set; }
        public int Weight { get; set; }

        public Animal(string n, int w)
        {
            Name = n;
            Weight = w;
        }

        public virtual void Move()
        {
            Console.WriteLine("Move!");
        }
    }

    class Land : Animal
    {
        public Land(string n, int w) : base(n, w)
        {
        }

        //public override void Move()
        //{
        //    Console.WriteLine("Run!");
        //}
    }

    class Sea : Animal
    {
        public Sea(string n, int w) : base(n, w)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Swim!");
        }

    }

    class Air : Animal
    {
        public Air(string n, int w) : base(n, w)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Fly!");
        }
    }
}
