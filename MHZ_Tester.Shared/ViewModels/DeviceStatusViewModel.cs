using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MHZ_Tester.Shared.ViewModels;

public partial class DeviceStatusViewModel : ObservableObject
{
    [ObservableProperty]
    private string connectionStatus = "Disconnected";

    [RelayCommand]
    public void Connect()
    {
        ConnectionStatus = "Connected";
    }

    [RelayCommand]
    public void Disconnect()
    {
        ConnectionStatus = "Disconnected";
    }
}
