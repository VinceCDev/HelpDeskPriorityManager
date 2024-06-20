/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 25/11/2023
 * Time: 6:07 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelpDeskPriorityManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;       
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelPriority;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.ListBox listBoxHelpRequests;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button button1;
		
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.listBoxHelpRequests = new System.Windows.Forms.ListBox();
        	this.labelTitle = new System.Windows.Forms.Label();
        	this.labelPriority = new System.Windows.Forms.Label();
        	this.labelID = new System.Windows.Forms.Label();
        	this.labelTime = new System.Windows.Forms.Label();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.btnAdd = new System.Windows.Forms.Button();
        	this.btnRemove = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// listBoxHelpRequests
        	// 
        	this.listBoxHelpRequests.BackColor = System.Drawing.Color.LightYellow;
        	this.listBoxHelpRequests.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.listBoxHelpRequests.FormattingEnabled = true;
        	this.listBoxHelpRequests.ItemHeight = 22;
        	this.listBoxHelpRequests.Location = new System.Drawing.Point(30, 185);
        	this.listBoxHelpRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.listBoxHelpRequests.Name = "listBoxHelpRequests";
        	this.listBoxHelpRequests.Size = new System.Drawing.Size(527, 202);
        	this.listBoxHelpRequests.TabIndex = 0;
        	// 
        	// labelTitle
        	// 
        	this.labelTitle.AutoSize = true;
        	this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelTitle.Location = new System.Drawing.Point(30, 24);
        	this.labelTitle.Name = "labelTitle";
        	this.labelTitle.Size = new System.Drawing.Size(527, 36);
        	this.labelTitle.TabIndex = 0;
        	this.labelTitle.Text = "HELP-DESK PRIORITY MANAGER";
        	this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// labelPriority
        	// 
        	this.labelPriority.AutoSize = true;
        	this.labelPriority.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelPriority.Location = new System.Drawing.Point(44, 154);
        	this.labelPriority.Name = "labelPriority";
        	this.labelPriority.Size = new System.Drawing.Size(121, 25);
        	this.labelPriority.TabIndex = 1;
        	this.labelPriority.Text = "PRIORITY";
        	// 
        	// labelID
        	// 
        	this.labelID.AutoSize = true;
        	this.labelID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelID.Location = new System.Drawing.Point(227, 154);
        	this.labelID.Name = "labelID";
        	this.labelID.Size = new System.Drawing.Size(37, 25);
        	this.labelID.TabIndex = 2;
        	this.labelID.Text = "ID";
        	// 
        	// labelTime
        	// 
        	this.labelTime.AutoSize = true;
        	this.labelTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelTime.Location = new System.Drawing.Point(325, 154);
        	this.labelTime.Name = "labelTime";
        	this.labelTime.Size = new System.Drawing.Size(218, 25);
        	this.labelTime.TabIndex = 3;
        	this.labelTime.Text = "TIME OF REQUEST";
        	// 
        	// textBox1
        	// 
        	this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox1.Location = new System.Drawing.Point(30, 107);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(190, 26);
        	this.textBox1.TabIndex = 4;
        	// 
        	// dateTimePicker1
        	// 
        	this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dateTimePicker1.Location = new System.Drawing.Point(297, 104);
        	this.dateTimePicker1.Name = "dateTimePicker1";
        	this.dateTimePicker1.Size = new System.Drawing.Size(260, 26);
        	this.dateTimePicker1.TabIndex = 6;
        	this.dateTimePicker1.Value = new System.DateTime(2023, 12, 16, 6, 48, 0, 0);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.PaleGreen;
        	this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(30, 78);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(81, 23);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Enter ID";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.PaleGreen;
        	this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(297, 78);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(102, 23);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Enter Time";
        	// 
        	// btnAdd
        	// 
        	this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
        	this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAdd.Location = new System.Drawing.Point(96, 403);
        	this.btnAdd.Name = "btnAdd";
        	this.btnAdd.Size = new System.Drawing.Size(147, 26);
        	this.btnAdd.TabIndex = 9;
        	this.btnAdd.Text = "ADD";
        	this.btnAdd.UseVisualStyleBackColor = false;
        	this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
        	// 
        	// btnRemove
        	// 
        	this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnRemove.Location = new System.Drawing.Point(325, 403);
        	this.btnRemove.Name = "btnRemove";
        	this.btnRemove.Size = new System.Drawing.Size(147, 26);
        	this.btnRemove.TabIndex = 10;
        	this.btnRemove.Text = "REMOVE";
        	this.btnRemove.UseVisualStyleBackColor = true;
        	this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
        	// 
        	// button1
        	// 
        	this.button1.BackColor = System.Drawing.SystemColors.Control;
        	this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.Location = new System.Drawing.Point(213, 445);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(147, 26);
        	this.button1.TabIndex = 11;
        	this.button1.Text = "EXIT";
        	this.button1.UseVisualStyleBackColor = false;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Cyan;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(580, 483);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.btnRemove);
        	this.Controls.Add(this.btnAdd);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.dateTimePicker1);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.labelTitle);
        	this.Controls.Add(this.labelPriority);
        	this.Controls.Add(this.labelID);
        	this.Controls.Add(this.labelTime);
        	this.Controls.Add(this.listBoxHelpRequests);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Help Desk Priority Manager";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        }

      
    }


