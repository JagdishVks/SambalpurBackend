namespace dharmendraPradhan.Models
{
    public class WhattsappwebModel
    {


        public int Id { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public List<string> Content { get; set; } = new List<string>(); // Initialize Content as an empty list
        public DateTime Timestamp { get; set; }
    }
}
