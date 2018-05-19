Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim obj As TestAggregatedPropertiesObject = ObjectSpace.FindObject(Of TestAggregatedPropertiesObject)(CriteriaOperator.Parse("Name=?", "TestAggregatedPropertiesObject"))
			If obj Is Nothing Then
				obj = New TestAggregatedPropertiesObject(Session)
				obj.Name = "TestAggregatedPropertiesObject"
				obj.Save()
			End If
		End Sub
	End Class
End Namespace