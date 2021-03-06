﻿namespace UI.Desktop
{
    /// <summary>
    /// Summary description for Reporte2.
    /// </summary>
    partial class Reporte2
    {
        private GrapeCity.ActiveReports.SectionReportModel.PageHeader pageHeader;
        private GrapeCity.ActiveReports.SectionReportModel.Detail detail;
        private GrapeCity.ActiveReports.SectionReportModel.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Reporte2));
            GrapeCity.ActiveReports.Data.SqlDBDataSource sqlDBDataSource1 = new GrapeCity.ActiveReports.Data.SqlDBDataSource();
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.txtnombre1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtapellido1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtlegajo1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtapellido1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlegajo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label1});
            this.pageHeader.Height = 1.5F;
            this.pageHeader.Name = "pageHeader";
            // 
            // label1
            // 
            this.label1.Height = 0.638F;
            this.label1.HyperLink = null;
            this.label1.Left = 1F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: Microsoft Sans Serif; font-size: 30pt";
            this.label1.Text = "Listado de Alumnos";
            this.label1.Top = 0.27F;
            this.label1.Width = 3.98F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtnombre1,
            this.txtapellido1,
            this.txtlegajo1});
            this.detail.Height = 0.471F;
            this.detail.Name = "detail";
            // 
            // txtnombre1
            // 
            this.txtnombre1.DataField = "nombre";
            this.txtnombre1.Height = 0.2F;
            this.txtnombre1.Left = 3.031F;
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Text = "txtnombre1";
            this.txtnombre1.Top = 0.123F;
            this.txtnombre1.Width = 1F;
            // 
            // txtapellido1
            // 
            this.txtapellido1.DataField = "apellido";
            this.txtapellido1.Height = 0.2F;
            this.txtapellido1.Left = 4.031F;
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Text = "txtapellido1";
            this.txtapellido1.Top = 0.123F;
            this.txtapellido1.Width = 1F;
            // 
            // txtlegajo1
            // 
            this.txtlegajo1.DataField = "legajo";
            this.txtlegajo1.Height = 0.2F;
            this.txtlegajo1.Left = 1F;
            this.txtlegajo1.Name = "txtlegajo1";
            this.txtlegajo1.Text = "txtlegajo1";
            this.txtlegajo1.Top = 0.123F;
            this.txtlegajo1.Width = 1F;
            // 
            // pageFooter
            // 
            this.pageFooter.CanShrink = true;
            this.pageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.reportInfo1});
            this.pageFooter.Name = "pageFooter";
            // 
            // reportInfo1
            // 
            this.reportInfo1.FormatString = "Page {PageNumber} of {PageCount} on {RunDateTime}";
            this.reportInfo1.Height = 0.2F;
            this.reportInfo1.Left = 1.656F;
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Style = "text-align: center";
            this.reportInfo1.Top = 0F;
            this.reportInfo1.Width = 2.74F;
            // 
            // Reporte2
            // 
            this.MasterReport = false;
            sqlDBDataSource1.ConnectionString = "Server=localhost;Database=tp2_net;Integrated Security=false; User=net; Password=n" +
    "et;";
            sqlDBDataSource1.SQL = "Select * from personas where tipo_persona=1";
            this.DataSource = sqlDBDataSource1;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtapellido1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlegajo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtnombre1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtapellido1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtlegajo1;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
    }
}
