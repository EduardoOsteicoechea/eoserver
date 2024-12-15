namespace eoserver
{
   public class SubmitButtonComponent: IComponent
   {
      public SubmitButtonComponent() {}
      public string Print()
      {
         return $@"
            <div>
               <button>Enviar</button>
            <div>
         ";
      }
   }
}
