using UiPath.CodedWorkflows;
using System;

namespace SM_Snacktime_Downloading_Performer
{
    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection Production_scmc_bot1_smsupermalls_com__3 { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Production_scmc_bot1_smsupermalls_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("228722d4-b973-40e7-a1af-0bcce05d7515", resolver);
        }
    }

    public class O365MailFactory
    {
        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection Production_scmc_bot1_smsupermalls_com__3 { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Production_scmc_bot1_smsupermalls_com__3 = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("228722d4-b973-40e7-a1af-0bcce05d7515", resolver);
        }
    }
}