namespace Sitecore.Support.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent
{
  using Sitecore.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent;
  using Sitecore.XA.Foundation.Multisite.Extensions;

  public class AppendSitemapUrl : Sitecore.XA.Feature.SiteMetadata.Pipelines.GetRobotsContent.AppendSitemapUrl
  {
    public override void Process(GetRobotsContentArgs args)
    {
      #region Added code
      if (Sitecore.Context.Site.IsSxaSite())
      {
        base.Process(args);
      } 
      #endregion
    }
  }
}