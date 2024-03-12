namespace Tugas3
{
    partial class akumati
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxuse = new System.Windows.Forms.TextBox();
            this.tbxpas = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxuang = new System.Windows.Forms.TextBox();
            this.btnwit = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "UC Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tbxuse
            // 
            this.tbxuse.Location = new System.Drawing.Point(115, 109);
            this.tbxuse.Name = "tbxuse";
            this.tbxuse.Size = new System.Drawing.Size(221, 19);
            this.tbxuse.TabIndex = 4;
            this.tbxuse.TextChanged += new System.EventHandler(this.tbxuse_TextChanged);
            // 
            // tbxpas
            // 
            this.tbxpas.Location = new System.Drawing.Point(115, 149);
            this.tbxpas.Name = "tbxpas";
            this.tbxpas.Size = new System.Drawing.Size(221, 19);
            this.tbxpas.TabIndex = 5;
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(12, 188);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(90, 23);
            this.btnlog.TabIndex = 6;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(12, 217);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(90, 23);
            this.btnreg.TabIndex = 7;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxuang);
            this.panel1.Controls.Add(this.btnwit);
            this.panel1.Controls.Add(this.btndep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 173);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(236, 14);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(90, 23);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please enter the amount";
            this.label5.Visible = false;
            // 
            // tbxuang
            // 
            this.tbxuang.Location = new System.Drawing.Point(19, 81);
            this.tbxuang.Name = "tbxuang";
            this.tbxuang.Size = new System.Drawing.Size(221, 19);
            this.tbxuang.TabIndex = 9;
            this.tbxuang.Visible = false;
            // 
            // btnwit
            // 
            this.btnwit.Location = new System.Drawing.Point(19, 135);
            this.btnwit.Name = "btnwit";
            this.btnwit.Size = new System.Drawing.Size(90, 23);
            this.btnwit.TabIndex = 9;
            this.btnwit.Text = "Withdraw";
            this.btnwit.UseVisualStyleBackColor = true;
            this.btnwit.Click += new System.EventHandler(this.btnwit_Click);
            // 
            // btndep
            // 
            this.btndep.Location = new System.Drawing.Point(19, 106);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(90, 23);
            this.btndep.TabIndex = 9;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = true;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Balance :";
            // 
            // akumati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.tbxpas);
            this.Controls.Add(this.tbxuse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "akumati";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxuse;
        private System.Windows.Forms.TextBox tbxpas;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxuang;
        private System.Windows.Forms.Button btnwit;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogout;
    }
}

