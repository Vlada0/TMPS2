using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns1
{
    abstract class Subject
    {
        public abstract void Play();
    }


    class RealProduct : Subject
    {
        public override void Play()
        {
            Console.WriteLine("Play Product");
        }
    }

    class Proxy : Subject
    {
        private RealProduct realProduct;

        public override void Play()
        {
            if (realProduct == null)
            {
                realProduct = new RealProduct();
            }
            realProduct.Play();
        }
    }
}
