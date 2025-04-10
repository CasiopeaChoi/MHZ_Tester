using System;
using System.ComponentModel;

namespace MHZ_Tester.Shared.Services
{
	public class SidebarService : INotifyPropertyChanged
	{
		private bool _isCollapsed;
		public bool IsCollapsed
		{
			get => _isCollapsed;
			set
			{
				if (_isCollapsed != value)
				{
					_isCollapsed = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCollapsed)));
				}
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
	}
}
