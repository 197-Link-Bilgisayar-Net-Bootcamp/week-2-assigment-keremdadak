using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Con.OCP
{
    public class TypeManagement
    {
        public abstract class Role
        {
            public abstract void Decision();
        }

        public class Manager : Role
        {
            public override void Decision()
            {
                Console.WriteLine("The person is Manager\n");
            }
        }

        public class Chef : Role
        {
            public override void Decision()
            {
                Console.WriteLine("The person is Chef \n");
            }
        }

        public class Waiter : Role
        {
            public override void Decision()
            {
                Console.WriteLine("The person is Waiter\n");
            }
        }
        public class Cleaner : Role
        {
            public override void Decision()
            {
                Console.WriteLine("The person is Cleaner\n");
            }
        }
        public class RoleDecision
        {
            public void ProduceVehicle(Role role)
            {
                role.Decision();
            }
        }

    }
}
