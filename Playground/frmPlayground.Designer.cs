
using System;

namespace Playground
{
    partial class frmPlayground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayground));
            this.animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SampleElement1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SampleElement2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SampleElement4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SampleElement3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTheme = new Guna.UI2.WinForms.Guna2Button();
            this.animator = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.animatorTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.SampleElement1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animator)).BeginInit();
            this.SuspendLayout();
            // 
            // animate
            // 
            this.animate.Interval = 1000;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.SampleElement1);
            this.pnlContainer.Controls.Add(this.button1);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.SampleElement2);
            this.pnlContainer.Controls.Add(this.SampleElement4);
            this.pnlContainer.Controls.Add(this.SampleElement3);
            this.pnlContainer.Controls.Add(this.btnTheme);
            this.pnlContainer.Controls.Add(this.animator);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1171, 653);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // SampleElement1
            // 
            this.SampleElement1.Controls.Add(this.label1);
            this.SampleElement1.FillColor = System.Drawing.Color.LightBlue;
            this.SampleElement1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SampleElement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SampleElement1.Location = new System.Drawing.Point(115, 149);
            this.SampleElement1.Name = "SampleElement1";
            this.SampleElement1.ShadowDecoration.Parent = this.SampleElement1;
            this.SampleElement1.Size = new System.Drawing.Size(300, 200);
            this.SampleElement1.TabIndex = 9;
            this.SampleElement1.Text = "SampleElement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(825, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 384);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Peru;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 96);
            this.panel5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 96);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 96);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 96);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // SampleElement2
            // 
            this.SampleElement2.FillColor = System.Drawing.Color.LightBlue;
            this.SampleElement2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SampleElement2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SampleElement2.Location = new System.Drawing.Point(421, 149);
            this.SampleElement2.Name = "SampleElement2";
            this.SampleElement2.ShadowDecoration.Parent = this.SampleElement2;
            this.SampleElement2.Size = new System.Drawing.Size(300, 200);
            this.SampleElement2.TabIndex = 7;
            this.SampleElement2.Text = "SampleElement";
            // 
            // SampleElement4
            // 
            this.SampleElement4.FillColor = System.Drawing.Color.LightBlue;
            this.SampleElement4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SampleElement4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SampleElement4.Location = new System.Drawing.Point(421, 385);
            this.SampleElement4.Name = "SampleElement4";
            this.SampleElement4.ShadowDecoration.Parent = this.SampleElement4;
            this.SampleElement4.Size = new System.Drawing.Size(300, 200);
            this.SampleElement4.TabIndex = 11;
            this.SampleElement4.Text = "SampleElement";
            // 
            // SampleElement3
            // 
            this.SampleElement3.FillColor = System.Drawing.Color.LightBlue;
            this.SampleElement3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SampleElement3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SampleElement3.Location = new System.Drawing.Point(115, 385);
            this.SampleElement3.Name = "SampleElement3";
            this.SampleElement3.ShadowDecoration.Parent = this.SampleElement3;
            this.SampleElement3.Size = new System.Drawing.Size(300, 200);
            this.SampleElement3.TabIndex = 12;
            this.SampleElement3.Text = "SampleElement";
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnTheme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTheme.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnTheme.CheckedState.Image")));
            this.btnTheme.CheckedState.Parent = this.btnTheme;
            this.btnTheme.CustomImages.Parent = this.btnTheme;
            this.btnTheme.FillColor = System.Drawing.Color.Transparent;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnTheme.HoverState.Parent = this.btnTheme;
            this.btnTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnTheme.Image")));
            this.btnTheme.Location = new System.Drawing.Point(395, 68);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.PressedColor = System.Drawing.Color.Transparent;
            this.btnTheme.ShadowDecoration.Parent = this.btnTheme;
            this.btnTheme.Size = new System.Drawing.Size(44, 44);
            this.btnTheme.TabIndex = 8;
            this.btnTheme.UseTransparentBackground = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // animator
            // 
            this.animator.BackColor = System.Drawing.Color.Transparent;
            this.animator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.animator.FillColor = System.Drawing.Color.Transparent;
            this.animator.Location = new System.Drawing.Point(395, 68);
            this.animator.Name = "animator";
            this.animator.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.animator.ShadowDecoration.Parent = this.animator;
            this.animator.Size = new System.Drawing.Size(44, 44);
            this.animator.TabIndex = 10;
            this.animator.TabStop = false;
            this.animator.UseTransparentBackground = true;
            // 
            // animatorTimer
            // 
            this.animatorTimer.Interval = 1;
            this.animatorTimer.Tick += new System.EventHandler(this.animatorTimer_Tick);
            // 
            // frmPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 653);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlayground";
            this.Text = "frmPlayground";
            this.Load += new System.EventHandler(this.frmPlayground_Load);
            this.pnlContainer.ResumeLayout(false);
            this.SampleElement1.ResumeLayout(false);
            this.SampleElement1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animator)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow animate;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Timer animatorTimer;
        private Guna.UI2.WinForms.Guna2GroupBox SampleElement1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox SampleElement2;
        private Guna.UI2.WinForms.Guna2GroupBox SampleElement4;
        private Guna.UI2.WinForms.Guna2Button btnTheme;
        private Guna.UI2.WinForms.Guna2GroupBox SampleElement3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox animator;
    }
}