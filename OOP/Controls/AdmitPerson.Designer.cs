namespace OOP.Controls
{
    partial class AdmitPerson
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
            this.SelectDoctor = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtDiagnosis = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNotes = new MaterialSkin.Controls.MaterialTextBox2();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDoctor
            // 
            this.SelectDoctor.AutoResize = false;
            this.SelectDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectDoctor.Depth = 0;
            this.SelectDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectDoctor.DropDownHeight = 174;
            this.SelectDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDoctor.DropDownWidth = 121;
            this.SelectDoctor.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectDoctor.FormattingEnabled = true;
            this.SelectDoctor.Hint = "Select Doctor of the Patient";
            this.SelectDoctor.IntegralHeight = false;
            this.SelectDoctor.ItemHeight = 43;
            this.SelectDoctor.Location = new System.Drawing.Point(30, 109);
            this.SelectDoctor.MaxDropDownItems = 4;
            this.SelectDoctor.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectDoctor.Name = "SelectDoctor";
            this.SelectDoctor.Size = new System.Drawing.Size(294, 49);
            this.SelectDoctor.StartIndex = 0;
            this.SelectDoctor.TabIndex = 0;
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.AnimateReadOnly = false;
            this.TxtDiagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDiagnosis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDiagnosis.Depth = 0;
            this.TxtDiagnosis.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDiagnosis.HideSelection = true;
            this.TxtDiagnosis.Hint = "Enter Diagnosis";
            this.TxtDiagnosis.LeadingIcon = null;
            this.TxtDiagnosis.Location = new System.Drawing.Point(30, 188);
            this.TxtDiagnosis.MaxLength = 32767;
            this.TxtDiagnosis.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.PasswordChar = '\0';
            this.TxtDiagnosis.PrefixSuffixText = null;
            this.TxtDiagnosis.ReadOnly = false;
            this.TxtDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDiagnosis.SelectedText = "";
            this.TxtDiagnosis.SelectionLength = 0;
            this.TxtDiagnosis.SelectionStart = 0;
            this.TxtDiagnosis.ShortcutsEnabled = true;
            this.TxtDiagnosis.Size = new System.Drawing.Size(294, 48);
            this.TxtDiagnosis.TabIndex = 1;
            this.TxtDiagnosis.TabStop = false;
            this.TxtDiagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDiagnosis.TrailingIcon = null;
            this.TxtDiagnosis.UseSystemPasswordChar = false;
            // 
            // TxtNotes
            // 
            this.TxtNotes.AnimateReadOnly = false;
            this.TxtNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNotes.Depth = 0;
            this.TxtNotes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNotes.HideSelection = true;
            this.TxtNotes.Hint = "Enter Notes";
            this.TxtNotes.LeadingIcon = null;
            this.TxtNotes.Location = new System.Drawing.Point(30, 269);
            this.TxtNotes.MaxLength = 32767;
            this.TxtNotes.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.PasswordChar = '\0';
            this.TxtNotes.PrefixSuffixText = null;
            this.TxtNotes.ReadOnly = false;
            this.TxtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNotes.SelectedText = "";
            this.TxtNotes.SelectionLength = 0;
            this.TxtNotes.SelectionStart = 0;
            this.TxtNotes.ShortcutsEnabled = true;
            this.TxtNotes.Size = new System.Drawing.Size(294, 48);
            this.TxtNotes.TabIndex = 2;
            this.TxtNotes.TabStop = false;
            this.TxtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNotes.TrailingIcon = null;
            this.TxtNotes.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(202, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 57);
            this.button2.TabIndex = 36;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdmitPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.SelectDoctor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdmitPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admit Person";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmitPerson_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdmitPerson_FormClosed);
            this.Load += new System.EventHandler(this.AdmitPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox SelectDoctor;
        private MaterialSkin.Controls.MaterialTextBox2 TxtDiagnosis;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNotes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}