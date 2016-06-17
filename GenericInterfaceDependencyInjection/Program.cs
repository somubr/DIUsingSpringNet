using GenericInterfaceDataModel;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IApplicationContext applicationContext = ContextRegistry.GetContext();


            var vat = (ITaxRepository<StateRequest, StateResponse>)applicationContext["TaxCalculatorState"];
            //container.Res

            Console.WriteLine(vat.GetVat(new StateRequest { TaxRate = 12 }));
            Console.ReadLine();
        }
    }
}
