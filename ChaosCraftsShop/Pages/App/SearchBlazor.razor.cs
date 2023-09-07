using ChaosCraftsShop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;

namespace ChaosCraftsShop.Pages.App
{
    public partial class SearchBlazor
    {
        public string SearchText = "";
        public List<Product> FilteredProducts { get; set; } = new List<Product>();

        [Inject]
        public IProductRepository? ProductRepository { get; set; }

        private void Search()
        {
            FilteredProducts.Clear();
            if (ProductRepository is not null)
            {
                if (SearchText.Length >= 3)
                    FilteredProducts = ProductRepository.SearchProducts(SearchText).ToList();
            }
        }
    }
}
