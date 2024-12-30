using System.Threading.Tasks;
using System.Timers;
using Avalonia.Controls;
using Avalonia.Threading;

namespace AsyncAwaitApp;

public partial class MainWindow : Window
{
    private Timer? _timer;

    public MainWindow()
    {
        InitializeComponent();
        OutputTextBox = this.FindControl<TextBox>("OutputTextBox");
    }

    private async void ConnectButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OutputTextBox.Text += "Connecting to the database...\n";
        await Task.Delay(3000);
        OutputTextBox.Text += "Connected to the database.\n";
        
        StartTimer();
    }

    private async void DisconectButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        StopTimer();

        OutputTextBox.Text += "Disconnecting from the database...\n";
        await Task.Delay(3000);
        OutputTextBox.Text += "Disconnected from the database.\n";

    }
    
    private void StartTimer()
    {
        if (_timer != null)
        {
            _timer.Dispose();
        }
        
        _timer = new Timer(2000);
        _timer.Elapsed += (s, e) =>
        {
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                OutputTextBox.Text += "Data received.\n";
            });
        };
        _timer.Start();
        OutputTextBox.Text += "Timer started.\n"; // Повідомлення для діагностики
    }
    
    private void StopTimer()
    {
        if (_timer != null)
        {
            _timer.Stop();
            _timer.Dispose();
            _timer = null;
            OutputTextBox.Text += "Timer stopped.\n"; // Повідомлення для діагностики

        }
    }
}