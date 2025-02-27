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
using System.Windows.Shapes;

namespace _2_14fi_WPF_masodik
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        ServerConnection connection;
        Registration regWindow;
        second GameWindow;
        public LoginWindow()
        {
            InitializeComponent();
            connection = new ServerConnection();

        }
        private void NewGame(object s, EventArgs e)
        {
            if (Data.users.Where(user => user.username != null).Count() == 2)
            {
                this.Hide();
                GameWindow = new second();
                GameWindow.Show();
                GameWindow.Closing += (ss, ee) =>
                {
                    this.Show();
                };
            }
            else
            {
                MessageBox.Show("Nincs két bejelentkezett felhasználó");
            }
        }
        private async void LoginClick(Object s, EventArgs e)
        {
            Button sender = s as Button;
            string username;
            string password;
            if (sender.Name == "user1Login")
            {
                username = user1Name.Text;
                password = user1Pass.Text;
                if (password.Length < 1)
                {
                    Data.users[0] = new JsonResponse() { username = username };
                    return;
                }
            }
            else
            {
                username = user2Name.Text;
                password = user2Pass.Text;
                if (password.Length < 1)
                {
                    Data.users[1] = new JsonResponse() { username = username };
                    return;
                }
            }
            if (Data.users.Select(user => user.username).Contains(username))
            {
                MessageBox.Show("Duplikált bejelentkezés");
            }
            else
            {
                JsonResponse onePlayer = await connection.Login(username, password);
                if (onePlayer.username != null)
                {
                    if (sender.Name == "user1Login")
                        Data.users[0] = onePlayer;
                    else
                        Data.users[1] = onePlayer;
                }
                else
                {
                    if (sender.Name == "user1Login")
                        Data.users[0] = onePlayer;
                    else
                        Data.users[1] = onePlayer;
                }
                
            }
        }
        private void RegistrationClick(object s, EventArgs e)
        {
            regWindow = new Registration();
            regWindow.Top = this.Top;
            regWindow.Left = this.Left;

            regWindow.Closing += (ss, ee) =>
            {
                this.Show();
            };

            regWindow.Show();
            this.Hide();
        }
    }
}
