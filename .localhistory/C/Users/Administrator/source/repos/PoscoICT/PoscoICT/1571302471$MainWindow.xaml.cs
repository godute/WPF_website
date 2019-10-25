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
        private List<string> _companyList;
        public List<string> CompanyList
        {
            get { return _companyList; }
        }
    
        public MainWindow()
        {
            InitValue();
            InitializeComponent();
        }

        private void InitValue()
        {
            _companyList = new List<string>();
            _companyList.Add("기업개요");
            _companyList.Add("CEO");
            _companyList.Add("행복경영");
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;

        }
    }
}
