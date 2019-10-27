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
        private bool _isDefault;
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        
    }
    public class SubHeader
    {
        private string _subHeaderName;
        public string SubHeaderName
        {
            get { return _subHeaderName; }
            set { _subHeaderName = value; }
        }
        private List<SubItem>_subItems;
        public List<SubItem> SubItems
        {
            get { return _subItems; }
            set { _subItems = value; }
        }
        private string _hasSubitem;
        public string HasSubitem
        {
            get { return _subItems == null ? "DarkBlue" : "White"; }
            set { _hasSubitem = value; }
        }
        private bool _isDefault;
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
    }
    public class Item
    {
        private string _topHeaderName;
        public string TopHeaderName
        {
            get { return _topHeaderName; }
            set { _topHeaderName = value; }
        }
        private List<SubHeader> _subHeaders;
        public List<SubHeader> SubHeaders
        {
            get { return _subHeaders; }
            set { _subHeaders = value; }
        }
    }
}
