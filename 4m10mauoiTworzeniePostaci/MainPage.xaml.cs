namespace _4m10mauoiTworzeniePostaci
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSprawdz(object sender, EventArgs e)
        {
            //imię nie może być puste, mieć od 3 do 20 znaków, bez spacji
            //imię ma być z dużej litery - skonwertować
            if(string.IsNullOrEmpty(entImie.Text))
            {
                await DisplayAlert("błąd", "brak imienia", "ok");
                return;
            }
            string imie = entImie.Text;
            if(imie.Length <3 || imie.Length > 20)
            {
                await DisplayAlert("błąd", "zła długość imienia", "ok");
                return;
            }
            if(imie.Contains(" "))
            {
                await DisplayAlert("błąd", "w imieniu nie może być spacji", "ok");
                return;
            }
            string pierwsza = imie[0].ToString().ToUpper();
            imie = pierwsza + imie.Substring(1).ToLower();
            lblWynik.Text = $"imię  {imie}";
            string rasa="";
            if (rbtCzlowiek.IsChecked) rasa = "człowiek";
            if (rbtElf.IsChecked) rasa = "elf";
            if (rbtGoblin.IsChecked) rasa = "goblin";
            lblWynik.Text += $"rasa: {rasa}; ";
        }
        private void rbtChanged(object sender, EventArgs e)
        {
            if (rbtCzlowiek.IsChecked)
                entWzrost.Placeholder = "wzrost 160-190";
            if (rbtElf.IsChecked)
                entWzrost.Placeholder = "wzrost 190-220";
            if (rbtGoblin.IsChecked)
                entWzrost.Placeholder = "wzrost 120-160";
        }
    }

}
