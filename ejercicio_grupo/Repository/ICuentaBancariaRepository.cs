﻿using ejercicio_grupo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_grupo.Repository
{
    public interface ICuentaBancariaRepository
    {
        CuentaBancaria Create(CuentaBancaria cuentaBancaria);
        CuentaBancaria Read(long id);
        IQueryable<CuentaBancaria> ReadAll();
        void Update(CuentaBancaria cuentaBancaria);
        CuentaBancaria Delete(long id);
    }
}
