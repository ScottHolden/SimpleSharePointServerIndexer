using SimpleSPSIndexer;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ISearchIndex, AzureSearchIndex>();
builder.Services.AddSingleton<IMetadataManagement, TableMetadataManagement>();
builder.Services.AddSingleton<ISharePointServer, SharePointServer>();

builder.Services.AddHostedService<SimpleIndexer>();

var host = builder.Build();
host.Run();