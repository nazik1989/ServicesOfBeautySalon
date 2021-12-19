using System.Web;
using System.Web.Optimization;

namespace ServicesOfBeautySalon
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


            ////////////////////////////Adding by Nazik
            bundles.Add(new ScriptBundle("~/bundles/easing").Include(
                      "~/Scripts/easing.js"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                "~/Scripts/home.js"));

            bundles.Add(new ScriptBundle("~/bundles/jarallax").Include(
                "~/Scripts/jarallax.js"));            
            bundles.Add(new ScriptBundle("~/bundles/afterJaralax").Include(
                "~/Scripts/afterJaralax.js"));

            //bundles.Add(new ScriptBundle("~/bundles/owlcarousel").Include(
            //            "~/Scripts/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/bundles/movetop").Include(
                        "~/Scripts/move-top.js"));

            bundles.Add(new ScriptBundle("~/bundles/countup").Include(
                        "~/Scripts/jquery.countup.js"));

            bundles.Add(new ScriptBundle("~/bundles/flexslider").Include(
                        "~/Scripts/jquery.flexslider.js"));

            bundles.Add(new ScriptBundle("~/bundles/waypoints").Include(
            "~/Scripts/jquery.waypoints.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/lightbox").Include(
            "~/Scripts/lightbox-plus-jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/lightboxmap").Include(
"~/Scripts/lightbox-plus-jquery.min.map"));
            //////////////////////////// end adding



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-theme.css.map",
                      "~/Content/bootstrap-theme.min.css",
                      "~/Content/bootstrap-theme.min.css.map",
                      "~/Content/bootstrap.css.map",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.min.css.map",
                      "~/Content/flexslider.css",
                      "~/Content/font-awesome.css",
                      "~/Content/home.css",
                      "~/Content/lightbox.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/site.css",
                      "~/Content/style.css"));
        }
    }
}
