﻿using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Abstract
{
    public interface IMalzemeService 
    {
        
        Task AddMalzemeAsync(Malzeme malzeme);
        Task UpdateMalzemeAsync(Malzeme malzeme);
        Task DeleteMalzemeAsync(int malzemeId);

        Task<Malzeme> GetByMalzemeIdAsync(int malzemeId);
        Task<List<Malzeme>> GetAllMalzemeAsync();


    }
}
