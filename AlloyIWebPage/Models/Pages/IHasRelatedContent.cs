using EPiServer.Core;

namespace AlloyIWebPage.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
