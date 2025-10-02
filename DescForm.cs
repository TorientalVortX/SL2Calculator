// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.DescForm
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class DescForm : Form
{
  public WeaponCalculator WeaponForm;
  private int DescPower;
  private int DescCrit;
  private int DescAcc;
  private int DescWeight;
  private int DescRarity;
  private int DescCritMod;
  private string WeaponName;
  private IContainer components;
  private TextBox WeaponDesc;
  private TextBox WeaponEffect;
  private Label WeaponNameLbl;
  private Label PowerLbl;
  private Label AccuracyLbl;
  private Label CriticalLbl;
  private Label WeightLbl;
  private Label CritModLbl;
  private Label PowerValue;
  private Label CritModValue;
  private Label WeightValue;
  private Label CritValue;
  private Label AccuracyValue;
  private TextBox WeaponPotential;
  private Label Rarity;
  private Label label2;
  private TextBox SpecialStrike;

  public DescForm(WeaponCalculator that)
  {
    this.InitializeComponent();
    this.WeaponForm = that;
  }

  private void DescForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.WeaponForm.DescFormClose();
  }

  public void DescUpdate()
  {
    this.WeaponName = this.WeaponForm.WeaponChoice;
    this.DescPower = (int) this.WeaponForm.Power;
    this.DescCrit = (int) this.WeaponForm.Critical;
    this.DescAcc = (int) this.WeaponForm.Accuracy;
    this.DescWeight = (int) this.WeaponForm.Weight;
    this.DescRarity = (int) this.WeaponForm.RarityW;
    this.DescCritMod = (int) this.WeaponForm.CriticalModifier;
    this.WeaponNameLbl.Text = this.WeaponName + string.Empty;
    this.PowerValue.Text = this.DescPower.ToString() + string.Empty;
    this.CritValue.Text = this.DescCrit.ToString() + string.Empty;
    this.AccuracyValue.Text = this.DescAcc.ToString() + string.Empty;
    this.WeightValue.Text = this.DescWeight.ToString() + string.Empty;
    this.CritModValue.Text = this.DescCritMod.ToString() + "%";
    this.Rarity.Text = this.DescRarity.ToString() + string.Empty;
    string str = "\r\n";
    this.WeaponDesc.Text = $"Weapon Description:{str}{this.WeaponForm.WeaponDesc}";
    this.WeaponEffect.Text = $"Weapon Effect:{str}{this.WeaponForm.WeaponEffect}";
    this.WeaponPotential.Text = $"Weapon Potential:{str}{this.WeaponForm.WeaponPotential}";
    this.SpecialStrike.Text = $"Special Strike:{str}{this.WeaponForm.WeaponSpecialStrike}";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.WeaponDesc = new TextBox();
    this.WeaponEffect = new TextBox();
    this.WeaponNameLbl = new Label();
    this.PowerLbl = new Label();
    this.AccuracyLbl = new Label();
    this.CriticalLbl = new Label();
    this.WeightLbl = new Label();
    this.CritModLbl = new Label();
    this.PowerValue = new Label();
    this.CritModValue = new Label();
    this.WeightValue = new Label();
    this.CritValue = new Label();
    this.AccuracyValue = new Label();
    this.WeaponPotential = new TextBox();
    this.Rarity = new Label();
    this.label2 = new Label();
    this.SpecialStrike = new TextBox();
    this.SuspendLayout();
    this.WeaponDesc.Location = new Point(7, 182);
    this.WeaponDesc.Multiline = true;
    this.WeaponDesc.Name = "WeaponDesc";
    this.WeaponDesc.ReadOnly = true;
    this.WeaponDesc.Size = new Size(507, 103);
    this.WeaponDesc.TabIndex = 0;
    this.WeaponDesc.Text = "Weapon Description:";
    this.WeaponEffect.Location = new Point(7, 291);
    this.WeaponEffect.Multiline = true;
    this.WeaponEffect.Name = "WeaponEffect";
    this.WeaponEffect.ReadOnly = true;
    this.WeaponEffect.Size = new Size(507, 101);
    this.WeaponEffect.TabIndex = 1;
    this.WeaponEffect.Text = "Weapon Effect:";
    this.WeaponNameLbl.AutoSize = true;
    this.WeaponNameLbl.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.WeaponNameLbl.Location = new Point(22, 9);
    this.WeaponNameLbl.Name = "WeaponNameLbl";
    this.WeaponNameLbl.Size = new Size(155, 25);
    this.WeaponNameLbl.TabIndex = 2;
    this.WeaponNameLbl.Text = "Weapon Name";
    this.PowerLbl.AutoSize = true;
    this.PowerLbl.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.PowerLbl.Location = new Point(46, 48 /*0x30*/);
    this.PowerLbl.Name = "PowerLbl";
    this.PowerLbl.Size = new Size(61, 20);
    this.PowerLbl.TabIndex = 3;
    this.PowerLbl.Text = "Power:";
    this.AccuracyLbl.AutoSize = true;
    this.AccuracyLbl.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.AccuracyLbl.Location = new Point(23, 68);
    this.AccuracyLbl.Name = "AccuracyLbl";
    this.AccuracyLbl.Size = new Size(84, 20);
    this.AccuracyLbl.TabIndex = 4;
    this.AccuracyLbl.Text = "Accuracy:";
    this.CriticalLbl.AutoSize = true;
    this.CriticalLbl.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.CriticalLbl.Location = new Point(40, 88);
    this.CriticalLbl.Name = "CriticalLbl";
    this.CriticalLbl.Size = new Size(67, 20);
    this.CriticalLbl.TabIndex = 5;
    this.CriticalLbl.Text = "Critical:";
    this.WeightLbl.AutoSize = true;
    this.WeightLbl.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.WeightLbl.Location = new Point(40, 108);
    this.WeightLbl.Name = "WeightLbl";
    this.WeightLbl.Size = new Size(66, 20);
    this.WeightLbl.TabIndex = 6;
    this.WeightLbl.Text = "Weight:";
    this.CritModLbl.AutoSize = true;
    this.CritModLbl.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.CritModLbl.Location = new Point(3, 128 /*0x80*/);
    this.CritModLbl.Name = "CritModLbl";
    this.CritModLbl.Size = new Size(104, 20);
    this.CritModLbl.TabIndex = 7;
    this.CritModLbl.Text = "Critical Mod:";
    this.PowerValue.AutoSize = true;
    this.PowerValue.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.PowerValue.Location = new Point(113, 51);
    this.PowerValue.Name = "PowerValue";
    this.PowerValue.Size = new Size(16 /*0x10*/, 17);
    this.PowerValue.TabIndex = 8;
    this.PowerValue.Text = "0";
    this.CritModValue.AutoSize = true;
    this.CritModValue.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.CritModValue.Location = new Point(113, 128 /*0x80*/);
    this.CritModValue.Name = "CritModValue";
    this.CritModValue.Size = new Size(16 /*0x10*/, 17);
    this.CritModValue.TabIndex = 9;
    this.CritModValue.Text = "0";
    this.WeightValue.AutoSize = true;
    this.WeightValue.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.WeightValue.Location = new Point(113, 111);
    this.WeightValue.Name = "WeightValue";
    this.WeightValue.Size = new Size(16 /*0x10*/, 17);
    this.WeightValue.TabIndex = 10;
    this.WeightValue.Text = "0";
    this.CritValue.AutoSize = true;
    this.CritValue.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.CritValue.Location = new Point(113, 91);
    this.CritValue.Name = "CritValue";
    this.CritValue.Size = new Size(16 /*0x10*/, 17);
    this.CritValue.TabIndex = 11;
    this.CritValue.Text = "0";
    this.AccuracyValue.AutoSize = true;
    this.AccuracyValue.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.AccuracyValue.Location = new Point(113, 71);
    this.AccuracyValue.Name = "AccuracyValue";
    this.AccuracyValue.Size = new Size(16 /*0x10*/, 17);
    this.AccuracyValue.TabIndex = 12;
    this.AccuracyValue.Text = "0";
    this.WeaponPotential.Location = new Point(157, 48 /*0x30*/);
    this.WeaponPotential.Multiline = true;
    this.WeaponPotential.Name = "WeaponPotential";
    this.WeaponPotential.ReadOnly = true;
    this.WeaponPotential.Size = new Size(357, 128 /*0x80*/);
    this.WeaponPotential.TabIndex = 13;
    this.WeaponPotential.Text = "Weapon Potential:";
    this.Rarity.AutoSize = true;
    this.Rarity.Font = new Font("Microsoft Sans Serif", 10.25f);
    this.Rarity.Location = new Point(113, 151);
    this.Rarity.Name = "Rarity";
    this.Rarity.Size = new Size(16 /*0x10*/, 17);
    this.Rarity.TabIndex = 15;
    this.Rarity.Text = "0";
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Microsoft Sans Serif", 12.25f);
    this.label2.Location = new Point(46, 148);
    this.label2.Name = "label2";
    this.label2.Size = new Size(58, 20);
    this.label2.TabIndex = 14;
    this.label2.Text = "Rarity:";
    this.SpecialStrike.Location = new Point(7, 398);
    this.SpecialStrike.Multiline = true;
    this.SpecialStrike.Name = "SpecialStrike";
    this.SpecialStrike.ReadOnly = true;
    this.SpecialStrike.Size = new Size(507, 156);
    this.SpecialStrike.TabIndex = 16 /*0x10*/;
    this.SpecialStrike.Text = "Special Strike:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(526, 560);
    this.Controls.Add((Control) this.SpecialStrike);
    this.Controls.Add((Control) this.Rarity);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.WeaponPotential);
    this.Controls.Add((Control) this.AccuracyValue);
    this.Controls.Add((Control) this.CritValue);
    this.Controls.Add((Control) this.WeightValue);
    this.Controls.Add((Control) this.CritModValue);
    this.Controls.Add((Control) this.PowerValue);
    this.Controls.Add((Control) this.CritModLbl);
    this.Controls.Add((Control) this.WeightLbl);
    this.Controls.Add((Control) this.CriticalLbl);
    this.Controls.Add((Control) this.AccuracyLbl);
    this.Controls.Add((Control) this.PowerLbl);
    this.Controls.Add((Control) this.WeaponNameLbl);
    this.Controls.Add((Control) this.WeaponEffect);
    this.Controls.Add((Control) this.WeaponDesc);
    this.Name = nameof (DescForm);
    this.Text = "Weapon Description";
    this.FormClosing += new FormClosingEventHandler(this.DescForm_FormClosing);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
