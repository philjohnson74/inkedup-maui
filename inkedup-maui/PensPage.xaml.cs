using inkedup_maui.Models;
using inkedup_maui.Services;

namespace inkedup_maui
{
    public partial class PensPage : ContentPage
    {
    	private bool IsNextPage = false;
    	public List<Pen> Pens { get; set; }
    	public List<Brand> Brands = new List<Brand>()
    	{
        	new Brand(){ BrandName = "Montblanc"},
			new Brand(){ BrandName = "Visconti"},
    	};

 	   public PensPage()
 	   {
    	    InitializeComponent();
        	Pens = new List<Pen>();
        	CvBrands.ItemsSource = Brands;
    	}
    
		protected override async void OnAppearing()
    	{
        	base.OnAppearing();
        	if (IsNextPage == false)
        	{
        	    await PassBrand("Montblanc");
        	}

    	}

    	public async Task PassBrand(string brandName)
    	{
    	    CvPens.ItemsSource = null;
    	    Pens.Clear();
    	    ApiService apiService = new ApiService();
    	    var pensResult = await apiService.GetPens(brandName);
        	foreach (var item in pensResult)
        	{
        	    Pens.Add(item);
        	}
        	CvPens.ItemsSource = Pens;
	    }

	    private async void CvBrands_SelectionChanged(object sender, SelectionChangedEventArgs e)
	    {
	        var selectedItem = e.CurrentSelection.FirstOrDefault() as Brand;
	        if (selectedItem == null) return;
	        await PassBrand(selectedItem.BrandName);
	        ((CollectionView)sender).SelectedItem = null;
	    }

	    private void CvPens_SelectionChanged(object sender, SelectionChangedEventArgs e)
	    {
	        var selectedItem = e.CurrentSelection.FirstOrDefault() as Pen;
	        if (selectedItem == null) return;
	        IsNextPage = true;
	        Navigation.PushAsync(new PenDetailPage(selectedItem));
	        ((CollectionView)sender).SelectedItem = null;
	    }
	}
}