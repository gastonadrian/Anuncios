using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Anuncios.Data.NHibernateMaps.Conventions
{
    public class HasManyConvention : IHasManyConvention
    {
        
        
        #region IConvention<IOneToManyCollectionInspector,IOneToManyCollectionInstance> Members

        public void Apply(FluentNHibernate.Conventions.Instances.IOneToManyCollectionInstance instance)
        {
            oneToManyPart.KeyColumnNames.Clear();
            oneToManyPart.KeyColumnNames.Add(oneToManyPart.EntityType.Name + "Id");
        }

        #endregion
    }
}
