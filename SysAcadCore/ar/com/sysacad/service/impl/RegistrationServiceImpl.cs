using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.repository;
using SysAcadCore.ar.com.sysacad.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.service.impl
{
    public class RegistrationServiceImpl : RegistrationService
    {
        private RegistrationRepository _registrationRep;

        public RegistrationServiceImpl() {
            _registrationRep = new RegistrationRepositoryImpl();
        }

        public List<Registration> GetAllRegistrationOfAStudent(int stdFileNm) {
            return _registrationRep.GetAllByFileNumber(stdFileNm);
        }
    }
}
