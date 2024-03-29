﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace poscoict_webpage
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private MainWindow mainWindow;
        private void ToggleButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = ((ToggleButton)sender).Content;
            Debug.WriteLine(item);
            if(item == null)
            {
                return;
            }

            Page page = null;
            switch(item)
            {
                case "기업개요":
                    page = mainWindow._companyIntroPage;
                    break;

                case "CEO":
                    page = mainWindow._ceoPage;
                    break;
                case "행복경영":
                    page = mainWindow._happyBizPage;
                    break;
            }
            mainWindow.frame.Navigate(page);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void _itemRadio_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton checked_button = sender as RadioButton;
            string item = checked_button.Content.ToString();
            Debug.WriteLine(item);
            if (item == null)
            {
                return;
            }

            Page page = null;
            switch (item)
            {
                case "기업개요":
                    page = mainWindow._companyIntroPage;
                    break;
                case "기업소개":
                    page = mainWindow._companyInfoPage;
                    break;
                case "CEO":
                    page = mainWindow._ceoPage;
                    break;
                case "행복경영":
                    page = mainWindow._happyBizPage;
                    break;
                case "포스코그룹비전":
                    page = mainWindow._groupvisionPage;
                    break;
            }
            mainWindow.frame.Navigate(page);
        }
    }
}
