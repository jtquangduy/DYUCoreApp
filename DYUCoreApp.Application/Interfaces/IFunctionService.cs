﻿using DYUCoreApp.Application.ViewModels.System;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DYUCoreApp.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}