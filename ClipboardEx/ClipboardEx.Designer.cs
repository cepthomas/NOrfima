
namespace ClipboardEx
{
    partial class ClipboardEx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvInfo = new NBagOfUis.TextViewer();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvInfo
            // 
            this.tvInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvInfo.Location = new System.Drawing.Point(233, 166);
            this.tvInfo.MaxText = 50000;
            this.tvInfo.Name = "tvInfo";
            this.tvInfo.Size = new System.Drawing.Size(836, 312);
            this.tvInfo.TabIndex = 0;
            this.tvInfo.Text = "";
            // 
            // rtbText
            // 
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Location = new System.Drawing.Point(11, 271);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(205, 207);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(12, 166);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(94, 29);
            this.btnDebug.TabIndex = 2;
            this.btnDebug.Text = "Do Stuff";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblWin
            // 
            this.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWin.Location = new System.Drawing.Point(14, 219);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(25, 25);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "W";
            // 
            // lblLetter
            // 
            this.lblLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetter.Location = new System.Drawing.Point(45, 219);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(25, 25);
            this.lblLetter.TabIndex = 7;
            this.lblLetter.Text = "?";
            // 
            // lblMatch
            // 
            this.lblMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatch.Location = new System.Drawing.Point(76, 219);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(25, 25);
            this.lblMatch.TabIndex = 8;
            this.lblMatch.Text = "!!";
            // 
            // ClipboardEx
            // 
            this.ClientSize = new System.Drawing.Size(1336, 490);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tvInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClipboardEx";
            this.Text = "Hoo Haa";
            this.ResumeLayout(false);

        }
        #endregion

        
        private NBagOfUis.TextViewer tvInfo;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblMatch;
    }
}