using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Android.Util;
using System.Collections;

namespace FirstDemo.Droid
{
    public class MvxSelectableListView : MvxListView
    {
        public MvxSelectableListView(Context context, IAttributeSet attrs) : base(context, attrs) {}
        public MvxSelectableListView(Context context, IAttributeSet attrs, IMvxAdapter adapter) : base(context, attrs, adapter) {}

        public IList SelectedItems
        {
            set
            {
                var objects = this.Adapter.ItemsSource.Cast<object>().ToList();
                foreach (var item in objects)
                {
                    int position = objects.IndexOf(item);
                    bool isChecked = value.Contains(item);
                    SetItemChecked(position, isChecked);
                }
            }
        }
    }
}
