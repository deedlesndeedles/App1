using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string ava1 = "http://www.avasdemon.com/pages.php#0001";
        private Uri u1, u2;
        private double aw = 600, ah = 458, ax = .5, ay = .1;

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            LoadWeb(ava1, aw, ah);
        }

        public MainPage()
        {
            InitializeComponent();
            LoadWeb(ava1, aw, ah);
        }

        private string BuildUrl(string s1, int p, string s2)
        {
            string s = s1;
            string page = "000" + p;
            page.Substring(page.Length - 4);
            s += page;
            s += s2;


            return s;
        }

        public void LoadWeb(string s, double w, double h)
        {
            u1 = new Uri(s);
            Viewer.Navigate(u1);
            Main.Width = w*1.4*2;
            Viewer.Width = w;
            Main.Height = h*1.4*2;
            Viewer.Height = h;
            Main.ChangeView(200, 200, 1.4f);
        }
    }
}
