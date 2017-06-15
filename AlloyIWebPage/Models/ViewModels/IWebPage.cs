using EPiServer.Core;

namespace AlloyIWebPage.Models.ViewModels
{
    public interface IWebPage
    {
        string PageTitle { get; }

        string SeoDescription { get; }

        string[] SeoKeywords { get; }

        ContentReference ContentLink { get; }

        ContentReference ParentLink { get; }

        string Language { get; }

        IContent Section { get; set; }

        LayoutModel Layout { get; set; }
    }
}
