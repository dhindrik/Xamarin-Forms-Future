using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Formsfuture.Models;
namespace Formsfuture.ViewModels
{
    public class HomeViewModel : ViewModel
    {
        public HomeViewModel()
        {
            var podcasts = new List<Podcast>()
            {
                new Podcast()
                {
                    Name = "App In The Cloud",
                    Logo ="https://images.transistor.fm/images/show/856/full_1547107023-artwork.jpg",
                    Description = "App In The Cloud is a podcast hosted by Daniel Hindrikes about software development, with focus on Microsoft techologies."
                },
                new Podcast()
                {
                    Name = "The Code Behind",
                    Logo = "https://images.transistor.fm/images/show/858/full_1547060415-artwork.jpg",
                    Description = "En podcast om kod av Daniel Hindrikes och Johan Karlsson!"

                }
            };

            Podcasts = new ObservableCollection<Podcast>(podcasts);
        }

        public ObservableCollection<Podcast> Podcasts { get; set; }
    }
}
