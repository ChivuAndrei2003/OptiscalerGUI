using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace OptiGUI.Views;

public partial class MainWindow : Window
{
    //private bool _sidebarExpanded;

    public MainWindow()
    {
        InitializeComponent();
    }

    // private void Button_OnClick(object? sender, RoutedEventArgs e)
    // {
    //     Console.WriteLine("hello world");
    // }

    // private void ToggleSidebar_Click(object? sender, RoutedEventArgs e)
    // {
    //     _sidebarExpanded = !_sidebarExpanded;
    //
    //     Sidebar.Width = _sidebarExpanded ? 220 : 70;
    // }
}