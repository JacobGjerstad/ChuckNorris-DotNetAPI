﻿namespace ChuckNorrisJoke
{
    partial class Form1
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
            this.btnJoke = new System.Windows.Forms.Button();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnJoke
            // 
            this.btnJoke.Location = new System.Drawing.Point(216, 52);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(75, 23);
            this.btnJoke.TabIndex = 0;
            this.btnJoke.Text = "Get Joke";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.BtnJoke_Click);
            // 
            // cboxCategories
            // 
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(30, 52);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(121, 21);
            this.cboxCategories.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 152);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.btnJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.ComboBox cboxCategories;
    }
}

