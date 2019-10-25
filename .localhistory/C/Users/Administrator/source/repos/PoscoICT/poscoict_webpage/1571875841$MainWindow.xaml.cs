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
        private CompanyIntroPage _companyIntroPage;
        private GroupVisionPage _groupvisionPage;
        private CEOPage _ceoPage;
        private HappyBizPage _happyBizPage;
        private List<Item> items;
        public MainWindow()
        {
            InitializeComponent();
            InitPage();
            items = new List<Item>();
            InitItems();
            
        }
        private void InitItems()
        {
            /////
            SubItem subitem1 = new SubItem();
            SubItem subitem2 = new SubItem();
            subitem1.SubItemName = "기업소개";
            subitem2.SubItemName = "포스코그룹비전";

            SubHeader subheader1 = new SubHeader();
            subheader1.SubHeaderName = "기업개요";
            subheader1.SubItems = new List<SubItem> { subitem1, subitem2 };


            //////
            SubHeader subheader2 = new SubHeader();
            subheader1.SubHeaderName = "CEO";

            //////

            SubItem subitem3 = new SubItem();
            SubItem subitem4 = new SubItem();
            subitem3.SubItemName = "감사나눔";
            subitem4.SubItemName = "사회공헌";

            SubHeader subheader3 = new SubHeader();
            subheader3.SubHeaderName = "행복경영";
            subheader3.SubItems = new List<SubItem> { subitem3, subitem4 };

            ///////

            SubItem subitem5 = new SubItem();
            SubItem subitem6 = new SubItem();
            subitem5.SubItemName = "윤리경영";
            subitem6.SubItemName = "동반성장";

            SubHeader subheader4 = new SubHeader();
            subheader4.SubHeaderName = "지속가능경영";
            subheader4.SubItems = new List<SubItem> { subitem5, subitem6 };
            ////
            Item item1 = new Item();
            item1.TopHeaderName = "기업정보";
            item1.SubHeaders = new List<SubHeader> { subheader1 , subheader2,subheader3, subheader4 };

            items.Add(item1);

        }
        private void InitPage()
        {
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
