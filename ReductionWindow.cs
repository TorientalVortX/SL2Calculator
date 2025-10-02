// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.ReductionWindow
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class ReductionWindow : Form
{
  private MainWindow MainForm;
  private double SWA = 100.0;
  private double FanPower;
  private double SWAScale = 100.0;
  private double EleScaling = 100.0;
  private double EleATK;
  private double TotalPower;
  private double TotalPower2;
  private double TotalPower3;
  private double FlatBonus;
  private double CriticalMod;
  private double FlatCritMod;
  private double NumberofHits = 1.0;
  private double DamageMulti;
  private double DR1v;
  private double DR2v;
  private double DR3v;
  private double DR4v;
  private double DR5v;
  private double DR6v;
  private double DR7v;
  private double DR8v;
  private double DR9v;
  private double EleResV;
  private double Shield1v;
  private double Shield2v;
  private double Shield3v;
  private double Armor;
  private double DEF;
  private double RES;
  private double GUI;
  private double Barrier = 1.0;
  private double Evasion = 1.0;
  private double TotalPowerF = 1.0;
  private double BaseDamage = 1.0;
  private double FinalDamage = 1.0;
  private double MultiHitDamage = 1.0;
  private IContainer components;
  private CheckBox MagicBox;
  private NumericUpDown DamageAmp;
  private NumericUpDown DR1;
  private NumericUpDown ArmorNum;
  private Label label2;
  private Label label3;
  private Label label4;
  private NumericUpDown DR3;
  private Label label6;
  private NumericUpDown BaseDamageNum;
  private NumericUpDown DR4;
  private NumericUpDown DR2;
  private Label DR;
  private CheckBox checkBox1;
  private Label Test;
  private Label label1;
  private ComboBox comboBox1;
  private CheckBox checkBox2;
  private Label label9;
  private Label label5;
  private NumericUpDown Shield1;
  private Label label7;
  private Label label8;
  private Label label10;
  private NumericUpDown Shield2;
  private NumericUpDown Shield3;
  private NumericUpDown DR5;
  private Label label11;
  private Label label12;
  private NumericUpDown DR6;
  private NumericUpDown DR7;
  private NumericUpDown DR8;
  private NumericUpDown DR9;
  private Label label13;
  private NumericUpDown FanPwr;
  private Label label14;
  private NumericUpDown EleScale;
  private Label label15;
  private NumericUpDown EleAtkNum;
  private Label label16;
  private NumericUpDown TotalPowerNum;
  private Label label17;
  private NumericUpDown FlatBonusNum;
  private Label label18;
  private NumericUpDown CritMod;
  private Label label19;
  private NumericUpDown CritFlatNum;
  private Label label20;
  private NumericUpDown NumOfHits;
  private Label label21;
  private NumericUpDown SWAPercent;
  private Label label22;
  private Label label23;
  private Label label24;
  private Label label26;
  private Label label27;
  private Label label28;
  private Label label29;
  private Label label30;
  private NumericUpDown EleRes;
  private Label TotalPowerLBL;
  private Label BaseDamageLBL;
  private NumericUpDown TotalPowerNum2;
  private NumericUpDown TotalPowerNum3;
  private Button button1;
  private NumericUpDown numericUpDown1;
  private Label label31;
  private ComboBox comboBox2;
  private Label label32;
  private Panel panel1;
  private Label CritDmgLbl;
  private CheckBox EliteCheck;
  private Label label25;
  private NumericUpDown ExcelNum;
  private CheckBox HolyCheck;
  private Panel panel2;
  private Label RESLBL;
  private Label DEFLBL;
  private Label GUILBL;
  private Label label33;

  public ReductionWindow(MainWindow that)
  {
    this.InitializeComponent();
    this.MainForm = that;
    if (this.MainForm.dark)
    {
      this.ForeColor = Color.White;
      this.BackColor = Color.FromArgb(55, 55, 55);
    }
    this.UpdateStats("All");
    this.UpdateDamage("All");
  }

  private void ReductionWindow_FormClosing_1(object sender, FormClosingEventArgs e)
  {
    this.MainForm.ClosedReductionCalculator();
  }

  private void TotalPowerNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("TotalPower");
    this.UpdateDamage("Total Power");
  }

  private void FlatBonusNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("FlatBonus");
    this.UpdateDamage("Base Damage");
  }

  private void CritMod_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("CritMod");
    this.UpdateDamage("Base Damage");
  }

  private void CritFlatNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("FlatCrit");
    this.UpdateDamage("Base Damage");
  }

  private void EleScale_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("EleScaling");
    this.UpdateDamage("Total Power");
  }

  private void EleRes_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("EleRes");
    this.UpdateDamage("Final Damage");
  }

  private void SWAPercent_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("SwaScaling");
    this.UpdateDamage("Total Power");
  }

  private void EleAtkNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("EleAtk");
    this.UpdateDamage("Total Power");
  }

  private void FanPwr_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("FanPwr");
    this.UpdateDamage("Total Power");
  }

  private void NumOfHits_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Hits");
    this.UpdateDamage("Base Damage");
  }

  private void ExcelNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Excel");
    this.UpdateDamage("Base Damage");
  }

  private void EliteCheck_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Excel");
    this.UpdateDamage("Base Damage");
  }

  private void HolyCheck_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Holy");
    this.UpdateDamage("Base Damage");
  }

  private void label33_Click(object sender, EventArgs e)
  {
  }

  private void TotalPowerNum2_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("TotalPower2");
    this.UpdateDamage("Total Power");
  }

  private void TotalPowerNum3_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("TotalPower3");
    this.UpdateDamage("Total Power");
  }

  private void DR5_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR5");
    this.UpdateDamage("Final Damage");
  }

  private void DR6_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR6");
    this.UpdateDamage("Final Damage");
  }

  private void DR7_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR7");
    this.UpdateDamage("Final Damage");
  }

  private void DR8_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR8");
    this.UpdateDamage("Final Damage");
  }

  private void DR9_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR9");
    this.UpdateDamage("Final Damage");
  }

  private void Shield3_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Shield3");
    this.UpdateDamage("Final Damage");
  }

  private void Shield2_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Shield2");
    this.UpdateDamage("Final Damage");
  }

  private void Shield1_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Shield1");
    this.UpdateDamage("Final Damage");
  }

  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.UpdateDamage("Total Power");
  }

  private void ReductionWindow_Load(object sender, EventArgs e) => this.UpdateDamage("Total Power");

  private void CheckBox1_CheckedChanged(object sender, EventArgs e)
  {
    this.Barrier = !this.checkBox1.Checked ? 1.0 : 0.5;
    this.UpdateDamage("Final Damage");
  }

  private void BaseDamageNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateDamage("Total Power");
  }

  private void checkBox2_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateDamage("Final Damage");
  }

  private void label7_Click(object sender, EventArgs e)
  {
  }

  private void BaseDamageNum_ValueChanged_1(object sender, EventArgs e)
  {
    this.UpdateStats("SWA");
    this.UpdateDamage("Total Power");
  }

  private void EleResBox_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR4");
    this.UpdateDamage("Final Damage");
  }

  private void ClassNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR2");
    this.UpdateDamage("Final Damage");
  }

  private void BaseBox_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateDamage("Total Power");
  }

  private void StatusNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR3");
    this.UpdateDamage("Final Damage");
  }

  private void ArmorNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("Armor");
    this.UpdateDamage("Multihit Damage");
  }

  private void EquipmentNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DR1");
    this.UpdateDamage("Final Damage");
  }

  private void DamageAmpNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStats("DamageAmp");
    this.UpdateDamage("Base Damage");
  }

  private void MagicBox_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateDamage("Final Damage");
  }

  private double EvasionCheck()
  {
    this.Evasion = !this.checkBox2.Checked ? 1.0 : 0.4;
    return this.Evasion;
  }

  public void UpdateStats(string Stat)
  {
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(Stat))
    {
      case 688663774:
        if (!(Stat == "TotalPower"))
          break;
        this.TotalPower = (double) (int) this.TotalPowerNum.Value * 0.01 + 1.0;
        break;
      case 870741424:
        int num = Stat == "NA" ? 1 : 0;
        break;
      case 897266739:
        if (!(Stat == "Shield1"))
          break;
        this.Shield1v = 1.0 - (double) (int) this.Shield1.Value * 0.01;
        break;
      case 914044358:
        if (!(Stat == "Shield2"))
          break;
        this.Shield2v = 1.0 - (double) (int) this.Shield2.Value * 0.01;
        break;
      case 930821977:
        if (!(Stat == "Shield3"))
          break;
        this.Shield3v = 1.0 - (double) (int) this.Shield3.Value * 0.01;
        break;
      case 1242496940:
        if (!(Stat == "DEF"))
          break;
        this.DEF = this.MainForm.GetDefense() * 0.9;
        this.DEFLBL.Text = "DEF: " + this.DEF.ToString();
        this.DEF = 1.0 - this.DEF * 0.01;
        break;
      case 1344544810:
        if (!(Stat == "SWA"))
          break;
        this.SWA = (double) (int) this.BaseDamageNum.Value;
        break;
      case 1373653293:
        if (!(Stat == "FlatBonus"))
          break;
        this.FlatBonus = (double) (int) this.FlatBonusNum.Value;
        break;
      case 1926135097:
        if (!(Stat == "RES"))
          break;
        this.RES = this.MainForm.GetResistance() * 0.9;
        this.RESLBL.Text = "RES: " + this.RES.ToString();
        this.RES = 1.0 - this.RES * 0.01;
        break;
      case 1974461284:
        if (!(Stat == "All"))
          break;
        this.DEF = this.MainForm.GetDefense() * 0.9;
        this.DEFLBL.Text = "DEF: " + this.DEF.ToString();
        this.DEF = 1.0 - this.DEF * 0.01;
        this.RES = this.MainForm.GetResistance() * 0.9;
        this.RESLBL.Text = "RES: " + this.RES.ToString();
        this.RES = 1.0 - this.RES * 0.01;
        this.GUI = this.MainForm.GetGuile();
        this.GUILBL.Text = "GUI: " + this.GUI.ToString();
        this.CriticalMod = ((double) (int) this.CritMod.Value + this.GUI) * 0.01;
        this.SWA = (double) (int) this.BaseDamageNum.Value;
        this.EleATK = (double) (int) this.EleAtkNum.Value;
        this.EleScaling = (double) (int) this.EleScale.Value * 0.01;
        this.SWAScale = (double) (int) this.SWAPercent.Value * 0.01;
        this.TotalPower = 1.0 + (double) (int) this.TotalPowerNum.Value * 0.01;
        this.TotalPower2 = 1.0 + (double) (int) this.TotalPowerNum2.Value * 0.01;
        this.TotalPower3 = 1.0 + (double) (int) this.TotalPowerNum3.Value * 0.01;
        this.FanPower = (double) (int) this.FanPwr.Value * 0.01 + 1.0;
        this.FlatBonus = (double) (int) this.FlatBonusNum.Value;
        this.CriticalMod = (double) (int) this.CritMod.Value * 0.01;
        this.NumberofHits = (double) (int) this.NumOfHits.Value;
        this.FlatCritMod = (double) (int) this.CritFlatNum.Value;
        this.Armor = (double) (int) this.ArmorNum.Value;
        this.DamageMulti = 1.0 + (double) (int) this.DamageAmp.Value * 0.01;
        this.DR1v = 1.0 - (double) (int) this.DR1.Value * 0.01;
        this.DR2v = 1.0 - (double) (int) this.DR2.Value * 0.01;
        this.DR3v = 1.0 - (double) (int) this.DR3.Value * 0.01;
        this.DR4v = 1.0 - (double) (int) this.DR4.Value * 0.01;
        this.DR5v = 1.0 - (double) (int) this.DR5.Value * 0.01;
        this.DR6v = 1.0 - (double) (int) this.DR6.Value * 0.01;
        this.DR7v = 1.0 - (double) (int) this.DR7.Value * 0.01;
        this.DR8v = 1.0 - (double) (int) this.DR8.Value * 0.01;
        this.DR9v = 1.0 - (double) (int) this.DR9.Value * 0.01;
        this.EleResV = 1.0 - (double) (int) this.EleRes.Value * 0.01;
        this.Shield1v = 1.0 - (double) (int) this.Shield1.Value * 0.01;
        this.Shield2v = 1.0 - (double) (int) this.Shield2.Value * 0.01;
        this.Shield3v = 1.0 - (double) (int) this.Shield3.Value * 0.01;
        break;
      case 1994091296:
        if (!(Stat == "DR3"))
          break;
        this.DR3v = 1.0 - (double) (int) this.DR3.Value * 0.01;
        break;
      case 2010868915:
        if (!(Stat == "DR2"))
          break;
        this.DR2v = 1.0 - (double) (int) this.DR2.Value * 0.01;
        break;
      case 2027646534:
        if (!(Stat == "DR1"))
          break;
        this.DR1v = 1.0 - (double) (int) this.DR1.Value * 0.01;
        break;
      case 2047816512:
        if (!(Stat == "GUI"))
          break;
        this.GUI = this.MainForm.GetGuile();
        this.GUILBL.Text = "GUI: " + this.GUI.ToString();
        this.CriticalMod = ((double) (int) this.CritMod.Value + this.GUI) * 0.01;
        break;
      case 2061201772:
        if (!(Stat == "DR7"))
          break;
        this.DR7v = 1.0 - (double) (int) this.DR7.Value * 0.01;
        break;
      case 2077979391:
        if (!(Stat == "DR6"))
          break;
        this.DR6v = 1.0 - (double) (int) this.DR6.Value * 0.01;
        break;
      case 2094757010:
        if (!(Stat == "DR5"))
          break;
        this.DR5v = 1.0 - (double) (int) this.DR5.Value * 0.01;
        break;
      case 2111534629:
        if (!(Stat == "DR4"))
          break;
        this.DR4v = 1.0 - (double) (int) this.DR4.Value * 0.01;
        break;
      case 2161867486:
        if (!(Stat == "DR9"))
          break;
        this.DR9v = 1.0 - (double) (int) this.DR9.Value * 0.01;
        break;
      case 2178645105:
        if (!(Stat == "DR8"))
          break;
        this.DR8v = 1.0 - (double) (int) this.DR8.Value * 0.01;
        break;
      case 2226667892:
        if (!(Stat == "Armor"))
          break;
        this.Armor = (double) (int) this.ArmorNum.Value;
        break;
      case 2278375579:
        if (!(Stat == "SwaScaling"))
          break;
        this.SWAScale = (double) (int) this.SWAPercent.Value * 0.01;
        break;
      case 2318055300:
        if (!(Stat == "TotalPower2"))
          break;
        this.TotalPower2 = (double) (int) this.TotalPowerNum2.Value * 0.01 + 1.0;
        break;
      case 2319273763:
        if (!(Stat == "FanPwr"))
          break;
        this.FanPower = (double) (int) this.FanPwr.Value * 0.01 + 1.0;
        break;
      case 2334832919:
        if (!(Stat == "TotalPower3"))
          break;
        this.TotalPower3 = (double) (int) this.TotalPowerNum3.Value * 0.01 + 1.0;
        break;
      case 2411657814:
        if (!(Stat == "FlatCrit"))
          break;
        this.FlatCritMod = (double) (int) this.CritFlatNum.Value;
        break;
      case 2579191107:
        if (!(Stat == "EleRes"))
          break;
        this.EleResV = 1.0 - (double) (int) this.EleRes.Value * 0.01;
        break;
      case 2647892027:
        if (!(Stat == "CritMod"))
          break;
        this.CriticalMod = ((double) (int) this.CritMod.Value + this.GUI) * 0.01;
        break;
      case 3317804286:
        if (!(Stat == "DamageAmp"))
          break;
        this.DamageMulti = 1.0 + (double) (int) this.DamageAmp.Value * 0.01;
        break;
      case 3404024251:
        if (!(Stat == "Hits"))
          break;
        this.NumberofHits = (double) (int) this.NumOfHits.Value;
        break;
      case 3549939255:
        if (!(Stat == "EleAtk"))
          break;
        this.EleATK = (double) (int) this.EleAtkNum.Value;
        break;
      case 4097806668:
        if (!(Stat == "EleScaling"))
          break;
        this.EleScaling = (double) (int) this.EleScale.Value * 0.01;
        break;
    }
  }

  public double CalculateTotalPower(double SWATP)
  {
    SWATP = (SWATP * this.SWAScale * this.FanPower + this.EleATK * this.EleScaling) * this.TotalPower * this.TotalPower2 * this.TotalPower3;
    return SWATP;
  }

  public double CalculateBaseDamage(double Damage)
  {
    Damage = ((Damage + this.FlatBonus) * this.CriticalMod / this.NumberofHits + this.FlatCritMod) * this.DamageMulti;
    return Damage;
  }

  public double CalculateFinalDamage(double Damage)
  {
    Damage = this.DamageReductionCalc(Damage);
    return Damage;
  }

  public double DamageReductionCalc(double Damage)
  {
    double num = this.SetDefenses(this.MagicBox.Checked);
    Damage = Damage * num * this.DR1v * this.DR2v * this.DR3v * this.DR4v * this.DR5v * this.DR6v * this.DR7v * this.DR8v * this.DR9v * this.Barrier * this.EvasionCheck() * this.EleResV;
    return Damage;
  }

  public double DamageShieldCalc(double Damage)
  {
    Damage = Damage * this.Shield1v * this.Shield2v * this.Shield3v;
    return Damage;
  }

  public double CheckForMultihitDamage(double Damage)
  {
    if (this.NumberofHits == 1.0)
    {
      Damage -= this.Armor;
      Damage = this.DamageShieldCalc(Damage);
    }
    else
      Damage = this.DamageShieldCalc(Damage);
    return Damage;
  }

  public double CalculateDamageReduction()
  {
    this.SetDefenses(this.MagicBox.Checked);
    return (this.DamageReductionCalc(100.0) - 100.0) * -1.0;
  }

  public double SetDefenses(bool Magic) => !Magic ? this.DEF : this.RES;

  public void UpdateDamage(string step)
  {
    switch (step)
    {
      case "All":
        this.TotalPowerF = this.CalculateTotalPower(this.SWA);
        this.BaseDamage = this.CalculateBaseDamage(this.TotalPowerF);
        this.FinalDamage = this.CalculateFinalDamage(this.BaseDamage);
        this.MultiHitDamage = this.CheckForMultihitDamage(this.FinalDamage);
        break;
      case "Total Power":
        this.TotalPowerF = this.CalculateTotalPower(this.SWA);
        this.BaseDamage = this.CalculateBaseDamage(this.TotalPowerF);
        this.FinalDamage = this.CalculateFinalDamage(this.BaseDamage);
        this.MultiHitDamage = this.CheckForMultihitDamage(this.FinalDamage);
        break;
      case "Base Damage":
        this.BaseDamage = this.CalculateBaseDamage(this.TotalPowerF);
        this.FinalDamage = this.CalculateFinalDamage(this.BaseDamage);
        this.MultiHitDamage = this.CheckForMultihitDamage(this.FinalDamage);
        break;
      case "Final Damage":
        this.FinalDamage = this.CalculateFinalDamage(this.BaseDamage);
        this.MultiHitDamage = this.CheckForMultihitDamage(this.FinalDamage);
        break;
      case "Multihit Damage":
        this.MultiHitDamage = this.CheckForMultihitDamage(this.FinalDamage);
        break;
    }
    double num;
    if (this.NumberofHits == 1.0)
    {
      Label test = this.Test;
      num = Math.Floor(this.MultiHitDamage);
      string str = "Final Damage: " + num.ToString();
      test.Text = str;
    }
    else
      this.Test.Text = $"Final Damage: {Math.Floor(this.MultiHitDamage).ToString()} ({Math.Floor(this.MultiHitDamage * this.NumberofHits - this.DamageShieldCalc(this.Armor)).ToString()})";
    Label dr = this.DR;
    num = Math.Floor(this.CalculateDamageReduction());
    string str1 = "DR%: " + num.ToString();
    dr.Text = str1;
    Label totalPowerLbl = this.TotalPowerLBL;
    num = Math.Floor(this.TotalPowerF);
    string str2 = "Total Power: " + num.ToString();
    totalPowerLbl.Text = str2;
    Label baseDamageLbl = this.BaseDamageLBL;
    num = Math.Floor(this.BaseDamage);
    string str3 = "Base Damage: " + num.ToString();
    baseDamageLbl.Text = str3;
    Label critDmgLbl = this.CritDmgLbl;
    num = Math.Floor(this.CriticalMod * 100.0);
    string str4 = "Crit Dmg %: " + num.ToString();
    critDmgLbl.Text = str4;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.MagicBox = new CheckBox();
    this.DamageAmp = new NumericUpDown();
    this.DR1 = new NumericUpDown();
    this.ArmorNum = new NumericUpDown();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.DR3 = new NumericUpDown();
    this.label6 = new Label();
    this.BaseDamageNum = new NumericUpDown();
    this.DR4 = new NumericUpDown();
    this.DR2 = new NumericUpDown();
    this.DR = new Label();
    this.checkBox1 = new CheckBox();
    this.Test = new Label();
    this.label1 = new Label();
    this.comboBox1 = new ComboBox();
    this.checkBox2 = new CheckBox();
    this.label9 = new Label();
    this.label5 = new Label();
    this.Shield1 = new NumericUpDown();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label10 = new Label();
    this.Shield2 = new NumericUpDown();
    this.Shield3 = new NumericUpDown();
    this.DR5 = new NumericUpDown();
    this.label11 = new Label();
    this.label12 = new Label();
    this.DR6 = new NumericUpDown();
    this.DR7 = new NumericUpDown();
    this.DR8 = new NumericUpDown();
    this.DR9 = new NumericUpDown();
    this.label13 = new Label();
    this.FanPwr = new NumericUpDown();
    this.label14 = new Label();
    this.EleScale = new NumericUpDown();
    this.label15 = new Label();
    this.EleAtkNum = new NumericUpDown();
    this.label16 = new Label();
    this.TotalPowerNum = new NumericUpDown();
    this.label17 = new Label();
    this.FlatBonusNum = new NumericUpDown();
    this.label18 = new Label();
    this.CritMod = new NumericUpDown();
    this.label19 = new Label();
    this.CritFlatNum = new NumericUpDown();
    this.label20 = new Label();
    this.NumOfHits = new NumericUpDown();
    this.label21 = new Label();
    this.SWAPercent = new NumericUpDown();
    this.label22 = new Label();
    this.label23 = new Label();
    this.label24 = new Label();
    this.label26 = new Label();
    this.label27 = new Label();
    this.label28 = new Label();
    this.label29 = new Label();
    this.label30 = new Label();
    this.EleRes = new NumericUpDown();
    this.TotalPowerLBL = new Label();
    this.BaseDamageLBL = new Label();
    this.TotalPowerNum2 = new NumericUpDown();
    this.TotalPowerNum3 = new NumericUpDown();
    this.button1 = new Button();
    this.numericUpDown1 = new NumericUpDown();
    this.label31 = new Label();
    this.comboBox2 = new ComboBox();
    this.label32 = new Label();
    this.panel1 = new Panel();
    this.CritDmgLbl = new Label();
    this.EliteCheck = new CheckBox();
    this.label25 = new Label();
    this.ExcelNum = new NumericUpDown();
    this.HolyCheck = new CheckBox();
    this.panel2 = new Panel();
    this.GUILBL = new Label();
    this.DEFLBL = new Label();
    this.RESLBL = new Label();
    this.label33 = new Label();
    this.DamageAmp.BeginInit();
    this.DR1.BeginInit();
    this.ArmorNum.BeginInit();
    this.DR3.BeginInit();
    this.BaseDamageNum.BeginInit();
    this.DR4.BeginInit();
    this.DR2.BeginInit();
    this.Shield1.BeginInit();
    this.Shield2.BeginInit();
    this.Shield3.BeginInit();
    this.DR5.BeginInit();
    this.DR6.BeginInit();
    this.DR7.BeginInit();
    this.DR8.BeginInit();
    this.DR9.BeginInit();
    this.FanPwr.BeginInit();
    this.EleScale.BeginInit();
    this.EleAtkNum.BeginInit();
    this.TotalPowerNum.BeginInit();
    this.FlatBonusNum.BeginInit();
    this.CritMod.BeginInit();
    this.CritFlatNum.BeginInit();
    this.NumOfHits.BeginInit();
    this.SWAPercent.BeginInit();
    this.EleRes.BeginInit();
    this.TotalPowerNum2.BeginInit();
    this.TotalPowerNum3.BeginInit();
    this.numericUpDown1.BeginInit();
    this.panel1.SuspendLayout();
    this.ExcelNum.BeginInit();
    this.panel2.SuspendLayout();
    this.SuspendLayout();
    this.MagicBox.AutoSize = true;
    this.MagicBox.Location = new Point(154, 347);
    this.MagicBox.Name = "MagicBox";
    this.MagicBox.Size = new Size(55, 17);
    this.MagicBox.TabIndex = 1;
    this.MagicBox.Text = "Magic";
    this.MagicBox.UseVisualStyleBackColor = true;
    this.MagicBox.CheckedChanged += new EventHandler(this.MagicBox_CheckedChanged);
    this.DamageAmp.Location = new Point(116, 266);
    this.DamageAmp.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.DamageAmp.Name = "DamageAmp";
    this.DamageAmp.Size = new Size(67, 20);
    this.DamageAmp.TabIndex = 2;
    this.DamageAmp.ValueChanged += new EventHandler(this.DamageAmpNum_ValueChanged);
    this.DR1.Location = new Point(33, 214);
    this.DR1.Name = "DR1";
    this.DR1.Size = new Size(44, 20);
    this.DR1.TabIndex = 3;
    this.DR1.ValueChanged += new EventHandler(this.EquipmentNum_ValueChanged);
    this.ArmorNum.Location = new Point(116, 292);
    this.ArmorNum.Name = "ArmorNum";
    this.ArmorNum.Size = new Size(67, 20);
    this.ArmorNum.TabIndex = 4;
    this.ArmorNum.ValueChanged += new EventHandler(this.ArmorNum_ValueChanged);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(15, 294);
    this.label2.Name = "label2";
    this.label2.Size = new Size(98, 13);
    this.label2.TabIndex = 7;
    this.label2.Text = "Armor/Magic Armor";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(4, 216);
    this.label3.Name = "label3";
    this.label3.Size = new Size(23, 13);
    this.label3.TabIndex = 8;
    this.label3.Text = "DR";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(4, 268);
    this.label4.Name = "label4";
    this.label4.Size = new Size(109, 13);
    this.label4.TabIndex = 9;
    this.label4.Text = "Damage Amplification";
    this.DR3.Location = new Point(128 /*0x80*/, 214);
    this.DR3.Name = "DR3";
    this.DR3.Size = new Size(39, 20);
    this.DR3.TabIndex = 10;
    this.DR3.ValueChanged += new EventHandler(this.StatusNum_ValueChanged);
    this.label6.AutoSize = true;
    this.label6.Location = new Point(30, 9);
    this.label6.Name = "label6";
    this.label6.Size = new Size(32 /*0x20*/, 13);
    this.label6.TabIndex = 15;
    this.label6.Text = "SWA";
    this.BaseDamageNum.Location = new Point(75, 7);
    this.BaseDamageNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.BaseDamageNum.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.BaseDamageNum.Name = "BaseDamageNum";
    this.BaseDamageNum.Size = new Size(48 /*0x30*/, 20);
    this.BaseDamageNum.TabIndex = 14;
    this.BaseDamageNum.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.BaseDamageNum.ValueChanged += new EventHandler(this.BaseDamageNum_ValueChanged_1);
    this.DR4.Location = new Point(173, 214);
    this.DR4.Name = "DR4";
    this.DR4.Size = new Size(46, 20);
    this.DR4.TabIndex = 16 /*0x10*/;
    this.DR4.ValueChanged += new EventHandler(this.EleResBox_ValueChanged);
    this.DR2.Location = new Point(80 /*0x50*/, 214);
    this.DR2.Name = "DR2";
    this.DR2.Size = new Size(42, 20);
    this.DR2.TabIndex = 18;
    this.DR2.ValueChanged += new EventHandler(this.ClassNum_ValueChanged);
    this.DR.AutoSize = true;
    this.DR.Location = new Point(45, 2);
    this.DR.Name = "DR";
    this.DR.RightToLeft = RightToLeft.No;
    this.DR.Size = new Size(34, 13);
    this.DR.TabIndex = 20;
    this.DR.Text = "DR%:";
    this.checkBox1.AutoSize = true;
    this.checkBox1.Location = new Point(18, 347);
    this.checkBox1.Name = "checkBox1";
    this.checkBox1.Size = new Size(56, 17);
    this.checkBox1.TabIndex = 21;
    this.checkBox1.Text = "Barrier";
    this.checkBox1.UseVisualStyleBackColor = true;
    this.checkBox1.CheckedChanged += new EventHandler(this.CheckBox1_CheckedChanged);
    this.Test.AutoSize = true;
    this.Test.Location = new Point(4, 15);
    this.Test.Name = "Test";
    this.Test.RightToLeft = RightToLeft.No;
    this.Test.Size = new Size(75, 13);
    this.Test.TabIndex = 0;
    this.Test.Text = "Final Damage:";
    this.Test.TextAlign = ContentAlignment.MiddleRight;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(655, 7);
    this.label1.Name = "label1";
    this.label1.Size = new Size(34, 13);
    this.label1.TabIndex = 22;
    this.label1.Text = "(WIP)";
    this.comboBox1.FormattingEnabled = true;
    this.comboBox1.Items.AddRange(new object[3]
    {
      (object) "Unarmored",
      (object) "Light",
      (object) "Heavy"
    });
    this.comboBox1.Location = new Point(7, 551);
    this.comboBox1.Name = "comboBox1";
    this.comboBox1.Size = new Size(121, 21);
    this.comboBox1.TabIndex = 23;
    this.comboBox1.Visible = false;
    this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
    this.checkBox2.AutoSize = true;
    this.checkBox2.Location = new Point(80 /*0x50*/, 347);
    this.checkBox2.Name = "checkBox2";
    this.checkBox2.Size = new Size(68, 17);
    this.checkBox2.TabIndex = 24;
    this.checkBox2.Text = "Glancing";
    this.checkBox2.UseVisualStyleBackColor = true;
    this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(8, 535);
    this.label9.Name = "label9";
    this.label9.RightToLeft = RightToLeft.Yes;
    this.label9.Size = new Size(61, 13);
    this.label9.TabIndex = 25;
    this.label9.Text = "Armor Type";
    this.label9.Visible = false;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(15, 320);
    this.label5.Name = "label5";
    this.label5.Size = new Size(84, 13);
    this.label5.TabIndex = 27;
    this.label5.Text = "Damage Shields";
    this.Shield1.Location = new Point(116, 318);
    this.Shield1.Name = "Shield1";
    this.Shield1.Size = new Size(67, 20);
    this.Shield1.TabIndex = 26;
    this.Shield1.ValueChanged += new EventHandler(this.Shield1_ValueChanged);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(4, 367);
    this.label7.Name = "label7";
    this.label7.Size = new Size(179, 13);
    this.label7.TabIndex = 28;
    this.label7.Text = "Base Damage Calculation is roughly:";
    this.label7.Click += new EventHandler(this.label7_Click);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 380);
    this.label8.Name = "label8";
    this.label8.Size = new Size(654, 13);
    this.label8.TabIndex = 29;
    this.label8.Text = "((((SWA * SWA Mod%) + (Ele ATK * Ele ATK %)) * Total Power % + Flat Bonus) * Crit Mod * Damage Reduction - Armor) * Damage Shields";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(335, 320);
    this.label10.Name = "label10";
    this.label10.Size = new Size(244, 13);
    this.label10.TabIndex = 30;
    this.label10.Text = "- Wraithguard / Shared Pain / Combination Fighter";
    this.Shield2.Location = new Point(189, 318);
    this.Shield2.Name = "Shield2";
    this.Shield2.Size = new Size(67, 20);
    this.Shield2.TabIndex = 31 /*0x1F*/;
    this.Shield2.ValueChanged += new EventHandler(this.Shield2_ValueChanged);
    this.Shield3.Location = new Point(262, 318);
    this.Shield3.Name = "Shield3";
    this.Shield3.Size = new Size(67, 20);
    this.Shield3.TabIndex = 32 /*0x20*/;
    this.Shield3.ValueChanged += new EventHandler(this.Shield3_ValueChanged);
    this.DR5.Location = new Point(225, 214);
    this.DR5.Name = "DR5";
    this.DR5.Size = new Size(46, 20);
    this.DR5.TabIndex = 33;
    this.DR5.ValueChanged += new EventHandler(this.DR5_ValueChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(189, 294);
    this.label11.Name = "label11";
    this.label11.Size = new Size(82, 13);
    this.label11.TabIndex = 34;
    this.label11.Text = "- Flat Reduction";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(189, 268);
    this.label12.Name = "label12";
    this.label12.Size = new Size(193, 13);
    this.label12.TabIndex = 35;
    this.label12.Text = "- Additive with each other. (10+10 = 20)";
    this.DR6.Location = new Point(277, 214);
    this.DR6.Name = "DR6";
    this.DR6.Size = new Size(43, 20);
    this.DR6.TabIndex = 36;
    this.DR6.ValueChanged += new EventHandler(this.DR6_ValueChanged);
    this.DR7.Location = new Point(326, 214);
    this.DR7.Name = "DR7";
    this.DR7.Size = new Size(45, 20);
    this.DR7.TabIndex = 37;
    this.DR7.ValueChanged += new EventHandler(this.DR7_ValueChanged);
    this.DR8.Location = new Point(377, 214);
    this.DR8.Name = "DR8";
    this.DR8.Size = new Size(43, 20);
    this.DR8.TabIndex = 38;
    this.DR8.ValueChanged += new EventHandler(this.DR8_ValueChanged);
    this.DR9.Location = new Point(426, 214);
    this.DR9.Name = "DR9";
    this.DR9.Size = new Size(44, 20);
    this.DR9.TabIndex = 39;
    this.DR9.ValueChanged += new EventHandler(this.DR9_ValueChanged);
    this.label13.AutoSize = true;
    this.label13.Location = new Point(1, 36);
    this.label13.Name = "label13";
    this.label13.Size = new Size(74, 13);
    this.label13.TabIndex = 41;
    this.label13.Text = "Spell Power %";
    this.FanPwr.Location = new Point(75, 34);
    this.FanPwr.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.FanPwr.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.FanPwr.Name = "FanPwr";
    this.FanPwr.Size = new Size(47, 20);
    this.FanPwr.TabIndex = 40;
    this.FanPwr.ValueChanged += new EventHandler(this.FanPwr_ValueChanged);
    this.label14.AutoSize = true;
    this.label14.Location = new Point(123, 63 /*0x3F*/);
    this.label14.Name = "label14";
    this.label14.Size = new Size(60, 13);
    this.label14.TabIndex = 43;
    this.label14.Text = "Ele Scaling";
    this.EleScale.Location = new Point(186, 61);
    this.EleScale.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.EleScale.Name = "EleScale";
    this.EleScale.Size = new Size(46, 20);
    this.EleScale.TabIndex = 42;
    this.EleScale.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.EleScale.ValueChanged += new EventHandler(this.EleScale_ValueChanged);
    this.label15.AutoSize = true;
    this.label15.Location = new Point(24, 63 /*0x3F*/);
    this.label15.Name = "label15";
    this.label15.Size = new Size(46, 13);
    this.label15.TabIndex = 45;
    this.label15.Text = "Ele ATK";
    this.EleAtkNum.Location = new Point(75, 61);
    this.EleAtkNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.EleAtkNum.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.EleAtkNum.Name = "EleAtkNum";
    this.EleAtkNum.Size = new Size(47, 20);
    this.EleAtkNum.TabIndex = 44;
    this.EleAtkNum.ValueChanged += new EventHandler(this.EleAtkNum_ValueChanged);
    this.label16.AutoSize = true;
    this.label16.Location = new Point(10, 89);
    this.label16.Name = "label16";
    this.label16.Size = new Size(63 /*0x3F*/, 13);
    this.label16.TabIndex = 47;
    this.label16.Text = "Total Pwr %";
    this.TotalPowerNum.Location = new Point(75, 87);
    this.TotalPowerNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.TotalPowerNum.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.TotalPowerNum.Name = "TotalPowerNum";
    this.TotalPowerNum.Size = new Size(47, 20);
    this.TotalPowerNum.TabIndex = 46;
    this.TotalPowerNum.ValueChanged += new EventHandler(this.TotalPowerNum_ValueChanged);
    this.label17.AutoSize = true;
    this.label17.Location = new Point(16 /*0x10*/, 115);
    this.label17.Name = "label17";
    this.label17.Size = new Size(57, 13);
    this.label17.TabIndex = 49;
    this.label17.Text = "Flat Bonus";
    this.FlatBonusNum.Location = new Point(75, 113);
    this.FlatBonusNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.FlatBonusNum.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.FlatBonusNum.Name = "FlatBonusNum";
    this.FlatBonusNum.Size = new Size(47, 20);
    this.FlatBonusNum.TabIndex = 48 /*0x30*/;
    this.FlatBonusNum.ValueChanged += new EventHandler(this.FlatBonusNum_ValueChanged);
    this.label18.AutoSize = true;
    this.label18.Location = new Point(8, 166);
    this.label18.Name = "label18";
    this.label18.Size = new Size(62, 13);
    this.label18.TabIndex = 51;
    this.label18.Text = "Critical Mod";
    this.CritMod.Location = new Point(76, 164);
    this.CritMod.Maximum = new Decimal(new int[4]
    {
      100000,
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
    this.CritMod.Size = new Size(46, 20);
    this.CritMod.TabIndex = 50;
    this.CritMod.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.CritMod.ValueChanged += new EventHandler(this.CritMod_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.Location = new Point(12, 190);
    this.label19.Name = "label19";
    this.label19.Size = new Size(58, 13);
    this.label19.TabIndex = 53;
    this.label19.Text = "Critical Flat";
    this.CritFlatNum.Location = new Point(75, 188);
    this.CritFlatNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.CritFlatNum.Name = "CritFlatNum";
    this.CritFlatNum.Size = new Size(47, 20);
    this.CritFlatNum.TabIndex = 52;
    this.CritFlatNum.ValueChanged += new EventHandler(this.CritFlatNum_ValueChanged);
    this.label20.AutoSize = true;
    this.label20.Location = new Point(23, 140);
    this.label20.Name = "label20";
    this.label20.Size = new Size(47, 13);
    this.label20.TabIndex = 55;
    this.label20.Text = "# of Hits";
    this.NumOfHits.Location = new Point(75, 138);
    this.NumOfHits.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.NumOfHits.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.NumOfHits.Name = "NumOfHits";
    this.NumOfHits.Size = new Size(47, 20);
    this.NumOfHits.TabIndex = 54;
    this.NumOfHits.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.NumOfHits.ValueChanged += new EventHandler(this.NumOfHits_ValueChanged);
    this.label21.AutoSize = true;
    this.label21.Location = new Point(137, 9);
    this.label21.Name = "label21";
    this.label21.Size = new Size(43, 13);
    this.label21.TabIndex = 57;
    this.label21.Text = "SWA %";
    this.SWAPercent.Location = new Point(186, 7);
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
    this.SWAPercent.Size = new Size(46, 20);
    this.SWAPercent.TabIndex = 56;
    this.SWAPercent.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.SWAPercent.ValueChanged += new EventHandler(this.SWAPercent_ValueChanged);
    this.label22.AutoSize = true;
    this.label22.Location = new Point(125, 190);
    this.label22.Name = "label22";
    this.label22.Size = new Size(100, 13);
    this.label22.TabIndex = 58;
    this.label22.Text = "- Applies to each hit";
    this.label23.AutoSize = true;
    this.label23.Location = new Point(125, 140);
    this.label23.Name = "label23";
    this.label23.Size = new Size(504, 13);
    this.label23.TabIndex = 59;
    this.label23.Text = "- Armor only applies once and acts as a 'Pool' of Flat Reduction (Two hits of 40 against 60 Armor = 0 + 20)";
    this.label24.AutoSize = true;
    this.label24.Location = new Point(125, 166);
    this.label24.Name = "label24";
    this.label24.Size = new Size(175, 13);
    this.label24.TabIndex = 60;
    this.label24.Text = "- Bonuses are additive (10+10 = 20)";
    this.label26.AutoSize = true;
    this.label26.Location = new Point(238, 89);
    this.label26.Name = "label26";
    this.label26.Size = new Size(404, 13);
    this.label26.TabIndex = 62;
    this.label26.Text = "- Kingslayer / Rogue Dasher / Combination Strike, Separate Modifiers (Multiplicative)";
    this.label27.AutoSize = true;
    this.label27.Location = new Point(128 /*0x80*/, 36);
    this.label27.Name = "label27";
    this.label27.Size = new Size(142, 13);
    this.label27.TabIndex = 63 /*0x3F*/;
    this.label27.Text = "- Fan Tomes (Coastal Squall)";
    this.label28.AutoSize = true;
    this.label28.Location = new Point(476, 216);
    this.label28.Name = "label28";
    this.label28.Size = new Size(74, 13);
    this.label28.TabIndex = 64 /*0x40*/;
    this.label28.Text = "- Multiplicative";
    this.label29.AutoSize = true;
    this.label29.Location = new Point(189, 242);
    this.label29.Name = "label29";
    this.label29.Size = new Size(252, 13);
    this.label29.TabIndex = 67;
    this.label29.Text = "- Additive/Subtractive with each other. (10+10 = 20)";
    this.label30.AutoSize = true;
    this.label30.Location = new Point(4, 242);
    this.label30.Name = "label30";
    this.label30.Size = new Size(109, 13);
    this.label30.TabIndex = 66;
    this.label30.Text = "Elemental Resistance";
    this.EleRes.Location = new Point(116, 240 /*0xF0*/);
    this.EleRes.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.EleRes.Minimum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      int.MinValue
    });
    this.EleRes.Name = "EleRes";
    this.EleRes.Size = new Size(67, 20);
    this.EleRes.TabIndex = 65;
    this.EleRes.ValueChanged += new EventHandler(this.EleRes_ValueChanged);
    this.TotalPowerLBL.AutoSize = true;
    this.TotalPowerLBL.Location = new Point(12, 28);
    this.TotalPowerLBL.Name = "TotalPowerLBL";
    this.TotalPowerLBL.Size = new Size(67, 13);
    this.TotalPowerLBL.TabIndex = 68;
    this.TotalPowerLBL.Text = "Total Power:";
    this.BaseDamageLBL.AutoSize = true;
    this.BaseDamageLBL.Location = new Point(2, 41);
    this.BaseDamageLBL.Name = "BaseDamageLBL";
    this.BaseDamageLBL.Size = new Size(77, 13);
    this.BaseDamageLBL.TabIndex = 69;
    this.BaseDamageLBL.Text = "Base Damage:";
    this.TotalPowerNum2.Location = new Point(128 /*0x80*/, 87);
    this.TotalPowerNum2.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.TotalPowerNum2.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.TotalPowerNum2.Name = "TotalPowerNum2";
    this.TotalPowerNum2.Size = new Size(48 /*0x30*/, 20);
    this.TotalPowerNum2.TabIndex = 70;
    this.TotalPowerNum2.ValueChanged += new EventHandler(this.TotalPowerNum2_ValueChanged);
    this.TotalPowerNum3.Location = new Point(184, 87);
    this.TotalPowerNum3.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.TotalPowerNum3.Minimum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      int.MinValue
    });
    this.TotalPowerNum3.Name = "TotalPowerNum3";
    this.TotalPowerNum3.Size = new Size(48 /*0x30*/, 20);
    this.TotalPowerNum3.TabIndex = 71;
    this.TotalPowerNum3.ValueChanged += new EventHandler(this.TotalPowerNum3_ValueChanged);
    this.button1.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.button1.Location = new Point(396, 57);
    this.button1.Name = "button1";
    this.button1.Size = new Size(119, 24);
    this.button1.TabIndex = 72;
    this.button1.Text = "Use Weapon Form Stats";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Visible = false;
    this.numericUpDown1.Location = new Point(357, 60);
    this.numericUpDown1.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.numericUpDown1.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericUpDown1.Name = "numericUpDown1";
    this.numericUpDown1.Size = new Size(33, 20);
    this.numericUpDown1.TabIndex = 73;
    this.numericUpDown1.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericUpDown1.Visible = false;
    this.label31.AutoSize = true;
    this.label31.Location = new Point(309, 63 /*0x3F*/);
    this.label31.Name = "label31";
    this.label31.Size = new Size(42, 13);
    this.label31.TabIndex = 74;
    this.label31.Text = "WEP #";
    this.label31.Visible = false;
    this.comboBox2.FormattingEnabled = true;
    this.comboBox2.Location = new Point(396, 31 /*0x1F*/);
    this.comboBox2.Name = "comboBox2";
    this.comboBox2.Size = new Size(119, 21);
    this.comboBox2.TabIndex = 75;
    this.comboBox2.Visible = false;
    this.label32.AutoSize = true;
    this.label32.Location = new Point(393, 18);
    this.label32.Name = "label32";
    this.label32.Size = new Size(54, 13);
    this.label32.TabIndex = 76;
    this.label32.Text = "Skill Used";
    this.label32.Visible = false;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.CritDmgLbl);
    this.panel1.Controls.Add((Control) this.BaseDamageLBL);
    this.panel1.Controls.Add((Control) this.TotalPowerLBL);
    this.panel1.Controls.Add((Control) this.Test);
    this.panel1.Controls.Add((Control) this.DR);
    this.panel1.Location = new Point(522, 7);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(120, 74);
    this.panel1.TabIndex = 77;
    this.CritDmgLbl.AutoSize = true;
    this.CritDmgLbl.Location = new Point(18, 55);
    this.CritDmgLbl.Name = "CritDmgLbl";
    this.CritDmgLbl.Size = new Size(61, 13);
    this.CritDmgLbl.TabIndex = 70;
    this.CritDmgLbl.Text = "Crit Dmg %:";
    this.EliteCheck.AutoSize = true;
    this.EliteCheck.Location = new Point(245, 117);
    this.EliteCheck.Name = "EliteCheck";
    this.EliteCheck.Size = new Size(46, 17);
    this.EliteCheck.TabIndex = 78;
    this.EliteCheck.Text = "Elite";
    this.EliteCheck.UseVisualStyleBackColor = true;
    this.EliteCheck.CheckedChanged += new EventHandler(this.EliteCheck_CheckedChanged);
    this.label25.AutoSize = true;
    this.label25.Location = new Point(128 /*0x80*/, 118);
    this.label25.Name = "label25";
    this.label25.Size = new Size(78, 13);
    this.label25.TabIndex = 80 /*0x50*/;
    this.label25.Text = "Excel Charges:";
    this.ExcelNum.Location = new Point(206, 115);
    this.ExcelNum.Maximum = new Decimal(new int[4]
    {
      100000,
      0,
      0,
      0
    });
    this.ExcelNum.Name = "ExcelNum";
    this.ExcelNum.Size = new Size(33, 20);
    this.ExcelNum.TabIndex = 79;
    this.ExcelNum.ValueChanged += new EventHandler(this.ExcelNum_ValueChanged);
    this.HolyCheck.AutoSize = true;
    this.HolyCheck.Location = new Point(288, 117);
    this.HolyCheck.Name = "HolyCheck";
    this.HolyCheck.Size = new Size(47, 17);
    this.HolyCheck.TabIndex = 81;
    this.HolyCheck.Text = "Holy";
    this.HolyCheck.UseVisualStyleBackColor = true;
    this.HolyCheck.CheckedChanged += new EventHandler(this.HolyCheck_CheckedChanged);
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.RESLBL);
    this.panel2.Controls.Add((Control) this.DEFLBL);
    this.panel2.Controls.Add((Control) this.GUILBL);
    this.panel2.Location = new Point(585, 320);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(69, 51);
    this.panel2.TabIndex = 82;
    this.GUILBL.AutoSize = true;
    this.GUILBL.Location = new Point(3, 6);
    this.GUILBL.Name = "GUILBL";
    this.GUILBL.RightToLeft = RightToLeft.No;
    this.GUILBL.Size = new Size(29, 13);
    this.GUILBL.TabIndex = 83;
    this.GUILBL.Text = "GUI:";
    this.GUILBL.TextAlign = ContentAlignment.MiddleRight;
    this.DEFLBL.AutoSize = true;
    this.DEFLBL.Location = new Point(1, 19);
    this.DEFLBL.Name = "DEFLBL";
    this.DEFLBL.RightToLeft = RightToLeft.No;
    this.DEFLBL.Size = new Size(31 /*0x1F*/, 13);
    this.DEFLBL.TabIndex = 84;
    this.DEFLBL.Text = "DEF:";
    this.DEFLBL.TextAlign = ContentAlignment.MiddleRight;
    this.RESLBL.AutoSize = true;
    this.RESLBL.Location = new Point(0, 32 /*0x20*/);
    this.RESLBL.Name = "RESLBL";
    this.RESLBL.RightToLeft = RightToLeft.No;
    this.RESLBL.Size = new Size(32 /*0x20*/, 13);
    this.RESLBL.TabIndex = 85;
    this.RESLBL.Text = "RES:";
    this.RESLBL.TextAlign = ContentAlignment.MiddleRight;
    this.label33.AutoSize = true;
    this.label33.Location = new Point(590, 304);
    this.label33.Name = "label33";
    this.label33.Size = new Size(56, 13);
    this.label33.TabIndex = 83;
    this.label33.Text = "Char Stats";
    this.label33.Click += new EventHandler(this.label33_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(658, 400);
    this.Controls.Add((Control) this.label33);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.HolyCheck);
    this.Controls.Add((Control) this.label25);
    this.Controls.Add((Control) this.ExcelNum);
    this.Controls.Add((Control) this.EliteCheck);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.label32);
    this.Controls.Add((Control) this.comboBox2);
    this.Controls.Add((Control) this.label31);
    this.Controls.Add((Control) this.numericUpDown1);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.TotalPowerNum3);
    this.Controls.Add((Control) this.TotalPowerNum2);
    this.Controls.Add((Control) this.label29);
    this.Controls.Add((Control) this.label30);
    this.Controls.Add((Control) this.EleRes);
    this.Controls.Add((Control) this.label28);
    this.Controls.Add((Control) this.label27);
    this.Controls.Add((Control) this.label26);
    this.Controls.Add((Control) this.label24);
    this.Controls.Add((Control) this.label23);
    this.Controls.Add((Control) this.label22);
    this.Controls.Add((Control) this.label21);
    this.Controls.Add((Control) this.SWAPercent);
    this.Controls.Add((Control) this.label20);
    this.Controls.Add((Control) this.NumOfHits);
    this.Controls.Add((Control) this.label19);
    this.Controls.Add((Control) this.CritFlatNum);
    this.Controls.Add((Control) this.label18);
    this.Controls.Add((Control) this.CritMod);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.FlatBonusNum);
    this.Controls.Add((Control) this.label16);
    this.Controls.Add((Control) this.TotalPowerNum);
    this.Controls.Add((Control) this.label15);
    this.Controls.Add((Control) this.EleAtkNum);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.EleScale);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.FanPwr);
    this.Controls.Add((Control) this.DR9);
    this.Controls.Add((Control) this.DR8);
    this.Controls.Add((Control) this.DR7);
    this.Controls.Add((Control) this.DR6);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.DR5);
    this.Controls.Add((Control) this.Shield3);
    this.Controls.Add((Control) this.Shield2);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.Shield1);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.checkBox2);
    this.Controls.Add((Control) this.comboBox1);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.checkBox1);
    this.Controls.Add((Control) this.DR2);
    this.Controls.Add((Control) this.DR4);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.BaseDamageNum);
    this.Controls.Add((Control) this.DR3);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.ArmorNum);
    this.Controls.Add((Control) this.DR1);
    this.Controls.Add((Control) this.DamageAmp);
    this.Controls.Add((Control) this.MagicBox);
    this.Name = nameof (ReductionWindow);
    this.RightToLeft = RightToLeft.No;
    this.Text = "Damage Reduction";
    this.FormClosing += new FormClosingEventHandler(this.ReductionWindow_FormClosing_1);
    this.Load += new EventHandler(this.ReductionWindow_Load);
    this.DamageAmp.EndInit();
    this.DR1.EndInit();
    this.ArmorNum.EndInit();
    this.DR3.EndInit();
    this.BaseDamageNum.EndInit();
    this.DR4.EndInit();
    this.DR2.EndInit();
    this.Shield1.EndInit();
    this.Shield2.EndInit();
    this.Shield3.EndInit();
    this.DR5.EndInit();
    this.DR6.EndInit();
    this.DR7.EndInit();
    this.DR8.EndInit();
    this.DR9.EndInit();
    this.FanPwr.EndInit();
    this.EleScale.EndInit();
    this.EleAtkNum.EndInit();
    this.TotalPowerNum.EndInit();
    this.FlatBonusNum.EndInit();
    this.CritMod.EndInit();
    this.CritFlatNum.EndInit();
    this.NumOfHits.EndInit();
    this.SWAPercent.EndInit();
    this.EleRes.EndInit();
    this.TotalPowerNum2.EndInit();
    this.TotalPowerNum3.EndInit();
    this.numericUpDown1.EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.ExcelNum.EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
