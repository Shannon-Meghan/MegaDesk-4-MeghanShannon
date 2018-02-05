namespace MegaDesk_3_MeghanShannon
{
    partial class SearchQuotes
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.surfaceMaterialCB = new System.Windows.Forms.ComboBox();
            this.quoteListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(568, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(130, 37);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(131, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Material Type:";
            // 
            // surfaceMaterialCB
            // 
            this.surfaceMaterialCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surfaceMaterialCB.FormattingEnabled = true;
            this.surfaceMaterialCB.Location = new System.Drawing.Point(378, 67);
            this.surfaceMaterialCB.Name = "surfaceMaterialCB";
            this.surfaceMaterialCB.Size = new System.Drawing.Size(213, 33);
            this.surfaceMaterialCB.TabIndex = 2;
            this.surfaceMaterialCB.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterialCB_SelectedIndexChanged);
            // 
            // quoteListView
            // 
            this.quoteListView.Location = new System.Drawing.Point(13, 120);
            this.quoteListView.Name = "quoteListView";
            this.quoteListView.Size = new System.Drawing.Size(685, 263);
            this.quoteListView.TabIndex = 3;
            this.quoteListView.UseCompatibleStateImageBehavior = false;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 395);
            this.Controls.Add(this.quoteListView);
            this.Controls.Add(this.surfaceMaterialCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox surfaceMaterialCB;
        private System.Windows.Forms.ListView quoteListView;
    }
}