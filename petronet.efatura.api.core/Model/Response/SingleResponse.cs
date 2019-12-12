namespace petronet.efatura.api.core.Model.Response {
    public class SingleResponse<TModel> : ISingleResponse<TModel>, IResponse
    {
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public TModel Model { get; set; }
    }
}
