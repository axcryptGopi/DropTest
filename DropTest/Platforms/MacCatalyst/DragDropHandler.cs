using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Console.WriteLine("CanHandleSession fired " + AllowDrop);
            return AllowDrop;
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
    }

}
