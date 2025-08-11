using UiPath.CodedWorkflows;
using System;

namespace SM_Snacktime_Downloading_Performer
{
    public class ConnectionsManager
    {
        public ExcelFactory Excel { get; set; }
        public O365MailFactory O365Mail { get; set; }
        public OneDriveFactory OneDrive { get; set; }

        public ConnectionsManager(ICodedWorkflowsServiceContainer resolver)
        {
            Excel = new ExcelFactory(resolver);
            O365Mail = new O365MailFactory(resolver);
            OneDrive = new OneDriveFactory(resolver);
        }
    }
}