using ClothStock_ClassLibrary;
using System;

namespace ClothStock_WPF
{
    public static class ManagerModel
    {
        public static Stock Stock { get; set; }
        static ManagerModel()
        {
            Stock = new Stock();
            Stock.Add(new Cloth());
            Stock.Add(new Cloth("Индийский шёлк", ProducingFactory.БТК_Текстиль,
                Types.Натуральная, 200, new DateTime(2003, 12, 18), 10, Markup.десять));
        }
    }
}
