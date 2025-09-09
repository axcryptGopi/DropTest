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
    public class FileDropBoxHandler : ViewHandler<FileDropBox, FileDropView>
    {
        public static IPropertyMapper<FileDropBox, FileDropBoxHandler> Mapper = new PropertyMapper<FileDropBox, FileDropBoxHandler>(ViewHandler.ViewMapper);
        public static CommandMapper<FileDropBox, FileDropBoxHandler> CommandMapper = new(ViewHandler.ViewCommandMapper);

        public FileDropBoxHandler() : base(Mapper, CommandMapper)
        {
        }

        protected override FileDropView CreatePlatformView()
        {
            var nativeView = new FileDropView(CGRect.Empty);
            nativeView.FileDropped += path =>
            {
                VirtualView?.RaiseFileDropped(path);
            };
            return nativeView;
        }
    }
}
