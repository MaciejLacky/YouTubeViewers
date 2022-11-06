using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Models;
using YouTubeViewers.Stores;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;
        private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYouTubeViewer;
        public bool HasSelectedField => SelectedYouTubeViewer != null;
        public string UserName => _selectedYouTubeViewerStore.SelectedYouTubeViewer?.Username ?? "Unknown";
        public string IsMemberedDisplay => (_selectedYouTubeViewerStore.SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";
        public string IsSubscribedDisplay => (_selectedYouTubeViewerStore.SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";

       

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {           
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += SelectedYouTubeViewerStore_SelectedChanged;
        }

        protected override void Dispose()
        {
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged -= SelectedYouTubeViewerStore_SelectedChanged;
            base.Dispose();
        }

        private void SelectedYouTubeViewerStore_SelectedChanged()
        {
            OnPropertyChanged(nameof(HasSelectedField));
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(IsMemberedDisplay));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
        }
    }
}
