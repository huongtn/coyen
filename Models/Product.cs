using System;
using System.Collections.Generic;

namespace DoChoiThongMinh.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Images { get; set; }

    public string? Description { get; set; }

    public int? Cost { get; set; }

    public int? Discount { get; set; }

    public string? Video { get; set; }

    public int? Star { get; set; }

    public bool? IsNew { get; set; }

    public bool? IsTopSell { get; set; }

    public string? Categories { get; set; }

    public string? Color { get; set; }

    public int? Qty { get; set; }
}
