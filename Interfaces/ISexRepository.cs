using LifeworthAPI.Helper.Account;
using LifeworthAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Interfaces
{
   public interface ISexRepository: IRepository <SexTb>
    {
        public Task<IEnumerable<SexDTO>> Getsex();
    }
}
