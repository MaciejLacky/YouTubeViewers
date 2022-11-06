using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Models;
using YouTubeViewers.Stores;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersListeningViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;

        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemsViewModels => _youTubeViewersListingItemViewModels;

        private YouTubeViewersListingItemViewModel _selectedYoutubeViewerListingViewModel;
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        public YouTubeViewersListingItemViewModel SelectedYoutubeViewerListingViewModel
        {
            get
            {
                return _selectedYoutubeViewerListingViewModel;
            }
            set
            {
                _selectedYoutubeViewerListingViewModel = value;
                OnPropertyChanged(nameof(SelectedYoutubeViewerListingViewModel));
                _selectedYouTubeViewerStore.SelectedYouTubeViewer = _selectedYoutubeViewerListingViewModel?.YouTubeViewer;
            }
        }

        public YouTubeViewersListeningViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer ("Maciej", true, false)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Madzix", false, false)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Skiper", true, true)));
        }

    }
}
