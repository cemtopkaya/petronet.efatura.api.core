namespace petronet.efatura.api.core.Model.Response {
    public interface IPagedResponse<TModel> : IListResponse<TModel>, IResponse
    {
        int ItemsCount { get; set; }

        double PageCount { get; }
    }
}
