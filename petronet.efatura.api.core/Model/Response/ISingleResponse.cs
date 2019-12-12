namespace petronet.efatura.api.core.Model.Response {
    public interface ISingleResponse<TModel> : IResponse
    {
        TModel Model { get; set; }
    }
}
