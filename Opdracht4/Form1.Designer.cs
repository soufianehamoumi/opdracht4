namespace Opdracht4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textinfo = new System.Windows.Forms.TextBox();
            this.toevoegen = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Verplaatst = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.zienMessage = new System.Windows.Forms.Button();
            this.Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel : ";
            // 
            // Titel
            // 
            this.Titel.Location = new System.Drawing.Point(130, 100);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(392, 27);
            this.Titel.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.Location = new System.Drawing.Point(130, 364);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(182, 27);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "gemaakt op datum :";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 364);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textinfo
            // 
            this.textinfo.Location = new System.Drawing.Point(130, 163);
            this.textinfo.Multiline = true;
            this.textinfo.Name = "textinfo";
            this.textinfo.Size = new System.Drawing.Size(392, 174);
            this.textinfo.TabIndex = 5;
            // 
            // toevoegen
            // 
            this.toevoegen.Location = new System.Drawing.Point(233, 414);
            this.toevoegen.Name = "toevoegen";
            this.toevoegen.Size = new System.Drawing.Size(140, 56);
            this.toevoegen.TabIndex = 6;
            this.toevoegen.Text = "Toevoegen";
            this.toevoegen.UseVisualStyleBackColor = true;
            this.toevoegen.Click += new System.EventHandler(this.toevoegen_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(619, 71);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(140, 56);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Verplaatst
            // 
            this.Verplaatst.Location = new System.Drawing.Point(619, 148);
            this.Verplaatst.Name = "Verplaatst";
            this.Verplaatst.Size = new System.Drawing.Size(140, 56);
            this.Verplaatst.TabIndex = 8;
            this.Verplaatst.Text = "Achteraan verplaatsen  ";
            this.Verplaatst.UseVisualStyleBackColor = true;
            this.Verplaatst.Click += new System.EventHandler(this.Verplaatst_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(619, 229);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 56);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Verwijderen ";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // zienMessage
            // 
            this.zienMessage.Location = new System.Drawing.Point(619, 335);
            this.zienMessage.Name = "zienMessage";
            this.zienMessage.Size = new System.Drawing.Size(140, 56);
            this.zienMessage.TabIndex = 10;
            this.zienMessage.Text = "Message box ";
            this.zienMessage.UseVisualStyleBackColor = true;
            this.zienMessage.Click += new System.EventHandler(this.zienMessage_Click);
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(619, 414);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(140, 56);
            this.Form.TabIndex = 11;
            this.Form.Text = "Form";
            this.Form.UseVisualStyleBackColor = true;
            this.Form.Click += new System.EventHandler(this.Form_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 482);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.zienMessage);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Verplaatst);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.toevoegen);
            this.Controls.Add(this.textinfo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Titel;
        private CheckBox checkBox;
        private DateTimePicker dateTimePicker1;
        private TextBox textinfo;
        private Button toevoegen;
        private Button Next;
        private Button Verplaatst;
        private Button Delete;
        private Button zienMessage;
        private Button Form;
    }
}