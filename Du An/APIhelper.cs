namespace Du_An
{
    public class APIhelper
    {
      public static HttpClient APIClient { get; set; } = new HttpClient();
        public static void InitializeClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
