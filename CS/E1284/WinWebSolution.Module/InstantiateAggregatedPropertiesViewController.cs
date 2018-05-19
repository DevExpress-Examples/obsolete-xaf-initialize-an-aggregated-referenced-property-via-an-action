using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public partial class InstantiateAggregatedPropertiesViewController : ViewController {
        public InstantiateAggregatedPropertiesViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            TestAggregatedPropertiesObject obj = View.CurrentObject as TestAggregatedPropertiesObject;
            if (obj != null) {
                obj.SetReadOnlyAddress();
            }
        }
        private void simpleAction2_Execute(object sender, SimpleActionExecuteEventArgs e) {
            TestAggregatedPropertiesObject obj = View.CurrentObject as TestAggregatedPropertiesObject;
            if (obj != null) {
                obj.SetWritableAddress();
            }
        }
    }
}