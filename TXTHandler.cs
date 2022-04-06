using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Interfaces
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("The TXT file was opened in the TXTHandler!");
        }
        //------------------------------

        public override void Create()
        {
            Console.WriteLine("The TXT file was created in the TXTHandler!");
        }
        //------------------------------

        public override void Change()
        {
            Console.WriteLine("The TXT file was changed in the TXTHandler!");
        }
        //------------------------------

        public override void Save()
        {
            Console.WriteLine("The TXT file was saved in the TXTHandler!");
        }
        //------------------------------
    }
}
