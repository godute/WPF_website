using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poscoict_webpage
{
    public class SubItem
    {
        private string _subItemName;
        public string SubItemName
        {
            get { return _subItemName; }
            set { _subItemName = value; }
        }
        public SubItem(string subitem)
        {
            _subItemName = subitem;
        }
    }
    public class Item
    {
        private string _headerName;
        public string HeaderName
        {
            get { return _headerName; }
            set { _headerName = value; }
        }
        private List<SubItem> _subItems;
        public List<SubItem> SubItems
        {
            get { return _subItems; }
            set { _subItems = value; }
        }
    }
}
