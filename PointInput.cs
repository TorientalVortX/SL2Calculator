// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.PointInput
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class PointInput : Form
{
  private string TargetStat;
  private string TargetOperation;
  private MainWindow ParentForm;
  private IContainer components;
  private Button ConfirmButton;
  private NumericUpDown NumberEntry;

  public PointInput(MainWindow OriginForm, string StatName, string Operation)
  {
    this.InitializeComponent();
    this.Text = $"{StatName} {Operation}";
    this.TargetStat = StatName;
    this.TargetOperation = Operation;
    this.ParentForm = OriginForm;
  }

  private void ConfirmButton_Click(object sender, EventArgs e)
  {
    this.ParentForm.RetrievePointInput(Convert.ToInt32(this.NumberEntry.Value), this.TargetStat, this.TargetOperation);
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.ConfirmButton = new Button();
    this.NumberEntry = new NumericUpDown();
    this.NumberEntry.BeginInit();
    this.SuspendLayout();
    this.ConfirmButton.Location = new Point(136, 12);
    this.ConfirmButton.Name = "ConfirmButton";
    this.ConfirmButton.Size = new Size(75, 23);
    this.ConfirmButton.TabIndex = 0;
    this.ConfirmButton.Text = "Confirm";
    this.ConfirmButton.UseVisualStyleBackColor = true;
    this.ConfirmButton.Click += new EventHandler(this.ConfirmButton_Click);
    this.NumberEntry.Location = new Point(12, 13);
    this.NumberEntry.Maximum = new Decimal(new int[4]
    {
      240 /*0xF0*/,
      0,
      0,
      0
    });
    this.NumberEntry.Name = "NumberEntry";
    this.NumberEntry.Size = new Size(118, 20);
    this.NumberEntry.TabIndex = 1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(304, 42);
    this.Controls.Add((Control) this.NumberEntry);
    this.Controls.Add((Control) this.ConfirmButton);
    this.Name = nameof (PointInput);
    this.Text = "Form2";
    this.NumberEntry.EndInit();
    this.ResumeLayout(false);
  }
}
