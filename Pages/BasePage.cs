using System.Text;

namespace eoserver
{
   public class BasePage: IBasePage
   {
      public string PageName { get; set;} = "";
      public StringBuilder MarkupBuilder { get; set;} = new();
      public IPageComponents Components { get; set;}
      public ISessionManager SessionManager { get; set;}
      public GlobalHeaderComponent GlobalHeaderComponent { get; set;} = new();
      public GlobalSidebarComponent GlobalSidebarComponent { get; set;} = new();
      public GlobalAsideComponent GlobalAsideComponent { get; set;} = new();
      public GlobalFooterComponent GlobalFooterComponent { get; set;} = new();
      public GlobalJavaScriptComponent GlobalJavaScriptComponent { get; set;} = new();

      public string Print()
      {
         return MarkupBuilder.ToString();
      }
      
      public BasePage
      (
      )
      {
      }

      public BasePage
      (
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

      public void GenerateTemplate()
      {
         AppendDoctypeTag();
         AppendHTMLStartTag();
         AppendHeadStartTag();
         AppendDefaultHeadTags();
         GenerateComponentsStylesheetsLinks();
         AppendComponentsStylesheetsLinks();
         AppendHeadEndTag();
         AppendBodyStartTag();
         AppendHeader();
         AppendMainStartTag();
         AppendComponents();
         AppendMainEndTag();
         AppendSidebar();
         AppendAside();
         AppendFooter();
         AppendGlobalJavaScript();
         AppendBodyEndTag();
         AppendHTMLEndTag();
      }

      public void AppendDoctypeTag()
      {
         MarkupBuilder.Append($@"
            <!DOCTYPE html>
         ");
      }
      public void AppendHTMLStartTag()
      {
         MarkupBuilder.Append($@"
            <html lang='en'>
         ");
      }
      public void AppendHeadStartTag()
      {
         MarkupBuilder.Append($@"
            <head>
         ");
      }
      public void AppendDefaultHeadTags()
      {
         MarkupBuilder.Append($@"
            <meta charset='utf-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <meta name='theme-color' content='#fff'>
            <meta name='author' content='Eduardo Osteicoechea'>
            <meta name='robots' content='index,follow'>
            <link rel='stylesheet' href='index.css'>
            <link rel='icon' type='image/x-icon' href='favicon.webp'>
            <title>{this.PageName}</title>
         ");
      }
      public void GenerateComponentsStylesheetsLinks()
      {
         Components.GenerateComponentsStylesheetsLinks();
      }
      public void AppendComponentsStylesheetsLinks()
      {
         MarkupBuilder.Append(Components.PrintComponentsStylesheetsLinks());
      }

      public void AppendHeadEndTag()
      {
         MarkupBuilder.Append($@"
            </head>
         ");
      }

      public void AppendBodyStartTag()
      {
         MarkupBuilder.Append($@"
            <body>
         ");
      }

      public void AppendHeader()
      {
         MarkupBuilder.Append(GlobalHeaderComponent.Print());
      }

      public void AppendSidebar()
      {
         MarkupBuilder.Append(GlobalSidebarComponent.Print());
      }

      public void AppendAside()
      {
         MarkupBuilder.Append(GlobalAsideComponent.Print());
      }

      public void AppendFooter()
      {
         MarkupBuilder.Append(GlobalFooterComponent.Print());
      }

      public void AppendMainStartTag()
      {
         MarkupBuilder.Append($@"
            <main>
         ");
      }

      public void AppendComponents()
      {
         MarkupBuilder.Append(Components.Print());
      }

      public void AppendMainEndTag()
      {
         MarkupBuilder.Append($@"
            </main>
         ");
      }

      public void AppendGlobalJavaScript()
      {
         MarkupBuilder.Append(GlobalJavaScriptComponent.Print());
      }

      public void AppendBodyEndTag()
      {
         MarkupBuilder.Append($@"
            </body>
         ");
      }

      public void AppendHTMLEndTag()
      {
         MarkupBuilder.Append($@"
            </html>
         ");
      }
   }
}
