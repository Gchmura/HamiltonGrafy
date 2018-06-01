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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.wpfHost.Size = new System.Drawing.Size(1106, 809);
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
            this.roundButton3.Location = new System.Drawing.Point(0, 792);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(89, 34);
            this.roundButton3.TabIndex = 27;
            this.roundButton3.Text = "Save...";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(1406, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(219, 129);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Location = new System.Drawing.Point(1406, 198);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(219, 129);
            this.listView2.TabIndex = 29;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Location = new System.Drawing.Point(1406, 333);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(219, 129);
            this.listView3.TabIndex = 30;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView4.Location = new System.Drawing.Point(1406, 468);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(219, 131);
            this.listView4.TabIndex = 31;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1406, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "------";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1586, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "------";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1406, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "------";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1586, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "------";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1406, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "------";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1586, 774);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "------";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1430, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Evolutions:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1567, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1451, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "The best cycles:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1637, 830);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
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
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
    }
}

