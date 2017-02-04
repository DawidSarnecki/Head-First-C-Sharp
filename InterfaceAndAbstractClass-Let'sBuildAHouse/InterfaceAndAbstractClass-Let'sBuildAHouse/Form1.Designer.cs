namespace InterfaceAndAbstractClass_Let_sBuildAHouse
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
            this.descriptionWindow = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.GoThroughTheDoor = new System.Windows.Forms.Button();
            this.exitsList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionWindow
            // 
            this.descriptionWindow.Location = new System.Drawing.Point(13, 11);
            this.descriptionWindow.Multiline = true;
            this.descriptionWindow.Name = "descriptionWindow";
            this.descriptionWindow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionWindow.Size = new System.Drawing.Size(689, 251);
            this.descriptionWindow.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(22, 279);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(234, 35);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go Here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // GoThroughTheDoor
            // 
            this.GoThroughTheDoor.Location = new System.Drawing.Point(222, 347);
            this.GoThroughTheDoor.Name = "GoThroughTheDoor";
            this.GoThroughTheDoor.Size = new System.Drawing.Size(334, 42);
            this.GoThroughTheDoor.TabIndex = 2;
            this.GoThroughTheDoor.Text = "Go through the door";
            this.GoThroughTheDoor.UseVisualStyleBackColor = true;
            this.GoThroughTheDoor.Click += new System.EventHandler(this.GoThroughTheDoor_Click);
            // 
            // exitsList
            // 
            this.exitsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitsList.FormattingEnabled = true;
            this.exitsList.Location = new System.Drawing.Point(302, 285);
            this.exitsList.Name = "exitsList";
            this.exitsList.Size = new System.Drawing.Size(350, 24);
            this.exitsList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 410);
            this.Controls.Add(this.exitsList);
            this.Controls.Add(this.GoThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.descriptionWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionWindow;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button GoThroughTheDoor;
        private System.Windows.Forms.ComboBox exitsList;
    }
}

