using System;
using System.Collections.Generic;

namespace Patrones.Modelos.Data;

public partial class Beer
{
    //Scaffold-DbContext "Server=localhost;Database=Testing; Trusted_Connection=true;TrustServerCertificate=true" Microsoft.EntityFrameWorkCore.SqlServer -OutputDir Data -force
    public Guid BeerId { get; set; }

    public string Name { get; set; } = null!;

    public string Style { get; set; } = null!;

    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
