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
    /// <summary>
    /// Custom collection type for circuit elements
    /// </summary>
    /// <typeparam name="T">Classes with ISegment realizations</typeparam>
    public class EventDrivenCollection<T> : ObservableCollection<T> where T : ISegment
    {
        /// <summary>
        /// Event fires when value of one of the elements changed or when new element added/deleted
        /// </summary>
        public event EventHandler ElementsChanged;

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            if (item is IElement element)
            {
                element.SegmentChanged += OnSegmentChanged;
            }
            else
            {
                item.SegmentChanged += OnSegmentChanged;
            }
        }

        protected override void RemoveItem(int index)
        {
            var item = this[index];
            base.RemoveItem(index);
            if (item is IElement element)
            {
                element.SegmentChanged += OnSegmentChanged;
            }
            else
            {
                item.SegmentChanged += OnSegmentChanged;
            }
        }

        protected override void SetItem(int index, T item)
        {
            var oldItem = this[index];
            base.SetItem(index, item);
            if (item is IElement element)
            {
                element.SegmentChanged += OnSegmentChanged;
            }
            else
            {
                item.SegmentChanged += OnSegmentChanged;
            }
            if (oldItem is IElement oldElement)
            {
                oldElement.SegmentChanged -= OnSegmentChanged;
            }
            else
            {
               oldItem.SegmentChanged -= OnSegmentChanged;
            }
        }

        protected override void ClearItems()
        {
            foreach (var item in Items)
            {
                if (item is IElement element)
                {
                    element.SegmentChanged -= OnSegmentChanged;
                }
                else
                {
                    item.SegmentChanged -= OnSegmentChanged;
                }
            }
            base.ClearItems();
        }

        /// <summary>
        /// Handler for ValueChanged event
        /// </summary>
        /// <param name="sender">IElement</param>
        /// <param name="e">Default EventArgs</param>
        private void OnSegmentChanged(object sender, EventArgs e)
        {
            ElementsChanged?.Invoke(this, e);
        }
    }
}
