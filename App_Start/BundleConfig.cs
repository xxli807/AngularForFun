using System.Web;
using System.Web.Optimization;

namespace AngularForFun
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Comlib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/Comlib/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Comlib/jquery.unobtrusive*",
                        "~/Scripts/Comlib/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
 
            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));


            RegisuerCustomJsBudle(bundles);
            RegisuerCustomCssBudle(bundles);
        }


        public static void RegisuerCustomJsBudle(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Scripts/AngularBootstrap").Include(
                    "~/Scripts/Angular/angular.js",
                     "~/Scripts/Angular/angular-route.js",
                     "~/Scripts/Bootstrap/bootstrap.js" 
                     //"~/Scripts/Bootstrap/npm.js"
                 )
            );


            //the download template
            bundles.Add(new ScriptBundle("~/Scripts/DownloadTemplate").IncludeDirectory("~/Scripts/MyScript/Download", "*.js", true));
             
        }


        public static void RegisuerCustomCssBudle(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/AngularBootstrap").IncludeDirectory("~/Content/bootstrap","*.css",true));


            bundles.Add(new StyleBundle("~/Content/DownloadCss").IncludeDirectory("~/Content/DownloadCss","*.css",true));

        }
    


    
    
    }
}