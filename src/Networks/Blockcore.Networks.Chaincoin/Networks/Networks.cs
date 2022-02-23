namespace Blockcore.Networks.Chaincoin
{
    public static class Networks
   {
      public static NetworksSelector Chaincoin
      {
         get
         {
            return new NetworksSelector(() => new ChaincoinMain(), () => new ChaincoinTest(), () => new ChaincoinRegTest());
         }
      }
   }
}
