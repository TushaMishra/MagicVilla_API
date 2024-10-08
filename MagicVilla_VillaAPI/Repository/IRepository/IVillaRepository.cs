﻿using MagicT_TAPI.Repository.IRepository;
using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Repository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
