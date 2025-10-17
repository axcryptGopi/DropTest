namespace DropTest
{
    public partial class MainPage : ContentPage
    {
        private async void OnDropGestureRecognizerDrop(object sender, DropEventArgs e)
        {

        }

        public MainPage()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.PageHandler.Mapper.AppendToMapping("DragDrop", (handler, view) =>
            {




            });
        }
    }
}
