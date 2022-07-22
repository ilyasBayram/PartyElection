
namespace PartyElection
{
    partial class FormGraphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpBoxGraphs = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxProvince = new System.Windows.Forms.GroupBox();
            this.lblProvinceChoose = new System.Windows.Forms.Label();
            this.cmBoxProvince = new System.Windows.Forms.ComboBox();
            this.lblAParty = new System.Windows.Forms.Label();
            this.progBarAParty = new System.Windows.Forms.ProgressBar();
            this.progBarBParty = new System.Windows.Forms.ProgressBar();
            this.lblBPArty = new System.Windows.Forms.Label();
            this.progBarEParty = new System.Windows.Forms.ProgressBar();
            this.lblEParty = new System.Windows.Forms.Label();
            this.lblDParty = new System.Windows.Forms.Label();
            this.progBarCParty = new System.Windows.Forms.ProgressBar();
            this.lblCParty = new System.Windows.Forms.Label();
            this.progBarDParty = new System.Windows.Forms.ProgressBar();
            this.lblAScore = new System.Windows.Forms.Label();
            this.lblBScore = new System.Windows.Forms.Label();
            this.lblCScore = new System.Windows.Forms.Label();
            this.lblDScore = new System.Windows.Forms.Label();
            this.lblEScore = new System.Windows.Forms.Label();
            this.btnVotePage = new System.Windows.Forms.Button();
            this.grpBoxGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpBoxProvince.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGraphs
            // 
            this.grpBoxGraphs.Controls.Add(this.chart1);
            this.grpBoxGraphs.Location = new System.Drawing.Point(12, 25);
            this.grpBoxGraphs.Name = "grpBoxGraphs";
            this.grpBoxGraphs.Size = new System.Drawing.Size(1064, 375);
            this.grpBoxGraphs.TabIndex = 0;
            this.grpBoxGraphs.TabStop = false;
            this.grpBoxGraphs.Text = "Graphs";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(51, 38);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Parties";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(987, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // grpBoxProvince
            // 
            this.grpBoxProvince.Controls.Add(this.btnVotePage);
            this.grpBoxProvince.Controls.Add(this.lblEScore);
            this.grpBoxProvince.Controls.Add(this.lblDScore);
            this.grpBoxProvince.Controls.Add(this.lblCScore);
            this.grpBoxProvince.Controls.Add(this.lblBScore);
            this.grpBoxProvince.Controls.Add(this.lblAScore);
            this.grpBoxProvince.Controls.Add(this.progBarDParty);
            this.grpBoxProvince.Controls.Add(this.progBarCParty);
            this.grpBoxProvince.Controls.Add(this.lblCParty);
            this.grpBoxProvince.Controls.Add(this.progBarEParty);
            this.grpBoxProvince.Controls.Add(this.lblEParty);
            this.grpBoxProvince.Controls.Add(this.lblDParty);
            this.grpBoxProvince.Controls.Add(this.progBarBParty);
            this.grpBoxProvince.Controls.Add(this.lblBPArty);
            this.grpBoxProvince.Controls.Add(this.progBarAParty);
            this.grpBoxProvince.Controls.Add(this.lblAParty);
            this.grpBoxProvince.Controls.Add(this.cmBoxProvince);
            this.grpBoxProvince.Controls.Add(this.lblProvinceChoose);
            this.grpBoxProvince.Location = new System.Drawing.Point(12, 406);
            this.grpBoxProvince.Name = "grpBoxProvince";
            this.grpBoxProvince.Size = new System.Drawing.Size(1064, 274);
            this.grpBoxProvince.TabIndex = 1;
            this.grpBoxProvince.TabStop = false;
            this.grpBoxProvince.Text = "Choose a province";
            // 
            // lblProvinceChoose
            // 
            this.lblProvinceChoose.AutoSize = true;
            this.lblProvinceChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProvinceChoose.Location = new System.Drawing.Point(35, 36);
            this.lblProvinceChoose.Name = "lblProvinceChoose";
            this.lblProvinceChoose.Size = new System.Drawing.Size(187, 25);
            this.lblProvinceChoose.TabIndex = 0;
            this.lblProvinceChoose.Text = "Choose a province :";
            // 
            // cmBoxProvince
            // 
            this.cmBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBoxProvince.FormattingEnabled = true;
            this.cmBoxProvince.Location = new System.Drawing.Point(244, 33);
            this.cmBoxProvince.Name = "cmBoxProvince";
            this.cmBoxProvince.Size = new System.Drawing.Size(287, 33);
            this.cmBoxProvince.TabIndex = 1;
            this.cmBoxProvince.SelectedIndexChanged += new System.EventHandler(this.cmBoxProvince_SelectedIndexChanged);
            // 
            // lblAParty
            // 
            this.lblAParty.AutoSize = true;
            this.lblAParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAParty.Location = new System.Drawing.Point(46, 125);
            this.lblAParty.Name = "lblAParty";
            this.lblAParty.Size = new System.Drawing.Size(87, 25);
            this.lblAParty.TabIndex = 2;
            this.lblAParty.Text = "A Party :";
            // 
            // progBarAParty
            // 
            this.progBarAParty.Location = new System.Drawing.Point(159, 125);
            this.progBarAParty.Name = "progBarAParty";
            this.progBarAParty.Size = new System.Drawing.Size(214, 25);
            this.progBarAParty.TabIndex = 3;
            // 
            // progBarBParty
            // 
            this.progBarBParty.Location = new System.Drawing.Point(159, 174);
            this.progBarBParty.Name = "progBarBParty";
            this.progBarBParty.Size = new System.Drawing.Size(214, 25);
            this.progBarBParty.TabIndex = 5;
            // 
            // lblBPArty
            // 
            this.lblBPArty.AutoSize = true;
            this.lblBPArty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBPArty.Location = new System.Drawing.Point(46, 174);
            this.lblBPArty.Name = "lblBPArty";
            this.lblBPArty.Size = new System.Drawing.Size(86, 25);
            this.lblBPArty.TabIndex = 4;
            this.lblBPArty.Text = "B Party :";
            // 
            // progBarEParty
            // 
            this.progBarEParty.Location = new System.Drawing.Point(636, 174);
            this.progBarEParty.Name = "progBarEParty";
            this.progBarEParty.Size = new System.Drawing.Size(214, 25);
            this.progBarEParty.TabIndex = 9;
            // 
            // lblEParty
            // 
            this.lblEParty.AutoSize = true;
            this.lblEParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEParty.Location = new System.Drawing.Point(543, 174);
            this.lblEParty.Name = "lblEParty";
            this.lblEParty.Size = new System.Drawing.Size(86, 25);
            this.lblEParty.TabIndex = 8;
            this.lblEParty.Text = "E Party :";
            // 
            // lblDParty
            // 
            this.lblDParty.AutoSize = true;
            this.lblDParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDParty.Location = new System.Drawing.Point(543, 125);
            this.lblDParty.Name = "lblDParty";
            this.lblDParty.Size = new System.Drawing.Size(87, 25);
            this.lblDParty.TabIndex = 6;
            this.lblDParty.Text = "D Party :";
            // 
            // progBarCParty
            // 
            this.progBarCParty.Location = new System.Drawing.Point(159, 227);
            this.progBarCParty.Name = "progBarCParty";
            this.progBarCParty.Size = new System.Drawing.Size(214, 25);
            this.progBarCParty.TabIndex = 11;
            // 
            // lblCParty
            // 
            this.lblCParty.AutoSize = true;
            this.lblCParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCParty.Location = new System.Drawing.Point(46, 227);
            this.lblCParty.Name = "lblCParty";
            this.lblCParty.Size = new System.Drawing.Size(88, 25);
            this.lblCParty.TabIndex = 10;
            this.lblCParty.Text = "C Party :";
            // 
            // progBarDParty
            // 
            this.progBarDParty.Location = new System.Drawing.Point(636, 125);
            this.progBarDParty.Name = "progBarDParty";
            this.progBarDParty.Size = new System.Drawing.Size(214, 25);
            this.progBarDParty.TabIndex = 12;
            // 
            // lblAScore
            // 
            this.lblAScore.AutoSize = true;
            this.lblAScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAScore.Location = new System.Drawing.Point(379, 125);
            this.lblAScore.Name = "lblAScore";
            this.lblAScore.Size = new System.Drawing.Size(23, 25);
            this.lblAScore.TabIndex = 13;
            this.lblAScore.Text = "0";
            // 
            // lblBScore
            // 
            this.lblBScore.AutoSize = true;
            this.lblBScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBScore.Location = new System.Drawing.Point(379, 174);
            this.lblBScore.Name = "lblBScore";
            this.lblBScore.Size = new System.Drawing.Size(23, 25);
            this.lblBScore.TabIndex = 14;
            this.lblBScore.Text = "0";
            // 
            // lblCScore
            // 
            this.lblCScore.AutoSize = true;
            this.lblCScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCScore.Location = new System.Drawing.Point(379, 227);
            this.lblCScore.Name = "lblCScore";
            this.lblCScore.Size = new System.Drawing.Size(23, 25);
            this.lblCScore.TabIndex = 15;
            this.lblCScore.Text = "0";
            // 
            // lblDScore
            // 
            this.lblDScore.AutoSize = true;
            this.lblDScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDScore.Location = new System.Drawing.Point(856, 125);
            this.lblDScore.Name = "lblDScore";
            this.lblDScore.Size = new System.Drawing.Size(23, 25);
            this.lblDScore.TabIndex = 16;
            this.lblDScore.Text = "0";
            // 
            // lblEScore
            // 
            this.lblEScore.AutoSize = true;
            this.lblEScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEScore.Location = new System.Drawing.Point(856, 174);
            this.lblEScore.Name = "lblEScore";
            this.lblEScore.Size = new System.Drawing.Size(23, 25);
            this.lblEScore.TabIndex = 17;
            this.lblEScore.Text = "0";
            // 
            // btnVotePage
            // 
            this.btnVotePage.Location = new System.Drawing.Point(799, 25);
            this.btnVotePage.Name = "btnVotePage";
            this.btnVotePage.Size = new System.Drawing.Size(216, 49);
            this.btnVotePage.TabIndex = 18;
            this.btnVotePage.Text = "Vote Page";
            this.btnVotePage.UseVisualStyleBackColor = true;
            this.btnVotePage.Click += new System.EventHandler(this.btnVotePage_Click);
            // 
            // FormGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 692);
            this.Controls.Add(this.grpBoxProvince);
            this.Controls.Add(this.grpBoxGraphs);
            this.Name = "FormGraphs";
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.FormGraphs_Load);
            this.grpBoxGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpBoxProvince.ResumeLayout(false);
            this.grpBoxProvince.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox grpBoxProvince;
        private System.Windows.Forms.ProgressBar progBarEParty;
        private System.Windows.Forms.Label lblEParty;
        private System.Windows.Forms.Label lblDParty;
        private System.Windows.Forms.ProgressBar progBarBParty;
        private System.Windows.Forms.Label lblBPArty;
        private System.Windows.Forms.ProgressBar progBarAParty;
        private System.Windows.Forms.Label lblAParty;
        private System.Windows.Forms.ComboBox cmBoxProvince;
        private System.Windows.Forms.Label lblProvinceChoose;
        private System.Windows.Forms.ProgressBar progBarCParty;
        private System.Windows.Forms.Label lblCParty;
        private System.Windows.Forms.ProgressBar progBarDParty;
        private System.Windows.Forms.Label lblEScore;
        private System.Windows.Forms.Label lblDScore;
        private System.Windows.Forms.Label lblCScore;
        private System.Windows.Forms.Label lblBScore;
        private System.Windows.Forms.Label lblAScore;
        private System.Windows.Forms.Button btnVotePage;
    }
}