namespace FBAppUI
{
    partial class ClosestEventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosestEventsForm));
            this.DataGridCloseEvents = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendingAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonLocationEvents = new System.Windows.Forms.Button();
            this.ButtonHometownEvents = new System.Windows.Forms.Button();
            this.ButtonBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCloseEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCloseEvents
            // 
            this.DataGridCloseEvents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridCloseEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCloseEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.EventOwner,
            this.AttendingAmmount,
            this.EventTime,
            this.EventDescription});
            this.DataGridCloseEvents.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridCloseEvents.Location = new System.Drawing.Point(221, 25);
            this.DataGridCloseEvents.Name = "DataGridCloseEvents";
            this.DataGridCloseEvents.ReadOnly = true;
            this.DataGridCloseEvents.Size = new System.Drawing.Size(644, 390);
            this.DataGridCloseEvents.TabIndex = 0;
            this.DataGridCloseEvents.Visible = false;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 130;
            // 
            // EventOwner
            // 
            this.EventOwner.HeaderText = "Event Owner";
            this.EventOwner.Name = "EventOwner";
            this.EventOwner.ReadOnly = true;
            // 
            // AttendingAmmount
            // 
            this.AttendingAmmount.HeaderText = "Number Attending";
            this.AttendingAmmount.Name = "AttendingAmmount";
            this.AttendingAmmount.ReadOnly = true;
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "Time Of Event";
            this.EventTime.Name = "EventTime";
            this.EventTime.ReadOnly = true;
            // 
            // EventDescription
            // 
            this.EventDescription.HeaderText = "Description";
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.ReadOnly = true;
            this.EventDescription.Width = 200;
            // 
            // ButtonLocationEvents
            // 
            this.ButtonLocationEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonLocationEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLocationEvents.Location = new System.Drawing.Point(12, 25);
            this.ButtonLocationEvents.Name = "ButtonLocationEvents";
            this.ButtonLocationEvents.Size = new System.Drawing.Size(191, 99);
            this.ButtonLocationEvents.TabIndex = 1;
            this.ButtonLocationEvents.Text = "Events At My Location";
            this.ButtonLocationEvents.UseVisualStyleBackColor = false;
            this.ButtonLocationEvents.Click += new System.EventHandler(this.ButtonLocationEvents_Click);
            // 
            // ButtonHometownEvents
            // 
            this.ButtonHometownEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonHometownEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHometownEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHometownEvents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHometownEvents.Location = new System.Drawing.Point(12, 316);
            this.ButtonHometownEvents.Name = "ButtonHometownEvents";
            this.ButtonHometownEvents.Size = new System.Drawing.Size(191, 99);
            this.ButtonHometownEvents.TabIndex = 2;
            this.ButtonHometownEvents.Text = "Events At My Hometown";
            this.ButtonHometownEvents.UseVisualStyleBackColor = false;
            this.ButtonHometownEvents.Click += new System.EventHandler(this.ButtonHometownEvents_Click);
            // 
            // ButtonBackToMain
            // 
            this.ButtonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackToMain.Location = new System.Drawing.Point(12, 172);
            this.ButtonBackToMain.Name = "ButtonBackToMain";
            this.ButtonBackToMain.Size = new System.Drawing.Size(191, 99);
            this.ButtonBackToMain.TabIndex = 3;
            this.ButtonBackToMain.Text = "Back To Main";
            this.ButtonBackToMain.UseVisualStyleBackColor = false;
            this.ButtonBackToMain.Click += new System.EventHandler(this.ButtonBackToMain_Click);
            // 
            // ClosestEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.ButtonBackToMain);
            this.Controls.Add(this.ButtonHometownEvents);
            this.Controls.Add(this.ButtonLocationEvents);
            this.Controls.Add(this.DataGridCloseEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClosestEventsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Events Close To Me";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCloseEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCloseEvents;
        private System.Windows.Forms.Button ButtonLocationEvents;
        private System.Windows.Forms.Button ButtonHometownEvents;
        private System.Windows.Forms.Button ButtonBackToMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendingAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
    }
}