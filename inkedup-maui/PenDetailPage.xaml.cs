using inkedup_maui.Models;

namespace inkedup_maui;

public partial class PenDetailPage : ContentPage
{
    private string uri;
    public PenDetailPage(Pen pen)
    {
        InitializeComponent();
        ImgPen.Source = pen.Image;
        LblBrandName.Text = pen.BrandName;
        LblModel.Text = pen.Model;
        uri = pen.Uri;
    }

    private async void TbShare_Clicked(object sender, EventArgs e)
    {
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = uri,
            Title = "Share"
        });
    }
}