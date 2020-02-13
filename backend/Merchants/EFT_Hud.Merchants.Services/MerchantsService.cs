using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Merchants.Interfaces;
using EFT_Hud.Merchants.Services.Dto;

namespace EFT_Hud.Merchants.Services
{
    public interface IMerchantsService
    {
        IEnumerable<MerchantDto> GetAll();
        MerchantDetailsDto GetDetails(int id);
    }

    public class MerchantsService : IMerchantsService
    {
        private readonly IMerchantRepository _repository;

        public MerchantsService(IMerchantRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<MerchantDto> GetAll()
        {
            var merchants = _repository
                .GetAll()
                .Select(AutoMapperHelper.Map<Merchant,MerchantDto>)
                .ToList();

            return merchants;
        }

        public MerchantDetailsDto GetDetails(int id)
        {
            var merchant = _repository.Get(id);
            var dto = AutoMapperHelper.Map<Merchant, MerchantDetailsDto>(merchant);

            return dto;
        }
    }
}
