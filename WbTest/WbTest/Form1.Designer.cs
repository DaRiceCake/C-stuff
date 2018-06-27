namespace WbTest
{
    partial class BrowserWindow
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
            this.Dock = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.UrlEnter = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.ChrWindow = new System.Windows.Forms.Panel();
            this.Dock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dock
            // 
            this.Dock.Controls.Add(this.go);
            this.Dock.Controls.Add(this.UrlEnter);
            this.Dock.Controls.Add(this.forward);
            this.Dock.Controls.Add(this.back);
            this.Dock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dock.Location = new System.Drawing.Point(0, 0);
            this.Dock.Name = "Dock";
            this.Dock.Size = new System.Drawing.Size(761, 66);
            this.Dock.TabIndex = 0;
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 66);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Dock = System.Windows.Forms.DockStyle.Left;
            this.forward.Location = new System.Drawing.Point(75, 0);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 66);
            this.forward.TabIndex = 1;
            this.forward.Text = "forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // UrlEnter
            // 
            this.UrlEnter.Location = new System.Drawing.Point(230, 24);
            this.UrlEnter.Name = "UrlEnter";
            this.UrlEnter.Size = new System.Drawing.Size(307, 20);
            this.UrlEnter.TabIndex = 2;
            this.UrlEnter.TextChanged += new System.EventHandler(this.UrlEnter_TextChanged);
            // 
            // go
            // 
            this.go.Dock = System.Windows.Forms.DockStyle.Right;
            this.go.Location = new System.Drawing.Point(686, 0);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 66);
            this.go.TabIndex = 3;
            this.go.Text = "go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // ChrWindow
            // 
            this.ChrWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChrWindow.Location = new System.Drawing.Point(0, 66);
            this.ChrWindow.Name = "ChrWindow";
            this.ChrWindow.Size = new System.Drawing.Size(761, 285);
            this.ChrWindow.TabIndex = 1;
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 351);
            this.Controls.Add(this.ChrWindow);
            this.Controls.Add(this.Dock);
            this.Name = "BrowserWindow";
            this.Text = "Form1";
            this.Dock.ResumeLayout(false);
            this.Dock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dock;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox UrlEnter;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel ChrWindow;
    }
}

