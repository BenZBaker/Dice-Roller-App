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

namespace Ben_Baker_Dice_Roller_Session_7_Portfolio_Exercise
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


        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            totalCount.Text = (Convert.ToInt32(totalCount.Text) - 1).ToString();
            runningAdditions.Text = runningAdditions.Text + " - 1";
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + 1).ToString();
            runningAdditions.Text = runningAdditions.Text + " + 1";
        }

        private void Button1d2_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 3);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();

        }

        private void Button1d3_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 4);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d4_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 5);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d6_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 7);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d8_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 9);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d10_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 11);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d12_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 13);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d20_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 21);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void Button1d100_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 101);
            runningAdditions.Text = runningAdditions.Text + " + " + rand_num.ToString();
            totalCount.Text = (Convert.ToInt32(totalCount.Text) + Convert.ToInt32(rand_num)).ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            totalCount.Text = "0";
            runningAdditions.Text = "0";
        }
    }
}
