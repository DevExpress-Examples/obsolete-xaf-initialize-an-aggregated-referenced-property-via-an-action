Imports Microsoft.VisualBasic
Imports System
Namespace WinWebSolution.Module
	Partial Public Class InstantiateAggregatedPropertiesViewController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleAction1 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			Me.simpleAction2 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' simpleAction1
			' 
			Me.simpleAction1.Id = "InstantiateReadOnlyAddressViaController"
			Me.simpleAction1.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject
'			Me.simpleAction1.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction1_Execute);
			' 
			' simpleAction2
			' 
			Me.simpleAction2.Id = "InstantiateWritableAddressViaController"
			Me.simpleAction2.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject
'			Me.simpleAction2.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction2_Execute);
			Me.TargetObjectType = GetType(WinWebSolution.Module.TestAggregatedPropertiesObject)
		End Sub
		#End Region
		Private WithEvents simpleAction1 As DevExpress.ExpressApp.Actions.SimpleAction
		Private WithEvents simpleAction2 As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
