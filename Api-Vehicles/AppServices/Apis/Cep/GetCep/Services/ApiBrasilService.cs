namespace AppServices.Apis.Cep.GetCep.Services
{
    public class ApiBrasilService : IApiBrasilService
    {
        private readonly IBrasilApi _brasilApi;

        public ApiBrasilService(IBrasilApi brasilApi)
        {
            _brasilApi = brasilApi;
        }

        public async Task<GetPostalCodeResponse> GetPostalCode(string postalCode)
        {
            try
            {
                var apiResponse = await _brasilApi.GetPostalCode(postalCode).ConfigureAwait(false);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    throw new ArgumentNullException("Erro ao chamar api de CEP");
                }

                return apiResponse.Content;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Erro ao chamar api de CEP");
            }
        }
    }
}
