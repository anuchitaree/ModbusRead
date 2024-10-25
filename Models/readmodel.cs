using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusRead.Models
{
    public class Readmodel
    {
        public int Id { get; set; }
        public int Reg { get; set; }
        public string Address { get; set; }    
        public string DecString { get; set; }
        public int    DecValue { get; set; }
        public string HexString { get; set; }
        public int    Int32Value { get; set; }
    }
}
