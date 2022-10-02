using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows;
using atividade_D7.Data;

namespace atividade_D7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Context context;
        User tryUser = new();
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
            Login.DataContext = tryUser;
        }


        private void Logar(object sender, RoutedEventArgs e)
        {
            if (validateEmail(tryUser.Usuario))
            {
                var usuarios = context.Users.ToList();
                foreach (User usuario in usuarios)
                {
                    if (tryUser.Usuario == usuario.Usuario && tryUser.Senha == usuario.Senha)
                    {
                        MessageBox.Show("Usuário autenticado!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Email Inválido!");
                return;
            }
            MessageBox.Show("Credenciais inválidas!");
        }
        static bool validateEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
