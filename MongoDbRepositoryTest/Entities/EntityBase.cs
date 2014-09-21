using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A non-instantiable base entity which defines 
/// members available across all entities.
/// </summary>
public abstract class EntityBase
{
    public Guid Id { get; set; }
}