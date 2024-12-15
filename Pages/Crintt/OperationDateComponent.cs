namespace eoserver
{
   public class OperationDateComponent: IComponent
   {
      public OperationDateComponent() {}
      public string Print()
      {
         return $@"
            <div>
               <label>Fecha de envío</label>
               <input type='number'>
            <div>
         ";
      }
   }
}
