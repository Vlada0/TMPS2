using StructuralPatterns1;
using StructuralPatterns1.Bridge;
using StructuralPatterns1.Composite;
using StructuralPatterns1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuralPatterns1
{ 
 class Program
{
        static void Main(string[] args)
        {
            //adapter
            Console.WriteLine("Pattern Adapter\n");
            ITarget target = new Adapter();
            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");
            List<string> list = target.GetFilmList();
            foreach (string s in list)
            {
                Console.WriteLine("Film: " + s + "\n");
            }

            //decorator
            Console.WriteLine("\n\nPattern Decorator\n");

            //film
            ConcreteComponentFilm ccFilm = new ConcreteComponentFilm();
            Console.WriteLine(ccFilm.GetName());


            // add effects
            EffectsDecorator eFilm = new EffectsDecorator(ccFilm);
            Console.WriteLine(eFilm.GetName());

            // add graphics
            GraphicsDecorator gFilm = new GraphicsDecorator(eFilm);
            Console.WriteLine(gFilm.GetName());

            // add subtitles
            SubTitlesDecorator sFilm = new SubTitlesDecorator(gFilm);
            Console.WriteLine(sFilm.GetName());

            // mult
            ConcreteComponentMult ccMult = new ConcreteComponentMult();
            Console.WriteLine(ccMult.GetName());
            // add effects, graphics and subtitles
            EffectsDecorator eMult = new EffectsDecorator(ccMult);
            GraphicsDecorator gMult = new GraphicsDecorator(eMult);
            SubTitlesDecorator sMult = new SubTitlesDecorator(gMult);
            Console.WriteLine(sMult.GetName());

            //composite
            Console.WriteLine("\n\nComposite\n");
            Component fileSystem = new Directory("File System");
            // определяем новый диск
            Component diskC = new Directory("Disk C");
            // новые файлы
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");
            //добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // выводим все данные
            fileSystem.Print();
            Console.WriteLine("________________");
            // удаляем с диска С файл
            diskC.Remove(pngFile);
            // создаем новую папку в диске С
            Component docsFolder = new Directory("My Documents");
            // добавляем в нее файлы
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);
            fileSystem.Print();

            //proxy
            Console.WriteLine("\n\nPattern Proxy\n");
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Play();

            //bridge
            Console.WriteLine("\n\nPattern Bridge\n");
            Product prFilm = new Film();
            Console.WriteLine("\nFilm\n");
            prFilm.WayToWatch = new TVWayToWatch();
            prFilm.watchProduct();
            prFilm.WayToWatch = new DVDWayToWatch();
            prFilm.watchProduct();

            Product prMult = new Mult();
            Console.WriteLine("\n\nMult\n");
            prMult.WayToWatch = new TVWayToWatch();
            prMult.watchProduct();
            prMult.WayToWatch = new DVDWayToWatch();
            prMult.watchProduct();

            Console.Read();
        }
    }
}
