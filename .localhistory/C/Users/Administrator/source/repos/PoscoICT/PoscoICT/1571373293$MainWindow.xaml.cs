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
        private List<string> _companyInfo;
        private List<string> _bizArea;
        private List<string> _investInfo;
        private List<string> _prCenter;
        private List<string> _customerService;

        public List<string> CompanyInfo
        {
            get { return _companyInfo; }
        }
        public List<string> BizArea
        {
            get { return _bizArea; }
        }
        public List<string> InvestInfo
        {
            get { return _investInfo; }
        }
        public List<string> PRCenter
        {
            get { return _prCenter; }
        }
        public List<string> CustomerService
        {
            get { return _customerService; }
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
            _companyInfo = new List<string>();
            _companyInfo.Add("기업개요");
            _companyInfo.Add("CEO");
            _companyInfo.Add("행복경영");
            _companyInfo.Add("지속가능경영");
            _companyInfo.Add("창의경영");
        }
        private void Init()
        {
            _bizArea = new List<string>();
            _bizArea.Add("Smart X");
            _bizArea.Add("IT Service");
            _bizArea.Add("Energy");
            _bizArea.Add("SOC");
            _bizArea.Add("Smart Solution");
        }
    }
}
