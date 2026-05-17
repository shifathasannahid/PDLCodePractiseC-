using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accesmodifier;

namespace PropertyMethod
{
    public class Employee : Person

    {
        public void Show()
        {
            Address = "Dhaka";
            showAddress();
        }
    }
}
