namespace Services.Apis.Cep.GetCep
{
    public interface IApiBrasilService
    {
        Task<GetPostalCodeResponse> GetPostalCode(string postalCode);
    }
}
