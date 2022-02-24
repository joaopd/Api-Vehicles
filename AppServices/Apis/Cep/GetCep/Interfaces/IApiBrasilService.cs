namespace AppServices.Apis.Cep.GetCep
{
    public interface IApiBrasilService
    {
        Task<GetPostalCodeResponse> GetPostalCode(string postalCode);
    }
}
