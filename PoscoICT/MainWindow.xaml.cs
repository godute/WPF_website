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

namespace PoscoICT
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<List<string>> _companyInfo;
        private List<List<string>> _bizArea;
        private List<List<string>> _investInfo;
        private List<List<string>> _prCenter;
        private List<List<string>> _customerService;

        public List<string> Header_CompanyInfo
        {
            get { return GetColumn(_companyInfo, 0).ToList(); }
        }
        //public List<string> Item_CompanyInfo
        //{
        //    get { return }
        //}

        public List<string> BizArea
        {
            get { return GetColumn(_bizArea, 0).ToList(); }
        }
        public List<string> InvestInfo
        {
            get { return GetColumn(_investInfo, 0).ToList(); }
        }
        public List<string> PRCenter
        {
            get { return GetColumn(_prCenter, 0).ToList(); }
        }
        public List<string> CustomerService
        {
            get { return GetColumn(_customerService, 0).ToList(); }
        }

        public static IEnumerable<string> GetColumn(List<List<string>> data, int columnIndex)
        {
            foreach(List<string> row in data)
            {
                yield return row[columnIndex];
            }
        }

        public MainWindow()
        {
            InitValue();
            InitializeComponent();
        }

        private void InitValue()
        {
            InitCompanyInfo();
        }
        private void InitCompanyInfo()
        {
            _companyInfo = new List<List<string>>
            {
                new List<string> { "기업개요", "기업소개", "포스코그룹 비전" },
                new List<string> { "CEO" },
                new List<string> { "행복경영", "감사나눔", "사회공헌" },
                new List<string> { "지속가능경영", "윤리경영", "동반성장", "공정거래", "전략물자" },
                new List<string> { "창의경영"}
            };
            //_companyInfo.Add("기업개요");
            //_companyInfo.Add("CEO");
            //_companyInfo.Add("행복경영");
            //_companyInfo.Add("지속가능경영");
            //_companyInfo.Add("창의경영");
            
        }
<<<<<<< HEAD

        private void Item1_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            item.IsSubmenuOpen = true;
        }

        private void M1_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            item.IsSubmenuOpen = true;
        }
=======
       
>>>>>>> 74c58c697f75900c30484d0732c4d4c1643a6b43
    }
}
