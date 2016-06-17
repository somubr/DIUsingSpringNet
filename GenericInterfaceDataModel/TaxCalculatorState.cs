using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDataModel
{
    public class TaxCalculatorState<T,t>:ITaxRepository<T,t>
    {
        public t GetVat(T request)
        {
            throw new NotImplementedException();
        }
    }
}
