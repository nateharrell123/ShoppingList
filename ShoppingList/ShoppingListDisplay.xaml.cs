using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for ShoppingListDisplay.xaml
    /// </summary>
    public partial class ShoppingListDisplay : UserControl
    {
        public ShoppingListDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The button that got clicked.</param>
        /// <param name="e"></param>
        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is ShoppingListData data)
            {
                if(sender is Button button) // casting
                {
                    data.Remove(button.DataContext.ToString()); // we only want the string literal to be removed
                }
            }
        }
    }
}
