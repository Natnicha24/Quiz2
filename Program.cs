using System;
using System.Collections.Generic;
namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberofrose, numberofsunflower;

            Console.Write("Input Total Rose : ");
            numberofrose = int.Parse(Console.ReadLine());

            Console.Write("Input Total Sun flower : ");
            numberofsunflower = int.Parse(Console.ReadLine());

        }
       

    }
    class Rose : Flower
    {
        public Rose(int id, string flowername, string description, int number, string height, string roundline) : base(id, flowername, description, number, height, roundline)
        {
            this.ID = id;
            this.FlowerName = flowername;
            this.Description = description;
            this.Number = number;
            this.Height = height;
            this.RoundLine = roundline;
        }

      
    }
    class Sunflower : Flower
    {
        public Sunflower(int id, string flowername, string description, int number, string height, string roundline) : base(id, flowername, description, number, height, roundline)
        {
            this.ID = id;
            this.FlowerName = flowername;
            this.Description = description;
            this.Number = number;
            this.Height = height;
            this.RoundLine = roundline;
        }
    }
    class Flower
    {
        public int ID;
        public string FlowerName;
        public string Description;
        public int Number;
        public string Height;
        public string RoundLine;

        public Flower(int id, string flowername, string description, int number, string height, string roundline)
        {
            this.ID = id;
            this.FlowerName = flowername;
            this.Description = description;
            this.Number = number;
            this.Height = height;
            this.RoundLine = roundline;
        }
        public void InputInformation(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("ID : ");
                ID = int.Parse(Console.ReadLine());
                Console.Write("Plant name : ");
                FlowerName = Console.ReadLine();
                Console.Write("Plant Description : ");
                Description = Console.ReadLine();
                Console.Write("Amount : ");
                Number = int.Parse(Console.ReadLine());
                Console.Write("Height : ");
                Height = Console.ReadLine();
                Console.Write("Circumference : ");
                RoundLine = Console.ReadLine();
            }
        }
        public void getFlower()
        {
            foreach (Flower flowers in flower)
            {
                Console.WriteLine(flowers.ID);
                Console.WriteLine(flowers.FlowerName);
                Console.WriteLine(flowers.Description);
                Console.WriteLine(flowers.Number);
                Console.WriteLine(flowers.Height);
                Console.WriteLine(flowers.RoundLine);

            }
        }

        private List<Flower> flower;
        public void addListFlower(Flower flowers)
        {
            flower.Add(flowers);
        }
       

    }
}
