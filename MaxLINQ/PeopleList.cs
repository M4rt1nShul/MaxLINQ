using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                IQ = 120,
                Kõrgus = 169,
                Raha = 2500,

                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 21,
                IQ = 110,
                Kõrgus = 178,
                Raha = 5500,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                IQ = 124,
                Kõrgus = 190,
                Raha = 1000,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 4,
                Name = "Jane",
                Age = 20,
                IQ = 134,
                Kõrgus = 175,
                Raha = 100000,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                IQ = 98,
                Kõrgus = 188,
                Raha = 1200,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
                IQ = 75,
                Kõrgus = 195,
                Raha = 6400,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },

        };
    }
}