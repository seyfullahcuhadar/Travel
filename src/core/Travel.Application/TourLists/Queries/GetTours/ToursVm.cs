using System.Collections.Generic;
using System.Threading.Tasks;
using Travel.Application.Dtos.Tour;

namespace Travel.Application.TourLists.Queries.GetTours
{
    public class ToursVm
    {
        public Task<List<TourListDto>> Lists { get; set; }
    }
}