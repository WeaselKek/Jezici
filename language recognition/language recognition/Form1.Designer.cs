namespace language_recognition
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblJezik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMain.Location = new System.Drawing.Point(26, 54);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(664, 293);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(80, 369);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(542, 58);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Identify";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblJezik
            // 
            this.lblJezik.AutoSize = true;
            this.lblJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJezik.Location = new System.Drawing.Point(113, 22);
            this.lblJezik.Name = "lblJezik";
            this.lblJezik.Size = new System.Drawing.Size(51, 20);
            this.lblJezik.TabIndex = 2;
            this.lblJezik.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJezik);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.rtbMain);
            this.Name = "Form1";
            this.Text = "Language Recognition Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.Label label1;
    }
}

