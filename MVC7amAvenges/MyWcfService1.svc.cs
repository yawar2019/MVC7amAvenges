using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MVC7amAvenges
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyWcfService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyWcfService1.svc or MyWcfService1.svc.cs at the Solution Explorer and start debugging.
    public class MyWcfService1 : IMyWcfService1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void DoWork()
        {
        }
    }
}
