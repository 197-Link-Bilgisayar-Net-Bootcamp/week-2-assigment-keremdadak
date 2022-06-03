using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.LSP
{
    public interface IFlying
    {
        void Flying();
    }
    public abstract class Animal
    {
        public void Talk()
        {
            Console.WriteLine("Hayvan konuşabiliyor.");
        }
    }
    public class Bird : Animal, IFlying
    {
        public void Flying()
        {
            Console.WriteLine("Hayvan uçabiliyor.");
        }
    }
    public class Dog : Animal
    {

    }
}
