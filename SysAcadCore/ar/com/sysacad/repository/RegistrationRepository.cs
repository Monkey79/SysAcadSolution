﻿using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository
{
    public interface RegistrationRepository : CrudOperation<Registration>
    {
        List<Registration> GetAllByFileNumber(int stdFileNm);
    }
}
