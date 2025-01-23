﻿using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Abstract
    {
        public interface IMalzemeGrupService
        {
            Task<List<MalzemeGrup>> GetAllMalzemeGrupAsync();
            Task AddMalzemeGrupAsync(MalzemeGrup malzemeGrup);
            Task UpdateMalzemeGrupAsync(MalzemeGrup malzemeGrup);
            Task DeleteMalzemeGrupAsync(int malzemeGrupId);
            Task<MalzemeGrup> GetByMalzemeGrupIdAsync(int malzemeGrupId);
        }
    }
