



namespace WeatherMaui.Dependencies;

public static class DependencyGraphCreator
{


  public static MauiAppBuilder CreateDependencyGraph(this MauiAppBuilder builder)
  => builder.RegisterNetwork()
  .RegisterLogging()
  .RegisterServices()
  .RegisterViewModels()
  .RegisterViews();

}