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
        public event Action<string> FileDropped;

        public FileDropView(CGRect frame) : base(frame)
        {
            BackgroundColor = UIColor.SystemGray5;

            var dropInteraction = new UIDropInteraction(this);
            AddInteraction(dropInteraction);
        }

        [Export("dropInteraction:canHandleSession:")]
        public bool CanHandleSession(UIDropInteraction interaction, IUIDropSession session)
        {
            // Accept file URLs only
            return true; // session.HasItemsConformingTo(new[] { UTType.FileUrl });
        }

        [Export("dropInteraction:sessionDidUpdate:")]
        public UIDropProposal SessionDidUpdate(UIDropInteraction interaction, IUIDropSession session)
        {
            return new UIDropProposal(UIDropOperation.Copy);
        }

        [Export("dropInteraction:performDrop:")]
        public void PerformDrop(UIDropInteraction interaction, IUIDropSession session)
        {
            foreach (var item in session.Items)
            {
                //item.ItemProvider.LoadFileRepresentation(UTType.FileUrl, (url, error) =>
                //{
                //    if (url != null)
                //    {
                //        var path = url.Path;
                //        Console.WriteLine($"Dropped file: {path}");
                //        FileDropped?.Invoke(path);
                //    }
                //});
            }
        }
    }

}
