using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.DIP
{
    internal class NameService
    {
        private readonly INameRepository _nameRepository;

        public NameService(INameRepository nameRepository)
        {
            _nameRepository = nameRepository;
        }
        public List<string> GetName()
        {


            return _nameRepository.GetNameList();
        }
    }
}
