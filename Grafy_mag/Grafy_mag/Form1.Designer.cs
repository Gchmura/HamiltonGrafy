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
            this.btn_generate = new System.Windows.Forms.Button();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.btn_reload = new System.Windows.Forms.Button();
            this.txb_prob = new System.Windows.Forms.TextBox();
            this.lbl_prob = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_next_weights = new System.Windows.Forms.Button();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_weight_layer = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_mut = new System.Windows.Forms.Label();
            this.txb_mut_prob = new System.Windows.Forms.TextBox();
            this.lbl_pop = new System.Windows.Forms.Label();
            this.txb_pop_size = new System.Windows.Forms.TextBox();
            this.lbl_iters = new System.Windows.Forms.Label();
            this.txb_iter_count = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generate.Location = new System.Drawing.Point(822, 14);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(100, 52);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(0, 0);
            this.wpfHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(813, 535);
            this.wpfHost.TabIndex = 1;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_reload.Location = new System.Drawing.Point(930, 23);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(111, 35);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Rearrange";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.Btn_reload_Click);
            // 
            // txb_prob
            // 
            this.txb_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_prob.Location = new System.Drawing.Point(972, 81);
            this.txb_prob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_prob.Name = "txb_prob";
            this.txb_prob.Size = new System.Drawing.Size(55, 26);
            this.txb_prob.TabIndex = 3;
            this.txb_prob.Text = "0.95";
            // 
            // lbl_prob
            // 
            this.lbl_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_prob.AutoSize = true;
            this.lbl_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_prob.Location = new System.Drawing.Point(821, 84);
            this.lbl_prob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prob.Name = "lbl_prob";
            this.lbl_prob.Size = new System.Drawing.Size(143, 20);
            this.lbl_prob.TabIndex = 4;
            this.lbl_prob.Text = "Edge probability:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(972, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hide edges";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_next_weights
            // 
            this.btn_next_weights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next_weights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next_weights.Location = new System.Drawing.Point(844, 150);
            this.btn_next_weights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_next_weights.Name = "btn_next_weights";
            this.btn_next_weights.Size = new System.Drawing.Size(150, 32);
            this.btn_next_weights.TabIndex = 6;
            this.btn_next_weights.Text = "Next weights";
            this.btn_next_weights.UseVisualStyleBackColor = true;
            this.btn_next_weights.Click += new System.EventHandler(this.btn_next_weights_Click);
            // 
            // lbl_weight
            // 
            this.lbl_weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weight.Location = new System.Drawing.Point(847, 194);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(113, 20);
            this.lbl_weight.TabIndex = 7;
            this.lbl_weight.Text = "Weight layer:";
            // 
            // lbl_weight_layer
            // 
            this.lbl_weight_layer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_weight_layer.AutoSize = true;
            this.lbl_weight_layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_weight_layer.Location = new System.Drawing.Point(967, 187);
            this.lbl_weight_layer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight_layer.Name = "lbl_weight_layer";
            this.lbl_weight_layer.Size = new System.Drawing.Size(27, 29);
            this.lbl_weight_layer.TabIndex = 8;
            this.lbl_weight_layer.Text = "1";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.Location = new System.Drawing.Point(851, 394);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(150, 43);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start evolution";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_mut
            // 
            this.lbl_mut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mut.AutoSize = true;
            this.lbl_mut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mut.Location = new System.Drawing.Point(821, 349);
            this.lbl_mut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mut.Name = "lbl_mut";
            this.lbl_mut.Size = new System.Drawing.Size(171, 20);
            this.lbl_mut.TabIndex = 10;
            this.lbl_mut.Text = "Mutation probability:";
            // 
            // txb_mut_prob
            // 
            this.txb_mut_prob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_mut_prob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_mut_prob.Location = new System.Drawing.Point(993, 346);
            this.txb_mut_prob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_mut_prob.Name = "txb_mut_prob";
            this.txb_mut_prob.Size = new System.Drawing.Size(48, 26);
            this.txb_mut_prob.TabIndex = 11;
            this.txb_mut_prob.Text = "0.05";
            // 
            // lbl_pop
            // 
            this.lbl_pop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pop.AutoSize = true;
            this.lbl_pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_pop.Location = new System.Drawing.Point(821, 306);
            this.lbl_pop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pop.Name = "lbl_pop";
            this.lbl_pop.Size = new System.Drawing.Size(136, 20);
            this.lbl_pop.TabIndex = 12;
            this.lbl_pop.Text = "Population size:";
            // 
            // txb_pop_size
            // 
            this.txb_pop_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_pop_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_pop_size.Location = new System.Drawing.Point(993, 303);
            this.txb_pop_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_pop_size.Name = "txb_pop_size";
            this.txb_pop_size.Size = new System.Drawing.Size(48, 26);
            this.txb_pop_size.TabIndex = 13;
            this.txb_pop_size.Text = "121";
            // 
            // lbl_iters
            // 
            this.lbl_iters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_iters.AutoSize = true;
            this.lbl_iters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_iters.Location = new System.Drawing.Point(821, 263);
            this.lbl_iters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iters.Name = "lbl_iters";
            this.lbl_iters.Size = new System.Drawing.Size(91, 20);
            this.lbl_iters.TabIndex = 14;
            this.lbl_iters.Text = "Iterations:";
            // 
            // txb_iter_count
            // 
            this.txb_iter_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_iter_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb_iter_count.Location = new System.Drawing.Point(993, 260);
            this.txb_iter_count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_iter_count.Name = "txb_iter_count";
            this.txb_iter_count.Size = new System.Drawing.Size(48, 26);
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
            this.comboBox1.Location = new System.Drawing.Point(820, 495);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Blue";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(821, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Colors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txb_iter_count);
            this.Controls.Add(this.lbl_iters);
            this.Controls.Add(this.txb_pop_size);
            this.Controls.Add(this.lbl_pop);
            this.Controls.Add(this.txb_mut_prob);
            this.Controls.Add(this.lbl_mut);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_weight_layer);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.btn_next_weights);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_prob);
            this.Controls.Add(this.txb_prob);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.wpfHost);
            this.Controls.Add(this.btn_generate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "GraphsMutations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.TextBox txb_prob;
        private System.Windows.Forms.Label lbl_prob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_next_weights;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_weight_layer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_mut;
        private System.Windows.Forms.TextBox txb_mut_prob;
        private System.Windows.Forms.Label lbl_pop;
        private System.Windows.Forms.TextBox txb_pop_size;
        private System.Windows.Forms.Label lbl_iters;
        private System.Windows.Forms.TextBox txb_iter_count;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

