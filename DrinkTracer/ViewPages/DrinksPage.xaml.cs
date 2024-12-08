using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkTracer.ViewPages;

public partial class DrinksPage : ContentPage
{
    public DrinksPage()
    {
        InitializeComponent();
    }

    private void BarcodeButton_OnClicked(object? sender, EventArgs e)
    {
        DisplayAlert("Not implemented yet", "Barcode not implemented yet", "OK");
    }
}