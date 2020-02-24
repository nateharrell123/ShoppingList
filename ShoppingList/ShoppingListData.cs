using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ShoppingList
{
    public class ShoppingListData : INotifyPropertyChanged
    {
        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray(); // public property that accesses private backing variable. .ToArray() copies the list to an array

        public event PropertyChangedEventHandler PropertyChanged; // tracks if a property has been changed

        /// <summary>
        /// This means that we have to access this ShoppingList class before we can add or remove data.
        /// </summary>
        /// <param name="item"></param>
        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); // 'this' says what object we're invoking on
        }
        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); // 'this' says what object we're invoking on

        }
    }
}
