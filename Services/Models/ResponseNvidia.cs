namespace Services.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Choice
    {
        public int index { get; set; }
        public Message message { get; set; }
        public object logprobs { get; set; }
        public string finish_reason { get; set; }
        public object stop_reason { get; set; }
        public object token_ids { get; set; }
        public object routed_experts { get; set; }
    }

    public class Message
    {
        public string role { get; set; }
        public string content { get; set; }
        public object refusal { get; set; }
        public object annotations { get; set; }
        public object audio { get; set; }
        public object function_call { get; set; }
        public List<object> tool_calls { get; set; }
        public object reasoning { get; set; }
    }

    public class ResponseNvidia
    {
        public string id { get; set; }
        public string @object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public List<Choice> choices { get; set; }
        public object service_tier { get; set; }
        public string system_fingerprint { get; set; }
        public Usage usage { get; set; }
        public object prompt_logprobs { get; set; }
        public object prompt_token_ids { get; set; }
        public object prompt_text { get; set; }
        public object kv_transfer_params { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int total_tokens { get; set; }
        public int completion_tokens { get; set; }
        public object prompt_tokens_details { get; set; }
    }

}
