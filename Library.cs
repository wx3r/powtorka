using System;
using System.Collections.Generic;

namespace powtorka
{
    public class Library
    {
        public List<IMediaItem> Items { get; set; }

        public Library()
        {
            Items = new List<IMediaItem>();
        }

        public void AddItem(IMediaItem item)
        {
            Items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (var item in Items)
            {
                item.DisplayInfo();
            }
        }

        public IMediaItem FindItemByTitle(string title)
        {
            foreach (var item in Items)
            {
                if (item.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }
    }
}