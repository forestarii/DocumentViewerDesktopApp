using DocumentViewer.Desktop.Models;

namespace DocumentViewer.Desktop.HttpServices
{
    public interface IDocumentHttpService
    {
        Task<IEnumerable<Document>> GetDocumentsAsync();
        Task DeleteDocumentAsync();
        Task UpdateDocumentAsync();

    }
}
