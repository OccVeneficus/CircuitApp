using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CircutApp
{
    public class CircuitElements<T> : ObservableCollection<T> where T : IElement
    {
        public event EventHandler ElementsChanged;

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            item.ValueChanged += Item_ValueChanged;
        }

        protected override void RemoveItem(int index)
        {
            var item = this[index];
            base.RemoveItem(index);
            item.ValueChanged += Item_ValueChanged;
        }

        protected override void SetItem(int index, T item)
        {
            var oldItem = this[index];
            base.SetItem(index, item);
            oldItem.ValueChanged -= Item_ValueChanged;
            item.ValueChanged += Item_ValueChanged;
        }

        protected override void ClearItems()
        {
            foreach (var item in Items)
            {
                item.ValueChanged -= Item_ValueChanged;
            }
            base.ClearItems();
        }

        private void Item_ValueChanged(object sender, EventArgs e)
        {
            ElementsChanged?.Invoke(this, e);
        }
    }
}
