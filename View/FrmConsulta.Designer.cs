namespace View
{
    partial class FrmConsulta
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
            if (disposing && (components != null))
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSelecionarConta = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelecionarConta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(555, 34);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridConsulta);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 300);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Consulta ";
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridConsulta.Location = new System.Drawing.Point(2, 23);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSelecionarConta});
            this.gridConsulta.Size = new System.Drawing.Size(551, 275);
            this.gridConsulta.TabIndex = 31;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewConsulta.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewConsulta.AutoFillColumn = this.gridColumnDescricao;
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnDescricao});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(211)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = 1;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightBlue;
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = 2;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            formatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = 3;
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            formatConditionRuleValue4.Appearance.BackColor2 = System.Drawing.Color.Honeydew;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = 4;
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Name = "Format4";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(124)))));
            formatConditionRuleValue5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = true;
            gridFormatRule5.Rule = formatConditionRuleValue5;
            this.gridViewConsulta.FormatRules.Add(gridFormatRule1);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule2);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule3);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule4);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule5);
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewConsulta.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewConsulta.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewConsulta.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewConsulta.OptionsPrint.PrintFooter = false;
            this.gridViewConsulta.OptionsPrint.PrintGroupFooter = false;
            this.gridViewConsulta.OptionsPrint.PrintVertLines = false;
            this.gridViewConsulta.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewConsulta.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewConsulta.OptionsSelection.MultiSelect = true;
            this.gridViewConsulta.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewConsulta.OptionsView.ColumnAutoWidth = false;
            this.gridViewConsulta.OptionsView.RowAutoHeight = true;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDescricao
            // 
            this.gridColumnDescricao.Caption = "Descrição";
            this.gridColumnDescricao.FieldName = "Descricao";
            this.gridColumnDescricao.Name = "gridColumnDescricao";
            this.gridColumnDescricao.OptionsColumn.AllowEdit = false;
            this.gridColumnDescricao.OptionsColumn.AllowFocus = false;
            this.gridColumnDescricao.Visible = true;
            this.gridColumnDescricao.VisibleIndex = 1;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.OptionsColumn.AllowEdit = false;
            this.gridColumnId.OptionsColumn.AllowFocus = false;
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // chkSelecionarConta
            // 
            this.chkSelecionarConta.AutoHeight = false;
            this.chkSelecionarConta.Name = "chkSelecionarConta";
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 334);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmConsulta.IconOptions.Icon")));
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Vendas - Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelecionarConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSelecionarConta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescricao;
    }
}