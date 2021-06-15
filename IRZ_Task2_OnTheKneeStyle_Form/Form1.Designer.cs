namespace IRZ_Task2_OnTheKneeStyle_Form
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
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.uriLable = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.pathSaveTextBox = new System.Windows.Forms.TextBox();
            this.resultLable = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.loadFromWebButton = new System.Windows.Forms.Button();
            this.saveXmlButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.pathLoadLable = new System.Windows.Forms.Label();
            this.pathLoadTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveHtmlButton = new System.Windows.Forms.Button();
            this.OpenInBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(85, 45);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(311, 20);
            this.LinkTextBox.TabIndex = 0;
            // 
            // uriLable
            // 
            this.uriLable.AutoSize = true;
            this.uriLable.Location = new System.Drawing.Point(12, 45);
            this.uriLable.Name = "uriLable";
            this.uriLable.Size = new System.Drawing.Size(27, 13);
            this.uriLable.TabIndex = 1;
            this.uriLable.Text = "Link";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(85, 126);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(311, 336);
            this.resultTextBox.TabIndex = 2;
            // 
            // pathSaveTextBox
            // 
            this.pathSaveTextBox.Location = new System.Drawing.Point(85, 484);
            this.pathSaveTextBox.Name = "pathSaveTextBox";
            this.pathSaveTextBox.Size = new System.Drawing.Size(311, 20);
            this.pathSaveTextBox.TabIndex = 3;
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(12, 126);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(32, 13);
            this.resultLable.TabIndex = 4;
            this.resultLable.Text = "result";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(222, 80);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(27, 13);
            this.titleLable.TabIndex = 5;
            this.titleLable.Text = "Title";
            // 
            // loadFromWebButton
            // 
            this.loadFromWebButton.Location = new System.Drawing.Point(402, 43);
            this.loadFromWebButton.Name = "loadFromWebButton";
            this.loadFromWebButton.Size = new System.Drawing.Size(91, 23);
            this.loadFromWebButton.TabIndex = 6;
            this.loadFromWebButton.Text = "Load from web";
            this.loadFromWebButton.UseVisualStyleBackColor = true;
            this.loadFromWebButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // saveXmlButton
            // 
            this.saveXmlButton.Location = new System.Drawing.Point(418, 482);
            this.saveXmlButton.Name = "saveXmlButton";
            this.saveXmlButton.Size = new System.Drawing.Size(99, 23);
            this.saveXmlButton.TabIndex = 7;
            this.saveXmlButton.Text = "Save to xml file";
            this.saveXmlButton.UseVisualStyleBackColor = true;
            this.saveXmlButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(402, 13);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(104, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load from xml file";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadFromXmlButton_Click);
            // 
            // pathLoadLable
            // 
            this.pathLoadLable.AutoSize = true;
            this.pathLoadLable.Location = new System.Drawing.Point(12, 15);
            this.pathLoadLable.Name = "pathLoadLable";
            this.pathLoadLable.Size = new System.Drawing.Size(67, 13);
            this.pathLoadLable.TabIndex = 9;
            this.pathLoadLable.Text = "Path for load";
            // 
            // pathLoadTextBox
            // 
            this.pathLoadTextBox.Location = new System.Drawing.Point(85, 15);
            this.pathLoadTextBox.Name = "pathLoadTextBox";
            this.pathLoadTextBox.Size = new System.Drawing.Size(311, 20);
            this.pathLoadTextBox.TabIndex = 8;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 80);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 14;
            this.AuthorLabel.Text = "Author";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(85, 80);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(131, 20);
            this.authorTextBox.TabIndex = 13;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(255, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(141, 20);
            this.titleTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Path for Save";
            // 
            // saveHtmlButton
            // 
            this.saveHtmlButton.Location = new System.Drawing.Point(418, 511);
            this.saveHtmlButton.Name = "saveHtmlButton";
            this.saveHtmlButton.Size = new System.Drawing.Size(99, 23);
            this.saveHtmlButton.TabIndex = 16;
            this.saveHtmlButton.Text = "Save to html file";
            this.saveHtmlButton.UseVisualStyleBackColor = true;
            this.saveHtmlButton.Click += new System.EventHandler(this.saveHtmlButton_Click);
            // 
            // OpenInBrowser
            // 
            this.OpenInBrowser.Location = new System.Drawing.Point(418, 439);
            this.OpenInBrowser.Name = "OpenInBrowser";
            this.OpenInBrowser.Size = new System.Drawing.Size(99, 23);
            this.OpenInBrowser.TabIndex = 17;
            this.OpenInBrowser.Text = "Open in browser";
            this.OpenInBrowser.UseVisualStyleBackColor = true;
            this.OpenInBrowser.Click += new System.EventHandler(this.OpenInBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 550);
            this.Controls.Add(this.OpenInBrowser);
            this.Controls.Add(this.saveHtmlButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pathLoadLable);
            this.Controls.Add(this.pathLoadTextBox);
            this.Controls.Add(this.saveXmlButton);
            this.Controls.Add(this.loadFromWebButton);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.pathSaveTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.uriLable);
            this.Controls.Add(this.LinkTextBox);
            this.Name = "Form1";
            this.Text = "IRZ_Task2_OnTheKneeStyle_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label uriLable;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox pathSaveTextBox;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button loadFromWebButton;
        private System.Windows.Forms.Button saveXmlButton;
        private System.Windows.Forms.Label pathLoadLable;
        private System.Windows.Forms.TextBox pathLoadTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveHtmlButton;
        private System.Windows.Forms.Button OpenInBrowser;
    }
}

