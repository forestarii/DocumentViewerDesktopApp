using DocumentViewer.Desktop.HttpServices;

namespace DocumentViewer.Desktop;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

	private void OnDocumentCollectionClicked(object sender, EventArgs e)
	{
        DocumentCollectionBtn.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new DocumentCollection());
        };

        SemanticScreenReader.Announce(DocumentCollectionBtn.Text);
    }
}

