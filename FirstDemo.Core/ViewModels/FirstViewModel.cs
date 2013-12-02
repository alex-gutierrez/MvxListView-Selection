using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;

namespace FirstDemo.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public List<ListItem> Items
        {
            get 
            { 
                var list = new List<ListItem>();
                for (int i = 0; i < 100; i++)
                {
                    list.Add(new ListItem("Item " + i));
                }
                return list;
            }
        }

        private List<ListItem> _selectedItems;
        public List<ListItem> SelectedItems
        {
            get 
            { 
                if (_selectedItems == null)
                    _selectedItems = new List<ListItem>();
                return _selectedItems;
            }
            set { _selectedItems = value; RaisePropertyChanged(() => SelectedItems); }
        }

        public void OnItemSelect(ListItem item)
        {
            if (SelectedItems.Contains(item))
            {
                SelectedItems.Remove(item);
            }
            else
            {
                SelectedItems.Add(item);
            }
            RaisePropertyChanged(() => SelectedItems);
        }
    }

    public class ListItem
    {
        public ListItem(string title) : base()
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }
}

