#region

using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using Avalonia.Controls;
using ReactiveUI;

#endregion

namespace AvaloniaTesting.Pages;

public partial class MainPage : UserControl
{
    public MainPage()
    {
        InitializeComponent();
        OpenFileDropDownButton.Flyout!.Opened += (_, _) => PopulateOpenFileDropDownButton();
    }
    
    private void PopulateOpenFileDropDownButton()
    {
    }

    private static async Task OpenPath(string path, bool isDirectory)
    {
    }

    private static async Task OpenFile(string relativeFilePath)
    {
        await OpenPath(relativeFilePath, false);
    }

    private static void OpenDir(string relativeDirPath)
    {
        OpenPath(relativeDirPath, true).Wait();
    }
}
