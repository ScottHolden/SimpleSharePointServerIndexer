namespace SimpleSPSIndexer;

public class SharePointServer : ISharePointServer
{
	public Task<byte[]> DownloadDocumentAsync(string documentId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<SharePointList> GetListAsync(string listName, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
