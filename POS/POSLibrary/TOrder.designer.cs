﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSLibrary
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="retailmgmt")]
	public partial class TOrderDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTOrder(TOrder instance);
    partial void UpdateTOrder(TOrder instance);
    partial void DeleteTOrder(TOrder instance);
    #endregion
		
		public TOrderDataContext() : 
				base(global::POSLibrary.Properties.Settings.Default.retailmgmtConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TOrderDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TOrderDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TOrderDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TOrderDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TOrder> TOrders
		{
			get
			{
				return this.GetTable<TOrder>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TOrder")]
	public partial class TOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderNumber;
		
		private decimal _TotalPrice;
		
		private decimal _TotalDiscount;
		
		private decimal _TotalTax;
		
		private decimal _CardPayment;
		
		private decimal _CashPayment;
		
		private System.Nullable<int> _PoitRedeem;
		
		private System.Nullable<int> _PointEarned;
		
		private System.DateTime _OrdeDate;
		
		private System.Nullable<int> _IsReturned;
		
		private System.Nullable<int> _CustomerID;
		
		private System.Nullable<int> _Username;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderNumberChanging(int value);
    partial void OnOrderNumberChanged();
    partial void OnTotalPriceChanging(decimal value);
    partial void OnTotalPriceChanged();
    partial void OnTotalDiscountChanging(decimal value);
    partial void OnTotalDiscountChanged();
    partial void OnTotalTaxChanging(decimal value);
    partial void OnTotalTaxChanged();
    partial void OnCardPaymentChanging(decimal value);
    partial void OnCardPaymentChanged();
    partial void OnCashPaymentChanging(decimal value);
    partial void OnCashPaymentChanged();
    partial void OnPoitRedeemChanging(System.Nullable<int> value);
    partial void OnPoitRedeemChanged();
    partial void OnPointEarnedChanging(System.Nullable<int> value);
    partial void OnPointEarnedChanged();
    partial void OnOrdeDateChanging(System.DateTime value);
    partial void OnOrdeDateChanged();
    partial void OnIsReturnedChanging(System.Nullable<int> value);
    partial void OnIsReturnedChanged();
    partial void OnCustomerIDChanging(System.Nullable<int> value);
    partial void OnCustomerIDChanged();
    partial void OnUsernameChanging(System.Nullable<int> value);
    partial void OnUsernameChanged();
    #endregion
		
		public TOrder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalPrice", DbType="Money NOT NULL")]
		public decimal TotalPrice
		{
			get
			{
				return this._TotalPrice;
			}
			set
			{
				if ((this._TotalPrice != value))
				{
					this.OnTotalPriceChanging(value);
					this.SendPropertyChanging();
					this._TotalPrice = value;
					this.SendPropertyChanged("TotalPrice");
					this.OnTotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalDiscount", DbType="Money NOT NULL")]
		public decimal TotalDiscount
		{
			get
			{
				return this._TotalDiscount;
			}
			set
			{
				if ((this._TotalDiscount != value))
				{
					this.OnTotalDiscountChanging(value);
					this.SendPropertyChanging();
					this._TotalDiscount = value;
					this.SendPropertyChanged("TotalDiscount");
					this.OnTotalDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalTax", DbType="Money NOT NULL")]
		public decimal TotalTax
		{
			get
			{
				return this._TotalTax;
			}
			set
			{
				if ((this._TotalTax != value))
				{
					this.OnTotalTaxChanging(value);
					this.SendPropertyChanging();
					this._TotalTax = value;
					this.SendPropertyChanged("TotalTax");
					this.OnTotalTaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardPayment", DbType="Money NOT NULL")]
		public decimal CardPayment
		{
			get
			{
				return this._CardPayment;
			}
			set
			{
				if ((this._CardPayment != value))
				{
					this.OnCardPaymentChanging(value);
					this.SendPropertyChanging();
					this._CardPayment = value;
					this.SendPropertyChanged("CardPayment");
					this.OnCardPaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CashPayment", DbType="Money NOT NULL")]
		public decimal CashPayment
		{
			get
			{
				return this._CashPayment;
			}
			set
			{
				if ((this._CashPayment != value))
				{
					this.OnCashPaymentChanging(value);
					this.SendPropertyChanging();
					this._CashPayment = value;
					this.SendPropertyChanged("CashPayment");
					this.OnCashPaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PoitRedeem", DbType="Int")]
		public System.Nullable<int> PoitRedeem
		{
			get
			{
				return this._PoitRedeem;
			}
			set
			{
				if ((this._PoitRedeem != value))
				{
					this.OnPoitRedeemChanging(value);
					this.SendPropertyChanging();
					this._PoitRedeem = value;
					this.SendPropertyChanged("PoitRedeem");
					this.OnPoitRedeemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PointEarned", DbType="Int")]
		public System.Nullable<int> PointEarned
		{
			get
			{
				return this._PointEarned;
			}
			set
			{
				if ((this._PointEarned != value))
				{
					this.OnPointEarnedChanging(value);
					this.SendPropertyChanging();
					this._PointEarned = value;
					this.SendPropertyChanged("PointEarned");
					this.OnPointEarnedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrdeDate", DbType="DateTime2 NOT NULL")]
		public System.DateTime OrdeDate
		{
			get
			{
				return this._OrdeDate;
			}
			set
			{
				if ((this._OrdeDate != value))
				{
					this.OnOrdeDateChanging(value);
					this.SendPropertyChanging();
					this._OrdeDate = value;
					this.SendPropertyChanged("OrdeDate");
					this.OnOrdeDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsReturned", DbType="Int")]
		public System.Nullable<int> IsReturned
		{
			get
			{
				return this._IsReturned;
			}
			set
			{
				if ((this._IsReturned != value))
				{
					this.OnIsReturnedChanging(value);
					this.SendPropertyChanging();
					this._IsReturned = value;
					this.SendPropertyChanged("IsReturned");
					this.OnIsReturnedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int")]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="Int")]
		public System.Nullable<int> Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591