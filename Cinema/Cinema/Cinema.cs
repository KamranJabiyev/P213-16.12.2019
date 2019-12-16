using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        private static int index = 0;
        public string CinemaName;
        private Hall[] halls;

        public Cinema(int maxHallCount,string name)
        {
            halls = new Hall[maxHallCount];
            CinemaName = name;
        }

        public void AddHall(Hall hall)
        {
            if (index < halls.Length)
            {
                halls[index] = hall;
                index++;
                Console.WriteLine($"{hall.Name} {CinemaName} kinoteatrina elave olundu");
            }
            else
            {
                Console.WriteLine($"{hall.Name} elave ede bilmersiniz");
            }
            
        }
    }
}
