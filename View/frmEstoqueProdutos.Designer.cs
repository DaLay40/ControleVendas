namespace View
{
    partial class frmEstoqueProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueProdutos));
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnObservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtObservacao = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnImagem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PictureImagemProduto = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdicionarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.cboProduto = new Utilitarios.Componentes.MyComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNovoProduto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Utilitarios.Componentes.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl8);
            this.panelControl4.Controls.Add(this.txtQuantidade);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.cboProduto);
            this.panelControl4.Controls.Add(this.btnNovoProduto);
            this.panelControl4.Controls.Add(this.btnAdicionarProduto);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 34);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(862, 64);
            this.panelControl4.TabIndex = 24;
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
            this.panelControl1.Size = new System.Drawing.Size(862, 34);
            this.panelControl1.TabIndex = 23;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridProdutos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 392);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Produtos em estoque";
            // 
            // gridProdutos
            // 
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.EmbeddedNavigator.Appearance.Options.UseTextOptions = true;
            this.gridProdutos.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridProdutos.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProdutos.Location = new System.Drawing.Point(2, 23);
            this.gridProdutos.MainView = this.gridViewProdutos;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtObservacao,
            this.PictureImagemProduto});
            this.gridProdutos.Size = new System.Drawing.Size(858, 367);
            this.gridProdutos.TabIndex = 30;
            this.gridProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewProdutos.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewProdutos.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewProdutos.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridViewProdutos.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AutoFillColumn = this.gridColumnObservacoes;
            this.gridViewProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnImagem,
            this.gridColumnDescricao,
            this.gridColumn1marca,
            this.gridColumnValor,
            this.gridColumnQuantidade,
            this.gridColumnObservacoes});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(211)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = ((byte)(0));
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightBlue;
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = ((byte)(2));
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            formatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = ((byte)(1));
            gridFormatRule3.Rule = formatConditionRuleValue3;
            this.gridViewProdutos.FormatRules.Add(gridFormatRule1);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule2);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule3);
            this.gridViewProdutos.GridControl = this.gridProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewProdutos.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewProdutos.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewProdutos.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewProdutos.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewProdutos.OptionsPrint.ExpandAllDetails = true;
            this.gridViewProdutos.OptionsPrint.PrintFooter = false;
            this.gridViewProdutos.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProdutos.OptionsPrint.PrintVertLines = false;
            this.gridViewProdutos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProdutos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewProdutos.OptionsSelection.MultiSelect = true;
            this.gridViewProdutos.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewProdutos.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridViewProdutos.OptionsView.RowAutoHeight = true;
            this.gridViewProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnObservacoes
            // 
            this.gridColumnObservacoes.Caption = "Observações";
            this.gridColumnObservacoes.ColumnEdit = this.txtObservacao;
            this.gridColumnObservacoes.FieldName = "Observacao";
            this.gridColumnObservacoes.Name = "gridColumnObservacoes";
            this.gridColumnObservacoes.OptionsColumn.AllowEdit = false;
            this.gridColumnObservacoes.OptionsColumn.AllowFocus = false;
            this.gridColumnObservacoes.Visible = true;
            this.gridColumnObservacoes.VisibleIndex = 5;
            this.gridColumnObservacoes.Width = 144;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Name = "txtObservacao";
            // 
            // gridColumnImagem
            // 
            this.gridColumnImagem.ColumnEdit = this.PictureImagemProduto;
            this.gridColumnImagem.FieldName = "ImagemConvertida";
            this.gridColumnImagem.Name = "gridColumnImagem";
            this.gridColumnImagem.Visible = true;
            this.gridColumnImagem.VisibleIndex = 0;
            this.gridColumnImagem.Width = 90;
            // 
            // PictureImagemProduto
            // 
            this.PictureImagemProduto.Name = "PictureImagemProduto";
            this.PictureImagemProduto.NullText = "Nenhuma imagem.";
            this.PictureImagemProduto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridColumnDescricao
            // 
            this.gridColumnDescricao.Caption = "Produto";
            this.gridColumnDescricao.FieldName = "Descricao";
            this.gridColumnDescricao.Name = "gridColumnDescricao";
            this.gridColumnDescricao.Visible = true;
            this.gridColumnDescricao.VisibleIndex = 1;
            this.gridColumnDescricao.Width = 139;
            // 
            // gridColumn1marca
            // 
            this.gridColumn1marca.Caption = "Marca";
            this.gridColumn1marca.FieldName = "MarcaNome";
            this.gridColumn1marca.Name = "gridColumn1marca";
            this.gridColumn1marca.Visible = true;
            this.gridColumn1marca.VisibleIndex = 2;
            this.gridColumn1marca.Width = 139;
            // 
            // gridColumnValor
            // 
            this.gridColumnValor.Caption = "Valor";
            this.gridColumnValor.FieldName = "ValorProdutoFormatado";
            this.gridColumnValor.Name = "gridColumnValor";
            this.gridColumnValor.OptionsColumn.AllowEdit = false;
            this.gridColumnValor.OptionsColumn.AllowFocus = false;
            this.gridColumnValor.Visible = true;
            this.gridColumnValor.VisibleIndex = 3;
            this.gridColumnValor.Width = 184;
            // 
            // gridColumnQuantidade
            // 
            this.gridColumnQuantidade.Caption = "Quantidade";
            this.gridColumnQuantidade.FieldName = "Estoque";
            this.gridColumnQuantidade.Name = "gridColumnQuantidade";
            this.gridColumnQuantidade.Visible = true;
            this.gridColumnQuantidade.VisibleIndex = 4;
            this.gridColumnQuantidade.Width = 139;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(412, 29);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(77, 21);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar";
            // 
            // cboProduto
            // 
            this.cboProduto.DataSource = null;
            this.cboProduto.DisplayMember = "";
            this.cboProduto.EditValue = -1;
            this.cboProduto.IdObjetoRetorno = null;
            this.cboProduto.Location = new System.Drawing.Point(9, 30);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(0);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.NaoMudarFocoTeclaEnter = false;
            this.cboProduto.NaoMudarReadOnly = false;
            this.cboProduto.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProduto.Properties.NullText = "";
            this.cboProduto.Required = true;
            this.cboProduto.RequiredMessage = "Informe o Produto.";
            this.cboProduto.SelectedIndex = -1;
            this.cboProduto.SelectedItem = -1;
            this.cboProduto.SelectedValue = -1;
            this.cboProduto.Size = new System.Drawing.Size(184, 20);
            this.cboProduto.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Produtos";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(205, 30);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(77, 20);
            this.btnNovoProduto.TabIndex = 1;
            this.btnNovoProduto.Text = "Novo";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(304, 11);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.EditValue = "1";
            this.txtQuantidade.Location = new System.Drawing.Point(304, 30);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Required = true;
            this.txtQuantidade.RequiredMessege = "Informe a quantidade.";
            this.txtQuantidade.Size = new System.Drawing.Size(87, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // frmEstoqueProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 490);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEstoqueProdutos.IconOptions.Icon")));
            this.Name = "frmEstoqueProdutos";
            this.Text = "Controle de Vendas -  Estoque Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObservacoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1marca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImagem;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit PictureImagemProduto;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProduto;
        private Utilitarios.Componentes.MyComboBox cboProduto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNovoProduto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Utilitarios.Componentes.MyTextBox txtQuantidade;
    }
}