using AutoMapper;
using SharafDG.Application.Features.Categories.Commands.CreateCateogry;
using SharafDG.Application.Features.Categories.Queries.GetCategoriesList;
using SharafDG.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using SharafDG.Application.Features.Events.Commands.CreateEvent;
using SharafDG.Application.Features.Events.Commands.UpdateEvent;
using SharafDG.Application.Features.Events.Queries.GetEventDetail;
using SharafDG.Application.Features.Events.Queries.GetEventsExport;
using SharafDG.Application.Features.Events.Queries.GetEventsList;
using SharafDG.Application.Features.Orders.GetOrdersForMonth;
using SharafDG.Application.Features.SME.Commands;
using SharafDG.Application.Features.SME.Commands.CreateSME;
using SharafDG.Domain.Entities;

namespace SharafDG.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();

            CreateMap<SMEUser, CreateSMECommand>();
            CreateMap<SMEUser, CreateSMEDto>();
        }
    }
}
