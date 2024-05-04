using System;

namespace AnimalHierarchy
{
    public abstract class LivingCreature
    {
        public int Speed { get; protected set; }

        public abstract void Move();
        public abstract void Stand();
    }

    public class Panther : LivingCreature
    {
        public bool IsOnTree { get; private set; }

        public Panther()
        {
            Speed = 0;
            IsOnTree = false;
        }

        public void ClimbTree()
        {
            IsOnTree = true;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 1, 10);
        }

        public override void Stand()
        {
            Speed = 0;
            IsOnTree = false;
        }

        public void Roar()
        {
            Console.WriteLine("Panther roars!");
        }
    }

    public class Dog : LivingCreature
    {
        public Dog()
        {
            Speed = 0;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 1, 10);
        }

        public override void Stand()
        {
            Speed = Math.Max(Speed - 1, 0);
        }

        public void Bark()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    public class Turtle : LivingCreature
    {
        public Turtle()
        {
            Speed = 0;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 1, 10);
        }

        public override void Stand()
        {
            Speed = Math.Max(Speed - 1, 0);
        }
    }
}
