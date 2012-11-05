namespace resourceCalculator
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
            this.items = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.required = new System.Windows.Forms.ListBox();
            this.ammount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ammount)).BeginInit();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.Location = new System.Drawing.Point(12, 12);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(118, 251);
            this.items.Sorted = true;
            this.items.TabIndex = 0;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Wasco Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(136, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(58, 20);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.required);
            this.panel1.Location = new System.Drawing.Point(139, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 206);
            this.panel1.TabIndex = 3;
            // 
            // required
            // 
            this.required.FormattingEnabled = true;
            this.required.Location = new System.Drawing.Point(3, 7);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(282, 199);
            this.required.Sorted = true;
            this.required.TabIndex = 0;
            // 
            // ammount
            // 
            this.ammount.Location = new System.Drawing.Point(142, 35);
            this.ammount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(100, 20);
            this.ammount.TabIndex = 4;
            this.ammount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ammount.ValueChanged += new System.EventHandler(this.ammount_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.items);
            this.Name = "Form1";
            this.Text = "Resource Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ammount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox required;
        private System.Windows.Forms.NumericUpDown ammount;
        private System.Windows.Forms.Button button1;
    }
}

