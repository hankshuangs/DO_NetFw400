﻿namespace FtpAutoUpload
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtArea = new System.Windows.Forms.TextBox();
			this.btnToBak = new System.Windows.Forms.Button();
			this.btnSet = new System.Windows.Forms.Button();
			this.btnSource = new System.Windows.Forms.Button();
			this.txtPW = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNasIP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(96, 12);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(100, 22);
			this.txtArea.TabIndex = 35;
			// 
			// btnToBak
			// 
			this.btnToBak.Location = new System.Drawing.Point(427, 165);
			this.btnToBak.Name = "btnToBak";
			this.btnToBak.Size = new System.Drawing.Size(89, 33);
			this.btnToBak.TabIndex = 33;
			this.btnToBak.Text = "即刻備份";
			this.btnToBak.UseVisualStyleBackColor = true;
			this.btnToBak.Click += new System.EventHandler(this.btnToBak_Click);
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(427, 126);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(89, 33);
			this.btnSet.TabIndex = 34;
			this.btnSet.Text = "資料設定";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// btnSource
			// 
			this.btnSource.Location = new System.Drawing.Point(434, 51);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(75, 23);
			this.btnSource.TabIndex = 32;
			this.btnSource.Text = "瀏覽";
			this.btnSource.UseVisualStyleBackColor = true;
			this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
			// 
			// txtPW
			// 
			this.txtPW.Location = new System.Drawing.Point(96, 172);
			this.txtPW.Name = "txtPW";
			this.txtPW.PasswordChar = '*';
			this.txtPW.Size = new System.Drawing.Size(129, 22);
			this.txtPW.TabIndex = 28;
			this.txtPW.Text = "helloibus";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(96, 132);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(129, 22);
			this.txtID.TabIndex = 29;
			this.txtID.Text = "infor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 23;
			this.label4.Text = "密碼：";
			// 
			// txtNasIP
			// 
			this.txtNasIP.Location = new System.Drawing.Point(96, 92);
			this.txtNasIP.Name = "txtNasIP";
			this.txtNasIP.Size = new System.Drawing.Size(328, 22);
			this.txtNasIP.TabIndex = 30;
			this.txtNasIP.Text = "ftp://192.168.168.102:21//行車紀錄器";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 24;
			this.label3.Text = "iNas帳號：";
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(96, 52);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(328, 22);
			this.txtSource.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 12);
			this.label2.TabIndex = 25;
			this.label2.Text = "iNas 位址：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 26;
			this.label5.Text = "單位：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 27;
			this.label1.Text = "來源的路徑：";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 230);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.btnToBak);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.btnSource);
			this.Controls.Add(this.txtPW);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNasIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "自動備份";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Button btnToBak;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Button btnSource;
		private System.Windows.Forms.TextBox txtPW;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNasIP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
	}
}

