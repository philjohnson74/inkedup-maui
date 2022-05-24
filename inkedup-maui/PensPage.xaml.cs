namespace inkedup_maui
{
    public partial class PensPage : ContentPage
    {
        public PensPage()
        {
            InitializeComponent();
        }

		private void BtnNavigateBack_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
    }
}