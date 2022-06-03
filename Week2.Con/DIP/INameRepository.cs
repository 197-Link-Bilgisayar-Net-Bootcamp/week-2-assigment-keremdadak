using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.DIP
{
    public interface INameRepository
    {
        List<string> GetNameList();
    }
}
