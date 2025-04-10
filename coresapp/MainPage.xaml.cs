namespace coresapp;
using coresapp.Resources.Theme;


public partial class MainPage : ContentPage
    {
        int count = 0;
        bool escuro = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private void blue_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new BlueTheme());
            }
        }

        private void red_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new RedTheme());
            }
        }

        private void dark_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new DarkTheme());
            }
        }

        private void light_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new LightTheme());
            }
        }

        private void green_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new GreenTheme());
            }
        }

        private void coffee_Clicked(object sender, EventArgs e)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new CoffeeTheme());
            }
        }

        private void default_Clicked(object sender, EventArgs e)
        {

        var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
            {
            
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new ());
            }
        }
}


