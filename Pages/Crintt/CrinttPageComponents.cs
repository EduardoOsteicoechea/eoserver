using System.Text;

namespace eoserver
{
   public class CrinttPageComponents : IPageComponents
   {
      public StringBuilder MarkupBuilder { get; set; } = new();
      public OperationNumberComponent OperationNumber { get; set; } = new();
      public OperationDateComponent OperationDate { get; set; } = new();
      public OperationTimeComponent OperationTime { get; set; } = new();
      public OperationRegistriesQuantityComponent OperationRegistriesQuantity { get; set; } = new();
      public SubmitButtonComponent SubmitButton { get; set; } = new();
      public List<IComponent> ComponentList { get; set; } = [];
      public CrinttPageComponents()
      {
         ComponentList.Add(OperationNumber);
         ComponentList.Add(OperationDate);
         ComponentList.Add(OperationTime);
         ComponentList.Add(OperationRegistriesQuantity);
         ComponentList.Add(SubmitButton);
         GenerateComponentListHTML();
      }
      public void GenerateComponentsStylesheetsLinks() { }
      public string Print() { return MarkupBuilder.ToString(); }
      public string PrintComponentsStylesheetsLinks() { return ""; }
      public void GenerateComponentListHTML()
      {
         foreach (IComponent component in ComponentList) 
         {
            MarkupBuilder.Append(component.Print());
         }
      }
   }
}
