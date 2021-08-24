using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataModels.Interfaces
{
    internal interface IDrink
    {
        void DrinkAmount(int ml);
        void DrinkAll();
    }
}
