﻿namespace Tikhe_POS
{
	partial class Cust_Chart
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
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartcust = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartcust)).BeginInit();
			this.SuspendLayout();
			// 
			// chartcust
			// 
			chartArea1.Name = "ChartArea1";
			this.chartcust.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartcust.Legends.Add(legend1);
			this.chartcust.Location = new System.Drawing.Point(12, 12);
			this.chartcust.Name = "chartcust";
			this.chartcust.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Male";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Female";
			this.chartcust.Series.Add(series1);
			this.chartcust.Series.Add(series2);
			this.chartcust.Size = new System.Drawing.Size(277, 342);
			this.chartcust.TabIndex = 0;
			this.chartcust.Text = "chart1";
			title1.Name = "Customer Info Chart";
			this.chartcust.Titles.Add(title1);
			this.chartcust.Click += new System.EventHandler(this.Chart_Load);
			// 
			// Cust_Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 364);
			this.Controls.Add(this.chartcust);
			this.Name = "Cust_Chart";
			this.Text = "Cust_Chart";
			this.Load += new System.EventHandler(this.Chart_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartcust)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartcust;
	}
}