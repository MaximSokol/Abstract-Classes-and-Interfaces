using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Interfaces
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("The XML file was opened in the HMLHandler!");
        }
        //------------------------------

        public override void Create()
        {
            Console.WriteLine("The XML file was created in the XMLHandler!");
        }
        //------------------------------

        public override void Change()
        {
            Console.WriteLine("The XML file was changed in the XMLHandler!");
        }
        //------------------------------

        public override void Save()
        {
            Console.WriteLine("The XML file was saved in the XMLHandler!");
        }
        //------------------------------
    }
}
