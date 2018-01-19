using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Factory
    {
        public static IFactoredElement Create(string criterion)
        {

            switch (criterion)
            {
                case "element1":
                    return new Element1();
                case "element2":
                    return new Element2();
                default:
                    return null;
            }

        }
    }
}
