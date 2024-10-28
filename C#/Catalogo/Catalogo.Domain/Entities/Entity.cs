using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities;

public abstract class Entity
{

    // se tivessemos outras entidades todas teriam uma propriedade de ID e todas elas herdariam de Entity que é uma classe abstrata
    public int Id { get; protected set; }

}
