
namespace PasswordGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkCharacter = new System.Windows.Forms.CheckBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPASS = new System.Windows.Forms.Label();
            this.btnPassCopy = new System.Windows.Forms.Button();
            this.btnMD5Copy = new System.Windows.Forms.Button();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUpper);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.chkCharacter);
            this.groupBox1.Controls.Add(this.chkLower);
            this.groupBox1.Controls.Add(this.chkNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Location = new System.Drawing.Point(12, 19);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(63, 17);
            this.chkNumber.TabIndex = 0;
            this.chkNumber.Text = "Number";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(12, 65);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(78, 17);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "Lowercase";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkCharacter
            // 
            this.chkCharacter.AutoSize = true;
            this.chkCharacter.Location = new System.Drawing.Point(81, 19);
            this.chkCharacter.Name = "chkCharacter";
            this.chkCharacter.Size = new System.Drawing.Size(72, 17);
            this.chkCharacter.TabIndex = 2;
            this.chkCharacter.Text = "Character";
            this.chkCharacter.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLength.Location = new System.Drawing.Point(205, 15);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(42, 24);
            this.txtLength.TabIndex = 3;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(159, 20);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(40, 13);
            this.Length.TabIndex = 4;
            this.Length.Text = "Length";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(156, 45);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 37);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPassCopy);
            this.groupBox2.Controls.Add(this.lblPASS);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randomly Text";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMD5);
            this.groupBox3.Controls.Add(this.btnMD5Copy);
            this.groupBox3.Location = new System.Drawing.Point(12, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MD5 Text";
            // 
            // lblPASS
            // 
            this.lblPASS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPASS.Location = new System.Drawing.Point(4, 26);
            this.lblPASS.Name = "lblPASS";
            this.lblPASS.Size = new System.Drawing.Size(252, 22);
            this.lblPASS.TabIndex = 0;
            this.lblPASS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPassCopy
            // 
            this.btnPassCopy.Location = new System.Drawing.Point(12, 56);
            this.btnPassCopy.Name = "btnPassCopy";
            this.btnPassCopy.Size = new System.Drawing.Size(235, 23);
            this.btnPassCopy.TabIndex = 1;
            this.btnPassCopy.Text = "COPY";
            this.btnPassCopy.UseVisualStyleBackColor = true;
            this.btnPassCopy.Click += new System.EventHandler(this.btnPassCopy_Click);
            // 
            // btnMD5Copy
            // 
            this.btnMD5Copy.Location = new System.Drawing.Point(12, 48);
            this.btnMD5Copy.Name = "btnMD5Copy";
            this.btnMD5Copy.Size = new System.Drawing.Size(235, 25);
            this.btnMD5Copy.TabIndex = 2;
            this.btnMD5Copy.Text = "COPY";
            this.btnMD5Copy.UseVisualStyleBackColor = true;
            this.btnMD5Copy.Click += new System.EventHandler(this.btnMD5Copy_Click);
            // 
            // lblMD5
            // 
            this.lblMD5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMD5.ForeColor = System.Drawing.Color.Salmon;
            this.lblMD5.Location = new System.Drawing.Point(6, 23);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(250, 22);
            this.lblMD5.TabIndex = 2;
            this.lblMD5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(13, 291);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 3;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(12, 42);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(78, 17);
            this.chkUpper.TabIndex = 6;
            this.chkUpper.Text = "Uppercase";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 313);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.CheckBox chkCharacter;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPassCopy;
        private System.Windows.Forms.Label lblPASS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.Button btnMD5Copy;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.CheckBox chkUpper;
    }
}

