using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            TestAggregatedPropertiesObject obj = Session.FindObject<TestAggregatedPropertiesObject>(CriteriaOperator.Parse("Name=?", "TestAggregatedPropertiesObject"));
            if (obj == null) {
                obj = new TestAggregatedPropertiesObject(Session);
                obj.Name = "TestAggregatedPropertiesObject";
                obj.Save();
            }
        }
    }
}