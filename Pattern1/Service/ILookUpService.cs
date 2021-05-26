using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Service
{
    public interface ILookUpService
    {
        public int GetShard(int id);
    }
}
