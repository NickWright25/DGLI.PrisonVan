using DGLI.PrisonVan.App.Data.Services;
using DGLI.PrisonVan.Data;
using Microsoft.EntityFrameworkCore;

namespace DGLI.PrisonVan.App;

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
			});

		builder.Services.AddAntDesign();

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
# endif
		builder.Services.AddDbContext<IUnitOfWork, UnitOfWork>(opts =>
		{
			opts.UseSqlite(@$"DataSource={FileSystem.Current.AppDataDirectory}\database.db");
			opts.UseLazyLoadingProxies();
		});
		builder.Services.AddSingleton<ISoundcardService, SoundcardService>();
		builder.Services.AddSingleton<IAudiofileService, AudiofileService>();

		var serviceProvider = builder.Services.BuildServiceProvider();

		var unitOfWork = serviceProvider.GetService<IUnitOfWork>();
		unitOfWork.Database.Migrate();

		if (!Directory.Exists($@"{FileSystem.Current.AppDataDirectory}\files"))
		{
			Directory.CreateDirectory($@"{FileSystem.Current.AppDataDirectory}\files");
		}

		return builder.Build();
	}
}
