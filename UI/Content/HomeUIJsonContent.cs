namespace eoserver
{
	public class HomeUIJsonContent: IUIJsonContent
	{
		public ClientDataModel ClientData {get;set;}
		public string PageTitle {get;set;} = "Eduardo Osteicoechea";
		public string PageMainHeading {get;set;} = "Thanks Lord Jesus";
		public string HeroPersonalImage {get;set;} = "1920x1920.jpg";
		public List<string> mainIdeas {get;set;} = new List<string>() {
			"Each discipline and sub-consultant are to have their own Revit models",
			"There is a federated model that has the content of all disciplines modeles linked to it",
			"After a Datum model is shared, all disciplines must ensure that they consume the latest shared package, link the Datum model, and copy/monitor Levels & Grids from this model"
		};	










		public HomeUIJsonContent()
		{
		
		}
	}
}
