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

public class rpt_PhieuXuatKhoBanThuongMai : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell2;

	private PageHeaderBand PageHeader;

	private XRLabel xrLabel13;

	private XRLabel xrLabel12;

	private XRLabel xrLabel11;

	private XRLabel xrLabel8;

	private XRLabel xrLabel7;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell17;

	private XRTableCell xrTableCell18;

	private XRTableCell xrTableCell19;

	private XRTableCell xrTableCell20;

	private XRTableCell xrTableCell21;

	private XRTableCell xrTableCell22;

	private XRTableCell xrTableCell23;

	private XRTableCell xrTableCell16;

	private XRTable xrTable2;

	private XRTableRow xrTableRow2;

	private XRTableCell xrTableCell4;

	private XRTableCell xrTableCell5;

	private XRTableCell xrTableCell7;

	private XRTableCell xrTableCell6;

	private XRTableCell xrTableCell9;

	private XRTableCell xrTableCell10;

	private XRTableCell xrTableCell11;

	private XRTableCell xrTableCell12;

	private XRTableCell xrTableCell13;

	private XRTableCell xrTableCell8;

	private XRTable xrTable6;

	private XRTableRow xrTableRow6;

	private XRTableCell xrTableCell31;

	private XRTableCell xrTableCell33;

	private XRTableCell xrTableCell32;

	private XRTable xrTable5;

	private XRTableRow xrTableRow5;

	private XRTableCell xrTableCell27;

	private XRTableCell xrTableCell29;

	private XRTableCell xrTableCell28;

	private XRTable xrTable4;

	private XRTableRow xrTableRow4;

	private XRTableCell xrTableCell25;

	private XRTableCell xrTableCell24;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel20;

	private XRLabel xrLabel19;

	private XRLabel xrLabel18;

	private XRLabel xrLabel17;

	private XRLabel xrLabel28;

	private rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF rep_PhieuXuatKhoKiemVanChuyenNoiBo_PDF1;

	private XRTableCell xrTableCell1;

	private XRLabel xrLabel30;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLabel xrLabel6;

	private XRLabel xrLabel9;

	private XRLabel xrLabel29;

	private XRLabel xrLabel10;

	private XRLabel xrLabel16;

	private XRLabel xrLabel14;

	private XRLabel xrLabel21;

	private XRLabel xrLabel22;

	private XRLabel xrLabel15;

	private XRTableCell xrTableCell26;

	private XRTableCell xrTableCell3;

	private XRPictureBox xrPictureBox1;

	private XRPageInfo xrPageInfo1;
	private XRLabel xrLabel24;
	private XRLabel xrLabel23;

	public rpt_PhieuXuatKhoBanThuongMai()
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

	private void rpt_PhieuXuatKhoBanThuongMai_BeforePrint(object sender, PrintEventArgs e)
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
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
			this.Detail.HeightF = 25F;
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
			this.xrTable3.SizeF = new System.Drawing.SizeF(1125F, 25F);
			this.xrTable3.StylePriority.UseTextAlignment = false;
			this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell16});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell14.StylePriority.UseBorders = false;
			this.xrTableCell14.StylePriority.UseFont = false;
			this.xrTableCell14.StylePriority.UsePadding = false;
			this.xrTableCell14.StylePriority.UseTextAlignment = false;
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell14.Summary = xrSummary1;
			this.xrTableCell14.Text = "STT";
			this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell14.Weight = 0.15292162579941254D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HopitalCode]")});
			this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell15.StylePriority.UseBorders = false;
			this.xrTableCell15.StylePriority.UseFont = false;
			this.xrTableCell15.StylePriority.UsePadding = false;
			this.xrTableCell15.StylePriority.UseTextAlignment = false;
			this.xrTableCell15.Text = "xrTableCell15";
			this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell15.Weight = 0.31938619785226768D;
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
			this.xrTableCell17.Weight = 0.56707750889031427D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuyCach]")});
			this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell18.StylePriority.UseBorders = false;
			this.xrTableCell18.StylePriority.UseFont = false;
			this.xrTableCell18.StylePriority.UsePadding = false;
			this.xrTableCell18.Weight = 0.24288341497160509D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HangSanXuatName]")});
			this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell19.StylePriority.UseBorders = false;
			this.xrTableCell19.StylePriority.UseFont = false;
			this.xrTableCell19.StylePriority.UsePadding = false;
			this.xrTableCell19.StylePriority.UseTextAlignment = false;
			this.xrTableCell19.Text = "xrTableCell19";
			this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell19.Weight = 0.36924144212377041D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Unit]")});
			this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell20.StylePriority.UseBorders = false;
			this.xrTableCell20.StylePriority.UseFont = false;
			this.xrTableCell20.StylePriority.UsePadding = false;
			this.xrTableCell20.Text = "xrTableCell20";
			this.xrTableCell20.Weight = 0.24509603405573094D;
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
			this.xrTableCell21.Weight = 0.2185465336895919D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Batch]")});
			this.xrTableCell22.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell22.StylePriority.UseBorders = false;
			this.xrTableCell22.StylePriority.UseFont = false;
			this.xrTableCell22.StylePriority.UsePadding = false;
			this.xrTableCell22.StylePriority.UseTextAlignment = false;
			this.xrTableCell22.Text = "xrTableCell22";
			this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell22.Weight = 0.33618693306653014D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExpDate]")});
			this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell23.StylePriority.UseBorders = false;
			this.xrTableCell23.StylePriority.UseFont = false;
			this.xrTableCell23.StylePriority.UsePadding = false;
			this.xrTableCell23.Text = "xrTableCell23";
			this.xrTableCell23.TextFormatString = "{0:dd/MM/yyyy}";
			this.xrTableCell23.Weight = 0.33705828814947481D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ViTriXuat]")});
			this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 1, 1, 100F);
			this.xrTableCell16.StylePriority.UseBorders = false;
			this.xrTableCell16.StylePriority.UseFont = false;
			this.xrTableCell16.StylePriority.UsePadding = false;
			this.xrTableCell16.StylePriority.UseTextAlignment = false;
			this.xrTableCell16.Text = "xrTableCell16";
			this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell16.TextFormatString = "{0:n0}";
			this.xrTableCell16.Weight = 0.30320432069093112D;
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
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel21,
            this.xrTable1});
			this.ReportHeader.HeightF = 89.99998F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(115.7367F, 73.87502F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
			// 
			// xrLabel21
			// 
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(905.7277F, 0F);
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(209.2722F, 23F);
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "SOP-KHO-009-05 BM-01";
			this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(282.3659F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(609.8201F, 89.99998F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.Weight = 0.0056195197856871437D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 18F);
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.StylePriority.UseFont = false;
			this.xrTableCell2.StylePriority.UseTextAlignment = false;
			this.xrTableCell2.Text = "PHIẾU XUẤT KHO ";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell2.Weight = 1.7078267455635467D;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel24,
            this.xrPageInfo1,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel10,
            this.xrLabel6,
            this.xrLabel9,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrTable2,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
			this.PageHeader.HeightF = 277.6667F;
			this.PageHeader.Name = "PageHeader";
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(863.7484F, 86.83001F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(244.0428F, 23F);
			this.xrPageInfo1.StylePriority.UseFont = false;
			this.xrPageInfo1.StylePriority.UseTextAlignment = false;
			this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel23
			// 
			this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(760.6237F, 86.83F);
			this.xrLabel23.Name = "xrLabel23";
			this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel23.SizeF = new System.Drawing.SizeF(103.1248F, 23F);
			this.xrLabel23.StylePriority.UseFont = false;
			this.xrLabel23.StylePriority.UseTextAlignment = false;
			this.xrLabel23.Text = "Số trang:";
			this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel22
			// 
			this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.Tax]")});
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 11.25F);
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(107.2917F, 36.00001F);
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(649.9999F, 23F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.StylePriority.UseTextAlignment = false;
			this.xrLabel22.Text = "xrLabel22";
			this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel15
			// 
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(23.95831F, 36.00001F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(83.33325F, 23F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			this.xrLabel15.Text = "Mã số thuế:";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel16
			// 
			this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DienThoaiLienHe]")});
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(669.2237F, 184.6251F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(438.5687F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "xrLabel16";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel14
			// 
			this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.CustomerName]")});
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(655.6819F, 115.625F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(452.1104F, 23F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "xrLabel14";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel10
			// 
			this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DonViVanChuyen]")});
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(171.8676F, 115.625F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(352.091F, 23F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "xrLabel10";
			this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel6
			// 
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 184.6251F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(177.7691F, 23F);
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "4. Dự kiến ngày giao hàng:";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel9
			// 
			this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NgayDuKienGiaoHang]")});
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(201.7274F, 184.6251F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(322.2311F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "xrLabel9";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel32
			// 
			this.xrLabel32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.SoLDD]")});
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(863.7485F, 11F);
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(245.2504F, 23F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.StylePriority.UseTextAlignment = false;
			this.xrLabel32.Text = "xrLabel32";
			this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel31
			// 
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(760.6237F, 11.00001F);
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(103.1248F, 23F);
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.StylePriority.UseTextAlignment = false;
			this.xrLabel31.Text = "Số LĐĐ: ";
			this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel30
			// 
			this.xrLabel30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DiaDiemGiaoHang]")});
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(681.6808F, 161.625F);
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(426.1116F, 23F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.StylePriority.UseTextAlignment = false;
			this.xrLabel30.Text = "[Table1.DiaDiemGiaoHang]";
			this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(528.5985F, 115.625F);
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(127.0834F, 23F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.Text = "5. Tên khách hàng:";
			this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel28
			// 
			this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DiaChi]")});
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 11.25F);
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(107.2917F, 61.83338F);
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(649.9999F, 23F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.StylePriority.UseTextAlignment = false;
			this.xrLabel28.Text = "xrLabel28";
			this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel20
			// 
			this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DiaChiKhachHang]")});
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(602.1541F, 138.625F);
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(505.6383F, 22.99998F);
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			this.xrLabel20.Text = "xrLabel20";
			this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel19
			// 
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.KhoXuatName]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(125.6858F, 161.625F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(398.2728F, 23F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "xrLabel19";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NgayXuat]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(863.7485F, 61.83338F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(244.0439F, 23F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel18.TextFormatString = "{0:}";
			// 
			// xrLabel17
			// 
			this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.SoPhieuXuat]")});
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(863.7485F, 37.00002F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(245.2504F, 23F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "xrLabel17";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrTable2
			// 
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0.0009218852F, 222.4583F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(1124.999F, 55.20834F);
			this.xrTable2.StylePriority.UseTextAlignment = false;
			this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7,
            this.xrTableCell6,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell8});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell4.Multiline = true;
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.StylePriority.UseBorders = false;
			this.xrTableCell4.StylePriority.UseFont = false;
			this.xrTableCell4.Text = "STT\r\n(1)\r\n";
			this.xrTableCell4.Weight = 0.14838832724054693D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell5.Multiline = true;
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.StylePriority.UseBorders = false;
			this.xrTableCell5.StylePriority.UseFont = false;
			this.xrTableCell5.Text = "Mã hàng\r\n(2) ";
			this.xrTableCell5.Weight = 0.30992320088806274D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell7.Multiline = true;
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.StylePriority.UseBorders = false;
			this.xrTableCell7.StylePriority.UseFont = false;
			this.xrTableCell7.Text = "Tên hàng hóa(3)";
			this.xrTableCell7.Weight = 0.55027598925041776D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell6.Multiline = true;
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.StylePriority.UseBorders = false;
			this.xrTableCell6.StylePriority.UseFont = false;
			this.xrTableCell6.Text = "Quy cách\r\n(4)";
			this.xrTableCell6.Weight = 0.23568695247966961D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell9.Multiline = true;
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.StylePriority.UseBorders = false;
			this.xrTableCell9.StylePriority.UseFont = false;
			this.xrTableCell9.Text = "Nhà sản xuất\r\n(5)";
			this.xrTableCell9.Weight = 0.35830164083174981D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell10.Multiline = true;
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.StylePriority.UseBorders = false;
			this.xrTableCell10.StylePriority.UseFont = false;
			this.xrTableCell10.Text = "Đơn vị tính\r\n(6)";
			this.xrTableCell10.Weight = 0.23783396810526727D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell11.Multiline = true;
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.StylePriority.UseBorders = false;
			this.xrTableCell11.StylePriority.UseFont = false;
			this.xrTableCell11.Text = "Số lượng\r\n(7)";
			this.xrTableCell11.Weight = 0.21207130040018438D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell12.Multiline = true;
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.StylePriority.UseBorders = false;
			this.xrTableCell12.StylePriority.UseFont = false;
			this.xrTableCell12.Text = "Số lô\r\n(8)";
			this.xrTableCell12.Weight = 0.32622625803965111D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell13.Multiline = true;
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.StylePriority.UseBorders = false;
			this.xrTableCell13.StylePriority.UseFont = false;
			this.xrTableCell13.Text = "Hạn dùng\r\n(9)";
			this.xrTableCell13.Weight = 0.32707187921020026D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell8.Multiline = true;
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.StylePriority.UseBorders = false;
			this.xrTableCell8.StylePriority.UseFont = false;
			this.xrTableCell8.Text = "Vị trí xuất \r\n(10)";
			this.xrTableCell8.Weight = 0.29422048355424962D;
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(528.5985F, 161.625F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(153.0822F, 23F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "7. Địa điểm giao hàng:";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel12
			// 
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(528.5985F, 138.625F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(73.55554F, 23.00002F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "6. Địa chỉ:";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(528.5985F, 184.6251F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(140.6251F, 23F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.StylePriority.UseTextAlignment = false;
			this.xrLabel11.Text = "8. Điện thoại liên hệ:";
			this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel8
			// 
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(23.95836F, 161.625F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(101.7274F, 23F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "3. Xuất tại kho:";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 138.625F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(500.0003F, 23F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "2. Phương tiện vận chuyển :";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel5
			// 
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(760.6237F, 61.83337F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(103.1248F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "Ngày xuất:";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(760.6237F, 37.00001F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(103.1248F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "Số phiếu xuất:";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 115.625F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(147.9093F, 22.99998F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "1. Đơn vị  vận chuyển:";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 61.83338F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(83.33325F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Địa chỉ:";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.TenCongTy]")});
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 10.00001F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(733.3334F, 23F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "xrLabel1";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrTable6
			// 
			this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(16.12521F, 95.83334F);
			this.xrTable6.Name = "xrTable6";
			this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
			this.xrTable6.SizeF = new System.Drawing.SizeF(1091.666F, 24.99999F);
			this.xrTable6.StylePriority.UseTextAlignment = false;
			this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrTableRow6
			// 
			this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell26,
            this.xrTableCell33,
            this.xrTableCell32});
			this.xrTableRow6.Name = "xrTableRow6";
			this.xrTableRow6.StylePriority.UseTextAlignment = false;
			this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableRow6.Weight = 1D;
			// 
			// xrTableCell31
			// 
			this.xrTableCell31.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell31.Name = "xrTableCell31";
			this.xrTableCell31.StylePriority.UseFont = false;
			this.xrTableCell31.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell31.Weight = 0.74748132922303445D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.StylePriority.UseFont = false;
			this.xrTableCell26.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell26.Weight = 0.74748136267333409D;
			// 
			// xrTableCell33
			// 
			this.xrTableCell33.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell33.Name = "xrTableCell33";
			this.xrTableCell33.StylePriority.UseFont = false;
			this.xrTableCell33.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell33.Weight = 0.74748136267333409D;
			// 
			// xrTableCell32
			// 
			this.xrTableCell32.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell32.Name = "xrTableCell32";
			this.xrTableCell32.StylePriority.UseFont = false;
			this.xrTableCell32.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell32.Weight = 0.75755594543029769D;
			// 
			// xrTable5
			// 
			this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(16.1252F, 55.83331F);
			this.xrTable5.Name = "xrTable5";
			this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
			this.xrTable5.SizeF = new System.Drawing.SizeF(1091.667F, 39.99998F);
			this.xrTable5.StylePriority.UseTextAlignment = false;
			this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow5
			// 
			this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell27,
            this.xrTableCell3,
            this.xrTableCell29,
            this.xrTableCell28});
			this.xrTableRow5.Name = "xrTableRow5";
			this.xrTableRow5.Weight = 1D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.StylePriority.UseFont = false;
			this.xrTableCell27.StylePriority.UseTextAlignment = false;
			this.xrTableCell27.Text = "Người xuất";
			this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell27.Weight = 0.74748068067926376D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTableCell3.Multiline = true;
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.StylePriority.UseFont = false;
			this.xrTableCell3.Text = "Người chịu trách nhiệm\r\nchuyên môn";
			this.xrTableCell3.Weight = 0.74748067801159079D;
			// 
			// xrTableCell29
			// 
			this.xrTableCell29.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell29.Name = "xrTableCell29";
			this.xrTableCell29.StylePriority.UseFont = false;
			this.xrTableCell29.Text = "Đơn vị/ người vận chuyển";
			this.xrTableCell29.Weight = 0.74748067801159079D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.StylePriority.UseFont = false;
			this.xrTableCell28.StylePriority.UseTextAlignment = false;
			this.xrTableCell28.Text = "Người nhận";
			this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell28.Weight = 0.75755796329755465D;
			// 
			// xrTable4
			// 
			this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0.0009218852F, 0F);
			this.xrTable4.Name = "xrTable4";
			this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
			this.xrTable4.SizeF = new System.Drawing.SizeF(1124.999F, 25F);
			// 
			// xrTableRow4
			// 
			this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell24});
			this.xrTableRow4.Name = "xrTableRow4";
			this.xrTableRow4.Weight = 1D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell25.StylePriority.UseBorders = false;
			this.xrTableCell25.StylePriority.UseFont = false;
			this.xrTableCell25.StylePriority.UsePadding = false;
			this.xrTableCell25.StylePriority.UseTextAlignment = false;
			this.xrTableCell25.Text = "Tổng khoản:   ";
			this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell25.Weight = 1.6515090281422469D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.TongKhoan]")});
			this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(13, 0, 0, 0, 100F);
			this.xrTableCell24.StylePriority.UseBorders = false;
			this.xrTableCell24.StylePriority.UseFont = false;
			this.xrTableCell24.StylePriority.UsePadding = false;
			this.xrTableCell24.StylePriority.UseTextAlignment = false;
			this.xrTableCell24.Text = "xrTableCell24";
			this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell24.Weight = 1.4400936885518831D;
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrTable5,
            this.xrTable6});
			this.ReportFooter.HeightF = 269.7917F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrLabel24
			// 
			this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.PhuongTienVanChuyen]")});
			this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(201.7274F, 138.625F);
			this.xrLabel24.Name = "xrLabel24";
			this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel24.SizeF = new System.Drawing.SizeF(322.231F, 23F);
			this.xrLabel24.StylePriority.UseFont = false;
			this.xrLabel24.StylePriority.UseTextAlignment = false;
			this.xrLabel24.Text = "xrLabel10";
			this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// rpt_PhieuXuatKhoBanThuongMai
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
			this.DataMember = "Table4";
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(24, 20, 23, 23);
			this.PageHeight = 827;
			this.PageWidth = 1169;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}
