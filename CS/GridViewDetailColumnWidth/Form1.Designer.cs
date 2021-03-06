﻿// Developer Express Code Central Example:
// How to keep master and detail view column widths synchronized
// 
// When you have a master-detail view and for some reason don't want to use the
// AutoColumnWidth option, the detail view is still stretched to accommodate the
// entire master view's width. So, in this example we've decided to create a grid
// view that changes this behavior and synchronizes the detail view's width with
// the mater view's columns.
// We create and register a GridView descendant that
// introduces the AutoSynchronizeDetailsLayout option by using a descendant of the
// GridOptionsView class. If this option is enabled and the AutoColumnWidth option
// is disabled the new behavior takes effect. The detail view's width is now
// calculated based on the master view columns' width, so, the detail view ends up
// with the last master view's column. In addition, if the number of detail and
// master view columns is equal, the detail view's columns are aligned with that of
// the master view for even a smoother view.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2454

// Developer Express Code Central Example:
// How to keep master and detail view column widths synchronized
// 
// When you have a master-detail view and for some reason don't want to use the
// AutoColumnWidth option, the detail view is still stretched to accommodate the
// entire master view's width. So, in this example we've decided to create a grid
// view that changes this behavior and synchronizes the detail view's width with
// the mater view's columns.
// We create and register a GridView descendant that
// introduces the AutoSynchronizeDetailsLayout option by using a descendant of the
// GridOptionsView class. If this option is enabled and the AutoColumnWidth option
// is disabled the new behavior takes effect. The detail view's width is now
// calculated based on the master view columns' width, so, the detail view ends up
// with the last master view's column. In addition, if the number of detail and
// master view columns is equal, the detail view's columns are aligned with that of
// the master view for even a smoother view.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2454

namespace GridViewDetailColumnWidth
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.myGridView2 = new GridViewDetailColumnWidth.MyGridView();
            this.colCarId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myGridControl1 = new GridViewDetailColumnWidth.MyGridControl();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new GridViewDetailColumnWidth.CarsDBDataSet();
            this.myGridView1 = new GridViewDetailColumnWidth.MyGridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carsTableAdapter = new GridViewDetailColumnWidth.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.carSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSchedulingTableAdapter = new GridViewDetailColumnWidth.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridView2
            // 
            this.myGridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarId,
            this.colSubject,
            this.colDescription,
            this.colStartTime,
            this.colEndTime,
            this.colLocation});
            this.myGridView2.GridControl = this.myGridControl1;
            this.myGridView2.Name = "myGridView2";
            this.myGridView2.OptionsView.AutoSynchronizeDetailsLayout = GridViewDetailColumnWidth.DetailsLayoutSynchronizationType.LayoutAndColumnOrder;
            this.myGridView2.OptionsView.ColumnAutoWidth = false;
            this.myGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCarId
            // 
            this.colCarId.FieldName = "CarId";
            this.colCarId.Name = "colCarId";
            this.colCarId.Visible = true;
            this.colCarId.VisibleIndex = 0;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 3;
            // 
            // colEndTime
            // 
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 4;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 5;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.carsBindingSource;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.myGridView2;
            gridLevelNode1.RelationName = "Cars_CarScheduling";
            this.myGridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(599, 515);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1,
            this.myGridView2});
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colPrice,
            this.colCategory});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsDetail.ShowDetailTabs = false;
            this.myGridView1.OptionsView.AutoSynchronizeDetailsLayout = GridViewDetailColumnWidth.DetailsLayoutSynchronizationType.LayoutAndColumnOrder;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTrademark
            // 
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            this.colTrademark.VisibleIndex = 1;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            // 
            // colHP
            // 
            this.colHP.FieldName = "HP";
            this.colHP.Name = "colHP";
            this.colHP.Visible = true;
            this.colHP.VisibleIndex = 3;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 5;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // carSchedulingBindingSource
            // 
            this.carSchedulingBindingSource.DataMember = "CarScheduling";
            this.carSchedulingBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carSchedulingTableAdapter
            // 
            this.carSchedulingTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 515);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private CarsDBDataSet carsDBDataSet;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private System.Windows.Forms.BindingSource carSchedulingBindingSource;
		private CarsDBDataSetTableAdapters.CarSchedulingTableAdapter carSchedulingTableAdapter;
		private MyGridControl myGridControl1;
		private MyGridView myGridView2;
		private MyGridView myGridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
		private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colHP;
		private DevExpress.XtraGrid.Columns.GridColumn colCarId;
		private DevExpress.XtraGrid.Columns.GridColumn colSubject;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
	}
}

