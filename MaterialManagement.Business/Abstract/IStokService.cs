﻿using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Abstract
{
    public interface IStokService
    {
        Task<List<Stok>> GetAllStokAsync();
        Task<Stok> GetByStokIdAsync(int stokId);

        Task AddStokAsync(Stok stok);
        Task UpdateStokAsync(Stok stok);
        Task DeleteStokAsync(int stokId);
        
    }
}
