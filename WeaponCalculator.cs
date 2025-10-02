// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.WeaponCalculator
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class WeaponCalculator : Form
{
  public MainWindow MainForm;
  private int STR;
  private int WIL;
  private int SKI;
  private int CEL;
  private int DEF;
  private int RES;
  private int VIT;
  private int FAI;
  private int LUC;
  private int GUI;
  private int SAN;
  private int APT;
  public sbyte UpgradeStat;
  public sbyte SentimentalityStat;
  public sbyte PowerBonus;
  public sbyte CritBonus;
  public sbyte HitBonus;
  public short MaterialPower;
  public short MaterialCrit;
  public short MaterialHit;
  public short MaterialWeight;
  public short WeaponP1Power;
  public short WeaponP1Crit;
  public short WeaponP1Hit;
  public short WeaponP1Weight;
  public short WeaponP2Power;
  public short WeaponP2Crit;
  public short WeaponP2Hit;
  public short WeaponP2Weight;
  public short WeaponP3Power;
  public short WeaponP3Crit;
  public short WeaponP3Hit;
  public short WeaponP3Weight;
  public short ScaleSTR;
  public short ScaleWIL;
  public short ScaleSKI;
  public short ScaleCEL;
  public short ScaleDEF;
  public short ScaleRES;
  public short ScaleVIT;
  public short ScaleFAI;
  public short ScaleLUC;
  public short ScaleGUI;
  public short ScaleSAN;
  public short Power;
  public short Critical;
  public short Accuracy;
  public short Weight;
  public short RarityW;
  public short CriticalModifier;
  public bool STRWeapon;
  public int RarityValue;
  public int EnchantHit;
  public int EnchantWeight;
  public int WeightBonus;
  public int EnchantCrit;
  public int EnchantCritMod;
  public int EnchantPower;
  public double WeaponP1CritDam;
  public double WeaponP2CritDam;
  public double WeaponP3CritDam;
  public double EnchantWeightMod = 1.0;
  public string WeaponPart1Type;
  public string WeaponPart2Type;
  public string WeaponPart3Type;
  public string MaterialType;
  public string WeaponDesc;
  public string WeaponEffect;
  public string WeaponPotential;
  public string WeaponSpecialStrike;
  public int SWA;
  public string WeaponChoice;
  public string EnchantChoice;
  public string Tag1 = string.Empty;
  public string Tag2 = string.Empty;
  public string Tag3 = string.Empty;
  public string Tag4 = string.Empty;
  private string nl = "\r\n";
  private short MainStat;
  private int BasePower;
  private int DescOpen;
  private DescForm WepDesc;
  private IContainer components;
  private NumericUpDown AptitudeBox;
  private NumericUpDown SanctityBox;
  private NumericUpDown GuileBox;
  private NumericUpDown LuckBox;
  private NumericUpDown FaithBox;
  private NumericUpDown VitalityBox;
  private NumericUpDown ResistanceBox;
  private NumericUpDown DefenseBox;
  private NumericUpDown CelerityBox;
  private NumericUpDown SkillBox;
  private NumericUpDown WillBox;
  private NumericUpDown StrengthBox;
  private Label AptitudeNameLabel;
  private Label SanctityNameLabel;
  private Label GuileNameLabel;
  private Label LuckNameLabel;
  private Label FaithNameLabel;
  private Label VitalityNameLabel;
  private Label ResistanceNameLabel;
  private Label DefenseNameLabel;
  private Label CelerityNameLabel;
  private Label SkillNameLabel;
  private Label WillNameLabel;
  private Label StrengthNameLabel;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private NumericUpDown WeightBox;
  private NumericUpDown CriticalBox;
  private NumericUpDown AccuracyBox;
  private NumericUpDown PowerBox;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label CritLabel;
  private Label HitLabel;
  private Label SWALabel;
  private Label label6;
  private NumericUpDown TwoHandBox;
  private Label label10;
  private NumericUpDown CritModBox;
  private Label CritModLabel;
  private Label label12;
  private Label CritDmgLabel;
  private Label label14;
  private ComboBox MaterialBox;
  private Label label11;
  private CheckBox PowerQuality;
  private CheckBox AccuracyQuality;
  private CheckBox CriticalQuality;
  private Label WeightLabel;
  private Label label15;
  private CheckBox WeightPlusBox;
  private CheckBox WeightMinusBox;
  private CheckBox SentimentBox;
  private ComboBox WeaponPart1Box;
  private Label label13;
  private Label label16;
  private ComboBox WeaponPart2Box;
  private Label label17;
  private ComboBox WeaponPart3Box;
  private ComboBox EnchantBox;
  private Label label18;
  private NumericUpDown Rarity;
  private Label label19;
  private CheckBox GunBox;
  private CheckBox RifleBox;
  private ComboBox WeaponBox;
  private Label label20;
  private Label MutationLabel;
  private CheckBox LockWPNE;
  private CheckBox AutoCheck;
  private Label Tag1Label;
  private Label Tag2Label;
  private Label Tag3Label;
  private CheckBox TagVisibleCheck;
  private Label label22;
  private NumericUpDown UpgradeLevelNUM;
  private Button WeaponEffectBtn;
  private CheckBox STRCrit;

  public WeaponCalculator(MainWindow that)
  {
    this.InitializeComponent();
    this.MainForm = that;
    if (!this.MainForm.dark)
      return;
    this.ForeColor = Color.White;
    this.BackColor = Color.FromArgb(55, 55, 55);
  }

  public WeaponCalculator()
  {
  }

  private void WeaponCalculator_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.MainForm.ClosedWeaponCalculator();
  }

  internal void UpdateCalc(object sender, EventArgs e) => this.UpdateSelf();

  private void WeaponCalculator_Load(object sender, EventArgs e)
  {
  }

  private void STRCrit_CheckedChanged(object sender, EventArgs e)
  {
    this.STRWeapon = this.STRCrit.Checked;
    this.UpdateSelf();
  }

  private void AutoCheck_CheckedChanged(object sender, EventArgs e) => this.UpdateSelf();

  private void TagVisibleCheck_CheckedChanged(object sender, EventArgs e)
  {
    this.Tag1Label.Visible = false;
    this.Tag2Label.Visible = false;
    this.Tag3Label.Visible = false;
    if (this.TagVisibleCheck.Checked)
      this.WeaponUpdate();
    this.UpdateSelf();
  }

  private void AccuracyQuality_CheckedChanged(object sender, EventArgs e)
  {
    this.HitBonus = (sbyte) 0;
    if (this.AccuracyQuality.Checked)
      this.HitBonus = (sbyte) 4;
    this.UpdateSelf();
  }

  private void GunBox_CheckedChanged(object sender, EventArgs e) => this.UpdateSelf();

  private void RifleBox_CheckedChanged(object sender, EventArgs e) => this.UpdateSelf();

  private void CriticalQuality_CheckedChanged(object sender, EventArgs e)
  {
    this.CritBonus = (sbyte) 0;
    if (this.CriticalQuality.Checked)
      this.CritBonus = (sbyte) 4;
    this.UpdateSelf();
  }

  private void UpgradeLevelNUM_ValueChanged(object sender, EventArgs e)
  {
    this.UpgradeStat = (sbyte) this.UpgradeLevelNUM.Value;
    this.UpdateSelf();
  }

  private void SentimentBox_CheckedChanged(object sender, EventArgs e)
  {
    this.SentimentalityStat = (sbyte) 0;
    if (this.SentimentBox.Checked)
      this.SentimentalityStat = (sbyte) 2;
    this.UpdateSelf();
  }

  private void WeightPlusBox_CheckedChanged(object sender, EventArgs e)
  {
    this.WeightCheck();
    this.UpdateSelf();
  }

  private void WeightMinusBox_CheckedChanged(object sender, EventArgs e)
  {
    this.WeightCheck();
    this.UpdateSelf();
  }

  private void WeightCheck()
  {
    this.WeightBonus = 0;
    if (this.WeightPlusBox.Checked)
      this.WeightBonus += 2;
    if (!this.WeightMinusBox.Checked)
      return;
    this.WeightBonus -= 2;
  }

  private void PowerQuality_CheckedChanged(object sender, EventArgs e)
  {
    this.PowerBonus = (sbyte) 0;
    if (this.PowerQuality.Checked)
      this.PowerBonus = (sbyte) 2;
    this.UpdateSelf();
  }

  private void TwoHandCheck_CheckedChanged(object sender, EventArgs e) => this.UpdateSelf();

  private void EnchantBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.EnchantChoice = (string) this.EnchantBox.SelectedItem;
    this.EnchantStat();
    this.UpdateSelf();
  }

  private void Rarity_ValueChanged(object sender, EventArgs e)
  {
    if (!(this.EnchantBox.Text == "Rebellion"))
      return;
    this.UpdateSelf();
  }

  private void MaterialBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.MaterialPower = (short) 0;
    this.MaterialHit = (short) 0;
    this.MaterialCrit = (short) 0;
    this.MaterialWeight = (short) 0;
    switch ((string) this.MaterialBox.SelectedItem)
    {
      case "Accursed":
        this.MaterialCrit = (short) 6;
        this.MaterialWeight = (short) 8;
        break;
      case "Arctic":
        this.MaterialCrit = (short) 5;
        this.MaterialHit = (short) -5;
        break;
      case "Ashen Chapter":
        this.MaterialPower = (short) 2;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 6;
        break;
      case "Aureate":
        this.MaterialPower = (short) -2;
        this.MaterialCrit = (short) -5;
        this.MaterialWeight = (short) 6;
        break;
      case "Beast Chapter":
        this.MaterialPower = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 8;
        break;
      case "Boulder":
        this.MaterialPower = (short) 10;
        this.MaterialCrit = (short) 10;
        this.MaterialHit = (short) -5;
        this.MaterialWeight = (short) 25;
        break;
      case "Carapace":
        this.MaterialPower = (short) 2;
        this.MaterialWeight = (short) 5;
        break;
      case "Clawice":
        this.MaterialPower = (short) 1;
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 5;
        break;
      case "Coldbark":
        this.MaterialCrit = (short) 5;
        this.MaterialHit = (short) -5;
        break;
      case "Conduiz":
        this.MaterialCrit = (short) 3;
        break;
      case "Coral":
        this.MaterialPower = (short) 1;
        this.MaterialCrit = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 1;
        break;
      case "Devilbark":
        this.MaterialPower = (short) 2;
        this.MaterialWeight = (short) 5;
        break;
      case "Dragon":
        this.MaterialPower = (short) 3;
        this.MaterialCrit = (short) 5;
        this.MaterialHit = (short) 5;
        this.MaterialWeight = (short) 8;
        break;
      case "Fine Art":
        this.MaterialPower = (short) -2;
        this.MaterialCrit = (short) -5;
        this.MaterialWeight = (short) 6;
        break;
      case "Firebark":
        this.MaterialPower = (short) 2;
        this.MaterialCrit = (short) -5;
        break;
      case "Fireblood":
        this.MaterialPower = (short) 8;
        this.MaterialWeight = (short) 8;
        break;
      case "Fish":
        this.MaterialPower = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 8;
        break;
      case "Foamy Chapter":
        this.MaterialPower = (short) 1;
        this.MaterialHit = (short) 5;
        this.MaterialWeight = (short) 6;
        break;
      case "Folded Steel":
        this.MaterialPower = (short) 2;
        this.MaterialCrit = (short) 5;
        break;
      case "Fossil":
        this.MaterialPower = (short) 5;
        this.MaterialCrit = (short) -5;
        this.MaterialWeight = (short) 6;
        break;
      case "Fungusbark":
        this.MaterialPower = (short) 2;
        this.MaterialWeight = (short) 2;
        break;
      case "Galdric":
        this.MaterialPower = (short) -2;
        this.MaterialHit = (short) 5;
        this.MaterialWeight = (short) -5;
        break;
      case "Gasprock":
        this.MaterialPower = (short) 2;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 5;
        break;
      case "Gorgon":
        this.MaterialHit = (short) 8;
        this.MaterialWeight = (short) 8;
        break;
      case "Gravestone":
        this.MaterialPower = (short) 2;
        this.MaterialCrit = (short) -5;
        this.MaterialWeight = (short) 3;
        break;
      case "Heretic Chapter":
        this.MaterialPower = (short) 5;
        this.MaterialWeight = (short) 5;
        break;
      case "Hollow Log":
        this.MaterialPower = (short) 10;
        this.MaterialHit = (short) -5;
        this.MaterialCrit = (short) 10;
        this.MaterialWeight = (short) 25;
        break;
      case "Iceblood":
        this.MaterialCrit = (short) 8;
        this.MaterialWeight = (short) 8;
        break;
      case "Insect":
        this.MaterialCrit = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 8;
        break;
      case "Isesip Chapter":
        this.MaterialPower = (short) 2;
        this.MaterialHit = (short) 2;
        this.MaterialCrit = (short) 2;
        this.MaterialWeight = (short) 2;
        break;
      case "Ivorybark":
        this.MaterialPower = (short) -2;
        this.MaterialCrit = (short) -5;
        this.MaterialWeight = (short) 6;
        break;
      case "Kraboid":
        this.MaterialHit = (short) 6;
        this.MaterialWeight = (short) 8;
        break;
      case "Kraken Chapter":
        this.MaterialPower = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 2;
        break;
      case "Magmic":
        this.MaterialPower = (short) 2;
        this.MaterialCrit = (short) -5;
        break;
      case "Markedbark":
        this.MaterialCrit = (short) 4;
        this.MaterialHit = (short) 4;
        this.MaterialWeight = (short) 4;
        break;
      case "Mercala Chapter":
        this.MaterialHit = (short) 5;
        this.MaterialWeight = (short) 5;
        break;
      case "Meteorite":
        this.MaterialPower = (short) 5;
        this.MaterialWeight = (short) 8;
        break;
      case "Moldy Chapter":
        this.MaterialPower = (short) 2;
        this.MaterialWeight = (short) 3;
        break;
      case "Mossybark":
        this.MaterialPower = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) -3;
        this.MaterialWeight = (short) 3;
        break;
      case "Nerif Chapter":
        this.MaterialPower = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 2;
        break;
      case "Nightflower":
        this.MaterialHit = (short) -5;
        break;
      case "Oribark":
        this.MaterialPower = (short) -1;
        this.MaterialCrit = (short) -1;
        this.MaterialHit = (short) -1;
        break;
      case "Orichal Chapter":
        this.MaterialPower = (short) -1;
        this.MaterialHit = (short) -1;
        this.MaterialCrit = (short) -1;
        this.MaterialWeight = (short) 2;
        break;
      case "Orichalum":
        this.MaterialPower = (short) -1;
        this.MaterialCrit = (short) -1;
        this.MaterialHit = (short) -1;
        this.MaterialWeight = (short) 2;
        break;
      case "Petrified Wood":
        this.MaterialPower = (short) 5;
        this.MaterialWeight = (short) 6;
        break;
      case "Planetarium":
        this.MaterialPower = (short) 1;
        this.MaterialCrit = (short) 2;
        this.MaterialHit = (short) 2;
        this.MaterialWeight = (short) -2;
        break;
      case "Rainbowbark":
        this.MaterialPower = (short) 3;
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) 3;
        break;
      case "Rockdirt":
        this.MaterialPower = (short) 1;
        this.MaterialCrit = (short) 4;
        this.MaterialHit = (short) 2;
        this.MaterialWeight = (short) 4;
        break;
      case "Rotwood":
        this.MaterialHit = (short) 3;
        break;
      case "Sandstone":
        this.MaterialPower = (short) -2;
        this.MaterialCrit = (short) 5;
        this.MaterialWeight = (short) 3;
        break;
      case "Sandy Chapter":
        this.MaterialPower = (short) 2;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 6;
        break;
      case "Scorched Wood":
        this.MaterialPower = (short) 2;
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 6;
        break;
      case "Seedbark":
        this.MaterialPower = (short) 4;
        this.MaterialHit = (short) 2;
        this.MaterialCrit = (short) -3;
        this.MaterialWeight = (short) 4;
        break;
      case "Shark":
        this.MaterialPower = (short) 6;
        this.MaterialWeight = (short) 8;
        break;
      case "Sheet Music":
        this.MaterialPower = (short) 1;
        this.MaterialCrit = (short) 2;
        this.MaterialHit = (short) 3;
        this.MaterialWeight = (short) 4;
        break;
      case "Smoothbark":
        this.MaterialPower = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 2;
        break;
      case "Snakeman":
        this.MaterialCrit = (short) 8;
        this.MaterialWeight = (short) 8;
        break;
      case "Spatial":
        this.MaterialPower = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 8;
        break;
      case "Star Chapter":
        this.MaterialPower = (short) 1;
        this.MaterialCrit = (short) 5;
        this.MaterialWeight = (short) 6;
        break;
      case "Storm Chapter":
        this.MaterialCrit = (short) 5;
        this.MaterialWeight = (short) 5;
        break;
      case "Sylph Chapter":
        this.MaterialHit = (short) 3;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) 2;
        break;
      case "Thin Chapter":
        this.MaterialPower = (short) -2;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) -6;
        break;
      case "Thinsteel":
        this.MaterialPower = (short) -3;
        this.MaterialHit = (short) 5;
        this.MaterialCrit = (short) 3;
        this.MaterialWeight = (short) -2;
        break;
      case "Windbark":
        this.MaterialPower = (short) -2;
        this.MaterialHit = (short) 5;
        this.MaterialWeight = (short) -2;
        break;
    }
    this.UpdateSelf();
  }

  private void WeaponPart1Box_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.WeaponP1Power = (short) 0;
    this.WeaponP1Hit = (short) 0;
    this.WeaponP1Crit = (short) 0;
    this.WeaponP1Weight = (short) 0;
    this.WeaponP1CritDam = 0.0;
    switch ((string) this.WeaponPart1Box.SelectedItem)
    {
      case "Balanced":
        this.WeaponP1Hit = (short) 3;
        this.WeaponP1Weight = (short) 1;
        break;
      case "Barbed":
        this.WeaponP1Power = (short) 1;
        this.WeaponP1Crit = (short) 5;
        this.WeaponP1Weight = (short) 2;
        break;
      case "Blank Cover":
        this.WeaponP1Crit = (short) 5;
        this.WeaponP1Power = (short) -2;
        break;
      case "Chain":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1Weight = (short) 10;
        break;
      case "Compact":
        this.WeaponP1Crit = (short) 15;
        this.WeaponP1Weight = (short) -4;
        break;
      case "Composite":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1Crit = (short) -5;
        break;
      case "Crescent":
        this.WeaponP1Hit = (short) 5;
        this.WeaponP1Crit = (short) -5;
        break;
      case "Curved Axehead":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Hit = (short) 5;
        break;
      case "Curved Pole":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Crit = (short) 5;
        break;
      case "Cutting":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Crit = (short) 10;
        break;
      case "Dense":
        this.WeaponP1Power = (short) 2;
        break;
      case "Diary Lock":
        this.WeaponP1Hit = (short) -3;
        this.WeaponP1Weight = (short) 5;
        this.WeaponP1Crit = (short) 3;
        break;
      case "Double String":
        this.WeaponP1Crit = (short) -5;
        break;
      case "Double(Shotgun)":
        this.WeaponP1Hit = (short) 5;
        this.WeaponP1Weight = (short) 3;
        break;
      case "Elongated":
        this.WeaponP1Crit = (short) 8;
        this.WeaponP1Weight = (short) 4;
        break;
      case "Extended Pole":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Hit = (short) 5;
        break;
      case "Flexible":
        this.WeaponP1Hit = (short) -5;
        break;
      case "Focused":
        this.WeaponP1Hit = (short) 5;
        break;
      case "Guillotine":
        this.WeaponP1Power = (short) 3;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Weight = (short) 1;
        break;
      case "Hardback Cover":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1Weight = (short) 3;
        break;
      case "Helix":
        this.WeaponP1Power = (short) 1;
        this.WeaponP1Hit = (short) -4;
        this.WeaponP1Weight = (short) 2;
        break;
      case "Hellish Eye":
        this.WeaponP1Hit = (short) 3;
        this.WeaponP1Weight = (short) 5;
        this.WeaponP1Crit = (short) -5;
        break;
      case "Hollow":
        this.WeaponP1Power = (short) -2;
        this.WeaponP1Weight = (short) -5;
        break;
      case "Hooked":
        this.WeaponP1Power = (short) 1;
        this.WeaponP1Crit = (short) -5;
        break;
      case "Huge(Sword)":
        this.WeaponP1Power = (short) 5;
        this.WeaponP1Hit = (short) -10;
        this.WeaponP1Crit = (short) -10;
        this.WeaponP1Weight = (short) 10;
        break;
      case "Large Body":
        this.WeaponP1Weight = (short) 6;
        break;
      case "Leather":
        this.WeaponP1Power = (short) -2;
        this.WeaponP1Hit = (short) 5;
        break;
      case "Long":
        this.WeaponP1Crit = (short) -5;
        break;
      case "Piercing Blade":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Crit = (short) -5;
        break;
      case "Razor Blade":
        this.WeaponP1Crit = (short) 10;
        break;
      case "Serrated":
        this.WeaponP1Power = (short) -1;
        break;
      case "Short":
        this.WeaponP1Power = (short) 5;
        break;
      case "Silk":
        this.WeaponP1Power = (short) -2;
        this.WeaponP1Hit = (short) 5;
        break;
      case "Sniper(Rifle)":
        this.WeaponP1Crit = (short) 15;
        this.WeaponP1Weight = (short) 8;
        break;
      case "Spiked Axehead":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1CritDam = 10.0;
        break;
      case "Spiked Knuckles":
        this.WeaponP1Power = (short) 1;
        this.WeaponP1Hit = (short) -4;
        break;
      case "Tempered":
        this.WeaponP1Power = (short) -1;
        break;
      case "Thin Body":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Weight = (short) -4;
        break;
      case "Thin Cover":
        this.WeaponP1Weight = (short) -5;
        break;
      case "Thin Spearhead":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Weight = (short) -2;
        break;
      case "Tight":
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Crit = (short) 5;
        break;
      case "Wide":
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Crit = (short) 5;
        break;
      case "Wire":
        this.WeaponP1Power = (short) 1;
        break;
      case "Wooden":
        this.WeaponP1Weight = (short) -5;
        break;
      case "Wrapped":
        this.WeaponP1Crit = (short) -4;
        break;
    }
    this.UpdateSelf();
  }

  private void WeaponPart2Box_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.WeaponP2Power = (short) 0;
    this.WeaponP2Hit = (short) 0;
    this.WeaponP2Crit = (short) 0;
    this.WeaponP2Weight = (short) 0;
    this.WeaponP2CritDam = 0.0;
    switch ((string) this.WeaponPart2Box.SelectedItem)
    {
      case "Balanced":
        this.WeaponP2Hit = (short) 3;
        this.WeaponP2Weight = (short) 1;
        break;
      case "Bone Binds":
        this.WeaponP2Weight = (short) 3;
        this.WeaponP2Crit = (short) 5;
        break;
      case "Chain":
        this.WeaponP2Power = (short) 2;
        this.WeaponP2Weight = (short) 10;
        break;
      case "Curved Pole":
        this.WeaponP2Power = (short) -1;
        this.WeaponP2Crit = (short) 5;
        break;
      case "Custom":
        this.WeaponP2Hit = (short) 3;
        this.WeaponP2Crit = (short) 3;
        break;
      case "Double String":
        this.WeaponP2Crit = (short) -5;
        break;
      case "Empty":
        this.WeaponP2Hit = (short) -5;
        this.WeaponP2Crit = (short) 5;
        break;
      case "Extended":
        this.WeaponP2Weight = (short) 2;
        break;
      case "Extended Pole":
        this.WeaponP2Power = (short) -1;
        this.WeaponP2Hit = (short) 5;
        break;
      case "Firm Hilt":
        this.WeaponP2Hit = (short) 3;
        break;
      case "Flexible":
        this.WeaponP2Hit = (short) -5;
        break;
      case "Full":
        this.WeaponP2Weight = (short) 4;
        break;
      case "Helix":
        this.WeaponP2Power = (short) 1;
        this.WeaponP2Hit = (short) -4;
        this.WeaponP2Weight = (short) 2;
        break;
      case "Huge(Sword)":
        this.WeaponP2Power = (short) 5;
        this.WeaponP2Hit = (short) -10;
        this.WeaponP2Crit = (short) -10;
        this.WeaponP2Weight = (short) 10;
        break;
      case "Insulated Hilt":
        this.WeaponP2Power = (short) -1;
        break;
      case "Leather Binds":
        this.WeaponP2Weight = (short) -3;
        this.WeaponP2Hit = (short) 3;
        this.WeaponP2Power = (short) -2;
        break;
      case "Locking":
        this.WeaponP2Weight = (short) 1;
        break;
      case "Long Binds":
        this.WeaponP2Weight = (short) 5;
        break;
      case "Loose":
        this.WeaponP2Hit = (short) -6;
        break;
      case "Magic Binds":
        this.WeaponP2Weight = (short) -8;
        this.WeaponP2Hit = (short) -3;
        break;
      case "Metal Binds":
        this.WeaponP2Weight = (short) 3;
        this.WeaponP2Power = (short) 3;
        break;
      case "Onigan Hilt":
        this.WeaponP2Hit = (short) -5;
        this.WeaponP2Crit = (short) 5;
        break;
      case "Piercing Blade":
        this.WeaponP2Power = (short) 2;
        this.WeaponP2Hit = (short) -5;
        this.WeaponP2Crit = (short) -5;
        break;
      case "Razor Blade":
        this.WeaponP2Crit = (short) 10;
        break;
      case "Razor Guard":
        this.WeaponP2Power = (short) 1;
        this.WeaponP2Weight = (short) 1;
        break;
      case "Revolver":
        this.WeaponP2Crit = (short) 5;
        this.WeaponP2Power = (short) -2;
        break;
      case "Serrated":
        this.WeaponP2Power = (short) -1;
        break;
      case "Sharp Hilt":
        this.WeaponP2Power = (short) 1;
        this.WeaponP2Hit = (short) -5;
        break;
      case "Silk":
        this.WeaponP2Power = (short) -2;
        this.WeaponP2Hit = (short) 5;
        break;
      case "Soft":
        this.WeaponP2Power = (short) -1;
        break;
      case "Spiked Wrist":
        this.WeaponP2Power = (short) 1;
        this.WeaponP2Weight = (short) 2;
        break;
      case "Steady":
        this.WeaponP2Hit = (short) 5;
        this.WeaponP2Crit = (short) -5;
        break;
      case "Strings Wrist":
        this.WeaponP2Hit = (short) 4;
        break;
      case "Sturdy":
        this.WeaponP2Hit = (short) 3;
        this.WeaponP2Weight = (short) 1;
        break;
      case "Tight":
        this.WeaponP2Hit = (short) -5;
        this.WeaponP2Crit = (short) 5;
        break;
      case "Weighted":
        this.WeaponP2Hit = (short) -5;
        this.WeaponP2Crit = (short) 10;
        this.WeaponP2Weight = (short) 8;
        this.WeaponP2CritDam = 5.0;
        break;
      case "Wire":
        this.WeaponP2Power = (short) 1;
        break;
      case "Wooden":
        this.WeaponP2Weight = (short) -5;
        break;
      case "Wooden Hilt":
        this.WeaponP2Weight = (short) -3;
        break;
      case "Wrist Guard":
        this.WeaponP2Weight = (short) 2;
        break;
    }
    this.UpdateSelf();
  }

  private void WeaponPart3Box_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.WeaponP3Power = (short) 0;
    this.WeaponP3Hit = (short) 0;
    this.WeaponP3Crit = (short) 0;
    this.WeaponP3Weight = (short) 0;
    this.WeaponP3CritDam = 0.0;
    switch ((string) this.WeaponPart3Box.SelectedItem)
    {
      case "Aerodynamic":
        this.WeaponP3Hit = (short) 5;
        this.WeaponP3Crit = (short) -5;
        break;
      case "Balanced":
        this.WeaponP3Hit = (short) 3;
        this.WeaponP3Weight = (short) 1;
        break;
      case "Curved Axehead":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Hit = (short) 5;
        break;
      case "Curved Pole":
        this.WeaponP3Power = (short) -1;
        this.WeaponP3Crit = (short) 5;
        break;
      case "Cutting":
        this.WeaponP1Power = (short) -1;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Crit = (short) 10;
        break;
      case "Extended Pole":
        this.WeaponP3Power = (short) -1;
        this.WeaponP3Hit = (short) 5;
        break;
      case "Fire Arrow":
        this.WeaponP3Power = (short) 1;
        this.WeaponP3Crit = (short) -5;
        break;
      case "Firm Hilt":
        this.WeaponP3Hit = (short) 3;
        break;
      case "Flexible":
        this.WeaponP3Hit = (short) -5;
        break;
      case "Guillotine":
        this.WeaponP1Power = (short) 3;
        this.WeaponP1Hit = (short) -5;
        this.WeaponP1Weight = (short) 1;
        break;
      case "Heavy Arrow":
        this.WeaponP3Power = (short) 2;
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Weight = (short) 5;
        break;
      case "Helix":
        this.WeaponP3Power = (short) 1;
        this.WeaponP3Hit = (short) -4;
        this.WeaponP3Weight = (short) 2;
        break;
      case "Hellhound":
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Crit = (short) 5;
        break;
      case "Huge(Sword)":
        this.WeaponP3Power = (short) 5;
        this.WeaponP3Hit = (short) -10;
        this.WeaponP3Crit = (short) -10;
        this.WeaponP3Weight = (short) 10;
        break;
      case "Insulated Hilt":
        this.WeaponP3Power = (short) -1;
        break;
      case "Light Arrow":
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Crit = (short) 5;
        break;
      case "Onigan Hilt":
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Crit = (short) 5;
        break;
      case "Piercing Blade":
        this.WeaponP3Power = (short) 2;
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Crit = (short) -5;
        break;
      case "Piercing Bullet":
        this.WeaponP3Power = (short) 5;
        this.WeaponP3Crit = (short) -5;
        break;
      case "Razor Blade":
        this.WeaponP3Crit = (short) 10;
        break;
      case "Scatter":
        this.WeaponP3Power = (short) -2;
        this.WeaponP3Hit = (short) 5;
        break;
      case "Serrated":
        this.WeaponP3Power = (short) -1;
        break;
      case "Sharp Arrow":
        this.WeaponP3Hit = (short) -5;
        this.WeaponP3Crit = (short) 10;
        break;
      case "Sharp Hilt":
        this.WeaponP3Power = (short) 1;
        this.WeaponP3Hit = (short) -5;
        break;
      case "Silver":
        this.WeaponP3Hit = (short) -5;
        break;
      case "Spiked Axehead":
        this.WeaponP1Power = (short) 2;
        this.WeaponP1CritDam = 10.0;
        break;
      case "Tempered":
        this.WeaponP1Power = (short) -1;
        break;
      case "Thin Arrow":
        this.WeaponP3Power = (short) -1;
        this.WeaponP3Hit = (short) 5;
        break;
      case "Wooden":
        this.WeaponP3Weight = (short) -5;
        break;
      case "Wooden Hilt":
        this.WeaponP3Weight = (short) -3;
        break;
    }
    this.UpdateSelf();
  }

  public void EnchantStat()
  {
    this.EnchantPower = 0;
    this.EnchantHit = 0;
    this.EnchantCrit = 0;
    this.EnchantCritMod = 0;
    this.EnchantWeight = 0;
    this.EnchantWeightMod = 1.0;
    string selectedItem = (string) this.EnchantBox.SelectedItem;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(selectedItem))
    {
      case 88624105:
        if (!(selectedItem == "Fleeting"))
          break;
        this.EnchantPower = 2;
        this.EnchantCrit = 2;
        this.EnchantHit = 2;
        this.EnchantWeight = -2;
        break;
      case 865347900:
        if (!(selectedItem == "Blessed(Divine Sign)"))
          break;
        this.EnchantHit = 5 + this.FAI / 2;
        break;
      case 931430305:
        if (!(selectedItem == "Mundane"))
          break;
        this.WeaponUpdate();
        break;
      case 1053758203:
        if (!(selectedItem == "Runed"))
          break;
        this.EnchantPower = 2;
        this.EnchantCrit = 2;
        this.EnchantHit = 2;
        this.EnchantWeight = -2;
        break;
      case 1189750365:
        if (!(selectedItem == "Vorpal"))
          break;
        this.EnchantCrit = 10;
        this.EnchantCritMod = 5;
        break;
      case 1235219211:
        if (!(selectedItem == "Gigantic"))
          break;
        this.EnchantWeightMod = 1.5;
        break;
      case 1272077285:
        if (!(selectedItem == "Purity Edge"))
          break;
        this.EnchantPower = 5;
        this.EnchantCrit = 5;
        this.EnchantHit = 5;
        break;
      case 1635121158:
        if (!(selectedItem == "Divine"))
          break;
        this.EnchantPower = 2;
        this.EnchantCrit = 5;
        this.EnchantHit = 5;
        this.EnchantWeight = -2;
        break;
      case 2339316351:
        if (!(selectedItem == "Arcane"))
          break;
        this.WeaponUpdate();
        break;
      case 2425027202:
        if (!(selectedItem == "Reaper"))
          break;
        this.EnchantPower = 5;
        this.EnchantCrit = 5;
        break;
      case 2519000043:
        if (!(selectedItem == "Rustic"))
          break;
        this.EnchantPower = 5;
        break;
      case 2972600418:
        if (!(selectedItem == "Mutation"))
          break;
        this.EnchantWeightMod = 1.25;
        this.EnchantHit = -5;
        break;
      case 3273501733:
        if (!(selectedItem == "Fated"))
          break;
        this.EnchantPower = 3;
        this.EnchantCrit = 3;
        this.EnchantHit = 3;
        this.EnchantWeight = -3;
        break;
      case 3712528377:
        if (!(selectedItem == "Blessed"))
          break;
        this.EnchantHit = this.FAI / 2;
        break;
      case 4202495337:
        if (!(selectedItem == "Rebellion"))
          break;
        this.RarityValue = 9 - (int) this.Rarity.Value;
        this.EnchantPower = Math.Max(15 * this.RarityValue / 10, 0);
        this.EnchantHit = -2 * this.RarityValue;
        break;
    }
  }

  public void DescCheck()
  {
    switch (this.DescOpen)
    {
      case 0:
        this.WepDesc = new DescForm(this);
        this.DescOpen = 1;
        this.WepDesc.Show();
        this.WeaponUpdate();
        this.WepDesc.DescUpdate();
        break;
      case 1:
        this.WeaponUpdate();
        this.WepDesc.DescUpdate();
        break;
    }
  }

  private void WeaponEffectBtn_Click(object sender, EventArgs e) => this.DescCheck();

  public void DescFormClose() => this.DescOpen = 0;

  private void WeaponUpdate()
  {
    this.MainStat = (short) 100;
    this.Tag1 = string.Empty;
    this.Tag2 = string.Empty;
    this.Tag3 = string.Empty;
    this.ScaleSTR = (short) 0;
    this.ScaleWIL = (short) 0;
    this.ScaleSKI = (short) 0;
    this.ScaleCEL = (short) 0;
    this.ScaleDEF = (short) 0;
    this.ScaleRES = (short) 0;
    this.ScaleVIT = (short) 0;
    this.ScaleFAI = (short) 0;
    this.ScaleLUC = (short) 0;
    this.ScaleSAN = (short) 0;
    this.ScaleGUI = (short) 0;
    this.Power = (short) 0;
    this.Weight = (short) 0;
    this.Accuracy = (short) 0;
    this.Critical = (short) 0;
    this.CriticalModifier = (short) 100;
    this.RarityW = (short) 1;
    this.MaterialType = string.Empty;
    this.WeaponPart1Type = string.Empty;
    this.WeaponPart2Type = string.Empty;
    this.WeaponPart3Type = string.Empty;
    this.WeaponP1Power = (short) 0;
    this.WeaponP1Hit = (short) 0;
    this.WeaponP1Crit = (short) 0;
    this.WeaponP1Weight = (short) 0;
    this.WeaponP1CritDam = 0.0;
    this.WeaponP2Power = (short) 0;
    this.WeaponP2Hit = (short) 0;
    this.WeaponP2Crit = (short) 0;
    this.WeaponP2Weight = (short) 0;
    this.WeaponP2CritDam = 0.0;
    this.WeaponP3Power = (short) 0;
    this.WeaponP3Hit = (short) 0;
    this.WeaponP3Crit = (short) 0;
    this.WeaponP3Weight = (short) 0;
    this.WeaponP3CritDam = 0.0;
    this.WeaponDesc = "";
    this.WeaponEffect = "";
    this.WeaponPotential = "";
    this.WeaponSpecialStrike = "";
    switch ((string) this.WeaponBox.SelectedItem)
    {
      case "Abberation Spear":
        this.ScaleSTR = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 85;
        this.Critical = (short) 12;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Adversity Annihilator":
        this.ScaleSTR = this.WeaponTag("Basic", "Sylphid", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Akujin":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Amethyst-Head/Morganite Staff":
        this.ScaleWIL = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Ampeol":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Ampgeneoule":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Lightning", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Amplifyia":
        this.ScaleWIL = this.WeaponTag("Basic", "Electrical", "Dextria-Lightning", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Anchor Edge":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 18;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 22;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Aquamarine-Head Staff":
        this.ScaleWIL = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Aquaphobia":
        this.ScaleWIL = this.WeaponTag("Basic", "Aquatic", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Arcane Fists":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 0;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "None";
        this.WeaponPart1Type = "None";
        this.WeaponPart2Type = "None";
        this.WeaponPart3Type = "None";
        break;
      case "Artemis Replica":
        this.ScaleSTR = this.WeaponTag("Basic", "Replica", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Atlua's Abaniko":
        this.ScaleGUI = this.WeaponTag("Finesse", "Dextria-Water", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 7;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Autopistol":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Axe":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Baihurai":
        this.ScaleWIL = this.WeaponTag("Basic", "Electrical", "Earthen", (short) 0);
        this.Power = (short) 2;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Bakaga Shuriken":
        this.ScaleGUI = this.WeaponTag("Darkness", "Tool", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Balrog":
        this.ScaleWIL = this.WeaponTag("Finesse", "Flamelit", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 15;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Bamboo-Bo":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Pole";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Bandit Sword":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 14;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Baphomet's Offering":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 15;
        this.Weight = (short) 20;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Bare Fists":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 0;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "None";
        this.WeaponPart1Type = "None";
        this.WeaponPart2Type = "None";
        this.WeaponPart3Type = "None";
        break;
      case "Battleaxe":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 135;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Battlepick":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 18;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Bear Claws":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Bell of No Rest":
        this.ScaleGUI = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Betrayer's Wit":
        this.ScaleGUI = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 14;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Black Spear":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Black Xyston":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Black Zepia":
        this.ScaleGUI = this.WeaponTag("Firearms", "Vampiric", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Blackmeteor":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Earth", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Blackmount":
        this.ScaleWIL = this.WeaponTag("Basic", "Earthen", "Dextria-Earth", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Blacksand":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Blaster Trumpet":
        this.ScaleGUI = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Blind Bright":
        this.ScaleSTR = this.WeaponTag("Finesse", "Faithful", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 15;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Bloodstained Flute":
        this.ScaleGUI = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 4;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Bloody-Fang":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Bow":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Bow of the Green Forest":
        this.ScaleSTR = this.WeaponTag("Basic", "Cunning", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Boxing Gloves":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 2;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Braver Replica":
        this.ScaleSTR = this.WeaponTag("Replica", "", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Brawler's Glove":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 2;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Burngada":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Burst Claw":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Buzzing Chakram":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Byakko Tessen":
        this.ScaleGUI = this.WeaponTag("Finesse", "Dextria-Lightning", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Carteblanche":
        this.ScaleWIL = this.WeaponTag("Basic", "Cold", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Cerron Scepter":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Chorus":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Chorusaf":
        this.ScaleWIL = this.WeaponTag("Basic", "Faithful", "Dextria-Light", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Chorusafhybyn":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Light", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Citizen Slaughterer":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Claw Gauntlet":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Cleaving Clarinet":
        this.ScaleSTR = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Coastal Squall":
        this.ScaleWIL = this.WeaponTag("Basic", "Cold", "Aquatic", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Cobalt Qrytys":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Combat Magnifying Glass":
        this.ScaleGUI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Copper Coliche":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Corvis Cannon":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "Darkness", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 15;
        this.Weight = (short) 14;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Cougar Claws":
        this.ScaleSTR = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponDesc = "A deadly pair of claws best used by the agile.";
        this.WeaponEffect = "This item's Power, Hit, and Critical are increased by +5 while you have any Roar-type status effect active.";
        this.WeaponPotential = $"Cougar Strike{this.nl}Targets 2 location within 1 Range. Location 1 must have an enemy, and Location 2 must be an unoccupied tile.{this.nl}You attack the target in Location 1 with your Cougar Claws, and then slide to Location 2.";
        this.WeaponSpecialStrike = $"Cougar's Roar{this.nl}Trigger Rate: 10% + 5% Bonus{this.nl}Triggers before an enemy is attacked, and replaces the attack.{this.nl}Deals 110% of Cougar Claws' Scaled Weapon Attack over 8 hits while you teleport around the target.{this.nl}If none of the 8 hits are evaded, you unleash the roar of a Cougar, gaining Cougar's Roar (Lv 10, 5 rounds) and attempt to inflict all enemies in 5 range with Hesitation (Lv 15, 2 rounds.)";
        break;
      case "Crash Cymbals":
        this.ScaleSTR = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Crazy Coyote":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Creed Replica":
        this.ScaleGUI = this.WeaponTag("Replica", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Creeping Darkness":
        this.ScaleGUI = this.WeaponTag("Darkness", "Finesse", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Crelia":
        this.ScaleGUI = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Crossbow":
        this.ScaleSKI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Crystal Blade":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Dagger":
        this.ScaleGUI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 3;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        this.WeaponEffect = "";
        this.WeaponDesc = "";
        this.WeaponPotential = $"Forbidden Technique (3M){this.nl}Inflicts you with Cursed Vengeance LV10 for 3 rounds.{this.nl}(Cursed Vengeance increases your damage by LV%, but drains your HP by LV% of your maximum HP every round.)";
        break;
      case "Dagger of Bleeding":
        this.ScaleGUI = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Daikyu":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        this.WeaponDesc = $"The daikyu is a longbow with an irregular draw, positioned below the center of the bow.{this.nl}This makes the bow well-suited for use on horseback, as the bow is less likely to caatch on the horse.{this.nl}However, the stress on the wood requires greater levels of maintanence, and its draw form is different from standard bows.{this.nl}Someone using a Daikyu without proper training will not have a functional one for long.";
        this.WeaponEffect = "When you are two-handing this weapon, it gains a +2 Farshot Bonus.";
        this.WeaponPotential = $"Daikyu Snipe{this.nl}Targets 1 unoccupied tile within 1 Range and fires a long-reaching arrow from the Daikyu, which travels up to 15 tiles away.{this.nl}The first enemy hit by the arrow is attacked by the Daikyu with no Farshot Penalty.{this.nl}If the bow is fitted with Light Arrows, this arrow cannot be reflected, dispells Darkness tiles it passes near, and gains +100 Critical against Supernatural enemies.{this.nl}If you have 40+ FAI, it also creates Sanctuary tiles (LV 1, 2 rounds).";
        break;
      case "Dancing Shiv":
        this.ScaleGUI = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 7;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Deadclaw":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 6;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Deadly Smile":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Desert Wind":
        this.ScaleWIL = this.WeaponTag("Basic", "Earthen", "Sylphid", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Devil's Tome":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 6;
        this.Weight = (short) 13;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Diamond-Head/Aerialite Staff":
        this.ScaleWIL = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Dual-Blade":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Blade";
        break;
      case "Duodent":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 5;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Acid)":
        this.ScaleWIL = this.WeaponTag("Basic", "Cunning", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Dark)":
        this.ScaleWIL = this.WeaponTag("Basic", "Darkness", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Earth)":
        this.ScaleWIL = this.WeaponTag("Basic", "Earthen", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Fire)":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Ice)":
        this.ScaleWIL = this.WeaponTag("Basic", "Cold", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Light)":
        this.ScaleWIL = this.WeaponTag("Basic", "Faithful", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Ltn.)":
        this.ScaleWIL = this.WeaponTag("Basic", "Electrical", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Sound)":
        this.ScaleWIL = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Water)":
        this.ScaleWIL = this.WeaponTag("Basic", "Aquatic", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynamic Tome (Wind)":
        this.ScaleWIL = this.WeaponTag("Basic", "Sylphid", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Dynaxis":
        this.ScaleSTR = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 11;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Electric Axe":
        this.ScaleSTR = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Elenoa":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Emerald-Head/Fortunite Staff":
        this.ScaleWIL = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Endless Handkerchief":
        this.ScaleSTR = this.WeaponTag("Spiritual", "Finesse", "Dextria-Sound", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 3;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Engraved Katana":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        this.WeaponDesc = "The katana, as the name implies, has a spell engraved in it's metal.";
        this.WeaponEffect = "Katana contains a scroll slot.";
        this.WeaponPotential = "(N/A)";
        break;
      case "Ensui":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Eresh":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Eternal Servitude":
        this.ScaleSTR = this.WeaponTag("Darkness", "Magical", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Eternal Solitude":
        this.ScaleGUI = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Evil Club":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Excel Hasta":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Excel Parashu":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 22;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Excel Saber":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 18;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Excel Sniper":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Excelgraph":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 18;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Excellion":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Fae Bow":
        this.ScaleSTR = this.WeaponTag("Basic", "Electrical", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Fangfare":
        this.ScaleGUI = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Farren":
        this.ScaleWIL = this.WeaponTag("Basic", "Sylphid", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Fellgrant Drinker":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Fenri":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Filcherbird":
        this.ScaleSTR = this.WeaponTag("Basic", "Sylphid", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 12;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Firepoker":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponDesc = "Not your average fireplace tool.";
        this.WeaponEffect = "On Hit: Deals magic Fire bonus damage equal to 50% of your Fire ATK, which ignores armor.";
        this.WeaponPotential = "(N/A)";
        this.WeaponSpecialStrike = $"Coal Brand{this.nl}Trigger Rate: 10% + 5% Bonus{this.nl}2 Round Cooldown{this.nl}Triggers before an enemy is attacked.{this.nl}Inflicts the target with Elemental Pierce (Fire) (2 Rounds), if it hits, all other enemies in 5 range of the target take Firepoker's On Hit Effects.";
        break;
      case "Firthrower":
        this.ScaleGUI = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 15;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Flambella":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "Dextria-Fire", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Flamberg":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Flamnyaghra":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Fire", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Forgrint":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Fortune's Favor":
        this.ScaleSTR = this.WeaponTag("Dextria-Lightning", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Fullgust":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Fullphoon":
        this.ScaleWIL = this.WeaponTag("Basic", "Sylphid", "Dextria-Wind", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Fullurricane":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Wind", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Fuuma":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Gae Baed":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Gae Bolg Replica":
        this.ScaleSTR = this.WeaponTag("Replica", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Gel'Naia":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Ghost Smoke":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Giant Slayer":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Binds";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Bullets";
        this.WeaponDesc = "A sling, made to be swung and fire rocks at enemies. The biggest ones are the easiest to hit.";
        this.WeaponEffect = $"Basic Attacks with this weapon deal 15% more damage if the target is a Giant, Enlarged, or has the Mountain skill.{this.nl}Also applies to enemies with a Gigantic torso enchantment at half effectiveness.{this.nl}On Defeat Enemy: If enemy was a Giant, Enlarged, had the Mountain skill, or a Gigantic torso enchantment, and this weapon defeated them,{this.nl}all other enemies in the battle of those same categories suffer -5 to all stats (except VIT) for 5 rounds.";
        this.WeaponPotential = "N/A";
        break;
      case "Gigantys":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Golgorth":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Gorger":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Graality":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 20;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Grand Axe":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Grand Smasher":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Grandia":
        this.ScaleSTR = this.WeaponTag("Basic", "Finesse", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Grandovyn":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Greatspear":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Grudge Claws":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 6;
        this.Weight = (short) 0;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "None";
        this.WeaponPart1Type = "None";
        this.WeaponPart2Type = "None";
        this.WeaponPart3Type = "None";
        break;
      case "Gryphon Wing":
        this.ScaleSTR = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Guiding Shot":
        this.ScaleSTR = this.WeaponTag("Basic", "Finesse", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Guillotine":
        this.ScaleSTR = this.WeaponTag("Basic", "Metal", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Gunbai":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 18;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Remains";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponDesc = "A solid metal fan. Commonly used for directing troops in battle, it also can act as a shield from projectile weapons, or just smash people who get too close.";
        this.WeaponEffect = $"+5 Wind ATK.{this.nl}On Hit: Deals magic Wind bonus damage equal to 50% of your Wind ATK, which ignores armor.";
        this.WeaponPotential = $"Gunbai Defense Arts{this.nl}Use the Gunbai as a shield, increasing your Armor & Magic Armor by its Power against attacks from ranged weapons.{this.nl}This skill is only effective if the attacker is in your line of sight, and is half effective while you are Blind.";
        this.WeaponSpecialStrike = $"Wind Current Reverse{this.nl}Trigger Rate: 10% + 5% Bonus{this.nl}3 Round Cooldown{this.nl}Triggers after the attack hits an enemy.{this.nl}Deals 35 Wind armor-ignoring magic bonus damage to the target and all enemies in 3 range around them.{this.nl}You gain Reflect Wind (Limited) (Lv 1, 2 rounds).{this.nl}If Gunbai is enchanted with Feather, the attack target is also inflicted with Damage Change (Wind) (Lv 1, Until Next Turn)";
        break;
      case "Hakouhen Katana":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 8;
        this.Weight = (short) 6;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Handgun":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 3;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Hands of the Giant":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 22;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Hankyu":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        this.WeaponDesc = $"The hankyu is a more compact version of the daikyu bow, with an irregular, uneven draw slightly below the center of the bow.{this.nl}While it's power at long distances is less impressive than its sister bow, its smaller body allows it to be used for low profile shooting, such as when ducking.";
        this.WeaponEffect = "When you are two-handing this weapon, it gains a +10 Power and +10 Critical against enemies within 2 Range.";
        this.WeaponPotential = $"Hankyu Posture{this.nl}Take a swift knee and gain Firing Posture (until your next turn).{this.nl}Gain +10 Evade and Critical Evade while in Firing Posture.{this.nl}If the Hankyu is fitted with Light Arrows, attacks while in Firing Posture deal 75% of your Light ATK as armor-ignoring bonus magic damage (doubled against Supernatural enemies.{this.nl}If you have 40+ FAI, attacking a field object while in Firing Posture applies this bonus damage to all enemies in 3 Range of it.";
        break;
      case "Harp Bow":
        this.ScaleSTR = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Hell Sniper":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 84;
        this.Critical = (short) 4;
        this.Weight = (short) 13;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        this.WeaponDesc = "The bow glowers with a fatal curse, and its arows are painfully accurate, even when fired from hell.";
        this.WeaponEffect = $"Marked Target damage bonuses increases by 8% when triggered by this weapon.{this.nl}On New Round: If this weapon is Cursed or Doomed, lose 15 HP (non-fatal) and a random enemy becomes one of your Marked Targets (LV 15).";
        this.WeaponPotential = "(N/A)";
        break;
      case "Helrenroka":
        this.ScaleGUI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Hexfang":
        this.ScaleGUI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Hidden Barrage":
        this.ScaleGUI = this.WeaponTag("Firearms", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 0;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "None";
        this.WeaponPart1Type = "None";
        this.WeaponPart2Type = "None";
        this.WeaponPart3Type = "None";
        this.EnchantBox.Text = "N/A";
        break;
      case "Hidden Blade":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 0;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "N/A";
        this.WeaponPart1Type = "N/A";
        this.WeaponPart2Type = "N/A";
        this.WeaponPart3Type = "N/A";
        break;
      case "Highway Axe":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Hikage":
        this.ScaleGUI = this.WeaponTag("Flamelit", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Hisen":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 3;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Hold Upper":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Holy Lance":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 7;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Holy Word":
        this.ScaleFAI = this.WeaponTag("Flamelit", "", "", (short) 0);
        this.Power = (short) 30;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 30;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Grip";
        this.WeaponPart2Type = "Scroll";
        this.WeaponPart3Type = "Bullets";
        this.WeaponDesc = "A massive launcher equipped with a heavy sharpened spike, it holds within it some sort of scripture.";
        this.WeaponEffect = $"When equipped, you cannot use movements skills, except basic skills, Mercalan domain spells, or skills with the 'Holy' tag.{this.nl}Grants Skill: Crusader Charge.Grants Skill: Divine Bunker.";
        this.WeaponPotential = "(N/A)";
        break;
      case "Homura":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Hooked Twinblade":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Howling Handshot":
        this.ScaleSTR = this.WeaponTag("Precision", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 25;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Hundred-Reflection Spear":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Hunting Bow":
        this.ScaleSTR = this.WeaponTag("Basic", "Finesse", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Hymn":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Hymnta":
        this.ScaleWIL = this.WeaponTag("Basic", "Darkness", "Dextria-Dark", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Hymntaturych":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Dark", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Icebreaker":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Impaler":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Jackhammer":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 22;
        this.Accuracy = (short) 60;
        this.Critical = (short) 0;
        this.Weight = (short) 20;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Jade Insect Whistle":
        this.ScaleWIL = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 7;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Javelin":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 7;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Kamiya":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        this.WeaponDesc = $"A wooden sword known as a 'bokken'. While it is often used for training purposes, there are some who practice non-lethal swordsmanship.{this.nl}In their hands, even a branch is a weapon..";
        this.WeaponEffect = $"Grants Skill: Kamiya Guard{this.nl}Show Mercy's success rate increases by 15%. (Percentage of actual success rate; not additive.){this.nl}Weapon suffers no penalties to damage, hit, or critical for being broken.";
        this.WeaponPotential = "(N/A)";
        break;
      case "Kanabo":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 17;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "N/A";
        this.WeaponDesc = "A large club with circular metal protusions. A rather brutal and heavy weapon, it is often associated with 'oni' or giants.";
        this.WeaponEffect = "Critical chance increased by the Wear Down LV on the attack target.";
        this.WeaponPotential = "(Exists but not logged yet.)";
        break;
      case "Kigal Replica":
        this.ScaleWIL = this.WeaponTag("Basic", "Replica", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 20;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Kingslayer":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Kirosh":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Knight Slayer":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Knightslayer":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Knuckledusters":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 2;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Konosekai":
        this.ScaleGUI = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 1;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Kouenjin":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Kraken's Sigh":
        this.ScaleSTR = this.WeaponTag("Basic", "Cold", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 95;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Kusarigami":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 14;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Blade";
        break;
      case "Labrys":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 18;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Lare Grystale":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 19;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Larveget":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        this.WeaponDesc = "Your standard, boring longsword.";
        this.WeaponEffect = "N/A";
        this.WeaponPotential = "N/A";
        break;
      case "Longbow":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Longsword":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        this.WeaponDesc = "Your standard, boring longsword.";
        this.WeaponEffect = "N/A";
        this.WeaponPotential = "N/A";
        break;
      case "Lorelei":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Lute":
        this.ScaleGUI = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Magical Comet":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Magical Meteor":
        this.ScaleSTR = this.WeaponTag("Basic", "Magical", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Magical Moon":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Magical Nova":
        this.ScaleGUI = this.WeaponTag("Basic", "Magical", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Magical Photon":
        this.ScaleGUI = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Magical Star":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Magical Sun":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Maned Tonfa":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Manic Slasher":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 14;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Monk Priest's Staff":
        this.ScaleSTR = this.WeaponTag("Faithful", "Dextria-Light", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Monster Spine":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 22;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Axehead";
        break;
      case "Moonblade":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Moonlight Mercy":
        this.ScaleGUI = this.WeaponTag("Basic", "Faithful", "", (short) 0);
        this.Power = (short) 17;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 20;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Morimayer":
        this.ScaleWIL = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 16 /*0x10*/;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponDesc = "A summoning scroll holding a small host of minor spirits. Its power is unpredictable, yet formidable.";
        this.WeaponEffect = $"This weapon's attack skill uses one of the 4 random spirits; each will provide a different bonus and damage type for the attack.{this.nl}If the attack hits, you also gain a status effect based on the animal, which increases either your Scaled Weapon Attack, Hit, Critical, or Armor by a small amount, and provides a single-use cast a random spell{this.nl}(from a small selection, based on the animal, excluding spells you have equipped).";
        this.WeaponPotential = "(N/A)";
        break;
      case "Mortissimo":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 13;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Mugendai":
        this.ScaleWIL = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Mythslayer":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Narcus":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Needler":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Nelten":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Nighthunt":
        this.ScaleSTR = this.WeaponTag("Basic", "Darkness", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Ninja Scroll":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "N/A";
        this.WeaponDesc = $"Concealed within the wrist of these otherwise unassuming gloves is a scroll.{this.nl}Often used by shinobi as a means to transport and use hidden arts.";
        this.WeaponEffect = "N/A";
        this.WeaponPotential = "N/A";
        break;
      case "Ninshi Shuriken":
        this.ScaleGUI = this.WeaponTag("Flamelit", "Tool", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Nirvana Replica":
        this.ScaleSTR = this.WeaponTag("Replica", "", "", (short) 0);
        this.Power = (short) 19;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 20;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Noble Axe":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 18;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Nullifying Dirk":
        this.ScaleGUI = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Onyx-Head/Tetraite Staff":
        this.ScaleWIL = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Overgrown Staff":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 95;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Paragi Shuriken":
        this.ScaleGUI = this.WeaponTag("Electrical", "Tool", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Parrying Dagger":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Pickpocketers":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 8;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Pilfer Spear":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Pillawag":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 22;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Pinchers":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 9;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Puppet Strings":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Remains";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "String";
        this.WeaponDesc = "Gloves holding within them long puppet strings. One never knows when they may be forced to dance upon them.";
        this.WeaponEffect = $"+1 Attack Range if weapon is made of Thinsteel.{this.nl}On Hit: Apply or power up String Attached (LV 1, max 4, 3 rounds). Only 1 string can attached per action (even if you have multiple Puppet Strings equipped, or attack with it multiple times).{this.nl}Grants Skill: Puppet Assault";
        this.WeaponPotential = "(N/A)";
        break;
      case "Qinglongram":
        this.ScaleWIL = this.WeaponTag("Basic", "Electrical", "Sylphid", (short) 0);
        this.Power = (short) 2;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Quarterstaff":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Quickdraw":
        this.ScaleGUI = this.WeaponTag("Basic", "Sylphid", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Raijin":
        this.ScaleSTR = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Ramarg":
        this.ScaleSTR = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Rapier of Resent":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 6;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Razing Salamander":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Red Argus":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Red Letter":
        this.ScaleGUI = this.WeaponTag("Flamelit", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Redwing":
        this.ScaleSTR = this.WeaponTag("Basic", "Vampiric", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Revolver Raid Cannon":
        this.ScaleGUI = this.WeaponTag("Firearms", "", "", (short) 0);
        this.Power = (short) 20;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 0;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "None";
        this.WeaponPart1Type = "None";
        this.WeaponPart2Type = "None";
        this.WeaponPart3Type = "None";
        this.EnchantBox.Text = "Rampaging";
        break;
      case "Rexys":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "River Sword":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Roaring Rose":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Rogue Dasher":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Rose Whip":
        this.ScaleWIL = this.WeaponTag("Basic", "Finesse", "Electrical", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 7;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Ruby-Head/Requinite Staff":
        this.ScaleWIL = this.WeaponTag("Flamelit", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Ryeser":
        this.ScaleGUI = this.WeaponTag("Basic", "Tool", "Electrical", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 3;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Sakabatou":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        this.WeaponDesc = $"A reverse-blade sword, meaning the side where the edge normally would be is dull, and vice versa.{this.nl}It is somewhat less lethal with a dull edge, and can be flipped should you need to cut, but it requires a skilled hand to avoid hurting yourself.";
        this.WeaponEffect = $"Grants Skill: Flip Blade{this.nl}Cooldown: 1 Round(s){this.nl}Turn your Sakabatou around, changing which side you're using. Grants or removes Flipped Blade (permanent duration).{this.nl}{this.nl}Flipped Blade - Your Sakabatou weapons deal Slash damage.";
        this.WeaponPotential = $"Killing is A Choice{this.nl}Sakabatou gains + 5 Critical while it deals Slash damage, and you gain + 5 Armor & Magic Armor while it deals Blunt damage.{this.nl}When you flip the Sakabatou to Slash damage, enemies within its attack range are inflicted with your Sakki(if the skill is equipped) and Slash Resist Down(LV 10, 1 round, 1 hit). 2 round CD if an enemy is affected.";
        this.WeaponSpecialStrike = $"Nine Heads{this.nl}Trigger Rate: 10% + 8% Bonus{this.nl}2 Round CooldownTriggers before an enemy is attacked, and replaces the attack.{this.nl}An ultra fast strike hitting from 9 directions at once, dealing 125% Scaled Weapon Attack, and rendering it unavoidable and unparriable which can critically hit but deals no extra damage for it.";
        break;
      case "Salamander Sword":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Sanjin":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Sapphire-Head/Cariaite Staff":
        this.ScaleWIL = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sasumata":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) -5;
        this.Weight = (short) 6;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Ore";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponDesc = $"A polearm with a dull crescent edge and a row of spikes near it.{this.nl}It is frequently used by guards in certain cultures as a means to restrain the aggressive, such as animals or criminals, or to keep them away.";
        this.WeaponEffect = $"Sasumata: Once per round (per enemy), after an enemy uses an action that moves them into the tile you are facing;{this.nl}if your STR is greater than their Battle Weight (ignoring reductions; monsters use their level instead), you push them back 1 tile and inflict them with Clumsy (1 round).{this.nl}Otherwise you inflict them with Impaired Attack (LV 5, until your next turn, effect ends when the enemy is no longer close to you).";
        this.WeaponPotential = $"Subdue & Restrain{this.nl}Sasumata's Potential Skill. Targets an enemy in 1 Range and applies an effect. If the target is Knocked Down, you pin them with the Sasumata, inflicting Grappled (2 rounds) and Impaired Attack (LV 10, 2 rounds).{this.nl}If not, if you are behind the target, you strike their knees and inflict them with Knocked Down.{this.nl}If none of the other effects activate, you knock them back 2 tiles and recover 2M.";
        break;
      case "Screaming Tome":
        this.ScaleWIL = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Sea Hunter Axe":
        this.ScaleSTR = this.WeaponTag("Magical", "Metal", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 75;
        this.Critical = (short) 7;
        this.Weight = (short) 14;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sea Hunter Bow":
        this.ScaleSTR = this.WeaponTag("Basic", "Aquatic", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 7;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Sea Hunter Dagger":
        this.ScaleGUI = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 75;
        this.Critical = (short) 7;
        this.Weight = (short) 8;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Sea Hunter Gauntlet":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 7;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Sea Hunter Gun":
        this.ScaleGUI = this.WeaponTag("Basic", "Aquatic", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 7;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Sea Hunter Spear":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 12;
        this.Accuracy = (short) 85;
        this.Critical = (short) 7;
        this.Weight = (short) 11;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sea Hunter Sword":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 7;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Sea Hunter Tome":
        this.ScaleWIL = this.WeaponTag("Basic", "Aquatic", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 7;
        this.Weight = (short) 12;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Seed Sniper":
        this.ScaleGUI = this.WeaponTag("Basic", "Earthen", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Seiryuu Tessen":
        this.ScaleGUI = this.WeaponTag("Finesse", "Dextria-Wind", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Setsuna":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Shadow Wind Claw":
        this.ScaleSTR = this.WeaponTag("Dextria-Dark", "Dextria-Wind", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 5;
        this.Weight = (short) 5;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Sheer Cold":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 10;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Shine Sword":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Shizumare":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Shotgun":
        this.ScaleGUI = this.WeaponTag("Basic", "Firearms", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Shotgun Tonfa":
        this.ScaleGUI = this.WeaponTag("Flamelit", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        this.WeaponDesc = "A pair of tonfa which have been hollowed out to make a room for a crude shotgun barrel on each. Discharging them requires swinging the tonfa, but that's not much of a problem.";
        this.WeaponEffect = $"Also qualifies as a Fist weapon.{this.nl}Also qualifies as a Shotgun weapon{this.nl}After performing an attack with this weapon, gain Tonfa Afterblast (LV1, 1 round), which allows you to use the skill of the same name.{this.nl}Tonfa Block - Increases the LV of Guard statuses applied to you by 5 if you are two-handing this weapon.";
        this.WeaponPotential = $"Tonfa Parry{this.nl}Parry skill. Grants a chance to parry non-spell, non-ranged weapon damage for 25% reduction.{this.nl}Activate Rate: 15% + 50% of Scaled DEF, +10% if the owner of this skill has the Roar status active.";
        break;
      case "Shredder Replica":
        this.ScaleSTR = this.WeaponTag("Replica", "", "", (short) 0);
        this.Power = (short) 16 /*0x10*/;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Shuriken":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 3;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Siphon":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Skullcaver":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 17;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 15;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sky Mantis Scythe":
        this.ScaleSTR = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 90;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sleigher":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 9;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Sogensara":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Soulshot":
        this.ScaleSTR = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Soulstealer":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Spear":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Spectre Sword":
        this.ScaleSTR = this.WeaponTag("Darkness", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Spine Leash":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 14;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Spirit Axe":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Spirit Bow":
        this.ScaleSTR = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Spirit Gauntlet":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Spirit Hunter":
        this.ScaleGUI = this.WeaponTag("Basic", "Spiritual", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Spirit Sword":
        this.ScaleSTR = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Staff of Eyes":
        this.ScaleSTR = this.WeaponTag("Tool", "Darkness", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Star Shooter":
        this.ScaleSTR = this.WeaponTag("Basic", "Faithful", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Sthenno":
        this.ScaleWIL = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 11;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Stinger":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 4;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 145;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Stone Vector":
        this.ScaleWIL = this.WeaponTag("Earthen", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Summoner's Tandem Dagger":
        this.ScaleGUI = this.WeaponTag("Spiritual", "", "", (short) 0);
        this.Power = (short) 7;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 8;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Suzaku Tessen":
        this.ScaleGUI = this.WeaponTag("Finesse", "Dextria-Fire", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Sweeper":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 22;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Swordfish Sword":
        this.ScaleSTR = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Tamaki Shuriken":
        this.ScaleGUI = this.WeaponTag("Tool", "Cunning", "", (short) 40);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Tanto":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        this.WeaponEffect = "Subtype: Katana";
        this.WeaponDesc = "A small blade with a sharp edge, the tanto is often used for personal protection or as a backup weapon when longer blades aren't available or are impractical.";
        this.WeaponPotential = "N/A";
        break;
      case "Tarnada":
        this.ScaleSTR = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 15;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 10;
        this.Weight = (short) 10;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Tarnell":
        this.ScaleGUI = this.WeaponTag("Basic", "Flamelit", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Tenderizers":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 4;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "The Kiss Farewell":
        this.ScaleGUI = this.WeaponTag("Firearms", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 120;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Thief Blade":
        this.ScaleGUI = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 4;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Thorn Shooter":
        this.ScaleSTR = this.WeaponTag("Basic", "Earthen", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Throwing Dagger":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Thunder Shot":
        this.ScaleSTR = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Body";
        this.WeaponPart2Type = "String";
        this.WeaponPart3Type = "Arrows";
        break;
      case "Topaz-Head/Fulgurite Staff":
        this.ScaleWIL = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Torment Noctis":
        this.ScaleWIL = this.WeaponTag("Basic", "Darkness", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 70;
        this.Critical = (short) 0;
        this.Weight = (short) 3;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Touyaa Shuriken":
        this.ScaleGUI = this.WeaponTag("Cold", "Tool", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Toyatori":
        this.ScaleGUI = this.WeaponTag("Basic", "Cold", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 12;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Tsukikage":
        this.ScaleGUI = this.WeaponTag("Aquatic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 75;
        this.Critical = (short) 5;
        this.Weight = (short) 4;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Tuning Fork":
        this.ScaleSTR = this.WeaponTag("Dextria-Sound", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 5;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Vampire Bat":
        this.ScaleSTR = this.WeaponTag("Vampiric", "", "", (short) 0);
        this.Power = (short) 14;
        this.Accuracy = (short) 75;
        this.Critical = (short) -5;
        this.Weight = (short) 15;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Violet Varon":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Voidcut":
        this.ScaleSTR = this.WeaponTag("Magical", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 4;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Vorpal Fang":
        this.ScaleGUI = this.WeaponTag("Electrical", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 75;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Vorso Verso":
        this.ScaleWIL = this.WeaponTag("Basic", "Spiritual", "Dextria-Sound", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 5;
        this.Weight = (short) 22;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Warstaff":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Well":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Wellweg":
        this.ScaleWIL = this.WeaponTag("Basic", "Aquatic", "Dextria-Water", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Wellwegwet":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Water", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Whip":
        this.ScaleGUI = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 4;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 5;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 130;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "String";
        this.WeaponPart2Type = "Hilt";
        this.WeaponPart3Type = "Pole";
        break;
      case "Whulf":
        this.ScaleSTR = this.WeaponTag("Faithful", "", "", (short) 0);
        this.Power = (short) 10;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Winged Spear":
        this.ScaleSTR = this.WeaponTag("Sylphid", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 11;
        this.RarityW = (short) 10;
        this.CriticalModifier = (short) 115;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Spearhead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Wo-Dao":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 6;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 5;
        this.RarityW = (short) 2;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Wooden Katana":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Wooden Longsword":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Wooden Nelten":
        this.ScaleSTR = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 11;
        this.Accuracy = (short) 80 /*0x50*/;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Wood";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Wrench":
        this.ScaleSTR = this.WeaponTag("Cunning", "", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 75;
        this.Critical = (short) 0;
        this.Weight = (short) 8;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 125;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Axehead";
        this.WeaponPart2Type = "Pole";
        this.WeaponPart3Type = "None";
        break;
      case "Xuanwuken":
        this.ScaleWIL = this.WeaponTag("Basic", "Cold", "Earthen", (short) 0);
        this.Power = (short) 2;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Yang":
        this.ScaleGUI = this.WeaponTag("Basic", "Faithful", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Yin":
        this.ScaleGUI = this.WeaponTag("Basic", "Darkness", "", (short) 0);
        this.Power = (short) 8;
        this.Accuracy = (short) 85;
        this.Critical = (short) 10;
        this.Weight = (short) 8;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Barrel";
        this.WeaponPart2Type = "Grip";
        this.WeaponPart3Type = "Bullets";
        break;
      case "Ymir":
        this.ScaleSTR = this.WeaponTag("Cold", "", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 15;
        this.RarityW = (short) 9;
        this.CriticalModifier = (short) 105;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Knuckles";
        this.WeaponPart2Type = "Wrist";
        this.WeaponPart3Type = "None";
        break;
      case "Yukijin":
        this.ScaleSTR = this.WeaponTag("Finesse", "", "", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 10;
        this.RarityW = (short) 7;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Metal";
        this.WeaponPart1Type = "Blade";
        this.WeaponPart2Type = "Guard";
        this.WeaponPart3Type = "Hilt";
        break;
      case "Zeroraid":
        this.ScaleWIL = this.WeaponTag("Basic", "", "", (short) 0);
        this.Power = (short) 5;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 12;
        this.RarityW = (short) 1;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Zerorewuin":
        this.ScaleWIL = this.WeaponTag("Basic", "Dextria-Ice", "", (short) 0);
        this.Power = (short) 13;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 14;
        this.RarityW = (short) 6;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Zerotrain":
        this.ScaleWIL = this.WeaponTag("Basic", "Cold", "Dextria-Ice", (short) 0);
        this.Power = (short) 9;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 13;
        this.RarityW = (short) 3;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      case "Zhuquelare":
        this.ScaleWIL = this.WeaponTag("Basic", "Flamelit", "Sylphid", (short) 0);
        this.Power = (short) 2;
        this.Accuracy = (short) 85;
        this.Critical = (short) 0;
        this.Weight = (short) 6;
        this.RarityW = (short) 8;
        this.CriticalModifier = (short) 110;
        this.MaterialType = "Paper";
        this.WeaponPart1Type = "Cover";
        this.WeaponPart2Type = "Binds";
        this.WeaponPart3Type = "None";
        break;
      default:
        this.Power = (short) 0;
        this.Weight = (short) 0;
        this.Accuracy = (short) 0;
        this.Critical = (short) 0;
        this.CriticalModifier = (short) 100;
        this.RarityW = (short) 1;
        break;
    }
    if (this.TagVisibleCheck.Checked)
    {
      this.Tag1Label.Visible = true;
      this.Tag2Label.Visible = true;
      this.Tag3Label.Visible = true;
    }
    this.StrengthBox.Value = (Decimal) this.ScaleSTR;
    this.WillBox.Value = (Decimal) this.ScaleWIL;
    this.SkillBox.Value = (Decimal) this.ScaleSKI;
    this.CelerityBox.Value = (Decimal) this.ScaleCEL;
    this.DefenseBox.Value = (Decimal) this.ScaleDEF;
    this.ResistanceBox.Value = (Decimal) this.ScaleRES;
    this.VitalityBox.Value = (Decimal) this.ScaleVIT;
    this.FaithBox.Value = (Decimal) this.ScaleFAI;
    this.LuckBox.Value = (Decimal) this.ScaleLUC;
    this.SanctityBox.Value = (Decimal) this.ScaleSAN;
    this.GuileBox.Value = (Decimal) this.ScaleGUI;
    this.PowerBox.Value = (Decimal) this.Power;
    this.AccuracyBox.Value = (Decimal) this.Accuracy;
    this.CriticalBox.Value = (Decimal) this.Critical;
    this.CritModBox.Value = (Decimal) this.CriticalModifier;
    this.WeightBox.Value = (Decimal) this.Weight;
    this.Rarity.Value = (Decimal) this.RarityW;
    this.WeaponChoice = (string) this.WeaponBox.SelectedItem;
    if (this.LockWPNE.Checked)
      return;
    this.MaterialBox.Text = this.MaterialType + string.Empty;
    this.WeaponPart1Box.Text = this.WeaponPart1Type + string.Empty;
    this.WeaponPart2Box.Text = this.WeaponPart2Type + string.Empty;
    this.WeaponPart3Box.Text = this.WeaponPart3Type + string.Empty;
    this.MaterialPower = (short) 0;
    this.MaterialHit = (short) 0;
    this.MaterialCrit = (short) 0;
    this.MaterialWeight = (short) 0;
  }

  private short WeaponTag(string Tag1, string Tag2, string Tag3, short Bonus)
  {
    switch (Tag1)
    {
      case "Aquatic":
        this.MainStat -= (short) 30;
        this.ScaleVIT += (short) 40;
        break;
      case "Cold":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 40;
        break;
      case "Cunning":
        this.MainStat -= (short) 30;
        this.ScaleGUI += (short) 40;
        break;
      case "Darkness":
        this.MainStat -= (short) 30;
        this.ScaleRES += (short) 40;
        break;
      case "Dextria-Acid":
        this.MainStat -= (short) 20;
        this.ScaleGUI += (short) 30;
        break;
      case "Dextria-Dark":
        this.MainStat -= (short) 20;
        this.ScaleRES += (short) 30;
        break;
      case "Dextria-Earth":
        this.MainStat -= (short) 20;
        this.ScaleDEF += (short) 30;
        break;
      case "Dextria-Fire":
        this.MainStat -= (short) 20;
        this.ScaleSTR += (short) 30;
        break;
      case "Dextria-Ice":
        this.MainStat -= (short) 20;
        this.ScaleSKI += (short) 30;
        break;
      case "Dextria-Light":
        this.MainStat -= (short) 20;
        this.ScaleFAI += (short) 30;
        break;
      case "Dextria-Lightning":
        this.MainStat -= (short) 20;
        this.ScaleLUC += (short) 30;
        break;
      case "Dextria-Sound":
        this.MainStat -= (short) 20;
        this.ScaleSAN += (short) 30;
        break;
      case "Dextria-Water":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
      case "Dextria-Wind":
        this.MainStat -= (short) 20;
        this.ScaleCEL += (short) 30;
        break;
      case "Earthen":
        this.MainStat -= (short) 30;
        this.ScaleDEF += (short) 40;
        break;
      case "Electrical":
        this.MainStat -= (short) 30;
        this.ScaleLUC += (short) 40;
        break;
      case "Faithful":
        this.MainStat -= (short) 30;
        this.ScaleFAI += (short) 40;
        break;
      case "Finesse":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 30;
        break;
      case "Firearms":
        this.MainStat -= (short) 40;
        this.ScaleSKI += (short) 40;
        break;
      case "Flamelit":
        this.MainStat -= (short) 30;
        this.ScaleSTR += (short) 40;
        break;
      case "Magical":
        this.MainStat -= (short) 30;
        this.ScaleWIL += (short) 40;
        break;
      case "Precision":
        this.MainStat -= (short) 70;
        this.ScaleSKI += (short) 70;
        break;
      case "Replica":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 20;
        this.ScaleSAN += (short) 20;
        break;
      case "Spiritual":
        this.MainStat -= (short) 30;
        this.ScaleSAN += (short) 40;
        break;
      case "Sylphid":
        this.MainStat -= (short) 30;
        this.ScaleCEL += (short) 40;
        break;
      case "Tool":
        this.MainStat -= (short) 30;
        break;
      case "Vampiric":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
    }
    switch (Tag2)
    {
      case "Aquatic":
        this.MainStat -= (short) 30;
        this.ScaleVIT += (short) 40;
        break;
      case "Cold":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 40;
        break;
      case "Cunning":
        this.MainStat -= (short) 30;
        this.ScaleGUI += (short) 40;
        break;
      case "Darkness":
        this.MainStat -= (short) 30;
        this.ScaleRES += (short) 40;
        break;
      case "Dextria-Acid":
        this.MainStat -= (short) 20;
        this.ScaleGUI += (short) 30;
        break;
      case "Dextria-Dark":
        this.MainStat -= (short) 20;
        this.ScaleRES += (short) 30;
        break;
      case "Dextria-Earth":
        this.MainStat -= (short) 20;
        this.ScaleDEF += (short) 30;
        break;
      case "Dextria-Fire":
        this.MainStat -= (short) 20;
        this.ScaleSTR += (short) 30;
        break;
      case "Dextria-Ice":
        this.MainStat -= (short) 20;
        this.ScaleSKI += (short) 30;
        break;
      case "Dextria-Light":
        this.MainStat -= (short) 20;
        this.ScaleFAI += (short) 30;
        break;
      case "Dextria-Lightning":
        this.MainStat -= (short) 20;
        this.ScaleLUC += (short) 30;
        break;
      case "Dextria-Sound":
        this.MainStat -= (short) 20;
        this.ScaleSAN += (short) 30;
        break;
      case "Dextria-Water":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
      case "Dextria-Wind":
        this.MainStat -= (short) 20;
        this.ScaleCEL += (short) 30;
        break;
      case "Earthen":
        this.MainStat -= (short) 30;
        this.ScaleDEF += (short) 40;
        break;
      case "Electrical":
        this.MainStat -= (short) 30;
        this.ScaleLUC += (short) 40;
        break;
      case "Faithful":
        this.MainStat -= (short) 30;
        this.ScaleFAI += (short) 40;
        break;
      case "Finesse":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 30;
        break;
      case "Firearms":
        this.MainStat -= (short) 40;
        this.ScaleSKI += (short) 40;
        break;
      case "Flamelit":
        this.MainStat -= (short) 30;
        this.ScaleSTR += (short) 40;
        break;
      case "Magical":
        this.MainStat -= (short) 30;
        this.ScaleWIL += (short) 40;
        break;
      case "Precision":
        this.MainStat -= (short) 70;
        this.ScaleSKI += (short) 70;
        break;
      case "Replica":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 20;
        this.ScaleSAN += (short) 20;
        break;
      case "Spiritual":
        this.MainStat -= (short) 30;
        this.ScaleSAN += (short) 40;
        break;
      case "Sylphid":
        this.MainStat -= (short) 30;
        this.ScaleCEL += (short) 40;
        break;
      case "Tool":
        this.MainStat -= (short) 30;
        break;
      case "Vampiric":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
    }
    switch (Tag3)
    {
      case "Aquatic":
        this.MainStat -= (short) 30;
        this.ScaleVIT += (short) 40;
        break;
      case "Cold":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 40;
        break;
      case "Cunning":
        this.MainStat -= (short) 30;
        this.ScaleGUI += (short) 40;
        break;
      case "Darkness":
        this.MainStat -= (short) 30;
        this.ScaleRES += (short) 40;
        break;
      case "Dextria-Acid":
        this.MainStat -= (short) 20;
        this.ScaleGUI += (short) 30;
        break;
      case "Dextria-Dark":
        this.MainStat -= (short) 20;
        this.ScaleRES += (short) 30;
        break;
      case "Dextria-Earth":
        this.MainStat -= (short) 20;
        this.ScaleDEF += (short) 30;
        break;
      case "Dextria-Fire":
        this.MainStat -= (short) 20;
        this.ScaleSTR += (short) 30;
        break;
      case "Dextria-Ice":
        this.MainStat -= (short) 20;
        this.ScaleSKI += (short) 30;
        break;
      case "Dextria-Light":
        this.MainStat -= (short) 20;
        this.ScaleFAI += (short) 30;
        break;
      case "Dextria-Lightning":
        this.MainStat -= (short) 20;
        this.ScaleLUC += (short) 30;
        break;
      case "Dextria-Sound":
        this.MainStat -= (short) 20;
        this.ScaleSAN += (short) 30;
        break;
      case "Dextria-Water":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
      case "Dextria-Wind":
        this.MainStat -= (short) 20;
        this.ScaleCEL += (short) 30;
        break;
      case "Earthen":
        this.MainStat -= (short) 30;
        this.ScaleDEF += (short) 40;
        break;
      case "Electrical":
        this.MainStat -= (short) 30;
        this.ScaleLUC += (short) 40;
        break;
      case "Faithful":
        this.MainStat -= (short) 30;
        this.ScaleFAI += (short) 40;
        break;
      case "Finesse":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 30;
        break;
      case "Firearms":
        this.MainStat -= (short) 40;
        this.ScaleSKI += (short) 40;
        break;
      case "Flamelit":
        this.MainStat -= (short) 30;
        this.ScaleSTR += (short) 40;
        break;
      case "Magical":
        this.MainStat -= (short) 30;
        this.ScaleWIL += (short) 40;
        break;
      case "Precision":
        this.MainStat -= (short) 70;
        this.ScaleSKI += (short) 70;
        break;
      case "Replica":
        this.MainStat -= (short) 30;
        this.ScaleSKI += (short) 20;
        this.ScaleSAN += (short) 20;
        break;
      case "Spiritual":
        this.MainStat -= (short) 30;
        this.ScaleSAN += (short) 40;
        break;
      case "Sylphid":
        this.MainStat -= (short) 30;
        this.ScaleCEL += (short) 40;
        break;
      case "Tool":
        this.MainStat -= (short) 30;
        break;
      case "Vampiric":
        this.MainStat -= (short) 20;
        this.ScaleVIT += (short) 30;
        break;
    }
    this.Tag1Label.Text = Tag1;
    this.Tag2Label.Text = Tag2;
    this.Tag3Label.Text = Tag3;
    this.MainStat += Bonus;
    return this.MainStat;
  }

  private void WeaponBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.WeaponUpdate();
    this.UpdateSelf();
  }

  private void MutateCheck()
  {
    Decimal num = this.Rarity.Value;
    if (num <= 4M)
    {
      if (num <= 2M)
      {
        if (!(num == 1M))
        {
          if (num == 2M)
          {
            this.MutationLabel.Text = "Mutates Into: Fist";
            return;
          }
        }
        else
        {
          this.MutationLabel.Text = "Mutates Into: Dagger";
          return;
        }
      }
      else if (!(num == 3M))
      {
        if (num == 4M)
        {
          this.MutationLabel.Text = "Mutates Into: Axe";
          return;
        }
      }
      else
      {
        this.MutationLabel.Text = "Mutates Into: Sword";
        return;
      }
    }
    else if (num <= 6M)
    {
      if (!(num == 5M))
      {
        if (num == 6M)
        {
          this.MutationLabel.Text = "Mutates Into: Tome";
          return;
        }
      }
      else
      {
        this.MutationLabel.Text = "Mutates Into: Polearm";
        return;
      }
    }
    else if (!(num == 7M))
    {
      if (num == 8M)
      {
        this.MutationLabel.Text = "Mutates Into: Gun";
        return;
      }
    }
    else
    {
      this.MutationLabel.Text = "Mutates Into: Bow";
      return;
    }
    this.MutationLabel.Text = "Mutates Into: N/A";
  }

  private void UpdateStats()
  {
    this.STR = (int) this.MainForm.GetStrength();
    this.WIL = (int) this.MainForm.GetWill();
    this.SKI = (int) this.MainForm.GetSkill();
    this.CEL = (int) this.MainForm.GetCelerity();
    this.DEF = (int) this.MainForm.GetDefense();
    this.RES = (int) this.MainForm.GetResistance();
    this.VIT = (int) this.MainForm.GetVitality();
    this.FAI = (int) this.MainForm.GetFaith();
    this.LUC = (int) this.MainForm.GetLuck();
    this.GUI = (int) this.MainForm.GetGuile();
    this.SAN = (int) this.MainForm.GetSanctity();
    this.APT = (int) this.MainForm.GetAptitude();
  }

  public void UpdateSelf()
  {
    this.UpdateStats();
    this.MutateCheck();
    Decimal num1 = (Decimal) (this.SKI * 2) + this.AccuracyBox.Value + (Decimal) this.MaterialHit + (Decimal) this.UpgradeStat + (Decimal) this.SentimentalityStat + (Decimal) this.WeaponP1Hit + (Decimal) this.WeaponP2Hit + (Decimal) this.WeaponP3Hit + (Decimal) this.EnchantHit + (Decimal) this.HitBonus;
    Decimal num2 = this.WeightBox.Value + (Decimal) this.MaterialWeight + (Decimal) this.WeaponP1Weight + (Decimal) this.WeaponP2Weight + (Decimal) this.WeaponP3Weight + (Decimal) this.EnchantWeight + (Decimal) this.WeightBonus;
    Decimal num3 = (Decimal) (this.SKI / 2 + this.LUC) + this.CriticalBox.Value + (Decimal) this.UpgradeStat + (Decimal) this.MaterialCrit + (Decimal) this.SentimentalityStat + (Decimal) this.WeaponP1Crit + (Decimal) this.WeaponP2Crit + (Decimal) this.WeaponP3Crit + (Decimal) this.EnchantCrit + (Decimal) this.CritBonus;
    if (this.AutoCheck.Checked)
    {
      if (this.EnchantBox.Text == "Rebellion")
        this.EnchantHit = 0;
      num1 = (Decimal) (this.SKI * 2 + this.LUC + 90 + this.EnchantHit + (int) this.HitBonus);
    }
    Decimal num4 = Math.Floor(num2 * (Decimal) this.EnchantWeightMod);
    if (this.EnchantBox.Text == "Floating")
      num4 = Math.Floor(this.WeightBox.Value / 2M) + (Decimal) this.MaterialWeight + (Decimal) this.WeaponP1Weight + (Decimal) this.WeaponP2Weight + (Decimal) this.WeaponP3Weight + (Decimal) this.EnchantWeight + (Decimal) this.WeightBonus;
    int num5 = (int) this.TwoHandBox.Value * 2;
    if (num4 >= 20M && !this.RifleBox.Checked && !this.GunBox.Checked)
      num5 = (int) this.TwoHandBox.Value * 4;
    if (this.RifleBox.Checked && this.GunBox.Checked)
      num5 = (int) this.TwoHandBox.Value * 4;
    if (this.GunBox.Checked)
      num1 += (Decimal) num5;
    this.BasePower = (int) ((double) this.STR * ((double) this.StrengthBox.Value * 0.01)) + (int) ((double) this.WIL * ((double) this.WillBox.Value * 0.01)) + (int) ((double) this.SKI * ((double) this.SkillBox.Value * 0.01)) + (int) ((double) this.CEL * ((double) this.CelerityBox.Value * 0.01)) + (int) ((double) this.DEF * ((double) this.DefenseBox.Value * 0.01)) + (int) ((double) this.RES * ((double) this.ResistanceBox.Value * 0.01)) + (int) ((double) this.VIT * ((double) this.VitalityBox.Value * 0.01)) + (int) ((double) this.FAI * ((double) this.FaithBox.Value * 0.01)) + (int) ((double) this.LUC * ((double) this.LuckBox.Value * 0.01)) + (int) ((double) this.GUI * ((double) this.GuileBox.Value * 0.01)) + (int) ((double) this.SAN * ((double) this.SanctityBox.Value * 0.01)) + (int) ((double) this.APT * ((double) this.AptitudeBox.Value * 0.01));
    this.BasePower = (int) ((double) this.BasePower * 1.5) + (int) this.PowerBox.Value;
    this.BasePower = !this.GunBox.Checked ? this.BasePower + num5 + (int) this.MaterialPower + (int) this.UpgradeStat + (int) this.SentimentalityStat + (int) this.WeaponP1Power + (int) this.WeaponP2Power + (int) this.WeaponP3Power + this.EnchantPower + (int) this.PowerBonus : this.BasePower + (int) this.MaterialPower + (int) this.UpgradeStat + (int) this.SentimentalityStat + (int) this.WeaponP1Power + (int) this.WeaponP2Power + (int) this.WeaponP3Power + this.EnchantPower + (int) this.PowerBonus;
    this.SWALabel.Text = this.BasePower.ToString();
    double num6 = (double) this.CritModBox.Value + (double) this.GUI + this.WeaponP1CritDam + this.WeaponP2CritDam + this.WeaponP3CritDam + (double) this.EnchantCritMod;
    double num7 = num6 / 100.0;
    this.HitLabel.Text = num1.ToString() + "%";
    this.WeightLabel.Text = num4.ToString() + string.Empty;
    if (!this.STRWeapon)
    {
      this.CritLabel.Text = num3.ToString() + "%";
    }
    else
    {
      Decimal num8 = Math.Floor((Decimal) ((double) this.STR * 0.4));
      this.CritLabel.Text = (num3 + num8).ToString() + "%";
    }
    this.CritModLabel.Text = num6.ToString() + "%";
    this.CritDmgLabel.Text = ((int) ((double) this.BasePower * num7)).ToString();
    this.SWA = this.BasePower;
    if (!this.MainForm.PrintWindowOpen)
      return;
    this.MainForm.PrintUpdate();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.AptitudeBox = new NumericUpDown();
    this.SanctityBox = new NumericUpDown();
    this.GuileBox = new NumericUpDown();
    this.LuckBox = new NumericUpDown();
    this.FaithBox = new NumericUpDown();
    this.VitalityBox = new NumericUpDown();
    this.ResistanceBox = new NumericUpDown();
    this.DefenseBox = new NumericUpDown();
    this.CelerityBox = new NumericUpDown();
    this.SkillBox = new NumericUpDown();
    this.WillBox = new NumericUpDown();
    this.StrengthBox = new NumericUpDown();
    this.AptitudeNameLabel = new Label();
    this.SanctityNameLabel = new Label();
    this.GuileNameLabel = new Label();
    this.LuckNameLabel = new Label();
    this.FaithNameLabel = new Label();
    this.VitalityNameLabel = new Label();
    this.ResistanceNameLabel = new Label();
    this.DefenseNameLabel = new Label();
    this.CelerityNameLabel = new Label();
    this.SkillNameLabel = new Label();
    this.WillNameLabel = new Label();
    this.StrengthNameLabel = new Label();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.WeightBox = new NumericUpDown();
    this.CriticalBox = new NumericUpDown();
    this.AccuracyBox = new NumericUpDown();
    this.PowerBox = new NumericUpDown();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.CritLabel = new Label();
    this.HitLabel = new Label();
    this.SWALabel = new Label();
    this.label6 = new Label();
    this.TwoHandBox = new NumericUpDown();
    this.label10 = new Label();
    this.CritModBox = new NumericUpDown();
    this.CritModLabel = new Label();
    this.label12 = new Label();
    this.CritDmgLabel = new Label();
    this.label14 = new Label();
    this.MaterialBox = new ComboBox();
    this.label11 = new Label();
    this.PowerQuality = new CheckBox();
    this.AccuracyQuality = new CheckBox();
    this.CriticalQuality = new CheckBox();
    this.WeightLabel = new Label();
    this.label15 = new Label();
    this.WeightPlusBox = new CheckBox();
    this.WeightMinusBox = new CheckBox();
    this.SentimentBox = new CheckBox();
    this.WeaponPart1Box = new ComboBox();
    this.label13 = new Label();
    this.label16 = new Label();
    this.WeaponPart2Box = new ComboBox();
    this.label17 = new Label();
    this.WeaponPart3Box = new ComboBox();
    this.EnchantBox = new ComboBox();
    this.label18 = new Label();
    this.Rarity = new NumericUpDown();
    this.label19 = new Label();
    this.GunBox = new CheckBox();
    this.RifleBox = new CheckBox();
    this.WeaponBox = new ComboBox();
    this.label20 = new Label();
    this.MutationLabel = new Label();
    this.LockWPNE = new CheckBox();
    this.AutoCheck = new CheckBox();
    this.Tag1Label = new Label();
    this.Tag2Label = new Label();
    this.Tag3Label = new Label();
    this.TagVisibleCheck = new CheckBox();
    this.label22 = new Label();
    this.UpgradeLevelNUM = new NumericUpDown();
    this.WeaponEffectBtn = new Button();
    this.STRCrit = new CheckBox();
    this.AptitudeBox.BeginInit();
    this.SanctityBox.BeginInit();
    this.GuileBox.BeginInit();
    this.LuckBox.BeginInit();
    this.FaithBox.BeginInit();
    this.VitalityBox.BeginInit();
    this.ResistanceBox.BeginInit();
    this.DefenseBox.BeginInit();
    this.CelerityBox.BeginInit();
    this.SkillBox.BeginInit();
    this.WillBox.BeginInit();
    this.StrengthBox.BeginInit();
    this.WeightBox.BeginInit();
    this.CriticalBox.BeginInit();
    this.AccuracyBox.BeginInit();
    this.PowerBox.BeginInit();
    this.TwoHandBox.BeginInit();
    this.CritModBox.BeginInit();
    this.Rarity.BeginInit();
    this.UpgradeLevelNUM.BeginInit();
    this.SuspendLayout();
    this.AptitudeBox.Location = new Point(12, 285);
    this.AptitudeBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.AptitudeBox.Name = "AptitudeBox";
    this.AptitudeBox.Size = new Size(54, 20);
    this.AptitudeBox.TabIndex = 126;
    this.AptitudeBox.Visible = false;
    this.AptitudeBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.SanctityBox.Location = new Point(12, 263);
    this.SanctityBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.SanctityBox.Name = "SanctityBox";
    this.SanctityBox.Size = new Size(54, 20);
    this.SanctityBox.TabIndex = 125;
    this.SanctityBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.GuileBox.Location = new Point(12, 240 /*0xF0*/);
    this.GuileBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.GuileBox.Name = "GuileBox";
    this.GuileBox.Size = new Size(54, 20);
    this.GuileBox.TabIndex = 124;
    this.GuileBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.LuckBox.Location = new Point(12, 217);
    this.LuckBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.LuckBox.Name = "LuckBox";
    this.LuckBox.Size = new Size(54, 20);
    this.LuckBox.TabIndex = 123;
    this.LuckBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.FaithBox.Location = new Point(12, 194);
    this.FaithBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.FaithBox.Name = "FaithBox";
    this.FaithBox.Size = new Size(54, 20);
    this.FaithBox.TabIndex = 122;
    this.FaithBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.VitalityBox.Location = new Point(12, 172);
    this.VitalityBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.VitalityBox.Name = "VitalityBox";
    this.VitalityBox.Size = new Size(54, 20);
    this.VitalityBox.TabIndex = 121;
    this.VitalityBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.ResistanceBox.Location = new Point(12, 150);
    this.ResistanceBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.ResistanceBox.Name = "ResistanceBox";
    this.ResistanceBox.Size = new Size(54, 20);
    this.ResistanceBox.TabIndex = 120;
    this.ResistanceBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.DefenseBox.Location = new Point(12, (int) sbyte.MaxValue);
    this.DefenseBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.DefenseBox.Name = "DefenseBox";
    this.DefenseBox.Size = new Size(54, 20);
    this.DefenseBox.TabIndex = 119;
    this.DefenseBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.CelerityBox.Location = new Point(12, 104);
    this.CelerityBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.CelerityBox.Name = "CelerityBox";
    this.CelerityBox.Size = new Size(54, 20);
    this.CelerityBox.TabIndex = 118;
    this.CelerityBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.SkillBox.Location = new Point(12, 79);
    this.SkillBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.SkillBox.Name = "SkillBox";
    this.SkillBox.Size = new Size(54, 20);
    this.SkillBox.TabIndex = 117;
    this.SkillBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.WillBox.Location = new Point(12, 57);
    this.WillBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.WillBox.Name = "WillBox";
    this.WillBox.Size = new Size(54, 20);
    this.WillBox.TabIndex = 116;
    this.WillBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.StrengthBox.Location = new Point(12, 33);
    this.StrengthBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.StrengthBox.Name = "StrengthBox";
    this.StrengthBox.Size = new Size(54, 20);
    this.StrengthBox.TabIndex = 115;
    this.StrengthBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.AptitudeNameLabel.AutoSize = true;
    this.AptitudeNameLabel.Location = new Point(72, 287);
    this.AptitudeNameLabel.Name = "AptitudeNameLabel";
    this.AptitudeNameLabel.Size = new Size(46, 13);
    this.AptitudeNameLabel.TabIndex = 138;
    this.AptitudeNameLabel.Text = "Aptitude";
    this.AptitudeNameLabel.Visible = false;
    this.SanctityNameLabel.AutoSize = true;
    this.SanctityNameLabel.Location = new Point(72, 265);
    this.SanctityNameLabel.Name = "SanctityNameLabel";
    this.SanctityNameLabel.Size = new Size(45, 13);
    this.SanctityNameLabel.TabIndex = 137;
    this.SanctityNameLabel.Text = "Sanctity";
    this.GuileNameLabel.AutoSize = true;
    this.GuileNameLabel.Location = new Point(72, 242);
    this.GuileNameLabel.Name = "GuileNameLabel";
    this.GuileNameLabel.Size = new Size(31 /*0x1F*/, 13);
    this.GuileNameLabel.TabIndex = 136;
    this.GuileNameLabel.Text = "Guile";
    this.LuckNameLabel.AutoSize = true;
    this.LuckNameLabel.Location = new Point(72, 219);
    this.LuckNameLabel.Name = "LuckNameLabel";
    this.LuckNameLabel.Size = new Size(31 /*0x1F*/, 13);
    this.LuckNameLabel.TabIndex = 135;
    this.LuckNameLabel.Text = "Luck";
    this.FaithNameLabel.AutoSize = true;
    this.FaithNameLabel.Location = new Point(72, 196);
    this.FaithNameLabel.Name = "FaithNameLabel";
    this.FaithNameLabel.Size = new Size(30, 13);
    this.FaithNameLabel.TabIndex = 134;
    this.FaithNameLabel.Text = "Faith";
    this.VitalityNameLabel.AutoSize = true;
    this.VitalityNameLabel.Location = new Point(72, 174);
    this.VitalityNameLabel.Name = "VitalityNameLabel";
    this.VitalityNameLabel.Size = new Size(37, 13);
    this.VitalityNameLabel.TabIndex = 133;
    this.VitalityNameLabel.Text = "Vitality";
    this.ResistanceNameLabel.AutoSize = true;
    this.ResistanceNameLabel.Location = new Point(72, 152);
    this.ResistanceNameLabel.Name = "ResistanceNameLabel";
    this.ResistanceNameLabel.Size = new Size(60, 13);
    this.ResistanceNameLabel.TabIndex = 132;
    this.ResistanceNameLabel.Text = "Resistance";
    this.DefenseNameLabel.AutoSize = true;
    this.DefenseNameLabel.Location = new Point(72, 129);
    this.DefenseNameLabel.Name = "DefenseNameLabel";
    this.DefenseNameLabel.Size = new Size(47, 13);
    this.DefenseNameLabel.TabIndex = 131;
    this.DefenseNameLabel.Text = "Defense";
    this.CelerityNameLabel.AutoSize = true;
    this.CelerityNameLabel.Location = new Point(72, 106);
    this.CelerityNameLabel.Name = "CelerityNameLabel";
    this.CelerityNameLabel.Size = new Size(41, 13);
    this.CelerityNameLabel.TabIndex = 130;
    this.CelerityNameLabel.Text = "Celerity";
    this.SkillNameLabel.AutoSize = true;
    this.SkillNameLabel.Location = new Point(72, 81);
    this.SkillNameLabel.Name = "SkillNameLabel";
    this.SkillNameLabel.Size = new Size(26, 13);
    this.SkillNameLabel.TabIndex = 129;
    this.SkillNameLabel.Text = "Skill";
    this.WillNameLabel.AutoSize = true;
    this.WillNameLabel.Location = new Point(72, 59);
    this.WillNameLabel.Name = "WillNameLabel";
    this.WillNameLabel.Size = new Size(24, 13);
    this.WillNameLabel.TabIndex = 128 /*0x80*/;
    this.WillNameLabel.Text = "Will";
    this.StrengthNameLabel.AutoSize = true;
    this.StrengthNameLabel.Location = new Point(72, 35);
    this.StrengthNameLabel.Name = "StrengthNameLabel";
    this.StrengthNameLabel.Size = new Size(47, 13);
    this.StrengthNameLabel.TabIndex = (int) sbyte.MaxValue;
    this.StrengthNameLabel.Text = "Strength";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(9, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(283, 13);
    this.label1.TabIndex = 139;
    this.label1.Text = "Enter numbers as they appear. (Example: enter 50 for 50%)";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(284, 108);
    this.label2.Name = "label2";
    this.label2.Size = new Size(41, 13);
    this.label2.TabIndex = 147;
    this.label2.Text = "Weight";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(284, 83);
    this.label3.Name = "label3";
    this.label3.Size = new Size(38, 13);
    this.label3.TabIndex = 146;
    this.label3.Text = "Critical";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(284, 61);
    this.label4.Name = "label4";
    this.label4.Size = new Size(52, 13);
    this.label4.TabIndex = 145;
    this.label4.Text = "Accuracy";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(284, 37);
    this.label5.Name = "label5";
    this.label5.Size = new Size(37, 13);
    this.label5.TabIndex = 144 /*0x90*/;
    this.label5.Text = "Power";
    this.WeightBox.Location = new Point(224 /*0xE0*/, 106);
    this.WeightBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.WeightBox.Minimum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      int.MinValue
    });
    this.WeightBox.Name = "WeightBox";
    this.WeightBox.Size = new Size(54, 20);
    this.WeightBox.TabIndex = 143;
    this.WeightBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.CriticalBox.Location = new Point(224 /*0xE0*/, 81);
    this.CriticalBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.CriticalBox.Minimum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      int.MinValue
    });
    this.CriticalBox.Name = "CriticalBox";
    this.CriticalBox.Size = new Size(54, 20);
    this.CriticalBox.TabIndex = 142;
    this.CriticalBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.AccuracyBox.Location = new Point(224 /*0xE0*/, 59);
    this.AccuracyBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.AccuracyBox.Minimum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      int.MinValue
    });
    this.AccuracyBox.Name = "AccuracyBox";
    this.AccuracyBox.Size = new Size(54, 20);
    this.AccuracyBox.TabIndex = 141;
    this.AccuracyBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.PowerBox.Location = new Point(224 /*0xE0*/, 35);
    this.PowerBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.PowerBox.Minimum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      int.MinValue
    });
    this.PowerBox.Name = "PowerBox";
    this.PowerBox.Size = new Size(54, 20);
    this.PowerBox.TabIndex = 140;
    this.PowerBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(43, 358);
    this.label7.Name = "label7";
    this.label7.Size = new Size(38, 13);
    this.label7.TabIndex = 150;
    this.label7.Text = "Critical";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(43, 336);
    this.label8.Name = "label8";
    this.label8.Size = new Size(20, 13);
    this.label8.TabIndex = 149;
    this.label8.Text = "Hit";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(43, 312);
    this.label9.Name = "label9";
    this.label9.Size = new Size(118, 13);
    this.label9.TabIndex = 148;
    this.label9.Text = "Scaled Weapon Attack";
    this.CritLabel.AutoSize = true;
    this.CritLabel.Location = new Point(9, 358);
    this.CritLabel.Name = "CritLabel";
    this.CritLabel.Size = new Size(21, 13);
    this.CritLabel.TabIndex = 153;
    this.CritLabel.Text = "0%";
    this.HitLabel.AutoSize = true;
    this.HitLabel.Location = new Point(9, 336);
    this.HitLabel.Name = "HitLabel";
    this.HitLabel.Size = new Size(21, 13);
    this.HitLabel.TabIndex = 152;
    this.HitLabel.Text = "0%";
    this.SWALabel.AutoSize = true;
    this.SWALabel.Location = new Point(17, 312);
    this.SWALabel.Name = "SWALabel";
    this.SWALabel.Size = new Size(13, 13);
    this.SWALabel.TabIndex = 151;
    this.SWALabel.Text = "0";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(284, 134);
    this.label6.Name = "label6";
    this.label6.Size = new Size(88, 13);
    this.label6.TabIndex = 155;
    this.label6.Text = "2H/Steady Rank";
    this.TwoHandBox.Location = new Point(224 /*0xE0*/, 132);
    this.TwoHandBox.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.TwoHandBox.Name = "TwoHandBox";
    this.TwoHandBox.Size = new Size(54, 20);
    this.TwoHandBox.TabIndex = 154;
    this.TwoHandBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(284, 160 /*0xA0*/);
    this.label10.Name = "label10";
    this.label10.Size = new Size(78, 13);
    this.label10.TabIndex = 157;
    this.label10.Text = "Critical Modifier";
    this.CritModBox.Location = new Point(224 /*0xE0*/, 158);
    this.CritModBox.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.CritModBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CritModBox.Name = "CritModBox";
    this.CritModBox.Size = new Size(54, 20);
    this.CritModBox.TabIndex = 156;
    this.CritModBox.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.CritModBox.ValueChanged += new EventHandler(this.UpdateCalc);
    this.CritModLabel.AutoSize = true;
    this.CritModLabel.Location = new Point(9, 378);
    this.CritModLabel.Name = "CritModLabel";
    this.CritModLabel.Size = new Size(33, 13);
    this.CritModLabel.TabIndex = 159;
    this.CritModLabel.Text = "100%";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(43, 378);
    this.label12.Name = "label12";
    this.label12.Size = new Size(78, 13);
    this.label12.TabIndex = 158;
    this.label12.Text = "Critical Modifier";
    this.CritDmgLabel.AutoSize = true;
    this.CritDmgLabel.Location = new Point(16 /*0x10*/, 398);
    this.CritDmgLabel.Name = "CritDmgLabel";
    this.CritDmgLabel.Size = new Size(13, 13);
    this.CritDmgLabel.TabIndex = 161;
    this.CritDmgLabel.Text = "0";
    this.label14.AutoSize = true;
    this.label14.Location = new Point(43, 398);
    this.label14.Name = "label14";
    this.label14.Size = new Size(81, 13);
    this.label14.TabIndex = 160 /*0xA0*/;
    this.label14.Text = "Critical Damage";
    this.MaterialBox.FormattingEnabled = true;
    this.MaterialBox.Items.AddRange(new object[72]
    {
      (object) "==Metal==",
      (object) "Iron",
      (object) "Rockdirt",
      (object) "Galdric",
      (object) "Planetarium",
      (object) "Arctic",
      (object) "Conduiz",
      (object) "Coral",
      (object) "Ether",
      (object) "Magmic",
      (object) "Carapace",
      (object) "Orichalum",
      (object) "Gasprock",
      (object) "Clawice",
      (object) "Sandstone",
      (object) "Fossil",
      (object) "Boulder",
      (object) "Meteorite",
      (object) "Thinsteel",
      (object) "Folded Steel",
      (object) "Gravestone",
      (object) "Aureate",
      (object) "==Remains==",
      (object) "Accursed",
      (object) "Dragon",
      (object) "Fireblood",
      (object) "Iceblood",
      (object) "Fish",
      (object) "Gorgon",
      (object) "Insect",
      (object) "Kraboid",
      (object) "Shark",
      (object) "Snakeman",
      (object) "Spatial",
      (object) "==Wood==",
      (object) "Ash Wood",
      (object) "Coldbark",
      (object) "Devilbark",
      (object) "Etherbark",
      (object) "Firebark",
      (object) "Nightflower",
      (object) "Oribark",
      (object) "Windbark",
      (object) "Rotwood",
      (object) "Fungusbark",
      (object) "Markedbark",
      (object) "Smoothbark",
      (object) "Scorched Wood",
      (object) "Petrified Wood",
      (object) "Mossybark",
      (object) "Ivorybark",
      (object) "Rainbowbark",
      (object) "Hollow Log",
      (object) "Seedbark",
      (object) "==Paper==",
      (object) "Nerif Chapter",
      (object) "Kraken Chapter",
      (object) "Isesip Chapter",
      (object) "Sylph Chapter",
      (object) "Storm Chapter",
      (object) "Mercala Chapter",
      (object) "Heretic Chapter",
      (object) "Moldy Chapter",
      (object) "Beast Chapter",
      (object) "Orichal Chapter",
      (object) "Sandy Chapter",
      (object) "Ashen Chapter",
      (object) "Fine Art",
      (object) "Sheet Music",
      (object) "Foamy Chapter",
      (object) "Star Chapter",
      (object) "Thin Chapter"
    });
    this.MaterialBox.Location = new Point(225, 340);
    this.MaterialBox.Name = "MaterialBox";
    this.MaterialBox.Size = new Size(120, 21);
    this.MaterialBox.TabIndex = 162;
    this.MaterialBox.SelectedIndexChanged += new EventHandler(this.MaterialBox_SelectedIndexChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(222, 324);
    this.label11.Name = "label11";
    this.label11.Size = new Size(44, 13);
    this.label11.TabIndex = 163;
    this.label11.Text = "Material";
    this.PowerQuality.AutoSize = true;
    this.PowerQuality.Location = new Point(225, 212);
    this.PowerQuality.Name = "PowerQuality";
    this.PowerQuality.Size = new Size(56, 17);
    this.PowerQuality.TabIndex = 164;
    this.PowerQuality.Text = "Power";
    this.PowerQuality.UseVisualStyleBackColor = true;
    this.PowerQuality.CheckedChanged += new EventHandler(this.PowerQuality_CheckedChanged);
    this.AccuracyQuality.AutoSize = true;
    this.AccuracyQuality.Location = new Point(287, 212);
    this.AccuracyQuality.Name = "AccuracyQuality";
    this.AccuracyQuality.Size = new Size(71, 17);
    this.AccuracyQuality.TabIndex = 165;
    this.AccuracyQuality.Text = "Accuracy";
    this.AccuracyQuality.UseVisualStyleBackColor = true;
    this.AccuracyQuality.CheckedChanged += new EventHandler(this.AccuracyQuality_CheckedChanged);
    this.CriticalQuality.AutoSize = true;
    this.CriticalQuality.Location = new Point(225, 235);
    this.CriticalQuality.Name = "CriticalQuality";
    this.CriticalQuality.Size = new Size(57, 17);
    this.CriticalQuality.TabIndex = 166;
    this.CriticalQuality.Text = "Critical";
    this.CriticalQuality.UseVisualStyleBackColor = true;
    this.CriticalQuality.CheckedChanged += new EventHandler(this.CriticalQuality_CheckedChanged);
    this.WeightLabel.AutoSize = true;
    this.WeightLabel.Location = new Point(16 /*0x10*/, 416);
    this.WeightLabel.Name = "WeightLabel";
    this.WeightLabel.Size = new Size(13, 13);
    this.WeightLabel.TabIndex = 168;
    this.WeightLabel.Text = "0";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(43, 416);
    this.label15.Name = "label15";
    this.label15.Size = new Size(41, 13);
    this.label15.TabIndex = 167;
    this.label15.Text = "Weight";
    this.WeightPlusBox.AutoSize = true;
    this.WeightPlusBox.Location = new Point(225, 258);
    this.WeightPlusBox.Name = "WeightPlusBox";
    this.WeightPlusBox.Size = new Size(66, 17);
    this.WeightPlusBox.TabIndex = 169;
    this.WeightPlusBox.Text = "+Weight";
    this.WeightPlusBox.UseVisualStyleBackColor = true;
    this.WeightPlusBox.CheckedChanged += new EventHandler(this.WeightPlusBox_CheckedChanged);
    this.WeightMinusBox.AutoSize = true;
    this.WeightMinusBox.Location = new Point(287, 258);
    this.WeightMinusBox.Name = "WeightMinusBox";
    this.WeightMinusBox.Size = new Size(63 /*0x3F*/, 17);
    this.WeightMinusBox.TabIndex = 170;
    this.WeightMinusBox.Text = "-Weight";
    this.WeightMinusBox.TextAlign = ContentAlignment.MiddleCenter;
    this.WeightMinusBox.UseVisualStyleBackColor = true;
    this.WeightMinusBox.CheckedChanged += new EventHandler(this.WeightMinusBox_CheckedChanged);
    this.SentimentBox.AutoSize = true;
    this.SentimentBox.Location = new Point(224 /*0xE0*/, 304);
    this.SentimentBox.Name = "SentimentBox";
    this.SentimentBox.Size = new Size(120, 17);
    this.SentimentBox.TabIndex = 173;
    this.SentimentBox.Text = "Sentimentality (Max)";
    this.SentimentBox.UseVisualStyleBackColor = true;
    this.SentimentBox.CheckedChanged += new EventHandler(this.SentimentBox_CheckedChanged);
    this.WeaponPart1Box.FormattingEnabled = true;
    this.WeaponPart1Box.Items.AddRange(new object[55]
    {
      (object) "Standard",
      (object) "==Blades==",
      (object) "Serrated",
      (object) "Razor Blade",
      (object) "Piercing Blade",
      (object) "Huge(Sword)",
      (object) "Balanced",
      (object) "==Axehead==",
      (object) "Tempered",
      (object) "Cutting",
      (object) "Spiked Axehead",
      (object) "Curved Axehead",
      (object) "Guillotine",
      (object) "==Spearhead==",
      (object) "Barbed",
      (object) "Crescent",
      (object) "Hollow",
      (object) "Hooked",
      (object) "Thin Spearhead",
      (object) "==Poles==",
      (object) "Wooden",
      (object) "Curved Pole",
      (object) "Helix",
      (object) "Extended Pole",
      (object) "Flexible",
      (object) "==Bow Body==",
      (object) "Compact",
      (object) "Focused",
      (object) "Large Body",
      (object) "Composite",
      (object) "Thin Body",
      (object) "==Knuckles==",
      (object) "Dense",
      (object) "Elongated",
      (object) "Leather",
      (object) "Spiked Knuckles",
      (object) "Wrapped",
      (object) "==Barrels==",
      (object) "Short",
      (object) "Wide",
      (object) "Long",
      (object) "Double(Shotgun)",
      (object) "Sniper(Rifle)",
      (object) "==Strings==",
      (object) "Silk",
      (object) "Tight",
      (object) "Double String",
      (object) "Wire",
      (object) "Chain",
      (object) "==Covers==",
      (object) "Blank Cover",
      (object) "Hardback Cover",
      (object) "Thin Cover",
      (object) "Hellish Eye",
      (object) "Diary Lock"
    });
    this.WeaponPart1Box.Location = new Point(225, 380);
    this.WeaponPart1Box.Name = "WeaponPart1Box";
    this.WeaponPart1Box.Size = new Size(121, 21);
    this.WeaponPart1Box.TabIndex = 174;
    this.WeaponPart1Box.SelectedIndexChanged += new EventHandler(this.WeaponPart1Box_SelectedIndexChanged);
    this.label13.AutoSize = true;
    this.label13.Location = new Point(222, 364);
    this.label13.Name = "label13";
    this.label13.Size = new Size(79, 13);
    this.label13.TabIndex = 175;
    this.label13.Text = "Weapon Part 1";
    this.label16.AutoSize = true;
    this.label16.Location = new Point(222, 404);
    this.label16.Name = "label16";
    this.label16.Size = new Size(79, 13);
    this.label16.TabIndex = 177;
    this.label16.Text = "Weapon Part 2";
    this.WeaponPart2Box.FormattingEnabled = true;
    this.WeaponPart2Box.Items.AddRange(new object[49]
    {
      (object) "Standard",
      (object) "==Blades==",
      (object) "Serrated",
      (object) "Razor Blade",
      (object) "Piercing Blade",
      (object) "Huge(Sword)",
      (object) "Balanced",
      (object) "==Poles==",
      (object) "Wooden",
      (object) "Curved Pole",
      (object) "Helix",
      (object) "Extended Pole",
      (object) "Flexible",
      (object) "==Guards==",
      (object) "Sturdy",
      (object) "Empty",
      (object) "Locking",
      (object) "Full",
      (object) "Razor Guard",
      (object) "==Strings==",
      (object) "Silk",
      (object) "Tight",
      (object) "Double String",
      (object) "Wire",
      (object) "Chain",
      (object) "==Wrists==",
      (object) "Wrist Guard",
      (object) "Spiked Wrist",
      (object) "Strings Wrist",
      (object) "Loose",
      (object) "Weighted",
      (object) "==Grips==",
      (object) "Soft",
      (object) "Steady",
      (object) "Revolver",
      (object) "Extended(Handgun)",
      (object) "Custom",
      (object) "==Bindings==",
      (object) "Leather Binds",
      (object) "Metal Binds",
      (object) "Magic Binds",
      (object) "Bone Binds",
      (object) "Long Binds",
      (object) "==Hilts==",
      (object) "Insulated Hilt",
      (object) "Wooden Hilt",
      (object) "Firm Hilt",
      (object) "Sharp Hilt",
      (object) "Onigan Hilt"
    });
    this.WeaponPart2Box.Location = new Point(225, 420);
    this.WeaponPart2Box.Name = "WeaponPart2Box";
    this.WeaponPart2Box.Size = new Size(121, 21);
    this.WeaponPart2Box.TabIndex = 176 /*0xB0*/;
    this.WeaponPart2Box.SelectedIndexChanged += new EventHandler(this.WeaponPart2Box_SelectedIndexChanged);
    this.label17.AutoSize = true;
    this.label17.Location = new Point(222, 444);
    this.label17.Name = "label17";
    this.label17.Size = new Size(79, 13);
    this.label17.TabIndex = 179;
    this.label17.Text = "Weapon Part 3";
    this.WeaponPart3Box.FormattingEnabled = true;
    this.WeaponPart3Box.Items.AddRange(new object[37]
    {
      (object) "Standard",
      (object) "==Hilts==",
      (object) "Insulated Hilt",
      (object) "Wooden Hilt",
      (object) "Firm Hilt",
      (object) "Sharp Hilt",
      (object) "Onigan Hilt",
      (object) "==Arrows==",
      (object) "Fire Arrow",
      (object) "Light Arrow",
      (object) "Sharp Arrow",
      (object) "Thin Arrow",
      (object) "Heavy Arrow",
      (object) "==Bullets==",
      (object) "Aerodynamic",
      (object) "Piercing Bullet",
      (object) "Hellhound",
      (object) "Scatter",
      (object) "Silver",
      (object) "==Poles==",
      (object) "Wooden",
      (object) "Curved Pole",
      (object) "Helix",
      (object) "Extended Pole",
      (object) "Flexible",
      (object) "==Blades==",
      (object) "Serrated",
      (object) "Razor Blade",
      (object) "Piercing Blade",
      (object) "Huge(Sword)",
      (object) "Balanced",
      (object) "==Axehead==",
      (object) "Tempered",
      (object) "Cutting",
      (object) "Spiked Axehead",
      (object) "Curved Axehead",
      (object) "Guillotine"
    });
    this.WeaponPart3Box.Location = new Point(225, 460);
    this.WeaponPart3Box.Name = "WeaponPart3Box";
    this.WeaponPart3Box.Size = new Size(121, 21);
    this.WeaponPart3Box.TabIndex = 178;
    this.WeaponPart3Box.SelectedIndexChanged += new EventHandler(this.WeaponPart3Box_SelectedIndexChanged);
    this.EnchantBox.FormattingEnabled = true;
    this.EnchantBox.Items.AddRange(new object[18]
    {
      (object) "No Enchant",
      (object) "==Standard==",
      (object) "Vorpal",
      (object) "Reaper",
      (object) "Divine",
      (object) "Blessed(Divine Sign)",
      (object) "Rebellion",
      (object) "Fated",
      (object) "Gigantic",
      (object) "Mutation",
      (object) "Floating",
      (object) "Runed",
      (object) "==Curses==",
      (object) "Rustic",
      (object) "Fleeting",
      (object) "==Other==",
      (object) "Blessed",
      (object) "Purity Edge"
    });
    this.EnchantBox.Location = new Point(225, 501);
    this.EnchantBox.Name = "EnchantBox";
    this.EnchantBox.Size = new Size(121, 21);
    this.EnchantBox.TabIndex = 180;
    this.EnchantBox.SelectedIndexChanged += new EventHandler(this.EnchantBox_SelectedIndexChanged);
    this.label18.AutoSize = true;
    this.label18.Location = new Point(221, 484);
    this.label18.Name = "label18";
    this.label18.Size = new Size(91, 13);
    this.label18.TabIndex = 181;
    this.label18.Text = "Weapon Enchant";
    this.Rarity.Location = new Point(224 /*0xE0*/, 184);
    this.Rarity.Maximum = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.Rarity.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.Rarity.Name = "Rarity";
    this.Rarity.Size = new Size(54, 20);
    this.Rarity.TabIndex = 182;
    this.Rarity.Value = new Decimal(new int[4]{ 1, 0, 0, 0 });
    this.Rarity.ValueChanged += new EventHandler(this.Rarity_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.Location = new Point(284, 186);
    this.label19.Name = "label19";
    this.label19.Size = new Size(34, 13);
    this.label19.TabIndex = 183;
    this.label19.Text = "Rarity";
    this.GunBox.AutoSize = true;
    this.GunBox.Location = new Point(225, 281);
    this.GunBox.Name = "GunBox";
    this.GunBox.Size = new Size(46, 17);
    this.GunBox.TabIndex = 184;
    this.GunBox.Text = "Gun";
    this.GunBox.UseVisualStyleBackColor = true;
    this.GunBox.CheckedChanged += new EventHandler(this.GunBox_CheckedChanged);
    this.RifleBox.AutoSize = true;
    this.RifleBox.Location = new Point(287, 281);
    this.RifleBox.Name = "RifleBox";
    this.RifleBox.Size = new Size(47, 17);
    this.RifleBox.TabIndex = 185;
    this.RifleBox.Text = "Rifle";
    this.RifleBox.UseVisualStyleBackColor = true;
    this.RifleBox.CheckedChanged += new EventHandler(this.RifleBox_CheckedChanged);
    this.WeaponBox.FormattingEnabled = true;
    this.WeaponBox.Items.AddRange(new object[417]
    {
      (object) "============Sword============",
      (object) "Hidden Blade",
      (object) "==1 Star==",
      (object) "Longsword",
      (object) "Wooden Longsword",
      (object) "Wooden Katana",
      (object) "==2 Star==",
      (object) "Swordfish Sword",
      (object) "Wo-Dao",
      (object) "==3 Star==",
      (object) "Nelten",
      (object) "Wooden Nelten",
      (object) "Fuuma",
      (object) "Eresh",
      (object) "Bloody-Fang",
      (object) "Moonblade",
      (object) "Endless Handkerchief",
      (object) "==4 Star==",
      (object) "Golgorth",
      (object) "River Sword",
      (object) "Spirit Sword",
      (object) "Crystal Blade",
      (object) "Rapier of Resent",
      (object) "==5 Star==",
      (object) "Dual-Blade",
      (object) "Bandit Sword",
      (object) "Homura",
      (object) "Engraved Katana",
      (object) "==6 Star==",
      (object) "Excel Saber",
      (object) "Dynaxis",
      (object) "Cleaving Clarinet",
      (object) "Sakabatou",
      (object) "==7 Star==",
      (object) "Yukijin",
      (object) "Raijin",
      (object) "Sanjin",
      (object) "Kouenjin",
      (object) "Akujin",
      (object) "Magical Star",
      (object) "Sea Hunter Sword",
      (object) "Hakouhen Katana",
      (object) "Kamiya",
      (object) "==8 Star==",
      (object) "Larveget",
      (object) "Braver Replica",
      (object) "Hisen",
      (object) "Setsuna",
      (object) "Ensui",
      (object) "Narcus",
      (object) "Kirosh",
      (object) "Shine Sword",
      (object) "==9 Star==",
      (object) "Salamander Sword",
      (object) "Black Xyston",
      (object) "Sogensara",
      (object) "Rogue Dasher",
      (object) "Spectre Sword",
      (object) "==10 Star==",
      (object) "Kingslayer",
      (object) "Tarnada",
      (object) "Spine Leash",
      (object) "Gigantys",
      (object) "Hooked Twinblade",
      (object) "============Polearms============",
      (object) "==1 Star==",
      (object) "Spear",
      (object) "Quarterstaff",
      (object) "==2 Star==",
      (object) "Javelin",
      (object) "Duodent",
      (object) "==3 Star==",
      (object) "Warstaff",
      (object) "Shizumare",
      (object) "Greatspear",
      (object) "Holy Lance",
      (object) "==4 Star==",
      (object) "Soulstealer",
      (object) "Siphon",
      (object) "Voidcut",
      (object) "Impaler",
      (object) "==5 Star==",
      (object) "Bamboo-Bo",
      (object) "Pilfer Spear",
      (object) "Cerron Scepter",
      (object) "Tuning Fork",
      (object) "Firepoker",
      (object) "Monk Priest's Staff",
      (object) "==6 Star==",
      (object) "Sleigher",
      (object) "Excel Hasta",
      (object) "Sasumata",
      (object) "==7 Star==",
      (object) "Abberation Spear",
      (object) "Magical Moon",
      (object) "Sea Hunter Spear",
      (object) "Black Spear",
      (object) "Deadly Smile",
      (object) "Lorelei",
      (object) "==8 Star==",
      (object) "Elenoa",
      (object) "Gae Bolg Replica",
      (object) "==9 Star==",
      (object) "Knight Slayer",
      (object) "Red Argus",
      (object) "Gae Baed",
      (object) "Diamond-Head/Aerialite Staff",
      (object) "Ruby-Head/Requinite Staff",
      (object) "Amethyst-Head/Morganite Staff",
      (object) "Onyx-Head/Tetraite Staff",
      (object) "Topaz-Head/Fulgurite Staff",
      (object) "Sapphire-Head/Cariaite Staff",
      (object) "Emerald-Head/Fortunite Staff",
      (object) "Aquamarine-Head Staff",
      (object) "Roaring Rose",
      (object) "==10 Star==",
      (object) "Staff of Eyes",
      (object) "Hundred-Reflection Spear",
      (object) "Eternal Servitude",
      (object) "Overgrown Staff",
      (object) "Winged Spear",
      (object) "Fellgrant Drinker",
      (object) "Gryphon Wing",
      (object) "============Axes============",
      (object) "==1 Star==",
      (object) "Axe",
      (object) "Wrench",
      (object) "Battleaxe",
      (object) "==2 Star==",
      (object) "Sweeper",
      (object) "Guillotine",
      (object) "==3 Star==",
      (object) "Icebreaker",
      (object) "Gorger",
      (object) "Battlepick",
      (object) "Grand Axe",
      (object) "==4 Star==",
      (object) "Graality",
      (object) "Spirit Axe",
      (object) "Kanabo",
      (object) "==5 Star==",
      (object) "Burngada",
      (object) "Highway Axe",
      (object) "Monster Spine",
      (object) "Gunbai",
      (object) "==6 Star==",
      (object) "Evil Club",
      (object) "Excel Parashu",
      (object) "Baphomet's Offering",
      (object) "==7 Star==",
      (object) "Electric Axe",
      (object) "Magical Sun",
      (object) "Sea Hunter Axe",
      (object) "Vampire Bat",
      (object) "Labrys",
      (object) "==8 Stars==",
      (object) "Mythslayer",
      (object) "Ramarg",
      (object) "Nirvana Replica",
      (object) "Lare Grystale",
      (object) "==9 Star==",
      (object) "Grand Smasher",
      (object) "Sky Mantis Scythe",
      (object) "Citizen Slaughterer",
      (object) "Violet Varon",
      (object) "Sheer Cold",
      (object) "==10 Star==",
      (object) "Noble Axe",
      (object) "Anchor Edge",
      (object) "Skullcaver",
      (object) "Pillawag",
      (object) "============Tomes============",
      (object) "==1 Star==",
      (object) "Flamberg",
      (object) "Zeroraid",
      (object) "Fullgust",
      (object) "Ampeol",
      (object) "Blacksand",
      (object) "Hymn",
      (object) "Well",
      (object) "Chorus",
      (object) "==3 Star==",
      (object) "Flambella",
      (object) "Zerotrain",
      (object) "Fullphoon",
      (object) "Amplifyia",
      (object) "Blackmount",
      (object) "Hymnta",
      (object) "Wellweg",
      (object) "Chorusaf",
      (object) "==5 Star==",
      (object) "Sthenno",
      (object) "==6 Star==",
      (object) "Flamnyaghra",
      (object) "Zerorewuin",
      (object) "Fullurricane",
      (object) "Ampgeneoule",
      (object) "Blackmeteor",
      (object) "Hymntaturych",
      (object) "Wellwegwet",
      (object) "Chorousafhybyn",
      (object) "Devil's Tome",
      (object) "Excelgraph",
      (object) "Stone Vector",
      (object) "==7 Star==",
      (object) "Rose Whip",
      (object) "Sea Hunter Tome",
      (object) "Mugendai",
      (object) "Jade Insect Whistle",
      (object) "==8 Star==",
      (object) "Farren",
      (object) "Kigal Replica",
      (object) "Zhuquelare",
      (object) "Xuanwuken",
      (object) "Baihurai",
      (object) "Qinglongram",
      (object) "==9 Star==",
      (object) "Screaming Tome",
      (object) "Rexys",
      (object) "Grandovyn",
      (object) "Forgrint",
      (object) "Dynamic Tome (Fire)",
      (object) "Dynamic Tome (Ice)",
      (object) "Dynamic Tome (Wind)",
      (object) "Dynamic Tome (Ltn.)",
      (object) "Dynamic Tome (Earth)",
      (object) "Dynamic Tome (Dark)",
      (object) "Dynamic Tome (Water)",
      (object) "Dynamic Tome (Light)",
      (object) "Dynamic Tome (Acid)",
      (object) "Dynamic Tome (Sound)",
      (object) "Betrayer's Wit",
      (object) "Morimayer",
      (object) "==10 Star==",
      (object) "Vorso Verso",
      (object) "Aquaphobia",
      (object) "Desert Wind",
      (object) "Coastal Squall",
      (object) "Carteblanche",
      (object) "Manic Slasher",
      (object) "Torment Noctis",
      (object) "Balrog",
      (object) "============Bows============",
      (object) "==1 Star==",
      (object) "Bow",
      (object) "Guiding Shot",
      (object) "==2 Star==",
      (object) "Hunting Bow",
      (object) "Crossbow",
      (object) "==3 Star==",
      (object) "Longbow",
      (object) "Knightslayer",
      (object) "Nighthunt",
      (object) "Redwing",
      (object) "Gel'Naia",
      (object) "Thunder Shot",
      (object) "Harp Bow",
      (object) "==4 Star==",
      (object) "Bow of the Green Forest",
      (object) "Spirit Bow",
      (object) "Soulshot",
      (object) "Daikyu",
      (object) "==5 Star==",
      (object) "Hankyu",
      (object) "==6 Star==",
      (object) "Thorn Shooter",
      (object) "Hell Sniper",
      (object) "==7 Star==",
      (object) "Magical Meteor",
      (object) "Sea Hunter Bow",
      (object) "Fortune's Favor",
      (object) "==8 Star==",
      (object) "Grandia",
      (object) "Artemis Replica",
      (object) "==9 Star==",
      (object) "Adversity Annihilator",
      (object) "Fae Bow",
      (object) "Howling Handshot",
      (object) "==10 Star==",
      (object) "Filcherbird",
      (object) "Star Shooter",
      (object) "Razing Salamander",
      (object) "Kraken's Sigh",
      (object) "Blind Bright",
      (object) "============Guns============",
      (object) "Revolver Raid Cannon",
      (object) "Hidden Barrage",
      (object) "==1 Star==",
      (object) "Handgun",
      (object) "==4 Star==",
      (object) "Autopistol",
      (object) "Shotgun",
      (object) "==5 Star==",
      (object) "Spirit Hunter",
      (object) "Hold Upper",
      (object) "Ghost Smoke",
      (object) "==6 Star==",
      (object) "Ryeser",
      (object) "Excel Sniper",
      (object) "Firthrower",
      (object) "==7 Star==",
      (object) "Sea Hunter Gun",
      (object) "Yin",
      (object) "Yang",
      (object) "Magical Nova",
      (object) "The Kiss Farewell",
      (object) "==8 Star==",
      (object) "Tarnell",
      (object) "Blaster Trumpet",
      (object) "Holy Word",
      (object) "==9 Star==",
      (object) "Jackhammer",
      (object) "Toyatori",
      (object) "Crazy Coyote",
      (object) "Black Zepia",
      (object) "Shotgun Tonfa",
      (object) "==10 Star==",
      (object) "Corvis Cannon",
      (object) "Moonlight Mercy",
      (object) "Seed Sniper",
      (object) "Quickdraw",
      (object) "Bell of No Rest",
      (object) "============Fists============",
      (object) "Bare Fists",
      (object) "Grudge Claws",
      (object) "Arcane Fists",
      (object) "==1 Star==",
      (object) "Brawler's Glove",
      (object) "==2 Star==",
      (object) "Knuckledusters",
      (object) "Boxing Gloves",
      (object) "Crash Cymbals",
      (object) "==3 Star==",
      (object) "Tenderizers",
      (object) "Needler",
      (object) "Cougar Claws",
      (object) "==4 Star==",
      (object) "Spirit Gauntlet",
      (object) "Claw Gauntlet",
      (object) "Ninja Scroll",
      (object) "==5 Star==",
      (object) "Pickpocketers",
      (object) "Maned Tonfa",
      (object) "==6 Star==",
      (object) "Burst Claw",
      (object) "Bear Claws",
      (object) "Excellion",
      (object) "Shadow Wind Claw",
      (object) "==7 Star==",
      (object) "Magical Comet",
      (object) "Sea Hunter Gauntlet",
      (object) "Whulf",
      (object) "Kusarigami",
      (object) "==8 Star==",
      (object) "Helrenroka",
      (object) "Shredder Replica",
      (object) "==9 Star==",
      (object) "Fenri",
      (object) "Cobalt Qrytys",
      (object) "Ymir",
      (object) "==10 Star==",
      (object) "Deadclaw",
      (object) "Mortissimo",
      (object) "Pinchers",
      (object) "Hands of the Giant",
      (object) "Buzzing Chakram",
      (object) "============Daggers============",
      (object) "==1 Star==",
      (object) "Dagger",
      (object) "Lute",
      (object) "Whip",
      (object) "==2 Star==",
      (object) "Throwing Dagger",
      (object) "Stinger",
      (object) "Tanto",
      (object) "==3 Star==",
      (object) "Shuriken",
      (object) "Dagger of Bleeding",
      (object) "Parrying Dagger",
      (object) "==4 Star==",
      (object) "Bloodstained Flute",
      (object) "Creeping Darkness",
      (object) "==5 Star==",
      (object) "Thief Blade",
      (object) "Nullifying Dirk",
      (object) "==6 Star==",
      (object) "Touyaa Shuriken",
      (object) "Byakko Tessen",
      (object) "Seiryuu Tessen",
      (object) "Suzaku Tessen",
      (object) "Summoner's Tandem Dagger",
      (object) "==7 Star==",
      (object) "Tamaki Shuriken",
      (object) "Sea Hunter Dagger",
      (object) "Magical Photon",
      (object) "Combat Magnifying Glass",
      (object) "Konosekai",
      (object) "==8 Star==",
      (object) "Paragi Shuriken",
      (object) "Tsukikage",
      (object) "Hikage",
      (object) "Crelia",
      (object) "Creed Replica",
      (object) "Puppet Strings",
      (object) "==9 Star==",
      (object) "Red Letter",
      (object) "Ninshi Shuriken",
      (object) "Bakaga Shuriken",
      (object) "Copper Coliche",
      (object) "==10 Star==",
      (object) "Eternal Solitude",
      (object) "Fangfare",
      (object) "Vorpal Fang",
      (object) "Atlua's Abaniko",
      (object) "Dancing Shiv",
      (object) "Hexfang",
      (object) "============================"
    });
    this.WeaponBox.Location = new Point(12, 476);
    this.WeaponBox.Name = "WeaponBox";
    this.WeaponBox.Size = new Size(203, 21);
    this.WeaponBox.TabIndex = 186;
    this.WeaponBox.SelectedIndexChanged += new EventHandler(this.WeaponBox_SelectedIndexChanged);
    this.label20.AutoSize = true;
    this.label20.Location = new Point(9, 460);
    this.label20.Name = "label20";
    this.label20.Size = new Size(48 /*0x30*/, 13);
    this.label20.TabIndex = 187;
    this.label20.Text = "Weapon";
    this.MutationLabel.AutoSize = true;
    this.MutationLabel.Location = new Point(9, 438);
    this.MutationLabel.Name = "MutationLabel";
    this.MutationLabel.Size = new Size(92, 13);
    this.MutationLabel.TabIndex = 188;
    this.MutationLabel.Text = "Mutates Into: N/A";
    this.LockWPNE.AutoSize = true;
    this.LockWPNE.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.LockWPNE.Location = new Point(143, 338);
    this.LockWPNE.Name = "LockWPNE";
    this.LockWPNE.RightToLeft = RightToLeft.Yes;
    this.LockWPNE.Size = new Size(72, 28);
    this.LockWPNE.TabIndex = 190;
    this.LockWPNE.Text = "Lock \r\nMat + Parts";
    this.LockWPNE.TextAlign = ContentAlignment.MiddleCenter;
    this.LockWPNE.UseVisualStyleBackColor = true;
    this.AutoCheck.AutoSize = true;
    this.AutoCheck.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.AutoCheck.Location = new Point(164, 39);
    this.AutoCheck.Name = "AutoCheck";
    this.AutoCheck.RightToLeft = RightToLeft.Yes;
    this.AutoCheck.Size = new Size(54, 16 /*0x10*/);
    this.AutoCheck.TabIndex = 191;
    this.AutoCheck.Text = "Autohit";
    this.AutoCheck.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoCheck.UseVisualStyleBackColor = true;
    this.AutoCheck.Visible = false;
    this.AutoCheck.CheckedChanged += new EventHandler(this.AutoCheck_CheckedChanged);
    this.Tag1Label.AutoSize = true;
    this.Tag1Label.Location = new Point(140, 380);
    this.Tag1Label.Name = "Tag1Label";
    this.Tag1Label.Size = new Size(32 /*0x20*/, 13);
    this.Tag1Label.TabIndex = 192 /*0xC0*/;
    this.Tag1Label.Text = "Tag1";
    this.Tag1Label.Visible = false;
    this.Tag2Label.AutoSize = true;
    this.Tag2Label.Location = new Point(140, 398);
    this.Tag2Label.Name = "Tag2Label";
    this.Tag2Label.Size = new Size(32 /*0x20*/, 13);
    this.Tag2Label.TabIndex = 193;
    this.Tag2Label.Text = "Tag2";
    this.Tag2Label.Visible = false;
    this.Tag3Label.AutoSize = true;
    this.Tag3Label.Location = new Point(140, 416);
    this.Tag3Label.Name = "Tag3Label";
    this.Tag3Label.Size = new Size(32 /*0x20*/, 13);
    this.Tag3Label.TabIndex = 194;
    this.Tag3Label.Text = "Tag3";
    this.Tag3Label.Visible = false;
    this.TagVisibleCheck.AutoSize = true;
    this.TagVisibleCheck.Location = new Point(298, 8);
    this.TagVisibleCheck.Name = "TagVisibleCheck";
    this.TagVisibleCheck.Size = new Size(50, 17);
    this.TagVisibleCheck.TabIndex = 195;
    this.TagVisibleCheck.Text = "Tags";
    this.TagVisibleCheck.UseVisualStyleBackColor = true;
    this.TagVisibleCheck.CheckedChanged += new EventHandler(this.TagVisibleCheck_CheckedChanged);
    this.label22.AutoSize = true;
    this.label22.Font = new Font("Microsoft Sans Serif", 7.25f);
    this.label22.Location = new Point(323, 236);
    this.label22.Name = "label22";
    this.label22.Size = new Size(20, 13);
    this.label22.TabIndex = 197;
    this.label22.Text = "UL";
    this.UpgradeLevelNUM.Location = new Point(287, 233);
    this.UpgradeLevelNUM.Maximum = new Decimal(new int[4]
    {
      6,
      0,
      0,
      0
    });
    this.UpgradeLevelNUM.Name = "UpgradeLevelNUM";
    this.UpgradeLevelNUM.Size = new Size(30, 20);
    this.UpgradeLevelNUM.TabIndex = 196;
    this.UpgradeLevelNUM.ValueChanged += new EventHandler(this.UpgradeLevelNUM_ValueChanged);
    this.WeaponEffectBtn.Location = new Point(46, 503);
    this.WeaponEffectBtn.Name = "WeaponEffectBtn";
    this.WeaponEffectBtn.Size = new Size(149, 23);
    this.WeaponEffectBtn.TabIndex = 198;
    this.WeaponEffectBtn.Text = "Check Weapon (WIP)";
    this.WeaponEffectBtn.UseVisualStyleBackColor = true;
    this.WeaponEffectBtn.Click += new EventHandler(this.WeaponEffectBtn_Click);
    this.STRCrit.AutoSize = true;
    this.STRCrit.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.STRCrit.Location = new Point(137, 460);
    this.STRCrit.Name = "STRCrit";
    this.STRCrit.RightToLeft = RightToLeft.Yes;
    this.STRCrit.Size = new Size(78, 16 /*0x10*/);
    this.STRCrit.TabIndex = 199;
    this.STRCrit.Text = "STR Weapon";
    this.STRCrit.TextAlign = ContentAlignment.MiddleCenter;
    this.STRCrit.UseVisualStyleBackColor = true;
    this.STRCrit.CheckedChanged += new EventHandler(this.STRCrit_CheckedChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(371, 531);
    this.Controls.Add((Control) this.STRCrit);
    this.Controls.Add((Control) this.WeaponEffectBtn);
    this.Controls.Add((Control) this.label22);
    this.Controls.Add((Control) this.UpgradeLevelNUM);
    this.Controls.Add((Control) this.TagVisibleCheck);
    this.Controls.Add((Control) this.Tag3Label);
    this.Controls.Add((Control) this.Tag2Label);
    this.Controls.Add((Control) this.Tag1Label);
    this.Controls.Add((Control) this.AutoCheck);
    this.Controls.Add((Control) this.LockWPNE);
    this.Controls.Add((Control) this.MutationLabel);
    this.Controls.Add((Control) this.label20);
    this.Controls.Add((Control) this.WeaponBox);
    this.Controls.Add((Control) this.RifleBox);
    this.Controls.Add((Control) this.GunBox);
    this.Controls.Add((Control) this.label19);
    this.Controls.Add((Control) this.Rarity);
    this.Controls.Add((Control) this.label18);
    this.Controls.Add((Control) this.EnchantBox);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.WeaponPart3Box);
    this.Controls.Add((Control) this.label16);
    this.Controls.Add((Control) this.WeaponPart2Box);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.WeaponPart1Box);
    this.Controls.Add((Control) this.SentimentBox);
    this.Controls.Add((Control) this.WeightMinusBox);
    this.Controls.Add((Control) this.WeightPlusBox);
    this.Controls.Add((Control) this.WeightLabel);
    this.Controls.Add((Control) this.label15);
    this.Controls.Add((Control) this.CriticalQuality);
    this.Controls.Add((Control) this.AccuracyQuality);
    this.Controls.Add((Control) this.PowerQuality);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.MaterialBox);
    this.Controls.Add((Control) this.CritDmgLabel);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.CritModLabel);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.CritModBox);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.TwoHandBox);
    this.Controls.Add((Control) this.CritLabel);
    this.Controls.Add((Control) this.HitLabel);
    this.Controls.Add((Control) this.SWALabel);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.WeightBox);
    this.Controls.Add((Control) this.CriticalBox);
    this.Controls.Add((Control) this.AccuracyBox);
    this.Controls.Add((Control) this.PowerBox);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.AptitudeNameLabel);
    this.Controls.Add((Control) this.SanctityNameLabel);
    this.Controls.Add((Control) this.GuileNameLabel);
    this.Controls.Add((Control) this.LuckNameLabel);
    this.Controls.Add((Control) this.FaithNameLabel);
    this.Controls.Add((Control) this.VitalityNameLabel);
    this.Controls.Add((Control) this.ResistanceNameLabel);
    this.Controls.Add((Control) this.DefenseNameLabel);
    this.Controls.Add((Control) this.CelerityNameLabel);
    this.Controls.Add((Control) this.SkillNameLabel);
    this.Controls.Add((Control) this.WillNameLabel);
    this.Controls.Add((Control) this.StrengthNameLabel);
    this.Controls.Add((Control) this.AptitudeBox);
    this.Controls.Add((Control) this.SanctityBox);
    this.Controls.Add((Control) this.GuileBox);
    this.Controls.Add((Control) this.LuckBox);
    this.Controls.Add((Control) this.FaithBox);
    this.Controls.Add((Control) this.VitalityBox);
    this.Controls.Add((Control) this.ResistanceBox);
    this.Controls.Add((Control) this.DefenseBox);
    this.Controls.Add((Control) this.CelerityBox);
    this.Controls.Add((Control) this.SkillBox);
    this.Controls.Add((Control) this.WillBox);
    this.Controls.Add((Control) this.StrengthBox);
    this.Name = nameof (WeaponCalculator);
    this.Text = "Weapon Calculations";
    this.FormClosing += new FormClosingEventHandler(this.WeaponCalculator_FormClosing);
    this.Load += new EventHandler(this.WeaponCalculator_Load);
    this.AptitudeBox.EndInit();
    this.SanctityBox.EndInit();
    this.GuileBox.EndInit();
    this.LuckBox.EndInit();
    this.FaithBox.EndInit();
    this.VitalityBox.EndInit();
    this.ResistanceBox.EndInit();
    this.DefenseBox.EndInit();
    this.CelerityBox.EndInit();
    this.SkillBox.EndInit();
    this.WillBox.EndInit();
    this.StrengthBox.EndInit();
    this.WeightBox.EndInit();
    this.CriticalBox.EndInit();
    this.AccuracyBox.EndInit();
    this.PowerBox.EndInit();
    this.TwoHandBox.EndInit();
    this.CritModBox.EndInit();
    this.Rarity.EndInit();
    this.UpgradeLevelNUM.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
