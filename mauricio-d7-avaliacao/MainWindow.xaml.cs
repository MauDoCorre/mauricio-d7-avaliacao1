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
            //GetUsers();
            Login.DataContext = tryUser;
        }


        //private void GetUsers() //carregar os dados para o datagrid (q vai mostrar na tabela)
        //{
        //    UserDataGrid.ItemsSource = context.Users.ToList(); //pelo context conegue acessar o banco
        //}

        private void Logar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicou");
            //seleciona
            //var usuarios = context.Users.ToList();
            //foreach (User usuario in usuarios) {
            //    //compara o usuário e senha do banco
            //    if (tryUser.Usuario == usuario.Usuario) //and senha = senha
            //    {
            //        MessageBox.Show("Usuário autenticado!");
            //    }
            //    //caso dê ruim
            //    else
            //    {
            //        MessageBox.Show("Credenciais inválidas!");
            //    }
            //}
        }
    }
}
