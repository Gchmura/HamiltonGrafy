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
			this.SuspendLayout();
			// 
			// wpfHost
			// 
			this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.wpfHost.BackColor = System.Drawing.Color.White;
			this.wpfHost.Location = new System.Drawing.Point(0, 0);
			this.wpfHost.Name = "wpfHost";
			this.wpfHost.Size = new System.Drawing.Size(544, 458);
			this.wpfHost.TabIndex = 1;
			this.wpfHost.Text = "elementHost1";
			this.wpfHost.Child = null;
			// 
			// txb_prob
			// 
			this.txb_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txb_prob.Location = new System.Drawing.Point(672, 115);
			this.txb_prob.Name = "txb_prob";
			this.txb_prob.Size = new System.Drawing.Size(38, 20);
			this.txb_prob.TabIndex = 3;
			this.txb_prob.Text = "0.95";
			// 
			// lbl_prob
			// 
			this.lbl_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_prob.AutoSize = true;
			this.lbl_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_prob.Location = new System.Drawing.Point(564, 117);
			this.lbl_prob.Name = "lbl_prob";
			this.lbl_prob.Size = new System.Drawing.Size(102, 13);
			this.lbl_prob.TabIndex = 4;
			this.lbl_prob.Text = "Edge probability:";
			// 
			// lbl_weight
			// 
			this.lbl_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_weight.AutoSize = true;
			this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_weight.Location = new System.Drawing.Point(584, 192);
			this.lbl_weight.Name = "lbl_weight";
			this.lbl_weight.Size = new System.Drawing.Size(82, 13);
			this.lbl_weight.TabIndex = 7;
			this.lbl_weight.Text = "Weight layer:";
			// 
			// lbl_weight_layer
			// 
			this.lbl_weight_layer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_weight_layer.AutoSize = true;
			this.lbl_weight_layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_weight_layer.Location = new System.Drawing.Point(664, 188);
			this.lbl_weight_layer.Name = "lbl_weight_layer";
			this.lbl_weight_layer.Size = new System.Drawing.Size(19, 20);
			this.lbl_weight_layer.TabIndex = 8;
			this.lbl_weight_layer.Text = "1";
			// 
			// lbl_mut
			// 
			this.lbl_mut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_mut.AutoSize = true;
			this.lbl_mut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_mut.Location = new System.Drawing.Point(547, 304);
			this.lbl_mut.Name = "lbl_mut";
			this.lbl_mut.Size = new System.Drawing.Size(122, 13);
			this.lbl_mut.TabIndex = 10;
			this.lbl_mut.Text = "Mutation probability:";
			// 
			// txb_mut_prob
			// 
			this.txb_mut_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_mut_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txb_mut_prob.Location = new System.Drawing.Point(679, 301);
			this.txb_mut_prob.Name = "txb_mut_prob";
			this.txb_mut_prob.Size = new System.Drawing.Size(33, 20);
			this.txb_mut_prob.TabIndex = 11;
			this.txb_mut_prob.Text = "0.05";
			// 
			// lbl_pop
			// 
			this.lbl_pop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_pop.AutoSize = true;
			this.lbl_pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_pop.Location = new System.Drawing.Point(547, 276);
			this.lbl_pop.Name = "lbl_pop";
			this.lbl_pop.Size = new System.Drawing.Size(97, 13);
			this.lbl_pop.TabIndex = 12;
			this.lbl_pop.Text = "Population size:";
			// 
			// txb_pop_size
			// 
			this.txb_pop_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_pop_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txb_pop_size.Location = new System.Drawing.Point(679, 273);
			this.txb_pop_size.Name = "txb_pop_size";
			this.txb_pop_size.Size = new System.Drawing.Size(33, 20);
			this.txb_pop_size.TabIndex = 13;
			this.txb_pop_size.Text = "121";
			// 
			// lbl_iters
			// 
			this.lbl_iters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_iters.AutoSize = true;
			this.lbl_iters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_iters.Location = new System.Drawing.Point(547, 248);
			this.lbl_iters.Name = "lbl_iters";
			this.lbl_iters.Size = new System.Drawing.Size(64, 13);
			this.lbl_iters.TabIndex = 14;
			this.lbl_iters.Text = "Iterations:";
			// 
			// txb_iter_count
			// 
			this.txb_iter_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_iter_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txb_iter_count.Location = new System.Drawing.Point(679, 245);
			this.txb_iter_count.Name = "txb_iter_count";
			this.txb_iter_count.Size = new System.Drawing.Size(33, 20);
			this.txb_iter_count.TabIndex = 15;
			this.txb_iter_count.Text = "400";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "DarkGreen",
            "Black",
            "DarkViolet",
            "Coral",
            "Gold"});
			this.comboBox1.Location = new System.Drawing.Point(595, 407);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(72, 21);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.Text = "Blue";
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(547, 409);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Colors:";
			// 
			// ButtonDatasetLocation
			// 
			this.ButtonDatasetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonDatasetLocation.BackColor = System.Drawing.SystemColors.Menu;
			this.ButtonDatasetLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonDatasetLocation.Location = new System.Drawing.Point(553, 6);
			this.ButtonDatasetLocation.Name = "ButtonDatasetLocation";
			this.ButtonDatasetLocation.Size = new System.Drawing.Size(159, 22);
			this.ButtonDatasetLocation.TabIndex = 23;
			this.ButtonDatasetLocation.Text = "Choose dataset location";
			this.ButtonDatasetLocation.UseVisualStyleBackColor = true;
			this.ButtonDatasetLocation.Click += new System.EventHandler(this.ButtonDatasetLocation_Click);
			// 
			// btnHide
			// 
			this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnHide.Location = new System.Drawing.Point(630, 335);
			this.btnHide.Margin = new System.Windows.Forms.Padding(2);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(90, 49);
			this.btnHide.TabIndex = 22;
			this.btnHide.Text = "Hide edges";
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// Btn_start
			// 
			this.Btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Btn_start.Location = new System.Drawing.Point(546, 337);
			this.Btn_start.Margin = new System.Windows.Forms.Padding(2);
			this.Btn_start.Name = "Btn_start";
			this.Btn_start.Size = new System.Drawing.Size(80, 45);
			this.Btn_start.TabIndex = 21;
			this.Btn_start.Text = "Start evolution";
			this.Btn_start.UseVisualStyleBackColor = true;
			this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click_1);
			// 
			// btn_nxtWeights
			// 
			this.btn_nxtWeights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_nxtWeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_nxtWeights.Location = new System.Drawing.Point(584, 147);
			this.btn_nxtWeights.Margin = new System.Windows.Forms.Padding(2);
			this.btn_nxtWeights.Name = "btn_nxtWeights";
			this.btn_nxtWeights.Size = new System.Drawing.Size(100, 36);
			this.btn_nxtWeights.TabIndex = 20;
			this.btn_nxtWeights.Text = "Next weights";
			this.btn_nxtWeights.UseVisualStyleBackColor = true;
			this.btn_nxtWeights.Click += new System.EventHandler(this.btn_nxtWeights_Click);
			// 
			// Btn_reload
			// 
			this.Btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Btn_reload.Location = new System.Drawing.Point(631, 42);
			this.Btn_reload.Margin = new System.Windows.Forms.Padding(2);
			this.Btn_reload.Name = "Btn_reload";
			this.Btn_reload.Size = new System.Drawing.Size(89, 61);
			this.Btn_reload.TabIndex = 19;
			this.Btn_reload.Text = "Rearrange";
			this.Btn_reload.UseVisualStyleBackColor = true;
			this.Btn_reload.Click += new System.EventHandler(this.Btn_reload_Click);
			// 
			// btn_generate
			// 
			this.btn_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_generate.Location = new System.Drawing.Point(546, 42);
			this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
			this.btn_generate.Name = "btn_generate";
			this.btn_generate.Size = new System.Drawing.Size(89, 61);
			this.btn_generate.TabIndex = 18;
			this.btn_generate.Text = "Generate";
			this.btn_generate.UseVisualStyleBackColor = true;
			this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(721, 458);
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
	}
}

