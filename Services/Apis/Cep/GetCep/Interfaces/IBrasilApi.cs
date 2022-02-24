using Refit;


namespace Services.Apis.Cep.GetCep
{
    public interface IBrasilApi
    {
        [Get("/cep/v1/{postalCode}")]
        Task<ApiResponse<GetPostalCodeResponse>> GetPostalCode(string postalCode);
    }
}
