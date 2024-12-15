using System.Text;

namespace eoserver
{
   public class CrinttPage: BasePage
   {
      public CrinttPage(
         string pageName,
         IPageComponents components,
         ISessionManager sessionManager = null
      ) 
      { 
         this.PageName = pageName;
         Components = components;
         SessionManager = sessionManager;
         GenerateTemplate();
      }
   }
}
