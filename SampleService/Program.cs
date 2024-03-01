using SampleService;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File(
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sample-service.log")
    )
    .CreateLogger();

var host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options => {
        options.ServiceName = "SampleService";
    })
    .UseSerilog()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
