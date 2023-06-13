#region

using System.Text;
using Avalonia.Controls;

#endregion

namespace AvaloniaTesting.Pages;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
        PopulateSteamSkinComboBox();
        SteamSkinComboBox.DropDownOpened += (_, _) => PopulateSteamSkinComboBox();
        SteamSkinComboBox.SelectionChanged += SteamSkinComboBox_SelectionChanged;
    }

    private void PopulateSteamSkinComboBox()
    {
    }

    private void SteamSkinComboBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
    }
}
