namespace petronet.efatura.api.core.Model.Response {
    using System.Collections.Generic;

    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }
}
