namespace practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BFuncion = new System.Windows.Forms.Button();
            this.LBNumeros = new System.Windows.Forms.ListBox();
            this.ChartNumeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BPares = new System.Windows.Forms.Button();
            this.BImpares = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.Location = new System.Drawing.Point(29, 44);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(70, 24);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.Location = new System.Drawing.Point(26, 91);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(73, 25);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(105, 48);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(116, 20);
            this.TDesde.TabIndex = 2;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(105, 96);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(116, 20);
            this.THasta.TabIndex = 3;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // BFuncion
            // 
            this.BFuncion.Location = new System.Drawing.Point(105, 144);
            this.BFuncion.Name = "BFuncion";
            this.BFuncion.Size = new System.Drawing.Size(116, 32);
            this.BFuncion.TabIndex = 4;
            this.BFuncion.Text = "Generar función";
            this.BFuncion.UseVisualStyleBackColor = true;
            this.BFuncion.Click += new System.EventHandler(this.BFuncion_Click);
            // 
            // LBNumeros
            // 
            this.LBNumeros.BackColor = System.Drawing.SystemColors.Info;
            this.LBNumeros.FormattingEnabled = true;
            this.LBNumeros.Location = new System.Drawing.Point(255, 35);
            this.LBNumeros.Name = "LBNumeros";
            this.LBNumeros.Size = new System.Drawing.Size(416, 368);
            this.LBNumeros.TabIndex = 7;
            // 
            // ChartNumeros
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartNumeros.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartNumeros.Legends.Add(legend2);
            this.ChartNumeros.Location = new System.Drawing.Point(321, 44);
            this.ChartNumeros.Name = "ChartNumeros";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Orden";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Pares";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Impares";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Primos";
            this.ChartNumeros.Series.Add(series5);
            this.ChartNumeros.Series.Add(series6);
            this.ChartNumeros.Series.Add(series7);
            this.ChartNumeros.Series.Add(series8);
            this.ChartNumeros.Size = new System.Drawing.Size(340, 348);
            this.ChartNumeros.TabIndex = 8;
            this.ChartNumeros.Text = "chart1";
            // 
            // BPares
            // 
            this.BPares.Location = new System.Drawing.Point(105, 195);
            this.BPares.Name = "BPares";
            this.BPares.Size = new System.Drawing.Size(116, 32);
            this.BPares.TabIndex = 9;
            this.BPares.Text = "Numeros pares";
            this.BPares.UseVisualStyleBackColor = true;
            this.BPares.Click += new System.EventHandler(this.BPares_Click);
            // 
            // BImpares
            // 
            this.BImpares.Location = new System.Drawing.Point(105, 244);
            this.BImpares.Name = "BImpares";
            this.BImpares.Size = new System.Drawing.Size(116, 32);
            this.BImpares.TabIndex = 10;
            this.BImpares.Text = "Numeros impares";
            this.BImpares.UseVisualStyleBackColor = true;
            this.BImpares.Click += new System.EventHandler(this.BImpares_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(105, 294);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(116, 32);
            this.BPrimos.TabIndex = 11;
            this.BPrimos.Text = "Numeros primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 428);
            this.Controls.Add(this.BPrimos);
            this.Controls.Add(this.BImpares);
            this.Controls.Add(this.BPares);
            this.Controls.Add(this.ChartNumeros);
            this.Controls.Add(this.LBNumeros);
            this.Controls.Add(this.BFuncion);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BFuncion;
        private System.Windows.Forms.ListBox LBNumeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNumeros;
        private System.Windows.Forms.Button BPares;
        private System.Windows.Forms.Button BImpares;
        private System.Windows.Forms.Button BPrimos;
    }
}

