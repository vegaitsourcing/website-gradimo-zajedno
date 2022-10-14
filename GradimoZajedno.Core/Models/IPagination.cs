namespace GradimoZajedno.Core.Models;

using System.Collections.Generic;

public interface IPagination
{
    int Page { get; }
    int TotalPages { get; }
    long TotalResults { get; }

    IReadOnlyList<Page> Pages { get; }

    bool HasPreviousPage();
    bool HasNextPage();
}
