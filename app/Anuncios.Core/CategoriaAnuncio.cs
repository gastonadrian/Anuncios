using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;
using SharpArch.Core.NHibernateValidator;

namespace Anuncios.Core
{
    public enum Posicion
    {
        Izquierda = 1,
        Derecha,
        Centro
    }

    [HasUniqueDomainSignature]
    public class CategoriaAnuncio : Entity
    {
        public virtual Anuncio Anuncio { get; set; }
        public virtual IList<Categoria> Categoria { get; set; }
        public virtual int Posicion { get; set; }
    }
}
