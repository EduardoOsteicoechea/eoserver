namespace eoserver
{
   public class OperationNumberComponent: IComponent
   {
      public OperationNumberComponent() {}
      public string Print()
      {
         return $@"
            <div>
               <label>Número de envío</label>
               <input type='number'>
            <div>
         ";
      }
   }
}
