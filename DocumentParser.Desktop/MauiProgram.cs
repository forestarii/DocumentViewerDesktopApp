using DocumentViewer.Desktop.HttpServices;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace DocumentViewer.Desktop;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<IDocumentHttpService, DocumentHttpService>();
		builder.ConfigureSyncfusionCore();

        return builder.Build();
	}
}
