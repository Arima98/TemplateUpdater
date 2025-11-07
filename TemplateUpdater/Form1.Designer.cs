namespace TemplateUpdater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCargarZip = new System.Windows.Forms.Button();
            this.btnRutaSalida = new System.Windows.Forms.Button();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.leftPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelReglas = new System.Windows.Forms.Label();
            this.dgvReglas = new System.Windows.Forms.DataGridView();
            this.rightPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelPreview = new System.Windows.Forms.Label();
            this.tvPreview = new System.Windows.Forms.TreeView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.mainTableLayout.SuspendLayout();
            this.topButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.leftPanelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglas)).BeginInit();
            this.rightPanelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.topButtonsPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.mainSplit, 0, 1);
            this.mainTableLayout.Controls.Add(this.btnActualizar, 0, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayout.Size = new System.Drawing.Size(784, 561);
            this.mainTableLayout.TabIndex = 0;
            // 
            // topButtonsPanel
            // 
            this.topButtonsPanel.ColumnCount = 2;
            this.topButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topButtonsPanel.Controls.Add(this.btnCargarZip, 0, 0);
            this.topButtonsPanel.Controls.Add(this.btnRutaSalida, 1, 0);
            this.topButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.topButtonsPanel.Name = "topButtonsPanel";
            this.topButtonsPanel.RowCount = 1;
            this.topButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topButtonsPanel.Size = new System.Drawing.Size(778, 35);
            this.topButtonsPanel.TabIndex = 0;
            // 
            // btnCargarZip
            // 
            this.btnCargarZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCargarZip.Location = new System.Drawing.Point(3, 3);
            this.btnCargarZip.Name = "btnCargarZip";
            this.btnCargarZip.Size = new System.Drawing.Size(383, 29);
            this.btnCargarZip.TabIndex = 0;
            this.btnCargarZip.Text = "1. Cargar ZIP de Plantilla...";
            this.btnCargarZip.UseVisualStyleBackColor = true;
            this.btnCargarZip.Click += new System.EventHandler(this.btnCargarZip_Click);
            // 
            // btnRutaSalida
            // 
            this.btnRutaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRutaSalida.Location = new System.Drawing.Point(392, 3);
            this.btnRutaSalida.Name = "btnRutaSalida";
            this.btnRutaSalida.Size = new System.Drawing.Size(383, 29);
            this.btnRutaSalida.TabIndex = 1;
            this.btnRutaSalida.Text = "2. Seleccionar Ruta de Salida...";
            this.btnRutaSalida.UseVisualStyleBackColor = true;
            this.btnRutaSalida.Click += new System.EventHandler(this.btnRutaSalida_Click);
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.Location = new System.Drawing.Point(3, 44);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.leftPanelTable);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.rightPanelTable);
            this.mainSplit.Size = new System.Drawing.Size(778, 479);
            this.mainSplit.SplitterDistance = 389;
            this.mainSplit.TabIndex = 1;
            // 
            // leftPanelTable
            // 
            this.leftPanelTable.ColumnCount = 1;
            this.leftPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanelTable.Controls.Add(this.labelReglas, 0, 0);
            this.leftPanelTable.Controls.Add(this.dgvReglas, 0, 1);
            this.leftPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanelTable.Location = new System.Drawing.Point(0, 0);
            this.leftPanelTable.Name = "leftPanelTable";
            this.leftPanelTable.RowCount = 2;
            this.leftPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.leftPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanelTable.Size = new System.Drawing.Size(389, 479);
            this.leftPanelTable.TabIndex = 0;
            // 
            // labelReglas
            // 
            this.labelReglas.AutoSize = true;
            this.labelReglas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReglas.Location = new System.Drawing.Point(3, 0);
            this.labelReglas.Name = "labelReglas";
            this.labelReglas.Padding = new System.Windows.Forms.Padding(3);
            this.labelReglas.Size = new System.Drawing.Size(262, 21);
            this.labelReglas.TabIndex = 0;
            this.labelReglas.Text = "Reglas de Reemplazo (añade filas aquí):";
            // 
            // dgvReglas
            // 
            this.dgvReglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReglas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReglas.Location = new System.Drawing.Point(3, 24);
            this.dgvReglas.Name = "dgvReglas";
            this.dgvReglas.RowTemplate.Height = 25;
            this.dgvReglas.Size = new System.Drawing.Size(383, 452);
            this.dgvReglas.TabIndex = 1;
            // 
            // rightPanelTable
            // 
            this.rightPanelTable.ColumnCount = 1;
            this.rightPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanelTable.Controls.Add(this.labelPreview, 0, 0);
            this.rightPanelTable.Controls.Add(this.tvPreview, 0, 1);
            this.rightPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelTable.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTable.Name = "rightPanelTable";
            this.rightPanelTable.RowCount = 2;
            this.rightPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rightPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanelTable.Size = new System.Drawing.Size(385, 479);
            this.rightPanelTable.TabIndex = 0;
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreview.Location = new System.Drawing.Point(3, 0);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Padding = new System.Windows.Forms.Padding(3);
            this.labelPreview.Size = new System.Drawing.Size(222, 21);
            this.labelPreview.TabIndex = 0;
            this.labelPreview.Text = "Vista Previa (cómo va a quedar):";
            // 
            // tvPreview
            // 
            this.tvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPreview.Location = new System.Drawing.Point(3, 24);
            this.tvPreview.Name = "tvPreview";
            this.tvPreview.Size = new System.Drawing.Size(379, 452);
            this.tvPreview.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(3, 529);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(778, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "3. Actualizar y Comprimir";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Actualizador de Plantillas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.topButtonsPanel.ResumeLayout(false);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.leftPanelTable.ResumeLayout(false);
            this.leftPanelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReglas)).EndInit();
            this.rightPanelTable.ResumeLayout(false);
            this.rightPanelTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel topButtonsPanel;
        private System.Windows.Forms.Button btnCargarZip;
        private System.Windows.Forms.Button btnRutaSalida;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.TableLayoutPanel leftPanelTable;
        private System.Windows.Forms.Label labelReglas;
        private System.Windows.Forms.DataGridView dgvReglas;
        private System.Windows.Forms.TableLayoutPanel rightPanelTable;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.TreeView tvPreview;
        private System.Windows.Forms.Button btnActualizar;
    }
}