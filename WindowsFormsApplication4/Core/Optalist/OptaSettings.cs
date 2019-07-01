namespace WindowsFormsApplication4.Core.Optalist
{
    class OptaSettings : IParserSettings
    {
        public OptaSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl
        {
            get; set;
        } = "https://tastycoffeesale.ru/coffee/";

        public int EndPoint
        {
            get; set;
        }

        public string Prefix
        {
            get;set;
        } = "?page={CurrentId}";

        public int StartPoint
        {
            get; set;
        }
    }
}
