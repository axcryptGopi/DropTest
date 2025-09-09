using CoreGraphics;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace DropTest.Platforms.MacCatalyst
{
    public class FileDropViewHandler : ViewHandler<FileDropBox, UIView>
    {
        public FileDropViewHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override UIView CreatePlatformView()
        {
            return new FileDropView(CGRect.Empty);
        }
    }
}
