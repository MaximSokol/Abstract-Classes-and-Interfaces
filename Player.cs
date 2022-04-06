using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Interfaces
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }
        //----------------------------------

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing is in the Pause mode!");
        }
        //----------------------------------

        void IPlayable.Stop()
        {
            Console.WriteLine("The playing is in the Stop mode!");
        }
        //----------------------------------

        public void Record()
        {
            Console.WriteLine("Recording...");
        }
        //----------------------------------

        void IRecodable.Pause()
        {
            Console.WriteLine("Recording is in the Pause mode!");
        }
        //----------------------------------

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording is in the Stop mode!");
        }
        //----------------------------------
    }
}
