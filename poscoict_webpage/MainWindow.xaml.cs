using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using poscoict_webpage.Pages;
using System.Diagnostics;

namespace poscoict_webpage
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public CompanyInfoPage _companyInfoPage;
        public CompanyIntroPage _companyIntroPage;
        public GroupVisionPage _groupvisionPage;
        public CEOPage _ceoPage;
        public HappyBizPage _happyBizPage;
        public List<Item> Items;

        private string _header;
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        public List<SubHeader> _Sub;
        public List<SubHeader> Sub
        {
            get { return _Sub; }
            set { _Sub = value; }
        }
        public MainWindow()
        {
            Items = new List<Item>();
            InitItems();

            Header = "기업정보";
            InitializeComponent();
            InitPage();
            Debug.WriteLine(lists.Template);
            
        }
        private void InitItems()
        {

            _Sub = new List<SubHeader>();
            /////
            SubItem subitem1 = new SubItem();
            SubItem subitem2 = new SubItem();
            subitem1.SubItemName = "기업소개";
            subitem2.SubItemName = "포스코그룹비전";
            subitem1.IsDefault = true;
            subitem2.IsDefault = false;

            SubHeader subheader1 = new SubHeader();
            subheader1.SubHeaderName = "기업개요";
            subheader1.SubItems = new List<SubItem> { subitem1, subitem2 };
            subheader1.IsDefault = true;

            //////
            SubHeader subheader2 = new SubHeader();
            subheader2.SubHeaderName = "CEO";
            subheader2.IsDefault = false;
            //////

            SubItem subitem3 = new SubItem();
            SubItem subitem4 = new SubItem();
            subitem3.SubItemName = "감사나눔";
            subitem4.SubItemName = "사회공헌";
            subitem3.IsDefault = true;
            subitem4.IsDefault = false;

            SubHeader subheader3 = new SubHeader();
            subheader3.SubHeaderName = "행복경영";
            subheader3.IsDefault = false;
            subheader3.SubItems = new List<SubItem> { subitem3, subitem4 };

            ///////

            SubItem subitem5 = new SubItem();
            SubItem subitem6 = new SubItem();
            subitem5.SubItemName = "윤리경영";
            subitem6.SubItemName = "동반성장";
            subitem5.IsDefault = true;
            subitem6.IsDefault = false;

            SubHeader subheader4 = new SubHeader();
            subheader4.SubHeaderName = "지속가능경영";
            subheader4.IsDefault = false;
            subheader4.SubItems = new List<SubItem> { subitem5, subitem6 };
            ////
            Item item1 = new Item();
            item1.TopHeaderName = "기업정보";
            item1.SubHeaders = new List<SubHeader> { subheader1 , subheader2,subheader3, subheader4 };
            
            Items.Add(item1);

            _Sub.Add(subheader1);
            _Sub.Add(subheader2);
            _Sub.Add(subheader3);
            _Sub.Add(subheader4);

        }
        private void InitPage()
        {
            _companyInfoPage = new CompanyInfoPage(this);
            _companyIntroPage = new CompanyIntroPage(this);
            _groupvisionPage = new GroupVisionPage(this);
            _ceoPage = new CEOPage(this);
            _happyBizPage = new HappyBizPage(this);
        }
        
        private void companyIntro_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("companyIntro_Click");
            frame.Navigate(_companyIntroPage);
        }
        private void groupVision_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("groupVision_Click");
            frame.Navigate(_groupvisionPage);
        }
        private void ceo_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("CEO Click");
            frame.Navigate(_ceoPage);
        }
        private void happBiz_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("HappyBiz Click");
            frame.Navigate(_happyBizPage);
        }
        
    }
}
