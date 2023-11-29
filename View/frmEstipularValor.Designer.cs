namespace View
{
    partial class frmEstipularValor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstipularValor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPorcentagemLucro = new Utilitarios.Componentes.MyTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorCompra = new Utilitarios.Componentes.MyTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelControl1.Size = new System.Drawing.Size(248, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPorcentagemLucro);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtValorCompra);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 185);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Estipular Valor";
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(12, 98);
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.Required = true;
            this.txtPorcentagemLucro.RequiredMessege = "Infrome a porcentagem de lucro desejada.";
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(55, 20);
            this.txtPorcentagemLucro.TabIndex = 1;
            this.txtPorcentagemLucro.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "%";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Porcentagem de lucro";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(12, 52);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Required = true;
            this.txtValorCompra.RequiredMessege = "Informe o valor de compra.";
            this.txtValorCompra.Size = new System.Drawing.Size(184, 20);
            this.txtValorCompra.TabIndex = 0;
            this.txtValorCompra.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Valor de compra";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panel1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 182);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(248, 37);
            this.panelControl4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(132, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 33);
            this.panel1.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            // 
            // frmEstipularValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 219);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEstipularValor.IconOptions.Icon")));
            this.Name = "frmEstipularValor";
            this.Text = "Controle Vendas - Calcular Valor";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Utilitarios.Componentes.MyTextBox txtPorcentagemLucro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Utilitarios.Componentes.MyTextBox txtValorCompra;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCalcular;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}