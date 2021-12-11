﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    partial void InsertTable_2(Table_2 instance);
    partial void UpdateTable_2(Table_2 instance);
    partial void DeleteTable_2(Table_2 instance);
    partial void InsertTable_3(Table_3 instance);
    partial void UpdateTable_3(Table_3 instance);
    partial void DeleteTable_3(Table_3 instance);
    partial void InsertTable_1(Table_1 instance);
    partial void UpdateTable_1(Table_1 instance);
    partial void DeleteTable_1(Table_1 instance);
    partial void InsertTable_5(Table_5 instance);
    partial void UpdateTable_5(Table_5 instance);
    partial void DeleteTable_5(Table_5 instance);
    partial void InsertTable_4(Table_4 instance);
    partial void UpdateTable_4(Table_4 instance);
    partial void DeleteTable_4(Table_4 instance);
    partial void InsertTable_6(Table_6 instance);
    partial void UpdateTable_6(Table_6 instance);
    partial void DeleteTable_6(Table_6 instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplication1.Properties.Settings.Default.mh2018, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Table> Table
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
		
		public System.Data.Linq.Table<Table_2> Table_2
		{
			get
			{
				return this.GetTable<Table_2>();
			}
		}
		
		public System.Data.Linq.Table<Table_3> Table_3
		{
			get
			{
				return this.GetTable<Table_3>();
			}
		}
		
		public System.Data.Linq.Table<Table_1> Table_1
		{
			get
			{
				return this.GetTable<Table_1>();
			}
		}
		
		public System.Data.Linq.Table<Table_5> Table_5
		{
			get
			{
				return this.GetTable<Table_5>();
			}
		}
		
		public System.Data.Linq.Table<Table_4> Table_4
		{
			get
			{
				return this.GetTable<Table_4>();
			}
		}
		
		public System.Data.Linq.Table<Table_6> Table_6
		{
			get
			{
				return this.GetTable<Table_6>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _pwd;
		
		private string _mailbox;
		
		private string _type;
		
		private System.Nullable<System.DateTime> _time;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    partial void OnmailboxChanging(string value);
    partial void OnmailboxChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OntimeChanging(System.Nullable<System.DateTime> value);
    partial void OntimeChanged();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mailbox", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mailbox
		{
			get
			{
				return this._mailbox;
			}
			set
			{
				if ((this._mailbox != value))
				{
					this.OnmailboxChanging(value);
					this.SendPropertyChanging();
					this._mailbox = value;
					this.SendPropertyChanged("mailbox");
					this.OnmailboxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime2")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_2")]
	public partial class Table_2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private System.DateTime _time;
		
		private string _major;
		
		private string _class;
		
		private string _year;
		
		private string _Teacher;
		
		private string _Classroom;
		
		private string _Remarks;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    partial void OnmajorChanging(string value);
    partial void OnmajorChanged();
    partial void OnclassChanging(string value);
    partial void OnclassChanged();
    partial void OnyearChanging(string value);
    partial void OnyearChanged();
    partial void OnTeacherChanging(string value);
    partial void OnTeacherChanged();
    partial void OnClassroomChanging(string value);
    partial void OnClassroomChanged();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    #endregion
		
		public Table_2()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime2 NOT NULL")]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_major", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string major
		{
			get
			{
				return this._major;
			}
			set
			{
				if ((this._major != value))
				{
					this.OnmajorChanging(value);
					this.SendPropertyChanging();
					this._major = value;
					this.SendPropertyChanged("major");
					this.OnmajorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="class", Storage="_class", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string @class
		{
			get
			{
				return this._class;
			}
			set
			{
				if ((this._class != value))
				{
					this.OnclassChanging(value);
					this.SendPropertyChanging();
					this._class = value;
					this.SendPropertyChanged("@class");
					this.OnclassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this.OnyearChanging(value);
					this.SendPropertyChanging();
					this._year = value;
					this.SendPropertyChanged("year");
					this.OnyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Teacher", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Teacher
		{
			get
			{
				return this._Teacher;
			}
			set
			{
				if ((this._Teacher != value))
				{
					this.OnTeacherChanging(value);
					this.SendPropertyChanging();
					this._Teacher = value;
					this.SendPropertyChanged("Teacher");
					this.OnTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classroom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Classroom
		{
			get
			{
				return this._Classroom;
			}
			set
			{
				if ((this._Classroom != value))
				{
					this.OnClassroomChanging(value);
					this.SendPropertyChanging();
					this._Classroom = value;
					this.SendPropertyChanged("Classroom");
					this.OnClassroomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_3")]
	public partial class Table_3 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _pid;
		
		private int _qty;
		
		private string _type;
		
		private System.DateTime _time;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnpidChanging(string value);
    partial void OnpidChanged();
    partial void OnqtyChanging(int value);
    partial void OnqtyChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    #endregion
		
		public Table_3()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qty", DbType="Int NOT NULL")]
		public int qty
		{
			get
			{
				return this._qty;
			}
			set
			{
				if ((this._qty != value))
				{
					this.OnqtyChanging(value);
					this.SendPropertyChanging();
					this._qty = value;
					this.SendPropertyChanged("qty");
					this.OnqtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime2 NOT NULL", IsPrimaryKey=true)]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_1")]
	public partial class Table_1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Cid;
		
		private string _Cname;
		
		private string _Csaleprice;
		
		private string _Cprice;
		
		private string _Ctype;
		
		private string _Cqty;
		
		private string _Cpicture;
		
		private System.Data.Linq.Binary _Ccomment;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCidChanging(string value);
    partial void OnCidChanged();
    partial void OnCnameChanging(string value);
    partial void OnCnameChanged();
    partial void OnCsalepriceChanging(string value);
    partial void OnCsalepriceChanged();
    partial void OnCpriceChanging(string value);
    partial void OnCpriceChanged();
    partial void OnCtypeChanging(string value);
    partial void OnCtypeChanged();
    partial void OnCqtyChanging(string value);
    partial void OnCqtyChanged();
    partial void OnCpictureChanging(string value);
    partial void OnCpictureChanged();
    partial void OnCcommentChanging(System.Data.Linq.Binary value);
    partial void OnCcommentChanged();
    #endregion
		
		public Table_1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cid", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Cid
		{
			get
			{
				return this._Cid;
			}
			set
			{
				if ((this._Cid != value))
				{
					this.OnCidChanging(value);
					this.SendPropertyChanging();
					this._Cid = value;
					this.SendPropertyChanged("Cid");
					this.OnCidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cname
		{
			get
			{
				return this._Cname;
			}
			set
			{
				if ((this._Cname != value))
				{
					this.OnCnameChanging(value);
					this.SendPropertyChanging();
					this._Cname = value;
					this.SendPropertyChanged("Cname");
					this.OnCnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Csaleprice", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Csaleprice
		{
			get
			{
				return this._Csaleprice;
			}
			set
			{
				if ((this._Csaleprice != value))
				{
					this.OnCsalepriceChanging(value);
					this.SendPropertyChanging();
					this._Csaleprice = value;
					this.SendPropertyChanged("Csaleprice");
					this.OnCsalepriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cprice", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cprice
		{
			get
			{
				return this._Cprice;
			}
			set
			{
				if ((this._Cprice != value))
				{
					this.OnCpriceChanging(value);
					this.SendPropertyChanging();
					this._Cprice = value;
					this.SendPropertyChanged("Cprice");
					this.OnCpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ctype", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Ctype
		{
			get
			{
				return this._Ctype;
			}
			set
			{
				if ((this._Ctype != value))
				{
					this.OnCtypeChanging(value);
					this.SendPropertyChanging();
					this._Ctype = value;
					this.SendPropertyChanged("Ctype");
					this.OnCtypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cqty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cqty
		{
			get
			{
				return this._Cqty;
			}
			set
			{
				if ((this._Cqty != value))
				{
					this.OnCqtyChanging(value);
					this.SendPropertyChanging();
					this._Cqty = value;
					this.SendPropertyChanged("Cqty");
					this.OnCqtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cpicture", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cpicture
		{
			get
			{
				return this._Cpicture;
			}
			set
			{
				if ((this._Cpicture != value))
				{
					this.OnCpictureChanging(value);
					this.SendPropertyChanging();
					this._Cpicture = value;
					this.SendPropertyChanged("Cpicture");
					this.OnCpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ccomment", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Ccomment
		{
			get
			{
				return this._Ccomment;
			}
			set
			{
				if ((this._Ccomment != value))
				{
					this.OnCcommentChanging(value);
					this.SendPropertyChanging();
					this._Ccomment = value;
					this.SendPropertyChanged("Ccomment");
					this.OnCcommentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_5")]
	public partial class Table_5 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _name1;
		
		private string _time;
		
		private string _username;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onname1Changing(string value);
    partial void Onname1Changed();
    partial void OntimeChanging(string value);
    partial void OntimeChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    #endregion
		
		public Table_5()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name1
		{
			get
			{
				return this._name1;
			}
			set
			{
				if ((this._name1 != value))
				{
					this.Onname1Changing(value);
					this.SendPropertyChanging();
					this._name1 = value;
					this.SendPropertyChanged("name1");
					this.Onname1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_4")]
	public partial class Table_4 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _username;
		
		private string _Education;
		
		private int _age;
		
		private string _sex;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnEducationChanging(string value);
    partial void OnEducationChanged();
    partial void OnageChanging(int value);
    partial void OnageChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    #endregion
		
		public Table_4()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Education", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Education
		{
			get
			{
				return this._Education;
			}
			set
			{
				if ((this._Education != value))
				{
					this.OnEducationChanging(value);
					this.SendPropertyChanging();
					this._Education = value;
					this.SendPropertyChanged("Education");
					this.OnEducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int NOT NULL")]
		public int age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_6")]
	public partial class Table_6 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kcheng;
		
		private string _didian;
		
		private string _time;
		
		private string _Teacher;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkchengChanging(string value);
    partial void OnkchengChanged();
    partial void OndidianChanging(string value);
    partial void OndidianChanged();
    partial void OntimeChanging(string value);
    partial void OntimeChanged();
    partial void OnTeacherChanging(string value);
    partial void OnTeacherChanged();
    #endregion
		
		public Table_6()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kcheng", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string kcheng
		{
			get
			{
				return this._kcheng;
			}
			set
			{
				if ((this._kcheng != value))
				{
					this.OnkchengChanging(value);
					this.SendPropertyChanging();
					this._kcheng = value;
					this.SendPropertyChanged("kcheng");
					this.OnkchengChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_didian", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string didian
		{
			get
			{
				return this._didian;
			}
			set
			{
				if ((this._didian != value))
				{
					this.OndidianChanging(value);
					this.SendPropertyChanging();
					this._didian = value;
					this.SendPropertyChanged("didian");
					this.OndidianChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Teacher", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Teacher
		{
			get
			{
				return this._Teacher;
			}
			set
			{
				if ((this._Teacher != value))
				{
					this.OnTeacherChanging(value);
					this.SendPropertyChanging();
					this._Teacher = value;
					this.SendPropertyChanged("Teacher");
					this.OnTeacherChanged();
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
