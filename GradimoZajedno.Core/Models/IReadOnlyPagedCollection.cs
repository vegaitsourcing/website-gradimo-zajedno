namespace GradimoZajedno.Core.Models;

using System.Collections.Generic;

public interface IReadOnlyPagedCollection<out T>
{
    IReadOnlyList<T> Items { get; }
    IPagination Pagination { get; }
}
