namespace Gyak02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_caluclate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_c = new System.Windows.Forms.TextBox();
            this.label_k = new System.Windows.Forms.Label();
            this.btn_click = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "C* to K converter";
            // 
            // btn_caluclate
            // 
            this.btn_caluclate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_caluclate.Location = new System.Drawing.Point(33, 258);
            this.btn_caluclate.Name = "btn_caluclate";
            this.btn_caluclate.Size = new System.Drawing.Size(196, 109);
            this.btn_caluclate.TabIndex = 1;
            this.btn_caluclate.Text = "Calculate";
            this.btn_caluclate.UseVisualStyleBackColor = false;
            this.btn_caluclate.Click += new System.EventHandler(this.btn_caluclate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "C* celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "K (Kelvin)";
            // 
            // textbox_c
            // 
            this.textbox_c.Location = new System.Drawing.Point(152, 109);
            this.textbox_c.Name = "textbox_c";
            this.textbox_c.Size = new System.Drawing.Size(125, 27);
            this.textbox_c.TabIndex = 4;
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Location = new System.Drawing.Point(152, 176);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(0, 20);
            this.label_k.TabIndex = 5;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(326, 27);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(94, 29);
            this.btn_click.TabIndex = 6;
            this.btn_click.Text = "Hello";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(460, 31);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(0, 20);
            this.lbl_hello.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.textbox_c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_caluclate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kelvin converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_caluclate;
        private Label label2;
        private Label label3;
        private TextBox textbox_c;
        private Label label_k;
        private Button btn_click;
        private Label lbl_hello;
    }
}