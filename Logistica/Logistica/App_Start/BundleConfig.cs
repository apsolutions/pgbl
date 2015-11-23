using System.Web;
using System.Web.Optimization;

namespace Logistica
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable").Include(
                "~/Scripts/bootstrapTable/bootstrap-table.min.js",
                "~/Scripts/jquery.base64.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapTableLocale").Include(
                "~/Scripts/bootstrapTable/locale/bootstrap-table-es-AR.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-accent-neutralise").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-accent-neutralise.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-angular").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-angular.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-cookie").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-cookie.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-editable").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-editable.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-export").Include(
                "~/Scripts/bootstrapTable/extensions/export/bootstrap-table-export.min.js",
                "~/Scripts/bootstrapTable/extensions/export/tableExport.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-filter").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-filter.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-filter-control").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-filter-control.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-flat-json").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-flat-json.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-group-by").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-group-by.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-key-events").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-key-events.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-mobile").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-mobile.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-multiple-search").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-multiple-search.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-multiple-sort").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-multiple-sort.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-natural-sorting").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-natural-sorting.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-reorder-columns").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-reorder-columns.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-reorder-rows").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-reorder-rows.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-resizable").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-resizable.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapTable-extension-toolbar").Include(
                "~/Scripts/bootstrapTable/extensions/bootstrap-table-toolbar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/AngularJS").Include(
                "~/Scripts/angular.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap_table").Include(
                      "~/Content/bootstrap_table/bootstrap-table.css",
                      "~/Content/bootstrap_table/bootstrap-table-group-by.css",
                      "~/Content/bootstrap_table/bootstrap-table-reorder-rows.css"));
        }
    }
}
