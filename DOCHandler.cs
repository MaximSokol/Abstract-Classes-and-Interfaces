using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Interfaces
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("The DOC file was opened in the DOCHandler!");
        }
        //------------------------------

        public override void Create()
        {
            Console.WriteLine("The DOC file was created in the DOCHandler!");
        }
        //------------------------------

        public override void Change()
        {
            Console.WriteLine("The DOC file was changed in the DOCHandler!");
        }
        //------------------------------

        public override void Save()
        {
            Console.WriteLine("The DOC file was saved in the DOCHandler!");
        }
        //------------------------------
    }
}
