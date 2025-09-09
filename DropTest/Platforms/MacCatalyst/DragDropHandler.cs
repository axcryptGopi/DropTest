using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileCoreServices;
using UIKit;

namespace DropTest.Platforms.MacCatalyst
{
    public class DragDropHandler : UIDropInteractionDelegate

    {
        private UIDropInteraction Interaction;

        public DragDropHandler(UIView view)
        {
            view.UserInteractionEnabled = true;
            Interaction = new UIDropInteraction(this);
            view.AddInteraction(Interaction);
        }


        public Boolean AllowDrop
        {
            get; set;
        }

        public override bool CanHandleSession(UIDropInteraction interaction, IUIDropSession session)
        {
            String temp = String.Empty;
            foreach (var item in session.Items)
            {
                foreach (var typeId in item.ItemProvider.RegisteredTypeIdentifiers)
                    temp += typeId + "\n";
            }
            bool retValue = session.HasConformingItems(new string[] { UTType.PlainText });
            return retValue;
        }
        public override void SessionDidEnter(UIDropInteraction interaction, IUIDropSession session)
        {
            base.SessionDidEnter(interaction, session);
        }
        public override UIDropProposal SessionDidUpdate(UIDropInteraction interaction, IUIDropSession session)
        {
            Console.WriteLine("Session Did Update fired");
            return new UIDropProposal(UIDropOperation.Copy);
        }

        public override void PerformDrop(UIDropInteraction interaction, IUIDropSession session)
        {
            Console.WriteLine("PerformDrop fired");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }

}
