using Avalonia;
using Avalonia.Controls;



Application app = Application.Current ?? AppBuilder.Configure<Application>().UsePlatformDetect().SetupWithoutStarting().Instance;
app.Styles.Add(new DefaultTheme());
app.Run(new Window() { Title = "Avalonia Basic Example", Content = "Hello Avalonia!" });
