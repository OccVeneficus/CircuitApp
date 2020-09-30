﻿using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CircutApp
{
    /// <summary>
    /// Custom collection type for circuit segments and elements
    /// </summary>
    /// <typeparam name="T">Classes with INotifyPropertyChanged realizations</typeparam>
    public class EventDrivenCollection<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor subscribe CollectionChanged event on it's handler
        /// </summary>
        public EventDrivenCollection()
        {
            CollectionChanged += FullEventDrivenCollectionChanged;
        }

        /// <summary>
        /// CollectionChanged event handler. Subscribes/unsubscribes collection items on ItemPropertyChanged handler
        /// </summary>
        /// <param name="sender">Circuit segment or element that caused event firing</param>
        /// <param name="e">NotifyCollectionChanged arguments</param>
        private void FullEventDrivenCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    ((INotifyPropertyChanged) item).PropertyChanged += ItemPropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    ((INotifyPropertyChanged)item).PropertyChanged -= ItemPropertyChanged;
                }
            }
        }

        /// <summary>
        /// PropertyChanged event handler. Fires OnCollectionChanged event
        /// </summary>
        /// <param name="sender">Circuit segment or element that caused event firing</param>
        /// <param name="e">PropertyChanged event arguments</param>
        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyCollectionChangedEventArgs args = 
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace,
                sender, sender, IndexOf((T)sender));
            OnCollectionChanged(args);
        }
    }
}
