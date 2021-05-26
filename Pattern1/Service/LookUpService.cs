using Pattern1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Service
{
    public class LookUpService : ILookUpService
    {
        public ApplicationDbContext3 context3;

        public LookUpService(ApplicationDbContext3 context3)
        {
            this.context3 = context3;
        }

            
        public int GetShard(int id)
        {
            var lookup = context3.LookUps.Where(x => x.min <= id && id <= x.max).FirstOrDefault();

            return lookup.shard;
        }
    }
}
