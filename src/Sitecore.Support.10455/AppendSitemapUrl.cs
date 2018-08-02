using Sitecore.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent;
using Sitecore.XA.Foundation.Multisite.Extensions;

namespace Sitecore.Support.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent
{
  public class AppendSitemapUrl : Sitecore.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent.AppendSitemapUrl
  {
    public virtual void Process(GetRobotsContentArgs args)
    {
      if (!SiteExtensions.IsSxaSite(Context.Site))
        return;
      base.Process(args);
    }
  }
}