using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.DIP
{
    internal class NameRepository : INameRepository
    { 
        public List<string> GetNameList()
        {
            return new List<string>() { "kerem", "kuzey", "efe","emir","mustafa" };
        }
    }
}
