using System.Web;
using System.Web.Optimization;

namespace MVCBlogProject.MVCUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Admin/css").Include(
                      "~/Content/AdminTheme/css/bootstrap.min.css",
                      "~/Content/AdminTheme/css/bootstrap-reset.css",
                      "~/Content/AdminTheme/assets/font-awesome/css/font-awesome.css",
                      "~/Content/AdminTheme/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css",
                      "~/Content/AdminTheme/css/owl.carousel.css",
                      "~/Content/AdminTheme/css/style.css",
                      "~/Content/AdminTheme/css/style-responsive.css"));

            bundles.Add(new ScriptBundle("~/Admin/js").Include(
                      "~/Content/AdminTheme/js/jquery.js",
                      "~/Content/AdminTheme/js/jquery-1.8.3.min.js",
                      "~/Content/AdminTheme/js/bootstrap.min.js",
                      "~/Content/AdminTheme/js/jquery.dcjqaccordion.2.7.js",
                      "~/Content/AdminTheme/js/jquery.scrollTo.min.js",
                      "~/Content/AdminTheme/js/jquery.nicescroll.js",
                      "~/Content/AdminTheme/js/jquery.sparkline.js",
                      "~/Content/AdminTheme/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js",
                      "~/Content/AdminTheme/js/owl.carousel.js",
                      "~/Content/AdminTheme/js/jquery.customSelect.min.js",
                      "~/Content/AdminTheme/js/respond.min.js",
                      "~/Content/AdminTheme/js/jquery.dcjqaccordion.2.7.js",
                      "~/Content/AdminTheme/js/common-scripts.js",
                      "~/Content/AdminTheme/js/sparkline-chart.js",
                      "~/Content/AdminTheme/js/easy-pie-chart.js",
                      "~/Content/AdminTheme/js/count.js"));
        }
    }
}
