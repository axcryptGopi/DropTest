using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTest.Platforms.MacCatalyst
{
    public class FileDropBox : View
    {
        public event Action<string> FileDropped;

        public void RaiseFileDropped(string path)
        {
            FileDropped?.Invoke(path);
        }
    }
}
