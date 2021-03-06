﻿using HACGUI.Extensions;
using LibHac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HACGUI.FirstStart
{
    /// <summary>
    /// Interaction logic for Finish.xaml
    /// </summary>
    public partial class FinishPage : PageExtension
    {
        public FinishPage()
        {
            InitializeComponent();

            Loaded += (_, __) =>
            {
                TextArea.Text += HACGUIKeyset.PrintCommonKeys(HACGUIKeyset.Keyset, true);
                TextArea.Text += "--------------------------------------------------------------\n";
                TextArea.Text += HACGUIKeyset.PrintCommonWithoutFriendlyKeys(HACGUIKeyset.Keyset);
                TextArea.Text += "--------------------------------------------------------------\n";
                TextArea.Text += ExternalKeys.PrintUniqueKeys(HACGUIKeyset.Keyset);
                TextArea.Text += "--------------------------------------------------------------\n";
                TextArea.Text += ExternalKeys.PrintTitleKeys(HACGUIKeyset.Keyset);
            };
        }

        private void OpenKeysClicked(object sender, RoutedEventArgs e)
        {
            Process.Start(HACGUIKeyset.UserSwitchDirectoryInfo.FullName);
        }
    }
}
