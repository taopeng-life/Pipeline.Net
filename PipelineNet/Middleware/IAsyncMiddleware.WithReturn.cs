﻿using System;
using System.Threading.Tasks;

namespace Pipeline.Net.Middleware
{
    public interface IAsyncMiddleware<TParameter, TReturn>
    {
        Task<TReturn> Run(TParameter parameter, Func<TParameter, Task<TReturn>> next);
    }
}
