// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.DamageWindow
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class DamageWindow : Form
{
  private MainWindow MainForm;
  private double BaseSWA;
  private double TomePowerMod;
  private double EleAtk;
  private double EleMod;
  private double FlatTotalP;
  private double FlatDMG;
  private double FlatSWAMod;
  private double TotalPower;
  private double InitialDMG;
  private double InitialFlatMod;
  private double Hits;
  private double FinalDMG;
  private double TrueDMG;
  private IContainer components;
  private Label label1;
  private Label label8;
  private NumericUpDown CritMod;
  private Label label7;
  private NumericUpDown FlatTotalPower;
  private Label label6;
  private NumericUpDown SWABox;
  private Label label5;
  private NumericUpDown DamageAmp1;
  private Label label4;
  private Label label3;
  private Label label2;
  private NumericUpDown FlatDamage;
  private NumericUpDown Flat3;
  private NumericUpDown DamageAmp2;
  private NumericUpDown Elangrave;
  private Label label9;
  private Label label10;
  private NumericUpDown Flank;
  private Label label11;
  private NumericUpDown Backstab;
  private Label label12;
  private NumericUpDown Claret;
  private Label label13;
  private NumericUpDown Hunted;
  private CheckBox OneOnOne;
  private Label label14;
  private NumericUpDown Katana;
  private Label label15;
  private NumericUpDown HeavyBow;
  private Label label16;
  private NumericUpDown EmptyPalm;
  private Label label17;
  private NumericUpDown ChargingStrike;
  private Label label18;
  private NumericUpDown BearStance;
  private Label label19;
  private NumericUpDown BearStanceCrit;
  private Label label20;
  private NumericUpDown BattleRush;
  private Label label21;
  private NumericUpDown RuledByAnger;
  private CheckBox MonHun;
  private Label label22;
  private NumericUpDown SWAPercent;
  private Label label23;
  private NumericUpDown EleAtkMod;
  private Label label24;
  private NumericUpDown EleAtk1;
  private Label label25;
  private NumericUpDown TomePower;
  private Label label26;
  private NumericUpDown numericUpDown4;
  private Label label27;
  private NumericUpDown numericUpDown5;
  private Label label28;
  private NumericUpDown Hit;
  private Label label29;
  private NumericUpDown numericUpDown7;
  private Label label30;
  private NumericUpDown Isenshi;
  private Label label31;
  private NumericUpDown ChargedWeapon;
  private Label label32;
  private NumericUpDown EliteEngine;
  private Label label33;
  private NumericUpDown MarkedTarget;
  private Label label34;
  private NumericUpDown numericUpDown1;
  private Label TotalPowerLabel;
  private Label InitialDMGLabel;
  private Label FinalDMGLabel;
  private Label TrueDMGLabel;
  private Label label35;
  private NumericUpDown numericUpDown2;
  private Button button1;
  private Label label36;

  public DamageWindow(MainWindow that)
  {
    this.InitializeComponent();
    this.MainForm = that;
  }

  private void DamageWindow_FormClosed(object sender, FormClosedEventArgs e)
  {
    this.MainForm.ClosedDamageCalculator();
  }

  private void SWABox_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Flat1_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Flat2_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Flat3_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void CritMod_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void DamageAmp1_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void DamageAmp2_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Claret_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Hunted_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Backstab_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Flank_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Elangrave_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void OneOnOne_CheckedChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void EmptyPalm_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void ChargingStrike_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void HeavyBow_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void Katana_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void BearStance_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void BearStanceCrit_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void RuledByAnger_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void BattleRush_ValueChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void MonHun_CheckedChanged(object sender, EventArgs e) => this.DamageFinalized();

  private void label4_Click(object sender, EventArgs e)
  {
  }

  private void UpdateVar(string CalcType, string DMGStep)
  {
    switch (DMGStep)
    {
      case "EleATK":
        this.EleAtk = (double) this.EleAtk1.Value;
        break;
      case "EleMod":
        this.EleMod = (double) this.EleAtkMod.Value;
        break;
      case "FlatPower":
        this.FlatDMG = (double) this.FlatDamage.Value + (double) this.Elangrave.Value * 2.0 + (double) this.Flank.Value * 10.0 + (double) this.Backstab.Value * 2.0;
        break;
      case "FlatTotal":
        this.FlatTotalP = (double) this.FlatTotalPower.Value;
        break;
      case "SWA":
        this.BaseSWA = (double) this.SWABox.Value + this.FlatSWAMod;
        break;
      case "SWAMod":
        this.BaseSWA *= (double) this.SWAPercent.Value * 0.01;
        break;
      case "TomePower":
        this.TomePowerMod = 1.0 + (double) this.TomePower.Value * 0.01;
        break;
    }
    switch (CalcType)
    {
      case "TotalPower":
        this.TotalPower = this.TotalPowerCalc(this.BaseSWA);
        break;
      case "InitialDMG":
        this.InitialDMG = this.InitialDMGCalc(this.TotalPower);
        break;
      case "FinalDMG":
        this.FinalDMG = this.FinalDMGCalc(this.InitialDMG);
        break;
      case "TrueDMG":
        this.TrueDMG = this.TrueDMGCalc(this.InitialDMG);
        break;
    }
  }

  private double TotalPowerCalc(double SWA)
  {
    this.TotalPower = SWA * (1.0 + this.TomePowerMod * 0.01) + this.EleAtk * (1.0 + this.EleMod * 0.01) + this.FlatTotalP;
    this.InitialDMGCalc(this.TotalPower);
    return this.TotalPower;
  }

  private double InitialDMGCalc(double Damage)
  {
    this.InitialDMG = Damage + this.FlatDMG;
    if (this.MarkedTarget.Value >= 1M)
      this.InitialDMG *= 1.15;
    if (this.ChargedWeapon.Value >= 1M)
      this.InitialDMG *= 1.0 + (50.0 - (double) this.EliteEngine.Value * 15.0) * (double) this.ChargedWeapon.Value * 0.01;
    if (this.Isenshi.Value >= 1M)
      this.InitialDMG *= 1.0 + (double) this.Isenshi.Value * 10.0 * 0.01;
    this.InitialDMG = this.InitialDMG / this.Hits + this.InitialFlatMod;
    this.FinalDMGCalc(this.InitialDMG);
    return this.InitialDMG;
  }

  private double FinalDMGCalc(double Damage)
  {
    this.FinalDMG = Damage + this.FlatDMG;
    return this.FinalDMG;
  }

  private double TrueDMGCalc(double Damage)
  {
    this.TrueDMG = Damage + this.FlatDMG;
    return this.TrueDMG;
  }

  private void DamageFinalized()
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label1 = new Label();
    this.label8 = new Label();
    this.CritMod = new NumericUpDown();
    this.label7 = new Label();
    this.FlatTotalPower = new NumericUpDown();
    this.label6 = new Label();
    this.SWABox = new NumericUpDown();
    this.label5 = new Label();
    this.DamageAmp1 = new NumericUpDown();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.FlatDamage = new NumericUpDown();
    this.Flat3 = new NumericUpDown();
    this.DamageAmp2 = new NumericUpDown();
    this.Elangrave = new NumericUpDown();
    this.label9 = new Label();
    this.label10 = new Label();
    this.Flank = new NumericUpDown();
    this.label11 = new Label();
    this.Backstab = new NumericUpDown();
    this.label12 = new Label();
    this.Claret = new NumericUpDown();
    this.label13 = new Label();
    this.Hunted = new NumericUpDown();
    this.OneOnOne = new CheckBox();
    this.label14 = new Label();
    this.Katana = new NumericUpDown();
    this.label15 = new Label();
    this.HeavyBow = new NumericUpDown();
    this.label16 = new Label();
    this.EmptyPalm = new NumericUpDown();
    this.label17 = new Label();
    this.ChargingStrike = new NumericUpDown();
    this.label18 = new Label();
    this.BearStance = new NumericUpDown();
    this.label19 = new Label();
    this.BearStanceCrit = new NumericUpDown();
    this.label20 = new Label();
    this.BattleRush = new NumericUpDown();
    this.label21 = new Label();
    this.RuledByAnger = new NumericUpDown();
    this.MonHun = new CheckBox();
    this.label22 = new Label();
    this.SWAPercent = new NumericUpDown();
    this.label23 = new Label();
    this.EleAtkMod = new NumericUpDown();
    this.label24 = new Label();
    this.EleAtk1 = new NumericUpDown();
    this.label25 = new Label();
    this.TomePower = new NumericUpDown();
    this.label26 = new Label();
    this.numericUpDown4 = new NumericUpDown();
    this.label27 = new Label();
    this.numericUpDown5 = new NumericUpDown();
    this.label28 = new Label();
    this.Hit = new NumericUpDown();
    this.label29 = new Label();
    this.numericUpDown7 = new NumericUpDown();
    this.label30 = new Label();
    this.Isenshi = new NumericUpDown();
    this.label31 = new Label();
    this.ChargedWeapon = new NumericUpDown();
    this.label32 = new Label();
    this.EliteEngine = new NumericUpDown();
    this.label33 = new Label();
    this.MarkedTarget = new NumericUpDown();
    this.label34 = new Label();
    this.numericUpDown1 = new NumericUpDown();
    this.TotalPowerLabel = new Label();
    this.InitialDMGLabel = new Label();
    this.FinalDMGLabel = new Label();
    this.TrueDMGLabel = new Label();
    this.label35 = new Label();
    this.numericUpDown2 = new NumericUpDown();
    this.button1 = new Button();
    this.label36 = new Label();
    this.CritMod.BeginInit();
    this.FlatTotalPower.BeginInit();
    this.SWABox.BeginInit();
    this.DamageAmp1.BeginInit();
    this.FlatDamage.BeginInit();
    this.Flat3.BeginInit();
    this.DamageAmp2.BeginInit();
    this.Elangrave.BeginInit();
    this.Flank.BeginInit();
    this.Backstab.BeginInit();
    this.Claret.BeginInit();
    this.Hunted.BeginInit();
    this.Katana.BeginInit();
    this.HeavyBow.BeginInit();
    this.EmptyPalm.BeginInit();
    this.ChargingStrike.BeginInit();
    this.BearStance.BeginInit();
    this.BearStanceCrit.BeginInit();
    this.BattleRush.BeginInit();
    this.RuledByAnger.BeginInit();
    this.SWAPercent.BeginInit();
    this.EleAtkMod.BeginInit();
    this.EleAtk1.BeginInit();
    this.TomePower.BeginInit();
    this.numericUpDown4.BeginInit();
    this.numericUpDown5.BeginInit();
    this.Hit.BeginInit();
    this.numericUpDown7.BeginInit();
    this.Isenshi.BeginInit();
    this.ChargedWeapon.BeginInit();
    this.EliteEngine.BeginInit();
    this.MarkedTarget.BeginInit();
    this.numericUpDown1.BeginInit();
    this.numericUpDown2.BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(34, 13);
    this.label1.TabIndex = 44;
    this.label1.Text = "(WIP)";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(52, 267);
    this.label8.Name = "label8";
    this.label8.Size = new Size(78, 13);
    this.label8.TabIndex = 41;
    this.label8.Text = "Critical Modifier";
    this.CritMod.Location = new Point(136, 265);
    this.CritMod.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.CritMod.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.CritMod.Name = "CritMod";
    this.CritMod.Size = new Size(67, 20);
    this.CritMod.TabIndex = 40;
    this.CritMod.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.CritMod.ValueChanged += new EventHandler(this.CritMod_ValueChanged);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(16 /*0x10*/, 100);
    this.label7.Name = "label7";
    this.label7.Size = new Size(114, 13);
    this.label7.TabIndex = 39;
    this.label7.Text = "Flat Total Power Boost";
    this.FlatTotalPower.Location = new Point(136, 98);
    this.FlatTotalPower.Name = "FlatTotalPower";
    this.FlatTotalPower.Size = new Size(67, 20);
    this.FlatTotalPower.TabIndex = 38;
    this.FlatTotalPower.ValueChanged += new EventHandler(this.Flat1_ValueChanged);
    this.label6.AutoSize = true;
    this.label6.Location = new Point(12, 31 /*0x1F*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(118, 13);
    this.label6.TabIndex = 37;
    this.label6.Text = "Scaled Weapon Attack";
    this.SWABox.Location = new Point(136, 28);
    this.SWABox.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.SWABox.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.SWABox.Name = "SWABox";
    this.SWABox.Size = new Size(67, 20);
    this.SWABox.TabIndex = 36;
    this.SWABox.ValueChanged += new EventHandler(this.SWABox_ValueChanged);
    this.label5.AutoSize = true;
    this.label5.Location = new Point(31 /*0x1F*/, 318);
    this.label5.Name = "label5";
    this.label5.Size = new Size(98, 13);
    this.label5.TabIndex = 35;
    this.label5.Text = "Damage Modifier %";
    this.DamageAmp1.Location = new Point(135, 316);
    this.DamageAmp1.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.DamageAmp1.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.DamageAmp1.Name = "DamageAmp1";
    this.DamageAmp1.Size = new Size(67, 20);
    this.DamageAmp1.TabIndex = 34;
    this.DamageAmp1.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.DamageAmp1.ValueChanged += new EventHandler(this.DamageAmp1_ValueChanged);
    this.label4.AutoSize = true;
    this.label4.Location = new Point(30, 292);
    this.label4.Name = "label4";
    this.label4.Size = new Size(101, 13);
    this.label4.TabIndex = 33;
    this.label4.Text = "Flat Critical Damage";
    this.label4.Click += new EventHandler(this.label4_Click);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(24, 218);
    this.label3.Name = "label3";
    this.label3.Size = new Size(105, 13);
    this.label3.TabIndex = 32 /*0x20*/;
    this.label3.Text = "Special Flat Damage";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(30, 146);
    this.label2.Name = "label2";
    this.label2.Size = new Size(97, 13);
    this.label2.TabIndex = 31 /*0x1F*/;
    this.label2.Text = "Flat Damage Boost";
    this.FlatDamage.Location = new Point(136, 144 /*0x90*/);
    this.FlatDamage.Name = "FlatDamage";
    this.FlatDamage.Size = new Size(67, 20);
    this.FlatDamage.TabIndex = 30;
    this.FlatDamage.ValueChanged += new EventHandler(this.Flat2_ValueChanged);
    this.Flat3.Location = new Point(136, 216);
    this.Flat3.Name = "Flat3";
    this.Flat3.Size = new Size(67, 20);
    this.Flat3.TabIndex = 29;
    this.Flat3.ValueChanged += new EventHandler(this.Flat3_ValueChanged);
    this.DamageAmp2.Location = new Point(136, 290);
    this.DamageAmp2.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.DamageAmp2.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.DamageAmp2.Name = "DamageAmp2";
    this.DamageAmp2.Size = new Size(67, 20);
    this.DamageAmp2.TabIndex = 28;
    this.DamageAmp2.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.DamageAmp2.ValueChanged += new EventHandler(this.DamageAmp2_ValueChanged);
    this.Elangrave.Location = new Point(606, 103);
    this.Elangrave.Maximum = new Decimal(new int[4]
    {
      13,
      0,
      0,
      0
    });
    this.Elangrave.Name = "Elangrave";
    this.Elangrave.Size = new Size(34, 20);
    this.Elangrave.TabIndex = 45;
    this.Elangrave.ValueChanged += new EventHandler(this.Elangrave_ValueChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(477, 105);
    this.label9.Name = "label9";
    this.label9.Size = new Size(110, 13);
    this.label9.TabIndex = 46;
    this.label9.Text = "Elangrave Momentum";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(554, 133);
    this.label10.Name = "label10";
    this.label10.Size = new Size(33, 13);
    this.label10.TabIndex = 48 /*0x30*/;
    this.label10.Text = "Flank";
    this.Flank.Location = new Point(606, 131);
    this.Flank.Maximum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.Flank.Name = "Flank";
    this.Flank.Size = new Size(34, 20);
    this.Flank.TabIndex = 47;
    this.Flank.ValueChanged += new EventHandler(this.Flank_ValueChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(506, 159);
    this.label11.Name = "label11";
    this.label11.Size = new Size(81, 13);
    this.label11.TabIndex = 50;
    this.label11.Text = "Backstab Rank";
    this.Backstab.Location = new Point(606, 157);
    this.Backstab.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.Backstab.Name = "Backstab";
    this.Backstab.Size = new Size(34, 20);
    this.Backstab.TabIndex = 49;
    this.Backstab.ValueChanged += new EventHandler(this.Backstab_ValueChanged);
    this.label12.AutoSize = true;
    this.label12.Location = new Point(523, 407);
    this.label12.Name = "label12";
    this.label12.Size = new Size(63 /*0x3F*/, 13);
    this.label12.TabIndex = 52;
    this.label12.Text = "Claret Level";
    this.Claret.Location = new Point(592, 405);
    this.Claret.Maximum = new Decimal(new int[4]
    {
      55,
      0,
      0,
      0
    });
    this.Claret.Name = "Claret";
    this.Claret.Size = new Size(47, 20);
    this.Claret.TabIndex = 51;
    this.Claret.ValueChanged += new EventHandler(this.Claret_ValueChanged);
    this.label13.AutoSize = true;
    this.label13.Location = new Point(515, 435);
    this.label13.Name = "label13";
    this.label13.Size = new Size(71, 13);
    this.label13.TabIndex = 54;
    this.label13.Text = "Hunted Level";
    this.Hunted.Location = new Point(592, 433);
    this.Hunted.Name = "Hunted";
    this.Hunted.Size = new Size(47, 20);
    this.Hunted.TabIndex = 53;
    this.Hunted.ValueChanged += new EventHandler(this.Hunted_ValueChanged);
    this.OneOnOne.AutoSize = true;
    this.OneOnOne.Location = new Point(555, 459);
    this.OneOnOne.Name = "OneOnOne";
    this.OneOnOne.Size = new Size(84, 17);
    this.OneOnOne.TabIndex = 55;
    this.OneOnOne.Text = "One on One";
    this.OneOnOne.UseVisualStyleBackColor = true;
    this.OneOnOne.CheckedChanged += new EventHandler(this.OneOnOne_CheckedChanged);
    this.label14.AutoSize = true;
    this.label14.Location = new Point(511 /*0x01FF*/, 185);
    this.label14.Name = "label14";
    this.label14.Size = new Size(76, 13);
    this.label14.TabIndex = 57;
    this.label14.Text = "Katana Master";
    this.Katana.Location = new Point(606, 183);
    this.Katana.Maximum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.Katana.Name = "Katana";
    this.Katana.Size = new Size(34, 20);
    this.Katana.TabIndex = 56;
    this.Katana.ValueChanged += new EventHandler(this.Katana_ValueChanged);
    this.label15.AutoSize = true;
    this.label15.Location = new Point(484, 213);
    this.label15.Name = "label15";
    this.label15.Size = new Size(103, 13);
    this.label15.TabIndex = 59;
    this.label15.Text = "Heavy Bow M Rank";
    this.HeavyBow.Location = new Point(606, 211);
    this.HeavyBow.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.HeavyBow.Name = "HeavyBow";
    this.HeavyBow.Size = new Size(34, 20);
    this.HeavyBow.TabIndex = 58;
    this.HeavyBow.ValueChanged += new EventHandler(this.HeavyBow_ValueChanged);
    this.label16.AutoSize = true;
    this.label16.Location = new Point(525, 240 /*0xF0*/);
    this.label16.Name = "label16";
    this.label16.Size = new Size(62, 13);
    this.label16.TabIndex = 61;
    this.label16.Text = "Empty Palm";
    this.EmptyPalm.Location = new Point(606, 238);
    this.EmptyPalm.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.EmptyPalm.Name = "EmptyPalm";
    this.EmptyPalm.Size = new Size(34, 20);
    this.EmptyPalm.TabIndex = 60;
    this.EmptyPalm.ValueChanged += new EventHandler(this.EmptyPalm_ValueChanged);
    this.label17.AutoSize = true;
    this.label17.Location = new Point(508, 266);
    this.label17.Name = "label17";
    this.label17.Size = new Size(79, 13);
    this.label17.TabIndex = 63 /*0x3F*/;
    this.label17.Text = "Charging Strike";
    this.ChargingStrike.Location = new Point(606, 264);
    this.ChargingStrike.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.ChargingStrike.Name = "ChargingStrike";
    this.ChargingStrike.Size = new Size(34, 20);
    this.ChargingStrike.TabIndex = 62;
    this.ChargingStrike.ValueChanged += new EventHandler(this.ChargingStrike_ValueChanged);
    this.label18.AutoSize = true;
    this.label18.Location = new Point(505, 295);
    this.label18.Name = "label18";
    this.label18.Size = new Size(82, 13);
    this.label18.TabIndex = 65;
    this.label18.Text = "Bear Stance LV";
    this.BearStance.Increment = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.BearStance.Location = new Point(606, 290);
    this.BearStance.Maximum = new Decimal(new int[4]
    {
      30,
      0,
      0,
      0
    });
    this.BearStance.Name = "BearStance";
    this.BearStance.Size = new Size(34, 20);
    this.BearStance.TabIndex = 64 /*0x40*/;
    this.BearStance.ValueChanged += new EventHandler(this.BearStance_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.Location = new Point(503, 320);
    this.label19.Name = "label19";
    this.label19.Size = new Size(84, 13);
    this.label19.TabIndex = 67;
    this.label19.Text = "Bear Stance Crit";
    this.BearStanceCrit.Location = new Point(606, 316);
    this.BearStanceCrit.Maximum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.BearStanceCrit.Name = "BearStanceCrit";
    this.BearStanceCrit.Size = new Size(34, 20);
    this.BearStanceCrit.TabIndex = 66;
    this.BearStanceCrit.ValueChanged += new EventHandler(this.BearStanceCrit_ValueChanged);
    this.label20.AutoSize = true;
    this.label20.Location = new Point(509, 345);
    this.label20.Name = "label20";
    this.label20.Size = new Size(78, 13);
    this.label20.TabIndex = 69;
    this.label20.Text = "Battle Rush LV";
    this.BattleRush.Location = new Point(606, 343);
    this.BattleRush.Maximum = new Decimal(new int[4]
    {
      30,
      0,
      0,
      0
    });
    this.BattleRush.Name = "BattleRush";
    this.BattleRush.Size = new Size(34, 20);
    this.BattleRush.TabIndex = 68;
    this.BattleRush.ValueChanged += new EventHandler(this.BattleRush_ValueChanged);
    this.label21.AutoSize = true;
    this.label21.Location = new Point(505, 372);
    this.label21.Name = "label21";
    this.label21.Size = new Size(81, 13);
    this.label21.TabIndex = 71;
    this.label21.Text = "Ruled By Anger";
    this.RuledByAnger.Location = new Point(606, 370);
    this.RuledByAnger.Maximum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.RuledByAnger.Name = "RuledByAnger";
    this.RuledByAnger.Size = new Size(34, 20);
    this.RuledByAnger.TabIndex = 70;
    this.RuledByAnger.ValueChanged += new EventHandler(this.RuledByAnger_ValueChanged);
    this.MonHun.AutoSize = true;
    this.MonHun.Location = new Point(555, 480);
    this.MonHun.Name = "MonHun";
    this.MonHun.Size = new Size(99, 17);
    this.MonHun.TabIndex = 72;
    this.MonHun.Text = "Monster Hunter";
    this.MonHun.UseVisualStyleBackColor = true;
    this.MonHun.CheckedChanged += new EventHandler(this.MonHun_CheckedChanged);
    this.label22.AutoSize = true;
    this.label22.Location = new Point(209, 31 /*0x1F*/);
    this.label22.Name = "label22";
    this.label22.Size = new Size(43, 13);
    this.label22.TabIndex = 74;
    this.label22.Text = "SWA %";
    this.SWAPercent.Location = new Point(253, 29);
    this.SWAPercent.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.SWAPercent.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.SWAPercent.Name = "SWAPercent";
    this.SWAPercent.Size = new Size(67, 20);
    this.SWAPercent.TabIndex = 73;
    this.label23.AutoSize = true;
    this.label23.Location = new Point(209, 76);
    this.label23.Name = "label23";
    this.label23.Size = new Size(38, 13);
    this.label23.TabIndex = 78;
    this.label23.Text = "ELE %";
    this.EleAtkMod.Location = new Point(253, 73);
    this.EleAtkMod.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.EleAtkMod.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.EleAtkMod.Name = "EleAtkMod";
    this.EleAtkMod.Size = new Size(67, 20);
    this.EleAtkMod.TabIndex = 77;
    this.label24.AutoSize = true;
    this.label24.Location = new Point(43, 76);
    this.label24.Name = "label24";
    this.label24.Size = new Size(87, 13);
    this.label24.TabIndex = 76;
    this.label24.Text = "Elemental Attack";
    this.EleAtk1.Location = new Point(136, 73);
    this.EleAtk1.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.EleAtk1.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.EleAtk1.Name = "EleAtk1";
    this.EleAtk1.Size = new Size(67, 20);
    this.EleAtk1.TabIndex = 75;
    this.label25.AutoSize = true;
    this.label25.Location = new Point(20, 53);
    this.label25.Name = "label25";
    this.label25.Size = new Size(107, 13);
    this.label25.TabIndex = 80 /*0x50*/;
    this.label25.Text = "Tome Power Modifier";
    this.TomePower.Location = new Point(136, 51);
    this.TomePower.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.TomePower.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.TomePower.Name = "TomePower";
    this.TomePower.Size = new Size(67, 20);
    this.TomePower.TabIndex = 79;
    this.TomePower.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.label26.AutoSize = true;
    this.label26.Location = new Point(39, 124);
    this.label26.Name = "label26";
    this.label26.Size = new Size(88, 13);
    this.label26.TabIndex = 82;
    this.label26.Text = "Total Power Mod";
    this.numericUpDown4.Location = new Point(136, 122);
    this.numericUpDown4.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.numericUpDown4.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.numericUpDown4.Name = "numericUpDown4";
    this.numericUpDown4.Size = new Size(67, 20);
    this.numericUpDown4.TabIndex = 81;
    this.numericUpDown4.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.label27.AutoSize = true;
    this.label27.Location = new Point(45, 170);
    this.label27.Name = "label27";
    this.label27.Size = new Size(82, 13);
    this.label27.TabIndex = 84;
    this.label27.Text = "Special Modifier";
    this.numericUpDown5.Location = new Point(136, 168);
    this.numericUpDown5.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.numericUpDown5.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.numericUpDown5.Name = "numericUpDown5";
    this.numericUpDown5.Size = new Size(67, 20);
    this.numericUpDown5.TabIndex = 83;
    this.numericUpDown5.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.label28.AutoSize = true;
    this.label28.Location = new Point(57, 194);
    this.label28.Name = "label28";
    this.label28.Size = new Size(70, 13);
    this.label28.TabIndex = 86;
    this.label28.Text = "Damage Split";
    this.Hit.Location = new Point(136, 192 /*0xC0*/);
    this.Hit.Name = "Hit";
    this.Hit.Size = new Size(67, 20);
    this.Hit.TabIndex = 85;
    this.label29.AutoSize = true;
    this.label29.Location = new Point(38, 242);
    this.label29.Name = "label29";
    this.label29.Size = new Size(91, 13);
    this.label29.TabIndex = 88;
    this.label29.Text = "Special Modifier 2";
    this.numericUpDown7.Location = new Point(136, 240 /*0xF0*/);
    this.numericUpDown7.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.numericUpDown7.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.numericUpDown7.Name = "numericUpDown7";
    this.numericUpDown7.Size = new Size(67, 20);
    this.numericUpDown7.TabIndex = 87;
    this.numericUpDown7.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.label30.AutoSize = true;
    this.label30.Location = new Point(518, 81);
    this.label30.Name = "label30";
    this.label30.Size = new Size(69, 13);
    this.label30.TabIndex = 90;
    this.label30.Text = "Isenshi Rank";
    this.Isenshi.Location = new Point(606, 79);
    this.Isenshi.Maximum = new Decimal(new int[4]
    {
      13,
      0,
      0,
      0
    });
    this.Isenshi.Name = "Isenshi";
    this.Isenshi.Size = new Size(34, 20);
    this.Isenshi.TabIndex = 89;
    this.label31.AutoSize = true;
    this.label31.Location = new Point(501, 57);
    this.label31.Name = "label31";
    this.label31.Size = new Size(85, 13);
    this.label31.TabIndex = 92;
    this.label31.Text = "Charge Weapon";
    this.ChargedWeapon.Location = new Point(606, 55);
    this.ChargedWeapon.Maximum = new Decimal(new int[4]
    {
      13,
      0,
      0,
      0
    });
    this.ChargedWeapon.Name = "ChargedWeapon";
    this.ChargedWeapon.Size = new Size(34, 20);
    this.ChargedWeapon.TabIndex = 91;
    this.label32.AutoSize = true;
    this.label32.Location = new Point(523, 31 /*0x1F*/);
    this.label32.Name = "label32";
    this.label32.Size = new Size(63 /*0x3F*/, 13);
    this.label32.TabIndex = 94;
    this.label32.Text = "Elite Engine";
    this.EliteEngine.Location = new Point(606, 29);
    this.EliteEngine.Maximum = new Decimal(new int[4]
    {
      13,
      0,
      0,
      0
    });
    this.EliteEngine.Name = "EliteEngine";
    this.EliteEngine.Size = new Size(34, 20);
    this.EliteEngine.TabIndex = 93;
    this.label33.AutoSize = true;
    this.label33.Location = new Point(509, 9);
    this.label33.Name = "label33";
    this.label33.Size = new Size(77, 13);
    this.label33.TabIndex = 96 /*0x60*/;
    this.label33.Text = "Marked Target";
    this.MarkedTarget.Location = new Point(606, 7);
    this.MarkedTarget.Maximum = new Decimal(new int[4]
    {
      13,
      0,
      0,
      0
    });
    this.MarkedTarget.Name = "MarkedTarget";
    this.MarkedTarget.Size = new Size(34, 20);
    this.MarkedTarget.TabIndex = 95;
    this.label34.AutoSize = true;
    this.label34.Location = new Point(209, 267);
    this.label34.Name = "label34";
    this.label34.Size = new Size(75, 13);
    this.label34.TabIndex = 98;
    this.label34.Text = "WPN Crit Mod";
    this.numericUpDown1.Location = new Point(290, 265);
    this.numericUpDown1.Maximum = new Decimal(new int[4]
    {
      300,
      0,
      0,
      0
    });
    this.numericUpDown1.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.numericUpDown1.Name = "numericUpDown1";
    this.numericUpDown1.Size = new Size(67, 20);
    this.numericUpDown1.TabIndex = 97;
    this.numericUpDown1.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.TotalPowerLabel.AutoSize = true;
    this.TotalPowerLabel.Location = new Point(16 /*0x10*/, 370);
    this.TotalPowerLabel.Name = "TotalPowerLabel";
    this.TotalPowerLabel.Size = new Size(67, 13);
    this.TotalPowerLabel.TabIndex = 99;
    this.TotalPowerLabel.Text = "Total Power:";
    this.InitialDMGLabel.AutoSize = true;
    this.InitialDMGLabel.Location = new Point(6, 391);
    this.InitialDMGLabel.Name = "InitialDMGLabel";
    this.InitialDMGLabel.Size = new Size(77, 13);
    this.InitialDMGLabel.TabIndex = 100;
    this.InitialDMGLabel.Text = "Initial Damage:";
    this.FinalDMGLabel.AutoSize = true;
    this.FinalDMGLabel.Location = new Point(6, 414);
    this.FinalDMGLabel.Name = "FinalDMGLabel";
    this.FinalDMGLabel.Size = new Size(75, 13);
    this.FinalDMGLabel.TabIndex = 101;
    this.FinalDMGLabel.Text = "Final Damage:";
    this.TrueDMGLabel.AutoSize = true;
    this.TrueDMGLabel.Location = new Point(6, 438);
    this.TrueDMGLabel.Name = "TrueDMGLabel";
    this.TrueDMGLabel.Size = new Size(75, 13);
    this.TrueDMGLabel.TabIndex = 102;
    this.TrueDMGLabel.Text = "True Damage:";
    this.label35.AutoSize = true;
    this.label35.Location = new Point(6, 466);
    this.label35.Name = "label35";
    this.label35.Size = new Size(75, 13);
    this.label35.TabIndex = 104;
    this.label35.Text = "In Game DMG";
    this.numericUpDown2.Location = new Point(87, 464);
    this.numericUpDown2.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.numericUpDown2.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown2.Name = "numericUpDown2";
    this.numericUpDown2.Size = new Size(67, 20);
    this.numericUpDown2.TabIndex = 103;
    this.button1.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.button1.Location = new Point(160 /*0xA0*/, 464);
    this.button1.Name = "button1";
    this.button1.Size = new Size(87, 20);
    this.button1.TabIndex = 105;
    this.button1.Text = "Calc Enemy DR";
    this.button1.UseVisualStyleBackColor = true;
    this.label36.AutoSize = true;
    this.label36.Location = new Point(20, 487);
    this.label36.Name = "label36";
    this.label36.Size = new Size(61, 13);
    this.label36.TabIndex = 106;
    this.label36.Text = "Enemy DR:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(659, 509);
    this.Controls.Add((Control) this.label36);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.label35);
    this.Controls.Add((Control) this.numericUpDown2);
    this.Controls.Add((Control) this.TrueDMGLabel);
    this.Controls.Add((Control) this.FinalDMGLabel);
    this.Controls.Add((Control) this.InitialDMGLabel);
    this.Controls.Add((Control) this.TotalPowerLabel);
    this.Controls.Add((Control) this.label34);
    this.Controls.Add((Control) this.numericUpDown1);
    this.Controls.Add((Control) this.label33);
    this.Controls.Add((Control) this.MarkedTarget);
    this.Controls.Add((Control) this.label32);
    this.Controls.Add((Control) this.EliteEngine);
    this.Controls.Add((Control) this.label31);
    this.Controls.Add((Control) this.ChargedWeapon);
    this.Controls.Add((Control) this.label30);
    this.Controls.Add((Control) this.Isenshi);
    this.Controls.Add((Control) this.label29);
    this.Controls.Add((Control) this.numericUpDown7);
    this.Controls.Add((Control) this.label28);
    this.Controls.Add((Control) this.Hit);
    this.Controls.Add((Control) this.label27);
    this.Controls.Add((Control) this.numericUpDown5);
    this.Controls.Add((Control) this.label26);
    this.Controls.Add((Control) this.numericUpDown4);
    this.Controls.Add((Control) this.label25);
    this.Controls.Add((Control) this.TomePower);
    this.Controls.Add((Control) this.label23);
    this.Controls.Add((Control) this.EleAtkMod);
    this.Controls.Add((Control) this.label24);
    this.Controls.Add((Control) this.EleAtk1);
    this.Controls.Add((Control) this.label22);
    this.Controls.Add((Control) this.SWAPercent);
    this.Controls.Add((Control) this.MonHun);
    this.Controls.Add((Control) this.label21);
    this.Controls.Add((Control) this.RuledByAnger);
    this.Controls.Add((Control) this.label20);
    this.Controls.Add((Control) this.BattleRush);
    this.Controls.Add((Control) this.label19);
    this.Controls.Add((Control) this.BearStanceCrit);
    this.Controls.Add((Control) this.label18);
    this.Controls.Add((Control) this.BearStance);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.ChargingStrike);
    this.Controls.Add((Control) this.label16);
    this.Controls.Add((Control) this.EmptyPalm);
    this.Controls.Add((Control) this.label15);
    this.Controls.Add((Control) this.HeavyBow);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.Katana);
    this.Controls.Add((Control) this.OneOnOne);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.Hunted);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.Claret);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.Backstab);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.Flank);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.Elangrave);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.CritMod);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.FlatTotalPower);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.SWABox);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.DamageAmp1);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.FlatDamage);
    this.Controls.Add((Control) this.Flat3);
    this.Controls.Add((Control) this.DamageAmp2);
    this.Name = nameof (DamageWindow);
    this.Text = "Damage Calculation";
    this.FormClosed += new FormClosedEventHandler(this.DamageWindow_FormClosed);
    this.CritMod.EndInit();
    this.FlatTotalPower.EndInit();
    this.SWABox.EndInit();
    this.DamageAmp1.EndInit();
    this.FlatDamage.EndInit();
    this.Flat3.EndInit();
    this.DamageAmp2.EndInit();
    this.Elangrave.EndInit();
    this.Flank.EndInit();
    this.Backstab.EndInit();
    this.Claret.EndInit();
    this.Hunted.EndInit();
    this.Katana.EndInit();
    this.HeavyBow.EndInit();
    this.EmptyPalm.EndInit();
    this.ChargingStrike.EndInit();
    this.BearStance.EndInit();
    this.BearStanceCrit.EndInit();
    this.BattleRush.EndInit();
    this.RuledByAnger.EndInit();
    this.SWAPercent.EndInit();
    this.EleAtkMod.EndInit();
    this.EleAtk1.EndInit();
    this.TomePower.EndInit();
    this.numericUpDown4.EndInit();
    this.numericUpDown5.EndInit();
    this.Hit.EndInit();
    this.numericUpDown7.EndInit();
    this.Isenshi.EndInit();
    this.ChargedWeapon.EndInit();
    this.EliteEngine.EndInit();
    this.MarkedTarget.EndInit();
    this.numericUpDown1.EndInit();
    this.numericUpDown2.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
