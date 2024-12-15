namespace eoserver
{
   public class BimApi
   {
      public string Content { get; set; }
      public BimApi()
      {
         Content = Newtonsoft.Json.JsonConvert.SerializeObject("{message:'thankslord'}");
      }
   }
}
