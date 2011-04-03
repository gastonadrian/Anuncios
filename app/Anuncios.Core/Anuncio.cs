using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;
using SharpArch.Core.NHibernateValidator;

namespace Anuncios.Core
{
    public enum TipoAnuncio
    {
        Grande = 1,
        Mediano,
        Pequeño
    }

    [HasUniqueDomainSignature]
    public class Anuncio : Entity
    {


        public virtual string Texto { get; set; }
        public virtual IList<Imagen> Imagenes { get; set; }
        public virtual int Tipo { get; set; }
        public virtual IList<CategoriaAnuncio> Categorias { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
