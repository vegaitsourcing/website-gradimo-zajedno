namespace GradimoZajedno.Core.ViewModels.Partials.Listing;

using System;
using GradimoZajedno.Core.Models;

public class PaginationViewModel
{
    public PaginationViewModel(IPagination pagination)
    {
        Pagination = pagination ?? throw new ArgumentNullException(nameof(pagination));
    }

    public IPagination Pagination { get; }
}
