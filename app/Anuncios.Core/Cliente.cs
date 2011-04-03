using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;
using SharpArch.Core.NHibernateValidator;

namespace Anuncios.Core
{
    [HasUniqueDomainSignature]
    public class Cliente : Entity
    {
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Mail { get; set; }
        public virtual IList<Anuncio> Anuncios { get; set; }
        public virtual bool Habilitado { get; set; }

    }
}
