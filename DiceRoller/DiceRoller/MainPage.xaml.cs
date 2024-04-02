namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SorterNumeroDado_Clicked(object sender, EventArgs e)
        {
            var lados = EscolherLadoDado.SelectedItem;
            if (lados != null)
            {
                var Nsorteado = new Random().Next(1, (int)lados + 1);
                NumeroRodado.Text = Nsorteado.ToString();

            }
            else
            {
                NumeroRodado.Text = "Selecione um Valor";
            }


        }
    }

}
