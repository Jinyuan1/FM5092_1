namespace FM5092_A1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtsigma = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtsteps = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioCall = new System.Windows.Forms.RadioButton();
            this.radioPut = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblGamma = new System.Windows.Forms.Label();
            this.lblVega = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.lblRho = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.lblStd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(160, 59);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 28);
            this.txtS.TabIndex = 0;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(160, 93);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 28);
            this.txtK.TabIndex = 1;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // txtsigma
            // 
            this.txtsigma.Location = new System.Drawing.Point(160, 127);
            this.txtsigma.Name = "txtsigma";
            this.txtsigma.Size = new System.Drawing.Size(100, 28);
            this.txtsigma.TabIndex = 2;
            this.txtsigma.TextChanged += new System.EventHandler(this.txtsigma_TextChanged);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(160, 161);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 28);
            this.txtr.TabIndex = 3;
            this.txtr.TextChanged += new System.EventHandler(this.txtr_TextChanged);
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(160, 195);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 28);
            this.txtT.TabIndex = 4;
            this.txtT.TextChanged += new System.EventHandler(this.txtT_TextChanged);
            // 
            // txtsteps
            // 
            this.txtsteps.Location = new System.Drawing.Point(160, 250);
            this.txtsteps.Name = "txtsteps";
            this.txtsteps.Size = new System.Drawing.Size(100, 28);
            this.txtsteps.TabIndex = 5;
            this.txtsteps.TextChanged += new System.EventHandler(this.txtsteps_TextChanged);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(160, 291);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 28);
            this.txtN.TabIndex = 6;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Underlying Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Strike Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Volatility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Risk-free rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tenor (in years)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "steps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trails";
            // 
            // radioCall
            // 
            this.radioCall.AutoSize = true;
            this.radioCall.Location = new System.Drawing.Point(60, 340);
            this.radioCall.Name = "radioCall";
            this.radioCall.Size = new System.Drawing.Size(132, 22);
            this.radioCall.TabIndex = 14;
            this.radioCall.TabStop = true;
            this.radioCall.Text = "Call Option";
            this.radioCall.UseVisualStyleBackColor = true;
            // 
            // radioPut
            // 
            this.radioPut.AutoSize = true;
            this.radioPut.Location = new System.Drawing.Point(60, 368);
            this.radioPut.Name = "radioPut";
            this.radioPut.Size = new System.Drawing.Size(123, 22);
            this.radioPut.TabIndex = 15;
            this.radioPut.TabStop = true;
            this.radioPut.Text = "Put Option";
            this.radioPut.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Delta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(584, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gamma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Vega";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(730, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Theta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(801, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Rho";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Euro Option";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(411, 59);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 18);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "null";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(493, 59);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(44, 18);
            this.lblDelta.TabIndex = 24;
            this.lblDelta.Text = "null";
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(584, 59);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(44, 18);
            this.lblGamma.TabIndex = 25;
            this.lblGamma.Text = "null";
            // 
            // lblVega
            // 
            this.lblVega.AutoSize = true;
            this.lblVega.Location = new System.Drawing.Point(666, 59);
            this.lblVega.Name = "lblVega";
            this.lblVega.Size = new System.Drawing.Size(44, 18);
            this.lblVega.TabIndex = 26;
            this.lblVega.Text = "null";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(739, 59);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(44, 18);
            this.lblTheta.TabIndex = 27;
            this.lblTheta.Text = "null";
            // 
            // lblRho
            // 
            this.lblRho.AutoSize = true;
            this.lblRho.Location = new System.Drawing.Point(801, 59);
            this.lblRho.Name = "lblRho";
            this.lblRho.Size = new System.Drawing.Size(44, 18);
            this.lblRho.TabIndex = 28;
            this.lblRho.Text = "null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(739, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Standard error";
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Location = new System.Drawing.Point(774, 240);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(44, 18);
            this.lblStd.TabIndex = 31;
            this.lblStd.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 414);
            this.Controls.Add(this.lblStd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRho);
            this.Controls.Add(this.lblTheta);
            this.Controls.Add(this.lblVega);
            this.Controls.Add(this.lblGamma);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioPut);
            this.Controls.Add(this.radioCall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtsteps);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtsigma);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtsigma;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtsteps;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioCall;
        private System.Windows.Forms.RadioButton radioPut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.Label lblVega;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Label lblRho;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblStd;
        private System.Windows.Forms.Label label15;
    }
}

