using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anuncios.Core;
using FluentNHibernate.Automapping.Alterations;

namespace Anuncios.Data.NHibernateMaps
{
    public class ImagenMap : IAutoMappingOverride<Imagen>
    {
        #region IAutoMappingOverride<Imagen> Members

        public void Override(FluentNHibernate.Automapping.AutoMapping<Imagen> mapping)
        {
            mapping.Table("Imagenes");
        }

        #endregion
    }
}
