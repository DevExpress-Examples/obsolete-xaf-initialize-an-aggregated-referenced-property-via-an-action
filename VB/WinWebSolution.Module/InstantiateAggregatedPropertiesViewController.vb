Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace WinWebSolution.Module
	Partial Public Class InstantiateAggregatedPropertiesViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			Dim obj As TestAggregatedPropertiesObject = CType(View.CurrentObject, TestAggregatedPropertiesObject)
			obj.SetReadOnlyAddress()
		End Sub
		Private Sub simpleAction2_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction2.Execute
			Dim obj As TestAggregatedPropertiesObject = CType(View.CurrentObject, TestAggregatedPropertiesObject)
			obj.SetWritableAddress()
		End Sub
	End Class
End Namespace