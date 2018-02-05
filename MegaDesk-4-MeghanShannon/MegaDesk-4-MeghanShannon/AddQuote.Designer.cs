namespace MegaDesk_3_MeghanShannon
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.deskWidthTB = new System.Windows.Forms.TextBox();
            this.deskDepthTB = new System.Windows.Forms.TextBox();
            this.drawerNumCB = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialCB = new System.Windows.Forms.ComboBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Submit = new System.Windows.Forms.Button();
            this.rushNoneRadio = new System.Windows.Forms.RadioButton();
            this.rushThreeRadio = new System.Windows.Forms.RadioButton();
            this.rushFiveRadio = new System.Windows.Forms.RadioButton();
            this.rushSevenRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(481, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(107, 32);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desk Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(46, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desk Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(47, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(47, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(431, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rush Order:";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(251, 58);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(237, 22);
            this.customerNameTB.TabIndex = 7;
            // 
            // deskWidthTB
            // 
            this.deskWidthTB.Location = new System.Drawing.Point(251, 106);
            this.deskWidthTB.Name = "deskWidthTB";
            this.deskWidthTB.Size = new System.Drawing.Size(121, 22);
            this.deskWidthTB.TabIndex = 8;
            this.deskWidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            this.deskWidthTB.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthTB_Validating);
            // 
            // deskDepthTB
            // 
            this.deskDepthTB.Location = new System.Drawing.Point(251, 151);
            this.deskDepthTB.Name = "deskDepthTB";
            this.deskDepthTB.Size = new System.Drawing.Size(121, 22);
            this.deskDepthTB.TabIndex = 9;
            this.deskDepthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            this.deskDepthTB.Validating += new System.ComponentModel.CancelEventHandler(this.deskDepthTB_Validating);
            // 
            // drawerNumCB
            // 
            this.drawerNumCB.FormattingEnabled = true;
            this.drawerNumCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerNumCB.Location = new System.Drawing.Point(251, 199);
            this.drawerNumCB.Name = "drawerNumCB";
            this.drawerNumCB.Size = new System.Drawing.Size(121, 24);
            this.drawerNumCB.TabIndex = 10;
            // 
            // surfaceMaterialCB
            // 
            this.surfaceMaterialCB.FormattingEnabled = true;
            this.surfaceMaterialCB.Location = new System.Drawing.Point(251, 248);
            this.surfaceMaterialCB.Name = "surfaceMaterialCB";
            this.surfaceMaterialCB.Size = new System.Drawing.Size(121, 24);
            this.surfaceMaterialCB.TabIndex = 11;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(51, 12);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Submit.Location = new System.Drawing.Point(481, 326);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 32);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.AddDeskButton_Click);
            this.Submit.Validating += new System.ComponentModel.CancelEventHandler(this.deskDepthTB_Validating);
            // 
            // rushNoneRadio
            // 
            this.rushNoneRadio.AutoSize = true;
            this.rushNoneRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushNoneRadio.Location = new System.Drawing.Point(436, 142);
            this.rushNoneRadio.Name = "rushNoneRadio";
            this.rushNoneRadio.Size = new System.Drawing.Size(80, 29);
            this.rushNoneRadio.TabIndex = 15;
            this.rushNoneRadio.TabStop = true;
            this.rushNoneRadio.Text = "None";
            this.rushNoneRadio.UseVisualStyleBackColor = true;
            // 
            // rushThreeRadio
            // 
            this.rushThreeRadio.AutoSize = true;
            this.rushThreeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushThreeRadio.Location = new System.Drawing.Point(436, 177);
            this.rushThreeRadio.Name = "rushThreeRadio";
            this.rushThreeRadio.Size = new System.Drawing.Size(94, 29);
            this.rushThreeRadio.TabIndex = 16;
            this.rushThreeRadio.TabStop = true;
            this.rushThreeRadio.Text = "3 Days";
            this.rushThreeRadio.UseVisualStyleBackColor = true;
            // 
            // rushFiveRadio
            // 
            this.rushFiveRadio.AutoSize = true;
            this.rushFiveRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushFiveRadio.Location = new System.Drawing.Point(436, 212);
            this.rushFiveRadio.Name = "rushFiveRadio";
            this.rushFiveRadio.Size = new System.Drawing.Size(94, 29);
            this.rushFiveRadio.TabIndex = 17;
            this.rushFiveRadio.TabStop = true;
            this.rushFiveRadio.Text = "5 Days";
            this.rushFiveRadio.UseVisualStyleBackColor = true;
            // 
            // rushSevenRadio
            // 
            this.rushSevenRadio.AutoSize = true;
            this.rushSevenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushSevenRadio.Location = new System.Drawing.Point(436, 247);
            this.rushSevenRadio.Name = "rushSevenRadio";
            this.rushSevenRadio.Size = new System.Drawing.Size(94, 29);
            this.rushSevenRadio.TabIndex = 18;
            this.rushSevenRadio.TabStop = true;
            this.rushSevenRadio.Text = "7 Days";
            this.rushSevenRadio.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.rushSevenRadio);
            this.Controls.Add(this.rushFiveRadio);
            this.Controls.Add(this.rushThreeRadio);
            this.Controls.Add(this.rushNoneRadio);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.surfaceMaterialCB);
            this.Controls.Add(this.drawerNumCB);
            this.Controls.Add(this.deskDepthTB);
            this.Controls.Add(this.deskWidthTB);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.TextBox deskWidthTB;
        private System.Windows.Forms.TextBox deskDepthTB;
        private System.Windows.Forms.ComboBox drawerNumCB;
        private System.Windows.Forms.ComboBox surfaceMaterialCB;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton rushSevenRadio;
        private System.Windows.Forms.RadioButton rushFiveRadio;
        private System.Windows.Forms.RadioButton rushThreeRadio;
        private System.Windows.Forms.RadioButton rushNoneRadio;
    }
}