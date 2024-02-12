using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Repositories
{
    public interface ICinemaRoomRepository<TEntity>: ICrudRepository<TEntity, int>where TEntity : class
    {
    }
}
