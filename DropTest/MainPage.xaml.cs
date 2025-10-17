namespace DropTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
//            Microsoft.Maui.Handlers.PageHandler.Mapper.AppendToMapping("DragDrop", (handler, view) =>
//            {

//#if WINDOWS
//                Microsoft.Maui.Platform.ContentPanel nativeView = handler.PlatformView;
//                nativeView.AllowDrop = true;
//                nativeView.DragOver += (sender, e) =>
//                {
//                    e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;
//                    e.Handled = true;
//                };

//                nativeView.Drop += async (sender, e) =>
//                {
//                    if (e.DataView.Contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.StorageItems))
//                    {
//                        var items = await e.DataView.GetStorageItemsAsync();
//                        foreach (var item in items)
//                        {
//                            if (item is Windows.Storage.StorageFile file)
//                            {
//                                // Handle your file here (e.g., get path, open, etc.)
//                                string path = file.Path;
//                                System.Diagnostics.Debug.WriteLine($"Dropped file: {path}");
//                            }
//                        }
//                    }
//                    e.Handled = true;
//                };

//#elif MACCATALYST
//                Microsoft.Maui.Platform.ContentView nativeView = handler.PlatformView;

//                DropTest.Platforms.MacCatalyst.DragDropHandler handle = new DropTest.Platforms.MacCatalyst.DragDropHandler(nativeView);
//                handle.AllowDrop = true;
//#endif

//            });
        }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {
            DropGestureRecognizer dropGR = new DropGestureRecognizer();
            dropGR.Drop += DropGR_Drop;
            this.blazorWebView.GestureRecognizers.Add(dropGR);
        }

        private void DropGR_Drop(object? sender, DropEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
