﻿using MedOrganization.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrganization.Module.Services;
using MedOrganization.Module;

namespace MedOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            PacientServise ps = new PacientServise();

            MedOrgService ms = new MedOrgService();


            ServiceZakreplenie sz = new ServiceZakreplenie();
            string message = "";
            sz.Zakreplenie(ref ms, ref ps, out message);

            ms.Save();
            ps.Save();
        }
    }
}
