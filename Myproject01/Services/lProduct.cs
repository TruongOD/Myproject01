﻿using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;

namespace Myproject01.Services
{
    public interface lProduct
    {
        GenericResponse Create(ProductRequest request);
    }
}
