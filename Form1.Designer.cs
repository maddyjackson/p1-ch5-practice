namespace DistanceCalculator
{
    partial class FormDC
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
            this.lblvehiclespeed = new System.Windows.Forms.Label();
            this.lblhourstraveled = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtboxmph = new System.Windows.Forms.TextBox();
            this.txtboxhours = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.resultlistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblvehiclespeed
            // 
            this.lblvehiclespeed.AutoSize = true;
            this.lblvehiclespeed.Location = new System.Drawing.Point(153, 73);
            this.lblvehiclespeed.Name = "lblvehiclespeed";
            this.lblvehiclespeed.Size = new System.Drawing.Size(117, 13);
            this.lblvehiclespeed.TabIndex = 0;
            this.lblvehiclespeed.Text = "Vehicle Speed in MPH:";
            // 
            // lblhourstraveled
            // 
            this.lblhourstraveled.AutoSize = true;
            this.lblhourstraveled.Location = new System.Drawing.Point(153, 130);
            this.lblhourstraveled.Name = "lblhourstraveled";
            this.lblhourstraveled.Size = new System.Drawing.Size(83, 13);
            this.lblhourstraveled.TabIndex = 1;
            this.lblhourstraveled.Text = "Hours Traveled:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(156, 327);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(182, 91);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtboxmph
            // 
            this.txtboxmph.Location = new System.Drawing.Point(412, 62);
            this.txtboxmph.Name = "txtboxmph";
            this.txtboxmph.Size = new System.Drawing.Size(223, 20);
            this.txtboxmph.TabIndex = 3;
            this.txtboxmph.TextChanged += new System.EventHandler(this.txtboxmph_TextChanged);
            // 
            // txtboxhours
            // 
            this.txtboxhours.Location = new System.Drawing.Point(412, 114);
            this.txtboxhours.Name = "txtboxhours";
            this.txtboxhours.Size = new System.Drawing.Size(223, 20);
            this.txtboxhours.TabIndex = 4;
            this.txtboxhours.TextChanged += new System.EventHandler(this.txtboxhours_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(440, 327);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(182, 91);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // resultlistbox
            // 
            this.resultlistbox.FormattingEnabled = true;
            this.resultlistbox.Location = new System.Drawing.Point(172, 167);
            this.resultlistbox.Name = "resultlistbox";
            this.resultlistbox.Size = new System.Drawing.Size(427, 134);
            this.resultlistbox.TabIndex = 8;
            this.resultlistbox.SelectedIndexChanged += new System.EventHandler(this.resultlistbox_SelectedIndexChanged);
            // 
            // FormDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlistbox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtboxhours);
            this.Controls.Add(this.txtboxmph);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblhourstraveled);
            this.Controls.Add(this.lblvehiclespeed);
            this.Name = "FormDC";
            this.Text = "Distance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvehiclespeed;
        private System.Windows.Forms.Label lblhourstraveled;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtboxmph;
        private System.Windows.Forms.TextBox txtboxhours;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox resultlistbox;
    }
}

