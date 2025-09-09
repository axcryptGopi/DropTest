using CoreGraphics;
using Foundation;
using ObjCBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace DropTest.Platforms.MacCatalyst
{
    public class FileDropView : UIView, IUIDropInteractionDelegate
    {
        public FileDropView(CGRect frame) : base(frame)
        {
            var dropInteraction = new UIDropInteraction(this);
            AddInteraction(dropInteraction);
        }

        [Export("dropInteraction:performDrop:")]
        public void PerformDrop(UIDropInteraction interaction, IUIDropSession session)
        {
            foreach (var item in session.Items)
            {
                item.ItemProvider.LoadFileRepresentation("public.file-url", (url, error) =>
                {
                    if (url != null)
                    {
                        var filePath = url.Path;
                        Console.WriteLine($"Dropped file: {filePath}");
                        // Handle the file here
                    }
                });
            }
        }

        [Export("dropInteraction:canHandleSession:")]
        public bool CanHandleSession(UIDropInteraction interaction, IUIDropSession session)
        {
            return session.HasConformingItems(new[] { "public.file-url" });
        }
    }

}
