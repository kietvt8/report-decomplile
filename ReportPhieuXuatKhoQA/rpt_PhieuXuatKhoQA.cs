using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace ReportPhieuXuatKhoQA;

public class rpt_PhieuXuatKhoQA : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private DataSet dta = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private PageHeaderBand PageHeader;

	private ReportFooterBand ReportFooter;

	private PageFooterBand PageFooter;

	private XRPageInfo xrPageInfo1;

	private GroupFooterBand GroupFooter1;

	private XRPageBreak xrPageBreak1;

	private XRLabel xrLabel18;

	private XRTable xrTable2;

	private XRTableRow xrTableRow2;

	private XRTableCell xrTableCell11;

	private XRTableCell xrTableCell12;

	private XRTableCell xrTableCell13;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell4;

	private XRTableCell xrTableCell6;

	private XRTableCell xrTableCell7;

	private XRTableCell xrTableCell9;

	private XRTableCell xrTableCell10;

	private XRTableCell xrTableCell18;

	private XRTableCell xrTableCell20;

	private XRTable xrTable6;

	private XRTableRow xrTableRow8;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell21;

	private XRTableCell xrTableCell31;

	private XRTableCell xrTableCell8;

	private XRTableCell xrTableCell16;

	private XRTableCell xrTableCell2;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell19;

	private XRTableCell xrTableCell3;

	private XRTableCell xrTableCell17;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell5;

	private XRTable xrTable3;

	private XRLabel xrLabel4;

	private XRLabel xrLabel8;

	private GroupHeaderBand GroupHeader1;

	private XRTable xrTable5;

	private XRTableRow xrTableRow5;

	private XRTableCell xrTableCell23;

	private XRTableCell xrTableCell26;

	private XRTableRow xrTableRow6;

	private XRTableCell xrTableCell25;

	private XRTableCell xrTableCell28;

	private XRTableCell xrTableCell29;

	private XRTableCell xrTableCell27;

	private XRTableRow xrTableRow7;

	private XRTableCell xrTableCell30;

	private XRTableCell xrTableCell33;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private XRTable xrTable4;

	private XRTableRow xrTableRow4;

	private XRTableCell xrTableCell22;

	private XRTableCell xrTableCell24;

	private rep_PhieuXuatKhoQA rep_PhieuXuatKhoQA1;

	public rpt_PhieuXuatKhoQA()
	{
		InitializeComponent();
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		rep_PhieuXuatKhoQA rep_PhieuXuatKhoQA2 = new rep_PhieuXuatKhoQA();
		rep_PhieuXuatKhoQA2.ApplyDataSet(ds);
		dta = ds;
		base.DataSource = rep_PhieuXuatKhoQA2;
		dset = ds;
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

	private void rpt_PhieuLinhThuocNoiTru_BeforePrint(object sender, PrintEventArgs e)
	{
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.Detail.HeightF = 31.68432F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DoiTuongLinh", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable1
			// 
			this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.5000496F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(781.2083F, 31.68432F);
			this.xrTable1.StylePriority.UseBorders = false;
			this.xrTable1.StylePriority.UseFont = false;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell4,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell18,
            this.xrTableCell20});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STT]")});
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.StylePriority.UsePadding = false;
			this.xrTableCell1.StylePriority.UseTextAlignment = false;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell1.Weight = 0.157269025897196D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell4.StylePriority.UseBorders = false;
			this.xrTableCell4.StylePriority.UsePadding = false;
			this.xrTableCell4.StylePriority.UseTextAlignment = false;
			this.xrTableCell4.Text = "xrTableCell4";
			this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell4.Weight = 0.87155488325966124D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVT]")});
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell6.StylePriority.UseBorders = false;
			this.xrTableCell6.StylePriority.UsePadding = false;
			this.xrTableCell6.StylePriority.UseTextAlignment = false;
			this.xrTableCell6.Text = "xrTableCell6";
			this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell6.Weight = 0.2720374190296086D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoLo]")});
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell7.StylePriority.UseBorders = false;
			this.xrTableCell7.StylePriority.UsePadding = false;
			this.xrTableCell7.StylePriority.UseTextAlignment = false;
			this.xrTableCell7.Text = "xrTableCell7";
			this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell7.Weight = 0.28110079591908332D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HanDung]")});
			this.xrTableCell9.Multiline = true;
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell9.StylePriority.UseBorders = false;
			this.xrTableCell9.StylePriority.UsePadding = false;
			this.xrTableCell9.StylePriority.UseTextAlignment = false;
			this.xrTableCell9.Text = "xrTableCell9";
			this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell9.Weight = 0.3238730658263958D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Qty]")});
			this.xrTableCell10.Multiline = true;
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell10.StylePriority.UseBorders = false;
			this.xrTableCell10.StylePriority.UsePadding = false;
			this.xrTableCell10.StylePriority.UseTextAlignment = false;
			this.xrTableCell10.Text = "xrTableCell10";
			this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell10.TextFormatString = "{0}";
			this.xrTableCell10.Weight = 0.33955438085589279D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DonGia]")});
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell18.StylePriority.UseBorders = false;
			this.xrTableCell18.StylePriority.UsePadding = false;
			this.xrTableCell18.StylePriority.UseTextAlignment = false;
			this.xrTableCell18.Text = "xrTableCell18";
			this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell18.TextFormatString = "{0:}";
			this.xrTableCell18.Weight = 0.32646875521580471D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThanhTien]")});
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell20.StylePriority.UseBorders = false;
			this.xrTableCell20.StylePriority.UsePadding = false;
			this.xrTableCell20.StylePriority.UseTextAlignment = false;
			this.xrTableCell20.Text = "xrTableCell20";
			this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell20.TextFormatString = "{0:}";
			this.xrTableCell20.Weight = 0.44212052914196709D;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 25F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 25F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// ReportHeader
			// 
			this.ReportHeader.HeightF = 0F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// PageHeader
			// 
			this.PageHeader.HeightF = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// ReportFooter
			// 
			this.ReportFooter.HeightF = 0F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
			this.PageFooter.HeightF = 27.91665F;
			this.PageFooter.Name = "PageFooter";
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(757.8334F, 0F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(23.875F, 23F);
			this.xrPageInfo1.StylePriority.UseFont = false;
			this.xrPageInfo1.StylePriority.UseTextAlignment = false;
			this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrPageBreak1,
            this.xrLabel18,
            this.xrTable2});
			this.GroupFooter1.HeightF = 144.0833F;
			this.GroupFooter1.KeepTogether = true;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// xrTable6
			// 
			this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.00006F);
			this.xrTable6.Name = "xrTable6";
			this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
			this.xrTable6.SizeF = new System.Drawing.SizeF(781.5001F, 25F);
			this.xrTable6.StylePriority.UseFont = false;
			this.xrTable6.StylePriority.UseTextAlignment = false;
			this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// xrTableRow8
			// 
			this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell21,
            this.xrTableCell31});
			this.xrTableRow8.Name = "xrTableRow8";
			this.xrTableRow8.Weight = 1D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.StylePriority.UseFont = false;
			this.xrTableCell14.StylePriority.UseTextAlignment = false;
			this.xrTableCell14.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			this.xrTableCell14.Weight = 1.02367003055503D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.StylePriority.UseFont = false;
			this.xrTableCell21.StylePriority.UseTextAlignment = false;
			this.xrTableCell21.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			this.xrTableCell21.Weight = 0.9202631516539217D;
			// 
			// xrTableCell31
			// 
			this.xrTableCell31.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell31.Name = "xrTableCell31";
			this.xrTableCell31.StylePriority.UseFont = false;
			this.xrTableCell31.StylePriority.UseTextAlignment = false;
			this.xrTableCell31.Text = "(Ký, ghi rõ họ tên)";
			this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			this.xrTableCell31.Weight = 1.0560665877590703D;
			// 
			// xrPageBreak1
			// 
			this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 142.0833F);
			this.xrPageBreak1.Name = "xrPageBreak1";
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.NgayChuoi]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(506.3947F, 2.000049F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(275.1055F, 23.00001F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTable2
			// 
			this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0.4999708F, 25.00006F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(781.5001F, 25F);
			this.xrTable2.StylePriority.UseFont = false;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.StylePriority.UseFont = false;
			this.xrTableCell11.StylePriority.UseTextAlignment = false;
			this.xrTableCell11.Text = "Kế toán";
			this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell11.Weight = 1.02367003055503D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.StylePriority.UseFont = false;
			this.xrTableCell12.StylePriority.UseTextAlignment = false;
			this.xrTableCell12.Text = "Người nhận";
			this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell12.Weight = 0.9202631516539217D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.StylePriority.UseFont = false;
			this.xrTableCell13.StylePriority.UseTextAlignment = false;
			this.xrTableCell13.Text = "Thủ kho";
			this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell13.Weight = 1.0560665877590703D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Text = "Đơn giá";
			this.xrTableCell8.Weight = 0.32646851954565043D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.Multiline = true;
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.Text = "Thực xuất";
			this.xrTableCell16.Weight = 0.33955438161785234D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Text = "Hạn dùng";
			this.xrTableCell2.Weight = 0.32387306588989168D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.Text = "Số lô";
			this.xrTableCell15.Weight = 0.28110079585905479D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Text = "ĐVT";
			this.xrTableCell19.Weight = 0.2720374189625504D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Text = "Tên nhãn hiệu quy cách phẩm chất vật tư (sản phẩm hàng hóa)";
			this.xrTableCell3.Weight = 0.87155458970388555D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.Text = "STT";
			this.xrTableCell17.Weight = 0.15726921719614229D;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell3,
            this.xrTableCell19,
            this.xrTableCell15,
            this.xrTableCell2,
            this.xrTableCell16,
            this.xrTableCell8,
            this.xrTableCell5});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Text = "Thành tiền";
			this.xrTableCell5.Weight = 0.44212082218986515D;
			// 
			// xrTable3
			// 
			this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0.5000486F, 272.8735F);
			this.xrTable3.Name = "xrTable3";
			this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.xrTable3.SizeF = new System.Drawing.SizeF(781.2083F, 51.68433F);
			this.xrTable3.StylePriority.UseBorders = false;
			this.xrTable3.StylePriority.UseFont = false;
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 92F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(762.9999F, 34.99998F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "PHIẾU XUẤT KHO";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel8
			// 
			this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.NgayXuat]")});
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(281.9898F, 129.7083F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(224.4046F, 17.00002F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "xrLabel8";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel8.TextFormatString = "Ngày xuất: {0}";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrTable4,
            this.xrLabel8,
            this.xrLabel4,
            this.xrTable3});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DoiTuongLinh", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = 324.5578F;
			this.GroupHeader1.KeepTogether = true;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// xrTable5
			// 
			this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(10F, 192.4788F);
			this.xrTable5.Name = "xrTable5";
			this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7});
			this.xrTable5.SizeF = new System.Drawing.SizeF(747.8335F, 75.00005F);
			// 
			// xrTableRow5
			// 
			this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23,
            this.xrTableCell26});
			this.xrTableRow5.Name = "xrTableRow5";
			this.xrTableRow5.Weight = 1D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.StylePriority.UseTextAlignment = false;
			this.xrTableCell23.Text = "Họ tên người nhận:";
			this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell23.Weight = 0.52290093110763314D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.NguoiNhan]")});
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.StylePriority.UseTextAlignment = false;
			this.xrTableCell26.Text = "xrTableCell26";
			this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell26.Weight = 2.4770990688923673D;
			// 
			// xrTableRow6
			// 
			this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell27});
			this.xrTableRow6.Name = "xrTableRow6";
			this.xrTableRow6.Weight = 1D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.StylePriority.UseTextAlignment = false;
			this.xrTableCell25.Text = "Lý do xuất kho:";
			this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell25.Weight = 0.42010401506500217D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.LyDoXuat]")});
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.StylePriority.UseTextAlignment = false;
			this.xrTableCell28.Text = "xrTableCell28";
			this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell28.Weight = 1.3277228067013895D;
			// 
			// xrTableCell29
			// 
			this.xrTableCell29.Name = "xrTableCell29";
			this.xrTableCell29.StylePriority.UseTextAlignment = false;
			this.xrTableCell29.Text = "Bộ phận:";
			this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell29.Weight = 0.295323674246505D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.BoPhan]")});
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.StylePriority.UseTextAlignment = false;
			this.xrTableCell27.Text = "xrTableCell27";
			this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell27.Weight = 0.95684950398710344D;
			// 
			// xrTableRow7
			// 
			this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30,
            this.xrTableCell33});
			this.xrTableRow7.Name = "xrTableRow7";
			this.xrTableRow7.Weight = 1D;
			// 
			// xrTableCell30
			// 
			this.xrTableCell30.Name = "xrTableCell30";
			this.xrTableCell30.StylePriority.UseTextAlignment = false;
			this.xrTableCell30.Text = "Xuất tại:";
			this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell30.Weight = 0.26261520706298069D;
			// 
			// xrTableCell33
			// 
			this.xrTableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.StockName]")});
			this.xrTableCell33.Name = "xrTableCell33";
			this.xrTableCell33.StylePriority.UseTextAlignment = false;
			this.xrTableCell33.Text = "xrTableCell33";
			this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell33.Weight = 2.7373847929370196D;
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(650.9846F, 167.4364F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(109.598F, 17.00002F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "Có: ";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(650.9846F, 149.1631F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(109.5978F, 17.00002F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Nợ: ";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.ApprovedOutNo]")});
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(506.3944F, 129.7083F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(251.4391F, 17.00002F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "xrLabel1";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel1.TextFormatString = "Số: {0}";
			// 
			// xrTable4
			// 
			this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
			this.xrTable4.Name = "xrTable4";
			this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
			this.xrTable4.SizeF = new System.Drawing.SizeF(763F, 61.54661F);
			this.xrTable4.StylePriority.UseBorders = false;
			// 
			// xrTableRow4
			// 
			this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell24});
			this.xrTableRow4.Name = "xrTableRow4";
			this.xrTableRow4.Weight = 1D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataTable1.StockAddress]")});
			this.xrTableCell22.Multiline = true;
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell22.StylePriority.UsePadding = false;
			this.xrTableCell22.StylePriority.UseTextAlignment = false;
			this.xrTableCell22.Text = "xrTableCell22";
			this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell22.Weight = 2.1610149018573885D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.Multiline = true;
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell24.StylePriority.UsePadding = false;
			this.xrTableCell24.StylePriority.UseTextAlignment = false;
			this.xrTableCell24.Text = "Mẫu số: 01-VT\r\nQĐ số: 1141 – TCQĐCĐKT\r\nNgày 1-11-1995 Bộ Tài Chính";
			this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell24.Weight = 0.83898509814261135D;
			// 
			// rpt_PhieuXuatKhoQA
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupFooter1});
			this.DataMember = "DataTable2";
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margins = new System.Drawing.Printing.Margins(21, 23, 25, 25);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}
