﻿using System.Collections.Generic;

namespace AshtonBro.Panels.Data
{
    public class ViewModel
    {
        private readonly List<SimpleItem> _list = new SimpleItemList();

        public List<SimpleItem> Items
        {
            get
            {
                return _list;
            }
        }
    }
}
