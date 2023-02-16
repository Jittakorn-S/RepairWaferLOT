namespace RepairWaferLOT
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonWaferMapping = new System.Windows.Forms.RadioButton();
            this.radioButtonAfterAOI = new System.Windows.Forms.RadioButton();
            this.labelWaferMapping = new System.Windows.Forms.Label();
            this.labelAfterAOI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Repair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(290, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonWaferMapping
            // 
            this.radioButtonWaferMapping.AutoSize = true;
            this.radioButtonWaferMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWaferMapping.Location = new System.Drawing.Point(361, 245);
            this.radioButtonWaferMapping.Name = "radioButtonWaferMapping";
            this.radioButtonWaferMapping.Size = new System.Drawing.Size(118, 21);
            this.radioButtonWaferMapping.TabIndex = 2;
            this.radioButtonWaferMapping.TabStop = true;
            this.radioButtonWaferMapping.Text = "WaferMapping";
            this.radioButtonWaferMapping.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfterAOI
            // 
            this.radioButtonAfterAOI.AutoSize = true;
            this.radioButtonAfterAOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAfterAOI.Location = new System.Drawing.Point(361, 272);
            this.radioButtonAfterAOI.Name = "radioButtonAfterAOI";
            this.radioButtonAfterAOI.Size = new System.Drawing.Size(79, 21);
            this.radioButtonAfterAOI.TabIndex = 3;
            this.radioButtonAfterAOI.TabStop = true;
            this.radioButtonAfterAOI.Text = "AfterAOI";
            this.radioButtonAfterAOI.UseVisualStyleBackColor = true;
            // 
            // labelWaferMapping
            // 
            this.labelWaferMapping.AutoSize = true;
            this.labelWaferMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaferMapping.Location = new System.Drawing.Point(249, 89);
            this.labelWaferMapping.Name = "labelWaferMapping";
            this.labelWaferMapping.Size = new System.Drawing.Size(342, 46);
            this.labelWaferMapping.TabIndex = 4;
            this.labelWaferMapping.Text = "Repair Wafer LOT";
            // 
            // labelAfterAOI
            // 
            this.labelAfterAOI.AutoSize = true;
            this.labelAfterAOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfterAOI.Location = new System.Drawing.Point(288, 144);
            this.labelAfterAOI.Name = "labelAfterAOI";
            this.labelAfterAOI.Size = new System.Drawing.Size(258, 17);
            this.labelAfterAOI.TabIndex = 5;
            this.labelAfterAOI.Text = "Rename and fix wafer lot show incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAfterAOI);
            this.Controls.Add(this.labelWaferMapping);
            this.Controls.Add(this.radioButtonAfterAOI);
            this.Controls.Add(this.radioButtonWaferMapping);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonWaferMapping;
        private System.Windows.Forms.RadioButton radioButtonAfterAOI;
        private System.Windows.Forms.Label labelWaferMapping;
        private System.Windows.Forms.Label labelAfterAOI;
    }
}

