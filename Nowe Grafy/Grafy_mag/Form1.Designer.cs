namespace Grafy_mag
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.txb_prob = new System.Windows.Forms.TextBox();
            this.lbl_prob = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_weight_layer = new System.Windows.Forms.Label();
            this.lbl_mut = new System.Windows.Forms.Label();
            this.txb_mut_prob = new System.Windows.Forms.TextBox();
            this.lbl_pop = new System.Windows.Forms.Label();
            this.txb_pop_size = new System.Windows.Forms.TextBox();
            this.lbl_iters = new System.Windows.Forms.Label();
            this.txb_iter_count = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDatasetLocation = new System.Windows.Forms.Button();
            this.btnHide = new Grafy_mag.RoundButton();
            this.Btn_start = new Grafy_mag.RoundButton();
            this.btn_nxtWeights = new Grafy_mag.RoundButton();
            this.Btn_reload = new Grafy_mag.RoundButton();
            this.btn_generate = new Grafy_mag.RoundButton();
            this.labelPath = new System.Windows.Forms.Label();
            this.roundButton1 = new Grafy_mag.RoundButton();
            this.roundButton2 = new Grafy_mag.RoundButton();
            this.roundButton3 = new Grafy_mag.RoundButton();
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(293, 7);
            this.wpfHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(796, 794);
            this.wpfHost.TabIndex = 1;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // txb_prob
            // 
            this.txb_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_prob.Location = new System.Drawing.Point(215, 188);
            this.txb_prob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_prob.Name = "txb_prob";
            this.txb_prob.Size = new System.Drawing.Size(55, 26);
            this.txb_prob.TabIndex = 3;
            this.txb_prob.Text = "0.95";
            // 
            // lbl_prob
            // 
            this.lbl_prob.AutoSize = true;
            this.lbl_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_prob.Location = new System.Drawing.Point(53, 191);
            this.lbl_prob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prob.Name = "lbl_prob";
            this.lbl_prob.Size = new System.Drawing.Size(143, 20);
            this.lbl_prob.TabIndex = 4;
            this.lbl_prob.Text = "Edge probability:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weight.Location = new System.Drawing.Point(83, 295);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(113, 20);
            this.lbl_weight.TabIndex = 7;
            this.lbl_weight.Text = "Weight layer:";
            // 
            // lbl_weight_layer
            // 
            this.lbl_weight_layer.AutoSize = true;
            this.lbl_weight_layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weight_layer.Location = new System.Drawing.Point(203, 289);
            this.lbl_weight_layer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight_layer.Name = "lbl_weight_layer";
            this.lbl_weight_layer.Size = new System.Drawing.Size(27, 29);
            this.lbl_weight_layer.TabIndex = 8;
            this.lbl_weight_layer.Text = "1";
            // 
            // lbl_mut
            // 
            this.lbl_mut.AutoSize = true;
            this.lbl_mut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mut.Location = new System.Drawing.Point(27, 468);
            this.lbl_mut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mut.Name = "lbl_mut";
            this.lbl_mut.Size = new System.Drawing.Size(171, 20);
            this.lbl_mut.TabIndex = 10;
            this.lbl_mut.Text = "Mutation probability:";
            // 
            // txb_mut_prob
            // 
            this.txb_mut_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_mut_prob.Location = new System.Drawing.Point(225, 463);
            this.txb_mut_prob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_mut_prob.Name = "txb_mut_prob";
            this.txb_mut_prob.Size = new System.Drawing.Size(48, 26);
            this.txb_mut_prob.TabIndex = 11;
            this.txb_mut_prob.Text = "0.05";
            // 
            // lbl_pop
            // 
            this.lbl_pop.AutoSize = true;
            this.lbl_pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_pop.Location = new System.Drawing.Point(27, 425);
            this.lbl_pop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pop.Name = "lbl_pop";
            this.lbl_pop.Size = new System.Drawing.Size(136, 20);
            this.lbl_pop.TabIndex = 12;
            this.lbl_pop.Text = "Population size:";
            // 
            // txb_pop_size
            // 
            this.txb_pop_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_pop_size.Location = new System.Drawing.Point(225, 420);
            this.txb_pop_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_pop_size.Name = "txb_pop_size";
            this.txb_pop_size.Size = new System.Drawing.Size(48, 26);
            this.txb_pop_size.TabIndex = 13;
            this.txb_pop_size.Text = "121";
            // 
            // lbl_iters
            // 
            this.lbl_iters.AutoSize = true;
            this.lbl_iters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_iters.Location = new System.Drawing.Point(27, 382);
            this.lbl_iters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iters.Name = "lbl_iters";
            this.lbl_iters.Size = new System.Drawing.Size(91, 20);
            this.lbl_iters.TabIndex = 14;
            this.lbl_iters.Text = "Iterations:";
            // 
            // txb_iter_count
            // 
            this.txb_iter_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_iter_count.Location = new System.Drawing.Point(225, 377);
            this.txb_iter_count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_iter_count.Name = "txb_iter_count";
            this.txb_iter_count.Size = new System.Drawing.Size(48, 26);
            this.txb_iter_count.TabIndex = 15;
            this.txb_iter_count.Text = "400";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "DarkGreen",
            "Black",
            "DarkViolet",
            "Coral",
            "Gold"});
            this.comboBox1.Location = new System.Drawing.Point(99, 626);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Blue";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 629);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Colors:";
            // 
            // ButtonDatasetLocation
            // 
            this.ButtonDatasetLocation.BackColor = System.Drawing.SystemColors.Menu;
            this.ButtonDatasetLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDatasetLocation.Location = new System.Drawing.Point(32, 9);
            this.ButtonDatasetLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDatasetLocation.Name = "ButtonDatasetLocation";
            this.ButtonDatasetLocation.Size = new System.Drawing.Size(243, 34);
            this.ButtonDatasetLocation.TabIndex = 23;
            this.ButtonDatasetLocation.Text = "Choose dataset location";
            this.ButtonDatasetLocation.UseVisualStyleBackColor = true;
            this.ButtonDatasetLocation.Click += new System.EventHandler(this.ButtonDatasetLocation_Click);
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHide.Location = new System.Drawing.Point(152, 515);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(135, 75);
            this.btnHide.TabIndex = 22;
            this.btnHide.Text = "Hide edges";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Btn_start
            // 
            this.Btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_start.Location = new System.Drawing.Point(26, 518);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(120, 69);
            this.Btn_start.TabIndex = 21;
            this.Btn_start.Text = "Start evolution";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click_1);
            // 
            // btn_nxtWeights
            // 
            this.btn_nxtWeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nxtWeights.Location = new System.Drawing.Point(83, 226);
            this.btn_nxtWeights.Name = "btn_nxtWeights";
            this.btn_nxtWeights.Size = new System.Drawing.Size(150, 55);
            this.btn_nxtWeights.TabIndex = 20;
            this.btn_nxtWeights.Text = "Next weights";
            this.btn_nxtWeights.UseVisualStyleBackColor = true;
            this.btn_nxtWeights.Click += new System.EventHandler(this.btn_nxtWeights_Click);
            // 
            // Btn_reload
            // 
            this.Btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_reload.Location = new System.Drawing.Point(153, 83);
            this.Btn_reload.Name = "Btn_reload";
            this.Btn_reload.Size = new System.Drawing.Size(134, 94);
            this.Btn_reload.TabIndex = 19;
            this.Btn_reload.Text = "Rearrange";
            this.Btn_reload.UseVisualStyleBackColor = true;
            this.Btn_reload.Click += new System.EventHandler(this.Btn_reload_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generate.Location = new System.Drawing.Point(13, 83);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(134, 94);
            this.btn_generate.TabIndex = 18;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click_1);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPath.Location = new System.Drawing.Point(27, 48);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(62, 25);
            this.labelPath.TabIndex = 24;
            this.labelPath.Text = "Path:";
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundButton1.Location = new System.Drawing.Point(57, 667);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(185, 47);
            this.roundButton1.TabIndex = 25;
            this.roundButton1.Text = "Pareto Front";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundButton2.Location = new System.Drawing.Point(57, 739);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(185, 47);
            this.roundButton2.TabIndex = 26;
            this.roundButton2.Text = "Hamilton Cycles";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundButton3.Location = new System.Drawing.Point(0, 780);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(70, 34);
            this.roundButton3.TabIndex = 27;
            this.roundButton3.Text = "Save";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 815);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.ButtonDatasetLocation);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.Btn_start);
            this.Controls.Add(this.btn_nxtWeights);
            this.Controls.Add(this.Btn_reload);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txb_iter_count);
            this.Controls.Add(this.lbl_iters);
            this.Controls.Add(this.txb_pop_size);
            this.Controls.Add(this.lbl_pop);
            this.Controls.Add(this.txb_mut_prob);
            this.Controls.Add(this.lbl_mut);
            this.Controls.Add(this.lbl_weight_layer);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_prob);
            this.Controls.Add(this.txb_prob);
            this.Controls.Add(this.wpfHost);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "GraphsMutations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.TextBox txb_prob;
        private System.Windows.Forms.Label lbl_prob;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_weight_layer;
        private System.Windows.Forms.Label lbl_mut;
        private System.Windows.Forms.TextBox txb_mut_prob;
        private System.Windows.Forms.Label lbl_pop;
        private System.Windows.Forms.TextBox txb_pop_size;
        private System.Windows.Forms.Label lbl_iters;
        private System.Windows.Forms.TextBox txb_iter_count;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private RoundButton btn_generate;
        private RoundButton Btn_reload;
        private RoundButton btn_nxtWeights;
        private RoundButton Btn_start;
        private RoundButton btnHide;
		private System.Windows.Forms.Button ButtonDatasetLocation;
        private System.Windows.Forms.Label labelPath;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
    }
}

