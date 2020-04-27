using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns1.Bridge
{
    
    //базовый класс для способов просмотра 
    abstract class WayToWatch
    {
        abstract public void watch();
    }
    //реализация различных способов 
    class TVWayToWatch : WayToWatch
    {
        override public void watch()
        {
            Console.WriteLine("Watch on TV");
        }
    }
    class DVDWayToWatch : WayToWatch
    {
        override public void watch()
        {
            Console.WriteLine("Watch on DVD");
        }
    }

    abstract class Product  //abstraction
    {
        protected WayToWatch wayToWatch;
        abstract public void watchProduct();
        public WayToWatch WayToWatch
        {
            get { return wayToWatch; }
            set { wayToWatch = value; }
        }
    }
    //конкретные предметы
    class Film : Product
    {
        override public void watchProduct()
        {
            wayToWatch.watch();
        }
    }
    class Mult : Product
    {
        override public void watchProduct()
        {
            wayToWatch.watch();
        }
    }
}
