using EPiServer.Core;
using AlloyIWebPage.Models.Pages;

namespace AlloyIWebPage.Models.ViewModels
{
    public class PageViewModel<T> : IWebPage, IPageViewModel<T> where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }

        public LayoutModel Layout { get; set; }

        public IContent Section { get; set; }

        public string PageTitle => CurrentPage.MetaTitle;

        public string SeoDescription => CurrentPage.MetaDescription;

        public ContentReference ContentLink => CurrentPage.ContentLink;

        public ContentReference ParentLink => CurrentPage.ParentLink;

        public string[] SeoKeywords => CurrentPage.MetaKeywords;

        public string Language => CurrentPage.LanguageBranch;
    }

    public static class PageViewModel
    {
        /// <summary>
        /// Returns a PageViewModel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData
        {
            return new PageViewModel<T>(page);
        }
    }
}
