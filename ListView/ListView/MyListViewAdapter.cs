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
using ListViewLibrary;

namespace ListViewTutorial
{
    class CategoryListViewAdapter:BaseAdapter<Category>
    {
        List<Category> mItems;
        Context mContext;

        public CategoryListViewAdapter(Context context, List<Category> items)
        {
            mItems = items;
            mContext = context;
        }

        public override Category this[int position]
        {
            get { return mItems[position]; }
        }

        public override int Count
        {
            get { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_Row, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            TextView txtDescription = row.FindViewById<TextView>(Resource.Id.txtDescription);

            txtName.Text = mItems[position].Title;
            txtDescription.Text = mItems[position].Description;

            return row;
        }
    }
}