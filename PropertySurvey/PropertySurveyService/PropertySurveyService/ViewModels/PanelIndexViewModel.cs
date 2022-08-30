using PropertySurveyService.Models;

namespace PropertySurveyService.ViewModels
{
    public class PanelIndexViewModel
    {
        public PanelTable? Panel { get; set; }

        public IEnumerable<PhotoImage>? Images { get; set; }
    }
}
