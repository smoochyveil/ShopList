
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using ShopList.Maui.Views;
using System.Collections.ObjectModel;

namespace ShopList.Maui.ViewsModels
{
    public partial class MainViewModel
    {
        public ObservableCollection<ShopListItem> Items { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();

            LoadItems();
        }

        private void LoadItems()
        {
            Items.Add(new ShopListItem
            {
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false
            });

            Items.Add(new ShopListItem
            {
                Nombre = "Pan",
                Cantidad = 1,
                Comprado = false
            });

            Items.Add(new ShopListItem
            {
                Nombre = "Harina",
                Cantidad = 12,
                Comprado = false
            });
        }
        [RelayCommand]
        private async Task ShowNewItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListItemPage));
        }

    }

}
