﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns1.Composite
{
    abstract class Component
    {
        public string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Print();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
       
    }
    class Directory : Component
    {
        public List<Component> components = new List<Component>();

        public Directory(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Узел:\n" + name);
            Console.WriteLine("Подузлы:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }

    class File : Component
    {
        public File(string name)
                : base(name)
        { }
        public override void Print()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
        }

        public override void Remove(Component component)
        {   
        }
    }
}
