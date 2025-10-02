// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.PrintWindow
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using SL2_Reckoning_Calculator.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class PrintWindow : Form
{
  private MainWindow MainForm;
  private IContainer components;
  private Label label1;
  private Button SaveButton;
  private PictureBox Sticker;
  private Label label3;

  public PrintWindow(MainWindow main)
  {
    this.MainForm = main;
    this.InitializeComponent();
    this.ReceiveText(main.NewPrintFunction());
  }

  public void ReceiveText(string text) => this.label1.Text = text;

  private void PrintWindow_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.MainForm.ClosedPrintWindow();
  }

  private void SaveButton_Click(object sender, EventArgs e) => this.MainForm.PrintFunction();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label1 = new Label();
    this.SaveButton = new Button();
    this.label3 = new Label();
    this.Sticker = new PictureBox();
    ((ISupportInitialize) this.Sticker).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(112 /*0x70*/, 26);
    this.label1.TabIndex = 0;
    this.label1.Text = "this is a line\r\nand this is another line";
    this.SaveButton.Location = new Point(183, 140);
    this.SaveButton.Name = "SaveButton";
    this.SaveButton.Size = new Size(75, 22);
    this.SaveButton.TabIndex = 137;
    this.SaveButton.Text = "Save";
    this.SaveButton.UseVisualStyleBackColor = true;
    this.SaveButton.Click += new EventHandler(this.SaveButton_Click);
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Segoe Print", 10.75f, FontStyle.Bold);
    this.label3.ForeColor = Color.Crimson;
    this.label3.Location = new Point(165, 85);
    this.label3.Name = "label3";
    this.label3.Size = new Size(114, 52);
    this.label3.TabIndex = 139;
    this.label3.Text = "I NEED CALC\r\n   MILLER\r\n";
    this.Sticker.BackColor = Color.Transparent;
    this.Sticker.BackgroundImage = (Image) Resources.I_NEED_CALC2;
    this.Sticker.BackgroundImageLayout = ImageLayout.Stretch;
    this.Sticker.Location = new Point(183, 12);
    this.Sticker.Name = "Sticker";
    this.Sticker.Size = new Size(75, 70);
    this.Sticker.SizeMode = PictureBoxSizeMode.StretchImage;
    this.Sticker.TabIndex = 138;
    this.Sticker.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(279, 552);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.Sticker);
    this.Controls.Add((Control) this.SaveButton);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (PrintWindow);
    this.Text = nameof (PrintWindow);
    this.FormClosing += new FormClosingEventHandler(this.PrintWindow_FormClosing);
    ((ISupportInitialize) this.Sticker).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
