using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace WinWebSolution.Module {
    public partial class InstantiateAggregatedPropertiesViewController : ViewController {
        public InstantiateAggregatedPropertiesViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            TestAggregatedPropertiesObject obj = (TestAggregatedPropertiesObject)View.CurrentObject;
            obj.SetReadOnlyAddress();
        }
        private void simpleAction2_Execute(object sender, SimpleActionExecuteEventArgs e) {
            TestAggregatedPropertiesObject obj = (TestAggregatedPropertiesObject)View.CurrentObject;
            obj.SetWritableAddress();
        }
    }
}