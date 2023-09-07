using ChaosCraftsShop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;

namespace ChaosCraftsShop.Pages.App
{
    public partial class ProductCard
    {
        [Parameter]
        public Product? Product { get; set; }
    }
}
