namespace CarDealer
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.selectVehicleLbl = new System.Windows.Forms.Label();
            this.DeloreanCheckBox = new System.Windows.Forms.CheckBox();
            this.FuturaCheckBox = new System.Windows.Forms.CheckBox();
            this.D85CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectVehicleLbl
            // 
            this.selectVehicleLbl.AutoSize = true;
            this.selectVehicleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.selectVehicleLbl.Location = new System.Drawing.Point(12, 9);
            this.selectVehicleLbl.Name = "selectVehicleLbl";
            this.selectVehicleLbl.Size = new System.Drawing.Size(389, 29);
            this.selectVehicleLbl.TabIndex = 0;
            this.selectVehicleLbl.Text = "Select a vehicle from the list below ";
            this.selectVehicleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeloreanCheckBox
            // 
            this.DeloreanCheckBox.AutoSize = true;
            this.DeloreanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DeloreanCheckBox.Location = new System.Drawing.Point(34, 41);
            this.DeloreanCheckBox.Name = "DeloreanCheckBox";
            this.DeloreanCheckBox.Size = new System.Drawing.Size(287, 33);
            this.DeloreanCheckBox.TabIndex = 2;
            this.DeloreanCheckBox.Text = "DeLorean time machine";
            this.DeloreanCheckBox.UseVisualStyleBackColor = true;
            this.DeloreanCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FuturaCheckBox
            // 
            this.FuturaCheckBox.AutoSize = true;
            this.FuturaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FuturaCheckBox.Location = new System.Drawing.Point(34, 80);
            this.FuturaCheckBox.Name = "FuturaCheckBox";
            this.FuturaCheckBox.Size = new System.Drawing.Size(298, 33);
            this.FuturaCheckBox.TabIndex = 3;
            this.FuturaCheckBox.Text = "1955 Ford Lincoln Futura";
            this.FuturaCheckBox.UseVisualStyleBackColor = true;
            this.FuturaCheckBox.CheckedChanged += new System.EventHandler(this.FuturaCheckBox_CheckedChanged);
            // 
            // D85CheckBox
            // 
            this.D85CheckBox.AutoSize = true;
            this.D85CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.D85CheckBox.Location = new System.Drawing.Point(34, 119);
            this.D85CheckBox.Name = "D85CheckBox";
            this.D85CheckBox.Size = new System.Drawing.Size(216, 33);
            this.D85CheckBox.TabIndex = 4;
            this.D85CheckBox.Text = "Aston Martin DB5";
            this.D85CheckBox.UseVisualStyleBackColor = true;
            this.D85CheckBox.CheckedChanged += new System.EventHandler(this.D85CheckBox_CheckedChanged);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 616);
            this.Controls.Add(this.D85CheckBox);
            this.Controls.Add(this.FuturaCheckBox);
            this.Controls.Add(this.DeloreanCheckBox);
            this.Controls.Add(this.selectVehicleLbl);
            this.Name = "SelectionForm";
            this.Text = "DeLorean time machine";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectVehicleLbl;
        private System.Windows.Forms.CheckBox DeloreanCheckBox;
        private System.Windows.Forms.CheckBox FuturaCheckBox;
        private System.Windows.Forms.CheckBox D85CheckBox;
    }
}

