using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class FileRoot
    {
        public static string fileRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
