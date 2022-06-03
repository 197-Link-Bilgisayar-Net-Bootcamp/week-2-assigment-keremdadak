using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week2.Con.ISP
{
    public  class AnimalType
    {
        public interface IFlying
        {
            void fly();
        }
        public interface IRuning
        {
            void run();
        }
        public interface IBite
        {
            void bite();
        }
        public class Bird : IFlying
        {
            public void fly()
            {
                Console.WriteLine("Kuş Uçabilir");
            }
        }
        public class Cat : IFlying,IRuning,IBite
        {
            public void bite()
            {
                Console.Write("Kedi Tırmalayabilir ve Isırabilir");
            }

            public void fly()
            {
                Console.WriteLine("Kuş Uçabilir");
            }

            public void run()
            {
                Console.Write("Kedi Koşabilir."); ;
            }
        }
        public class Crocodile : IBite
        {
            public void bite()
            {
                Console.Write("Timsah Isırabilir");
            }

            
        }
    }
}
