using System.Web;
using System.Web.Optimization;

namespace ProjectOnePlace
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Asset/Scripts/Libraries/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Asset/Scripts/Libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Asset/Scripts/Libraries/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Asset/Scripts/Libraries/bootstrap.js",
                      "~/Asset/Scripts/Libraries/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Asset/Css/Libraries/bootstrap.css",
                      "~/Asset/Css/Custom/site.css"));

            bundles.Add(new ScriptBundle("~/Sitebase/JS").Include(
                "~/Asset/Scripts/main.js"));
            bundles.Add(new ScriptBundle("~/Releasemodule/JS").Include(
                "~/Asset/Scripts/release-module.js"));

            bundles.Add(new ScriptBundle("~/angular/JS").Include("~/Asset/Scripts/Libraries/angular.1.6.9.js"));
        }
    }
}
