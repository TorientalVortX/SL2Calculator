// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.DRDebug
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class DRDebug : Form
{
  private double CalculatedValue;
  private IContainer components;
  private NumericUpDown TotalInput;
  private NumericUpDown RacialInput;
  private Label label1;
  private Label label2;
  private Label CalculationLabel;
  private Button DiminishButton;
  private Label label3;

  public DRDebug() => this.InitializeComponent();

  private void DiminishButton_Click(object sender, EventArgs e) => this.UpdateNumber();

  private void UpdateNumber()
  {
    this.CalculatedValue = this.ReturnEffectiveStat((int) this.RacialInput.Value, (int) this.TotalInput.Value);
    this.CalculationLabel.Text = this.CalculatedValue.ToString();
  }

  private double ReturnEffectiveStat(int RacialStat, int TotalStat)
  {
    int num1 = RacialStat + 40;
    int num2 = TotalStat;
    if (num1 >= num2)
      return (double) num2;
    double num3 = (double) num1;
    int num4 = num2 - num1;
    double num5 = 0.9;
    while (num4 > 3)
    {
      num4 -= 3;
      num3 += 3.0 * num5;
      num5 -= 0.08;
      if (num5 < 0.1)
        num5 = 0.1;
    }
    return num3 + (double) num4 * num5;
  }

  private void RacialInput_ValueChanged(object sender, EventArgs e) => this.UpdateNumber();

  private void TotalInput_ValueChanged(object sender, EventArgs e) => this.UpdateNumber();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.TotalInput = new NumericUpDown();
    this.RacialInput = new NumericUpDown();
    this.label1 = new Label();
    this.label2 = new Label();
    this.CalculationLabel = new Label();
    this.DiminishButton = new Button();
    this.label3 = new Label();
    this.TotalInput.BeginInit();
    this.RacialInput.BeginInit();
    this.SuspendLayout();
    this.TotalInput.Location = new Point(93, 30);
    this.TotalInput.Name = "TotalInput";
    this.TotalInput.Size = new Size(120, 20);
    this.TotalInput.TabIndex = 0;
    this.TotalInput.ValueChanged += new EventHandler(this.TotalInput_ValueChanged);
    this.RacialInput.Location = new Point(13, 30);
    this.RacialInput.Name = "RacialInput";
    this.RacialInput.Size = new Size(74, 20);
    this.RacialInput.TabIndex = 1;
    this.RacialInput.ValueChanged += new EventHandler(this.RacialInput_ValueChanged);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(37, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Racial";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(93, 13);
    this.label2.Name = "label2";
    this.label2.Size = new Size(31 /*0x1F*/, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Total";
    this.CalculationLabel.AutoSize = true;
    this.CalculationLabel.Location = new Point(230, 36);
    this.CalculationLabel.Name = "CalculationLabel";
    this.CalculationLabel.Size = new Size(13, 13);
    this.CalculationLabel.TabIndex = 5;
    this.CalculationLabel.Text = "0";
    this.DiminishButton.Location = new Point(233, 3);
    this.DiminishButton.Name = "DiminishButton";
    this.DiminishButton.Size = new Size(75, 23);
    this.DiminishButton.TabIndex = 6;
    this.DiminishButton.Text = "Diminish";
    this.DiminishButton.UseVisualStyleBackColor = true;
    this.DiminishButton.Click += new EventHandler(this.DiminishButton_Click);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(13, 55);
    this.label3.Name = "label3";
    this.label3.Size = new Size(303, 26);
    this.label3.TabIndex = 7;
    this.label3.Text = "Be aware that this version of the DR formula is not the same as\r\nthe main calc and may be outdated at any point.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(327, 88);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.DiminishButton);
    this.Controls.Add((Control) this.CalculationLabel);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.RacialInput);
    this.Controls.Add((Control) this.TotalInput);
    this.Name = nameof (DRDebug);
    this.Text = "Diminishing Returns Debug";
    this.TotalInput.EndInit();
    this.RacialInput.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
