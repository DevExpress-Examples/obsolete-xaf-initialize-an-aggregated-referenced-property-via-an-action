using System;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    public class TestAggregatedPropertiesObject : BaseObject {
        public TestAggregatedPropertiesObject(Session session) : base(session) { }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        [Persistent("ReadOnlyAddress")]
        [Aggregated]
        private Address _ReadOnlyAddress;
        [PersistentAlias("_ReadOnlyAddress")]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        public Address ReadOnlyAddress {
            get { return _ReadOnlyAddress; }
        }
        [Action()]
        public void InstantiateReadOnlyAddressViaAttribute() {
            SetReadOnlyAddress();
        }
        public void SetReadOnlyAddress() {
            _ReadOnlyAddress = new Address(Session);
            _ReadOnlyAddress.ZipPostal = "1r";
            _ReadOnlyAddress.Street = "2r";
            _ReadOnlyAddress.StateProvince = "3r";
            _ReadOnlyAddress.City = "4r";
            OnChanged("ReadOnlyAddress");
        }
        private Address _WritableAddress;
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        public Address WritableAddress {
            get { return _WritableAddress; }
            set { SetPropertyValue("WritableAddress", ref _WritableAddress, value); }
        }
        [Action()]
        public void InstantiateWritableAddressViaAttribute() {
            SetWritableAddress();
        }
        public void SetWritableAddress() {
            _WritableAddress = new Address(Session);
            _WritableAddress.ZipPostal = "1w";
            _WritableAddress.Street = "2w";
            _WritableAddress.StateProvince = "3w";
            _WritableAddress.City = "4w";
            OnChanged("WritableAddress");
        }
    }
}
