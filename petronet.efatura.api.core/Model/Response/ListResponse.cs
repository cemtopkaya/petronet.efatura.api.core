namespace petronet.efatura.api.core.Model.Response {
    using System.Collections.Generic;

    public class ListResponse<TModel> : IListResponse<TModel>, IResponse
    {
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public IEnumerable<TModel> Model { get; set; }
    }
}
