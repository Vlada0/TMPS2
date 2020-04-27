using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns1.Decorator
{
    public abstract class ProductComponent
    {
        public abstract string GetName();
    }

    class ConcreteComponentFilm : ProductComponent
    {
        private string m_Name = "Film";

        public override string GetName()
        {
            return m_Name;
        }
    }

    class ConcreteComponentMult : ProductComponent
    {
        private string m_Name = "Mult";

        public override string GetName()
        {
            return m_Name;
        }
    }

    public abstract class Decorator : ProductComponent
    {
        ProductComponent m_BaseComponent = null;

        protected string m_Name;

        public Decorator(ProductComponent baseComponent)
        {
            this.m_BaseComponent = baseComponent;
        }

        public override string GetName()
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
        }
    }

    class EffectsDecorator : Decorator
    {
        public EffectsDecorator(ProductComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Are effects";
        }

        public override string GetName()
        {
            return string.Format("{0}", base.GetName());
        }
    }

    class GraphicsDecorator : Decorator
    {
        public GraphicsDecorator(ProductComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Are graphics";
        }

        public override string GetName()
        {
            return string.Format("{0}", base.GetName());
        }
    }

    class SubTitlesDecorator : Decorator
    {
        public SubTitlesDecorator(ProductComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Are subtitles";
        }

        public override string GetName()
        {
            return string.Format("{0}", base.GetName());
        }
        
    }

}
