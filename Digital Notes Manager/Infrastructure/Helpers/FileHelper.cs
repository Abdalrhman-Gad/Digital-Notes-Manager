using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Infrastructure.Helpers
{
    public static class FileHelper
    {
        public static void SaveFile(string path, byte[] data)
        {
            File.WriteAllBytes(path, data);
        }
    }
}
