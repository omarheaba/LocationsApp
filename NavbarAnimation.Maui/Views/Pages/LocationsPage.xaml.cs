using NavbarAnimation.Maui.Models;

namespace NavbarAnimation.Maui.Views.Pages;

public partial class LocationsPage : ContentPage
{
    public List<LocationModel> LocationsList { get; set; }
    public LocationsPage()
	{
		InitializeComponent();
        this.LocationsList = new List<LocationModel>()
        {
            new LocationModel()
            {
                LocationName="Location name 1",
                LocationRating=4.5,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487",
                FavoriteIcon="fill_star.png"
            },
            new LocationModel()
            {
                LocationName="Location name 2",
                LocationRating=3,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487"
            },
            new LocationModel()
            {
                LocationName="Location name 3",
                LocationRating=3.6,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487",
                FavoriteIcon="fill_star.png"
            },
            new LocationModel()
            {
                LocationName="Location name 4",
                LocationRating=4.2,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487"
            },
            new LocationModel()
            {
                LocationName="Location name 5",
                LocationRating=2.5,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487"
            },
            new LocationModel()
            {
                LocationName="Location name 6",
                LocationRating=4.9,
                LocationAddress="Address",
                LocationLatitude="55.252426",
                LocationLongitude="12.256487",
                FavoriteIcon="fill_star.png"
            }
        };

        this.BindingContext = this;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("///" + "HomePage");
    }
}