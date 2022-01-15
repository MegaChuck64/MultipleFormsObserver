using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class StaticComport
    {
        //Creating my own event, like a forms onClick function
        public static event EventHandler BufferChanged;

        public static string[] Buffer;
        public static void PopulateBuffer()
        {

            var rand = new System.Random();
            var numLines = rand.Next(20);
            var lineSize = rand.Next(20);

            Buffer = new string[numLines];

            for (int i = 0; i < numLines; i++)
            {
                var newLine = "";
                
                for (int j = 0; j < lineSize; j++)
                {
                    //65 is 'A'
                    newLine += (char)rand.Next(65, 65 + 26);
                }
                Buffer[i] = newLine;
            }

            //notice form events (OnClick), get passed and object(sender), and eventArgs
            //im just sending null, cuz this is static, doesn't matter
            BufferChanged.Invoke(null, EventArgs.Empty);
        }


    }
}
