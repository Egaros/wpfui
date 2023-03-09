// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Windows.Controls;
using Wpf.Ui.Gallery.ViewModels.Pages.DialogsAndFlyouts;

namespace Wpf.Ui.Gallery.Views.Pages.Samples;

public partial class SamplePage1 : Page
{
    public SamplePage1()
    {
        InitializeComponent();
        this.DataContext = App.GetService<MessageBoxViewModel>();
    }
}
