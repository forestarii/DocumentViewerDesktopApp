using DocumentViewer.Desktop.Models;

namespace DocumentViewer.Desktop.HttpServices
{
    class DocumentHttpService : IDocumentHttpService
    {
        public Task DeleteDocumentAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Document>> GetDocumentsAsync()
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync("http://localhost:5139/api/document/all");

            return new List<Document>();
        }

        public Task UpdateDocumentAsync()
        {
            throw new NotImplementedException();
        }
    }
}
