﻿using MahApps.Metro.Controls;
using PowerAccent.Core.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PowerAccent.UI.SettingsPage
{
    /// <summary>
    /// Logique d'interaction pour OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        private readonly SettingsService _settingService = new SettingsService();

        public OptionsPage()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            IsUseCaretPosition.IsOn = _settingService.UseCaretPosition;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _settingService.UseCaretPosition = ((ToggleSwitch)sender).IsOn;
            (Application.Current.MainWindow as Selector).RefreshSettings();
        }
    }
}