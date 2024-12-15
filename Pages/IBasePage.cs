using System.Text;

namespace eoserver
{
   public interface IBasePage
   {
      string PageName { get; set; }
      StringBuilder MarkupBuilder { get; set; }
      IPageComponents Components { get; set; }
      ISessionManager SessionManager { get; set; }
      GlobalHeaderComponent GlobalHeaderComponent { get; set; }
      GlobalSidebarComponent GlobalSidebarComponent { get; set; }
      GlobalAsideComponent GlobalAsideComponent { get; set; }
      GlobalFooterComponent GlobalFooterComponent { get; set; }
      GlobalJavaScriptComponent GlobalJavaScriptComponent { get; set; }
      string Print();
      public void GenerateTemplate();
      public void AppendDoctypeTag();
      public void AppendHTMLStartTag();
      public void AppendHeadStartTag();
      public void AppendDefaultHeadTags();
      public void GenerateComponentsStylesheetsLinks();
      public void AppendComponentsStylesheetsLinks();
      public void AppendHeadEndTag();
      public void AppendBodyStartTag();
      public void AppendHeader();
      public void AppendSidebar();
      public void AppendAside();
      public void AppendFooter();
      public void AppendMainStartTag();
      public void AppendComponents();
      public void AppendMainEndTag();
      public void AppendGlobalJavaScript();
      public void AppendBodyEndTag();
      public void AppendHTMLEndTag();
   }
}