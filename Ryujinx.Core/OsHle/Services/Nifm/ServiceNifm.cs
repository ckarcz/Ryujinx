using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.Services.Nifm
{
    class ServiceNifm : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public ServiceNifm()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                { 4, CreateGeneralServiceOld }
            };
        }

        public long CreateGeneralServiceOld(ServiceCtx Context)
        {
            MakeObject(Context, new IGeneralService());

            return 0;
        }
    }
}