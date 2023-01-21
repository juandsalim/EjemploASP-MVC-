using System;
using System.Collections.Generic;

namespace EjemploASP_MVC_.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; } = new List<Beer>();
}
