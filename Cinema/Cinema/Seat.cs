using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Seat
    {
        public int Row;
        public int Column;
        public bool Status=true;

        public Seat(int row,int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return $"Cerge: {Row} , sira: {Column} , status:{Status}";
        }
    }
}
