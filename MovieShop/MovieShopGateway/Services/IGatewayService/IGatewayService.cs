﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopGateway.Services.IGatewayService
{
    public interface IGatewayService<T>
    {
        IEnumerable<T> ReadAll();
        T Add(T model);

        T ReadById(int id);

        T Update(T model);
        void Delete(T model);

    }
}
