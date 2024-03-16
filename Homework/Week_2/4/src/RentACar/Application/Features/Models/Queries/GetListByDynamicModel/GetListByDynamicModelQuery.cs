using Application.Features.Brands.Models;
using Application.Features.Models.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Features.Models.Queries.GetListByDynamicModel
{
    public class GetListByDynamicModelQuery : IRequest<ModelListModel>
    {
        public Dynamic Dynamic {  get; set; }
        public PageRequest PageRequest { get; set; }

        public class GetListByDynamicModelQueryHandler : IRequestHandler<GetListByDynamicModelQuery, ModelListModel>
        {
            private readonly IModelRepository _modelRepository;
            private readonly IMapper _mapper;

            public GetListByDynamicModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
            {
                _modelRepository = modelRepository;
                _mapper = mapper;
            }

            public async Task<ModelListModel> Handle(GetListByDynamicModelQuery request, CancellationToken cancellationToken)
            {
                // this models that car models
                IPaginate<Model> models = await _modelRepository.GetListByDynamicAsync(request.Dynamic,include:
                                            m => m.Include(c => c.Brand),
                                            index: request.PageRequest.Page,
                                            size: request.PageRequest.PageSize);

                ModelListModel mappedModels = _mapper.Map<ModelListModel>(models);

                return mappedModels;
            }
        }
    }
}
