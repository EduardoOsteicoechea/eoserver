namespace eoserver
{
   public class OperationRegistriesQuantityComponent: IComponent
   {
      public OperationRegistriesQuantityComponent() {}
      public string Print()
      {
         return $@"
            <div>
               <label>Cantidad de registros</label>
               <input type='number'>
            <div>
         ";
      }
   }
}
