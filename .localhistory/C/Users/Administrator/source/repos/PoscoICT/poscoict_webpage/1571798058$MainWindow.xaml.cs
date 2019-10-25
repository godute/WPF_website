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
       
        public MainWindow()
        {
            InitializeComponent();
            InitPage();
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
            frame.Navigate(_companyIntroPage);
        }
        private void groupVision_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(_groupvisionPage);
        }
        private void ceo_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(_ceoPage);
        }
        private void happBiz_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(_happyBizPage);
        }
    }
}
