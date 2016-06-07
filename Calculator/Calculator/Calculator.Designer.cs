namespace Calculator
{
    partial class Calculator
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue1Min = new System.Windows.Forms.TextBox();
            this.btnCalmin = new System.Windows.Forms.Button();
            this.txtResultMin = new System.Windows.Forms.TextBox();
            this.lblEqualMin = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.txtValue2Min = new System.Windows.Forms.TextBox();
            this.btnCalim = new System.Windows.Forms.Button();
            this.txtResultIm = new System.Windows.Forms.TextBox();
            this.lblEqualIm = new System.Windows.Forms.Label();
            this.lblIm = new System.Windows.Forms.Label();
            this.txtValue2Im = new System.Windows.Forms.TextBox();
            this.txtValue1Im = new System.Windows.Forms.TextBox();
            this.btnCaldiv = new System.Windows.Forms.Button();
            this.txtResultdiv = new System.Windows.Forms.TextBox();
            this.lblEqualdiv = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.txtValue2div = new System.Windows.Forms.TextBox();
            this.txtValue1div = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(12, 12);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(38, 20);
            this.txtValue1.TabIndex = 0;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(73, 12);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(38, 20);
            this.txtValue2.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(56, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "+";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(117, 15);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(13, 13);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(136, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(82, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(227, 10);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "Topla";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(13, 51);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "made by Nuri";
            // 
            // txtValue1Min
            // 
            this.txtValue1Min.Location = new System.Drawing.Point(12, 51);
            this.txtValue1Min.Name = "txtValue1Min";
            this.txtValue1Min.Size = new System.Drawing.Size(38, 20);
            this.txtValue1Min.TabIndex = 8;
            // 
            // btnCalmin
            // 
            this.btnCalmin.Location = new System.Drawing.Point(227, 49);
            this.btnCalmin.Name = "btnCalmin";
            this.btnCalmin.Size = new System.Drawing.Size(75, 23);
            this.btnCalmin.TabIndex = 13;
            this.btnCalmin.Text = "Çıkar";
            this.btnCalmin.UseVisualStyleBackColor = true;
            this.btnCalmin.Click += new System.EventHandler(this.btnCalmin_Click);
            // 
            // txtResultMin
            // 
            this.txtResultMin.Location = new System.Drawing.Point(136, 51);
            this.txtResultMin.Name = "txtResultMin";
            this.txtResultMin.Size = new System.Drawing.Size(82, 20);
            this.txtResultMin.TabIndex = 12;
            // 
            // lblEqualMin
            // 
            this.lblEqualMin.AutoSize = true;
            this.lblEqualMin.Location = new System.Drawing.Point(117, 54);
            this.lblEqualMin.Name = "lblEqualMin";
            this.lblEqualMin.Size = new System.Drawing.Size(13, 13);
            this.lblEqualMin.TabIndex = 11;
            this.lblEqualMin.Text = "=";
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Location = new System.Drawing.Point(56, 54);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(10, 13);
            this.lblMinus.TabIndex = 10;
            this.lblMinus.Text = "-";
            // 
            // txtValue2Min
            // 
            this.txtValue2Min.Location = new System.Drawing.Point(73, 51);
            this.txtValue2Min.Name = "txtValue2Min";
            this.txtValue2Min.Size = new System.Drawing.Size(38, 20);
            this.txtValue2Min.TabIndex = 9;
            // 
            // btnCalim
            // 
            this.btnCalim.Location = new System.Drawing.Point(227, 86);
            this.btnCalim.Name = "btnCalim";
            this.btnCalim.Size = new System.Drawing.Size(75, 23);
            this.btnCalim.TabIndex = 19;
            this.btnCalim.Text = "Çarp";
            this.btnCalim.UseVisualStyleBackColor = true;
            this.btnCalim.Click += new System.EventHandler(this.btnCalim_Click);
            // 
            // txtResultIm
            // 
            this.txtResultIm.Location = new System.Drawing.Point(136, 88);
            this.txtResultIm.Name = "txtResultIm";
            this.txtResultIm.Size = new System.Drawing.Size(82, 20);
            this.txtResultIm.TabIndex = 18;
            // 
            // lblEqualIm
            // 
            this.lblEqualIm.AutoSize = true;
            this.lblEqualIm.Location = new System.Drawing.Point(117, 91);
            this.lblEqualIm.Name = "lblEqualIm";
            this.lblEqualIm.Size = new System.Drawing.Size(13, 13);
            this.lblEqualIm.TabIndex = 17;
            this.lblEqualIm.Text = "=";
            // 
            // lblIm
            // 
            this.lblIm.AutoSize = true;
            this.lblIm.Location = new System.Drawing.Point(56, 91);
            this.lblIm.Name = "lblIm";
            this.lblIm.Size = new System.Drawing.Size(11, 13);
            this.lblIm.TabIndex = 16;
            this.lblIm.Text = "*";
            // 
            // txtValue2Im
            // 
            this.txtValue2Im.Location = new System.Drawing.Point(73, 88);
            this.txtValue2Im.Name = "txtValue2Im";
            this.txtValue2Im.Size = new System.Drawing.Size(38, 20);
            this.txtValue2Im.TabIndex = 15;
            // 
            // txtValue1Im
            // 
            this.txtValue1Im.Location = new System.Drawing.Point(12, 88);
            this.txtValue1Im.Name = "txtValue1Im";
            this.txtValue1Im.Size = new System.Drawing.Size(38, 20);
            this.txtValue1Im.TabIndex = 14;
            // 
            // btnCaldiv
            // 
            this.btnCaldiv.Location = new System.Drawing.Point(227, 123);
            this.btnCaldiv.Name = "btnCaldiv";
            this.btnCaldiv.Size = new System.Drawing.Size(75, 23);
            this.btnCaldiv.TabIndex = 25;
            this.btnCaldiv.Text = "Böl";
            this.btnCaldiv.UseVisualStyleBackColor = true;
            this.btnCaldiv.Click += new System.EventHandler(this.btnCaldiv_Click);
            // 
            // txtResultdiv
            // 
            this.txtResultdiv.Location = new System.Drawing.Point(136, 125);
            this.txtResultdiv.Name = "txtResultdiv";
            this.txtResultdiv.Size = new System.Drawing.Size(82, 20);
            this.txtResultdiv.TabIndex = 24;
            // 
            // lblEqualdiv
            // 
            this.lblEqualdiv.AutoSize = true;
            this.lblEqualdiv.Location = new System.Drawing.Point(117, 128);
            this.lblEqualdiv.Name = "lblEqualdiv";
            this.lblEqualdiv.Size = new System.Drawing.Size(13, 13);
            this.lblEqualdiv.TabIndex = 23;
            this.lblEqualdiv.Text = "=";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Location = new System.Drawing.Point(56, 128);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(12, 13);
            this.lblDiv.TabIndex = 22;
            this.lblDiv.Text = "/";
            // 
            // txtValue2div
            // 
            this.txtValue2div.Location = new System.Drawing.Point(73, 125);
            this.txtValue2div.Name = "txtValue2div";
            this.txtValue2div.Size = new System.Drawing.Size(38, 20);
            this.txtValue2div.TabIndex = 21;
            // 
            // txtValue1div
            // 
            this.txtValue1div.Location = new System.Drawing.Point(12, 125);
            this.txtValue1div.Name = "txtValue1div";
            this.txtValue1div.Size = new System.Drawing.Size(38, 20);
            this.txtValue1div.TabIndex = 20;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 219);
            this.Controls.Add(this.btnCaldiv);
            this.Controls.Add(this.txtResultdiv);
            this.Controls.Add(this.lblEqualdiv);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.txtValue2div);
            this.Controls.Add(this.txtValue1div);
            this.Controls.Add(this.btnCalim);
            this.Controls.Add(this.txtResultIm);
            this.Controls.Add(this.lblEqualIm);
            this.Controls.Add(this.lblIm);
            this.Controls.Add(this.txtValue2Im);
            this.Controls.Add(this.txtValue1Im);
            this.Controls.Add(this.btnCalmin);
            this.Controls.Add(this.txtResultMin);
            this.Controls.Add(this.lblEqualMin);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.txtValue2Min);
            this.Controls.Add(this.txtValue1Min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "Calculator";
            this.Text = "Calculator-Nuri v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue1Min;
        private System.Windows.Forms.Button btnCalmin;
        private System.Windows.Forms.TextBox txtResultMin;
        private System.Windows.Forms.Label lblEqualMin;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.TextBox txtValue2Min;
        private System.Windows.Forms.Button btnCalim;
        private System.Windows.Forms.TextBox txtResultIm;
        private System.Windows.Forms.Label lblEqualIm;
        private System.Windows.Forms.Label lblIm;
        private System.Windows.Forms.TextBox txtValue2Im;
        private System.Windows.Forms.TextBox txtValue1Im;
        private System.Windows.Forms.Button btnCaldiv;
        private System.Windows.Forms.TextBox txtResultdiv;
        private System.Windows.Forms.Label lblEqualdiv;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.TextBox txtValue2div;
        private System.Windows.Forms.TextBox txtValue1div;
    }
}

