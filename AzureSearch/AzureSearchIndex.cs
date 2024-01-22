namespace SimpleSPSIndexer;

public class AzureSearchIndex : ISearchIndex
{
	public Task EnsureIndexExistsAsync(CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task UpsertDocument(string id, SearchDocument document, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}