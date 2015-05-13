namespace TVC
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCt = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTOff = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.dtMuteTime = new System.Windows.Forms.DateTimePicker();
            this.dtUnMuteTime = new System.Windows.Forms.DateTimePicker();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.lbEnable = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblCt
            // 
            this.lblCt.AutoSize = true;
            this.lblCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCt.Location = new System.Drawing.Point(12, 9);
            this.lblCt.Name = "lblCt";
            this.lblCt.Size = new System.Drawing.Size(94, 17);
            this.lblCt.TabIndex = 2;
            this.lblCt.Text = "Current Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(116, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 3;
            // 
            // lblTOff
            // 
            this.lblTOff.AutoSize = true;
            this.lblTOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOff.Location = new System.Drawing.Point(12, 40);
            this.lblTOff.Name = "lblTOff";
            this.lblTOff.Size = new System.Drawing.Size(78, 17);
            this.lblTOff.TabIndex = 4;
            this.lblTOff.Text = "Mute Time:";
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOn.Location = new System.Drawing.Point(12, 70);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(96, 17);
            this.lblOn.TabIndex = 5;
            this.lblOn.Text = "Unmute Time:";
            // 
            // dtMuteTime
            // 
            this.dtMuteTime.CustomFormat = "hh:mm tt";
            this.dtMuteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMuteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMuteTime.Location = new System.Drawing.Point(119, 35);
            this.dtMuteTime.Name = "dtMuteTime";
            this.dtMuteTime.ShowUpDown = true;
            this.dtMuteTime.Size = new System.Drawing.Size(87, 23);
            this.dtMuteTime.TabIndex = 6;
            this.dtMuteTime.ValueChanged += new System.EventHandler(this.dtMuteTime_ValueChanged);
            // 
            // dtUnMuteTime
            // 
            this.dtUnMuteTime.CustomFormat = "hh:mm tt";
            this.dtUnMuteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUnMuteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtUnMuteTime.Location = new System.Drawing.Point(119, 70);
            this.dtUnMuteTime.Name = "dtUnMuteTime";
            this.dtUnMuteTime.ShowUpDown = true;
            this.dtUnMuteTime.Size = new System.Drawing.Size(87, 23);
            this.dtUnMuteTime.TabIndex = 7;
            this.dtUnMuteTime.ValueChanged += new System.EventHandler(this.dtUnMuteTime_ValueChanged);
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnable.Location = new System.Drawing.Point(75, 106);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(15, 14);
            this.cbEnable.TabIndex = 9;
            this.cbEnable.UseVisualStyleBackColor = true;
            this.cbEnable.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // lbEnable
            // 
            this.lbEnable.AutoSize = true;
            this.lbEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnable.Location = new System.Drawing.Point(12, 104);
            this.lbEnable.Name = "lbEnable";
            this.lbEnable.Size = new System.Drawing.Size(56, 17);
            this.lbEnable.TabIndex = 10;
            this.lbEnable.Text = "Enable:";
            // 
            // btnToggle
            // 
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(119, 102);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(87, 23);
            this.btnToggle.TabIndex = 11;
            this.btnToggle.Text = "Mute";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Click to show";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 172);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lbEnable);
            this.Controls.Add(this.cbEnable);
            this.Controls.Add(this.dtUnMuteTime);
            this.Controls.Add(this.dtMuteTime);
            this.Controls.Add(this.lblOn);
            this.Controls.Add(this.lblTOff);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "TVC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTOff;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.DateTimePicker dtMuteTime;
        private System.Windows.Forms.DateTimePicker dtUnMuteTime;
        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.Label lbEnable;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

