

namespace eoserver
{
	public class BimCompanyProjectBepChecklist: IUIJsonContent
	{
		public ClientDataModel ClientData {get;set;}		
		public string PageTitle {get;set;}
		public string PageMainHeading {get;set;}

		public BimCompanyProjectBepChecklist
		(
		 	int? companyId, 
			int? projectId, 
			int? checklistId
		)
		{
			if(companyId == 1 && projectId == 2 && checklistId == 3)
			{
				ClientData = new ClientDataModel();
				
				ClientData.companyId = companyId;
				ClientData.projectId = projectId;
				ClientData.checklistId = checklistId;

				PageTitle = "MTA Bep 1 Checklist";
				PageMainHeading = "Complete the following tasks";
			};
		}
	}
}
