using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using XAMLDemo;

namespace BackendDemo
{
    public class CacheListView : BaseAdapter<Cache>
    {
        private Context _context;
        private List<Cache> _items;

        public CacheListView(Context context, List<Cache> items)
        {
            _context = context;
            _items = items;
        }

        public override Cache this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get { return _items.Count; }
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
                row = LayoutInflater.From(_context).Inflate(Resource.Id.cacheListView, null, false);
            }

            TextView textTitle = row.FindViewById<TextView>(Resource.Id.title);
            textTitle.Text = _items[position].Title;

            TextView textMessage = row.FindViewById<TextView>(Resource.Id.message);
            textMessage.Text = _items[position].TextMessage;

            CheckBox checkVisibility = row.FindViewById<CheckBox>(Resource.Id.visibility);
            checkVisibility.Checked = _items[position].Visability;

            return row;
        }
    }
}