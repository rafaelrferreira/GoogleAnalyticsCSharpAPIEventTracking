using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoogleAnalyticsCSharpAPIET;

namespace GoogleAnalyticsCSharpAPIET {
    public partial class _Default : Page {
        //You need to go to https://console.developers.google.com and register your application to get a clientID
        //http://www.spyriadis.net/2014/07/google-analytics-measurement-protocol-track-events-c/
        //https://developers.google.com/analytics/devguides/collection/protocol/v1/devguide

        protected void Page_Load(object sender, EventArgs e) {
            //Inicialize
            GoogleTracker ga = new GoogleTracker("");

            //Track Event
            ga.trackEvent("Financeiro", "Assinatura", "IdPlano", "12345");
        }
    }
}