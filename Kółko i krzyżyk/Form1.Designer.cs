﻿
namespace Kółko_i_krzyżyk
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BR = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.CR = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Button();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BR, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TR, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TL, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BR
            // 
            this.BR.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.BR.Location = new System.Drawing.Point(221, 213);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(103, 99);
            this.BR.TabIndex = 8;
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.Mark);
            // 
            // BC
            // 
            this.BC.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.BC.Location = new System.Drawing.Point(112, 213);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(103, 99);
            this.BC.TabIndex = 7;
            this.BC.UseVisualStyleBackColor = true;
            this.BC.Click += new System.EventHandler(this.Mark);
            // 
            // BL
            // 
            this.BL.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.BL.Location = new System.Drawing.Point(3, 213);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(103, 99);
            this.BL.TabIndex = 6;
            this.BL.UseVisualStyleBackColor = true;
            this.BL.Click += new System.EventHandler(this.Mark);
            // 
            // CR
            // 
            this.CR.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.CR.Location = new System.Drawing.Point(221, 108);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(103, 99);
            this.CR.TabIndex = 5;
            this.CR.UseVisualStyleBackColor = true;
            this.CR.Click += new System.EventHandler(this.Mark);
            // 
            // CC
            // 
            this.CC.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.CC.Location = new System.Drawing.Point(112, 108);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(103, 99);
            this.CC.TabIndex = 4;
            this.CC.UseVisualStyleBackColor = true;
            this.CC.Click += new System.EventHandler(this.Mark);
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.CL.Location = new System.Drawing.Point(3, 108);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(103, 99);
            this.CL.TabIndex = 3;
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.Mark);
            // 
            // TR
            // 
            this.TR.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.TR.Location = new System.Drawing.Point(221, 3);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(103, 99);
            this.TR.TabIndex = 2;
            this.TR.UseVisualStyleBackColor = true;
            this.TR.Click += new System.EventHandler(this.Mark);
            // 
            // TC
            // 
            this.TC.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.TC.Location = new System.Drawing.Point(112, 3);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(103, 99);
            this.TC.TabIndex = 1;
            this.TC.UseVisualStyleBackColor = true;
            this.TC.Click += new System.EventHandler(this.Mark);
            // 
            // TL
            // 
            this.TL.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.TL.Location = new System.Drawing.Point(3, 3);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(103, 99);
            this.TL.TabIndex = 0;
            this.TL.UseVisualStyleBackColor = true;
            this.TL.Click += new System.EventHandler(this.Mark);
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPlayerLabel.Location = new System.Drawing.Point(20, 354);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(48, 21);
            this.currentPlayerLabel.TabIndex = 1;
            this.currentPlayerLabel.Text = "Ruch:";
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(241, 344);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(103, 31);
            this.restart.TabIndex = 2;
            this.restart.Text = "zacznij jeszcze raz";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 384);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button BC;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button CR;
        private System.Windows.Forms.Button CC;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button TC;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Button restart;
    }
}

