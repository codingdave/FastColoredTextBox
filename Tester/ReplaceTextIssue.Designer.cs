namespace Tester
{
    partial class ReplaceTextIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceTextIssue));
            this.label1 = new System.Windows.Forms.Label();
            this.btGotToEnd = new System.Windows.Forms.Button();
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "This example shows the reported bug";
            // 
            // btGotToEnd
            // 
            this.btGotToEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btGotToEnd.Location = new System.Drawing.Point(0, 445);
            this.btGotToEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGotToEnd.Name = "btGotToEnd";
            this.btGotToEnd.Size = new System.Drawing.Size(532, 35);
            this.btGotToEnd.TabIndex = 6;
            this.btGotToEnd.Text = "Execute";
            this.btGotToEnd.UseVisualStyleBackColor = true;
            this.btGotToEnd.Click += new System.EventHandler(this.btGotToEnd_Click);
            // 
            // fctb
            // 
            this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctb.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(0, 22);
            this.fctb.BackBrush = null;
            this.fctb.CharHeight = 22;
            this.fctb.CharWidth = 11;
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctb.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fctb.IsReplaceMode = false;
            this.fctb.Location = new System.Drawing.Point(0, 33);
            this.fctb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fctb.Name = "fctb";
            this.fctb.Paddings = new System.Windows.Forms.Padding(0);
            this.fctb.ReadOnly = true;
            this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
            this.fctb.Size = new System.Drawing.Size(532, 412);
            this.fctb.TabIndex = 5;
            this.fctb.WordWrap = true;
            this.fctb.Zoom = 100;
            // 
            // ReplaceTextIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 480);
            this.Controls.Add(this.fctb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGotToEnd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReplaceTextIssue";
            this.Text = "ReplaceTextIssue";
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Button btGotToEnd;
    }
}