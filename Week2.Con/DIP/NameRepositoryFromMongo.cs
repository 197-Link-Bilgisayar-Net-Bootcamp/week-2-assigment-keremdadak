using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.DIP
{
    internal class NameRepositoryFromMongo : INameRepository
    {
        public List<string> GetNameList()
        {
            return new List<string>() { "MONGO kerem", "MONGO kuzey", "MONGO efe", "MONGO emir", "MONGO mustafa" };
        }
    }
}
