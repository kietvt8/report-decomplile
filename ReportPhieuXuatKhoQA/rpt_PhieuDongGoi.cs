using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace ReportPhieuXuatKhoQA;

public class rpt_PhieuDongGoi : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private PageHeaderBand PageHeader;

	private XRLabel xrLabel13;

	private XRLabel xrLabel11;

	private XRLabel xrLabel8;

	private XRLabel xrLabel7;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel1;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell17;

	private XRTableCell xrTableCell19;

	private XRTableCell xrTableCell20;

	private XRTableCell xrTableCell21;

	private XRTable xrTable6;

	private XRTableRow xrTableRow6;

	private XRTableCell xrTableCell31;

	private XRTableCell xrTableCell32;

	private XRTable xrTable5;

	private XRTableRow xrTableRow5;

	private XRTableCell xrTableCell27;

	private XRTableCell xrTableCell28;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel19;

	private XRLabel xrLabel18;

	private XRLabel xrLabel17;

	private rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF1;

	private XRLabel xrLabel30;

	private XRLabel xrLabel9;

	private XRLabel xrLabel29;

	private XRLabel xrLabel16;

	private XRLabel xrLabel14;

	private XRLabel xrLabel21;

	private XRPictureBox xrPictureBox1;

	private XRTableCell xrTableCell34;

	private XRCheckBox xrCheckBox1;

	private XRLabel xrLabel2;

	private XRLabel xrLabel15;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell2;

	private XRLabel xrLabel34;

	private XRLabel xrLabel33;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLabel xrLabel28;

	private XRLabel xrLabel27;

	private XRLabel xrLabel20;

	private XRLabel xrLabel12;

	private XRLabel xrLabel10;

	private XRLabel xrLabel6;

	private XRCheckBox xrCheckBox5;

	private XRLabel xrLabel26;

	private XRLabel xrLabel3;

	private XRLabel xrLabel22;

	public rpt_PhieuDongGoi()
	{
		InitializeComponent();
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2 = new rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF();
		rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2.ApplyDataSet(ds);
		base.DataSource = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2;
		dset = rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF2;
		MemoryStream memoryStream = new MemoryStream();
		if (type.ToUpper() == "PDF")
		{
			ExportToPdf(memoryStream);
		}
		if (type.ToUpper() == "XLS")
		{
			ExportToXls(memoryStream);
		}
		if (type.ToUpper() == "HTML")
		{
			ExportToHtml(memoryStream);
		}
		return new ReportResult(type, memoryStream.ToArray());
	}

	private void rpt_PhieuSoanHang_BeforePrint(object sender, PrintEventArgs e)
	{
		string text = dset.Tables["Table1"].Rows[0]["Logo"].ToString();
		if (text != "")
		{
			byte[] buffer = Convert.FromBase64String(text);
			Stream stream = new MemoryStream(buffer);
			Image image = Image.FromStream(stream);
			xrPictureBox1.Image = image;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCheckBox5 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
			this.Detail.HeightF = 48.95833F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable3
			// 
			this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable3.Name = "xrTable3";
			this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.xrTable3.SizeF = new System.Drawing.SizeF(783F, 48.95833F);
			this.xrTable3.StylePriority.UseTextAlignment = false;
			this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell1,
            this.xrTableCell17,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell2,
            this.xrTableCell21,
            this.xrTableCell34});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STT_Thung]")});
			this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell14.StylePriority.UseBorders = false;
			this.xrTableCell14.StylePriority.UseFont = false;
			this.xrTableCell14.StylePriority.UsePadding = false;
			this.xrTableCell14.StylePriority.UseTextAlignment = false;
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
			this.xrTableCell14.Summary = xrSummary1;
			this.xrTableCell14.Text = "xrTableCell14";
			this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell14.Weight = 0.13943252666502062D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell15.StylePriority.UseBorders = false;
			this.xrTableCell15.StylePriority.UseFont = false;
			this.xrTableCell15.StylePriority.UsePadding = false;
			this.xrTableCell15.StylePriority.UseTextAlignment = false;
			this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell15.Weight = 0.210326041659997D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HopitalCode]")});
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.Weight = 0.19746340816430225D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HopitalName]")});
			this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell17.StylePriority.UseBorders = false;
			this.xrTableCell17.StylePriority.UseFont = false;
			this.xrTableCell17.StylePriority.UsePadding = false;
			this.xrTableCell17.StylePriority.UseTextAlignment = false;
			this.xrTableCell17.Text = "xrTableCell17";
			this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell17.Weight = 0.38907340700389964D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Batch]")});
			this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell19.StylePriority.UseBorders = false;
			this.xrTableCell19.StylePriority.UseFont = false;
			this.xrTableCell19.StylePriority.UsePadding = false;
			this.xrTableCell19.StylePriority.UseTextAlignment = false;
			this.xrTableCell19.Text = "xrTableCell19";
			this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell19.Weight = 0.21485634764322309D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExpDateStr]")});
			this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell20.StylePriority.UseBorders = false;
			this.xrTableCell20.StylePriority.UseFont = false;
			this.xrTableCell20.StylePriority.UsePadding = false;
			this.xrTableCell20.Text = "xrTableCell20";
			this.xrTableCell20.Weight = 0.21689861534346011D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Unit]")});
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.StylePriority.UseBorders = false;
			this.xrTableCell2.Text = "xrTableCell2";
			this.xrTableCell2.Weight = 0.14476227690211174D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoLuong]")});
			this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell21.StylePriority.UseBorders = false;
			this.xrTableCell21.StylePriority.UseFont = false;
			this.xrTableCell21.StylePriority.UsePadding = false;
			this.xrTableCell21.StylePriority.UseTextAlignment = false;
			this.xrTableCell21.Text = "xrTableCell21";
			this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell21.Weight = 0.24419333130263848D;
			// 
			// xrTableCell34
			// 
			this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell34.Name = "xrTableCell34";
			this.xrTableCell34.StylePriority.UseBorders = false;
			this.xrTableCell34.Weight = 0.17670179522251583D;
			// 
			// xrCheckBox1
			// 
			this.xrCheckBox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Table1.IsXeLanh]")});
			this.xrCheckBox1.Font = new System.Drawing.Font("Times New Roman", 10F);
			this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(315.9548F, 261.3752F);
			this.xrCheckBox1.Name = "xrCheckBox1";
			this.xrCheckBox1.SizeF = new System.Drawing.SizeF(18.70795F, 22.99997F);
			this.xrCheckBox1.StylePriority.UseBorders = false;
			this.xrCheckBox1.StylePriority.UseFont = false;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 23F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 22.91667F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// ReportHeader
			// 
			this.ReportHeader.HeightF = 0F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0.0009190437F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(115.7367F, 73.87502F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
			// 
			// xrLabel21
			// 
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(602.1539F, 8F);
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(180.8461F, 23F);
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "SOP-KH0-042-01 BM-01";
			this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// xrLabel16
			// 
			this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DienThoaiLienHe]")});
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(661.4866F, 235.3751F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(121.5126F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "xrLabel16";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(420.3425F, 70.87503F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(105.2081F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "Số phiếu xuất:";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel5
			// 
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(420.3425F, 96.70835F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(105.208F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "Ngày xuất:";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 261.3751F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(190.269F, 23F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "3. Phương tiện vận chuyển :";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel8
			// 
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 287.3751F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(126.7273F, 23.00002F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "4. Tổng số thùng:";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(567.7364F, 235.3751F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(93.75012F, 23F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.StylePriority.UseTextAlignment = false;
			this.xrLabel11.Text = "Số điện thoại:";
			this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0.0009218852F, 235.3751F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(141.6239F, 23F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "2. Địa chỉ giao hàng:";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel17
			// 
			this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.SoPhieuXuat]")});
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(525.5506F, 70.87503F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(257.4494F, 23F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "xrLabel17";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NgayXuat]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(525.5506F, 96.70835F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(257.4493F, 23F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel18.TextFormatString = "{0:}";
			// 
			// xrLabel19
			// 
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.KhoXuatName]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(115.7376F, 31F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(467.6663F, 23F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "xrLabel19";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 208.3751F);
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(105.2084F, 23F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.Text = "1. Khách hàng:";
			this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel30
			// 
			this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DiaDiemGiaoHang]")});
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(141.6248F, 235.3751F);
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(426.1116F, 23F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.StylePriority.UseTextAlignment = false;
			this.xrLabel30.Text = "[Table1.DiaDiemGiaoHang]";
			this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel9
			// 
			this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.TongSoThung]")});
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(126.7273F, 287.3752F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(126.0833F, 23.00002F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "xrLabel9";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel9.TextFormatString = "{0:#,#} thùng";
			// 
			// xrLabel14
			// 
			this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.CustomerName]")});
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(105.2084F, 208.3751F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(677.7908F, 23F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "xrLabel14";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.TenCongTy]")});
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(115.7376F, 8F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(467.6663F, 23F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "xrLabel1";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel20,
            this.xrLabel12,
            this.xrLabel10,
            this.xrLabel6,
            this.xrCheckBox5,
            this.xrLabel26,
            this.xrLabel3,
            this.xrLabel22,
            this.xrLabel2,
            this.xrLabel15,
            this.xrPictureBox1,
            this.xrLabel14,
            this.xrLabel9,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel13,
            this.xrLabel11,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel16,
            this.xrLabel21,
            this.xrLabel1,
            this.xrCheckBox1});
			this.PageHeader.HeightF = 394.2855F;
			this.PageHeader.Name = "PageHeader";
			// 
			// xrLabel34
			// 
			this.xrLabel34.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(711.4496F, 319.7916F);
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(71.55042F, 74.49377F);
			this.xrLabel34.StylePriority.UseBorders = false;
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.StylePriority.UseTextAlignment = false;
			this.xrLabel34.Text = "Ghi chú";
			this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel33
			// 
			this.xrLabel33.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(612.5705F, 344.2854F);
			this.xrLabel33.Name = "xrLabel33";
			this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel33.SizeF = new System.Drawing.SizeF(98.87909F, 50F);
			this.xrLabel33.StylePriority.UseBorders = false;
			this.xrLabel33.StylePriority.UseFont = false;
			this.xrLabel33.StylePriority.UseTextAlignment = false;
			this.xrLabel33.Text = "Số lượng";
			this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel32
			// 
			this.xrLabel32.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(553.9531F, 344.2854F);
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(58.61743F, 50F);
			this.xrLabel32.StylePriority.UseBorders = false;
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.StylePriority.UseTextAlignment = false;
			this.xrLabel32.Text = "Đơn vị tính";
			this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel31
			// 
			this.xrLabel31.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(466.1262F, 344.2855F);
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(87.82693F, 50F);
			this.xrLabel31.StylePriority.UseBorders = false;
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.StylePriority.UseTextAlignment = false;
			this.xrLabel31.Text = "Hạn dùng";
			this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel28
			// 
			this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(379.1262F, 344.2855F);
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(87F, 50F);
			this.xrLabel28.StylePriority.UseBorders = false;
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.StylePriority.UseTextAlignment = false;
			this.xrLabel28.Text = "Lô sản xuất";
			this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel27
			// 
			this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(221.582F, 344.2854F);
			this.xrLabel27.Name = "xrLabel27";
			this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel27.SizeF = new System.Drawing.SizeF(157.5442F, 50F);
			this.xrLabel27.StylePriority.UseBorders = false;
			this.xrLabel27.StylePriority.UseFont = false;
			this.xrLabel27.StylePriority.UseTextAlignment = false;
			this.xrLabel27.Text = "Tên hàng, Hàm lượng, Quy cách";
			this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel20
			// 
			this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(141.6248F, 344.2854F);
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(79.9572F, 50F);
			this.xrLabel20.StylePriority.UseBorders = false;
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			this.xrLabel20.Text = "Mã hàng";
			this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel12
			// 
			this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(141.6248F, 319.7916F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(569.8248F, 24.49377F);
			this.xrLabel12.StylePriority.UseBorders = false;
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "NỘI DUNG HÀNG HÓA";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel10
			// 
			this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(56.45924F, 319.7917F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(85.16555F, 74.49377F);
			this.xrLabel10.StylePriority.UseBorders = false;
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "Mã datalogger";
			this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel6
			// 
			this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0.0009218852F, 319.7917F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(56.45832F, 74.49377F);
			this.xrLabel6.StylePriority.UseBorders = false;
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "Thùng số";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrCheckBox5
			// 
			this.xrCheckBox5.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrCheckBox5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[Table1.IsThungLanh]")});
			this.xrCheckBox5.Font = new System.Drawing.Font("Times New Roman", 10F);
			this.xrCheckBox5.LocationFloat = new DevExpress.Utils.PointFloat(642.5395F, 262.3752F);
			this.xrCheckBox5.Name = "xrCheckBox5";
			this.xrCheckBox5.SizeF = new System.Drawing.SizeF(18.70795F, 22.99997F);
			this.xrCheckBox5.StylePriority.UseBorders = false;
			this.xrCheckBox5.StylePriority.UseFont = false;
			// 
			// xrLabel26
			// 
			this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(379.1262F, 261.3752F);
			this.xrLabel26.Name = "xrLabel26";
			this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel26.SizeF = new System.Drawing.SizeF(263.4132F, 23F);
			this.xrLabel26.StylePriority.UseFont = false;
			this.xrLabel26.StylePriority.UseTextAlignment = false;
			this.xrLabel26.Text = "Thùng lạnh 2-8ºC (máy bay / xe thường)";
			this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(214.2274F, 261.3752F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(101.7274F, 23F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "Xe lạnh 2-8ºC";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel22
			// 
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 148.7083F);
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(782.9991F, 46.95833F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.StylePriority.UseTextAlignment = false;
			this.xrLabel22.Text = "PHIẾU ĐÓNG GÓI";
			this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel2
			// 
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NgayDongGoi]")});
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(525.5506F, 122.7083F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(257.4494F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "xrLabel2";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel2.TextFormatString = "{0:}";
			// 
			// xrLabel15
			// 
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(420.3425F, 122.7083F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(105.208F, 23F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			this.xrLabel15.Text = "Ngày đóng gói:";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrTable6
			// 
			this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0.002129873F, 39.54163F);
			this.xrTable6.Name = "xrTable6";
			this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
			this.xrTable6.SizeF = new System.Drawing.SizeF(782.997F, 24.99999F);
			this.xrTable6.StylePriority.UseTextAlignment = false;
			this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrTableRow6
			// 
			this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32});
			this.xrTableRow6.Name = "xrTableRow6";
			this.xrTableRow6.StylePriority.UseTextAlignment = false;
			this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableRow6.Weight = 1D;
			// 
			// xrTableCell31
			// 
			this.xrTableCell31.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTableCell31.Name = "xrTableCell31";
			this.xrTableCell31.StylePriority.UseFont = false;
			this.xrTableCell31.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell31.Weight = 0.9975578142400221D;
			// 
			// xrTableCell32
			// 
			this.xrTableCell32.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic);
			this.xrTableCell32.Name = "xrTableCell32";
			this.xrTableCell32.StylePriority.UseFont = false;
			this.xrTableCell32.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell32.Weight = 1.1541909754181305D;
			// 
			// xrTable5
			// 
			this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0.0009218852F, 9.999974F);
			this.xrTable5.Name = "xrTable5";
			this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
			this.xrTable5.SizeF = new System.Drawing.SizeF(782.9982F, 28.54165F);
			this.xrTable5.StylePriority.UseTextAlignment = false;
			this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow5
			// 
			this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell27,
            this.xrTableCell28});
			this.xrTableRow5.Name = "xrTableRow5";
			this.xrTableRow5.Weight = 1D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
			this.xrTableCell27.Multiline = true;
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.StylePriority.UseFont = false;
			this.xrTableCell27.StylePriority.UseTextAlignment = false;
			this.xrTableCell27.Text = "Người đóng gói";
			this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell27.Weight = 0.99755694198763045D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.StylePriority.UseFont = false;
			this.xrTableCell28.StylePriority.UseTextAlignment = false;
			this.xrTableCell28.Text = "Thủ kho";
			this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell28.Weight = 1.1541957933556617D;
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrTable6});
			this.ReportFooter.HeightF = 269.7917F;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.StylePriority.UseFont = false;
			// 
			// rpt_PhieuDongGoi
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportFooter,
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader});
			this.DataMember = "Table4";
			this.Margins = new System.Drawing.Printing.Margins(24, 20, 23, 23);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}
