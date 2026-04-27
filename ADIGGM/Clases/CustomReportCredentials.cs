using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Net;
using System.Security.Principal;

namespace ADIGGM.Clases
{
    public class CustomReportCredentials : IReportServerCredentials
    {
        private readonly string _user;
        private readonly string _password;
        private readonly string _domain;

        public CustomReportCredentials(string user, string password, string domain)
        {
            _user = user;
            _password = password;
            _domain = domain;
        }

        public ICredentials ImpressionCredentials => null;

        public ICredentials NetworkCredentials => new NetworkCredential(_user, _password, _domain);

        public bool GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            authCookie = null;
            userName = _user;
            password = _password;
            authority = _domain;
            return false;
        }

        public WindowsIdentity ImpersonationUser => null;
    }
}
