﻿namespace DataTron
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnForm2Back = new System.Windows.Forms.Button();
            this.btnForm2Next = new System.Windows.Forms.Button();
            this.btnCopyPackage = new System.Windows.Forms.Button();
            this.btnGetJava = new System.Windows.Forms.Button();
            this.btnSetJavaHome = new System.Windows.Forms.Button();
            this.btnInstalWebCert = new System.Windows.Forms.Button();
            this.btnUpdateYML = new System.Windows.Forms.Button();
            this.btnInstallService = new System.Windows.Forms.Button();
            this.btnCreateEsUsers = new System.Windows.Forms.Button();
            this.btnGetJavaHome = new System.Windows.Forms.Button();
            this.textBoxJavaHome = new System.Windows.Forms.TextBox();
            this.listBoxJava = new System.Windows.Forms.ListBox();
            this.btnStartES = new System.Windows.Forms.Button();
            this.btnStopES = new System.Windows.Forms.Button();
            this.btnGetWebCert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm2Back
            // 
            this.btnForm2Back.Location = new System.Drawing.Point(852, 267);
            this.btnForm2Back.Name = "btnForm2Back";
            this.btnForm2Back.Size = new System.Drawing.Size(212, 23);
            this.btnForm2Back.TabIndex = 0;
            this.btnForm2Back.Text = "Back";
            this.btnForm2Back.UseVisualStyleBackColor = true;
            this.btnForm2Back.Click += new System.EventHandler(this.btnForm2Back_Click);
            // 
            // btnForm2Next
            // 
            this.btnForm2Next.Location = new System.Drawing.Point(852, 318);
            this.btnForm2Next.Name = "btnForm2Next";
            this.btnForm2Next.Size = new System.Drawing.Size(212, 23);
            this.btnForm2Next.TabIndex = 1;
            this.btnForm2Next.Text = "Next";
            this.btnForm2Next.UseVisualStyleBackColor = true;
            // 
            // btnCopyPackage
            // 
            this.btnCopyPackage.Location = new System.Drawing.Point(28, 23);
            this.btnCopyPackage.Name = "btnCopyPackage";
            this.btnCopyPackage.Size = new System.Drawing.Size(259, 23);
            this.btnCopyPackage.TabIndex = 2;
            this.btnCopyPackage.Text = "Copy Data Grid Package to Disk";
            this.btnCopyPackage.UseVisualStyleBackColor = true;
            this.btnCopyPackage.Click += new System.EventHandler(this.btnCopyPackage_Click);
            // 
            // btnGetJava
            // 
            this.btnGetJava.Location = new System.Drawing.Point(28, 103);
            this.btnGetJava.Name = "btnGetJava";
            this.btnGetJava.Size = new System.Drawing.Size(259, 23);
            this.btnGetJava.TabIndex = 2;
            this.btnGetJava.Text = "Get Java Installations";
            this.btnGetJava.UseVisualStyleBackColor = true;
            this.btnGetJava.Click += new System.EventHandler(this.btnCheckJava_Click);
            // 
            // btnSetJavaHome
            // 
            this.btnSetJavaHome.Location = new System.Drawing.Point(159, 145);
            this.btnSetJavaHome.Name = "btnSetJavaHome";
            this.btnSetJavaHome.Size = new System.Drawing.Size(128, 23);
            this.btnSetJavaHome.TabIndex = 2;
            this.btnSetJavaHome.Text = "Set Java Home";
            this.btnSetJavaHome.UseVisualStyleBackColor = true;
            this.btnSetJavaHome.Click += new System.EventHandler(this.btnSetJavaHome_Click);
            // 
            // btnInstalWebCert
            // 
            this.btnInstalWebCert.Location = new System.Drawing.Point(163, 277);
            this.btnInstalWebCert.Name = "btnInstalWebCert";
            this.btnInstalWebCert.Size = new System.Drawing.Size(124, 23);
            this.btnInstalWebCert.TabIndex = 2;
            this.btnInstalWebCert.Text = "Install Web Cert";
            this.btnInstalWebCert.UseVisualStyleBackColor = true;
            this.btnInstalWebCert.Click += new System.EventHandler(this.btnInstalWebCert_Click);
            // 
            // btnUpdateYML
            // 
            this.btnUpdateYML.Location = new System.Drawing.Point(28, 61);
            this.btnUpdateYML.Name = "btnUpdateYML";
            this.btnUpdateYML.Size = new System.Drawing.Size(259, 23);
            this.btnUpdateYML.TabIndex = 2;
            this.btnUpdateYML.Text = "Update YML File";
            this.btnUpdateYML.UseVisualStyleBackColor = true;
            this.btnUpdateYML.Click += new System.EventHandler(this.btnUpdateYML_Click);
            // 
            // btnInstallService
            // 
            this.btnInstallService.Location = new System.Drawing.Point(28, 192);
            this.btnInstallService.Name = "btnInstallService";
            this.btnInstallService.Size = new System.Drawing.Size(259, 23);
            this.btnInstallService.TabIndex = 2;
            this.btnInstallService.Text = "Install Elastic Service";
            this.btnInstallService.UseVisualStyleBackColor = true;
            this.btnInstallService.Click += new System.EventHandler(this.btnInstallService_Click);
            // 
            // btnCreateEsUsers
            // 
            this.btnCreateEsUsers.Location = new System.Drawing.Point(28, 346);
            this.btnCreateEsUsers.Name = "btnCreateEsUsers";
            this.btnCreateEsUsers.Size = new System.Drawing.Size(259, 23);
            this.btnCreateEsUsers.TabIndex = 2;
            this.btnCreateEsUsers.Text = "Create Elastic REST User";
            this.btnCreateEsUsers.UseVisualStyleBackColor = true;
            this.btnCreateEsUsers.Click += new System.EventHandler(this.btnCreateEsUsers_Click);
            // 
            // btnGetJavaHome
            // 
            this.btnGetJavaHome.Location = new System.Drawing.Point(28, 145);
            this.btnGetJavaHome.Name = "btnGetJavaHome";
            this.btnGetJavaHome.Size = new System.Drawing.Size(128, 23);
            this.btnGetJavaHome.TabIndex = 2;
            this.btnGetJavaHome.Text = "Get Java Home";
            this.btnGetJavaHome.UseVisualStyleBackColor = true;
            this.btnGetJavaHome.Click += new System.EventHandler(this.btnGetJavaHome_Click);
            // 
            // textBoxJavaHome
            // 
            this.textBoxJavaHome.Location = new System.Drawing.Point(316, 145);
            this.textBoxJavaHome.Name = "textBoxJavaHome";
            this.textBoxJavaHome.Size = new System.Drawing.Size(327, 20);
            this.textBoxJavaHome.TabIndex = 3;
            // 
            // listBoxJava
            // 
            this.listBoxJava.FormattingEnabled = true;
            this.listBoxJava.Location = new System.Drawing.Point(316, 103);
            this.listBoxJava.Name = "listBoxJava";
            this.listBoxJava.Size = new System.Drawing.Size(327, 30);
            this.listBoxJava.TabIndex = 4;
            this.listBoxJava.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxJava_MouseDoubleClick);
            // 
            // btnStartES
            // 
            this.btnStartES.Location = new System.Drawing.Point(28, 232);
            this.btnStartES.Name = "btnStartES";
            this.btnStartES.Size = new System.Drawing.Size(128, 23);
            this.btnStartES.TabIndex = 5;
            this.btnStartES.Text = "Start Service";
            this.btnStartES.UseVisualStyleBackColor = true;
            this.btnStartES.Click += new System.EventHandler(this.btnStartES_Click);
            // 
            // btnStopES
            // 
            this.btnStopES.Location = new System.Drawing.Point(163, 232);
            this.btnStopES.Name = "btnStopES";
            this.btnStopES.Size = new System.Drawing.Size(124, 23);
            this.btnStopES.TabIndex = 6;
            this.btnStopES.Text = "Stop Service";
            this.btnStopES.UseVisualStyleBackColor = true;
            this.btnStopES.Click += new System.EventHandler(this.btnStopES_Click);
            // 
            // btnGetWebCert
            // 
            this.btnGetWebCert.Location = new System.Drawing.Point(28, 277);
            this.btnGetWebCert.Name = "btnGetWebCert";
            this.btnGetWebCert.Size = new System.Drawing.Size(128, 23);
            this.btnGetWebCert.TabIndex = 7;
            this.btnGetWebCert.Text = "Get Web Cert";
            this.btnGetWebCert.UseVisualStyleBackColor = true;
            this.btnGetWebCert.Click += new System.EventHandler(this.btnGetWebCert_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1139, 406);
            this.Controls.Add(this.btnGetWebCert);
            this.Controls.Add(this.btnStopES);
            this.Controls.Add(this.btnStartES);
            this.Controls.Add(this.listBoxJava);
            this.Controls.Add(this.textBoxJavaHome);
            this.Controls.Add(this.btnCreateEsUsers);
            this.Controls.Add(this.btnInstallService);
            this.Controls.Add(this.btnUpdateYML);
            this.Controls.Add(this.btnInstalWebCert);
            this.Controls.Add(this.btnGetJavaHome);
            this.Controls.Add(this.btnSetJavaHome);
            this.Controls.Add(this.btnGetJava);
            this.Controls.Add(this.btnCopyPackage);
            this.Controls.Add(this.btnForm2Next);
            this.Controls.Add(this.btnForm2Back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Elastic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2Back;
        private System.Windows.Forms.Button btnForm2Next;
        private System.Windows.Forms.Button btnCopyPackage;
        private System.Windows.Forms.Button btnGetJava;
        private System.Windows.Forms.Button btnSetJavaHome;
        private System.Windows.Forms.Button btnInstalWebCert;
        private System.Windows.Forms.Button btnUpdateYML;
        private System.Windows.Forms.Button btnInstallService;
        private System.Windows.Forms.Button btnCreateEsUsers;
        private System.Windows.Forms.Button btnGetJavaHome;
        private System.Windows.Forms.TextBox textBoxJavaHome;
        private System.Windows.Forms.ListBox listBoxJava;
        private System.Windows.Forms.Button btnStartES;
        private System.Windows.Forms.Button btnStopES;
        private System.Windows.Forms.Button btnGetWebCert;
    }
}