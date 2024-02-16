using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repositories
{
    public interface IDiffusionRepository<TEntity> : ICrudRepository<TEntity, int> where TEntity : class
    {
    }
}
