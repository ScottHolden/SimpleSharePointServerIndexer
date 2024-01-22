namespace SimpleSPSIndexer;

public interface ISharePointServer
{
	Task<SharePointList> GetListAsync(string listName, CancellationToken cancellationToken);
	Task<byte[]> DownloadDocumentAsync(string documentId, CancellationToken cancellationToken);
}
