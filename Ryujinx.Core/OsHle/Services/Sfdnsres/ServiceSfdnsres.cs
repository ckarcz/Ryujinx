using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.Services.Sfdnsres
{
    class ServiceSfdnsres : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public ServiceSfdnsres()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                //{ 0, Function }
            };
        }
    }
}
