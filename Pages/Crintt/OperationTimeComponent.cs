namespace eoserver
{
   public class OperationTimeComponent: IComponent
   {
      public OperationTimeComponent() {}
      public string Print()
      {
         return $@"
            <div>
               <label>Hora de envío</label>
               <input type='number'>
            <div>
         ";
      }
   }
}
