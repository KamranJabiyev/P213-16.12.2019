using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Hall
    {
        public string Name;
        public Seat[,] seats;


        public Hall(string name,int row, int column)
        {
            Name = name;
            seats = new Seat[row, column];
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < column; i++)
                {
                    seats[j, i] = new Seat(j + 1, i + 1);
                }
            }
        }

        public void ShowAllSeat()
        {
            for (int j = 0; j < seats.GetLength(0); j++)
            {
                for (int i = 0; i < seats.GetLength(1); i++)
                {
                    Console.WriteLine(seats[j, i]);
                }
            }
        }

        public void Reserve(int row,int column)
        {
            if (seats[row - 1, column - 1].Status)
            {
                seats[row - 1, column - 1].Status = false;
                Console.WriteLine($"cerge: {row},sira: {column} rezerv etdiniz");
            }
            else
            {
                Console.WriteLine("Bu yer doludur");
            }
        }
    }
}
