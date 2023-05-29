namespace projetconservatoireFinal
{
    partial class Form3
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.payer = new System.Windows.Forms.GroupBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.payer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 42);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(529, 214);
            this.dgv1.TabIndex = 0;
            // 
            // payer
            // 
            this.payer.Controls.Add(this.label5);
            this.payer.Controls.Add(this.label4);
            this.payer.Controls.Add(this.label3);
            this.payer.Controls.Add(this.label2);
            this.payer.Controls.Add(this.label1);
            this.payer.Controls.Add(this.tb5);
            this.payer.Controls.Add(this.tb4);
            this.payer.Controls.Add(this.tb3);
            this.payer.Controls.Add(this.tb2);
            this.payer.Controls.Add(this.tb1);
            this.payer.Location = new System.Drawing.Point(12, 262);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(776, 166);
            this.payer.TabIndex = 1;
            this.payer.TabStop = false;
            this.payer.Text = "paiement ";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(17, 48);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 23);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(17, 112);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 23);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(247, 48);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(113, 23);
            this.tb3.TabIndex = 2;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(247, 112);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(113, 23);
            this.tb4.TabIndex = 3;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(478, 48);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 23);
            this.tb5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "datepaiment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "payer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.payer);
            this.Controls.Add(this.dgv1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.payer.ResumeLayout(false);
            this.payer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv1;
        private GroupBox payer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb5;
        private TextBox tb4;
        private TextBox tb3;
        private TextBox tb2;
        private TextBox tb1;
        private Button button1;
    }
}