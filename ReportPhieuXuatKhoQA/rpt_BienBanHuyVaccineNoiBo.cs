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

public class rpt_BienBanHuyVaccineNoiBo : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private ReportHeaderBand ReportHeader;

	private PageHeaderBand PageHeader;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell2;

	private XRTableCell xrTableCell3;

	private XRTableCell xrTableCell8;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell16;

	private XRTableCell xrTableCell17;

	private XRTableCell xrTableCell18;

	private XRTableCell xrTableCell19;

	private PageFooterBand PageFooter;

	private rep_BienBanHuyVaccineNoiBo rep_BienBanHuyVaccineNoiBo1;

	private XRLabel xrLabel20;

	private XRLabel xrLabel39;

	private XRLabel xrLabel38;

	private XRLabel xrLabel37;

	private XRLabel xrLabel36;

	private XRLabel xrLabel35;

	private XRLabel xrLabel34;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLine xrLine2;

	private XRLabel xrLabel30;

	private XRLabel xrLabel29;

	private XRLabel xrLabel28;

	private XRLabel xrLabel40;

	private XRLabel xrLabel22;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell20;

	private XRTableCell xrTableCell21;

	private XRTableCell xrTableCell22;

	private XRTableCell xrTableCell23;

	private XRTableCell xrTableCell24;

	private XRTableCell xrTableCell25;

	private XRTableCell xrTableCell26;

	private XRTableCell xrTableCell27;

	private XRTableCell xrTableCell28;

	private XRTableCell xrTableCell29;

	private XRPictureBox xrPictureBox1;

	private XRLabel xrLabel41;

	private ReportFooterBand ReportFooter;

	private XRPanel xrPanel1;

	private XRLabel xrLabel9;

	private XRLabel xrLabel12;

	private XRLabel xrLabel13;

	private XRLabel xrLabel14;

	private XRLabel xrLabel15;

	private XRLabel xrLabel16;

	private XRLabel xrLabel17;

	private XRLabel xrLabel18;

	private XRLabel xrLabel19;

	private XRCheckBox xrCheckBox2;

	private XRCheckBox xrCheckBox1;

	private XRLabel xrLabel1;

	public rpt_BienBanHuyVaccineNoiBo()
	{
		InitializeComponent();
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		rep_BienBanHuyVaccineNoiBo rep_BienBanHuyVaccineNoiBo2 = new rep_BienBanHuyVaccineNoiBo();
		rep_BienBanHuyVaccineNoiBo2.ApplyDataSet(ds);
		base.DataSource = rep_BienBanHuyVaccineNoiBo2;
		dset = rep_BienBanHuyVaccineNoiBo2;
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

	private void rpt_BienBanHuyVaccineNoiBo_BeforePrint(object sender, PrintEventArgs e)
	{
		string text = dset.Tables[0].Rows[0]["Logo"].ToString();
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.xrCheckBox2 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.Detail.HeightF = 48.95832F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable1
			// 
			this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
			this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(1123F, 48.95832F);
			this.xrTable1.StylePriority.UseBorders = false;
			this.xrTable1.StylePriority.UseFont = false;
			this.xrTable1.StylePriority.UseTextAlignment = false;
			this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell8,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STT]")});
			this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.StylePriority.UseFont = false;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.Weight = 0.12000010883172019D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HospitalName]")});
			this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell2.StylePriority.UseBorders = false;
			this.xrTableCell2.StylePriority.UseFont = false;
			this.xrTableCell2.StylePriority.UsePadding = false;
			this.xrTableCell2.StylePriority.UseTextAlignment = false;
			this.xrTableCell2.Text = "xrTableCell2";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell2.Weight = 0.52359748728133115D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NSX]")});
			this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell3.Multiline = true;
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell3.StylePriority.UseBorders = false;
			this.xrTableCell3.StylePriority.UseFont = false;
			this.xrTableCell3.StylePriority.UsePadding = false;
			this.xrTableCell3.StylePriority.UseTextAlignment = false;
			this.xrTableCell3.Text = "xrTableCell3";
			this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell3.Weight = 0.32011149582173803D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Batch]")});
			this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell8.Multiline = true;
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell8.StylePriority.UseBorders = false;
			this.xrTableCell8.StylePriority.UseFont = false;
			this.xrTableCell8.StylePriority.UsePadding = false;
			this.xrTableCell8.StylePriority.UseTextAlignment = false;
			this.xrTableCell8.Text = "xrTableCell8";
			this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell8.Weight = 0.17500976464863577D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApprovedQty]")});
			this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell14.Multiline = true;
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.StylePriority.UseBorders = false;
			this.xrTableCell14.StylePriority.UseFont = false;
			this.xrTableCell14.Text = "xrTableCell14";
			this.xrTableCell14.Weight = 0.2585029091813752D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell15.Multiline = true;
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.StylePriority.UseBorders = false;
			this.xrTableCell15.StylePriority.UseFont = false;
			this.xrTableCell15.Weight = 0.22707035300851838D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell16.Multiline = true;
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.StylePriority.UseBorders = false;
			this.xrTableCell16.StylePriority.UseFont = false;
			this.xrTableCell16.Weight = 0.30605599022273522D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KhoXuat_Name]")});
			this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell17.Multiline = true;
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell17.StylePriority.UseBorders = false;
			this.xrTableCell17.StylePriority.UseFont = false;
			this.xrTableCell17.StylePriority.UsePadding = false;
			this.xrTableCell17.StylePriority.UseTextAlignment = false;
			this.xrTableCell17.Text = "xrTableCell17";
			this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell17.Weight = 0.26714158090450724D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApprovedOutNo]")});
			this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell18.Multiline = true;
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell18.StylePriority.UseBorders = false;
			this.xrTableCell18.StylePriority.UseFont = false;
			this.xrTableCell18.StylePriority.UsePadding = false;
			this.xrTableCell18.StylePriority.UseTextAlignment = false;
			this.xrTableCell18.Text = "xrTableCell18";
			this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell18.Weight = 0.26714157711366149D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Decription]")});
			this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 11.25F);
			this.xrTableCell19.Multiline = true;
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
			this.xrTableCell19.StylePriority.UseBorders = false;
			this.xrTableCell19.StylePriority.UseFont = false;
			this.xrTableCell19.StylePriority.UsePadding = false;
			this.xrTableCell19.StylePriority.UseTextAlignment = false;
			this.xrTableCell19.Text = "xrTableCell19";
			this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell19.Weight = 0.53536873445073D;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 24F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 20F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel20,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLine2,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel40,
            this.xrLabel22,
            this.xrTable3,
            this.xrPictureBox1,
            this.xrLabel41});
			this.ReportHeader.HeightF = 408.7083F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(117.3937F, 0F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(342.9588F, 35F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "[Table1.CustomerFullName]";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel20
			// 
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(849.3062F, 0F);
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(209.2722F, 23F);
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			this.xrLabel20.Text = "SOP-QA-005-07 BM-06";
			this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// xrLabel39
			// 
			this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(488.6391F, 279.7917F);
			this.xrLabel39.Name = "xrLabel39";
			this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel39.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel39.StylePriority.UseFont = false;
			this.xrLabel39.StylePriority.UseTextAlignment = false;
			this.xrLabel39.Text = "Chức vụ:..............................";
			this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel38
			// 
			this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 251.7917F);
			this.xrLabel38.Name = "xrLabel38";
			this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel38.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel38.StylePriority.UseFont = false;
			this.xrLabel38.StylePriority.UseTextAlignment = false;
			this.xrLabel38.Text = "2, Ông (Bà): ...................................................................." +
    "....";
			this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel37
			// 
			this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(488.6391F, 251.7917F);
			this.xrLabel37.Name = "xrLabel37";
			this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel37.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel37.StylePriority.UseFont = false;
			this.xrLabel37.StylePriority.UseTextAlignment = false;
			this.xrLabel37.Text = "Chức vụ:..............................";
			this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel36
			// 
			this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(488.6391F, 223.7917F);
			this.xrLabel36.Name = "xrLabel36";
			this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel36.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel36.StylePriority.UseFont = false;
			this.xrLabel36.StylePriority.UseTextAlignment = false;
			this.xrLabel36.Text = "Chức vụ:..............................";
			this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel35
			// 
			this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 223.7917F);
			this.xrLabel35.Name = "xrLabel35";
			this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel35.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel35.StylePriority.UseFont = false;
			this.xrLabel35.StylePriority.UseTextAlignment = false;
			this.xrLabel35.Text = "1, Ông (Bà): ...................................................................." +
    "....";
			this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel34
			// 
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(0F, 195.7917F);
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(1113F, 28F);
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.StylePriority.UseTextAlignment = false;
			this.xrLabel34.Text = "Chúng tôi, gồm có:";
			this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel32
			// 
			this.xrLabel32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table2.ReportName]")});
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 15.5F, System.Drawing.FontStyle.Bold);
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 126.0417F);
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(1113F, 26.12499F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.StylePriority.UseTextAlignment = false;
			this.xrLabel32.Text = "xrLabel32";
			this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel31
			// 
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(640.034F, 76.04166F);
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(287.1325F, 23F);
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.StylePriority.UseTextAlignment = false;
			this.xrLabel31.Text = "[Table2.NgayIn]";
			this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLine2
			// 
			this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(572.3333F, 59.29171F);
			this.xrLine2.Name = "xrLine2";
			this.xrLine2.SizeF = new System.Drawing.SizeF(194F, 2F);
			// 
			// xrLabel30
			// 
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(488.6391F, 36.29169F);
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(360.6671F, 23F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.StylePriority.UseTextAlignment = false;
			this.xrLabel30.Text = "Độc lập - Tự do - Hạnh phúc";
			this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(488.6391F, 0F);
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(360.6671F, 23F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
			this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel28
			// 
			this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.CustomerAddress]")});
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(117.3937F, 35.00001F);
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(342.9588F, 64.04165F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.StylePriority.UseTextAlignment = false;
			this.xrLabel28.Text = "xrLabel28";
			this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel40
			// 
			this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 279.7917F);
			this.xrLabel40.Name = "xrLabel40";
			this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel40.SizeF = new System.Drawing.SizeF(460.3525F, 28F);
			this.xrLabel40.StylePriority.UseFont = false;
			this.xrLabel40.StylePriority.UseTextAlignment = false;
			this.xrLabel40.Text = "3, Ông (Bà): ...................................................................." +
    "....";
			this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel22
			// 
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 167.7917F);
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(1113F, 28F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.StylePriority.UseTextAlignment = false;
			this.xrLabel22.Text = "Thực hiện theo quy trình hủy vắc xin của Công ty Cổ phần vacxin Việt Nam về việc " +
    "hủy thuốc không đạt chất lượng, bị bể vỡ và vắc xin quá hạn.";
			this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrTable3
			// 
			this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 335.7917F);
			this.xrTable3.Name = "xrTable3";
			this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.xrTable3.SizeF = new System.Drawing.SizeF(1123F, 72.91666F);
			this.xrTable3.StylePriority.UseBorders = false;
			this.xrTable3.StylePriority.UseFont = false;
			this.xrTable3.StylePriority.UseTextAlignment = false;
			this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.StylePriority.UseBorders = false;
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell20.Multiline = true;
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.StylePriority.UseBorders = false;
			this.xrTableCell20.StylePriority.UseFont = false;
			this.xrTableCell20.Text = "STT";
			this.xrTableCell20.Weight = 0.12000010883172019D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell21.Multiline = true;
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.StylePriority.UseBorders = false;
			this.xrTableCell21.StylePriority.UseFont = false;
			this.xrTableCell21.Text = "Tên vắc xin, nồng độ, hàm lượng";
			this.xrTableCell21.Weight = 0.52626890313303631D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell22.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell22.Multiline = true;
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.StylePriority.UseBorders = false;
			this.xrTableCell22.StylePriority.UseFont = false;
			this.xrTableCell22.Text = "Nhà sản xuất";
			this.xrTableCell22.Weight = 0.31744007997003282D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell23.Multiline = true;
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.StylePriority.UseBorders = false;
			this.xrTableCell23.StylePriority.UseFont = false;
			this.xrTableCell23.Text = "Số lô";
			this.xrTableCell23.Weight = 0.17500976464863577D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell24.Multiline = true;
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.StylePriority.UseBorders = false;
			this.xrTableCell24.StylePriority.UseFont = false;
			this.xrTableCell24.Text = "Số lượng hủy theo chứng từ";
			this.xrTableCell24.Weight = 0.2585029091813752D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell25.Multiline = true;
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.StylePriority.UseBorders = false;
			this.xrTableCell25.StylePriority.UseFont = false;
			this.xrTableCell25.Text = "Số lượng thực hủy";
			this.xrTableCell25.Weight = 0.22707035300851838D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell26.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell26.Multiline = true;
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.StylePriority.UseBorders = false;
			this.xrTableCell26.StylePriority.UseFont = false;
			this.xrTableCell26.Text = "Chênh lệch giữa chứng từ và thực tế";
			this.xrTableCell26.Weight = 0.30605599022273522D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell27.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell27.Multiline = true;
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.StylePriority.UseBorders = false;
			this.xrTableCell27.StylePriority.UseFont = false;
			this.xrTableCell27.Text = "Kho hủy";
			this.xrTableCell27.Weight = 0.26714158090450724D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell28.Multiline = true;
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.StylePriority.UseBorders = false;
			this.xrTableCell28.StylePriority.UseFont = false;
			this.xrTableCell28.Text = "Số phiếu";
			this.xrTableCell28.Weight = 0.26714157711366149D;
			// 
			// xrTableCell29
			// 
			this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell29.Font = new System.Drawing.Font("Times New Roman", 11.25F);
			this.xrTableCell29.Multiline = true;
			this.xrTableCell29.Name = "xrTableCell29";
			this.xrTableCell29.StylePriority.UseBorders = false;
			this.xrTableCell29.StylePriority.UseFont = false;
			this.xrTableCell29.Text = "Ghi chú";
			this.xrTableCell29.Weight = 0.53536873445073D;
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(115.7367F, 73.87502F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
			// 
			// xrLabel41
			// 
			this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 307.7917F);
			this.xrLabel41.Name = "xrLabel41";
			this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel41.SizeF = new System.Drawing.SizeF(1123F, 28F);
			this.xrLabel41.StylePriority.UseFont = false;
			this.xrLabel41.StylePriority.UseTextAlignment = false;
			this.xrLabel41.Text = "Đã chứng kiến và tiến hành hủy các vắc xin sau:";
			this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// PageHeader
			// 
			this.PageHeader.HeightF = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.HeightF = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
			this.ReportFooter.HeightF = 304.1667F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrPanel1
			// 
			this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox2,
            this.xrCheckBox1,
            this.xrLabel9,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19});
			this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPanel1.Name = "xrPanel1";
			this.xrPanel1.SizeF = new System.Drawing.SizeF(1113F, 304.1667F);
			// 
			// xrCheckBox2
			// 
			this.xrCheckBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrCheckBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 56.00001F);
			this.xrCheckBox2.Name = "xrCheckBox2";
			this.xrCheckBox2.SizeF = new System.Drawing.SizeF(1103F, 28.00001F);
			this.xrCheckBox2.StylePriority.UseFont = false;
			// 
			// xrCheckBox1
			// 
			this.xrCheckBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28.00001F);
			this.xrCheckBox1.Name = "xrCheckBox1";
			this.xrCheckBox1.SizeF = new System.Drawing.SizeF(1103F, 28.00001F);
			this.xrCheckBox1.StylePriority.UseFont = false;
			this.xrCheckBox1.Text = "Rút hết vắc xin trong lọ, bơm vào thùng rác vàng.";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 0F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(1103F, 28F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "Phương pháp hủy:";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel12
			// 
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 84.00001F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(1103F, 28F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "Biên bản hủy được báo cáo lên: .................................................." +
    "........";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 112F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(1103F, 28.00001F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "Biên bản này được lập thành ...... bản, mỗi bên giữ 1 bản và gửi báo cáo 1 bản: ." +
    "...........................";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel14
			// 
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(44.92009F, 160.0417F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "Điều dưỡng trưởng / Quản lý kho";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel15
			// 
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(836.4583F, 160.0417F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			this.xrLabel15.Text = "Kiểm soát viên chất lượng";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel16
			// 
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(440.8437F, 160.0417F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "BP Kho phòng tiêm/Kho trung tâm ";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel17
			// 
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(44.92009F, 188.0417F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "(Ký và ghi rõ họ tên)";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel18
			// 
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(440.8437F, 188.0417F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "(Ký và ghi rõ họ tên)";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel19
			// 
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(836.4583F, 188.0417F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(240.7484F, 28F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "(Ký và ghi rõ họ tên)";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// rpt_BienBanHuyVaccineNoiBo
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
			this.DataMember = "Table3";
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(23, 23, 24, 20);
			this.PageHeight = 827;
			this.PageWidth = 1169;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}
