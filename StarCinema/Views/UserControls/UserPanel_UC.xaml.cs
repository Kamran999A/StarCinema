﻿using StarCinema.ViewModels;
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

namespace StarCinema.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UserPanel_UC.xaml
    /// </summary>
    public partial class UserPanel_UC : UserControl
    {
        public UserPanel_UC()
        {
            InitializeComponent();

            this.DataContext = new UserPanel_UCViewModel() { UserPanel_UCs = this };
        }

        private void Username_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = null;
                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);
                Username.Foreground = new SolidColorBrush(color1);
            }
        }

        private void Username_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Username.Text == "")
            {
                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);
                Username.Text = "Username";
                Username.Foreground = new SolidColorBrush(color2);
            }
        }



        private void Name_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Name.Text == "Name")
            {
                Name.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                Name.Foreground = new SolidColorBrush(color1);


            }
        }

        private void Name_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Name.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                Name.Text = "Name";
                Name.Foreground = new SolidColorBrush(color2);
            }
        }

        private void Surname_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Surname.Text == "Surname")
            {
                Surname.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                Surname.Foreground = new SolidColorBrush(color1);


            }
        }
        private void Surname_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Surname.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                Surname.Text = "Surname";
                Surname.Foreground = new SolidColorBrush(color2);
            }
        }
        private void Username2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Username2.Text == "Username")
            {
                Username2.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                Username2.Foreground = new SolidColorBrush(color1);


            }
        }
        private void Username2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Username2.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                Username2.Text = "Username";
                Username2.Foreground = new SolidColorBrush(color2);
            }
        }
        private void Email_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = null;



                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);

                Email.Foreground = new SolidColorBrush(color1);


            }
        }
        private void Email_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Email.Text == "")
            {

                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);

                Email.Text = "Email";
                Email.Foreground = new SolidColorBrush(color2);
            }
        }

        private void PackIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            Username.Visibility = Visibility.Visible;
            PasswordLabel2.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            SignIn.Visibility = Visibility.Visible;

        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Name.Visibility = Visibility.Visible;
            Surname.Visibility = Visibility.Visible;
            Username2.Visibility = Visibility.Visible;
            PasswordLabel.Visibility = Visibility.Visible;
            Password2.Visibility = Visibility.Visible;
            ConfirmPassword.Visibility = Visibility.Visible;
            ConfirmPasswordLabel.Visibility = Visibility.Visible;
            Email.Visibility = Visibility.Visible;
            SignUp.Visibility = Visibility.Visible;
        }
    }
}
