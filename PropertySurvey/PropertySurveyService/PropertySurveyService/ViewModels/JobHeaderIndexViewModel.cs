
using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class JobHeaderIndexViewModel
    {
        public IEnumerable<Job>? Jobs { get; set; }
        public IEnumerable<Header>? Headers { get; set; }
    }
}
