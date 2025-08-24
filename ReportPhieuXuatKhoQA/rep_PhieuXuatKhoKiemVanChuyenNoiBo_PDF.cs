using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ReportPhieuXuatKhoQA;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF : DataSet
{
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table1DataTable : TypedTableBase<Table1Row>
	{
		private DataColumn columnTax;

		private DataColumn columnTenCongTy;

		private DataColumn columnDiaChi;

		private DataColumn columnTongKhoan;

		private DataColumn columnSoPhieuXuat;

		private DataColumn columnNgayXuat;

		private DataColumn columnDonViVanChuyen;

		private DataColumn columnPhuongTienVanChuyen;

		private DataColumn columnKhoXuatName;

		private DataColumn columnNgayDuKienGiaoHang;

		private DataColumn columnCustomerName;

		private DataColumn columnDiaChiKhachHang;

		private DataColumn columnDiaDiemGiaoHang;

		private DataColumn columnDienThoaiLienHe;

		private DataColumn columnSoLDD;

		private DataColumn columnLogo;

		private DataColumn columnTongSoThung;

		private DataColumn columnIsXeLanh;

		private DataColumn columnIsThungLanh;

		private DataColumn columnNgayDongGoi;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TaxColumn => columnTax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TenCongTyColumn => columnTenCongTy;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaChiColumn => columnDiaChi;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TongKhoanColumn => columnTongKhoan;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SoPhieuXuatColumn => columnSoPhieuXuat;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayXuatColumn => columnNgayXuat;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DonViVanChuyenColumn => columnDonViVanChuyen;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PhuongTienVanChuyenColumn => columnPhuongTienVanChuyen;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn KhoXuatNameColumn => columnKhoXuatName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayDuKienGiaoHangColumn => columnNgayDuKienGiaoHang;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CustomerNameColumn => columnCustomerName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiKhachHangColumn => columnDiaChiKhachHang;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaDiemGiaoHangColumn => columnDiaDiemGiaoHang;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DienThoaiLienHeColumn => columnDienThoaiLienHe;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SoLDDColumn => columnSoLDD;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LogoColumn => columnLogo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TongSoThungColumn => columnTongSoThung;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsXeLanhColumn => columnIsXeLanh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IsThungLanhColumn => columnIsThungLanh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NgayDongGoiColumn => columnNgayDongGoi;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row this[int index] => (Table1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1DataTable()
		{
			base.TableName = "Table1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table1DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Table1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddTable1Row(Table1Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row AddTable1Row(string Tax, string TenCongTy, string DiaChi, string TongKhoan, string SoPhieuXuat, string NgayXuat, string DonViVanChuyen, string PhuongTienVanChuyen, string KhoXuatName, string NgayDuKienGiaoHang, string CustomerName, string DiaChiKhachHang, string DiaDiemGiaoHang, string DienThoaiLienHe, string SoLDD, string Logo, string TongSoThung, bool IsXeLanh, bool IsThungLanh, string NgayDongGoi)
		{
			Table1Row table1Row = (Table1Row)NewRow();
			object[] itemArray = new object[20]
			{
				Tax, TenCongTy, DiaChi, TongKhoan, SoPhieuXuat, NgayXuat, DonViVanChuyen, PhuongTienVanChuyen, KhoXuatName, NgayDuKienGiaoHang, CustomerName,
				DiaChiKhachHang, DiaDiemGiaoHang, DienThoaiLienHe, SoLDD, Logo, TongSoThung, IsXeLanh, IsThungLanh, NgayDongGoi
			};
			table1Row.ItemArray = itemArray;
			base.Rows.Add(table1Row);
			return table1Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Table1DataTable table1DataTable = (Table1DataTable)base.Clone();
			table1DataTable.InitVars();
			return table1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnTax = base.Columns["Tax"];
			columnTenCongTy = base.Columns["TenCongTy"];
			columnDiaChi = base.Columns["DiaChi"];
			columnTongKhoan = base.Columns["TongKhoan"];
			columnSoPhieuXuat = base.Columns["SoPhieuXuat"];
			columnNgayXuat = base.Columns["NgayXuat"];
			columnDonViVanChuyen = base.Columns["DonViVanChuyen"];
			columnPhuongTienVanChuyen = base.Columns["PhuongTienVanChuyen"];
			columnKhoXuatName = base.Columns["KhoXuatName"];
			columnNgayDuKienGiaoHang = base.Columns["NgayDuKienGiaoHang"];
			columnCustomerName = base.Columns["CustomerName"];
			columnDiaChiKhachHang = base.Columns["DiaChiKhachHang"];
			columnDiaDiemGiaoHang = base.Columns["DiaDiemGiaoHang"];
			columnDienThoaiLienHe = base.Columns["DienThoaiLienHe"];
			columnSoLDD = base.Columns["SoLDD"];
			columnLogo = base.Columns["Logo"];
			columnTongSoThung = base.Columns["TongSoThung"];
			columnIsXeLanh = base.Columns["IsXeLanh"];
			columnIsThungLanh = base.Columns["IsThungLanh"];
			columnNgayDongGoi = base.Columns["NgayDongGoi"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTax = new DataColumn("Tax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTax);
			columnTenCongTy = new DataColumn("TenCongTy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenCongTy);
			columnDiaChi = new DataColumn("DiaChi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChi);
			columnTongKhoan = new DataColumn("TongKhoan", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTongKhoan);
			columnSoPhieuXuat = new DataColumn("SoPhieuXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoPhieuXuat);
			columnNgayXuat = new DataColumn("NgayXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayXuat);
			columnDonViVanChuyen = new DataColumn("DonViVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDonViVanChuyen);
			columnPhuongTienVanChuyen = new DataColumn("PhuongTienVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPhuongTienVanChuyen);
			columnKhoXuatName = new DataColumn("KhoXuatName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnKhoXuatName);
			columnNgayDuKienGiaoHang = new DataColumn("NgayDuKienGiaoHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayDuKienGiaoHang);
			columnCustomerName = new DataColumn("CustomerName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCustomerName);
			columnDiaChiKhachHang = new DataColumn("DiaChiKhachHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiKhachHang);
			columnDiaDiemGiaoHang = new DataColumn("DiaDiemGiaoHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaDiemGiaoHang);
			columnDienThoaiLienHe = new DataColumn("DienThoaiLienHe", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDienThoaiLienHe);
			columnSoLDD = new DataColumn("SoLDD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoLDD);
			columnLogo = new DataColumn("Logo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLogo);
			columnTongSoThung = new DataColumn("TongSoThung", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTongSoThung);
			columnIsXeLanh = new DataColumn("IsXeLanh", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsXeLanh);
			columnIsThungLanh = new DataColumn("IsThungLanh", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsThungLanh);
			columnNgayDongGoi = new DataColumn("NgayDongGoi", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayDongGoi);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row NewTable1Row()
		{
			return (Table1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table1Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Table1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table1RowChanged != null)
			{
				this.Table1RowChanged(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table1RowChanging != null)
			{
				this.Table1RowChanging(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table1RowDeleted != null)
			{
				this.Table1RowDeleted(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table1RowDeleting != null)
			{
				this.Table1RowDeleting(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable1Row(Table1Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = new rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table1RowChangeEventHandler(object sender, Table1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table4RowChangeEventHandler(object sender, Table4RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table3RowChangeEventHandler(object sender, Table3RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table4DataTable : TypedTableBase<Table4Row>
	{
		private DataColumn columnSTT;

		private DataColumn columnHopitalCode;

		private DataColumn columnBatch;

		private DataColumn columnExpDate;

		private DataColumn columnHopitalName;

		private DataColumn columnUnit;

		private DataColumn columnHangSanXuatID;

		private DataColumn columnHangSanXuatName;

		private DataColumn columnQuyCach;

		private DataColumn columnViTriXuat;

		private DataColumn columnSoLuong;

		private DataColumn columnSTT_Thung;

		private DataColumn columnExpDateStr;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STTColumn => columnSTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HopitalCodeColumn => columnHopitalCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BatchColumn => columnBatch;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ExpDateColumn => columnExpDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HopitalNameColumn => columnHopitalName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UnitColumn => columnUnit;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HangSanXuatIDColumn => columnHangSanXuatID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HangSanXuatNameColumn => columnHangSanXuatName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn QuyCachColumn => columnQuyCach;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ViTriXuatColumn => columnViTriXuat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SoLuongColumn => columnSoLuong;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn STT_ThungColumn => columnSTT_Thung;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ExpDateStrColumn => columnExpDateStr;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table4Row this[int index] => (Table4Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table4RowChangeEventHandler Table4RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table4RowChangeEventHandler Table4RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table4RowChangeEventHandler Table4RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table4RowChangeEventHandler Table4RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table4DataTable()
		{
			base.TableName = "Table4";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table4DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Table4DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable4Row(Table4Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table4Row AddTable4Row(int STT, string HopitalCode, string Batch, DateTime ExpDate, string HopitalName, string Unit, int HangSanXuatID, string HangSanXuatName, string QuyCach, string ViTriXuat, double SoLuong, string STT_Thung, string ExpDateStr)
		{
			Table4Row table4Row = (Table4Row)NewRow();
			object[] itemArray = new object[13]
			{
				STT, HopitalCode, Batch, ExpDate, HopitalName, Unit, HangSanXuatID, HangSanXuatName, QuyCach, ViTriXuat,
				SoLuong, STT_Thung, ExpDateStr
			};
			table4Row.ItemArray = itemArray;
			base.Rows.Add(table4Row);
			return table4Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Table4DataTable table4DataTable = (Table4DataTable)base.Clone();
			table4DataTable.InitVars();
			return table4DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Table4DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnSTT = base.Columns["STT"];
			columnHopitalCode = base.Columns["HopitalCode"];
			columnBatch = base.Columns["Batch"];
			columnExpDate = base.Columns["ExpDate"];
			columnHopitalName = base.Columns["HopitalName"];
			columnUnit = base.Columns["Unit"];
			columnHangSanXuatID = base.Columns["HangSanXuatID"];
			columnHangSanXuatName = base.Columns["HangSanXuatName"];
			columnQuyCach = base.Columns["QuyCach"];
			columnViTriXuat = base.Columns["ViTriXuat"];
			columnSoLuong = base.Columns["SoLuong"];
			columnSTT_Thung = base.Columns["STT_Thung"];
			columnExpDateStr = base.Columns["ExpDateStr"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnSTT = new DataColumn("STT", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSTT);
			columnHopitalCode = new DataColumn("HopitalCode", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHopitalCode);
			columnBatch = new DataColumn("Batch", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBatch);
			columnExpDate = new DataColumn("ExpDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnExpDate);
			columnHopitalName = new DataColumn("HopitalName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHopitalName);
			columnUnit = new DataColumn("Unit", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUnit);
			columnHangSanXuatID = new DataColumn("HangSanXuatID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnHangSanXuatID);
			columnHangSanXuatName = new DataColumn("HangSanXuatName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHangSanXuatName);
			columnQuyCach = new DataColumn("QuyCach", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnQuyCach);
			columnViTriXuat = new DataColumn("ViTriXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnViTriXuat);
			columnSoLuong = new DataColumn("SoLuong", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSoLuong);
			columnSTT_Thung = new DataColumn("STT_Thung", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTT_Thung);
			columnExpDateStr = new DataColumn("ExpDateStr", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnExpDateStr);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table4Row NewTable4Row()
		{
			return (Table4Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table4Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table4Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table4RowChanged != null)
			{
				this.Table4RowChanged(this, new Table4RowChangeEvent((Table4Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table4RowChanging != null)
			{
				this.Table4RowChanging(this, new Table4RowChangeEvent((Table4Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table4RowDeleted != null)
			{
				this.Table4RowDeleted(this, new Table4RowChangeEvent((Table4Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table4RowDeleting != null)
			{
				this.Table4RowDeleting(this, new Table4RowChangeEvent((Table4Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveTable4Row(Table4Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = new rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table4DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table3DataTable : TypedTableBase<Table3Row>
	{
		private DataColumn columnLogo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LogoColumn => columnLogo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table3Row this[int index] => (Table3Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table3RowChangeEventHandler Table3RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table3RowChangeEventHandler Table3RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table3RowChangeEventHandler Table3RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table3RowChangeEventHandler Table3RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table3DataTable()
		{
			base.TableName = "Table3";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table3DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table3DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable3Row(Table3Row row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table3Row AddTable3Row(string Logo)
		{
			Table3Row table3Row = (Table3Row)NewRow();
			object[] itemArray = new object[1] { Logo };
			table3Row.ItemArray = itemArray;
			base.Rows.Add(table3Row);
			return table3Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Table3DataTable table3DataTable = (Table3DataTable)base.Clone();
			table3DataTable.InitVars();
			return table3DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Table3DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnLogo = base.Columns["Logo"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnLogo = new DataColumn("Logo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLogo);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table3Row NewTable3Row()
		{
			return (Table3Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table3Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Table3Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table3RowChanged != null)
			{
				this.Table3RowChanged(this, new Table3RowChangeEvent((Table3Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table3RowChanging != null)
			{
				this.Table3RowChanging(this, new Table3RowChangeEvent((Table3Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table3RowDeleted != null)
			{
				this.Table3RowDeleted(this, new Table3RowChangeEvent((Table3Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table3RowDeleting != null)
			{
				this.Table3RowDeleting(this, new Table3RowChangeEvent((Table3Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable3Row(Table3Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = new rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table3DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class Table1Row : DataRow
	{
		private Table1DataTable tableTable1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Tax
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Tax' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TaxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TenCongTy
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TenCongTyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenCongTy' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TenCongTyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DiaChi
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChi' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TongKhoan
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TongKhoanColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TongKhoan' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TongKhoanColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SoPhieuXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoPhieuXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoPhieuXuat' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoPhieuXuatColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayXuat' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayXuatColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DonViVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DonViVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DonViVanChuyen' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DonViVanChuyenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PhuongTienVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableTable1.PhuongTienVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PhuongTienVanChuyen' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.PhuongTienVanChuyenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string KhoXuatName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.KhoXuatNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KhoXuatName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.KhoXuatNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NgayDuKienGiaoHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayDuKienGiaoHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayDuKienGiaoHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayDuKienGiaoHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CustomerName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.CustomerNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CustomerName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.CustomerNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiKhachHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiKhachHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiKhachHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiKhachHangColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DiaDiemGiaoHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaDiemGiaoHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaDiemGiaoHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaDiemGiaoHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DienThoaiLienHe
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DienThoaiLienHeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DienThoaiLienHe' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DienThoaiLienHeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SoLDD
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoLDDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoLDD' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoLDDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Logo
		{
			get
			{
				try
				{
					return (string)base[tableTable1.LogoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Logo' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.LogoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TongSoThung
		{
			get
			{
				try
				{
					return (string)base[tableTable1.TongSoThungColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TongSoThung' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.TongSoThungColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsXeLanh
		{
			get
			{
				try
				{
					return (bool)base[tableTable1.IsXeLanhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IsXeLanh' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.IsXeLanhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsThungLanh
		{
			get
			{
				try
				{
					return (bool)base[tableTable1.IsThungLanhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IsThungLanh' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.IsThungLanhColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayDongGoi
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayDongGoiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayDongGoi' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayDongGoiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable1 = (Table1DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTaxNull()
		{
			return IsNull(tableTable1.TaxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTaxNull()
		{
			base[tableTable1.TaxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTenCongTyNull()
		{
			return IsNull(tableTable1.TenCongTyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTenCongTyNull()
		{
			base[tableTable1.TenCongTyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiNull()
		{
			return IsNull(tableTable1.DiaChiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaChiNull()
		{
			base[tableTable1.DiaChiColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTongKhoanNull()
		{
			return IsNull(tableTable1.TongKhoanColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTongKhoanNull()
		{
			base[tableTable1.TongKhoanColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoPhieuXuatNull()
		{
			return IsNull(tableTable1.SoPhieuXuatColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSoPhieuXuatNull()
		{
			base[tableTable1.SoPhieuXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayXuatNull()
		{
			return IsNull(tableTable1.NgayXuatColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNgayXuatNull()
		{
			base[tableTable1.NgayXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDonViVanChuyenNull()
		{
			return IsNull(tableTable1.DonViVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPhuongTienVanChuyenNull()
		{
			return IsNull(tableTable1.PhuongTienVanChuyenColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDonViVanChuyenNull()
		{
			base[tableTable1.DonViVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPhuongTienVanChuyenNull()
		{
			base[tableTable1.PhuongTienVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsKhoXuatNameNull()
		{
			return IsNull(tableTable1.KhoXuatNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetKhoXuatNameNull()
		{
			base[tableTable1.KhoXuatNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNgayDuKienGiaoHangNull()
		{
			return IsNull(tableTable1.NgayDuKienGiaoHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNgayDuKienGiaoHangNull()
		{
			base[tableTable1.NgayDuKienGiaoHangColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCustomerNameNull()
		{
			return IsNull(tableTable1.CustomerNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCustomerNameNull()
		{
			base[tableTable1.CustomerNameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiaChiKhachHangNull()
		{
			return IsNull(tableTable1.DiaChiKhachHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaChiKhachHangNull()
		{
			base[tableTable1.DiaChiKhachHangColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiaDiemGiaoHangNull()
		{
			return IsNull(tableTable1.DiaDiemGiaoHangColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiaDiemGiaoHangNull()
		{
			base[tableTable1.DiaDiemGiaoHangColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDienThoaiLienHeNull()
		{
			return IsNull(tableTable1.DienThoaiLienHeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDienThoaiLienHeNull()
		{
			base[tableTable1.DienThoaiLienHeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoLDDNull()
		{
			return IsNull(tableTable1.SoLDDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSoLDDNull()
		{
			base[tableTable1.SoLDDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLogoNull()
		{
			return IsNull(tableTable1.LogoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLogoNull()
		{
			base[tableTable1.LogoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTongSoThungNull()
		{
			return IsNull(tableTable1.TongSoThungColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTongSoThungNull()
		{
			base[tableTable1.TongSoThungColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIsXeLanhNull()
		{
			return IsNull(tableTable1.IsXeLanhColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsXeLanhNull()
		{
			base[tableTable1.IsXeLanhColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIsThungLanhNull()
		{
			return IsNull(tableTable1.IsThungLanhColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetIsThungLanhNull()
		{
			base[tableTable1.IsThungLanhColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNgayDongGoiNull()
		{
			return IsNull(tableTable1.NgayDongGoiColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNgayDongGoiNull()
		{
			base[tableTable1.NgayDongGoiColumn] = Convert.DBNull;
		}
	}

	public class Table4Row : DataRow
	{
		private Table4DataTable tableTable4;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int STT
		{
			get
			{
				try
				{
					return (int)base[tableTable4.STTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'STT' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.STTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HopitalCode
		{
			get
			{
				try
				{
					return (string)base[tableTable4.HopitalCodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HopitalCode' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.HopitalCodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Batch
		{
			get
			{
				try
				{
					return (string)base[tableTable4.BatchColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Batch' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.BatchColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime ExpDate
		{
			get
			{
				try
				{
					return (DateTime)base[tableTable4.ExpDateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ExpDate' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.ExpDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HopitalName
		{
			get
			{
				try
				{
					return (string)base[tableTable4.HopitalNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HopitalName' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.HopitalNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Unit
		{
			get
			{
				try
				{
					return (string)base[tableTable4.UnitColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Unit' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.UnitColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int HangSanXuatID
		{
			get
			{
				try
				{
					return (int)base[tableTable4.HangSanXuatIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HangSanXuatID' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.HangSanXuatIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HangSanXuatName
		{
			get
			{
				try
				{
					return (string)base[tableTable4.HangSanXuatNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HangSanXuatName' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.HangSanXuatNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string QuyCach
		{
			get
			{
				try
				{
					return (string)base[tableTable4.QuyCachColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'QuyCach' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.QuyCachColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ViTriXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable4.ViTriXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ViTriXuat' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.ViTriXuatColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double SoLuong
		{
			get
			{
				try
				{
					return (double)base[tableTable4.SoLuongColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoLuong' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.SoLuongColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string STT_Thung
		{
			get
			{
				try
				{
					return (string)base[tableTable4.STT_ThungColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'STT_Thung' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.STT_ThungColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ExpDateStr
		{
			get
			{
				try
				{
					return (string)base[tableTable4.ExpDateStrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ExpDateStr' in table 'Table4' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable4.ExpDateStrColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table4Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable4 = (Table4DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSTTNull()
		{
			return IsNull(tableTable4.STTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTTNull()
		{
			base[tableTable4.STTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHopitalCodeNull()
		{
			return IsNull(tableTable4.HopitalCodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHopitalCodeNull()
		{
			base[tableTable4.HopitalCodeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBatchNull()
		{
			return IsNull(tableTable4.BatchColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBatchNull()
		{
			base[tableTable4.BatchColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsExpDateNull()
		{
			return IsNull(tableTable4.ExpDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetExpDateNull()
		{
			base[tableTable4.ExpDateColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHopitalNameNull()
		{
			return IsNull(tableTable4.HopitalNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHopitalNameNull()
		{
			base[tableTable4.HopitalNameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUnitNull()
		{
			return IsNull(tableTable4.UnitColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetUnitNull()
		{
			base[tableTable4.UnitColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHangSanXuatIDNull()
		{
			return IsNull(tableTable4.HangSanXuatIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHangSanXuatIDNull()
		{
			base[tableTable4.HangSanXuatIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHangSanXuatNameNull()
		{
			return IsNull(tableTable4.HangSanXuatNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHangSanXuatNameNull()
		{
			base[tableTable4.HangSanXuatNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsQuyCachNull()
		{
			return IsNull(tableTable4.QuyCachColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetQuyCachNull()
		{
			base[tableTable4.QuyCachColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsViTriXuatNull()
		{
			return IsNull(tableTable4.ViTriXuatColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetViTriXuatNull()
		{
			base[tableTable4.ViTriXuatColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoLuongNull()
		{
			return IsNull(tableTable4.SoLuongColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSoLuongNull()
		{
			base[tableTable4.SoLuongColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSTT_ThungNull()
		{
			return IsNull(tableTable4.STT_ThungColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSTT_ThungNull()
		{
			base[tableTable4.STT_ThungColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsExpDateStrNull()
		{
			return IsNull(tableTable4.ExpDateStrColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetExpDateStrNull()
		{
			base[tableTable4.ExpDateStrColumn] = Convert.DBNull;
		}
	}

	public class Table3Row : DataRow
	{
		private Table3DataTable tableTable3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Logo
		{
			get
			{
				try
				{
					return (string)base[tableTable3.LogoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Logo' in table 'Table3' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable3.LogoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table3Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable3 = (Table3DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLogoNull()
		{
			return IsNull(tableTable3.LogoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLogoNull()
		{
			base[tableTable3.LogoColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table1RowChangeEvent : EventArgs
	{
		private Table1Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1RowChangeEvent(Table1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table4RowChangeEvent : EventArgs
	{
		private Table4Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table4Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table4RowChangeEvent(Table4Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table3RowChangeEvent : EventArgs
	{
		private Table3Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table3Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table3RowChangeEvent(Table3Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Table1DataTable tableTable1;

	private Table4DataTable tableTable4;

	private Table3DataTable tableTable3;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Table1DataTable Table1 => tableTable1;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Table4DataTable Table4 => tableTable4;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Table3DataTable Table3 => tableTable3;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table4"] != null)
			{
				base.Tables.Add(new Table4DataTable(dataSet.Tables["Table4"]));
			}
			if (dataSet.Tables["Table3"] != null)
			{
				base.Tables.Add(new Table3DataTable(dataSet.Tables["Table3"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = (rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF)base.Clone();
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.InitVars();
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.SchemaSerializationMode = SchemaSerializationMode;
		return rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table4"] != null)
			{
				base.Tables.Add(new Table4DataTable(dataSet.Tables["Table4"]));
			}
			if (dataSet.Tables["Table3"] != null)
			{
				base.Tables.Add(new Table3DataTable(dataSet.Tables["Table3"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableTable1 = (Table1DataTable)base.Tables["Table1"];
		if (initTable && tableTable1 != null)
		{
			tableTable1.InitVars();
		}
		tableTable4 = (Table4DataTable)base.Tables["Table4"];
		if (initTable && tableTable4 != null)
		{
			tableTable4.InitVars();
		}
		tableTable3 = (Table3DataTable)base.Tables["Table3"];
		if (initTable && tableTable3 != null)
		{
			tableTable3.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF";
		base.Prefix = "";
		base.Locale = new CultureInfo("en-US");
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableTable1 = new Table1DataTable();
		base.Tables.Add(tableTable1);
		tableTable4 = new Table4DataTable();
		base.Tables.Add(tableTable4);
		tableTable3 = new Table3DataTable();
		base.Tables.Add(tableTable3);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeTable1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTable4()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeTable3()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = new rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
