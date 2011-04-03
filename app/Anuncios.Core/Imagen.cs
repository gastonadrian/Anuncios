using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;
using SharpArch.Core.NHibernateValidator;

namespace Anuncios.Core
{
    [HasUniqueDomainSignature]
    public class Imagen : Entity
    {
        public virtual string Nombre { get; set; }
        public virtual Anuncio Cliente { get; set; }

    }
}
