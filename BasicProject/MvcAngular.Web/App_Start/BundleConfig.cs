﻿using System.Web;
using System.Web.Optimization;

namespace MvcAngular.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS Bundles

            bundles.Add(new StyleBundle("~/Content/css-one")
                .Include("~/Content/bootstrap/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/css-two")
                .Include("~/Content/bootstrap/bootstrap-responsive.css")
                .Include("~/Content/font-awesome/font-awesome.css")
                .Include("~/Content/app/main.css"));


            // Script Bundles

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/bootstrap/modernizr-2.6.2-respond-1.1.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Scripts/jquery/jquery-{version}.js")
                .Include("~/Scripts/bootstrap/bootstrap.js")
                .Include("~/Scripts/angular/angular.js"));
        }
    }
}