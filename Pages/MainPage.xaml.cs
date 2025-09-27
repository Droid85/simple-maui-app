using Microsoft.Maui.Controls;
using lab2.Models;
using lab2.PageModels;

namespace lab2.Pages;
public partial class MainPage : ContentPage
{
    private bool _toggled = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnChangeTextClicked(object sender, EventArgs e)
    {
        if (!_toggled)
        {
            DescriptionLabel.Text = "Hobby: Robotics & Programming";
            _toggled = true;
        }
        else
        {
            DescriptionLabel.Text = "Hobby: Programming";
            _toggled = false;
        }
    }
}