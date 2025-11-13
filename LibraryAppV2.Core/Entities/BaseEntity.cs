using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppV2.Core.Entities
{
    public abstract class BaseEntity
    {
            protected BaseEntity()
            {
                CreatedAt = DateTime.Now;
                IsDeleted = false;
            }

            public int Id { get; private set; }
            public DateTime CreatedAt { get; private set; }

            public bool IsDeleted { get; private set; }


            public void SetAsDeleted()
            {
                IsDeleted = true;
            }

    }
}
