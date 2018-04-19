namespace Tapp
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.CmdClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.CmdBattery = new System.Windows.Forms.Button();
            this.CmdClimate = new System.Windows.Forms.Button();
            this.CmdLocation = new System.Windows.Forms.Button();
            this.CmdSettings = new System.Windows.Forms.Button();
            this.CmdLogout = new System.Windows.Forms.Button();
            this.Flashlights = new System.Windows.Forms.Button();
            this.vehicleImage = new System.Windows.Forms.PictureBox();
            this.CmdHomelink = new System.Windows.Forms.Button();
            this.CmdHorn = new System.Windows.Forms.Button();
            this.CmdChargePort = new System.Windows.Forms.Button();
            this.CmdDoorLocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.Brown;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.Location = new System.Drawing.Point(35, 402);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(22, 33);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "☓";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "—";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CmdHome
            // 
            this.CmdHome.BackColor = System.Drawing.Color.Gray;
            this.CmdHome.FlatAppearance.BorderSize = 0;
            this.CmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdHome.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHome.Location = new System.Drawing.Point(0, 0);
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(175, 50);
            this.CmdHome.TabIndex = 3;
            this.CmdHome.Text = "Home";
            this.CmdHome.UseVisualStyleBackColor = false;
            this.CmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // CmdBattery
            // 
            this.CmdBattery.BackColor = System.Drawing.Color.Gray;
            this.CmdBattery.Enabled = false;
            this.CmdBattery.FlatAppearance.BorderSize = 0;
            this.CmdBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBattery.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdBattery.Location = new System.Drawing.Point(0, 56);
            this.CmdBattery.Name = "CmdBattery";
            this.CmdBattery.Size = new System.Drawing.Size(175, 50);
            this.CmdBattery.TabIndex = 4;
            this.CmdBattery.Text = "Battery";
            this.CmdBattery.UseVisualStyleBackColor = false;
            this.CmdBattery.Click += new System.EventHandler(this.CmdBattery_Click);
            // 
            // CmdClimate
            // 
            this.CmdClimate.BackColor = System.Drawing.Color.Gray;
            this.CmdClimate.Enabled = false;
            this.CmdClimate.FlatAppearance.BorderSize = 0;
            this.CmdClimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClimate.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClimate.Location = new System.Drawing.Point(0, 112);
            this.CmdClimate.Name = "CmdClimate";
            this.CmdClimate.Size = new System.Drawing.Size(175, 50);
            this.CmdClimate.TabIndex = 5;
            this.CmdClimate.Text = "Climate";
            this.CmdClimate.UseVisualStyleBackColor = false;
            this.CmdClimate.Click += new System.EventHandler(this.CmdClimate_Click);
            // 
            // CmdLocation
            // 
            this.CmdLocation.BackColor = System.Drawing.Color.Gray;
            this.CmdLocation.Enabled = false;
            this.CmdLocation.FlatAppearance.BorderSize = 0;
            this.CmdLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLocation.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLocation.Location = new System.Drawing.Point(0, 168);
            this.CmdLocation.Name = "CmdLocation";
            this.CmdLocation.Size = new System.Drawing.Size(175, 50);
            this.CmdLocation.TabIndex = 6;
            this.CmdLocation.Text = "Location";
            this.CmdLocation.UseVisualStyleBackColor = false;
            this.CmdLocation.Click += new System.EventHandler(this.CmdLocation_Click);
            // 
            // CmdSettings
            // 
            this.CmdSettings.BackColor = System.Drawing.Color.Gray;
            this.CmdSettings.FlatAppearance.BorderSize = 0;
            this.CmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSettings.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSettings.Location = new System.Drawing.Point(0, 224);
            this.CmdSettings.Name = "CmdSettings";
            this.CmdSettings.Size = new System.Drawing.Size(175, 50);
            this.CmdSettings.TabIndex = 7;
            this.CmdSettings.Text = "Settings";
            this.CmdSettings.UseVisualStyleBackColor = false;
            this.CmdSettings.Click += new System.EventHandler(this.CmdSettings_Click);
            // 
            // CmdLogout
            // 
            this.CmdLogout.BackColor = System.Drawing.Color.Gray;
            this.CmdLogout.FlatAppearance.BorderSize = 0;
            this.CmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLogout.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLogout.Location = new System.Drawing.Point(0, 347);
            this.CmdLogout.Name = "CmdLogout";
            this.CmdLogout.Size = new System.Drawing.Size(175, 50);
            this.CmdLogout.TabIndex = 8;
            this.CmdLogout.Text = "Logout";
            this.CmdLogout.UseVisualStyleBackColor = false;
            this.CmdLogout.Click += new System.EventHandler(this.CmdLogout_Click);
            // 
            // Flashlights
            // 
            this.Flashlights.Location = new System.Drawing.Point(195, 215);
            this.Flashlights.Name = "Flashlights";
            this.Flashlights.Size = new System.Drawing.Size(96, 23);
            this.Flashlights.TabIndex = 9;
            this.Flashlights.Text = "Flash Headlamps";
            this.Flashlights.UseVisualStyleBackColor = true;
            this.Flashlights.Click += new System.EventHandler(this.Flashlights_Click);
            // 
            // vehicleImage
            // 
            this.vehicleImage.Location = new System.Drawing.Point(181, 0);
            this.vehicleImage.Name = "vehicleImage";
            this.vehicleImage.Size = new System.Drawing.Size(557, 190);
            this.vehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehicleImage.TabIndex = 10;
            this.vehicleImage.TabStop = false;
            // 
            // CmdHomelink
            // 
            this.CmdHomelink.Location = new System.Drawing.Point(181, 167);
            this.CmdHomelink.Name = "CmdHomelink";
            this.CmdHomelink.Size = new System.Drawing.Size(101, 23);
            this.CmdHomelink.TabIndex = 11;
            this.CmdHomelink.Text = "Trigger Homelink";
            this.CmdHomelink.UseVisualStyleBackColor = true;
            this.CmdHomelink.Visible = false;
            // 
            // CmdHorn
            // 
            this.CmdHorn.Location = new System.Drawing.Point(408, 215);
            this.CmdHorn.Name = "CmdHorn";
            this.CmdHorn.Size = new System.Drawing.Size(96, 23);
            this.CmdHorn.TabIndex = 12;
            this.CmdHorn.Text = "Honk Horn";
            this.CmdHorn.UseVisualStyleBackColor = true;
            this.CmdHorn.Click += new System.EventHandler(this.CmdHorn_Click);
            // 
            // CmdChargePort
            // 
            this.CmdChargePort.Location = new System.Drawing.Point(626, 215);
            this.CmdChargePort.Name = "CmdChargePort";
            this.CmdChargePort.Size = new System.Drawing.Size(112, 23);
            this.CmdChargePort.TabIndex = 13;
            this.CmdChargePort.Text = "Open Charge Port";
            this.CmdChargePort.UseVisualStyleBackColor = true;
            this.CmdChargePort.Click += new System.EventHandler(this.CmdChargePort_Click);
            // 
            // CmdDoorLocks
            // 
            this.CmdDoorLocks.Location = new System.Drawing.Point(508, 215);
            this.CmdDoorLocks.Name = "CmdDoorLocks";
            this.CmdDoorLocks.Size = new System.Drawing.Size(112, 23);
            this.CmdDoorLocks.TabIndex = 14;
            this.CmdDoorLocks.Text = "Unlock";
            this.CmdDoorLocks.UseVisualStyleBackColor = true;
            this.CmdDoorLocks.Click += new System.EventHandler(this.CmdDoorLocks_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(750, 446);
            this.ControlBox = false;
            this.Controls.Add(this.CmdDoorLocks);
            this.Controls.Add(this.CmdChargePort);
            this.Controls.Add(this.CmdHorn);
            this.Controls.Add(this.CmdHomelink);
            this.Controls.Add(this.vehicleImage);
            this.Controls.Add(this.Flashlights);
            this.Controls.Add(this.CmdLogout);
            this.Controls.Add(this.CmdSettings);
            this.Controls.Add(this.CmdLocation);
            this.Controls.Add(this.CmdClimate);
            this.Controls.Add(this.CmdBattery);
            this.Controls.Add(this.CmdHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "-";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Shown += new System.EventHandler(this.MainView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmdHome;
        private System.Windows.Forms.Button CmdBattery;
        private System.Windows.Forms.Button CmdClimate;
        private System.Windows.Forms.Button CmdLocation;
        private System.Windows.Forms.Button CmdSettings;
        private System.Windows.Forms.Button CmdLogout;
        private System.Windows.Forms.Button Flashlights;
        private System.Windows.Forms.PictureBox vehicleImage;
        private System.Windows.Forms.Button CmdHomelink;
        private System.Windows.Forms.Button CmdHorn;
        private System.Windows.Forms.Button CmdChargePort;
        private System.Windows.Forms.Button CmdDoorLocks;
    }
}

