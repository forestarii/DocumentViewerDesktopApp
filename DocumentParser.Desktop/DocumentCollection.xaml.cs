using DocumentViewer.Desktop.HttpServices;

namespace DocumentViewer.Desktop;

public partial class DocumentCollection : ContentPage
{
    //private readonly IDocumentHttpService _documentHttpService;

    public DocumentCollection(/*IDocumentHttpService documentHttpService*/)
	{
		InitializeComponent();
        //_documentHttpService = documentHttpService;
    }

    private void OnUpdatedCollectionClicked(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();

        var responce = client.GetAsync("http://localhost:5139/api/document/all");

        SemanticScreenReader.Announce(UpdateCollectionBtn.Text);
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}