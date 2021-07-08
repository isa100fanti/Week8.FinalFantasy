﻿using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repository
{
    public interface IRepositoryEroe
    {
        public int Attacco(Arma arma, int puntivita); //l'arma mi serve per vedere i punti danno!
        public void Fuga();
        public bool CreaEroe(Eroe eroe);

    }
}
