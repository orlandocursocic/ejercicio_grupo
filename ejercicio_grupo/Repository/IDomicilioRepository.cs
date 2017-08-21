﻿using ejercicio_grupo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_grupo.Repository
{
    public interface IDomicilioRepository
    {
        Domicilio Create(Domicilio domicilio);
        Domicilio Read(long id);
        IQueryable<Domicilio> ReadAll();
        void Update(Domicilio domicilio);
        Domicilio Delete(long id);
    }
}
