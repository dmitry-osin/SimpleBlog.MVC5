using System.Web.Optimization;

namespace SimpleBlog.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/prism").Include(
                      "~/Scripts/prism.js"));

           bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"
                      ,"~/Content/styles.css"
                      , "~/Content/ubuntu-font.css"
                      , "~/Content/font-awesome.min.css"
                      ,"~/Content/prism.css"));

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
            
        } 
    }
}