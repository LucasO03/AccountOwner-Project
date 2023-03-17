using AutoMapper;
using Entities.DataTranferObjects;
using Entities.DataTransferObjects;
using Entities.Models;

namespace AccountOwnerServer;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDto>();

        CreateMap<Account, AccountDto>();

        CreateMap<OwnerForCreationDto, Owner>();
    }
}