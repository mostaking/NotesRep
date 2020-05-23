﻿namespace Notes.Forms
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelNotSign = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            resources.ApplyResources(this.buttonSignIn, "buttonSignIn");
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignUp
            // 
            resources.ApplyResources(this.buttonSignUp, "buttonSignUp");
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelNotSign
            // 
            resources.ApplyResources(this.labelNotSign, "labelNotSign");
            this.labelNotSign.Name = "labelNotSign";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.Name = "labelUsername";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.Name = "textBoxUsername";
            // 
            // labelSignIn
            // 
            resources.ApplyResources(this.labelSignIn, "labelSignIn");
            this.labelSignIn.Name = "labelSignIn";
            // 
            // labelWelcome
            // 
            resources.ApplyResources(this.labelWelcome, "labelWelcome");
            this.labelWelcome.Name = "labelWelcome";
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelNotSign);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.labelWelcome);
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelNotSign;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label labelWelcome;
    }
}