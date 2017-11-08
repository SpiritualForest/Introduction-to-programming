using System;
using Edibles;
using Edibles.Fruits;

namespace Animals {
    class Monkey {
        public string Name { get; set; }

        public Monkey(string name) {
            Name = name;
        }
        public void Eat(Edible edibleItem) {
            Console.WriteLine("{0} (a {1}) is eating a {2}...", Name, this.GetType().Name, edibleItem.GetType().Name);
        }
    }
}
