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

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace MobileApp2
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Btn1.Click += MyButtonClick;
            Btn2.Click += MyButtonClick;
            Btn3.Click += MyButtonClick;
            Btn4.Click += MyButtonClick;
            Btn5.Click += MyButtonClick;
            Btn6.Click += MyButtonClick;
            Btn7.Click += MyButtonClick;
            Btn8.Click += MyButtonClick;
            Btn9.Click += MyButtonClick;
        }

        void MyButtonClick(object sender, RoutedEventArgs args)
        {
            Button button = sender as Button;
            Displayer.Text += button.Content.ToString();
        }
    }
}
