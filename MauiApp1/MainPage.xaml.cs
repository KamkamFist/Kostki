

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        int all = 0;
        private void roll_clicked(object? sender, EventArgs e)
        {
            int wynik = 0;
            List<int> l = new List<int>();

            int a1 = new Random().Next(1, 7);
            l.Add(a1);
            int a2 = new Random().Next(1, 7);
            l.Add(a2);
            int a3 = new Random().Next(1, 7);
            l.Add(a3);
            int a4 = new Random().Next(1, 7);
            l.Add(a4);
            int a5 = new Random().Next(1, 7);
            l.Add(a5);

            var s = l.GroupBy(liczba => liczba).ToList();

            foreach (var g in s)
            {
                if(g.Count() > 1)
                {
                    wynik += g.Key * g.Count();
                }
            }

            img1.Source = $"k{a1}.jpg";
            img2.Source = $"k{a2}.jpg";
            img3.Source = $"k{a3}.jpg";
            img4.Source = $"k{a4}.jpg";
            img5.Source = $"k{a5}.jpg";

            all += wynik;

            now.Text = "Wynik aktualnego losowania: " +  wynik.ToString();
            total.Text = "Wynik gry: " + all.ToString();
        }

        private void reset_Clicked(object sender, EventArgs e)
        {
            

            img1.Source = $"question.jpg";
            img2.Source = $"question.jpg";
            img3.Source = $"question.jpg";
            img4.Source = $"question.jpg";
            img5.Source = $"question.jpg";

            int suma = 0;
            all = 0;

            now.Text = "Wynik aktualnego losowania: " + suma.ToString();
            total.Text = "Wynik gry: " + all.ToString();
        }
    }
}
