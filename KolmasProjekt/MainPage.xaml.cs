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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        int count = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (tbox2.Text == "kasutaja" && pbox1.Password.ToString() == "parool264")
            {
                answer1.Text = "Login worked!";
            }
            else
            {
                answer1.Text = "Wrong credentials!";
//                if (count > 3)
//                {
//                    Environment.Exit();
//                }
            }

        }
    }
}
