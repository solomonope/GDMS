namespace GDataWeb.App_Reports
{
    partial class Report
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.objectDataSource = new Telerik.Reporting.ObjectDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fieldCaptionTextBox = new Telerik.Reporting.TextBox();
            this.oilProducedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cONGProducedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.aGProducedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nAGProducedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.bSWProducedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.gasLiftCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.dateGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.fieldDataTextBox = new Telerik.Reporting.TextBox();
            this.oilProducedDataTextBox = new Telerik.Reporting.TextBox();
            this.cONGProducedDataTextBox = new Telerik.Reporting.TextBox();
            this.aGProducedDataTextBox = new Telerik.Reporting.TextBox();
            this.nAGProducedDataTextBox = new Telerik.Reporting.TextBox();
            this.bSWProducedDataTextBox = new Telerik.Reporting.TextBox();
            this.gasLiftDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // objectDataSource
            // 
            this.objectDataSource.DataMember = "GetAllReadings";
            this.objectDataSource.DataSource = "GDataLib.BLL.ReadingsManager, GDataLib, Version=1.0.0.0, Culture=neutral, PublicK" +
                "eyToken=null";
            this.objectDataSource.Name = "objectDataSource";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dateCaptionTextBox,
            this.fieldCaptionTextBox,
            this.oilProducedCaptionTextBox,
            this.cONGProducedCaptionTextBox,
            this.aGProducedCaptionTextBox,
            this.nAGProducedCaptionTextBox,
            this.bSWProducedCaptionTextBox,
            this.gasLiftCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // fieldCaptionTextBox
            // 
            this.fieldCaptionTextBox.CanGrow = true;
            this.fieldCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0230729579925537D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fieldCaptionTextBox.Name = "fieldCaptionTextBox";
            this.fieldCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.fieldCaptionTextBox.StyleName = "Caption";
            this.fieldCaptionTextBox.Value = "Oil Field";
            // 
            // oilProducedCaptionTextBox
            // 
            this.oilProducedCaptionTextBox.CanGrow = true;
            this.oilProducedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9932291507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.oilProducedCaptionTextBox.Name = "oilProducedCaptionTextBox";
            this.oilProducedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.oilProducedCaptionTextBox.StyleName = "Caption";
            this.oilProducedCaptionTextBox.Value = "OIL (bbl)";
            // 
            // cONGProducedCaptionTextBox
            // 
            this.cONGProducedCaptionTextBox.CanGrow = true;
            this.cONGProducedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9633855819702148D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.cONGProducedCaptionTextBox.Name = "cONGProducedCaptionTextBox";
            this.cONGProducedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.cONGProducedCaptionTextBox.StyleName = "Caption";
            this.cONGProducedCaptionTextBox.Value = "COND (bbl)";
            // 
            // aGProducedCaptionTextBox
            // 
            this.aGProducedCaptionTextBox.CanGrow = true;
            this.aGProducedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.aGProducedCaptionTextBox.Name = "aGProducedCaptionTextBox";
            this.aGProducedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2662582397460938D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.aGProducedCaptionTextBox.StyleName = "Caption";
            this.aGProducedCaptionTextBox.Value = "AG(mmscf/d)";
            // 
            // nAGProducedCaptionTextBox
            // 
            this.nAGProducedCaptionTextBox.CanGrow = true;
            this.nAGProducedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.199999809265137D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nAGProducedCaptionTextBox.Name = "nAGProducedCaptionTextBox";
            this.nAGProducedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8998004198074341D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nAGProducedCaptionTextBox.StyleName = "Caption";
            this.nAGProducedCaptionTextBox.Value = "NAG(mmscf/d)";
            // 
            // bSWProducedCaptionTextBox
            // 
            this.bSWProducedCaptionTextBox.CanGrow = true;
            this.bSWProducedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.100000381469727D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.bSWProducedCaptionTextBox.Name = "bSWProducedCaptionTextBox";
            this.bSWProducedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6910938024520874D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.bSWProducedCaptionTextBox.StyleName = "Caption";
            this.bSWProducedCaptionTextBox.Value = "BSW(%)";
            // 
            // gasLiftCaptionTextBox
            // 
            this.gasLiftCaptionTextBox.CanGrow = true;
            this.gasLiftCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.844010353088379D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.gasLiftCaptionTextBox.Name = "gasLiftCaptionTextBox";
            this.gasLiftCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.gasLiftCaptionTextBox.StyleName = "Caption";
            this.gasLiftCaptionTextBox.Value = "GAS LIFT(mmscf/d)";
            // 
            // dateGroupHeaderSection
            // 
            this.dateGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.dateGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dateDataTextBox});
            this.dateGroupHeaderSection.Name = "dateGroupHeaderSection";
            // 
            // dateGroupFooterSection
            // 
            this.dateGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.dateGroupFooterSection.Name = "dateGroupFooterSection";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "=Fields.Date";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "GEOTREX";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Production Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.fieldDataTextBox,
            this.oilProducedDataTextBox,
            this.cONGProducedDataTextBox,
            this.aGProducedDataTextBox,
            this.nAGProducedDataTextBox,
            this.bSWProducedDataTextBox,
            this.gasLiftDataTextBox});
            this.detail.Name = "detail";
            // 
            // fieldDataTextBox
            // 
            this.fieldDataTextBox.CanGrow = true;
            this.fieldDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0230729579925537D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fieldDataTextBox.Name = "fieldDataTextBox";
            this.fieldDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.fieldDataTextBox.StyleName = "Data";
            this.fieldDataTextBox.Value = "=Fields.Field";
            // 
            // oilProducedDataTextBox
            // 
            this.oilProducedDataTextBox.CanGrow = true;
            this.oilProducedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9932291507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.oilProducedDataTextBox.Name = "oilProducedDataTextBox";
            this.oilProducedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.oilProducedDataTextBox.StyleName = "Data";
            this.oilProducedDataTextBox.Value = "=Fields.OilProduced";
            // 
            // cONGProducedDataTextBox
            // 
            this.cONGProducedDataTextBox.CanGrow = true;
            this.cONGProducedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9633855819702148D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.cONGProducedDataTextBox.Name = "cONGProducedDataTextBox";
            this.cONGProducedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.cONGProducedDataTextBox.StyleName = "Data";
            this.cONGProducedDataTextBox.Value = "=Fields.CONGProduced";
            // 
            // aGProducedDataTextBox
            // 
            this.aGProducedDataTextBox.CanGrow = true;
            this.aGProducedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.aGProducedDataTextBox.Name = "aGProducedDataTextBox";
            this.aGProducedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.aGProducedDataTextBox.StyleName = "Data";
            this.aGProducedDataTextBox.Value = "=Fields.AGProduced";
            // 
            // nAGProducedDataTextBox
            // 
            this.nAGProducedDataTextBox.CanGrow = true;
            this.nAGProducedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9036979675292969D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nAGProducedDataTextBox.Name = "nAGProducedDataTextBox";
            this.nAGProducedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nAGProducedDataTextBox.StyleName = "Data";
            this.nAGProducedDataTextBox.Value = "=Fields.NAGProduced";
            // 
            // bSWProducedDataTextBox
            // 
            this.bSWProducedDataTextBox.CanGrow = true;
            this.bSWProducedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.873854637145996D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.bSWProducedDataTextBox.Name = "bSWProducedDataTextBox";
            this.bSWProducedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.bSWProducedDataTextBox.StyleName = "Data";
            this.bSWProducedDataTextBox.Value = "=Fields.BSWProduced";
            // 
            // gasLiftDataTextBox
            // 
            this.gasLiftDataTextBox.CanGrow = true;
            this.gasLiftDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.844010353088379D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.gasLiftDataTextBox.Name = "gasLiftDataTextBox";
            this.gasLiftDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9172395467758179D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.gasLiftDataTextBox.StyleName = "Data";
            this.gasLiftDataTextBox.Value = "=Fields.GasLift";
            // 
            // Report
            // 
            this.DataSource = this.objectDataSource;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.dateGroupFooterSection;
            group2.GroupHeader = this.dateGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Date"));
            group2.Name = "dateGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.dateGroupHeaderSection,
            this.dateGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "Report";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.ObjectDataSource objectDataSource;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox fieldCaptionTextBox;
        private Telerik.Reporting.TextBox oilProducedCaptionTextBox;
        private Telerik.Reporting.TextBox cONGProducedCaptionTextBox;
        private Telerik.Reporting.TextBox aGProducedCaptionTextBox;
        private Telerik.Reporting.TextBox nAGProducedCaptionTextBox;
        private Telerik.Reporting.TextBox bSWProducedCaptionTextBox;
        private Telerik.Reporting.TextBox gasLiftCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection dateGroupHeaderSection;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.GroupFooterSection dateGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox fieldDataTextBox;
        private Telerik.Reporting.TextBox oilProducedDataTextBox;
        private Telerik.Reporting.TextBox cONGProducedDataTextBox;
        private Telerik.Reporting.TextBox aGProducedDataTextBox;
        private Telerik.Reporting.TextBox nAGProducedDataTextBox;
        private Telerik.Reporting.TextBox bSWProducedDataTextBox;
        private Telerik.Reporting.TextBox gasLiftDataTextBox;

    }
}