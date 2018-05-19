using System;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            TestAggregatedPropertiesObject obj = ObjectSpace.FindObject<TestAggregatedPropertiesObject>(CriteriaOperator.Parse("Name=?", "TestAggregatedPropertiesObject"));
            if (obj == null) {
                obj = new TestAggregatedPropertiesObject(Session);
                obj.Name = "TestAggregatedPropertiesObject";
                obj.Save();
            }
        }
    }
}