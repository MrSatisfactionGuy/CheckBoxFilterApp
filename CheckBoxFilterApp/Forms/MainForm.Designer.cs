namespace CheckBoxFilterApp
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.labelOLV = new System.Windows.Forms.Label();
            this.labelFastOLV = new System.Windows.Forms.Label();
            this.columnButtonRenderer1 = new BrightIdeasSoftware.ColumnButtonRenderer();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.olvColumnApp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDescp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFunc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCheck = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFColumnApp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumnApp);
            this.objectListView1.AllColumns.Add(this.olvColumnDescp);
            this.objectListView1.AllColumns.Add(this.olvColumnFunc);
            this.objectListView1.AllColumns.Add(this.olvColumnDate);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnApp,
            this.olvColumnDescp,
            this.olvColumnFunc,
            this.olvColumnDate});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(12, 103);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(318, 335);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvColumnCheck);
            this.fastObjectListView1.AllColumns.Add(this.olvFColumnApp);
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnCheck,
            this.olvFColumnApp});
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(336, 103);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(230, 335);
            this.fastObjectListView1.TabIndex = 1;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            // 
            // labelOLV
            // 
            this.labelOLV.AutoSize = true;
            this.labelOLV.Location = new System.Drawing.Point(12, 87);
            this.labelOLV.Name = "labelOLV";
            this.labelOLV.Size = new System.Drawing.Size(28, 13);
            this.labelOLV.TabIndex = 2;
            this.labelOLV.Text = "OLV";
            // 
            // labelFastOLV
            // 
            this.labelFastOLV.AutoSize = true;
            this.labelFastOLV.Location = new System.Drawing.Point(333, 87);
            this.labelFastOLV.Name = "labelFastOLV";
            this.labelFastOLV.Size = new System.Drawing.Size(51, 13);
            this.labelFastOLV.TabIndex = 3;
            this.labelFastOLV.Text = "Fast OLV";
            // 
            // columnButtonRenderer1
            // 
            this.columnButtonRenderer1.ButtonPadding = new System.Drawing.Size(10, 10);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(713, 415);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // olvColumnApp
            // 
            this.olvColumnApp.AspectName = "Application";
            this.olvColumnApp.Text = "Application";
            this.olvColumnApp.Width = 80;
            // 
            // olvColumnDescp
            // 
            this.olvColumnDescp.AspectName = "Description";
            this.olvColumnDescp.Text = "Description";
            this.olvColumnDescp.Width = 80;
            // 
            // olvColumnFunc
            // 
            this.olvColumnFunc.AspectName = "Function";
            this.olvColumnFunc.Text = "Function";
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.AspectName = "CreateTime";
            this.olvColumnDate.Text = "DateTime";
            // 
            // olvColumnCheck
            // 
            this.olvColumnCheck.CheckBoxes = true;
            this.olvColumnCheck.Text = "CheckBox";
            this.olvColumnCheck.TriStateCheckBoxes = true;
            // 
            // olvFColumnApp
            // 
            this.olvFColumnApp.AspectName = "Application";
            this.olvFColumnApp.Text = "App";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelFastOLV);
            this.Controls.Add(this.labelOLV);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.objectListView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private System.Windows.Forms.Label labelOLV;
        private System.Windows.Forms.Label labelFastOLV;
        private BrightIdeasSoftware.ColumnButtonRenderer columnButtonRenderer1;
        private System.Windows.Forms.Button buttonSubmit;
        private BrightIdeasSoftware.OLVColumn olvColumnApp;
        private BrightIdeasSoftware.OLVColumn olvColumnDescp;
        private BrightIdeasSoftware.OLVColumn olvColumnFunc;
        private BrightIdeasSoftware.OLVColumn olvColumnDate;
        private BrightIdeasSoftware.OLVColumn olvColumnCheck;
        private BrightIdeasSoftware.OLVColumn olvFColumnApp;
    }
}

