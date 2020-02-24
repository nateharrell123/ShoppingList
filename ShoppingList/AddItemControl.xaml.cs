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
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick; // hooking up method to button
        }

        protected void OnAddItemButtonClick(object sender, RoutedEventArgs args)
        {
            /*
            var item = ItemToAdd.Text;
            var data = (ShoppingListData)DataContext; // throws an exception if it can't be done
            var data2 = DataContext as ShoppingListData; // sets data2 to null if it can't be done
            if(data2 != null)
            {
                // safe to work with data2
            }
            */

            // same as above:
            if(DataContext is ShoppingListData data) // checks if it's possible to cast. guarantees it exists and will be of type 'shoppinglistdata
            {
                // if true, data3 is accessible to us and is of type 'data3'.
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
