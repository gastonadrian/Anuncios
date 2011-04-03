using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Anuncios.Data.NHibernateMaps.Conventions
{
    public class TableNameConvention : IClassConvention
    {
        #region IConvention<IClassInspector,IClassInstance> Members

        public void Apply(FluentNHibernate.Conventions.Instances.IClassInstance instance)
        {
            instance.Table(Inflector.Net.Inflector.Pluralize(instance.EntityType.Name));
        }

        #endregion
    }
}
