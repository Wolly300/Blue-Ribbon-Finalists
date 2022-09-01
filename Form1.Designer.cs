namespace Blue_Ribbon_Finalists
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picRibbon = new System.Windows.Forms.PictureBox();
            this.lblNumberOfEntries = new System.Windows.Forms.Label();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.lblNumberOfEntriesValue = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblPreperationTime = new System.Windows.Forms.Label();
            this.lblPreperationTimeValue = new System.Windows.Forms.Label();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblEntryNameValue = new System.Windows.Forms.Label();
            this.lblStateValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRibbon)).BeginInit();
            this.SuspendLayout();
            // 
            // picRibbon
            // 
            resources.ApplyResources(this.picRibbon, "picRibbon");
            this.picRibbon.Name = "picRibbon";
            this.picRibbon.TabStop = false;
            // 
            // lblNumberOfEntries
            // 
            resources.ApplyResources(this.lblNumberOfEntries, "lblNumberOfEntries");
            this.lblNumberOfEntries.Name = "lblNumberOfEntries";
            // 
            // lblEntryName
            // 
            resources.ApplyResources(this.lblEntryName, "lblEntryName");
            this.lblEntryName.Name = "lblEntryName";
            // 
            // lblNumberOfEntriesValue
            // 
            resources.ApplyResources(this.lblNumberOfEntriesValue, "lblNumberOfEntriesValue");
            this.lblNumberOfEntriesValue.Name = "lblNumberOfEntriesValue";
            // 
            // lblState
            // 
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.Name = "lblState";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // lblCategoryValue
            // 
            resources.ApplyResources(this.lblCategoryValue, "lblCategoryValue");
            this.lblCategoryValue.Name = "lblCategoryValue";
            // 
            // lblPreperationTime
            // 
            resources.ApplyResources(this.lblPreperationTime, "lblPreperationTime");
            this.lblPreperationTime.Name = "lblPreperationTime";
            // 
            // lblPreperationTimeValue
            // 
            resources.ApplyResources(this.lblPreperationTimeValue, "lblPreperationTimeValue");
            this.lblPreperationTimeValue.Name = "lblPreperationTimeValue";
            // 
            // btnBefore
            // 
            resources.ApplyResources(this.btnBefore, "btnBefore");
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblEntryNameValue
            // 
            resources.ApplyResources(this.lblEntryNameValue, "lblEntryNameValue");
            this.lblEntryNameValue.Name = "lblEntryNameValue";
            // 
            // lblStateValue
            // 
            resources.ApplyResources(this.lblStateValue, "lblStateValue");
            this.lblStateValue.Name = "lblStateValue";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.lblPreperationTimeValue);
            this.Controls.Add(this.lblPreperationTime);
            this.Controls.Add(this.lblCategoryValue);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblStateValue);
            this.Controls.Add(this.lblEntryName);
            this.Controls.Add(this.lblEntryNameValue);
            this.Controls.Add(this.lblNumberOfEntries);
            this.Controls.Add(this.lblNumberOfEntriesValue);
            this.Controls.Add(this.picRibbon);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRibbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberOfEntries;
        private System.Windows.Forms.Label lblNumberOfEntriesValue;
        private System.Windows.Forms.Label lblEntryName;
        private System.Windows.Forms.Label lblEntryNameValue;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStateValue;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblPreperationTime;
        private System.Windows.Forms.Label lblPreperationTimeValue;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAbout;
        protected internal System.Windows.Forms.PictureBox picRibbon;
    }
}

