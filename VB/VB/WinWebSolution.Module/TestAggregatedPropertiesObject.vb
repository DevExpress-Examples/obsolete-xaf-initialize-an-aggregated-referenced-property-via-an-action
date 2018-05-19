Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base

Namespace WinWebSolution.Module
	<DefaultClassOptions> _
	Public Class TestAggregatedPropertiesObject
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property
		<Persistent("ReadOnlyAddress"), Aggregated> _
		Private _ReadOnlyAddress As Address
		<PersistentAlias("_ReadOnlyAddress"), ExpandObjectMembers(ExpandObjectMembers.Never)> _
		Public ReadOnly Property ReadOnlyAddress() As Address
			Get
				Return _ReadOnlyAddress
			End Get
		End Property
		<Action(Caption := "Instantiate ReadOnly Address Via Attribute")> _
		Public Sub InstantiateReadOnlyAddressViaAttribute()
			SetReadOnlyAddress()
		End Sub
		Public Sub SetReadOnlyAddress()
			_ReadOnlyAddress = New Address(Session)
			_ReadOnlyAddress.ZipPostal = "1r"
			_ReadOnlyAddress.Street = "2r"
			_ReadOnlyAddress.StateProvince = "3r"
			_ReadOnlyAddress.City = "4r"
			OnChanged("ReadOnlyAddress")
		End Sub
		Private _WritableAddress As Address
		<Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)> _
		Public Property WritableAddress() As Address
			Get
				Return _WritableAddress
			End Get
			Set(ByVal value As Address)
				SetPropertyValue("WritableAddress", _WritableAddress, value)
			End Set
		End Property
		<Action(Caption := "Instantiate Writable Address Via Attribute")> _
		Public Sub InstantiateWritableAddressViaAttribute()
			SetWritableAddress()
		End Sub
		Public Sub SetWritableAddress()
			_WritableAddress = New Address(Session)
			_WritableAddress.ZipPostal = "1w"
			_WritableAddress.Street = "2w"
			_WritableAddress.StateProvince = "3w"
			_WritableAddress.City = "4w"
			OnChanged("WritableAddress")
		End Sub
	End Class
End Namespace
