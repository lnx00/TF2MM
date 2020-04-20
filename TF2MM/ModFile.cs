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

        public string File { get; set; }

        public bool Active { get; set; }

        public ModFile()
        {

        }

        public ModFile(string pName, string pFile, bool pActive)
        {
            Name = pName;
            File = pFile;
            Active = pActive;
        }

    }
}
