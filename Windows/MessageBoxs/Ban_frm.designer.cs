namespace DevProLauncher.Windows.MessageBoxs
{
    partial class BanFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.msglabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputLbl2 = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.inputLbl1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.msglabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.41667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.58334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancelbtn);
            this.flowLayoutPanel1.Controls.Add(this.Confirmbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 116);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbtn.Location = new System.Drawing.Point(290, 4);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(88, 30);
            this.Cancelbtn.TabIndex = 1;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Location = new System.Drawing.Point(194, 4);
            this.Confirmbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(88, 30);
            this.Confirmbtn.TabIndex = 0;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // msglabel
            // 
            this.msglabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.msglabel.AutoSize = true;
            this.msglabel.Location = new System.Drawing.Point(4, 11);
            this.msglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(96, 17);
            this.msglabel.TabIndex = 0;
            this.msglabel.Text = "InputMessage";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.inputLbl2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inputBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inputLbl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 64);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // inputLbl2
            // 
            this.inputLbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLbl2.AutoSize = true;
            this.inputLbl2.Location = new System.Drawing.Point(263, 7);
            this.inputLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLbl2.Name = "inputLbl2";
            this.inputLbl2.Size = new System.Drawing.Size(47, 17);
            this.inputLbl2.TabIndex = 3;
            this.inputLbl2.Text = "Input2";
            // 
            // inputBox1
            // 
            this.inputBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputBox1.Location = new System.Drawing.Point(4, 36);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(183, 22);
            this.inputBox1.TabIndex = 1;
            // 
            // inputBox2
            // 
            this.inputBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputBox2.Location = new System.Drawing.Point(195, 36);
            this.inputBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(183, 22);
            this.inputBox2.TabIndex = 0;
            // 
            // inputLbl1
            // 
            this.inputLbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLbl1.AutoSize = true;
            this.inputLbl1.Location = new System.Drawing.Point(72, 7);
            this.inputLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputLbl1.Name = "inputLbl1";
            this.inputLbl1.Size = new System.Drawing.Size(47, 17);
            this.inputLbl1.TabIndex = 2;
            this.inputLbl1.Text = "Input1";
            // 
            // BanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(390, 155);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label msglabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Label inputLbl2;
        public System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.Label inputLbl1;
    }
}