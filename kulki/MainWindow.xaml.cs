using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kulki
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Random rnd = new Random();
        Random random = new Random();
        int zapamietaj = 0;
        int liczba = 0;
        List<string> names = new List<string> { "red", "yellow", "blue", "purple", "black", "green" };

        System.Windows.Threading.DispatcherTimer timer;
        double counter=9;
        int gracz1pkt =0;
        int gracz2pkt = 0;


        public MainWindow()
        {
            InitializeComponent();
            koniec.Value = 100;
            one.Visibility = Visibility.Collapsed;
            two.Visibility = Visibility.Collapsed;
            three.Visibility = Visibility.Collapsed;
            four.Visibility = Visibility.Collapsed;
            five.Visibility = Visibility.Collapsed;
            six.Visibility = Visibility.Collapsed;

        }
        public void resetK()
        {
            one.Visibility = Visibility.Collapsed;
            two.Visibility = Visibility.Collapsed;
            three.Visibility = Visibility.Collapsed;
            four.Visibility = Visibility.Collapsed;
            five.Visibility = Visibility.Collapsed;
            six.Visibility = Visibility.Collapsed;
            names = new List<string> { "red", "yellow", "blue", "purple", "black", "green" };
            timer.Stop();
            counter = 9;
            losuj.IsEnabled = true;
            losuj.Opacity = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (counter > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                counter = counter - 1;
                timeLabel.Text = counter.ToString();
                if (zapamietaj == 0)
                {
                    koniec.Value = counter * 5;
                }
                else
                {
                    koniec.Value = counter * 10;
                }
                
            }
            else
            {
                timer.Stop();
                if (zapamietaj == 1)
                {
                    one.Visibility = Visibility.Collapsed;
                    two.Visibility = Visibility.Collapsed;
                    three.Visibility = Visibility.Collapsed;
                    four.Visibility = Visibility.Collapsed;
                    five.Visibility = Visibility.Collapsed;
                    six.Visibility = Visibility.Collapsed;
                    counter = 19;
                    koniec.Value = 100;
                    timer.Start();
                    zapamietaj = 0;
                }
                else
                {
                    // If the user ran out of time, stop the timer, show
                    // a MessageBox, and fill in the answers.

                    //losuj.IsEnabled = true;
                    //losuj.Opacity = 1;
                    if (liczba == 1)
                    {
                        one.Visibility = Visibility.Visible;
                        

                    }
                    else if (liczba == 2)
                    {
                        one.Visibility = Visibility.Visible;
                      
                        two.Visibility = Visibility.Visible;
                       
                    }
                    else if (liczba == 3)
                    {
                        one.Visibility = Visibility.Visible;
                    
                        two.Visibility = Visibility.Visible;
                        three.Visibility = Visibility.Visible;
                    }
                    else if (liczba == 4)
                    {
                        one.Visibility = Visibility.Visible;
                        two.Visibility = Visibility.Visible;
                        three.Visibility = Visibility.Visible;
                        four.Visibility = Visibility.Visible;
                    
                    }
                    else if (liczba == 5)
                    {
                        one.Visibility = Visibility.Visible;
                        two.Visibility = Visibility.Visible;
                        three.Visibility = Visibility.Visible;
                        four.Visibility = Visibility.Visible;
                        five.Visibility = Visibility.Visible;
                   
                    }
                    else if (liczba == 6)
                    {
                        one.Visibility = Visibility.Visible;
                        two.Visibility = Visibility.Visible;
                        three.Visibility = Visibility.Visible;
                        four.Visibility = Visibility.Visible;
                        five.Visibility = Visibility.Visible;
                        six.Visibility = Visibility.Visible;
                    
                    }
                    counter = 9;
                    SoundPlayer sd = new SoundPlayer("../../Assets/siren.wav");
                    sd.Load();
                    sd.Play();
                    koniec.Value = 100;
                    
                }


                

            }

        }
        public RadialGradientBrush losujKolor()
        {
            System.Threading.Thread.Sleep(10);
            RadialGradientBrush kolor = null;
     


            int index = random.Next(names.Count);


            var name = names[index];
            names.RemoveAt(index);
            string color = name;
            RadialGradientBrush kolor1 = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(255, 255, 255));
            if (color == "red")
            {
                
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(255, 0, 0));
                kolor.GradientOrigin = new Point(0.75, 0.25);
                return kolor;
            }
            else if (color == "blue")
            {
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(0, 0, 255));
                kolor.GradientOrigin = new Point(0.75, 0.25);

                return kolor;
            }
            else if (color == "yellow")
            {
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(255, 255, 0));
                kolor.GradientOrigin = new Point(0.75, 0.25);

                return kolor;
            }
            else if (color == "purple")
            {
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(153, 0, 153));
                kolor.GradientOrigin = new Point(0.75, 0.25);

                return kolor;
            }
            else if (color == "black")
            {
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(0, 0, 0));
                kolor.GradientOrigin = new Point(0.75, 0.25);

                return kolor;
            }
            else if (color == "green")
            {
                kolor = new RadialGradientBrush(Color.FromRgb(255, 255, 255), Color.FromRgb(0, 153, 0));
                kolor.GradientOrigin = new Point(0.75, 0.25);

                return kolor;
            }
            else return kolor1;
        }
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zapamietaj = 1;
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            timeLabel.Text = counter.ToString();


            
            losuj.IsEnabled = false;
            losuj.Opacity = 0.1;

            liczba = rnd.Next(2, 7);
            if (liczba == 1) {
                one.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                
            } else if (liczba == 2)
            {
                one.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                two.Visibility = Visibility.Visible;
                two.Fill = losujKolor();
            } else if (liczba == 3)
            {
                one.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                two.Fill = losujKolor();
                three.Fill = losujKolor();
                two.Visibility = Visibility.Visible;
                three.Visibility = Visibility.Visible;
            } else if (liczba == 4)
            {
                one.Visibility = Visibility.Visible;
                two.Visibility = Visibility.Visible;
                three.Visibility = Visibility.Visible;
                four.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                two.Fill = losujKolor();
                three.Fill = losujKolor();
                four.Fill = losujKolor();
            } else if (liczba == 5)
            {
                one.Visibility = Visibility.Visible;
                two.Visibility = Visibility.Visible;
                three.Visibility = Visibility.Visible;
                four.Visibility = Visibility.Visible;
                five.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                two.Fill = losujKolor();
                three.Fill = losujKolor();
                four.Fill = losujKolor();
                five.Fill = losujKolor();
            } else if (liczba == 6)
            {
                one.Visibility = Visibility.Visible;
                two.Visibility = Visibility.Visible;
                three.Visibility = Visibility.Visible;
                four.Visibility = Visibility.Visible;
                five.Visibility = Visibility.Visible;
                six.Visibility = Visibility.Visible;
                one.Fill = losujKolor();
                two.Fill = losujKolor();
                three.Fill = losujKolor();
                four.Fill = losujKolor();
                five.Fill = losujKolor();
                six.Fill = losujKolor();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resetK();
        }

        private void gracz2_Click(object sender, RoutedEventArgs e)
        {
            gracz1pkt = gracz1pkt + 1;
            gracz1pkt1.Text = gracz1pkt.ToString();
            
        }

        private void gracz1_Click(object sender, RoutedEventArgs e)
        {
            gracz2pkt = gracz2pkt + 1;
            gracz2pkt1.Text = gracz2pkt.ToString();
        }
    }
}
