﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTableDemo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertTimeTable(TimeTable instance);
    partial void UpdateTimeTable(TimeTable instance);
    partial void DeleteTimeTable(TimeTable instance);
    partial void InsertTimeTableType(TimeTableType instance);
    partial void UpdateTimeTableType(TimeTableType instance);
    partial void DeleteTimeTableType(TimeTableType instance);
    #endregion
		
		public DBDataContext() : 
				base(global::TimeTableDemo.Properties.Settings.Default.DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TimeTable> TimeTable
		{
			get
			{
				return this.GetTable<TimeTable>();
			}
		}
		
		public System.Data.Linq.Table<TimeTableType> TimeTableType
		{
			get
			{
				return this.GetTable<TimeTableType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TimeTable")]
	public partial class TimeTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Address;
		
		private System.Nullable<int> _TypeId;
		
		private System.Nullable<System.DateTime> _BeginTime;
		
		private System.Nullable<System.DateTime> _EndTime;
		
		private string _MainContent;
		
		private System.Nullable<bool> _IsFinished;
		
		private EntityRef<TimeTableType> _TimeTableType;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnTypeIdChanging(System.Nullable<int> value);
    partial void OnTypeIdChanged();
    partial void OnBeginTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnBeginTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEndTimeChanged();
    partial void OnMainContentChanging(string value);
    partial void OnMainContentChanged();
    partial void OnIsFinishedChanging(System.Nullable<bool> value);
    partial void OnIsFinishedChanged();
    #endregion
		
		public TimeTable()
		{
			this._TimeTableType = default(EntityRef<TimeTableType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeId", DbType="Int")]
		public System.Nullable<int> TypeId
		{
			get
			{
				return this._TypeId;
			}
			set
			{
				if ((this._TypeId != value))
				{
					if (this._TimeTableType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIdChanging(value);
					this.SendPropertyChanging();
					this._TypeId = value;
					this.SendPropertyChanged("TypeId");
					this.OnTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> BeginTime
		{
			get
			{
				return this._BeginTime;
			}
			set
			{
				if ((this._BeginTime != value))
				{
					this.OnBeginTimeChanging(value);
					this.SendPropertyChanging();
					this._BeginTime = value;
					this.SendPropertyChanged("BeginTime");
					this.OnBeginTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainContent", DbType="NVarChar(255)")]
		public string MainContent
		{
			get
			{
				return this._MainContent;
			}
			set
			{
				if ((this._MainContent != value))
				{
					this.OnMainContentChanging(value);
					this.SendPropertyChanging();
					this._MainContent = value;
					this.SendPropertyChanged("MainContent");
					this.OnMainContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsFinished", DbType="Bit")]
		public System.Nullable<bool> IsFinished
		{
			get
			{
				return this._IsFinished;
			}
			set
			{
				if ((this._IsFinished != value))
				{
					this.OnIsFinishedChanging(value);
					this.SendPropertyChanging();
					this._IsFinished = value;
					this.SendPropertyChanged("IsFinished");
					this.OnIsFinishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TimeTableType_TimeTable", Storage="_TimeTableType", ThisKey="TypeId", OtherKey="Id", IsForeignKey=true)]
		public TimeTableType TimeTableType
		{
			get
			{
				return this._TimeTableType.Entity;
			}
			set
			{
				TimeTableType previousValue = this._TimeTableType.Entity;
				if (((previousValue != value) 
							|| (this._TimeTableType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TimeTableType.Entity = null;
						previousValue.TimeTable.Remove(this);
					}
					this._TimeTableType.Entity = value;
					if ((value != null))
					{
						value.TimeTable.Add(this);
						this._TypeId = value.Id;
					}
					else
					{
						this._TypeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TimeTableType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TimeTableType")]
	public partial class TimeTableType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<TimeTable> _TimeTable;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TimeTableType()
		{
			this._TimeTable = new EntitySet<TimeTable>(new Action<TimeTable>(this.attach_TimeTable), new Action<TimeTable>(this.detach_TimeTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TimeTableType_TimeTable", Storage="_TimeTable", ThisKey="Id", OtherKey="TypeId")]
		public EntitySet<TimeTable> TimeTable
		{
			get
			{
				return this._TimeTable;
			}
			set
			{
				this._TimeTable.Assign(value);
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
		
		private void attach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.TimeTableType = this;
		}
		
		private void detach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.TimeTableType = null;
		}
	}
}
#pragma warning restore 1591
