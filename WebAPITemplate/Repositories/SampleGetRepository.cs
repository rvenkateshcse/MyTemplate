using AutoMapper;
using WebAPITemplate.Models;
using Response = Swashbuckle.AspNetCore.Swagger.Response;

namespace WebAPITemplate.Repositories
{
    public class SampleGetRepository : ISampleGetRepository
    {
        public object Get()
        {
            //Sample Map Operations

            Response response = Mapper.Map<SampleModel, Response>(new SampleModel());
            throw new System.NotImplementedException();
        }
    }
}