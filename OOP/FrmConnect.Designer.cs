namespace OOP
{
    partial class FrmConnect
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
            this.TxtServer = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtDb = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtPort = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.TxtPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtServer
            // 
            this.TxtServer.AnimateReadOnly = false;
            this.TxtServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtServer.Depth = 0;
            this.TxtServer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtServer.HideSelection = true;
            this.TxtServer.Hint = "Enter Server (localhost or 192.168.x.x)";
            this.TxtServer.LeadingIcon = null;
            this.TxtServer.Location = new System.Drawing.Point(360, 100);
            this.TxtServer.MaxLength = 32767;
            this.TxtServer.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.PasswordChar = '\0';
            this.TxtServer.PrefixSuffixText = null;
            this.TxtServer.ReadOnly = false;
            this.TxtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtServer.SelectedText = "";
            this.TxtServer.SelectionLength = 0;
            this.TxtServer.SelectionStart = 0;
            this.TxtServer.ShortcutsEnabled = true;
            this.TxtServer.Size = new System.Drawing.Size(357, 48);
            this.TxtServer.TabIndex = 0;
            this.TxtServer.TabStop = false;
            this.TxtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtServer.TrailingIcon = null;
            this.TxtServer.UseSystemPasswordChar = false;
            // 
            // TxtDb
            // 
            this.TxtDb.AnimateReadOnly = false;
            this.TxtDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDb.Depth = 0;
            this.TxtDb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDb.HideSelection = true;
            this.TxtDb.Hint = "Enter Database name";
            this.TxtDb.LeadingIcon = null;
            this.TxtDb.Location = new System.Drawing.Point(360, 172);
            this.TxtDb.MaxLength = 32767;
            this.TxtDb.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDb.Name = "TxtDb";
            this.TxtDb.PasswordChar = '\0';
            this.TxtDb.PrefixSuffixText = null;
            this.TxtDb.ReadOnly = false;
            this.TxtDb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDb.SelectedText = "";
            this.TxtDb.SelectionLength = 0;
            this.TxtDb.SelectionStart = 0;
            this.TxtDb.ShortcutsEnabled = true;
            this.TxtDb.Size = new System.Drawing.Size(357, 48);
            this.TxtDb.TabIndex = 1;
            this.TxtDb.TabStop = false;
            this.TxtDb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDb.TrailingIcon = null;
            this.TxtDb.UseSystemPasswordChar = false;
            // 
            // TxtPort
            // 
            this.TxtPort.AnimateReadOnly = false;
            this.TxtPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPort.Depth = 0;
            this.TxtPort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPort.HideSelection = true;
            this.TxtPort.Hint = "Enter Port (e.g. 3306, etc)";
            this.TxtPort.LeadingIcon = null;
            this.TxtPort.Location = new System.Drawing.Point(360, 248);
            this.TxtPort.MaxLength = 32767;
            this.TxtPort.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.PasswordChar = '\0';
            this.TxtPort.PrefixSuffixText = null;
            this.TxtPort.ReadOnly = false;
            this.TxtPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPort.SelectedText = "";
            this.TxtPort.SelectionLength = 0;
            this.TxtPort.SelectionStart = 0;
            this.TxtPort.ShortcutsEnabled = true;
            this.TxtPort.Size = new System.Drawing.Size(357, 48);
            this.TxtPort.TabIndex = 2;
            this.TxtPort.TabStop = false;
            this.TxtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPort.TrailingIcon = null;
            this.TxtPort.UseSystemPasswordChar = false;
            // 
            // TxtUser
            // 
            this.TxtUser.AnimateReadOnly = false;
            this.TxtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUser.Depth = 0;
            this.TxtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUser.HideSelection = true;
            this.TxtUser.Hint = "Enter Username (e.g. root, etc.)";
            this.TxtUser.LeadingIcon = null;
            this.TxtUser.Location = new System.Drawing.Point(360, 327);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.PrefixSuffixText = null;
            this.TxtUser.ReadOnly = false;
            this.TxtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUser.SelectedText = "";
            this.TxtUser.SelectionLength = 0;
            this.TxtUser.SelectionStart = 0;
            this.TxtUser.ShortcutsEnabled = true;
            this.TxtUser.Size = new System.Drawing.Size(357, 48);
            this.TxtUser.TabIndex = 3;
            this.TxtUser.TabStop = false;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUser.TrailingIcon = null;
            this.TxtUser.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(361, 467);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(433, 467);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(200, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Connect to Localhost";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(641, 467);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(77, 36);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "Cancel";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // TxtPass
            // 
            this.TxtPass.AnimateReadOnly = false;
            this.TxtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPass.Depth = 0;
            this.TxtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPass.HideSelection = true;
            this.TxtPass.Hint = "Enter password ...";
            this.TxtPass.LeadingIcon = null;
            this.TxtPass.Location = new System.Drawing.Point(360, 398);
            this.TxtPass.MaxLength = 32767;
            this.TxtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '\0';
            this.TxtPass.PrefixSuffixText = null;
            this.TxtPass.ReadOnly = false;
            this.TxtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPass.SelectedText = "";
            this.TxtPass.SelectionLength = 0;
            this.TxtPass.SelectionStart = 0;
            this.TxtPass.ShortcutsEnabled = true;
            this.TxtPass.Size = new System.Drawing.Size(357, 48);
            this.TxtPass.TabIndex = 7;
            this.TxtPass.TabStop = false;
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPass.TrailingIcon = null;
            this.TxtPass.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 518);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtDb);
            this.Controls.Add(this.TxtServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to your Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnect_FormClosing);
            this.Load += new System.EventHandler(this.FrmConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TxtServer;
        private MaterialSkin.Controls.MaterialTextBox2 TxtDb;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPort;
        private MaterialSkin.Controls.MaterialTextBox2 TxtUser;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}