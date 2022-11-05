using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersListeningViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;

        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemsViewModels => _youTubeViewersListingItemViewModels;

        public YouTubeViewersListeningViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Maciej"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Madzix"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Skiper"));
        }

    }
}
