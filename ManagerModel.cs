using ClothStock_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothStock_WPF
{
    public class ManagerModel
    {
        public static Stock Stock { get; set; }
        public ManagerModel()
        {
            Stock = new Stock();
            Stock.Add(new Cloth());
            Stock.Add(new Cloth("Индийский шёлк", ProducingFactory.БТК_Текстиль,
                Types.Натуральная, 200, new DateTime(2003, 12, 18), 10, Markup.десять));
        }
    }
}
