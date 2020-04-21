using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2MM
{
    class ModFile
    {

        public string Name { get; set; }

        public string Path { get; set; }

        public string TFDir { get; set; }

        public bool Active { get; set; }

        public ModFile()
        {

        }

        public ModFile(string pName, string pPath, string pTFDir, bool pActive)
        {
            Name = pName;
            Path = pPath;
            TFDir = pTFDir;
            Active = pActive;
        }

    }
}
