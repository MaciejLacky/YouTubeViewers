using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }
        public YouTubeViewersListeningViewModel YouTubeViewersListeningViewModel { get; }
        public ICommand AddYouTubeViewersCommand { get; }
        
        public YouTubeViewersViewModel()
        {
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
            YouTubeViewersListeningViewModel = new YouTubeViewersListeningViewModel();
        }
    }
}
