namespace Essai_Grand_Ordi_1
{
    partial class FormToOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Did the client already ordered at our bakery ?";
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.BackColor = System.Drawing.Color.Transparent;
            this.rdbYes.Location = new System.Drawing.Point(375, 37);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(46, 17);
            this.rdbYes.TabIndex = 1;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "YES";
            this.rdbYes.UseVisualStyleBackColor = false;
            this.rdbYes.CheckedChanged += new System.EventHandler(this.rdbYes_CheckedChanged);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbNo.Location = new System.Drawing.Point(507, 37);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(41, 17);
            this.rdbNo.TabIndex = 2;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "NO";
            this.rdbNo.UseVisualStyleBackColor = false;
            // 
            // FormToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Essai_Grand_Ordi_1.Properties.Resources.istockphoto_488010990_612x6123;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormToOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToOrder";
            this.Load += new System.EventHandler(this.FormToOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.RadioButton rdbNo;
    }
}