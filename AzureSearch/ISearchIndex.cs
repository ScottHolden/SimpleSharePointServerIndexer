namespace SimpleSPSIndexer;

public interface ISearchIndex
{
	Task EnsureIndexExistsAsync(CancellationToken cancellationToken);
	Task UpsertDocument(string id, SearchDocument document, CancellationToken cancellationToken);
}
