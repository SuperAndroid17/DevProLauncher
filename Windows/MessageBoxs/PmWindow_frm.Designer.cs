﻿using DevProLauncher.Windows.Components;
namespace DevProLauncher.Windows.MessageBoxs
{
    partial class PmWindowFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PmWindowFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChatInput = new System.Windows.Forms.TextBox();
            this.ChatLog = new DevProLauncher.Windows.Components.CustomRTB();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ChatInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChatLog, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChatInput
            // 
            this.ChatInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatInput.Location = new System.Drawing.Point(4, 422);
            this.ChatInput.Margin = new System.Windows.Forms.Padding(4);
            this.ChatInput.MaxLength = 500;
            this.ChatInput.Name = "ChatInput";
            this.ChatInput.Size = new System.Drawing.Size(692, 22);
            this.ChatInput.TabIndex = 1;
            // 
            // ChatLog
            // 
            this.ChatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatLog.Location = new System.Drawing.Point(4, 4);
            this.ChatLog.Margin = new System.Windows.Forms.Padding(4);
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.Size = new System.Drawing.Size(692, 410);
            this.ChatLog.TabIndex = 2;
            this.ChatLog.Text = "";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notif";
            this.notifyIcon.Visible = true;
            // 
            // PmWindowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PmWindowFrm";
            this.Text = "PmWindow_frm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ChatInput;
        private CustomRTB ChatLog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}