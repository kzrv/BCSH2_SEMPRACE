﻿using Kozyrev_Hriha_SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozyrev_Hriha_SP.Repository.Interfaces
{
    public interface IAdresaRepository
    {
        int AddNewAdresa(Adresa adresa);
        Task UpdateAdresa(int id, Adresa adresa);
        void DeleteAdresa(int id);
        Task<Adresa>GetAdresaById(int id);
    }
}
