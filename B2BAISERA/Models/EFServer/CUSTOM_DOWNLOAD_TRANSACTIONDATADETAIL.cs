//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace B2BAISERA.Models.EFServer
{
    public partial class CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual int TransactionDataID
        {
            get { return _transactionDataID; }
            set
            {
                if (_transactionDataID != value)
                {
                    if (CUSTOM_DOWNLOAD_TRANSACTIONDATA != null && CUSTOM_DOWNLOAD_TRANSACTIONDATA.ID != value)
                    {
                        CUSTOM_DOWNLOAD_TRANSACTIONDATA = null;
                    }
                    _transactionDataID = value;
                }
            }
        }
        private int _transactionDataID;
    
        public virtual string Data
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual CUSTOM_DOWNLOAD_TRANSACTIONDATA CUSTOM_DOWNLOAD_TRANSACTIONDATA
        {
            get { return _cUSTOM_DOWNLOAD_TRANSACTIONDATA; }
            set
            {
                if (!ReferenceEquals(_cUSTOM_DOWNLOAD_TRANSACTIONDATA, value))
                {
                    var previousValue = _cUSTOM_DOWNLOAD_TRANSACTIONDATA;
                    _cUSTOM_DOWNLOAD_TRANSACTIONDATA = value;
                    FixupCUSTOM_DOWNLOAD_TRANSACTIONDATA(previousValue);
                }
            }
        }
        private CUSTOM_DOWNLOAD_TRANSACTIONDATA _cUSTOM_DOWNLOAD_TRANSACTIONDATA;

        #endregion

        #region Association Fixup
    
        private void FixupCUSTOM_DOWNLOAD_TRANSACTIONDATA(CUSTOM_DOWNLOAD_TRANSACTIONDATA previousValue)
        {
            if (previousValue != null && previousValue.CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL.Contains(this))
            {
                previousValue.CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL.Remove(this);
            }
    
            if (CUSTOM_DOWNLOAD_TRANSACTIONDATA != null)
            {
                if (!CUSTOM_DOWNLOAD_TRANSACTIONDATA.CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL.Contains(this))
                {
                    CUSTOM_DOWNLOAD_TRANSACTIONDATA.CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL.Add(this);
                }
                if (TransactionDataID != CUSTOM_DOWNLOAD_TRANSACTIONDATA.ID)
                {
                    TransactionDataID = CUSTOM_DOWNLOAD_TRANSACTIONDATA.ID;
                }
            }
        }

        #endregion

    }
}
