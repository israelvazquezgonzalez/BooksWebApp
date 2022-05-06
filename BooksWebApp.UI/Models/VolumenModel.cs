using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.UI.Models
{
    public class VolumenModel
    {
        public List<BookModel> Items { get; set; }
    }

    public class BookModel
    {

        public string Id { get; set; }
        public VolumeInfo VolumeInfo { get; set; }
        public string SelfLink { get; set; }
    }

    public class VolumeInfo
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string Language { get; set; }
        public string MaturityRating { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Categories { get; set; }
        public ImageLink ImageLinks { get; set; }
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }
    }

    public class ImageLink
    {
        public string SmallThumbnail { get; set; }
        public string Thumbnail { get; set; }
    }

    public class IndustryIdentifier
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
    }
}
