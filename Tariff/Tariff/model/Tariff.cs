using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tariff
{
    [Serializable]
    class Tariff : IReadOnlyTariff
    {
        private static int _id;

        public int Id { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }
        public int Minutes { get; private set; }
        public int Gygabytes { get; private set; }
        public int Messages { get; private set; }

        static Tariff()
        {
            _id = 0;
        }

        public Tariff(string name, int minutes, int gygabytes, int messages, int price)
        {
            Id = ++_id;
            Minutes = minutes;
            Gygabytes = gygabytes;
            Messages = messages;
            Price = price;
            Name = name;
        }

        public void Update(int price, int minutes, int gygabytes, int messages, string name)
        {
            if (price > 0)
                Price = price;
            if (minutes > 0)
                Minutes = minutes;
            if (gygabytes > 0)
                Gygabytes = gygabytes;
            if (messages > 0)
                Messages = messages;
            if (string.IsNullOrWhiteSpace(name) == false)
                Name = name;
        }

        public override string ToString() => Name; 
    }

    public interface IReadOnlyTariff
    {
        int Id { get; }
        double Price { get; }
        string Name { get; }
        int Minutes { get; }
        int Gygabytes { get; }
        int Messages { get; }
    }
}
