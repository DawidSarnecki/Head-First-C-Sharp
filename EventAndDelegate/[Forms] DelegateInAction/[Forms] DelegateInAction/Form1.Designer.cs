namespace _Forms__DelegateInAction
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
            this.GetComponent = new System.Windows.Forms.Button();
            this.UseAliceDelegate = new System.Windows.Forms.Button();
            this.UseJaneDelegate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetComponent
            // 
            this.GetComponent.Location = new System.Drawing.Point(69, 60);
            this.GetComponent.Name = "GetComponent";
            this.GetComponent.Size = new System.Drawing.Size(301, 46);
            this.GetComponent.TabIndex = 0;
            this.GetComponent.Text = "Get Component";
            this.GetComponent.UseVisualStyleBackColor = false;
            this.GetComponent.Click += new System.EventHandler(this.GetComponent_Click);
            // 
            // UseAliceDelegate
            // 
            this.UseAliceDelegate.Location = new System.Drawing.Point(73, 150);
            this.UseAliceDelegate.Name = "UseAliceDelegate";
            this.UseAliceDelegate.Size = new System.Drawing.Size(296, 44);
            this.UseAliceDelegate.TabIndex = 1;
            this.UseAliceDelegate.Text = "Use Alice Delegate";
            this.UseAliceDelegate.UseVisualStyleBackColor = true;
            this.UseAliceDelegate.Click += new System.EventHandler(this.UseAliceDelegate_Click);
            // 
            // UseJaneDelegate
            // 
            this.UseJaneDelegate.Location = new System.Drawing.Point(73, 250);
            this.UseJaneDelegate.Name = "UseJaneDelegate";
            this.UseJaneDelegate.Size = new System.Drawing.Size(296, 46);
            this.UseJaneDelegate.TabIndex = 2;
            this.UseJaneDelegate.Text = "Use Jane Delegate";
            this.UseJaneDelegate.UseVisualStyleBackColor = true;
            this.UseJaneDelegate.Click += new System.EventHandler(this.UseJaneDelegate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(428, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.UseJaneDelegate);
            this.Controls.Add(this.UseAliceDelegate);
            this.Controls.Add(this.GetComponent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetComponent;
        private System.Windows.Forms.Button UseAliceDelegate;
        private System.Windows.Forms.Button UseJaneDelegate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

