namespace SimpleSPSIndexer;

public class SimpleIndexer(
	ILogger<SimpleIndexer> _logger
) : BackgroundService
{
	protected override async Task ExecuteAsync(CancellationToken cancellationToken)
	{
		_logger.LogInformation("Worker started at: {time}", DateTimeOffset.Now);
		await Task.Delay(1000, cancellationToken);
		_logger.LogInformation("Worker finished at: {time}", DateTimeOffset.Now);
	}
}