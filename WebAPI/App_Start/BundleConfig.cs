﻿using System.Web;
using System.Web.Optimization;

namespace WebAPI
{
    public class BundleConfig
    {
        /// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/polyfills").Include(
                        "~/node_modules/core-js/client/shim.min.js",
                        "~/node_modules/zone.js/dist/zone.min.js",
                        "~/node_modules/systemjs/dist/system.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/node_modules/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/node_modules/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/config").Include(
                        "~/systemjs.config.js"));
        }
    }
}
