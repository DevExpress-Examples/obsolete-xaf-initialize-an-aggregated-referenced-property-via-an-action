Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	Partial Public Class InstantiateAggregatedPropertiesViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			Dim obj As TestAggregatedPropertiesObject = TryCast(View.CurrentObject, TestAggregatedPropertiesObject)
			If obj IsNot Nothing Then
				obj.SetReadOnlyAddress()
			End If
		End Sub
		Private Sub simpleAction2_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction2.Execute
			Dim obj As TestAggregatedPropertiesObject = TryCast(View.CurrentObject, TestAggregatedPropertiesObject)
			If obj IsNot Nothing Then
				obj.SetWritableAddress()
			End If
		End Sub
	End Class
End Namespace