namespace avaliacaoPAM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void rolarDados(object sender, EventArgs e)
        {

            ValorSorteado.Text = new Random().Next(1, 11).ToString();
        }
    }

}
