using System.Reflection.Emit;
using System.Windows.Forms;

namespace JazztelRK
{
    partial class JazztelPriceViewer
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
            this.Title = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.InternetPanel = new System.Windows.Forms.Panel();
            this.InternetTitlePanel = new System.Windows.Forms.Panel();
            this.CheckBoxInternet = new System.Windows.Forms.CheckBox();
            this.CheckBoxSpeed = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Content.SuspendLayout();
            this.SelectionPanel.SuspendLayout();
            this.InternetPanel.SuspendLayout();
            this.InternetTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1280, 20);
            this.Title.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.DimGray;
            this.Content.Controls.Add(this.SelectionPanel);
            this.Content.Controls.Add(this.label1);
            this.Content.Location = new System.Drawing.Point(0, 20);
            this.Content.Margin = new System.Windows.Forms.Padding(0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1280, 700);
            this.Content.TabIndex = 1;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectionPanel.Controls.Add(this.InternetPanel);
            this.SelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(216, 667);
            this.SelectionPanel.TabIndex = 1;
            // 
            // InternetPanel
            // 
            this.InternetPanel.Controls.Add(this.InternetTitlePanel);
            this.InternetPanel.Controls.Add(this.CheckBoxSpeed);
            this.InternetPanel.Location = new System.Drawing.Point(0, 0);
            this.InternetPanel.Name = "InternetPanel";
            this.InternetPanel.Size = new System.Drawing.Size(216, 96);
            this.InternetPanel.TabIndex = 1;
            // 
            // InternetTitlePanel
            // 
            this.InternetTitlePanel.BackColor = System.Drawing.Color.DimGray;
            this.InternetTitlePanel.Controls.Add(this.CheckBoxInternet);
            this.InternetTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.InternetTitlePanel.Name = "InternetTitlePanel";
            this.InternetTitlePanel.Size = new System.Drawing.Size(216, 37);
            this.InternetTitlePanel.TabIndex = 1;
            // 
            // CheckBoxInternet
            // 
            this.CheckBoxInternet.AutoSize = true;
            this.CheckBoxInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxInternet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CheckBoxInternet.Location = new System.Drawing.Point(12, 7);
            this.CheckBoxInternet.Name = "CheckBoxInternet";
            this.CheckBoxInternet.Size = new System.Drawing.Size(92, 24);
            this.CheckBoxInternet.TabIndex = 0;
            this.CheckBoxInternet.Text = "Internet";
            this.CheckBoxInternet.UseVisualStyleBackColor = true;
            this.CheckBoxInternet.Click += new System.EventHandler(this.CheckBoxInternet_Click);
            // 
            // CheckBoxSpeed
            // 
            this.CheckBoxSpeed.BackColor = System.Drawing.Color.Gainsboro;
            this.CheckBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckBoxSpeed.CheckOnClick = true;
            this.CheckBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxSpeed.Items.AddRange(new object[] {
            "300MB / ADSL",
            "1000MB"});
            this.CheckBoxSpeed.Location = new System.Drawing.Point(12, 43);
            this.CheckBoxSpeed.Name = "CheckBoxSpeed";
            this.CheckBoxSpeed.Size = new System.Drawing.Size(204, 38);
            this.CheckBoxSpeed.TabIndex = 0;
            this.CheckBoxSpeed.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckBoxSpeed_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola soy una real etiqueta bonita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JazztelPriceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Title);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "JazztelPriceViewer";
            this.ShowIcon = false;
            this.Text = "JazztelPriceViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.SelectionPanel.ResumeLayout(false);
            this.InternetPanel.ResumeLayout(false);
            this.InternetTitlePanel.ResumeLayout(false);
            this.InternetTitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Title;
        private Panel Content;
        private System.Windows.Forms.Label label1;
        private Panel SelectionPanel;
        private CheckedListBox CheckBoxSpeed;
        private Panel InternetPanel;
        private Panel InternetTitlePanel;
        private CheckBox CheckBoxInternet;
    }
}

