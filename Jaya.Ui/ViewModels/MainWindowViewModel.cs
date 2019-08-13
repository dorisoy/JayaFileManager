﻿using Jaya.Ui.Models;

namespace Jaya.Ui.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ToolbarConfigModel ToolbarConfig => Shared.Instance.ToolbarConfiguration;

        public PaneConfigModel PaneConfig => Shared.Instance.PaneConfiguration;
    }
}