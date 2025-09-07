using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using NitroShelf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace NitroShelf
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NavigateToPage (Type pageYype)
        {
            contentFrame.Navigate(pageYype);
            contentFrame.Navigate(typeof(BooksPage), null, new DrillInNavigationTransitionInfo());
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "BooksPage":
                        NavigateToPage(typeof(BooksPage));
                        sender.Header = "Books";
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
