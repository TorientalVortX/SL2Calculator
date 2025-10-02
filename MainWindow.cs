// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.MainWindow
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using SL2_Reckoning_Calculator.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace SL2_Reckoning_Calculator;

public class MainWindow : Form
{
  private int MonoclassModifier = 1;
  private double GiantGeneModifier = 1.0;
  private double EnduranceModifier = 1.0;
  private int FortitudeValue;
  private int PainTolValue;
  private int WarwalkValue;
  private int DragonKingPieces;
  private int DragonQueenPieces;
  private int MaxHP;
  private int CurrentHP;
  private int MaxMP;
  private int RacialStrength;
  private int RacialWill;
  private int RacialSkill;
  private int RacialCelerity;
  private int RacialDefense;
  private int RacialResistance;
  private int RacialVitality;
  private int RacialFaith;
  private int RacialLuck;
  private int RacialGuile;
  private int RacialSanctity;
  private int RacialAptitude;
  private int SubRacialStrength;
  private int SubRacialWill;
  private int SubRacialSkill;
  private int SubRacialCelerity;
  private int SubRacialDefense;
  private int SubRacialResistance;
  private int SubRacialVitality;
  private int SubRacialFaith;
  private int SubRacialLuck;
  private int SubRacialGuile;
  private int SubRacialSanctity;
  private int SubRacialAptitude;
  private int AddedStrength;
  private int AddedWill;
  private int AddedSkill;
  private int AddedCelerity;
  private int AddedDefense;
  private int AddedResistance;
  private int AddedVitality;
  private int AddedFaith;
  private int AddedLuck;
  private int AddedGuile;
  private int AddedSanctity;
  private int AddedAptitude;
  private int ClassStrength;
  private int ClassWill;
  private int ClassSkill;
  private int ClassCelerity;
  private int ClassDefense;
  private int ClassResistance;
  private int ClassVitality;
  private int ClassFaith;
  private int ClassLuck;
  private int ClassGuile;
  private int ClassSanctity;
  private int ClassAptitude;
  private double EffectiveStrength;
  private double EffectiveWill;
  private double EffectiveSkill;
  private double EffectiveCelerity;
  private double EffectiveDefense;
  private double EffectiveResistance;
  private double EffectiveVitality;
  private double EffectiveFaith;
  private double EffectiveLuck;
  private double EffectiveGuile;
  private double EffectiveSanctity;
  private double EffectiveAptitude;
  private int CustomStrength;
  private int CustomWill;
  private int CustomSkill;
  private int CustomCelerity;
  private int CustomDefense;
  private int CustomResistance;
  private int CustomVitality;
  private int CustomFaith;
  private int CustomLuck;
  private int CustomGuile;
  private int CustomSanctity;
  private int CustomAptitude;
  private int CustomBaseStrength;
  private int CustomBaseWill;
  private int CustomBaseSkill;
  private int CustomBaseCelerity;
  private int CustomBaseDefense;
  private int CustomBaseResistance;
  private int CustomBaseVitality;
  private int CustomBaseFaith;
  private int CustomBaseLuck;
  private int CustomBaseGuile;
  private int CustomBaseSanctity;
  private int CustomBaseAptitude;
  private bool AxysAlToggle;
  private bool KashIcToggle;
  private bool RabeUrToggle;
  private bool ZeroGyToggle;
  private bool GrenUtToggle;
  private bool ChoiErToggle;
  private bool BldiIaToggle;
  private bool HolyMrToggle;
  private bool KagiJiToggle;
  private bool LunaCuToggle;
  private bool AkurZoToggle;
  private bool AllLEButtonToggle;
  private int AxysAlBonus;
  private int KashIcBonus;
  private int RabeUrBonus;
  private int ZeroGyBonus;
  private int GrenUtBonus;
  private int ChoiErBonus;
  private int BldiIaBonus;
  private int HolyMrBonus;
  private int KagiJiBonus;
  private int LunaCuBonus;
  private int AkurZoBonus;
  private AstrologyWindow AstrologyForm;
  private WeaponCalculator WeaponForm;
  private WeaponCalculator WeaponForm2;
  private WeaponCalculator WeaponForm3;
  private WeaponCalculator WeaponForm4;
  private ReductionWindow ReductionForm;
  private StampWindow StampsForm;
  private PrintWindow PrintForm;
  private byte WeaponCalculatorOpen;
  private byte ReductionWindowOpen;
  private byte DamageWindowOpen;
  private bool AstrologyWindowOpen;
  private bool StampsWindowOpen;
  public bool PrintWindowOpen;
  private int TraitStrength;
  private int TraitWill;
  private int TraitSkill;
  private int TraitCelerity;
  private int TraitDefense;
  private int TraitResistance;
  private int TraitVitality;
  private int TraitFaith;
  private int TraitLuck;
  private int StampStrength;
  private int StampWill;
  private int StampSkill;
  private int StampCelerity;
  private int StampVitality;
  private int StampFaith;
  private int StampWater;
  private int StampEarth;
  private int StampLight;
  private int StampDark;
  private static int MaxPoints = 240 /*0xF0*/;
  private static int AptitudeNumber = 6;
  private int AptitudeBonus;
  private int TotalPoints;
  private int AstrologyMercury;
  private int AstrologyVenus;
  private int AstrologyMars;
  private int AstrologyJupiter;
  private int AstrologySaturn;
  private int AstrologyNeptune;
  private int AstrologyUranus;
  private int AstrologyPluto;
  private double Instinct;
  private int InstinctSTR;
  private int InstinctSKI;
  private int InstinctWIL;
  private int InstinctLUC;
  private int InstinctDEF;
  private int InstinctRES;
  private int InstinctGUI;
  private int InstinctCEL;
  private double RisingGame;
  private int RisingGameSTR;
  private int RisingGameSKI;
  private int RisingGameWIL;
  private int RisingGameLUC;
  private int RisingGameRES;
  private int RisingGameCEL;
  private string RaceBoxValue;
  private int MainClassPSTR;
  private int MainClassPWIL;
  private int MainClassPSKI;
  private int MainClassPCEL;
  private int MainClassPDEF;
  private int MainClassPRES;
  private int MainClassPFAI;
  private int MainClassPLUC;
  private int MainClassPGUI;
  private int MainClassPSAN;
  private int SubClassPSTR;
  private int SubClassPWIL;
  private int SubClassPSKI;
  private int SubClassPCEL;
  private int SubClassPDEF;
  private int SubClassPRES;
  private int SubClassPFAI;
  private int SubClassPLUC;
  private int SubClassPGUI;
  private int SubClassPSAN;
  private string MainClass;
  private string SubClass;
  private bool Homunculi;
  private bool Human;
  private bool Subrace;
  public bool dark;
  private int HistoryStrength;
  private int HistoryWill;
  private int HistorySkill;
  private int HistoryCelerity;
  private int HistoryDefense;
  private int HistoryResistance;
  private int HistoryVitality;
  private int HistoryFaith;
  private int HistoryLuck;
  private string HistoryString;
  private int FoodSTR;
  private int FoodWIL;
  private int FoodSKI;
  private int FoodCEL;
  private int FoodVIT;
  private double ExtraBaseEvade;
  private double StatEvade;
  private double EvadeCap;
  private double TotalEvade;
  private double ExtraCritEvade;
  private double BaseCritEvade;
  private int SanguineCrest;
  private IContainer components;
  private Label StrengthNameLabel;
  private Label WillNameLabel;
  private Label SkillNameLabel;
  private Label CelerityNameLabel;
  private Label DefenseNameLabel;
  private Label ResistanceNameLabel;
  private Label VitalityNameLabel;
  private Label FaithNameLabel;
  private Label LuckNameLabel;
  private Label GuileNameLabel;
  private Label SanctityNameLabel;
  private Label AptitudeNameLabel;
  private Label StrengthLabel;
  private Label WillLabel;
  private Label SkillLabel;
  private Label CelerityLabel;
  private Label DefenseLabel;
  private Label ResistanceLabel;
  private Label VitalityLabel;
  private Label FaithLabel;
  private Label LuckLabel;
  private Label GuileLabel;
  private Label SanctityLabel;
  private Label AptitudeLabel;
  private Label TotalPointsLabel;
  private ComboBox ClassBox;
  private ComboBox RaceBox;
  private Button StrengthPlus;
  private Label ClassLabel;
  private Label RaceLabel;
  private Button WillPlus;
  private Button SkillPlus;
  private Button CelerityPlus;
  private Button DefensePlus;
  private Button ResistancePlus;
  private Button VitalityPlus;
  private Button FaithPlus;
  private Button LuckPlus;
  private Button GuilePlus;
  private Button SanctityPlus;
  private Button AptitudePlus;
  private Button AptitudeMinus;
  private Button SanctityMinus;
  private Button GuileMinus;
  private Button LuckMinus;
  private Button FaithMinus;
  private Button VitalityMinus;
  private Button ResistanceMinus;
  private Button DefenseMinus;
  private Button CelerityMinus;
  private Button SkillMinus;
  private Button WillMinus;
  private Button StrengthMinus;
  private Button ResetButton;
  private ToolTip Tooltip;
  private PictureBox AxysAlButton;
  private PictureBox BldiIaButton;
  private PictureBox ChoiErButton;
  private PictureBox GrenUtButton;
  private PictureBox HolyMrButton;
  private PictureBox KagiJiButton;
  private PictureBox ZeroGyButton;
  private PictureBox RabeUrButton;
  private PictureBox KashIcButton;
  private Label VersionLabel;
  private NumericUpDown CustomStrengthBox;
  private NumericUpDown CustomWillBox;
  private NumericUpDown CustomSkillBox;
  private NumericUpDown CustomCelerityBox;
  private NumericUpDown CustomDefenseBox;
  private NumericUpDown CustomResistanceBox;
  private NumericUpDown CustomVitalityBox;
  private NumericUpDown CustomFaithBox;
  private NumericUpDown CustomLuckBox;
  private NumericUpDown CustomGuileBox;
  private NumericUpDown CustomSanctityBox;
  private NumericUpDown CustomAptitudeBox;
  private Label CustomLabel;
  private Label HPLabel;
  private Label MPLabel;
  private Button DebugDRButton;
  private Label PhysDefLabel;
  private Label MagDefLabel;
  private Label EvadeLabel;
  private Label CritEvadeLabel;
  private Label StatusInflictLabel;
  private Label StatusResistLabel;
  private Label FlankingLabel;
  private Label SkillPoolLabel;
  private Label EncumbranceLabel;
  private Label BattleWeightLabel;
  private Button WeaponButton;
  private PictureBox LunaCuButton;
  private PictureBox AkurZoButton;
  private Label BaseLabel;
  private NumericUpDown CustomBaseAptitudeBox;
  private NumericUpDown CustomBaseSanctityBox;
  private NumericUpDown CustomBaseGuileBox;
  private NumericUpDown CustomBaseLuckBox;
  private NumericUpDown CustomBaseFaithBox;
  private NumericUpDown CustomBaseVitalityBox;
  private NumericUpDown CustomBaseResistanceBox;
  private NumericUpDown CustomBaseDefenseBox;
  private NumericUpDown CustomBaseCelerityBox;
  private NumericUpDown CustomBaseSkillBox;
  private NumericUpDown CustomBaseWillBox;
  private NumericUpDown CustomBaseStrengthBox;
  private Label label7;
  private NumericUpDown CustomHPBox;
  private NumericUpDown CustomMPBox;
  private Label label8;
  private CheckBox GiantGeneCheckBox;
  private Button AstrologyButton;
  private Label ElemATKLabel;
  private Label SoundATKLabel;
  private Label AcidATKLabel;
  private Label LightningATKLabel;
  private Label LightATKLabel;
  private Label WaterATKLabel;
  private Label DarkATKLabel;
  private Label EarthATKLabel;
  private Label WindATKLabel;
  private Label IceATKLabel;
  private Label FireATKLabel;
  private PictureBox pictureBox1;
  private Button PrintButton;
  private NumericUpDown DragonKingBox;
  private Label DragonKingLabel;
  private Label SoundRESLabel;
  private Label AcidRESLabel;
  private Label LightningRESLabel;
  private Label LightRESLabel;
  private Label WaterRESLabel;
  private Label DarkRESLabel;
  private Label EarthRESLabel;
  private Label WindRESLabel;
  private Label IceRESLabel;
  private Label FireRESLabel;
  private Label label17;
  private Button StampsButton;
  private NumericUpDown CustomSoundATKBox;
  private NumericUpDown CustomAcidATKBox;
  private NumericUpDown CustomLightningATKBox;
  private NumericUpDown CustomLightATKBox;
  private NumericUpDown CustomWaterATKBox;
  private NumericUpDown CustomDarkATKBox;
  private NumericUpDown CustomEarthATKBox;
  private NumericUpDown CustomWindATKBox;
  private NumericUpDown CustomIceATKBox;
  private NumericUpDown CustomFireATKBox;
  private NumericUpDown CustomSoundRESBox;
  private NumericUpDown CustomAcidRESBox;
  private NumericUpDown CustomLightningRESBox;
  private NumericUpDown CustomLightRESBox;
  private NumericUpDown CustomWaterRESBox;
  private NumericUpDown CustomDarkRESBox;
  private NumericUpDown CustomEarthRESBox;
  private NumericUpDown CustomWindRESBox;
  private NumericUpDown CustomIceRESBox;
  private NumericUpDown CustomFireRESBox;
  private Label label4;
  private NumericUpDown HPPercent;
  private CheckBox EnduranceBox;
  private Button ReductionButton;
  private NumericUpDown RisingNumeric;
  private Label RisingLabel;
  private NumericUpDown TotalHPPercent;
  private Label label6;
  private Label InitativeLabel;
  private CheckBox LuminaryBox;
  private CheckBox Fortitude;
  private Label PainTolLabel;
  private NumericUpDown PainTol;
  private CheckBox Warwalk;
  private Label Youkai;
  private Label label2;
  private ComboBox SubClassBox;
  private CheckBox SanguineCrestBox;
  private Label Essence;
  private CheckBox GrimalkinI;
  private Label MainClassPassive;
  private NumericUpDown MainClassNum;
  private Label SubClassPassive;
  private NumericUpDown SubClassNum;
  private ComboBox FoodBox;
  private Label label10;
  private PictureBox AllLEButton;
  private NumericUpDown KorvaraFP;
  private Label label3;
  private NumericUpDown KorvaraHP;
  private Label label11;
  private Label DateLabel;
  private Label label9;
  private NumericUpDown DragonQueenBox;
  private Button button1;
  private ComboBox HistoryListBox;
  private Button EquipBTN;
  private ComboBox SubraceBox;

  public MainWindow()
  {
    this.InitializeComponent();
    this.InitializeCalculator();
    this.VersionLabel.Text = "Version 1.19";
    this.DateLabel.Text = "24/07/25 DD/MM/YY";
    this.HistoryListBox.SelectedIndex = 0;
  }

  private void InitializeCalculator()
  {
    this.TotalPoints = MainWindow.MaxPoints;
    this.MaxHP = 0;
    this.CurrentHP = 0;
    this.MaxMP = 0;
    this.AddedStrength = 0;
    this.AddedWill = 0;
    this.AddedSkill = 0;
    this.AddedCelerity = 0;
    this.AddedDefense = 0;
    this.AddedResistance = 0;
    this.AddedVitality = 0;
    this.AddedFaith = 0;
    this.AddedLuck = 0;
    this.AddedGuile = 0;
    this.AddedSanctity = 0;
    this.AddedAptitude = 0;
    this.CustomStrength = 0;
    this.CustomWill = 0;
    this.CustomSkill = 0;
    this.CustomCelerity = 0;
    this.CustomDefense = 0;
    this.CustomResistance = 0;
    this.CustomVitality = 0;
    this.CustomFaith = 0;
    this.CustomLuck = 0;
    this.CustomGuile = 0;
    this.CustomSanctity = 0;
    this.CustomAptitude = 0;
    this.CustomStrengthBox.Value = 0M;
    this.CustomWillBox.Value = 0M;
    this.CustomSkillBox.Value = 0M;
    this.CustomCelerityBox.Value = 0M;
    this.CustomDefenseBox.Value = 0M;
    this.CustomResistanceBox.Value = 0M;
    this.CustomVitalityBox.Value = 0M;
    this.CustomFaithBox.Value = 0M;
    this.CustomLuckBox.Value = 0M;
    this.CustomGuileBox.Value = 0M;
    this.CustomSanctityBox.Value = 0M;
    this.CustomAptitudeBox.Value = 0M;
    this.CustomBaseStrength = 0;
    this.CustomBaseWill = 0;
    this.CustomBaseSkill = 0;
    this.CustomBaseCelerity = 0;
    this.CustomBaseDefense = 0;
    this.CustomBaseResistance = 0;
    this.CustomBaseVitality = 0;
    this.CustomBaseFaith = 0;
    this.CustomBaseLuck = 0;
    this.CustomBaseGuile = 0;
    this.CustomBaseSanctity = 0;
    this.CustomBaseAptitude = 0;
    this.CustomBaseStrengthBox.Value = 0M;
    this.CustomBaseWillBox.Value = 0M;
    this.CustomBaseSkillBox.Value = 0M;
    this.CustomBaseCelerityBox.Value = 0M;
    this.CustomBaseDefenseBox.Value = 0M;
    this.CustomBaseResistanceBox.Value = 0M;
    this.CustomBaseVitalityBox.Value = 0M;
    this.CustomBaseFaithBox.Value = 0M;
    this.CustomBaseLuckBox.Value = 0M;
    this.CustomBaseGuileBox.Value = 0M;
    this.CustomBaseSanctityBox.Value = 0M;
    this.CustomBaseAptitudeBox.Value = 0M;
    this.CustomMPBox.Value = 0M;
    this.CustomHPBox.Value = 0M;
    this.GiantGeneCheckBox.Checked = false;
    this.EnduranceBox.Checked = false;
    this.DragonKingBox.Value = 0M;
    this.HPPercent.Value = 100M;
    this.SetNoSign();
    this.UpdateNumbers();
  }

  private bool CheckAddition() => this.TotalPoints > 0;

  private bool CheckSubtraction(int AddedStat) => AddedStat > 0;

  private void UpdateNumbers()
  {
    this.DiminishingReturns();
    this.StrengthLabel.Text = ((int) ((double) (this.RacialStrength + this.SubRacialStrength + this.CustomBaseStrength + this.AstrologyMars + this.AddedStrength + this.ClassStrength * this.MonoclassModifier + this.CustomStrength + this.AptitudeBonus + this.StampStrength + this.RisingGameSTR + this.InstinctSTR + this.SanguineCrest + this.FoodSTR + this.MainClassPSTR + this.SubClassPSTR) * (1.0 + 0.05 * (double) this.DragonKingPieces))).ToString();
    this.WillLabel.Text = ((int) ((double) (this.RacialWill + this.SubRacialWill + this.CustomBaseWill + this.AddedWill + this.ClassWill * this.MonoclassModifier + this.CustomWill + this.AptitudeBonus + this.StampWill + this.RisingGameWIL + this.InstinctWIL + this.FoodWIL + this.SanguineCrest + this.MainClassPWIL + this.SubClassPWIL) * (1.0 + 0.05 * (double) this.DragonQueenPieces))).ToString();
    this.SkillLabel.Text = (this.RacialSkill + this.SubRacialSkill + this.CustomBaseSkill + this.AstrologyMercury + this.AddedSkill + this.ClassSkill * this.MonoclassModifier + this.CustomSkill + this.RisingGameSKI + this.AptitudeBonus + this.StampSkill + this.InstinctSKI + this.FoodSKI + this.SanguineCrest + this.MainClassPSKI + this.SubClassPSKI).ToString();
    this.CelerityLabel.Text = (this.RacialCelerity + this.SubRacialCelerity + this.CustomBaseCelerity + this.AstrologySaturn + this.AddedCelerity + this.ClassCelerity * this.MonoclassModifier + this.CustomCelerity + this.AptitudeBonus + this.RisingGameCEL + this.StampCelerity + this.InstinctCEL + this.FoodCEL + this.SanguineCrest + this.MainClassPCEL + this.SubClassPCEL).ToString();
    this.DefenseLabel.Text = (this.RacialDefense + this.SubRacialDefense + this.CustomBaseDefense + this.AstrologyVenus + this.AddedDefense + this.ClassDefense * this.MonoclassModifier + this.CustomDefense + this.AptitudeBonus + this.InstinctDEF + this.SanguineCrest + this.MainClassPDEF + this.SubClassPDEF).ToString();
    this.ResistanceLabel.Text = (this.RacialResistance + this.SubRacialResistance + this.CustomBaseResistance + this.AstrologyPluto + this.AddedResistance + this.ClassResistance * this.MonoclassModifier + this.CustomResistance + this.RisingGameRES + this.AptitudeBonus + this.InstinctRES + this.MainClassPRES + this.SubClassPRES).ToString();
    this.VitalityLabel.Text = (this.RacialVitality + this.SubRacialVitality + this.CustomBaseVitality + this.AstrologyNeptune + this.AddedVitality + this.ClassVitality * this.MonoclassModifier + this.CustomVitality + this.AptitudeBonus + this.StampVitality + this.FoodVIT).ToString();
    this.FaithLabel.Text = (this.RacialFaith + this.SubRacialFaith + this.CustomBaseFaith + this.AstrologyUranus + this.AddedFaith + this.ClassFaith * this.MonoclassModifier + this.CustomFaith + this.AptitudeBonus + this.StampFaith + this.MainClassPFAI + this.SubClassPFAI).ToString();
    this.LuckLabel.Text = (this.RacialLuck + this.SubRacialLuck + this.CustomBaseLuck + this.AstrologyJupiter + this.AddedLuck + this.ClassLuck * this.MonoclassModifier + this.CustomLuck + this.AptitudeBonus + this.RisingGameLUC + this.InstinctLUC + this.MainClassPLUC + this.SubClassPLUC).ToString();
    this.GuileLabel.Text = (this.RacialGuile + this.SubRacialGuile + this.CustomBaseGuile + this.AddedGuile + this.ClassGuile * this.MonoclassModifier + this.CustomGuile + this.AptitudeBonus + this.InstinctGUI + this.MainClassPGUI + this.SubClassPGUI).ToString();
    this.SanctityLabel.Text = (this.RacialSanctity + this.SubRacialSanctity + this.CustomBaseSanctity + this.AddedSanctity + this.ClassSanctity * this.MonoclassModifier + this.CustomSanctity + this.AptitudeBonus + this.MainClassPSAN + this.SubClassPSAN).ToString();
    this.AptitudeLabel.Text = (this.RacialAptitude + this.SubRacialAptitude + this.CustomBaseAptitude + this.AddedAptitude + this.CustomAptitude).ToString();
    ToolTip tooltip1 = this.Tooltip;
    Label strengthNameLabel = this.StrengthNameLabel;
    int num1 = this.CustomBaseStrength + this.RacialStrength + this.SubRacialStrength;
    string str1 = num1.ToString();
    num1 = this.AstrologyMars + this.AddedStrength;
    string str2 = num1.ToString();
    string caption1 = $"{str1} + {str2}";
    tooltip1.SetToolTip((Control) strengthNameLabel, caption1);
    this.Tooltip.SetToolTip((Control) this.WillNameLabel, $"{(this.CustomBaseWill + this.RacialWill + this.SubRacialWill).ToString()} + {this.AddedWill.ToString()}");
    ToolTip tooltip2 = this.Tooltip;
    Label skillNameLabel = this.SkillNameLabel;
    int num2 = this.CustomBaseSkill + this.RacialSkill + this.SubRacialSkill;
    string str3 = num2.ToString();
    num2 = this.AstrologyMercury + this.AddedSkill;
    string str4 = num2.ToString();
    string caption2 = $"{str3} + {str4}";
    tooltip2.SetToolTip((Control) skillNameLabel, caption2);
    ToolTip tooltip3 = this.Tooltip;
    Label celerityNameLabel = this.CelerityNameLabel;
    int num3 = this.CustomBaseCelerity + this.RacialCelerity + this.SubRacialCelerity;
    string str5 = num3.ToString();
    num3 = this.AstrologySaturn + this.AddedCelerity;
    string str6 = num3.ToString();
    string caption3 = $"{str5} + {str6}";
    tooltip3.SetToolTip((Control) celerityNameLabel, caption3);
    ToolTip tooltip4 = this.Tooltip;
    Label defenseNameLabel = this.DefenseNameLabel;
    int num4 = this.CustomBaseDefense + this.RacialDefense + this.SubRacialDefense;
    string str7 = num4.ToString();
    num4 = this.AstrologyVenus + this.AddedDefense;
    string str8 = num4.ToString();
    string caption4 = $"{str7} + {str8}";
    tooltip4.SetToolTip((Control) defenseNameLabel, caption4);
    ToolTip tooltip5 = this.Tooltip;
    Label resistanceNameLabel = this.ResistanceNameLabel;
    int num5 = this.CustomBaseResistance + this.RacialResistance + this.SubRacialResistance;
    string str9 = num5.ToString();
    num5 = this.AstrologyPluto + this.AddedResistance;
    string str10 = num5.ToString();
    string caption5 = $"{str9} + {str10}";
    tooltip5.SetToolTip((Control) resistanceNameLabel, caption5);
    ToolTip tooltip6 = this.Tooltip;
    Label vitalityNameLabel = this.VitalityNameLabel;
    int num6 = this.CustomBaseVitality + this.RacialVitality + this.SubRacialVitality;
    string str11 = num6.ToString();
    num6 = this.AstrologyNeptune + this.AddedVitality;
    string str12 = num6.ToString();
    string caption6 = $"{str11} + {str12}";
    tooltip6.SetToolTip((Control) vitalityNameLabel, caption6);
    ToolTip tooltip7 = this.Tooltip;
    Label faithNameLabel = this.FaithNameLabel;
    int num7 = this.CustomBaseFaith + this.RacialFaith + this.SubRacialFaith;
    string str13 = num7.ToString();
    num7 = this.AstrologyUranus + this.AddedFaith;
    string str14 = num7.ToString();
    string caption7 = $"{str13} + {str14}";
    tooltip7.SetToolTip((Control) faithNameLabel, caption7);
    ToolTip tooltip8 = this.Tooltip;
    Label luckNameLabel = this.LuckNameLabel;
    int num8 = this.CustomBaseLuck + this.RacialLuck + this.SubRacialLuck;
    string str15 = num8.ToString();
    num8 = this.AstrologyJupiter + this.AddedLuck;
    string str16 = num8.ToString();
    string caption8 = $"{str15} + {str16}";
    tooltip8.SetToolTip((Control) luckNameLabel, caption8);
    this.Tooltip.SetToolTip((Control) this.GuileNameLabel, $"{(this.CustomBaseGuile + this.RacialGuile + this.SubRacialGuile).ToString()} + {this.AddedGuile.ToString()}");
    this.Tooltip.SetToolTip((Control) this.SanctityNameLabel, $"{(this.CustomBaseSanctity + this.RacialSanctity + this.SubRacialSanctity).ToString()} + {this.AddedSanctity.ToString()}");
    this.Tooltip.SetToolTip((Control) this.AptitudeNameLabel, $"{(this.CustomBaseAptitude + this.RacialAptitude + this.SubRacialAptitude).ToString()} + {this.AddedAptitude.ToString()}");
    this.Tooltip.SetToolTip((Control) this.StrengthLabel, this.EffectiveStrength.ToString());
    this.Tooltip.SetToolTip((Control) this.WillLabel, this.EffectiveWill.ToString());
    this.Tooltip.SetToolTip((Control) this.SkillLabel, this.EffectiveSkill.ToString());
    this.Tooltip.SetToolTip((Control) this.CelerityLabel, this.EffectiveCelerity.ToString());
    this.Tooltip.SetToolTip((Control) this.DefenseLabel, this.EffectiveDefense.ToString());
    this.Tooltip.SetToolTip((Control) this.ResistanceLabel, this.EffectiveResistance.ToString());
    this.Tooltip.SetToolTip((Control) this.VitalityLabel, this.EffectiveVitality.ToString());
    this.Tooltip.SetToolTip((Control) this.FaithLabel, this.EffectiveFaith.ToString());
    this.Tooltip.SetToolTip((Control) this.LuckLabel, this.EffectiveLuck.ToString());
    this.Tooltip.SetToolTip((Control) this.GuileLabel, this.EffectiveGuile.ToString());
    this.Tooltip.SetToolTip((Control) this.SanctityLabel, this.EffectiveSanctity.ToString());
    this.Tooltip.SetToolTip((Control) this.AptitudeLabel, this.EffectiveAptitude.ToString());
    this.CalculateHP();
    this.CalculateMP();
    if (this.RaceBoxValue == "Lich")
      this.MagiaDetremus();
    this.HPLabel.Text = $"HP: {this.CurrentHP.ToString()}/{this.MaxHP.ToString()}";
    this.MPLabel.Text = $"FP: {this.MaxMP.ToString()}/{this.MaxMP.ToString()}";
    this.PhysDefLabel.Text = $"Phys. {Math.Floor(this.EffectiveDefense * 0.9).ToString()}%";
    this.MagDefLabel.Text = $"Mag. Def {Math.Floor(this.EffectiveResistance * 0.9).ToString()}%";
    this.StatEvade = Math.Floor(this.EffectiveCelerity * 2.0);
    if (this.GiantGeneCheckBox.Checked)
      this.StatEvade -= 10.0;
    this.TotalEvade = this.StatEvade + this.ExtraBaseEvade;
    this.EvadeCap = this.TotalEvade + 50.0;
    this.EvadeLabel.Text = $"Evade {this.StatEvade.ToString()}+{this.ExtraBaseEvade.ToString()} ({this.EvadeCap.ToString()})";
    this.BaseCritEvade = Math.Floor(this.EffectiveFaith + this.EffectiveLuck);
    this.CritEvadeLabel.Text = $"Crit Evade {this.BaseCritEvade.ToString()}+{this.ExtraCritEvade.ToString()} ({(this.BaseCritEvade + this.ExtraCritEvade).ToString()})";
    this.StatusInflictLabel.Text = $"Status Inflict {Math.Floor(this.EffectiveSkill * 2.0 + this.EffectiveWill).ToString()}%";
    this.StatusResistLabel.Text = $"Status Resist {Math.Floor(this.EffectiveSanctity * 2.0 + this.EffectiveFaith).ToString()}%";
    this.InitativeLabel.Text = "Initative " + (this.RacialCelerity + this.AstrologySaturn + this.AddedCelerity + this.CustomBaseCelerity).ToString();
    this.Youkai.Text = "Youkai Cap " + ((double) ((int) Math.Floor((double) (this.RacialFaith + this.AstrologyUranus + this.AddedFaith + this.CustomBaseFaith) / 5.0) + 5)).ToString();
    Label flankingLabel = this.FlankingLabel;
    double num9 = Math.Floor(5.0 + this.EffectiveGuile / 2.0);
    string str17 = "Flanking " + num9.ToString();
    flankingLabel.Text = str17;
    this.SkillPoolLabel.Text = "Skill Pool " + this.CalculateSkillPool().ToString();
    Label essence = this.Essence;
    num9 = Math.Floor(this.EffectiveSanctity * 2.0 + 100.0);
    string str18 = "Essence " + num9.ToString();
    essence.Text = str18;
    int num10 = (int) this.EffectiveStrength + 5;
    int num11 = (int) this.EffectiveStrength + (int) this.EffectiveVitality + 5;
    if (this.RaceBoxValue == "M-Type A" || this.RaceBoxValue == "M-Type C" || this.RaceBoxValue == "M-Type R" || this.RaceBoxValue == "M-Type S")
      num11 += 20;
    else if (this.RaceBoxValue == "Dullahan")
    {
      num11 += 30;
      num10 += 100;
    }
    this.BattleWeightLabel.Text = "BW 0/" + num10.ToString();
    this.EncumbranceLabel.Text = "Encumbrance 0/" + num11.ToString();
    this.TotalPointsLabel.Text = this.TotalPoints.ToString() + " Points Remaining";
    if (this.PrintWindowOpen)
      this.PrintUpdate();
    if (this.WeaponCalculatorOpen >= (byte) 1)
      this.WeaponForm.UpdateSelf();
    if (this.WeaponCalculatorOpen >= (byte) 2)
      this.WeaponForm2.UpdateSelf();
    if (this.WeaponCalculatorOpen >= (byte) 3)
      this.WeaponForm3.UpdateSelf();
    if (this.WeaponCalculatorOpen >= (byte) 4)
      this.WeaponForm4.UpdateSelf();
    if (this.ReductionWindowOpen >= (byte) 1)
    {
      this.ReductionForm.UpdateStats("DEF");
      this.ReductionForm.UpdateStats("RES");
      this.ReductionForm.UpdateStats("GUI");
      this.ReductionForm.UpdateDamage("Total Power");
    }
    int int32 = Convert.ToInt32(this.WillLabel.Text);
    int num12;
    if (!this.LuminaryBox.Checked)
    {
      this.FireATKLabel.Text = ((int) this.EffectiveStrength + (int) this.EffectiveWill / 4 + this.AstrologyMars * 2 + (int) this.CustomFireATKBox.Value).ToString();
      this.IceATKLabel.Text = ((int) this.EffectiveSkill + (int) this.EffectiveWill / 4 + this.AstrologyMercury * 2 + (int) this.CustomIceATKBox.Value).ToString();
      this.WindATKLabel.Text = ((int) this.EffectiveCelerity + (int) this.EffectiveWill / 4 + this.AstrologySaturn * 2 + (int) this.CustomWindATKBox.Value).ToString();
      this.EarthATKLabel.Text = ((int) this.EffectiveDefense + (int) this.EffectiveWill / 4 + this.AstrologyVenus * 2 + (int) this.CustomEarthATKBox.Value).ToString();
      this.DarkATKLabel.Text = ((int) this.EffectiveResistance + (int) this.EffectiveWill / 4 + this.AstrologyPluto * 2 + (int) this.CustomDarkATKBox.Value).ToString();
      this.WaterATKLabel.Text = ((int) this.EffectiveVitality + (int) this.EffectiveWill / 4 + this.AstrologyNeptune * 2 + (int) this.CustomWaterATKBox.Value).ToString();
      this.LightATKLabel.Text = ((int) this.EffectiveFaith + (int) this.EffectiveWill / 4 + this.AstrologyUranus * 2 + (int) this.CustomLightATKBox.Value).ToString();
      this.LightningATKLabel.Text = ((int) this.EffectiveLuck + (int) this.EffectiveWill / 4 + this.AstrologyJupiter * 2 + (int) this.CustomLightningATKBox.Value).ToString();
      this.AcidATKLabel.Text = ((int) this.EffectiveGuile + (int) this.EffectiveWill / 4 + (int) this.CustomAcidATKBox.Value).ToString();
      Label soundAtkLabel = this.SoundATKLabel;
      num12 = (int) this.EffectiveSanctity + (int) this.EffectiveWill / 4 + (int) this.CustomSoundATKBox.Value;
      string str19 = num12.ToString();
      soundAtkLabel.Text = str19;
    }
    else
    {
      this.FireATKLabel.Text = ((int) this.EffectiveStrength + this.AstrologyMars * 2 + (int) this.CustomFireATKBox.Value).ToString();
      Label iceAtkLabel1 = this.IceATKLabel;
      int num13 = (int) this.EffectiveSkill + this.AstrologyMercury * 2 + (int) this.CustomIceATKBox.Value;
      string str20 = num13.ToString();
      iceAtkLabel1.Text = str20;
      Label windAtkLabel1 = this.WindATKLabel;
      num13 = (int) this.EffectiveCelerity + this.AstrologySaturn * 2 + (int) this.CustomWindATKBox.Value;
      string str21 = num13.ToString();
      windAtkLabel1.Text = str21;
      this.EarthATKLabel.Text = ((int) this.EffectiveDefense + this.AstrologyVenus * 2 + (int) this.CustomEarthATKBox.Value).ToString();
      Label darkAtkLabel1 = this.DarkATKLabel;
      int num14 = (int) this.EffectiveResistance + this.AstrologyPluto * 2 + (int) this.CustomDarkATKBox.Value;
      string str22 = num14.ToString();
      darkAtkLabel1.Text = str22;
      Label waterAtkLabel1 = this.WaterATKLabel;
      num14 = (int) this.EffectiveVitality + this.AstrologyNeptune * 2 + (int) this.CustomWaterATKBox.Value;
      string str23 = num14.ToString();
      waterAtkLabel1.Text = str23;
      this.LightATKLabel.Text = ((int) this.EffectiveFaith + this.AstrologyUranus * 2 + (int) this.CustomLightATKBox.Value).ToString();
      Label lightningAtkLabel1 = this.LightningATKLabel;
      int num15 = (int) this.EffectiveLuck + this.AstrologyJupiter * 2 + (int) this.CustomLightningATKBox.Value;
      string str24 = num15.ToString();
      lightningAtkLabel1.Text = str24;
      Label acidAtkLabel = this.AcidATKLabel;
      num15 = (int) this.EffectiveGuile + (int) this.CustomAcidATKBox.Value;
      string str25 = num15.ToString();
      acidAtkLabel.Text = str25;
      Label soundAtkLabel = this.SoundATKLabel;
      num12 = (int) this.EffectiveSanctity + (int) this.CustomSoundATKBox.Value;
      string str26 = num12.ToString();
      soundAtkLabel.Text = str26;
      if (this.AstrologyMars == 1)
      {
        Label fireAtkLabel = this.FireATKLabel;
        num12 = int32 + this.AstrologyMars * 2 + (int) this.CustomFireATKBox.Value;
        string str27 = num12.ToString();
        fireAtkLabel.Text = str27;
      }
      if (this.AstrologyMercury == 1)
      {
        Label iceAtkLabel2 = this.IceATKLabel;
        num12 = int32 + this.AstrologyMercury * 2 + (int) this.CustomIceATKBox.Value;
        string str28 = num12.ToString();
        iceAtkLabel2.Text = str28;
      }
      if (this.AstrologySaturn == 1)
      {
        Label windAtkLabel2 = this.WindATKLabel;
        num12 = int32 + this.AstrologySaturn * 2 + (int) this.CustomWindATKBox.Value;
        string str29 = num12.ToString();
        windAtkLabel2.Text = str29;
      }
      if (this.AstrologyVenus == 1)
      {
        Label earthAtkLabel = this.EarthATKLabel;
        num12 = int32 + this.AstrologyVenus * 2 + (int) this.CustomEarthATKBox.Value;
        string str30 = num12.ToString();
        earthAtkLabel.Text = str30;
      }
      if (this.AstrologyPluto == 1)
      {
        Label darkAtkLabel2 = this.DarkATKLabel;
        num12 = int32 + this.AstrologyPluto * 2 + (int) this.CustomDarkATKBox.Value;
        string str31 = num12.ToString();
        darkAtkLabel2.Text = str31;
      }
      if (this.AstrologyNeptune == 1)
      {
        Label waterAtkLabel2 = this.WaterATKLabel;
        num12 = int32 + this.AstrologyNeptune * 2 + (int) this.CustomWaterATKBox.Value;
        string str32 = num12.ToString();
        waterAtkLabel2.Text = str32;
      }
      if (this.AstrologyUranus == 1)
      {
        Label lightAtkLabel = this.LightATKLabel;
        num12 = int32 + this.AstrologyUranus * 2 + (int) this.CustomLightATKBox.Value;
        string str33 = num12.ToString();
        lightAtkLabel.Text = str33;
      }
      if (this.AstrologyJupiter == 1)
      {
        Label lightningAtkLabel2 = this.LightningATKLabel;
        num12 = int32 + this.AstrologyJupiter * 2 + (int) this.CustomLightningATKBox.Value;
        string str34 = num12.ToString();
        lightningAtkLabel2.Text = str34;
      }
    }
    Label fireResLabel = this.FireRESLabel;
    num12 = this.FireResistance() + (int) this.CustomFireRESBox.Value;
    string str35 = num12.ToString() + "%";
    fireResLabel.Text = str35;
    Label iceResLabel = this.IceRESLabel;
    num12 = this.IceResistance() + (int) this.CustomIceRESBox.Value;
    string str36 = num12.ToString() + "%";
    iceResLabel.Text = str36;
    Label windResLabel = this.WindRESLabel;
    num12 = this.WindResistance() + (int) this.CustomWindRESBox.Value;
    string str37 = num12.ToString() + "%";
    windResLabel.Text = str37;
    Label earthResLabel = this.EarthRESLabel;
    num12 = this.EarthResistance() + (int) this.CustomEarthRESBox.Value;
    string str38 = num12.ToString() + "%";
    earthResLabel.Text = str38;
    Label darkResLabel = this.DarkRESLabel;
    num12 = this.DarkResistance() + (int) this.CustomDarkRESBox.Value;
    string str39 = num12.ToString() + "%";
    darkResLabel.Text = str39;
    Label waterResLabel = this.WaterRESLabel;
    num12 = this.WaterResistance() + (int) this.CustomWaterRESBox.Value;
    string str40 = num12.ToString() + "%";
    waterResLabel.Text = str40;
    Label lightResLabel = this.LightRESLabel;
    num12 = this.LightResistance() + (int) this.CustomLightRESBox.Value;
    string str41 = num12.ToString() + "%";
    lightResLabel.Text = str41;
    Label lightningResLabel = this.LightningRESLabel;
    num12 = this.LightningResistance() + (int) this.CustomLightningRESBox.Value;
    string str42 = num12.ToString() + "%";
    lightningResLabel.Text = str42;
    Label acidResLabel = this.AcidRESLabel;
    num12 = this.AcidResistance() + (int) this.CustomAcidRESBox.Value;
    string str43 = num12.ToString() + "%";
    acidResLabel.Text = str43;
    Label soundResLabel = this.SoundRESLabel;
    num12 = this.SoundResistance() + (int) this.CustomSoundRESBox.Value;
    string str44 = num12.ToString() + "%";
    soundResLabel.Text = str44;
  }

  public int ElementalModifier(string Element, int Mod)
  {
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(Element))
    {
      case 248996601:
        if (Element == "Fire")
          break;
        break;
      case 941306634:
        if (Element == "Darkness")
          break;
        break;
      case 1654248869:
        if (Element == "Lightning")
          break;
        break;
      case 2329082063:
        if (Element == "Light")
          break;
        break;
      case 2487303463:
        if (Element == "Wind")
          break;
        break;
      case 3016399412:
        if (Element == "Sound")
          break;
        break;
      case 3576877000:
        int num = Element == "Acid" ? 1 : 0;
        break;
      case 3580699424:
        if (Element == "Ice")
          break;
        break;
      case 3593819824:
        if (Element == "Water")
          break;
        break;
      case 4159608695:
        if (Element == "Earth")
          break;
        break;
    }
    return 1;
  }

  private void CalculateHP()
  {
    int num1 = (int) (this.EffectiveVitality * 10.0);
    if (this.Homunculi)
      num1 -= (int) this.EffectiveVitality / 2;
    int num2 = (int) (this.EffectiveSanctity * 2.0);
    int num3 = (this.AddedStrength + this.RacialStrength + this.AstrologyMars) * 3;
    int num4 = MainWindow.MaxPoints - this.TotalPoints;
    this.MaxHP = num1 + num2 + num3 + num4;
    this.MaxHP = Convert.ToInt32((double) this.MaxHP * this.GiantGeneModifier);
    this.MaxHP += Convert.ToInt32(this.CustomHPBox.Value);
    this.MaxHP += this.FortitudeValue;
    this.MaxHP += this.PainTolValue;
    this.MaxHP += this.WarwalkValue;
    this.MaxHP += (int) this.KorvaraHP.Value;
    this.MaxHP = Convert.ToInt32((double) this.MaxHP * this.EnduranceModifier);
    this.MaxHP = Convert.ToInt32(Math.Floor((double) this.MaxHP * ((double) (int) this.TotalHPPercent.Value * 0.01)));
    this.CurrentHP = Convert.ToInt32(Math.Floor((double) this.MaxHP * ((double) (int) this.HPPercent.Value * 0.01)));
  }

  private void CalculateMP()
  {
    int num1 = (int) this.EffectiveWill * 5;
    if (this.Homunculi)
      num1 += (int) this.EffectiveWill;
    int num2 = (int) this.EffectiveSanctity * 2;
    int num3 = (int) this.EffectiveFaith * 3;
    this.MaxMP = num1 + num2 + num3;
    this.MaxMP += this.WarwalkValue;
    this.MaxMP += (int) this.KorvaraFP.Value;
    this.MaxMP += Convert.ToInt32(this.CustomMPBox.Value);
  }

  private void CustomHPBox_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void CustomMPBox_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void KorvaraHP_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void KorvaraFP_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void GiantGeneCheckBox_CheckStateChanged(object sender, EventArgs e)
  {
    this.GiantGeneModifier = !this.GiantGeneCheckBox.Checked ? 1.0 : 1.1;
    this.UpdateNumbers();
  }

  private void RisingGameCalc()
  {
    this.RisingGame = ((double) this.HPPercent.Value - 100.0) / 15.0;
    this.RisingGame = Math.Floor(this.RisingGame * -1.0);
    Decimal num = this.RisingNumeric.Value;
    if (num <= 2M)
    {
      if (!(num == 0M))
      {
        if (!(num == 1M))
        {
          if (num == 2M && this.RisingGame > 3.0)
            this.RisingGame = 3.0;
        }
        else if (this.RisingGame > 2.0)
          this.RisingGame = 2.0;
      }
      else
        this.RisingGame = 0.0;
    }
    else if (!(num == 3M))
    {
      if (!(num == 4M))
      {
        if (num == 5M && this.RisingGame > 6.0)
          this.RisingGame = 6.0;
      }
      else if (this.RisingGame > 5.0)
        this.RisingGame = 5.0;
    }
    else if (this.RisingGame > 4.0)
      this.RisingGame = 4.0;
    this.RisingGameCEL = (int) this.RisingGame;
    this.RisingGameSKI = (int) this.RisingGame;
    this.RisingGameLUC = (int) this.RisingGame;
    this.RisingGameRES = (int) this.RisingGame;
    this.RisingGameSTR = (int) this.RisingGame;
    this.RisingGameWIL = (int) this.RisingGame;
  }

  private int CalculateSkillPool()
  {
    int num1 = 11;
    double num2 = this.ReturnEffectiveStat(this.CustomBaseSkill + this.RacialSkill, this.AddedSkill - this.ZeroGyBonus + this.MainClassPSKI + this.SubClassPSKI + this.AstrologyMercury + this.StampSkill, this.ClassSkill, this.CustomSkill) + (double) this.ZeroGyBonus;
    double num3 = this.ReturnEffectiveStat(this.CustomBaseWill + this.RacialWill, this.AddedWill - this.KashIcBonus + this.StampWill + this.MainClassPWIL + this.SubClassPWIL, this.ClassWill, this.CustomWill) + (double) this.KashIcBonus;
    int skillPool = num1 + (int) Math.Truncate(this.EffectiveGuile / 5.0) + (int) Math.Truncate(num2 / 5.0) + (int) Math.Truncate(num3 / 10.0);
    if (this.Human)
      skillPool += 2;
    return skillPool;
  }

  private void InstinctCalc()
  {
    this.Instinct = 0.0;
    this.InstinctCEL = 0;
    this.InstinctDEF = 0;
    this.InstinctGUI = 0;
    this.InstinctLUC = 0;
    this.InstinctRES = 0;
    this.InstinctSTR = 0;
    this.InstinctSKI = 0;
    this.InstinctWIL = 0;
    if (this.HPPercent.Value <= 50M)
      this.Instinct = Math.Floor(this.EffectiveSanctity * 0.1 + 1.0);
    if (this.HPPercent.Value <= 25M)
      this.Instinct *= 2.0;
    if (this.RaceBoxValue == "Felidae" || this.RaceBoxValue == "Grimalkin")
    {
      this.InstinctSKI = (int) this.Instinct;
      this.InstinctCEL = (int) this.Instinct;
      this.InstinctGUI = (int) this.Instinct;
      this.InstinctLUC = (int) this.Instinct;
    }
    if (this.GrimalkinI.Checked)
    {
      this.InstinctGUI = 0;
      this.InstinctLUC = 0;
      this.InstinctWIL = (int) this.Instinct;
      this.InstinctRES = (int) this.Instinct;
    }
    if (!(this.RaceBoxValue == "Lupine"))
      return;
    this.InstinctSTR = (int) this.Instinct;
    this.InstinctWIL = (int) this.Instinct;
    this.InstinctDEF = (int) this.Instinct;
    this.InstinctRES = (int) this.Instinct;
  }

  private void MagiaDetremus()
  {
    double num = 0.3 - 0.01 * (double) ((this.CustomBaseSanctity + this.RacialSanctity + this.AddedSanctity + this.LunaCuBonus) / 2);
    this.MaxHP = (int) ((double) this.MaxHP * (1.0 - num));
    this.CurrentHP = (int) ((double) this.CurrentHP * (1.0 - num));
    this.MaxMP = (int) ((double) this.MaxMP * (1.0 - num) + (double) this.MaxMP);
  }

  private void DiminishingReturns()
  {
    this.ReturnEffectiveAptitude();
    this.EffectiveSanctity = this.ReturnEffectiveStat(this.CustomBaseSanctity + this.RacialSanctity + this.SubRacialSanctity, this.AddedSanctity - this.LunaCuBonus, this.ClassSanctity, this.CustomSanctity + this.MainClassPSAN + this.SubClassPSAN) + (double) this.LunaCuBonus;
    this.InstinctCalc();
    this.RisingGameCalc();
    this.EffectiveStrength = this.DragonKingPieces != 0 ? this.ReturnEffectiveStrengthWithDragonKing(this.CustomBaseStrength + this.RacialStrength + this.SubRacialStrength, this.AddedStrength - this.AxysAlBonus + this.AstrologyMars + this.StampStrength + this.RisingGameSTR + this.InstinctSTR + this.SanguineCrest + this.MainClassPSTR + this.SubClassPSTR + this.FoodSTR, this.ClassStrength, this.CustomStrength) + (double) this.AxysAlBonus : this.ReturnEffectiveStat(this.CustomBaseStrength + this.RacialStrength + this.SubRacialStrength, this.AddedStrength - this.AxysAlBonus + this.AstrologyMars + this.StampStrength + this.RisingGameSTR + this.InstinctSTR + this.SanguineCrest + this.MainClassPSTR + this.SubClassPSTR + this.FoodSTR, this.ClassStrength, this.CustomStrength) + (double) this.AxysAlBonus;
    this.EffectiveWill = this.DragonQueenPieces != 0 ? this.ReturnEffectiveWillWithDragonQueen(this.CustomBaseWill + this.RacialWill + this.SubRacialWill, this.AddedWill - this.KashIcBonus + this.RisingGameWIL + this.StampWill + this.InstinctWIL + this.SanguineCrest + this.FoodWIL + this.MainClassPWIL + this.SubClassPWIL, this.ClassWill, this.CustomWill) + (double) this.KashIcBonus : this.ReturnEffectiveStat(this.CustomBaseWill + this.RacialWill + this.SubRacialWill, this.AddedWill - this.KashIcBonus + this.RisingGameWIL + this.StampWill, this.ClassWill, this.CustomWill + this.InstinctWIL + this.SanguineCrest + this.FoodWIL + this.MainClassPWIL + this.SubClassPWIL) + (double) this.KashIcBonus;
    this.EffectiveSkill = this.ReturnEffectiveStat(this.CustomBaseSkill + this.RacialSkill + this.SubRacialSkill, this.AddedSkill - this.ZeroGyBonus + this.AstrologyMercury + this.RisingGameSKI + this.StampSkill, this.ClassSkill, this.CustomSkill + this.InstinctSKI + this.SanguineCrest + this.FoodSKI + this.MainClassPSKI + this.SubClassPSKI) + (double) this.ZeroGyBonus;
    this.EffectiveCelerity = this.ReturnEffectiveStat(this.CustomBaseCelerity + this.RacialCelerity + this.SubRacialCelerity, this.AddedCelerity - this.RabeUrBonus + this.AstrologySaturn + this.RisingGameCEL + this.StampCelerity + this.InstinctCEL + this.FoodCEL + this.SanguineCrest + this.MainClassPCEL + this.SubClassPCEL, this.ClassCelerity, this.CustomCelerity) + (double) this.RabeUrBonus;
    this.EffectiveDefense = this.ReturnEffectiveStat(this.CustomBaseDefense + this.RacialDefense + this.SubRacialDefense, this.AddedDefense - this.GrenUtBonus + this.AstrologyVenus, this.ClassDefense, this.CustomDefense + this.InstinctDEF + this.SanguineCrest + this.MainClassPDEF + this.SubClassPDEF) + (double) this.GrenUtBonus;
    this.EffectiveResistance = this.ReturnEffectiveStat(this.CustomBaseResistance + this.RacialResistance + this.SubRacialResistance, this.AddedResistance - this.ChoiErBonus + this.AstrologyPluto + this.RisingGameRES, this.ClassResistance, this.CustomResistance + this.InstinctRES + this.MainClassPRES + this.SubClassPRES) + (double) this.ChoiErBonus;
    this.EffectiveVitality = this.ReturnEffectiveStat(this.CustomBaseVitality + this.RacialVitality + this.SubRacialVitality, this.AddedVitality - this.BldiIaBonus + this.AstrologyNeptune + this.StampVitality + this.FoodVIT, this.ClassVitality, this.CustomVitality) + (double) this.BldiIaBonus;
    this.EffectiveFaith = this.ReturnEffectiveStat(this.CustomBaseFaith + this.RacialFaith + this.SubRacialFaith, this.AddedFaith - this.HolyMrBonus + this.AstrologyUranus + this.StampFaith, this.ClassFaith, this.CustomFaith + this.MainClassPFAI + this.SubClassPFAI) + (double) this.HolyMrBonus;
    this.EffectiveLuck = this.ReturnEffectiveStat(this.CustomBaseLuck + this.RacialLuck + this.SubRacialLuck, this.AddedLuck - this.KagiJiBonus + this.AstrologyJupiter + this.RisingGameLUC, this.ClassLuck, this.CustomLuck + this.InstinctLUC + this.MainClassPLUC + this.SubClassPLUC) + (double) this.KagiJiBonus;
    this.EffectiveGuile = this.ReturnEffectiveStat(this.CustomBaseGuile + this.RacialGuile + this.SubRacialGuile, this.AddedGuile - this.AkurZoBonus, this.ClassGuile, this.CustomGuile + this.InstinctGUI + this.MainClassPGUI + this.SubClassPGUI) + (double) this.AkurZoBonus;
  }

  private void ReturnEffectiveAptitude()
  {
    this.AptitudeBonus = 0;
    this.EffectiveAptitude = this.ReturnEffectiveStat(this.CustomBaseAptitude + this.RacialAptitude + this.SubRacialAptitude, this.AddedAptitude, this.ClassAptitude, this.CustomAptitude);
    for (double num = this.EffectiveAptitude - (double) MainWindow.AptitudeNumber; num >= 0.0; num -= (double) MainWindow.AptitudeNumber)
      ++this.AptitudeBonus;
  }

  private double ReturnEffectiveStat(int RacialStat, int AddedStat, int ClassStat, int CustomStat)
  {
    int num1 = RacialStat + 40;
    int num2 = RacialStat + AddedStat + ClassStat * this.MonoclassModifier + CustomStat + this.AptitudeBonus;
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

  private double ReturnEffectiveWillWithDragonQueen(
    int RacialStat,
    int AddedStat,
    int ClassStat,
    int CustomStat)
  {
    int num1 = RacialStat + 40 + this.DragonQueenPieces * 3;
    int num2 = RacialStat + AddedStat + ClassStat * this.MonoclassModifier + CustomStat + this.AptitudeBonus;
    int num3 = num2 + (int) ((double) num2 * (0.05 * (double) this.DragonQueenPieces));
    if (num1 >= num3)
      return (double) num3;
    double num4 = (double) num1;
    int num5 = num3 - num1;
    double num6 = 0.9;
    while (num5 > 3)
    {
      num5 -= 3;
      num4 += 3.0 * num6;
      num6 -= 0.08;
      if (num6 < 0.1)
        num6 = 0.1;
    }
    return num4 + (double) num5 * num6;
  }

  private double ReturnEffectiveStrengthWithDragonKing(
    int RacialStat,
    int AddedStat,
    int ClassStat,
    int CustomStat)
  {
    int num1 = RacialStat + 40 + this.DragonKingPieces * 3;
    int num2 = RacialStat + AddedStat + ClassStat * this.MonoclassModifier + CustomStat + this.AptitudeBonus;
    int num3 = num2 + (int) ((double) num2 * (0.05 * (double) this.DragonKingPieces));
    if (num1 >= num3)
      return (double) num3;
    double num4 = (double) num1;
    int num5 = num3 - num1;
    double num6 = 0.9;
    while (num5 > 3)
    {
      num5 -= 3;
      num4 += 3.0 * num6;
      num6 -= 0.08;
      if (num6 < 0.1)
        num6 = 0.1;
    }
    return num4 + (double) num5 * num6;
  }

  public void UpdateStatPassive()
  {
    this.MainClassPSTR = 0;
    this.MainClassPWIL = 0;
    this.MainClassPSKI = 0;
    this.MainClassPCEL = 0;
    this.MainClassPDEF = 0;
    this.MainClassPRES = 0;
    this.MainClassPFAI = 0;
    this.MainClassPLUC = 0;
    this.MainClassPGUI = 0;
    this.MainClassPSAN = 0;
    this.SubClassPSTR = 0;
    this.SubClassPWIL = 0;
    this.SubClassPSKI = 0;
    this.SubClassPCEL = 0;
    this.SubClassPDEF = 0;
    this.SubClassPRES = 0;
    this.SubClassPFAI = 0;
    this.SubClassPLUC = 0;
    this.SubClassPGUI = 0;
    this.SubClassPSAN = 0;
    this.Tooltip.SetToolTip((Control) this.MainClassNum, "");
    this.Tooltip.SetToolTip((Control) this.SubClassNum, "");
    if (this.ClassBox.SelectedItem == this.SubClassBox.SelectedItem)
    {
      this.SubClassNum.Value = 0M;
      this.SubClassNum.Maximum = 0M;
    }
    switch (this.MainClass)
    {
      case "Arbalest":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPSKI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SKI");
        break;
      case "Bard":
        this.MainClassPSAN = (int) this.MainClassNum.Value;
        this.MainClassNum.Maximum = 6M;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SAN");
        break;
      case "Black Knight":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPDEF = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+DEF");
        break;
      case "Bonder":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPWIL = (int) this.MainClassNum.Value;
        this.MainClassPFAI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+WIL/FAI");
        break;
      case "Dancer":
        this.MainClassPSAN = (int) this.MainClassNum.Value;
        this.MainClassNum.Maximum = 6M;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SAN");
        break;
      case "Dark Bard":
        this.MainClassPSTR = (int) this.MainClassNum.Value - 6;
        if (this.MainClassPSTR < 0)
          this.MainClassPSTR = 0;
        this.MainClassPSAN = (int) this.MainClassNum.Value;
        this.MainClassNum.Maximum = 9M;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SAN, +STR/SAN");
        break;
      case "Engineer":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPGUI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+GUI");
        break;
      case "Evoker":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPWIL = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+WIL");
        break;
      case "Ghost":
        this.MainClassNum.Maximum = 5M;
        this.MainClassPRES = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+RES");
        break;
      case "Hexer":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPDEF = (int) this.MainClassNum.Value;
        this.MainClassPRES = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+DEF/RES");
        break;
      case "Kensei":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPSTR = (int) this.MainClassNum.Value;
        this.MainClassPSKI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+STR/SKI");
        break;
      case "Lantern Bearer":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPRES = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+RES");
        break;
      case "Magic Gunner":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPCEL = (int) this.MainClassNum.Value;
        this.MainClassPRES = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+CEL/RES");
        break;
      case "Monk":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPSKI = (int) this.MainClassNum.Value;
        this.MainClassPCEL = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SKI/CEL");
        break;
      case "Performer":
        this.MainClassPSAN = (int) this.MainClassNum.Value;
        this.MainClassNum.Maximum = 6M;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SAN");
        break;
      case "Priest":
        this.MainClassNum.Maximum = 6M;
        this.MainClassPFAI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+FAI");
        break;
      case "Solblader":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPFAI = (int) this.MainClassNum.Value;
        this.MainClassPGUI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+FAI/GUI");
        break;
      case "Tactician":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPWIL = (int) this.MainClassNum.Value;
        this.MainClassPGUI = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+WIL/GUI");
        break;
      case "Void Assassin":
        this.MainClassNum.Maximum = 3M;
        this.MainClassPSKI = (int) this.MainClassNum.Value;
        this.MainClassPRES = (int) this.MainClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.MainClassNum, "+SKI/RES");
        break;
      default:
        this.MainClassNum.Maximum = 0M;
        break;
    }
    switch (this.SubClass)
    {
      case "Arbalest":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPSKI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SKI");
        break;
      case "Bard":
        this.SubClassNum.Maximum = this.MainClass == "Bard" || this.MainClass == "Performer" || this.MainClass == "Dancer" || this.MainClass == "Dark Bard" ? 0M : 6M;
        this.SubClassPSAN = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SAN");
        break;
      case "Black Knight":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPDEF = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+DEF");
        break;
      case "Bonder":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPWIL = (int) this.SubClassNum.Value;
        this.SubClassPFAI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+WIL/FAI");
        break;
      case "Dancer":
        this.SubClassNum.Maximum = this.MainClass == "Bard" || this.MainClass == "Performer" || this.MainClass == "Dancer" || this.MainClass == "Dark Bard" ? 0M : 6M;
        this.SubClassPSAN = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SAN");
        break;
      case "Dark Bard":
        if (this.MainClass == "Bard" || this.MainClass == "Performer" || this.MainClass == "Dancer" || this.MainClass == "Dark Bard")
        {
          this.SubClassNum.Maximum = 3M;
          this.SubClassPSTR = (int) this.SubClassNum.Value;
          this.SubClassPSAN = (int) this.SubClassNum.Value;
          this.Tooltip.SetToolTip((Control) this.SubClassNum, "+STR/SAN");
        }
        else
        {
          this.SubClassNum.Maximum = 9M;
          this.SubClassPSTR = (int) this.SubClassNum.Value - 6;
          this.SubClassPSAN = (int) this.SubClassNum.Value;
          this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SAN, +STR/SAN");
        }
        if (this.SubClassPSTR >= 0)
          break;
        this.SubClassPSTR = 0;
        break;
      case "Engineer":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPGUI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+GUI");
        break;
      case "Evoker":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPWIL = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+WIL");
        break;
      case "Ghost":
        this.SubClassNum.Maximum = 5M;
        this.SubClassPRES = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+RES");
        break;
      case "Hexer":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPDEF = (int) this.SubClassNum.Value;
        this.SubClassPRES = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+DEF/RES");
        break;
      case "Kensei":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPSTR = (int) this.SubClassNum.Value;
        this.SubClassPSKI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+STR/SKI");
        break;
      case "Lantern Bearer":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPRES = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+RES");
        break;
      case "Magic Gunner":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPCEL = (int) this.SubClassNum.Value;
        this.SubClassPRES = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+CEL/RES");
        break;
      case "Monk":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPSKI = (int) this.SubClassNum.Value;
        this.SubClassPCEL = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SKI/CEL");
        break;
      case "Performer":
        this.SubClassNum.Maximum = this.MainClass == "Bard" || this.MainClass == "Performer" || this.MainClass == "Dancer" || this.MainClass == "Dark Bard" ? 0M : 6M;
        this.SubClassPSAN = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SAN");
        break;
      case "Priest":
        this.SubClassNum.Maximum = 6M;
        this.SubClassPFAI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+FAI");
        break;
      case "Solblader":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPFAI = (int) this.SubClassNum.Value;
        this.SubClassPGUI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+FAI/GUI");
        break;
      case "Tactician":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPWIL = (int) this.SubClassNum.Value;
        this.SubClassPGUI = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+WIL/GUI");
        break;
      case "Void Assassin":
        this.SubClassNum.Maximum = 3M;
        this.SubClassPSKI = (int) this.SubClassNum.Value;
        this.SubClassPRES = (int) this.SubClassNum.Value;
        this.Tooltip.SetToolTip((Control) this.SubClassNum, "+SKI/RES");
        break;
      default:
        this.SubClassNum.Maximum = 0M;
        break;
    }
  }

  private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.MainClassNum.Value = 0M;
    this.MonoclassModifier = 1;
    this.ClassStrength = 0;
    this.ClassWill = 0;
    this.ClassSkill = 0;
    this.ClassCelerity = 0;
    this.ClassDefense = 0;
    this.ClassResistance = 0;
    this.ClassVitality = 0;
    this.ClassFaith = 0;
    this.ClassLuck = 0;
    this.ClassGuile = 0;
    this.ClassSanctity = 0;
    this.MainClass = (string) this.ClassBox.SelectedItem;
    if (this.SubClass == "Ghost" || this.MainClass == "Ghost")
    {
      this.RisingNumeric.Visible = true;
      this.RisingLabel.Visible = true;
      this.PainTol.Visible = true;
      this.PainTolLabel.Visible = true;
    }
    else
    {
      this.RisingNumeric.Visible = false;
      this.RisingLabel.Visible = false;
      this.PainTol.Visible = false;
      this.PainTolLabel.Visible = false;
      this.PainTol.Value = 0M;
      this.RisingNumeric.Value = 0M;
    }
    if (this.SubClass == "Soldier" || this.MainClass == "Soldier" || this.SubClass == "Black Knight" || this.MainClass == "Black Knight" || this.SubClass == "Tactician" || this.MainClass == "Tactician" || this.SubClass == "Demon Hunter" || this.MainClass == "Demon Hunter" || this.MainClass == "Solblader" || this.SubClass == "Solblader")
    {
      this.Fortitude.Visible = true;
    }
    else
    {
      this.Fortitude.Visible = false;
      this.Fortitude.Checked = false;
    }
    if (this.SubClass == "Hexer" || this.MainClass == "Hexer")
    {
      this.EnduranceBox.Visible = true;
    }
    else
    {
      this.EnduranceBox.Visible = false;
      this.EnduranceBox.Checked = false;
    }
    switch (this.MainClass)
    {
      case "Aquamancer":
        this.ClassWill = 1;
        this.ClassCelerity = 2;
        this.ClassFaith = 2;
        this.ClassVitality = 3;
        break;
      case "Arbalest":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassDefense = 2;
        this.ClassResistance = 1;
        this.ClassLuck = 1;
        break;
      case "Archer":
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassLuck = 1;
        break;
      case "Bard":
        this.ClassSanctity = 2;
        this.ClassCelerity = 2;
        this.ClassLuck = 1;
        break;
      case "Black Knight":
        this.ClassStrength = 2;
        this.ClassSkill = 1;
        this.ClassDefense = 2;
        this.ClassVitality = 2;
        this.ClassLuck = 1;
        break;
      case "Bonder":
        this.ClassStrength = 2;
        this.ClassWill = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 1;
        this.ClassLuck = 1;
        break;
      case "Boxer":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassDefense = 2;
        this.ClassVitality = 2;
        break;
      case "Curate":
        this.ClassWill = 2;
        this.ClassCelerity = 2;
        this.ClassResistance = 1;
        break;
      case "Dancer":
        this.ClassCelerity = 3;
        this.ClassSkill = 2;
        this.ClassWill = 2;
        this.ClassStrength = 1;
        break;
      case "Dark Bard":
        this.ClassStrength = 2;
        this.ClassResistance = 2;
        this.ClassVitality = 1;
        this.ClassSanctity = 3;
        break;
      case "Demon Hunter":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassDefense = 2;
        break;
      case "Druid":
        this.ClassFaith = 2;
        this.ClassDefense = 2;
        this.ClassLuck = 2;
        this.ClassCelerity = 2;
        break;
      case "Duelist":
        this.ClassStrength = 1;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        break;
      case "Engineer":
        this.ClassStrength = 2;
        this.ClassSkill = 1;
        this.ClassCelerity = 2;
        this.ClassDefense = 1;
        this.ClassLuck = 2;
        break;
      case "Evoker":
        this.ClassWill = 3;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassLuck = 1;
        break;
      case "Firebird":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 3;
        this.ClassLuck = 1;
        break;
      case "Ghost":
        this.RisingNumeric.Visible = true;
        this.RisingLabel.Visible = true;
        this.PainTol.Visible = true;
        this.PainTolLabel.Visible = true;
        break;
      case "Grand Summoner":
        this.ClassWill = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassFaith = 2;
        break;
      case "Hexer":
        this.ClassWill = 1;
        this.ClassSkill = 1;
        this.ClassDefense = 3;
        this.ClassResistance = 3;
        break;
      case "Kensei":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassLuck = 2;
        break;
      case "Lantern Bearer":
        this.ClassWill = 2;
        this.ClassCelerity = 2;
        this.ClassDefense = 1;
        this.ClassResistance = 2;
        this.ClassLuck = 1;
        break;
      case "Mage":
        this.ClassWill = 2;
        this.ClassCelerity = 1;
        this.ClassResistance = 2;
        break;
      case "Magic Gunner":
        this.ClassWill = 2;
        this.ClassSkill = 3;
        this.ClassCelerity = 2;
        this.ClassLuck = 1;
        break;
      case "Martial Artist":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 1;
        break;
      case "Monk":
        this.ClassStrength = 1;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassDefense = 2;
        this.ClassResistance = 1;
        break;
      case "Performer":
        this.ClassSanctity = 3;
        this.ClassCelerity = 2;
        this.ClassLuck = 2;
        this.ClassStrength = 1;
        break;
      case "Priest":
        this.ClassWill = 2;
        this.ClassCelerity = 1;
        this.ClassResistance = 2;
        this.ClassFaith = 3;
        break;
      case "Ranger":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassSanctity = 2;
        break;
      case "Rogue":
        this.ClassSkill = 1;
        this.ClassCelerity = 2;
        this.ClassLuck = 2;
        break;
      case "Ruler":
        this.ClassSanctity = 2;
        this.ClassWill = 2;
        this.ClassLuck = 2;
        this.ClassResistance = 2;
        break;
      case "Rune Magician":
        this.ClassWill = 3;
        this.ClassSkill = 2;
        this.ClassGuile = 3;
        break;
      case "Shapeshifter":
        this.ClassStrength = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassLuck = 2;
        break;
      case "Shinobi":
        this.ClassStrength = 2;
        this.ClassCelerity = 4;
        this.ClassGuile = 2;
        break;
      case "Solblader":
        this.ClassStrength = 2;
        this.ClassWill = 2;
        this.ClassCelerity = 2;
        this.ClassFaith = 2;
        break;
      case "Soldier":
        this.ClassStrength = 2;
        this.ClassSkill = 1;
        this.ClassVitality = 2;
        break;
      case "Spellthief":
        this.ClassStrength = 2;
        this.ClassWill = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        break;
      case "Summoner":
        this.ClassWill = 2;
        this.ClassCelerity = 2;
        this.ClassResistance = 1;
        break;
      case "Tactician":
        this.ClassStrength = 1;
        this.ClassWill = 1;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        this.ClassDefense = 1;
        this.ClassResistance = 1;
        break;
      case "Verglas":
        this.ClassStrength = 2;
        this.ClassWill = 2;
        this.ClassSkill = 2;
        this.ClassCelerity = 2;
        break;
      case "Void Assassin":
        this.ClassSkill = 3;
        this.ClassCelerity = 2;
        this.ClassResistance = 2;
        this.ClassLuck = 1;
        break;
    }
    if (this.ClassBox.SelectedItem == this.SubClassBox.SelectedItem)
      this.MonoclassModifier = 2;
    this.UpdateStatPassive();
    this.UpdateNumbers();
  }

  private void SubClassBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.SubClass = (string) this.SubClassBox.SelectedItem;
    this.MonoclassModifier = 1;
    this.SubClassNum.Value = 0M;
    if (this.ClassBox.SelectedItem == this.SubClassBox.SelectedItem)
      this.MonoclassModifier = 2;
    if (this.SubClass == "Ghost" || this.MainClass == "Ghost")
    {
      this.RisingNumeric.Visible = true;
      this.RisingLabel.Visible = true;
      this.PainTol.Visible = true;
      this.PainTolLabel.Visible = true;
    }
    else
    {
      this.RisingNumeric.Visible = false;
      this.RisingLabel.Visible = false;
      this.PainTol.Visible = false;
      this.PainTolLabel.Visible = false;
      this.PainTol.Value = 0M;
      this.RisingNumeric.Value = 0M;
    }
    if (this.SubClass == "Soldier" || this.MainClass == "Soldier" || this.SubClass == "Black Knight" || this.MainClass == "Black Knight" || this.SubClass == "Tactician" || this.MainClass == "Tactician" || this.SubClass == "Demon Hunter" || this.MainClass == "Demon Hunter" || this.SubClass == "Solblader" || this.MainClass == "Solblader")
    {
      this.Fortitude.Visible = true;
    }
    else
    {
      this.Fortitude.Visible = false;
      this.Fortitude.Checked = false;
    }
    if (this.SubClass == "Hexer" || this.MainClass == "Hexer")
    {
      this.EnduranceBox.Visible = true;
    }
    else
    {
      this.EnduranceBox.Visible = false;
      this.EnduranceBox.Checked = false;
    }
    this.UpdateStatPassive();
    this.UpdateNumbers();
  }

  private void SubClassNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStatPassive();
    this.UpdateNumbers();
  }

  private void MainClassNum_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateStatPassive();
    this.UpdateNumbers();
  }

  private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.RaceBoxValue = string.Empty;
    this.SubraceBox.SelectedItem = (object) string.Empty;
    this.Essence.Visible = false;
    this.SubraceBox.Visible = true;
    this.SanguineCrestBox.Visible = false;
    this.SanguineCrestBox.Checked = false;
    this.SubraceBox.Visible = false;
    this.GrimalkinI.Visible = false;
    this.Homunculi = false;
    this.Subrace = false;
    this.Human = false;
    this.RaceBoxValue = (string) this.RaceBox.SelectedItem;
    this.SubRacialStrength = 0;
    this.SubRacialWill = 0;
    this.SubRacialSkill = 0;
    this.SubRacialCelerity = 0;
    this.SubRacialVitality = 0;
    this.SubRacialDefense = 0;
    this.SubRacialResistance = 0;
    this.SubRacialFaith = 0;
    this.SubRacialLuck = 0;
    this.SubRacialSanctity = 0;
    this.SubRacialGuile = 0;
    this.SubRacialAptitude = 0;
    switch ((string) this.RaceBox.SelectedItem)
    {
      case "Alstalsian":
        this.RacialStrength = 2;
        this.RacialWill = 4;
        this.RacialSkill = 5;
        this.RacialCelerity = 5;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 8;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Amalgama":
        this.Homunculi = true;
        this.RacialStrength = 5;
        this.RacialWill = 6;
        this.RacialSkill = 5;
        this.RacialCelerity = 3;
        this.RacialDefense = 2;
        this.RacialResistance = 3;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 7;
        this.RacialSanctity = 0;
        this.RacialAptitude = 2;
        break;
      case "Apertaurus":
        this.RacialStrength = 9;
        this.RacialWill = 1;
        this.RacialSkill = 4;
        this.RacialCelerity = 6;
        this.RacialDefense = 1;
        this.RacialResistance = 2;
        this.RacialVitality = 7;
        this.RacialFaith = 1;
        this.RacialLuck = 2;
        this.RacialGuile = 1;
        this.RacialSanctity = 6;
        this.RacialAptitude = 0;
        break;
      case "Avian":
        this.RacialStrength = 6;
        this.RacialWill = 3;
        this.RacialSkill = 9;
        this.RacialCelerity = 7;
        this.RacialDefense = 4;
        this.RacialResistance = 4;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Beast":
        this.RacialStrength = 9;
        this.RacialWill = 4;
        this.RacialSkill = 6;
        this.RacialCelerity = 6;
        this.RacialDefense = 4;
        this.RacialResistance = 4;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 3;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Chataran":
        this.RacialStrength = 6;
        this.RacialWill = 2;
        this.RacialSkill = 4;
        this.RacialCelerity = 1;
        this.RacialDefense = 8;
        this.RacialResistance = 5;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 1;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Chimera":
        this.Homunculi = true;
        this.RacialStrength = 3;
        this.RacialWill = 3;
        this.RacialSkill = 6;
        this.RacialCelerity = 6;
        this.RacialDefense = 2;
        this.RacialResistance = 4;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 5;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        break;
      case "Corbie":
        this.RacialStrength = 4;
        this.RacialWill = 3;
        this.RacialSkill = 4;
        this.RacialCelerity = 6;
        this.RacialDefense = 1;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 5;
        this.RacialGuile = 6;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "Doriad":
        this.RacialStrength = 3;
        this.RacialWill = 5;
        this.RacialSkill = 5;
        this.RacialCelerity = 4;
        this.RacialDefense = 2;
        this.RacialResistance = 7;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 2;
        this.RacialSanctity = 5;
        this.RacialAptitude = 1;
        break;
      case "Dormehan":
        this.RacialStrength = 5;
        this.RacialWill = 2;
        this.RacialSkill = 5;
        this.RacialCelerity = 1;
        this.RacialDefense = 4;
        this.RacialResistance = 4;
        this.RacialVitality = 8;
        this.RacialFaith = 0;
        this.RacialLuck = 3;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Dragon":
        this.RacialStrength = 8;
        this.RacialWill = 6;
        this.RacialSkill = 7;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 5;
        this.RacialVitality = 7;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Dullahan":
        this.RacialStrength = 9;
        this.RacialWill = 1;
        this.RacialSkill = 5;
        this.RacialCelerity = 1;
        this.RacialDefense = 9;
        this.RacialResistance = 4;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 3;
        this.RacialSanctity = 0;
        this.RacialAptitude = 1;
        break;
      case "Duyuein":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 1;
        this.RacialDefense = 4;
        this.RacialResistance = 6;
        this.RacialVitality = 7;
        this.RacialFaith = 3;
        this.RacialLuck = 2;
        this.RacialGuile = 1;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Elf":
        this.RacialStrength = 3;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 7;
        this.RacialFaith = 2;
        this.RacialLuck = 1;
        this.RacialGuile = 2;
        this.RacialSanctity = 5;
        this.RacialAptitude = 0;
        break;
      case "Fairy":
        this.RacialStrength = 3;
        this.RacialWill = 6;
        this.RacialSkill = 6;
        this.RacialCelerity = 9;
        this.RacialDefense = 3;
        this.RacialResistance = 4;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 5;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Felidae":
        this.RacialStrength = 7;
        this.RacialWill = 1;
        this.RacialSkill = 6;
        this.RacialCelerity = 8;
        this.RacialDefense = 1;
        this.RacialResistance = 1;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "Geladynian":
        this.RacialStrength = 4;
        this.RacialWill = 7;
        this.RacialSkill = 4;
        this.RacialCelerity = 1;
        this.RacialDefense = 6;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 1;
        this.RacialGuile = 5;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Glykin":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 5;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 7;
        this.RacialFaith = 5;
        this.RacialLuck = 0;
        this.RacialGuile = 2;
        this.RacialSanctity = 3;
        this.RacialAptitude = 0;
        break;
      case "Grimalkin":
        this.GrimalkinI.Visible = true;
        this.RacialStrength = 4;
        this.RacialWill = 8;
        this.RacialSkill = 4;
        this.RacialCelerity = 7;
        this.RacialDefense = 1;
        this.RacialResistance = 5;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 1;
        this.RacialGuile = 4;
        this.RacialSanctity = 2;
        this.RacialAptitude = 1;
        break;
      case "Heron":
        this.RacialStrength = 4;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 2;
        this.RacialResistance = 2;
        this.RacialVitality = 5;
        this.RacialFaith = 3;
        this.RacialLuck = 1;
        this.RacialGuile = 1;
        this.RacialSanctity = 8;
        this.RacialAptitude = 0;
        break;
      case "Hyattr":
        this.RacialStrength = 7;
        this.RacialWill = 7;
        this.RacialSkill = 3;
        this.RacialCelerity = 2;
        this.RacialDefense = 5;
        this.RacialResistance = 1;
        this.RacialVitality = 8;
        this.RacialFaith = 0;
        this.RacialLuck = 1;
        this.RacialGuile = 1;
        this.RacialSanctity = 5;
        this.RacialAptitude = 4;
        break;
      case "Hyoyan":
        this.RacialStrength = 5;
        this.RacialWill = 5;
        this.RacialSkill = 6;
        this.RacialCelerity = 5;
        this.RacialDefense = 2;
        this.RacialResistance = 2;
        this.RacialVitality = 6;
        this.RacialFaith = 1;
        this.RacialLuck = 2;
        this.RacialGuile = 2;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Imperialist":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 4;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Karakuri":
        this.Subrace = true;
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 4;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 4;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 4;
        this.RacialAptitude = 4;
        this.SubraceBox.Visible = true;
        break;
      case "Karatynn":
        this.RacialStrength = 2;
        this.RacialWill = 7;
        this.RacialSkill = 5;
        this.RacialCelerity = 5;
        this.RacialDefense = 1;
        this.RacialResistance = 5;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Leporidae":
        this.RacialStrength = 6;
        this.RacialWill = 2;
        this.RacialSkill = 5;
        this.RacialCelerity = 5;
        this.RacialDefense = 3;
        this.RacialResistance = 2;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 7;
        this.RacialGuile = 3;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "Lich":
        this.RacialStrength = 1;
        this.RacialWill = 10;
        this.RacialSkill = 8;
        this.RacialCelerity = 4;
        this.RacialDefense = 2;
        this.RacialResistance = 6;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 6;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Lich (No MD)":
        this.RacialStrength = 1;
        this.RacialWill = 10;
        this.RacialSkill = 8;
        this.RacialCelerity = 4;
        this.RacialDefense = 2;
        this.RacialResistance = 6;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 6;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Lispoolian":
        this.RacialStrength = 3;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 3;
        this.RacialDefense = 2;
        this.RacialResistance = 6;
        this.RacialVitality = 4;
        this.RacialFaith = 4;
        this.RacialLuck = 1;
        this.RacialGuile = 1;
        this.RacialSanctity = 4;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Lupine":
        this.RacialStrength = 8;
        this.RacialWill = 1;
        this.RacialSkill = 4;
        this.RacialCelerity = 2;
        this.RacialDefense = 6;
        this.RacialResistance = 3;
        this.RacialVitality = 7;
        this.RacialFaith = 0;
        this.RacialLuck = 3;
        this.RacialGuile = 2;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "M-Type A":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 6;
        this.RacialCelerity = 6;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 3;
        this.RacialGuile = 3;
        this.RacialSanctity = 0;
        this.RacialAptitude = 2;
        break;
      case "M-Type C":
        this.RacialStrength = 2;
        this.RacialWill = 6;
        this.RacialSkill = 5;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 6;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 3;
        this.RacialGuile = 3;
        this.RacialSanctity = 0;
        this.RacialAptitude = 2;
        break;
      case "M-Type R":
        this.RacialStrength = 6;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 3;
        this.RacialDefense = 1;
        this.RacialResistance = 1;
        this.RacialVitality = 8;
        this.RacialFaith = 0;
        this.RacialLuck = 5;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 2;
        break;
      case "M-Type S":
        this.RacialStrength = 6;
        this.RacialWill = 2;
        this.RacialSkill = 4;
        this.RacialCelerity = 5;
        this.RacialDefense = 6;
        this.RacialResistance = 3;
        this.RacialVitality = 8;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 2;
        this.RacialSanctity = 0;
        this.RacialAptitude = 2;
        break;
      case "Meiaquarise":
        this.RacialStrength = 3;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 7;
        this.RacialDefense = 4;
        this.RacialResistance = 1;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 6;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Muridae":
        this.RacialStrength = 3;
        this.RacialWill = 5;
        this.RacialSkill = 5;
        this.RacialCelerity = 8;
        this.RacialDefense = 2;
        this.RacialResistance = 2;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 5;
        this.RacialSanctity = 2;
        this.RacialAptitude = 1;
        break;
      case "Mystic":
        this.RacialStrength = 3;
        this.RacialWill = 7;
        this.RacialSkill = 5;
        this.RacialCelerity = 6;
        this.RacialDefense = 4;
        this.RacialResistance = 3;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 7;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Naga":
        this.RacialStrength = 3;
        this.RacialWill = 8;
        this.RacialSkill = 4;
        this.RacialCelerity = 8;
        this.RacialDefense = 2;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 5;
        this.RacialSanctity = 1;
        this.RacialAptitude = 1;
        break;
      case "Night":
        this.RacialStrength = 5;
        this.RacialWill = 9;
        this.RacialSkill = 4;
        this.RacialCelerity = 5;
        this.RacialDefense = 3;
        this.RacialResistance = 4;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 6;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Omina":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 5;
        this.RacialCelerity = 7;
        this.RacialDefense = 2;
        this.RacialResistance = 2;
        this.RacialVitality = 4;
        this.RacialFaith = 2;
        this.RacialLuck = 4;
        this.RacialGuile = 2;
        this.RacialSanctity = 4;
        this.RacialAptitude = 0;
        break;
      case "Oni":
        this.RacialStrength = 8;
        this.RacialWill = 3;
        this.RacialSkill = 3;
        this.RacialCelerity = 2;
        this.RacialDefense = 5;
        this.RacialResistance = 4;
        this.RacialVitality = 9;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 0;
        this.RacialSanctity = 4;
        this.RacialAptitude = 0;
        break;
      case "Onigan":
        this.RacialStrength = 5;
        this.RacialWill = 1;
        this.RacialSkill = 7;
        this.RacialCelerity = 6;
        this.RacialDefense = 3;
        this.RacialResistance = 1;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 5;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Oracle":
        this.RacialStrength = 3;
        this.RacialWill = 7;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 5;
        this.RacialVitality = 5;
        this.RacialFaith = 4;
        this.RacialLuck = 1;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Papilion":
        this.RacialStrength = 2;
        this.RacialWill = 8;
        this.RacialSkill = 8;
        this.RacialCelerity = 5;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Phenex":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 4;
        this.RacialCelerity = 3;
        this.RacialDefense = 2;
        this.RacialResistance = 4;
        this.RacialVitality = 6;
        this.RacialFaith = 5;
        this.RacialLuck = 2;
        this.RacialGuile = 2;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "Plant":
        this.RacialStrength = 5;
        this.RacialWill = 6;
        this.RacialSkill = 5;
        this.RacialCelerity = 4;
        this.RacialDefense = 5;
        this.RacialResistance = 4;
        this.RacialVitality = 9;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Reaper":
        this.RacialStrength = 4;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 1;
        this.RacialDefense = 3;
        this.RacialResistance = 5;
        this.RacialVitality = 7;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 3;
        this.RacialSanctity = 5;
        this.RacialAptitude = 0;
        break;
      case "Redtail":
        this.RacialStrength = 3;
        this.RacialWill = 4;
        this.RacialSkill = 5;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 9;
        this.RacialGuile = 4;
        this.RacialSanctity = 1;
        this.RacialAptitude = 0;
        break;
      case "Salamandra":
        this.Homunculi = true;
        this.RacialStrength = 8;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 2;
        this.RacialResistance = 4;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 5;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Serpentine":
        this.RacialStrength = 2;
        this.RacialWill = 3;
        this.RacialSkill = 5;
        this.RacialCelerity = 8;
        this.RacialDefense = 3;
        this.RacialResistance = 8;
        this.RacialVitality = 3;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 6;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Shaitan":
        this.RacialStrength = 8;
        this.RacialWill = 1;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 8;
        this.RacialResistance = 3;
        this.RacialVitality = 8;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 2;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Tannite":
        this.RacialStrength = 5;
        this.RacialWill = 3;
        this.RacialSkill = 6;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 4;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 6;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Telegradian":
        this.RacialStrength = 7;
        this.RacialWill = 2;
        this.RacialSkill = 6;
        this.RacialCelerity = 4;
        this.RacialDefense = 1;
        this.RacialResistance = 4;
        this.RacialVitality = 4;
        this.RacialFaith = 2;
        this.RacialLuck = 4;
        this.RacialGuile = 2;
        this.RacialSanctity = 0;
        this.RacialAptitude = 4;
        this.Human = true;
        break;
      case "Theno":
        this.RacialStrength = 3;
        this.RacialWill = 6;
        this.RacialSkill = 6;
        this.RacialCelerity = 6;
        this.RacialDefense = 1;
        this.RacialResistance = 1;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 4;
        this.RacialSanctity = 0;
        this.RacialAptitude = 3;
        break;
      case "Umbral":
        this.RacialStrength = 5;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 6;
        this.RacialDefense = 2;
        this.RacialResistance = 4;
        this.RacialVitality = 6;
        this.RacialFaith = 0;
        this.RacialLuck = 4;
        this.RacialGuile = 3;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
      case "Vampire":
        this.Essence.Visible = true;
        this.SanguineCrestBox.Visible = true;
        this.RacialStrength = 3;
        this.RacialWill = 6;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 6;
        this.RacialFaith = 1;
        this.RacialLuck = 2;
        this.RacialGuile = 5;
        this.RacialSanctity = 3;
        this.RacialAptitude = 0;
        break;
      case "Wild Elf":
        this.RacialStrength = 6;
        this.RacialWill = 3;
        this.RacialSkill = 4;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 5;
        this.RacialFaith = 0;
        this.RacialLuck = 2;
        this.RacialGuile = 6;
        this.RacialSanctity = 4;
        this.RacialAptitude = 0;
        break;
      case "Wyverntouched":
        this.RacialStrength = 6;
        this.RacialWill = 6;
        this.RacialSkill = 5;
        this.RacialCelerity = 1;
        this.RacialDefense = 4;
        this.RacialResistance = 2;
        this.RacialVitality = 9;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 3;
        this.RacialSanctity = 3;
        this.RacialAptitude = 1;
        break;
      case "Zeran":
        this.RacialStrength = 4;
        this.RacialWill = 4;
        this.RacialSkill = 6;
        this.RacialCelerity = 4;
        this.RacialDefense = 3;
        this.RacialResistance = 3;
        this.RacialVitality = 4;
        this.RacialFaith = 5;
        this.RacialLuck = 0;
        this.RacialGuile = 4;
        this.RacialSanctity = 3;
        this.RacialAptitude = 0;
        break;
      default:
        this.RacialStrength = 0;
        this.RacialWill = 0;
        this.RacialSkill = 0;
        this.RacialCelerity = 0;
        this.RacialDefense = 0;
        this.RacialResistance = 0;
        this.RacialVitality = 0;
        this.RacialFaith = 0;
        this.RacialLuck = 0;
        this.RacialGuile = 0;
        this.RacialSanctity = 0;
        this.RacialAptitude = 0;
        break;
    }
    this.UpdateNumbers();
  }

  private void AxysAlButton_Click(object sender, EventArgs e)
  {
  }

  private void button1_Click(object sender, EventArgs e)
  {
    List<Form> formList = new List<Form>();
    foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
      formList.Add(openForm);
    if (!this.dark)
    {
      this.dark = true;
      this.ForeColor = Color.White;
      this.BackColor = Color.FromArgb(25, 25, 25);
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        control.ForeColor = Color.White;
        control.BackColor = Color.FromArgb(25, 25, 25);
      }
      foreach (Control control in this.Controls.OfType<Button>())
        control.BackColor = Color.FromArgb(50, 50, 50);
      foreach (Form form in formList)
      {
        form.ForeColor = Color.White;
        form.BackColor = Color.FromArgb(25, 25, 25);
      }
    }
    else
    {
      this.dark = false;
      this.ForeColor = new Color();
      this.BackColor = new Color();
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        control.ForeColor = new Color();
        control.BackColor = new Color();
      }
      foreach (Control control in this.Controls.OfType<Button>())
        control.BackColor = new Color();
      foreach (Control control in formList)
        control.ForeColor = new Color();
    }
  }

  private void MainWindow_Load(object sender, EventArgs e)
  {
  }

  private void EvadeMouseHover(object sender, EventArgs e)
  {
    this.EvadeLabel.ForeColor = Color.FromArgb(0, 200, 200);
  }

  private void CritEvadeLabel_MouseHover(object sender, EventArgs e)
  {
    this.CritEvadeLabel.ForeColor = Color.FromArgb(0, 200, 200);
  }

  private void EvadeMouseLeave(object sender, EventArgs e)
  {
    if (this.dark)
    {
      this.EvadeLabel.ForeColor = Color.White;
      this.EvadeLabel.BackColor = Color.FromArgb(25, 25, 25);
    }
    else
    {
      this.EvadeLabel.ForeColor = new Color();
      this.EvadeLabel.BackColor = new Color();
    }
  }

  private void CritEvadeLabel_MouseLeave(object sender, EventArgs e)
  {
    if (this.dark)
    {
      this.CritEvadeLabel.ForeColor = Color.White;
      this.CritEvadeLabel.BackColor = Color.FromArgb(25, 25, 25);
    }
    else
    {
      this.CritEvadeLabel.ForeColor = new Color();
      this.CritEvadeLabel.BackColor = new Color();
    }
  }

  private void SubraceBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.SubRacialStrength = 0;
    this.SubRacialWill = 0;
    this.SubRacialSkill = 0;
    this.SubRacialCelerity = 0;
    this.SubRacialVitality = 0;
    this.SubRacialDefense = 0;
    this.SubRacialResistance = 0;
    this.SubRacialFaith = 0;
    this.SubRacialLuck = 0;
    this.SubRacialSanctity = 0;
    this.SubRacialGuile = 0;
    this.SubRacialAptitude = 0;
    if (this.SubraceBox.SelectedItem is string selectedItem)
    {
      switch (selectedItem)
      {
        case "Avian":
          this.SubRacialGuile += 3;
          this.SubRacialCelerity += 2;
          this.SubRacialWill -= 3;
          this.SubRacialDefense -= 2;
          break;
        case "Beast":
          this.SubRacialSkill += 3;
          this.SubRacialLuck += 2;
          this.SubRacialResistance -= 3;
          this.SubRacialGuile -= 2;
          break;
        case "Dragon":
          this.SubRacialStrength += 3;
          this.SubRacialDefense += 2;
          this.SubRacialCelerity -= 3;
          this.SubRacialResistance -= 2;
          break;
        case "Fairy":
          this.SubRacialCelerity += 3;
          this.SubRacialLuck += 2;
          this.SubRacialStrength -= 3;
          this.SubRacialWill -= 2;
          break;
        case "Mystic":
          this.SubRacialWill += 3;
          this.SubRacialSkill += 2;
          this.SubRacialStrength -= 3;
          this.SubRacialResistance -= 2;
          break;
        case "Night":
          this.SubRacialResistance += 3;
          this.SubRacialGuile += 2;
          this.SubRacialDefense -= 3;
          this.SubRacialFaith -= 2;
          break;
        case "Plant":
          this.SubRacialDefense += 3;
          this.SubRacialVitality += 2;
          this.SubRacialGuile -= 3;
          this.SubRacialLuck -= 2;
          break;
      }
    }
    this.UpdateNumbers();
  }

  private void HistoryPick(string HistoryString)
  {
    this.HistoryStrength = 0;
    this.HistoryWill = 0;
    this.HistorySkill = 0;
    this.HistoryCelerity = 0;
    this.HistoryDefense = 0;
    this.HistoryResistance = 0;
    this.HistoryVitality = 0;
    this.HistoryFaith = 0;
    this.HistoryLuck = 0;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(HistoryString))
    {
      case 87178802:
        if (!(HistoryString == "Hero (STR++, LUC+)"))
          break;
        this.HistoryStrength = 2;
        this.HistoryLuck = 1;
        break;
      case 272427523:
        if (!(HistoryString == "Witchhunter(RES++, STR +)"))
          break;
        this.HistoryResistance = 2;
        this.HistoryStrength = 1;
        break;
      case 1026930413:
        if (!(HistoryString == "Assassin (SKI++, LUC+)"))
          break;
        this.HistorySkill = 2;
        this.HistoryLuck = 1;
        break;
      case 1113625367:
        if (!(HistoryString == "Warrior (STR++, SKI+)"))
          break;
        this.HistoryStrength = 2;
        this.HistorySkill = 1;
        break;
      case 1260043461:
        if (!(HistoryString == "Thief (CEL++, LUC+)"))
          break;
        this.HistoryCelerity = 2;
        this.HistoryLuck = 1;
        break;
      case 1286378051:
        if (!(HistoryString == "Marauder (VIT++, LUC+)"))
          break;
        this.HistoryVitality = 2;
        this.HistoryLuck = 1;
        break;
      case 1464428860:
        if (!(HistoryString == "Priest (FAI++, WIL+)"))
          break;
        this.HistoryFaith = 2;
        this.HistoryWill = 1;
        break;
      case 1838510978:
        if (!(HistoryString == "Magician (WIL++, CEL+)"))
          break;
        this.HistoryWill = 2;
        this.HistoryCelerity = 1;
        break;
      case 2203137900:
        if (!(HistoryString == "Survivor(LUC++, VIT +)"))
          break;
        this.HistoryLuck = 2;
        this.HistoryVitality = 1;
        break;
      case 2329384900:
        if (!(HistoryString == "Gambler (LUC++, STR+)"))
          break;
        this.HistoryLuck = 2;
        this.HistoryStrength = 1;
        break;
      case 2554976176:
        if (!(HistoryString == "Spellblade (WIL++, STR+)"))
          break;
        this.HistoryWill = 2;
        this.HistoryStrength = 1;
        break;
      case 2888530646:
        if (!(HistoryString == "Faithful (FAI++, RES+)"))
          break;
        this.HistoryFaith = 2;
        this.HistoryResistance = 1;
        break;
      case 2993731305:
        if (!(HistoryString == "Fencer (CEL++, DEF+)"))
          break;
        this.HistoryCelerity = 2;
        this.HistoryDefense = 1;
        break;
      case 3084573851:
        if (!(HistoryString == "Myrmidon (SKI++, CEL+)"))
          break;
        this.HistorySkill = 2;
        this.HistoryCelerity = 1;
        break;
      case 3453797438:
        if (!(HistoryString == "Ward (DEF++, RES+)"))
          break;
        this.HistoryDefense = 2;
        this.HistoryResistance = 1;
        break;
      case 3682678328:
        if (!(HistoryString == "Shaman (DEF++, WIL+)"))
          break;
        this.HistoryDefense = 2;
        this.HistoryWill = 1;
        break;
      case 3978366248:
        if (!(HistoryString == "Ghost (RES++, CEL+)"))
          break;
        this.HistoryResistance = 2;
        this.HistoryCelerity = 1;
        break;
      case 4083767204:
        if (!(HistoryString == "Knight (VIT++, DEF+)"))
          break;
        this.HistoryVitality = 2;
        this.HistoryDefense = 1;
        break;
    }
  }

  private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.HistoryString = this.HistoryListBox.Text;
    this.HistoryPick(this.HistoryString);
    this.SetTraitStrength(this.HistoryStrength);
    this.SetTraitWill(this.HistoryWill);
    this.SetTraitSkill(this.HistorySkill);
    this.SetTraitCelerity(this.HistoryCelerity);
    this.SetTraitDefense(this.HistoryDefense);
    this.SetTraitResistance(this.HistoryResistance);
    this.SetTraitVitality(this.HistoryVitality);
    this.SetTraitFaith(this.HistoryFaith);
    this.SetTraitLuck(this.HistoryLuck);
  }

  private void DragonKingBox_ValueChanged(object sender, EventArgs e)
  {
    this.DragonKingPieces = (int) this.DragonKingBox.Value;
    this.UpdateNumbers();
  }

  private void DragonQueenBox_ValueChanged(object sender, EventArgs e)
  {
    this.DragonQueenPieces = (int) this.DragonQueenBox.Value;
    this.UpdateNumbers();
  }

  private void FoodBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.FoodSTR = 0;
    this.FoodWIL = 0;
    this.FoodSKI = 0;
    this.FoodCEL = 0;
    this.FoodVIT = 0;
    if (this.FoodBox.SelectedItem is string selectedItem)
    {
      switch (selectedItem)
      {
        case "Androbar":
          this.FoodCEL = 3;
          break;
        case "Chocolate Bar":
          this.FoodCEL = 2;
          break;
        case "Cocky":
          this.FoodCEL = 3;
          break;
        case "Fugu":
          this.FoodSTR = 3;
          this.FoodWIL = 3;
          break;
        case "Jammies":
          this.FoodCEL = 4;
          break;
        case "Kat Knip":
          this.FoodCEL = 3;
          break;
        case "Potato & Carrot":
          this.FoodSKI = 3;
          break;
        case "Pumpkin Lollipop":
          this.FoodCEL = 5;
          break;
        case "Redpop":
          this.FoodCEL = 4;
          break;
        case "Salad":
          this.FoodVIT = 3;
          break;
        case "Salad w/ Yams":
          this.FoodVIT = 4;
          break;
        case "Sushi":
          this.FoodSTR = 2;
          this.FoodWIL = 2;
          break;
        case "Sweet Bites":
          this.FoodCEL = 1;
          break;
      }
    }
    this.UpdateNumbers();
  }

  private void EvadePlus_Click(object sender, EventArgs e)
  {
    new PointInput(this, "Evade", "Addition").Show();
  }

  private void CEvadePlus_Click(object sender, EventArgs e)
  {
    new PointInput(this, "Crit Evade", "Addition").Show();
  }

  private void StrengthPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Strength", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedStrength;
      this.UpdateNumbers();
    }
  }

  private void StrengthMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedStrength - (this.AxysAlBonus + this.TraitStrength)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Strength", "Subtraction").Show();
    }
    else
    {
      --this.AddedStrength;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void WillPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Will", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedWill;
      this.UpdateNumbers();
    }
  }

  private void WillMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedWill - (this.TraitWill + this.KashIcBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Will", "Subtraction").Show();
    }
    else
    {
      --this.AddedWill;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void SkillPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Skill", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedSkill;
      this.UpdateNumbers();
    }
  }

  private void SkillMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedSkill - (this.TraitSkill + this.ZeroGyBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Skill", "Subtraction").Show();
    }
    else
    {
      --this.AddedSkill;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void CelerityPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Celerity", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedCelerity;
      this.UpdateNumbers();
    }
  }

  private void CelerityMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedCelerity - (this.TraitCelerity + this.RabeUrBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Celerity", "Subtraction").Show();
    }
    else
    {
      --this.AddedCelerity;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void DefensePlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Defense", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedDefense;
      this.UpdateNumbers();
    }
  }

  private void DefenseMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedDefense - (this.TraitDefense + this.GrenUtBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Defense", "Subtraction").Show();
    }
    else
    {
      --this.AddedDefense;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void ResistancePlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Resistance", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedResistance;
      this.UpdateNumbers();
    }
  }

  private void ResistanceMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedResistance - (this.TraitResistance + this.ChoiErBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Resistance", "Subtraction").Show();
    }
    else
    {
      --this.AddedResistance;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void VitalityPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Vitality", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedVitality;
      this.UpdateNumbers();
    }
  }

  private void VitalityMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedVitality - (this.TraitVitality + this.BldiIaBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Vitality", "Subtraction").Show();
    }
    else
    {
      --this.AddedVitality;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void FaithPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Faith", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedFaith;
      this.UpdateNumbers();
    }
  }

  private void FaithMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedFaith - (this.TraitFaith + this.HolyMrBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Faith", "Subtraction").Show();
    }
    else
    {
      --this.AddedFaith;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void LuckPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Luck", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedLuck;
      this.UpdateNumbers();
    }
  }

  private void LuckMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedLuck - (this.TraitLuck + this.KagiJiBonus)))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Luck", "Subtraction").Show();
    }
    else
    {
      --this.AddedLuck;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void RisingNumeric_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void ReboundBox_CheckedChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void SanguineCrestBox_CheckedChanged_1(object sender, EventArgs e)
  {
    this.SanguineCrest = 0;
    if (this.SanguineCrestBox.Checked)
      this.SanguineCrest = 2;
    this.UpdateNumbers();
  }

  private void GrimalkinI_CheckedChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void LuminaryBox_CheckedChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void Fortitude_CheckedChanged(object sender, EventArgs e)
  {
    this.FortitudeValue = 0;
    if (this.Fortitude.Checked)
      this.FortitudeValue = 75;
    this.UpdateNumbers();
  }

  private void PainTol_ValueChanged(object sender, EventArgs e)
  {
    this.PainTolValue = (int) this.PainTol.Value * 8;
    if (this.PainTol.Value == 5M)
      this.PainTolValue += 8;
    this.UpdateNumbers();
  }

  private void Warwalk_CheckedChanged(object sender, EventArgs e)
  {
    this.WarwalkValue = 0;
    if (this.Warwalk.Checked)
      this.WarwalkValue = 20;
    this.UpdateNumbers();
  }

  private void TotalHPPercent_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void HPPercent_ValueChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void EnduranceBox_CheckedChanged(object sender, EventArgs e)
  {
    this.EnduranceModifier = !this.EnduranceBox.Checked ? 1.0 : 1.1;
    this.UpdateNumbers();
  }

  private void GuilePlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Guile", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedGuile;
      this.UpdateNumbers();
    }
  }

  private void GuileMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedGuile - this.AkurZoBonus))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Guile", "Subtraction").Show();
    }
    else
    {
      --this.AddedGuile;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void RisingBox_CheckedChanged(object sender, EventArgs e) => this.UpdateNumbers();

  private void SanctityPlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Sanctity", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedSanctity;
      this.UpdateNumbers();
    }
  }

  private void SanctityMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedSanctity - this.LunaCuBonus))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Sanctity", "Subtraction").Show();
    }
    else
    {
      --this.AddedSanctity;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  private void AptitudePlus_Click(object sender, EventArgs e)
  {
    if (!this.CheckAddition())
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Aptitude", "Addition").Show();
    }
    else
    {
      --this.TotalPoints;
      ++this.AddedAptitude;
      this.UpdateNumbers();
    }
  }

  private void AptitudeMinus_Click(object sender, EventArgs e)
  {
    if (!this.CheckSubtraction(this.AddedAptitude))
      return;
    if (Control.ModifierKeys == Keys.Shift)
    {
      new PointInput(this, "Aptitude", "Subtraction").Show();
    }
    else
    {
      --this.AddedAptitude;
      ++this.TotalPoints;
      this.UpdateNumbers();
    }
  }

  public void ResetButton_Click(object sender, EventArgs e)
  {
  }

  private void AxysAlToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.AxysAlToggle)
    {
      this.AxysAlButton.Image = (Image) Resources.AxysAlOn;
      this.AxysAlToggle = true;
      this.AxysAlBonus = 1;
      ++this.AddedStrength;
    }
    else if (this.AxysAlToggle & !this.AllLEButtonToggle)
    {
      this.AxysAlToggle = false;
      this.AxysAlBonus = 0;
      --this.AddedStrength;
      this.AxysAlButton.Image = (Image) Resources.AxysAlOff;
    }
    this.UpdateNumbers();
  }

  private void KashIcToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.KashIcToggle)
    {
      this.KashIcButton.Image = (Image) Resources.KashIcOn;
      this.KashIcToggle = true;
      this.KashIcBonus = 1;
      ++this.AddedWill;
    }
    else if (this.KashIcToggle & !this.AllLEButtonToggle)
    {
      this.KashIcToggle = false;
      this.KashIcBonus = 0;
      --this.AddedWill;
      this.KashIcButton.Image = (Image) Resources.KashIcOff;
    }
    this.UpdateNumbers();
  }

  private void RabeUrToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.RabeUrToggle)
    {
      this.RabeUrButton.Image = (Image) Resources.RabeUrOn;
      this.RabeUrToggle = true;
      this.RabeUrBonus = 1;
      ++this.AddedCelerity;
    }
    else if (this.RabeUrToggle & !this.AllLEButtonToggle)
    {
      this.RabeUrToggle = false;
      this.RabeUrBonus = 0;
      --this.AddedCelerity;
      this.RabeUrButton.Image = (Image) Resources.RabeUrOff;
    }
    this.UpdateNumbers();
  }

  private void ZeroGyToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.ZeroGyToggle)
    {
      this.ZeroGyButton.Image = (Image) Resources.ZeroGyOn;
      this.ZeroGyToggle = true;
      this.ZeroGyBonus = 1;
      ++this.AddedSkill;
    }
    else if (this.ZeroGyToggle & !this.AllLEButtonToggle)
    {
      this.ZeroGyToggle = false;
      this.ZeroGyBonus = 0;
      --this.AddedSkill;
      this.ZeroGyButton.Image = (Image) Resources.ZeroGyOff;
    }
    this.UpdateNumbers();
  }

  private void GrenUtToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.GrenUtToggle)
    {
      this.GrenUtButton.Image = (Image) Resources.GrenUtOn;
      this.GrenUtToggle = true;
      this.GrenUtBonus = 1;
      ++this.AddedDefense;
    }
    else if (this.GrenUtToggle & !this.AllLEButtonToggle)
    {
      this.GrenUtToggle = false;
      this.GrenUtBonus = 0;
      --this.AddedDefense;
      this.GrenUtButton.Image = (Image) Resources.GrenUtOff;
    }
    this.UpdateNumbers();
  }

  private void ChoiErToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.ChoiErToggle)
    {
      this.ChoiErButton.Image = (Image) Resources.ChoiErOn;
      this.ChoiErToggle = true;
      this.ChoiErBonus = 1;
      ++this.AddedResistance;
    }
    else if (this.ChoiErToggle & !this.AllLEButtonToggle)
    {
      this.ChoiErToggle = false;
      this.ChoiErBonus = 0;
      --this.AddedResistance;
      this.ChoiErButton.Image = (Image) Resources.ChoiErOff;
    }
    this.UpdateNumbers();
  }

  private void BldiIaToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.BldiIaToggle)
    {
      this.BldiIaButton.Image = (Image) Resources.BldiIaOn;
      this.BldiIaToggle = true;
      this.BldiIaBonus = 1;
      ++this.AddedVitality;
    }
    else if (this.BldiIaToggle & !this.AllLEButtonToggle)
    {
      this.BldiIaToggle = false;
      this.BldiIaBonus = 0;
      --this.AddedVitality;
      this.BldiIaButton.Image = (Image) Resources.BldiIaOff;
    }
    this.UpdateNumbers();
  }

  private void HolyMrToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.HolyMrToggle)
    {
      this.HolyMrButton.Image = (Image) Resources.HolyMrOn;
      this.HolyMrToggle = true;
      this.HolyMrBonus = 1;
      ++this.AddedFaith;
    }
    else if (this.HolyMrToggle & !this.AllLEButtonToggle)
    {
      this.HolyMrToggle = false;
      this.HolyMrBonus = 0;
      --this.AddedFaith;
      this.HolyMrButton.Image = (Image) Resources.HolyMrOff;
    }
    this.UpdateNumbers();
  }

  private void KagiJiToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.KagiJiToggle)
    {
      this.KagiJiButton.Image = (Image) Resources.KagiJiOn;
      this.KagiJiToggle = true;
      this.KagiJiBonus = 1;
      ++this.AddedLuck;
    }
    else if (this.KagiJiToggle & !this.AllLEButtonToggle)
    {
      this.KagiJiToggle = false;
      this.KagiJiBonus = 0;
      --this.AddedLuck;
      this.KagiJiButton.Image = (Image) Resources.KagiJiOff;
    }
    this.UpdateNumbers();
  }

  private void LunaCuToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.LunaCuToggle)
    {
      this.LunaCuButton.Image = (Image) Resources.LunaCuOn;
      this.LunaCuToggle = true;
      this.LunaCuBonus = 1;
      ++this.AddedSanctity;
    }
    else if (this.LunaCuToggle & !this.AllLEButtonToggle)
    {
      this.LunaCuToggle = false;
      this.LunaCuBonus = 0;
      --this.AddedSanctity;
      this.LunaCuButton.Image = (Image) Resources.LunaCuOff;
    }
    this.UpdateNumbers();
  }

  private void AkurZoToggleClick(object sender, MouseEventArgs e)
  {
    if (!this.AkurZoToggle)
    {
      this.AkurZoButton.Image = (Image) Resources.AkurZoOn;
      this.AkurZoToggle = true;
      this.AkurZoBonus = 1;
      ++this.AddedGuile;
    }
    else if (this.AkurZoToggle & !this.AllLEButtonToggle)
    {
      this.AkurZoToggle = false;
      this.AkurZoBonus = 0;
      --this.AddedGuile;
      this.AkurZoButton.Image = (Image) Resources.AkurZoOff;
    }
    this.UpdateNumbers();
  }

  private void AllLEButton_Click(object sender, EventArgs e)
  {
    if (!this.AllLEButtonToggle & !this.HolyMrToggle & !this.AkurZoToggle & !this.LunaCuToggle & !this.KagiJiToggle & !this.BldiIaToggle & !this.ChoiErToggle & !this.GrenUtToggle & !this.ZeroGyToggle & !this.RabeUrToggle & !this.KashIcToggle & !this.AxysAlToggle)
    {
      this.AllLEButton.Image = (Image) Resources.AllOn;
      this.AllLEButtonToggle = true;
      this.AkurZoButton.Image = (Image) Resources.AkurZoOn;
      this.AkurZoToggle = true;
      this.AkurZoBonus = 1;
      ++this.AddedGuile;
      this.LunaCuButton.Image = (Image) Resources.LunaCuOn;
      this.LunaCuToggle = true;
      this.LunaCuBonus = 1;
      ++this.AddedSanctity;
      this.KagiJiButton.Image = (Image) Resources.KagiJiOn;
      this.KagiJiToggle = true;
      this.KagiJiBonus = 1;
      ++this.AddedLuck;
      this.HolyMrButton.Image = (Image) Resources.HolyMrOn;
      this.HolyMrToggle = true;
      this.HolyMrBonus = 1;
      ++this.AddedFaith;
      this.BldiIaButton.Image = (Image) Resources.BldiIaOn;
      this.BldiIaToggle = true;
      this.BldiIaBonus = 1;
      ++this.AddedVitality;
      this.ChoiErButton.Image = (Image) Resources.ChoiErOn;
      this.ChoiErToggle = true;
      this.ChoiErBonus = 1;
      ++this.AddedResistance;
      this.GrenUtButton.Image = (Image) Resources.GrenUtOn;
      this.GrenUtToggle = true;
      this.GrenUtBonus = 1;
      ++this.AddedDefense;
      this.ZeroGyButton.Image = (Image) Resources.ZeroGyOn;
      this.ZeroGyToggle = true;
      this.ZeroGyBonus = 1;
      ++this.AddedSkill;
      this.RabeUrButton.Image = (Image) Resources.RabeUrOn;
      this.RabeUrToggle = true;
      this.RabeUrBonus = 1;
      ++this.AddedCelerity;
      this.KashIcButton.Image = (Image) Resources.KashIcOn;
      this.KashIcToggle = true;
      this.KashIcBonus = 1;
      ++this.AddedWill;
      this.AxysAlButton.Image = (Image) Resources.AxysAlOn;
      this.AxysAlToggle = true;
      this.AxysAlBonus = 1;
      ++this.AddedStrength;
    }
    else if (this.AllLEButtonToggle)
    {
      this.AllLEButton.Image = (Image) Resources.AllOff;
      this.AllLEButtonToggle = false;
      this.AxysAlToggle = false;
      this.AxysAlBonus = 0;
      --this.AddedStrength;
      this.AxysAlButton.Image = (Image) Resources.AxysAlOff;
      this.KashIcToggle = false;
      this.KashIcBonus = 0;
      --this.AddedWill;
      this.KashIcButton.Image = (Image) Resources.KashIcOff;
      this.RabeUrToggle = false;
      this.RabeUrBonus = 0;
      --this.AddedCelerity;
      this.RabeUrButton.Image = (Image) Resources.RabeUrOff;
      this.ZeroGyToggle = false;
      this.ZeroGyBonus = 0;
      --this.AddedSkill;
      this.ZeroGyButton.Image = (Image) Resources.ZeroGyOff;
      this.GrenUtToggle = false;
      this.GrenUtBonus = 0;
      --this.AddedDefense;
      this.GrenUtButton.Image = (Image) Resources.GrenUtOff;
      this.ChoiErToggle = false;
      this.ChoiErBonus = 0;
      --this.AddedResistance;
      this.ChoiErButton.Image = (Image) Resources.ChoiErOff;
      this.BldiIaToggle = false;
      this.BldiIaBonus = 0;
      --this.AddedVitality;
      this.BldiIaButton.Image = (Image) Resources.BldiIaOff;
      this.HolyMrToggle = false;
      this.HolyMrBonus = 0;
      --this.AddedFaith;
      this.HolyMrButton.Image = (Image) Resources.HolyMrOff;
      this.KagiJiToggle = false;
      this.KagiJiBonus = 0;
      --this.AddedLuck;
      this.KagiJiButton.Image = (Image) Resources.KagiJiOff;
      this.LunaCuToggle = false;
      this.LunaCuBonus = 0;
      --this.AddedSanctity;
      this.LunaCuButton.Image = (Image) Resources.LunaCuOff;
      this.AkurZoToggle = false;
      this.AkurZoBonus = 0;
      --this.AddedGuile;
      this.AkurZoButton.Image = (Image) Resources.AkurZoOff;
    }
    this.UpdateNumbers();
  }

  public void SetMercury()
  {
    this.AstrologyMercury = 1;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Mercury;
    this.UpdateNumbers();
  }

  public void SetVenus()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 1;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Venus;
    this.UpdateNumbers();
  }

  public void SetMars()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 1;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Mars;
    this.UpdateNumbers();
  }

  public void SetJupiter()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 1;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Jupiter;
    this.UpdateNumbers();
  }

  public void SetSaturn()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 1;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Saturn;
    this.UpdateNumbers();
  }

  public void SetNeptune()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 1;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Neptune;
    this.UpdateNumbers();
  }

  public void SetUranus()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 1;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Uranus;
    this.UpdateNumbers();
  }

  public void SetPluto()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 1;
    this.AstrologyButton.BackgroundImage = (Image) Resources.Pluto;
    this.UpdateNumbers();
  }

  public void SetNoSign()
  {
    this.AstrologyMercury = 0;
    this.AstrologyVenus = 0;
    this.AstrologyMars = 0;
    this.AstrologyJupiter = 0;
    this.AstrologySaturn = 0;
    this.AstrologyNeptune = 0;
    this.AstrologyUranus = 0;
    this.AstrologyPluto = 0;
    this.AstrologyButton.BackgroundImage = (Image) Resources.NoSign;
    this.UpdateNumbers();
  }

  private void CustomStrengthBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomStrength = Convert.ToInt32(this.CustomStrengthBox.Value);
    this.UpdateNumbers();
  }

  private void CustomWillBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomWill = Convert.ToInt32(this.CustomWillBox.Value);
    this.UpdateNumbers();
  }

  private void CustomSkillBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomSkill = Convert.ToInt32(this.CustomSkillBox.Value);
    this.UpdateNumbers();
  }

  private void CustomCelerityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomCelerity = Convert.ToInt32(this.CustomCelerityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomDefenseBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomDefense = Convert.ToInt32(this.CustomDefenseBox.Value);
    this.UpdateNumbers();
  }

  private void CustomResistanceBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomResistance = Convert.ToInt32(this.CustomResistanceBox.Value);
    this.UpdateNumbers();
  }

  private void CustomVitalityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomVitality = Convert.ToInt32(this.CustomVitalityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomFaithBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomFaith = Convert.ToInt32(this.CustomFaithBox.Value);
    this.UpdateNumbers();
  }

  private void CustomLuckBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomLuck = Convert.ToInt32(this.CustomLuckBox.Value);
    this.UpdateNumbers();
  }

  private void CustomGuileBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomGuile = Convert.ToInt32(this.CustomGuileBox.Value);
    this.UpdateNumbers();
  }

  private void CustomSanctityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomSanctity = Convert.ToInt32(this.CustomSanctityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomAptitudeBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomAptitude = Convert.ToInt32(this.CustomAptitudeBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseStrengthBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseStrength = Convert.ToInt32(this.CustomBaseStrengthBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseWillBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseWill = Convert.ToInt32(this.CustomBaseWillBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseSkillBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseSkill = Convert.ToInt32(this.CustomBaseSkillBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseCelerityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseCelerity = Convert.ToInt32(this.CustomBaseCelerityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseDefenseBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseDefense = Convert.ToInt32(this.CustomBaseDefenseBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseResistanceBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseResistance = Convert.ToInt32(this.CustomBaseResistanceBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseVitalityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseVitality = Convert.ToInt32(this.CustomBaseVitalityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseFaithBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseFaith = Convert.ToInt32(this.CustomBaseFaithBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseLuckBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseLuck = Convert.ToInt32(this.CustomBaseLuckBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseGuileBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseGuile = Convert.ToInt32(this.CustomBaseGuileBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseSanctityBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseSanctity = Convert.ToInt32(this.CustomBaseSanctityBox.Value);
    this.UpdateNumbers();
  }

  private void CustomBaseAptitudeBox_ValueChanged(object sender, EventArgs e)
  {
    this.CustomBaseAptitude = Convert.ToInt32(this.CustomBaseAptitudeBox.Value);
    this.UpdateNumbers();
  }

  internal void RetrievePointInput(int InputNumber, string StatName, string Operation)
  {
    switch (Operation)
    {
      case "Addition":
        if (StatName == "Evade" || StatName == "Crit Evade")
        {
          switch (StatName)
          {
            case "Evade":
              this.ExtraBaseEvade = (double) InputNumber;
              break;
            case "Crit Evade":
              this.ExtraCritEvade = (double) InputNumber;
              break;
          }
          this.UpdateNumbers();
          break;
        }
        if (this.TotalPoints < InputNumber)
          break;
        this.TotalPoints -= InputNumber;
        switch (StatName)
        {
          case "Aptitude":
            this.AddedAptitude += InputNumber;
            break;
          case "Celerity":
            this.AddedCelerity += InputNumber;
            break;
          case "Defense":
            this.AddedDefense += InputNumber;
            break;
          case "Faith":
            this.AddedFaith += InputNumber;
            break;
          case "Guile":
            this.AddedGuile += InputNumber;
            break;
          case "Luck":
            this.AddedLuck += InputNumber;
            break;
          case "Resistance":
            this.AddedResistance += InputNumber;
            break;
          case "Sanctity":
            this.AddedSanctity += InputNumber;
            break;
          case "Skill":
            this.AddedSkill += InputNumber;
            break;
          case "Strength":
            this.AddedStrength += InputNumber;
            break;
          case "Vitality":
            this.AddedVitality += InputNumber;
            break;
          case "Will":
            this.AddedWill += InputNumber;
            break;
        }
        this.UpdateNumbers();
        break;
      case "Subtraction":
        switch (StatName)
        {
          case "Strength":
            if (this.AddedStrength - this.AxysAlBonus < InputNumber)
              return;
            this.AddedStrength -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Will":
            if (this.AddedWill - this.KashIcBonus < InputNumber)
              return;
            this.AddedWill -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Skill":
            if (this.AddedSkill - this.ZeroGyBonus < InputNumber)
              return;
            this.AddedSkill -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Celerity":
            if (this.AddedCelerity - this.RabeUrBonus < InputNumber)
              return;
            this.AddedCelerity -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Defense":
            if (this.AddedDefense - this.GrenUtBonus < InputNumber)
              return;
            this.AddedDefense -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Vitality":
            if (this.AddedVitality - this.BldiIaBonus < InputNumber)
              return;
            this.AddedVitality -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Resistance":
            if (this.AddedResistance - this.ChoiErBonus < InputNumber)
              return;
            this.AddedResistance -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Faith":
            if (this.AddedFaith - this.HolyMrBonus < InputNumber)
              return;
            this.AddedFaith -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Luck":
            if (this.AddedLuck - this.KagiJiBonus < InputNumber)
              return;
            this.AddedLuck -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Guile":
            if (this.AddedGuile - this.AkurZoBonus < InputNumber)
              return;
            this.AddedGuile -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Sanctity":
            if (this.AddedSanctity - this.LunaCuBonus < InputNumber)
              return;
            this.AddedSanctity -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          case "Aptitude":
            if (this.AddedAptitude < InputNumber)
              return;
            this.AddedAptitude -= InputNumber;
            this.TotalPoints += InputNumber;
            this.UpdateNumbers();
            return;
          default:
            return;
        }
    }
  }

  internal double GetStrength() => this.EffectiveStrength;

  internal double GetWill() => this.EffectiveWill;

  internal double GetSkill() => this.EffectiveSkill;

  internal double GetCelerity() => this.EffectiveCelerity;

  internal double GetDefense() => this.EffectiveDefense;

  internal double GetResistance() => this.EffectiveResistance;

  internal double GetVitality() => this.EffectiveVitality;

  internal double GetFaith() => this.EffectiveFaith;

  internal double GetLuck() => this.EffectiveLuck;

  internal double GetGuile() => this.EffectiveGuile;

  internal double GetSanctity() => this.EffectiveSanctity;

  internal double GetAptitude() => this.EffectiveAptitude;

  private void DebugDRButton_Click(object sender, EventArgs e) => new DRDebug().Show();

  private void WeaponButton_Click(object sender, EventArgs e)
  {
    switch (this.WeaponCalculatorOpen)
    {
      case 0:
        this.WeaponForm = new WeaponCalculator(this);
        ++this.WeaponCalculatorOpen;
        this.WeaponForm.Show();
        break;
      case 1:
        this.WeaponForm2 = new WeaponCalculator(this);
        ++this.WeaponCalculatorOpen;
        this.WeaponForm2.Show();
        break;
      case 2:
        this.WeaponForm3 = new WeaponCalculator(this);
        ++this.WeaponCalculatorOpen;
        this.WeaponForm3.Show();
        break;
      case 3:
        this.WeaponForm4 = new WeaponCalculator(this);
        ++this.WeaponCalculatorOpen;
        this.WeaponForm4.Show();
        break;
    }
  }

  internal void ClosedWeaponCalculator() => --this.WeaponCalculatorOpen;

  private void ReductionButton_Click(object sender, EventArgs e)
  {
    if (this.ReductionWindowOpen > (byte) 0)
      return;
    this.ReductionForm = new ReductionWindow(this);
    ++this.ReductionWindowOpen;
    this.ReductionForm.Show();
  }

  internal void ClosedReductionCalculator() => --this.ReductionWindowOpen;

  internal void ClosedDamageCalculator() => --this.DamageWindowOpen;

  internal void ClosedPrintWindow() => this.PrintWindowOpen = false;

  private void TraitsButton_Click(object sender, EventArgs e)
  {
  }

  private void AstrologyButton_Click(object sender, EventArgs e)
  {
    if (this.AstrologyWindowOpen)
      return;
    this.AstrologyForm = new AstrologyWindow(this);
    this.AstrologyWindowOpen = true;
    this.AstrologyForm.Show();
  }

  private void StampsButton_Click(object sender, EventArgs e)
  {
    if (!this.StampsWindowOpen)
    {
      this.StampsForm = new StampWindow(this);
      this.StampsWindowOpen = true;
      this.StampsForm.Show();
    }
    this.StampsForm.Visible = true;
  }

  internal void ClosedTraitsWindow()
  {
  }

  internal void ClosedAstrologyWindow()
  {
    this.AstrologyWindowOpen = false;
    this.AstrologyForm = (AstrologyWindow) null;
    this.UpdateNumbers();
  }

  internal void SetTraitStrength(int x)
  {
    int num = x - this.TraitStrength;
    this.TraitStrength = x;
    this.AddedStrength += num;
    this.UpdateNumbers();
  }

  internal void SetTraitWill(int x)
  {
    int num = x - this.TraitWill;
    this.TraitWill = x;
    this.AddedWill += num;
    this.UpdateNumbers();
  }

  internal void SetTraitSkill(int x)
  {
    int num = x - this.TraitSkill;
    this.TraitSkill = x;
    this.AddedSkill += num;
    this.UpdateNumbers();
  }

  internal void SetTraitCelerity(int x)
  {
    int num = x - this.TraitCelerity;
    this.TraitCelerity = x;
    this.AddedCelerity += num;
    this.UpdateNumbers();
  }

  internal void SetTraitDefense(int x)
  {
    int num = x - this.TraitDefense;
    this.TraitDefense = x;
    this.AddedDefense += num;
    this.UpdateNumbers();
  }

  internal void SetTraitResistance(int x)
  {
    int num = x - this.TraitResistance;
    this.TraitResistance = x;
    this.AddedResistance += num;
    this.UpdateNumbers();
  }

  internal void SetTraitVitality(int x)
  {
    int num = x - this.TraitVitality;
    this.TraitVitality = x;
    this.AddedVitality += num;
    this.UpdateNumbers();
  }

  internal void SetTraitFaith(int x)
  {
    int num = x - this.TraitFaith;
    this.TraitFaith = x;
    this.AddedFaith += num;
    this.UpdateNumbers();
  }

  internal void SetTraitLuck(int x)
  {
    int num = x - this.TraitLuck;
    this.TraitLuck = x;
    this.AddedLuck += num;
    this.UpdateNumbers();
  }

  internal void StampStats()
  {
    if (this.StampsForm != null)
    {
      this.StampStrength = this.StampsForm.Str();
      this.StampWill = this.StampsForm.Wil();
      this.StampSkill = this.StampsForm.Ski();
      this.StampCelerity = this.StampsForm.Cel();
      this.StampVitality = this.StampsForm.Vit();
      this.StampFaith = this.StampsForm.Fai();
      this.StampWater = this.StampsForm.Water();
      this.StampEarth = this.StampsForm.Earth();
      this.StampLight = this.StampsForm.Light();
      this.StampDark = this.StampsForm.Dark();
    }
    else
    {
      this.StampStrength = 0;
      this.StampWill = 0;
      this.StampSkill = 0;
      this.StampCelerity = 0;
      this.StampVitality = 0;
      this.StampFaith = 0;
      this.StampWater = 0;
      this.StampEarth = 0;
      this.StampLight = 0;
      this.StampDark = 0;
    }
    this.UpdateNumbers();
  }

  internal int GetBaseStrength() => this.RacialStrength + this.AddedStrength;

  internal int GetBaseWill() => this.RacialWill + this.AddedWill;

  internal int GetBaseSkill() => this.RacialSkill + this.AddedSkill;

  internal int GetBaseCelerity() => this.RacialCelerity + this.AddedCelerity;

  internal int GetBaseDefense() => this.RacialDefense + this.AddedDefense;

  internal int GetBaseResistance() => this.RacialResistance + this.AddedResistance;

  internal int GetBaseVitality() => this.RacialVitality + this.AddedVitality;

  internal int GetBaseFaith() => this.RacialFaith + this.AddedFaith;

  internal int GetBaseLuck() => this.RacialLuck + this.AddedLuck;

  private void History()
  {
  }

  public void PrintUpdate() => this.PrintForm.ReceiveText(this.NewPrintFunction());

  private void PrintButton_Click(object sender, EventArgs e)
  {
    if (this.PrintWindowOpen)
      return;
    this.PrintForm = new PrintWindow(this);
    this.PrintForm.Show();
    this.PrintWindowOpen = true;
  }

  public string NewPrintFunction()
  {
    using (StringWriter stringWriter = new StringWriter())
    {
      if (this.RaceBox.SelectedItem != null)
        stringWriter.WriteLine(this.RaceBox.SelectedItem.ToString());
      if (this.Subrace)
        stringWriter.WriteLine("Subrace: " + this.SubraceBox.SelectedItem.ToString());
      if (this.ClassBox.SelectedItem != null)
      {
        if (this.ClassBox.SelectedItem == this.SubClassBox.SelectedItem)
          stringWriter.WriteLine("Monoclass " + this.MainClass);
        else
          stringWriter.WriteLine($"{this.MainClass} / {this.SubClass}");
      }
      this.History();
      stringWriter.WriteLine(this.HistoryString);
      stringWriter.WriteLine($"STR: {(this.AddedStrength - (this.AxysAlBonus + this.TraitStrength)).ToString()} ( +{this.CustomStrengthBox.Value.ToString()} )");
      stringWriter.WriteLine($"WIL: {(this.AddedWill - (this.TraitWill + this.KashIcBonus)).ToString()} ( +{this.CustomWillBox.Value.ToString()} )");
      stringWriter.WriteLine($"SKI: {(this.AddedSkill - (this.TraitSkill + this.ZeroGyBonus)).ToString()} ( +{this.CustomSkillBox.Value.ToString()} )");
      stringWriter.WriteLine($"CEL: {(this.AddedCelerity - (this.TraitCelerity + this.RabeUrBonus)).ToString()} ( +{this.CustomCelerityBox.Value.ToString()} )");
      stringWriter.WriteLine($"DEF: {(this.AddedDefense - (this.TraitDefense + this.GrenUtBonus)).ToString()} ( +{this.CustomDefenseBox.Value.ToString()} )");
      stringWriter.WriteLine($"RES: {(this.AddedResistance - (this.TraitResistance + this.ChoiErBonus)).ToString()} ( +{this.CustomResistanceBox.Value.ToString()} )");
      stringWriter.WriteLine($"VIT: {(this.AddedVitality - (this.TraitVitality + this.BldiIaBonus)).ToString()} ( +{this.CustomVitalityBox.Value.ToString()} )");
      stringWriter.WriteLine($"FAI: {(this.AddedFaith - (this.TraitFaith + this.HolyMrBonus)).ToString()} ( +{this.CustomFaithBox.Value.ToString()} )");
      stringWriter.WriteLine($"LUC: {(this.AddedLuck - (this.TraitLuck + this.KagiJiBonus)).ToString()} ( +{this.CustomLuckBox.Value.ToString()} )");
      stringWriter.WriteLine($"GUI: {(this.AddedGuile - this.AkurZoBonus).ToString()} ( +{this.CustomGuileBox.Value.ToString()} )");
      stringWriter.WriteLine($"SAN: {(this.AddedSanctity - this.LunaCuBonus).ToString()} ( +{this.CustomSanctityBox.Value.ToString()} )");
      stringWriter.WriteLine($"APT: {this.AddedAptitude.ToString()} ( +{this.CustomAptitudeBox.Value.ToString()} )");
      stringWriter.WriteLine("");
      stringWriter.WriteLine($"Total Evade: {this.TotalEvade.ToString()} / Stat Evade: {this.StatEvade.ToString()}");
      stringWriter.WriteLine("Evade Cap: " + this.EvadeCap.ToString());
      stringWriter.WriteLine("Crit Evade: " + (this.BaseCritEvade + this.ExtraCritEvade).ToString());
      if (this.WeaponCalculatorOpen == (byte) 1)
      {
        stringWriter.WriteLine($"W1: {this.WeaponForm.EnchantChoice} {this.WeaponForm.WeaponChoice}");
        stringWriter.WriteLine("W1 Projected SWA: " + this.WeaponForm.SWA.ToString());
      }
      if (this.WeaponCalculatorOpen == (byte) 2)
      {
        stringWriter.WriteLine($"W1: {this.WeaponForm.EnchantChoice} {this.WeaponForm.WeaponChoice}");
        stringWriter.WriteLine("W1 Projected SWA: " + this.WeaponForm.SWA.ToString());
        stringWriter.WriteLine($"W2: {this.WeaponForm2.EnchantChoice} {this.WeaponForm2.WeaponChoice}");
        stringWriter.WriteLine("W2 Projected SWA: " + this.WeaponForm2.SWA.ToString());
      }
      if (this.FoodBox.SelectedItem != null)
        stringWriter.WriteLine("Food: " + this.FoodBox.SelectedItem.ToString());
      if (this.AstrologyMars != 0)
        stringWriter.WriteLine("Astrology: Mars");
      else if (this.AstrologyMercury != 0)
        stringWriter.WriteLine("Astrology: Mercury");
      else if (this.AstrologyJupiter != 0)
        stringWriter.WriteLine("Astrology: Jupiter");
      else if (this.AstrologyNeptune != 0)
        stringWriter.WriteLine("Astrology: Neptune");
      else if (this.AstrologyPluto != 0)
        stringWriter.WriteLine("Astrology: Pluto");
      else if (this.AstrologySaturn != 0)
        stringWriter.WriteLine("Astrology: Saturn");
      else if (this.AstrologyUranus != 0)
        stringWriter.WriteLine("Astrology: Uranus");
      else if (this.AstrologyVenus != 0)
        stringWriter.WriteLine("Astrology: Venus");
      if (this.GiantGeneCheckBox.Checked)
        stringWriter.WriteLine("Giant Gene");
      stringWriter.WriteLine("");
      stringWriter.WriteLine("===Aspects===");
      if (this.AxysAlBonus != 0)
        stringWriter.WriteLine("Axys Al (STR)");
      if (this.KashIcBonus != 0)
        stringWriter.WriteLine("Kash Ic (WIL)");
      if (this.RabeUrBonus != 0)
        stringWriter.WriteLine("Rabe Ur (CEL)");
      if (this.ZeroGyBonus != 0)
        stringWriter.WriteLine("Zero Gy (SKI)");
      if (this.GrenUtBonus != 0)
        stringWriter.WriteLine("Gren Ut (DEF)");
      if (this.ChoiErBonus != 0)
        stringWriter.WriteLine("Choi Er (RES)");
      if (this.BldiIaBonus != 0)
        stringWriter.WriteLine("Bldi Ia (VIT)");
      if (this.HolyMrBonus != 0)
        stringWriter.WriteLine("Holy Mr (FAI)");
      if (this.KagiJiBonus != 0)
        stringWriter.WriteLine("Kage Ji (LUC)");
      if (this.LunaCuBonus != 0)
        stringWriter.WriteLine("Luna Cu (SAN)");
      if (this.AkurZoBonus != 0)
        stringWriter.WriteLine("Akur Zo (GUI)");
      stringWriter.WriteLine("");
      string str = stringWriter.ToString();
      stringWriter.Dispose();
      stringWriter.Close();
      return str;
    }
  }

  public void PrintFunction()
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "Text Files | *.txt";
    saveFileDialog.DefaultExt = "txt";
    saveFileDialog.OverwritePrompt = true;
    if (saveFileDialog.ShowDialog() != DialogResult.OK)
      return;
    if (File.Exists(saveFileDialog.FileName))
      File.Delete(saveFileDialog.FileName);
    using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
    {
      using (StreamWriter streamWriter = new StreamWriter(stream))
      {
        if (this.RaceBox.SelectedItem != null)
          streamWriter.WriteLine(this.RaceBox.SelectedItem.ToString());
        if (this.ClassBox.SelectedItem != null)
        {
          if (this.ClassBox.SelectedItem == this.SubClassBox.SelectedItem)
            streamWriter.WriteLine("Monoclass " + this.MainClass);
          else
            streamWriter.WriteLine($"{this.MainClass} / {this.SubClass}");
        }
        if (this.Subrace)
          streamWriter.WriteLine("Subrace: " + this.SubraceBox.SelectedItem.ToString());
        this.History();
        streamWriter.WriteLine(this.HistoryString);
        streamWriter.WriteLine($"STR: {(this.AddedStrength - (this.AxysAlBonus + this.TraitStrength)).ToString()} ( +{this.CustomStrengthBox.Value.ToString()} )");
        streamWriter.WriteLine($"WIL: {(this.AddedWill - (this.TraitWill + this.KashIcBonus)).ToString()} ( +{this.CustomWillBox.Value.ToString()} )");
        streamWriter.WriteLine($"SKI: {(this.AddedSkill - (this.TraitSkill + this.ZeroGyBonus)).ToString()} ( +{this.CustomSkillBox.Value.ToString()} )");
        streamWriter.WriteLine($"CEL: {(this.AddedCelerity - (this.TraitCelerity + this.RabeUrBonus)).ToString()} ( +{this.CustomCelerityBox.Value.ToString()} )");
        streamWriter.WriteLine($"DEF: {(this.AddedDefense - (this.TraitDefense + this.GrenUtBonus)).ToString()} ( +{this.CustomDefenseBox.Value.ToString()} )");
        streamWriter.WriteLine($"RES: {(this.AddedResistance - (this.TraitResistance + this.ChoiErBonus)).ToString()} ( +{this.CustomResistanceBox.Value.ToString()} )");
        streamWriter.WriteLine($"VIT: {(this.AddedVitality - (this.TraitVitality + this.BldiIaBonus)).ToString()} ( +{this.CustomVitalityBox.Value.ToString()} )");
        streamWriter.WriteLine($"FAI: {(this.AddedFaith - (this.TraitFaith + this.HolyMrBonus)).ToString()} ( +{this.CustomFaithBox.Value.ToString()} )");
        streamWriter.WriteLine($"LUC: {(this.AddedLuck - (this.TraitLuck + this.KagiJiBonus)).ToString()} ( +{this.CustomLuckBox.Value.ToString()} )");
        streamWriter.WriteLine($"GUI: {(this.AddedGuile - this.AkurZoBonus).ToString()} ( +{this.CustomGuileBox.Value.ToString()} )");
        streamWriter.WriteLine($"SAN: {(this.AddedSanctity - this.LunaCuBonus).ToString()} ( +{this.CustomSanctityBox.Value.ToString()} )");
        streamWriter.WriteLine($"APT: {this.AddedAptitude.ToString()} ( +{this.CustomAptitudeBox.Value.ToString()} )");
        streamWriter.WriteLine("");
        streamWriter.WriteLine($"Total Evade: {this.TotalEvade.ToString()} / Stat Evade: {this.StatEvade.ToString()}");
        streamWriter.WriteLine("Evade Cap: " + this.EvadeCap.ToString());
        streamWriter.WriteLine("Crit Evade: " + (this.BaseCritEvade + this.ExtraCritEvade).ToString());
        if (this.WeaponCalculatorOpen == (byte) 1)
        {
          streamWriter.WriteLine($"W1: {this.WeaponForm.EnchantChoice} {this.WeaponForm.WeaponChoice}");
          streamWriter.WriteLine("W1 Projected SWA: " + this.WeaponForm.SWA.ToString());
        }
        if (this.WeaponCalculatorOpen == (byte) 2)
        {
          streamWriter.WriteLine($"W1: {this.WeaponForm.EnchantChoice} {this.WeaponForm.WeaponChoice}");
          streamWriter.WriteLine("W1 Projected SWA: " + this.WeaponForm.SWA.ToString());
          streamWriter.WriteLine($"W2: {this.WeaponForm2.EnchantChoice} {this.WeaponForm2.WeaponChoice}");
          streamWriter.WriteLine("W2 Projected SWA: " + this.WeaponForm2.SWA.ToString());
        }
        if (this.FoodBox.SelectedItem != null)
          streamWriter.WriteLine("Food: " + this.FoodBox.SelectedItem.ToString());
        if (this.AstrologyMars != 0)
          streamWriter.WriteLine("Astrology: Mars");
        else if (this.AstrologyMercury != 0)
          streamWriter.WriteLine("Astrology: Mercury");
        else if (this.AstrologyJupiter != 0)
          streamWriter.WriteLine("Astrology: Jupiter");
        else if (this.AstrologyNeptune != 0)
          streamWriter.WriteLine("Astrology: Neptune");
        else if (this.AstrologyPluto != 0)
          streamWriter.WriteLine("Astrology: Pluto");
        else if (this.AstrologySaturn != 0)
          streamWriter.WriteLine("Astrology: Saturn");
        else if (this.AstrologyUranus != 0)
          streamWriter.WriteLine("Astrology: Uranus");
        else if (this.AstrologyVenus != 0)
          streamWriter.WriteLine("Astrology: Venus");
        if (this.GiantGeneCheckBox.Checked)
          streamWriter.WriteLine("Giant Gene");
        streamWriter.WriteLine("");
        streamWriter.WriteLine("===Aspects===");
        if (this.AxysAlBonus != 0)
          streamWriter.WriteLine("Axys Al (STR)");
        if (this.KashIcBonus != 0)
          streamWriter.WriteLine("Kash Ic (WIL)");
        if (this.RabeUrBonus != 0)
          streamWriter.WriteLine("Rabe Ur (CEL)");
        if (this.ZeroGyBonus != 0)
          streamWriter.WriteLine("Zero Gy (SKI)");
        if (this.GrenUtBonus != 0)
          streamWriter.WriteLine("Gren Ut (DEF)");
        if (this.ChoiErBonus != 0)
          streamWriter.WriteLine("Choi Er (RES)");
        if (this.BldiIaBonus != 0)
          streamWriter.WriteLine("Bldi Ia (VIT)");
        if (this.HolyMrBonus != 0)
          streamWriter.WriteLine("Holy Mr (FAI)");
        if (this.KagiJiBonus != 0)
          streamWriter.WriteLine("Kage Ji (LUC)");
        if (this.LunaCuBonus != 0)
          streamWriter.WriteLine("Luna Cu (SAN)");
        if (this.AkurZoBonus != 0)
          streamWriter.WriteLine("Akur Zo (GUI)");
        streamWriter.WriteLine("");
        streamWriter.Dispose();
        streamWriter.Close();
      }
    }
  }

  private int FireResistance()
  {
    int num = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Phenex")
      num += 15;
    if (this.RaceBoxValue == "Hyattr")
      num += 15;
    if (this.RaceBoxValue == "M-Type A" || this.RaceBoxValue == "M-Type C" || this.RaceBoxValue == "M-Type R" || this.RaceBoxValue == "M-Type S")
      num += 15;
    if (this.RaceBoxValue == "Doriad")
      num -= 15;
    return num;
  }

  private int IceResistance()
  {
    int num = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Phenex")
      num -= 15;
    if (this.RaceBoxValue == "Reaper" || this.RaceBoxValue == "Apertaurus")
      num += 10 + (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "M-Type A" || this.RaceBoxValue == "M-Type C" || this.RaceBoxValue == "M-Type R" || this.RaceBoxValue == "M-Type S")
      num += 15;
    if (this.RaceBoxValue == "Wild Elf")
      num -= 15;
    return num;
  }

  private int WindResistance()
  {
    int num1 = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Hyattr")
      num1 += -15;
    if (this.RaceBoxValue == "Papilion")
    {
      int num2 = 30 - (int) this.EffectiveSanctity;
      if (num2 > 0)
        num1 += num2;
    }
    if (this.RaceBoxValue == "Reaper" || this.RaceBoxValue == "Apertaurus")
      num1 += -10;
    return num1;
  }

  private int EarthResistance()
  {
    int num1 = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Papilion")
    {
      int num2 = 30 - (int) this.EffectiveSanctity;
      if (num2 > 0)
        num1 -= num2;
    }
    if (this.RaceBoxValue == "Doriad")
      num1 += 15;
    if (this.RaceBoxValue == "Wild Elf")
      num1 += 15;
    return num1 + this.StampEarth;
  }

  private int DarkResistance()
  {
    int num1 = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Phenex")
      num1 -= 15;
    if (this.RaceBoxValue == "Elf")
      num1 -= 25;
    if (this.RaceBoxValue == "Umbral")
    {
      int num2 = 25 - (int) this.EffectiveSanctity;
      if (num2 > 0)
        num1 += num2;
    }
    if (this.RaceBoxValue == "Vampire" && this.SanguineCrestBox.Checked)
      num1 += 25;
    if (this.RaceBoxValue == "Doriad")
      num1 -= 15;
    return num1 + this.StampDark;
  }

  private int WaterResistance()
  {
    int num = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Elf")
      num += 25;
    if (this.RaceBoxValue == "Doriad")
      num += 15;
    if (this.RaceBoxValue == "Theno")
      num += 15;
    return num + this.StampWater;
  }

  private int LightResistance()
  {
    int num1 = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "Phenex")
      num1 += 15;
    if (this.RaceBoxValue == "Umbral")
    {
      int num2 = 25 - (int) this.EffectiveSanctity;
      if (num2 > 0)
        num1 -= num2;
    }
    if (this.RaceBoxValue == "Vampire" && this.SanguineCrestBox.Checked)
      num1 -= 25;
    return num1 + this.StampLight;
  }

  private int LightningResistance()
  {
    int num = (int) this.EffectiveSanctity / 6;
    if (this.RaceBoxValue == "M-Type A" || this.RaceBoxValue == "M-Type C" || this.RaceBoxValue == "M-Type R" || this.RaceBoxValue == "M-Type S")
      num -= 25;
    if (this.RaceBoxValue == "Theno")
      num -= 15;
    return num;
  }

  private int AcidResistance()
  {
    int num = 0;
    if (this.RaceBoxValue == "Theno")
      num -= 15;
    return num;
  }

  private int SoundResistance()
  {
    int num = 0;
    if (this.RaceBoxValue == "Theno")
      num += 15;
    return num;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainWindow));
    this.StrengthNameLabel = new Label();
    this.WillNameLabel = new Label();
    this.SkillNameLabel = new Label();
    this.CelerityNameLabel = new Label();
    this.DefenseNameLabel = new Label();
    this.ResistanceNameLabel = new Label();
    this.VitalityNameLabel = new Label();
    this.FaithNameLabel = new Label();
    this.LuckNameLabel = new Label();
    this.GuileNameLabel = new Label();
    this.SanctityNameLabel = new Label();
    this.AptitudeNameLabel = new Label();
    this.StrengthLabel = new Label();
    this.WillLabel = new Label();
    this.SkillLabel = new Label();
    this.CelerityLabel = new Label();
    this.DefenseLabel = new Label();
    this.ResistanceLabel = new Label();
    this.VitalityLabel = new Label();
    this.FaithLabel = new Label();
    this.LuckLabel = new Label();
    this.GuileLabel = new Label();
    this.SanctityLabel = new Label();
    this.AptitudeLabel = new Label();
    this.TotalPointsLabel = new Label();
    this.ClassBox = new ComboBox();
    this.RaceBox = new ComboBox();
    this.ClassLabel = new Label();
    this.RaceLabel = new Label();
    this.ResetButton = new Button();
    this.Tooltip = new ToolTip(this.components);
    this.AkurZoButton = new PictureBox();
    this.LunaCuButton = new PictureBox();
    this.ZeroGyButton = new PictureBox();
    this.RabeUrButton = new PictureBox();
    this.KashIcButton = new PictureBox();
    this.KagiJiButton = new PictureBox();
    this.HolyMrButton = new PictureBox();
    this.GrenUtButton = new PictureBox();
    this.ChoiErButton = new PictureBox();
    this.BldiIaButton = new PictureBox();
    this.AxysAlButton = new PictureBox();
    this.AllLEButton = new PictureBox();
    this.EvadeLabel = new Label();
    this.CritEvadeLabel = new Label();
    this.VersionLabel = new Label();
    this.CustomStrengthBox = new NumericUpDown();
    this.CustomWillBox = new NumericUpDown();
    this.CustomSkillBox = new NumericUpDown();
    this.CustomCelerityBox = new NumericUpDown();
    this.CustomDefenseBox = new NumericUpDown();
    this.CustomResistanceBox = new NumericUpDown();
    this.CustomVitalityBox = new NumericUpDown();
    this.CustomFaithBox = new NumericUpDown();
    this.CustomLuckBox = new NumericUpDown();
    this.CustomGuileBox = new NumericUpDown();
    this.CustomSanctityBox = new NumericUpDown();
    this.CustomAptitudeBox = new NumericUpDown();
    this.CustomLabel = new Label();
    this.HPLabel = new Label();
    this.MPLabel = new Label();
    this.DebugDRButton = new Button();
    this.PhysDefLabel = new Label();
    this.MagDefLabel = new Label();
    this.StatusInflictLabel = new Label();
    this.StatusResistLabel = new Label();
    this.FlankingLabel = new Label();
    this.SkillPoolLabel = new Label();
    this.EncumbranceLabel = new Label();
    this.BattleWeightLabel = new Label();
    this.WeaponButton = new Button();
    this.BaseLabel = new Label();
    this.CustomBaseAptitudeBox = new NumericUpDown();
    this.CustomBaseSanctityBox = new NumericUpDown();
    this.CustomBaseGuileBox = new NumericUpDown();
    this.CustomBaseLuckBox = new NumericUpDown();
    this.CustomBaseFaithBox = new NumericUpDown();
    this.CustomBaseVitalityBox = new NumericUpDown();
    this.CustomBaseResistanceBox = new NumericUpDown();
    this.CustomBaseDefenseBox = new NumericUpDown();
    this.CustomBaseCelerityBox = new NumericUpDown();
    this.CustomBaseSkillBox = new NumericUpDown();
    this.CustomBaseWillBox = new NumericUpDown();
    this.CustomBaseStrengthBox = new NumericUpDown();
    this.label7 = new Label();
    this.CustomHPBox = new NumericUpDown();
    this.CustomMPBox = new NumericUpDown();
    this.label8 = new Label();
    this.GiantGeneCheckBox = new CheckBox();
    this.ElemATKLabel = new Label();
    this.SoundATKLabel = new Label();
    this.AcidATKLabel = new Label();
    this.LightningATKLabel = new Label();
    this.LightATKLabel = new Label();
    this.WaterATKLabel = new Label();
    this.DarkATKLabel = new Label();
    this.EarthATKLabel = new Label();
    this.WindATKLabel = new Label();
    this.IceATKLabel = new Label();
    this.FireATKLabel = new Label();
    this.PrintButton = new Button();
    this.DragonKingBox = new NumericUpDown();
    this.DragonKingLabel = new Label();
    this.SoundRESLabel = new Label();
    this.AcidRESLabel = new Label();
    this.LightningRESLabel = new Label();
    this.LightRESLabel = new Label();
    this.WaterRESLabel = new Label();
    this.DarkRESLabel = new Label();
    this.EarthRESLabel = new Label();
    this.WindRESLabel = new Label();
    this.IceRESLabel = new Label();
    this.FireRESLabel = new Label();
    this.label17 = new Label();
    this.StampsButton = new Button();
    this.CustomSoundATKBox = new NumericUpDown();
    this.CustomAcidATKBox = new NumericUpDown();
    this.CustomLightningATKBox = new NumericUpDown();
    this.CustomLightATKBox = new NumericUpDown();
    this.CustomWaterATKBox = new NumericUpDown();
    this.CustomDarkATKBox = new NumericUpDown();
    this.CustomEarthATKBox = new NumericUpDown();
    this.CustomWindATKBox = new NumericUpDown();
    this.CustomIceATKBox = new NumericUpDown();
    this.CustomFireATKBox = new NumericUpDown();
    this.CustomSoundRESBox = new NumericUpDown();
    this.CustomAcidRESBox = new NumericUpDown();
    this.CustomLightningRESBox = new NumericUpDown();
    this.CustomLightRESBox = new NumericUpDown();
    this.CustomWaterRESBox = new NumericUpDown();
    this.CustomDarkRESBox = new NumericUpDown();
    this.CustomEarthRESBox = new NumericUpDown();
    this.CustomWindRESBox = new NumericUpDown();
    this.CustomIceRESBox = new NumericUpDown();
    this.CustomFireRESBox = new NumericUpDown();
    this.label4 = new Label();
    this.HPPercent = new NumericUpDown();
    this.EnduranceBox = new CheckBox();
    this.ReductionButton = new Button();
    this.RisingNumeric = new NumericUpDown();
    this.RisingLabel = new Label();
    this.TotalHPPercent = new NumericUpDown();
    this.label6 = new Label();
    this.InitativeLabel = new Label();
    this.LuminaryBox = new CheckBox();
    this.Fortitude = new CheckBox();
    this.PainTolLabel = new Label();
    this.PainTol = new NumericUpDown();
    this.Warwalk = new CheckBox();
    this.Youkai = new Label();
    this.label2 = new Label();
    this.SubClassBox = new ComboBox();
    this.SanguineCrestBox = new CheckBox();
    this.Essence = new Label();
    this.GrimalkinI = new CheckBox();
    this.MainClassPassive = new Label();
    this.MainClassNum = new NumericUpDown();
    this.SubClassPassive = new Label();
    this.SubClassNum = new NumericUpDown();
    this.FoodBox = new ComboBox();
    this.label10 = new Label();
    this.AstrologyButton = new Button();
    this.AptitudeMinus = new Button();
    this.SanctityMinus = new Button();
    this.GuileMinus = new Button();
    this.LuckMinus = new Button();
    this.FaithMinus = new Button();
    this.VitalityMinus = new Button();
    this.ResistanceMinus = new Button();
    this.DefenseMinus = new Button();
    this.CelerityMinus = new Button();
    this.SkillMinus = new Button();
    this.WillMinus = new Button();
    this.StrengthMinus = new Button();
    this.AptitudePlus = new Button();
    this.SanctityPlus = new Button();
    this.GuilePlus = new Button();
    this.LuckPlus = new Button();
    this.FaithPlus = new Button();
    this.VitalityPlus = new Button();
    this.ResistancePlus = new Button();
    this.DefensePlus = new Button();
    this.CelerityPlus = new Button();
    this.SkillPlus = new Button();
    this.WillPlus = new Button();
    this.StrengthPlus = new Button();
    this.pictureBox1 = new PictureBox();
    this.KorvaraFP = new NumericUpDown();
    this.label3 = new Label();
    this.KorvaraHP = new NumericUpDown();
    this.label11 = new Label();
    this.DateLabel = new Label();
    this.label9 = new Label();
    this.DragonQueenBox = new NumericUpDown();
    this.button1 = new Button();
    this.HistoryListBox = new ComboBox();
    this.EquipBTN = new Button();
    this.SubraceBox = new ComboBox();
    ((ISupportInitialize) this.AkurZoButton).BeginInit();
    ((ISupportInitialize) this.LunaCuButton).BeginInit();
    ((ISupportInitialize) this.ZeroGyButton).BeginInit();
    ((ISupportInitialize) this.RabeUrButton).BeginInit();
    ((ISupportInitialize) this.KashIcButton).BeginInit();
    ((ISupportInitialize) this.KagiJiButton).BeginInit();
    ((ISupportInitialize) this.HolyMrButton).BeginInit();
    ((ISupportInitialize) this.GrenUtButton).BeginInit();
    ((ISupportInitialize) this.ChoiErButton).BeginInit();
    ((ISupportInitialize) this.BldiIaButton).BeginInit();
    ((ISupportInitialize) this.AxysAlButton).BeginInit();
    ((ISupportInitialize) this.AllLEButton).BeginInit();
    this.CustomStrengthBox.BeginInit();
    this.CustomWillBox.BeginInit();
    this.CustomSkillBox.BeginInit();
    this.CustomCelerityBox.BeginInit();
    this.CustomDefenseBox.BeginInit();
    this.CustomResistanceBox.BeginInit();
    this.CustomVitalityBox.BeginInit();
    this.CustomFaithBox.BeginInit();
    this.CustomLuckBox.BeginInit();
    this.CustomGuileBox.BeginInit();
    this.CustomSanctityBox.BeginInit();
    this.CustomAptitudeBox.BeginInit();
    this.CustomBaseAptitudeBox.BeginInit();
    this.CustomBaseSanctityBox.BeginInit();
    this.CustomBaseGuileBox.BeginInit();
    this.CustomBaseLuckBox.BeginInit();
    this.CustomBaseFaithBox.BeginInit();
    this.CustomBaseVitalityBox.BeginInit();
    this.CustomBaseResistanceBox.BeginInit();
    this.CustomBaseDefenseBox.BeginInit();
    this.CustomBaseCelerityBox.BeginInit();
    this.CustomBaseSkillBox.BeginInit();
    this.CustomBaseWillBox.BeginInit();
    this.CustomBaseStrengthBox.BeginInit();
    this.CustomHPBox.BeginInit();
    this.CustomMPBox.BeginInit();
    this.DragonKingBox.BeginInit();
    this.CustomSoundATKBox.BeginInit();
    this.CustomAcidATKBox.BeginInit();
    this.CustomLightningATKBox.BeginInit();
    this.CustomLightATKBox.BeginInit();
    this.CustomWaterATKBox.BeginInit();
    this.CustomDarkATKBox.BeginInit();
    this.CustomEarthATKBox.BeginInit();
    this.CustomWindATKBox.BeginInit();
    this.CustomIceATKBox.BeginInit();
    this.CustomFireATKBox.BeginInit();
    this.CustomSoundRESBox.BeginInit();
    this.CustomAcidRESBox.BeginInit();
    this.CustomLightningRESBox.BeginInit();
    this.CustomLightRESBox.BeginInit();
    this.CustomWaterRESBox.BeginInit();
    this.CustomDarkRESBox.BeginInit();
    this.CustomEarthRESBox.BeginInit();
    this.CustomWindRESBox.BeginInit();
    this.CustomIceRESBox.BeginInit();
    this.CustomFireRESBox.BeginInit();
    this.HPPercent.BeginInit();
    this.RisingNumeric.BeginInit();
    this.TotalHPPercent.BeginInit();
    this.PainTol.BeginInit();
    this.MainClassNum.BeginInit();
    this.SubClassNum.BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.KorvaraFP.BeginInit();
    this.KorvaraHP.BeginInit();
    this.DragonQueenBox.BeginInit();
    this.SuspendLayout();
    this.StrengthNameLabel.AutoSize = true;
    this.StrengthNameLabel.Location = new Point(11, 191);
    this.StrengthNameLabel.Name = "StrengthNameLabel";
    this.StrengthNameLabel.Size = new Size(47, 13);
    this.StrengthNameLabel.TabIndex = 0;
    this.StrengthNameLabel.Text = "Strength";
    this.WillNameLabel.AutoSize = true;
    this.WillNameLabel.Location = new Point(11, 215);
    this.WillNameLabel.Name = "WillNameLabel";
    this.WillNameLabel.Size = new Size(24, 13);
    this.WillNameLabel.TabIndex = 1;
    this.WillNameLabel.Text = "Will";
    this.SkillNameLabel.AutoSize = true;
    this.SkillNameLabel.Location = new Point(11, 237);
    this.SkillNameLabel.Name = "SkillNameLabel";
    this.SkillNameLabel.Size = new Size(26, 13);
    this.SkillNameLabel.TabIndex = 2;
    this.SkillNameLabel.Text = "Skill";
    this.CelerityNameLabel.AutoSize = true;
    this.CelerityNameLabel.Location = new Point(11, 262);
    this.CelerityNameLabel.Name = "CelerityNameLabel";
    this.CelerityNameLabel.Size = new Size(41, 13);
    this.CelerityNameLabel.TabIndex = 3;
    this.CelerityNameLabel.Text = "Celerity";
    this.DefenseNameLabel.AutoSize = true;
    this.DefenseNameLabel.Location = new Point(11, 285);
    this.DefenseNameLabel.Name = "DefenseNameLabel";
    this.DefenseNameLabel.Size = new Size(47, 13);
    this.DefenseNameLabel.TabIndex = 4;
    this.DefenseNameLabel.Text = "Defense";
    this.ResistanceNameLabel.AutoSize = true;
    this.ResistanceNameLabel.Location = new Point(11, 308);
    this.ResistanceNameLabel.Name = "ResistanceNameLabel";
    this.ResistanceNameLabel.Size = new Size(60, 13);
    this.ResistanceNameLabel.TabIndex = 5;
    this.ResistanceNameLabel.Text = "Resistance";
    this.VitalityNameLabel.AutoSize = true;
    this.VitalityNameLabel.Location = new Point(11, 330);
    this.VitalityNameLabel.Name = "VitalityNameLabel";
    this.VitalityNameLabel.Size = new Size(37, 13);
    this.VitalityNameLabel.TabIndex = 6;
    this.VitalityNameLabel.Text = "Vitality";
    this.FaithNameLabel.AutoSize = true;
    this.FaithNameLabel.Location = new Point(11, 352);
    this.FaithNameLabel.Name = "FaithNameLabel";
    this.FaithNameLabel.Size = new Size(30, 13);
    this.FaithNameLabel.TabIndex = 7;
    this.FaithNameLabel.Text = "Faith";
    this.LuckNameLabel.AutoSize = true;
    this.LuckNameLabel.Location = new Point(11, 375);
    this.LuckNameLabel.Name = "LuckNameLabel";
    this.LuckNameLabel.Size = new Size(31 /*0x1F*/, 13);
    this.LuckNameLabel.TabIndex = 8;
    this.LuckNameLabel.Text = "Luck";
    this.GuileNameLabel.AutoSize = true;
    this.GuileNameLabel.Location = new Point(11, 398);
    this.GuileNameLabel.Name = "GuileNameLabel";
    this.GuileNameLabel.Size = new Size(31 /*0x1F*/, 13);
    this.GuileNameLabel.TabIndex = 9;
    this.GuileNameLabel.Text = "Guile";
    this.SanctityNameLabel.AutoSize = true;
    this.SanctityNameLabel.Location = new Point(11, 421);
    this.SanctityNameLabel.Name = "SanctityNameLabel";
    this.SanctityNameLabel.Size = new Size(45, 13);
    this.SanctityNameLabel.TabIndex = 10;
    this.SanctityNameLabel.Text = "Sanctity";
    this.AptitudeNameLabel.AutoSize = true;
    this.AptitudeNameLabel.Location = new Point(11, 443);
    this.AptitudeNameLabel.Name = "AptitudeNameLabel";
    this.AptitudeNameLabel.Size = new Size(46, 13);
    this.AptitudeNameLabel.TabIndex = 11;
    this.AptitudeNameLabel.Text = "Aptitude";
    this.StrengthLabel.AutoSize = true;
    this.StrengthLabel.Location = new Point(93, 191);
    this.StrengthLabel.Name = "StrengthLabel";
    this.StrengthLabel.Size = new Size(13, 13);
    this.StrengthLabel.TabIndex = 12;
    this.StrengthLabel.Text = "0";
    this.WillLabel.AutoSize = true;
    this.WillLabel.Location = new Point(93, 215);
    this.WillLabel.Name = "WillLabel";
    this.WillLabel.Size = new Size(13, 13);
    this.WillLabel.TabIndex = 13;
    this.WillLabel.Text = "0";
    this.SkillLabel.AutoSize = true;
    this.SkillLabel.Location = new Point(93, 237);
    this.SkillLabel.Name = "SkillLabel";
    this.SkillLabel.Size = new Size(13, 13);
    this.SkillLabel.TabIndex = 14;
    this.SkillLabel.Text = "0";
    this.CelerityLabel.AutoSize = true;
    this.CelerityLabel.Location = new Point(93, 262);
    this.CelerityLabel.Name = "CelerityLabel";
    this.CelerityLabel.Size = new Size(13, 13);
    this.CelerityLabel.TabIndex = 15;
    this.CelerityLabel.Text = "0";
    this.DefenseLabel.AutoSize = true;
    this.DefenseLabel.Location = new Point(93, 285);
    this.DefenseLabel.Name = "DefenseLabel";
    this.DefenseLabel.Size = new Size(13, 13);
    this.DefenseLabel.TabIndex = 16 /*0x10*/;
    this.DefenseLabel.Text = "0";
    this.ResistanceLabel.AutoSize = true;
    this.ResistanceLabel.Location = new Point(93, 308);
    this.ResistanceLabel.Name = "ResistanceLabel";
    this.ResistanceLabel.Size = new Size(13, 13);
    this.ResistanceLabel.TabIndex = 17;
    this.ResistanceLabel.Text = "0";
    this.VitalityLabel.AutoSize = true;
    this.VitalityLabel.Location = new Point(93, 330);
    this.VitalityLabel.Name = "VitalityLabel";
    this.VitalityLabel.Size = new Size(13, 13);
    this.VitalityLabel.TabIndex = 18;
    this.VitalityLabel.Text = "0";
    this.FaithLabel.AutoSize = true;
    this.FaithLabel.Location = new Point(93, 352);
    this.FaithLabel.Name = "FaithLabel";
    this.FaithLabel.Size = new Size(13, 13);
    this.FaithLabel.TabIndex = 19;
    this.FaithLabel.Text = "0";
    this.LuckLabel.AutoSize = true;
    this.LuckLabel.Location = new Point(93, 375);
    this.LuckLabel.Name = "LuckLabel";
    this.LuckLabel.Size = new Size(13, 13);
    this.LuckLabel.TabIndex = 20;
    this.LuckLabel.Text = "0";
    this.GuileLabel.AutoSize = true;
    this.GuileLabel.Location = new Point(93, 398);
    this.GuileLabel.Name = "GuileLabel";
    this.GuileLabel.Size = new Size(13, 13);
    this.GuileLabel.TabIndex = 21;
    this.GuileLabel.Text = "0";
    this.SanctityLabel.AutoSize = true;
    this.SanctityLabel.Location = new Point(93, 421);
    this.SanctityLabel.Name = "SanctityLabel";
    this.SanctityLabel.Size = new Size(13, 13);
    this.SanctityLabel.TabIndex = 22;
    this.SanctityLabel.Text = "0";
    this.AptitudeLabel.AutoSize = true;
    this.AptitudeLabel.Location = new Point(93, 443);
    this.AptitudeLabel.Name = "AptitudeLabel";
    this.AptitudeLabel.Size = new Size(13, 13);
    this.AptitudeLabel.TabIndex = 23;
    this.AptitudeLabel.Text = "0";
    this.TotalPointsLabel.AutoSize = true;
    this.TotalPointsLabel.Location = new Point(14, 163);
    this.TotalPointsLabel.Name = "TotalPointsLabel";
    this.TotalPointsLabel.Size = new Size(98, 13);
    this.TotalPointsLabel.TabIndex = 24;
    this.TotalPointsLabel.Text = "0 Points Remaining";
    this.ClassBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.ClassBox.FormattingEnabled = true;
    this.ClassBox.Items.AddRange(new object[48 /*0x30*/]
    {
      (object) "Soldier",
      (object) "Black Knight",
      (object) "Tactician",
      (object) "Demon Hunter",
      (object) "Solblader",
      (object) "",
      (object) "Mage",
      (object) "Evoker",
      (object) "Hexer",
      (object) "Rune Magician",
      (object) "Ruler",
      (object) "",
      (object) "Archer",
      (object) "Arbalest",
      (object) "Magic Gunner",
      (object) "Ranger",
      (object) "",
      (object) "Curate",
      (object) "Lantern Bearer",
      (object) "Priest",
      (object) "Aquamancer",
      (object) "Druid",
      (object) "",
      (object) "Duelist",
      (object) "Ghost",
      (object) "Kensei",
      (object) "Firebird",
      (object) "",
      (object) "Martial Artist",
      (object) "Monk",
      (object) "Verglas",
      (object) "Boxer",
      (object) "Shinobi",
      (object) "",
      (object) "Rogue",
      (object) "Engineer",
      (object) "Void Assassin",
      (object) "Spellthief",
      (object) "",
      (object) "Summoner",
      (object) "Grand Summoner",
      (object) "Bonder",
      (object) "Shapeshifter",
      (object) "",
      (object) "Bard",
      (object) "Performer",
      (object) "Dancer",
      (object) "Dark Bard"
    });
    this.ClassBox.Location = new Point(10, 126);
    this.ClassBox.Name = "ClassBox";
    this.ClassBox.Size = new Size(109, 21);
    this.ClassBox.TabIndex = 26;
    this.ClassBox.Tag = (object) "";
    this.ClassBox.SelectedIndexChanged += new EventHandler(this.ClassBox_SelectedIndexChanged);
    this.RaceBox.BackColor = SystemColors.Window;
    this.RaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.RaceBox.FormattingEnabled = true;
    this.RaceBox.Items.AddRange(new object[68]
    {
      (object) "=HUMAN=",
      (object) "Imperialist",
      (object) "Chataran",
      (object) "Karatynn",
      (object) "Onigan",
      (object) "Tannite",
      (object) "Lispoolian",
      (object) "Dormehan",
      (object) "Alstalsian",
      (object) "Hyoyan",
      (object) "Telegradian",
      (object) "Geladynian",
      (object) "Meiaquarise",
      (object) "Duyuein",
      (object) "=KAELENSIAN=",
      (object) "Lupine",
      (object) "Corbie",
      (object) "Phenex",
      (object) "Heron",
      (object) "Felidae",
      (object) "Grimalkin",
      (object) "Leporidae",
      (object) "Muridae",
      (object) "=SERPENTKIND=",
      (object) "Glykin",
      (object) "Wyverntouched",
      (object) "Hyattr",
      (object) "Naga",
      (object) "=CORRUPTED=",
      (object) "Umbral",
      (object) "Shaitan",
      (object) "Oracle",
      (object) "Papilion",
      (object) "Theno",
      (object) "=ANCIENTS=",
      (object) "Elf",
      (object) "Wild Elf",
      (object) "Zeran",
      (object) "Lich",
      (object) "Vampire",
      (object) "Reaper",
      (object) "Apertaurus",
      (object) "=HOMUNCULI=",
      (object) "Salamandra",
      (object) "Chimera",
      (object) "Amalgama",
      (object) "=OTHER=",
      (object) "M-Type S",
      (object) "M-Type C",
      (object) "M-Type A",
      (object) "M-Type R",
      (object) "Redtail",
      (object) "Omina",
      (object) "Doriad",
      (object) "Dullahan",
      (object) "Karakuri",
      (object) "Oni",
      (object) "=YOUKAI/WILD=",
      (object) "Avian",
      (object) "Mystic",
      (object) "Plant",
      (object) "Night",
      (object) "Dragon",
      (object) "Beast",
      (object) "Fairy",
      (object) "Serpentine",
      (object) "=DEBUG=",
      (object) "Lich (No MD)"
    });
    this.RaceBox.Location = new Point(10, 84);
    this.RaceBox.Name = "RaceBox";
    this.RaceBox.Size = new Size(121, 21);
    this.RaceBox.TabIndex = 25;
    this.RaceBox.SelectedIndexChanged += new EventHandler(this.RaceBox_SelectedIndexChanged);
    this.ClassLabel.AutoSize = true;
    this.ClassLabel.Location = new Point(8, 112 /*0x70*/);
    this.ClassLabel.Name = "ClassLabel";
    this.ClassLabel.Size = new Size(58, 13);
    this.ClassLabel.TabIndex = 29;
    this.ClassLabel.Text = "Main Class";
    this.RaceLabel.AutoSize = true;
    this.RaceLabel.Location = new Point(8, 68);
    this.RaceLabel.Name = "RaceLabel";
    this.RaceLabel.Size = new Size(33, 13);
    this.RaceLabel.TabIndex = 30;
    this.RaceLabel.Text = "Race";
    this.ResetButton.Location = new Point(684, 12);
    this.ResetButton.Name = "ResetButton";
    this.ResetButton.Size = new Size(75, 23);
    this.ResetButton.TabIndex = 54;
    this.ResetButton.Text = "Reset";
    this.ResetButton.UseVisualStyleBackColor = true;
    this.ResetButton.Visible = false;
    this.ResetButton.Click += new EventHandler(this.ResetButton_Click);
    this.Tooltip.AutomaticDelay = 100;
    this.AkurZoButton.Image = (Image) Resources.AkurZoOff;
    this.AkurZoButton.Location = new Point(599, 124);
    this.AkurZoButton.Name = "AkurZoButton";
    this.AkurZoButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.AkurZoButton.TabIndex = 102;
    this.AkurZoButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.AkurZoButton, "Azur Zo (GUI)");
    this.AkurZoButton.MouseClick += new MouseEventHandler(this.AkurZoToggleClick);
    this.LunaCuButton.Image = (Image) componentResourceManager.GetObject("LunaCuButton.Image");
    this.LunaCuButton.Location = new Point(562, 124);
    this.LunaCuButton.Name = "LunaCuButton";
    this.LunaCuButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.LunaCuButton.TabIndex = 101;
    this.LunaCuButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.LunaCuButton, "Luna Cu (SAN)");
    this.LunaCuButton.MouseClick += new MouseEventHandler(this.LunaCuToggleClick);
    this.ZeroGyButton.Image = (Image) Resources.ZeroGyOff;
    this.ZeroGyButton.Location = new Point(636, 87);
    this.ZeroGyButton.Name = "ZeroGyButton";
    this.ZeroGyButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.ZeroGyButton.TabIndex = 66;
    this.ZeroGyButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.ZeroGyButton, "Zero Gy (SKI)");
    this.ZeroGyButton.MouseClick += new MouseEventHandler(this.ZeroGyToggleClick);
    this.RabeUrButton.Image = (Image) Resources.RabeUrOff;
    this.RabeUrButton.Location = new Point(599, 87);
    this.RabeUrButton.Name = "RabeUrButton";
    this.RabeUrButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.RabeUrButton.TabIndex = 65;
    this.RabeUrButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.RabeUrButton, "Rabe Ur (CEL)");
    this.RabeUrButton.MouseClick += new MouseEventHandler(this.RabeUrToggleClick);
    this.KashIcButton.Image = (Image) Resources.KashIcOff;
    this.KashIcButton.Location = new Point(562, 87);
    this.KashIcButton.Name = "KashIcButton";
    this.KashIcButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.KashIcButton.TabIndex = 64 /*0x40*/;
    this.KashIcButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.KashIcButton, "Kash Ic (WIL)");
    this.KashIcButton.MouseClick += new MouseEventHandler(this.KashIcToggleClick);
    this.KagiJiButton.Image = (Image) Resources.KagiJiOff;
    this.KagiJiButton.Location = new Point(636, 50);
    this.KagiJiButton.Name = "KagiJiButton";
    this.KagiJiButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.KagiJiButton.TabIndex = 63 /*0x3F*/;
    this.KagiJiButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.KagiJiButton, "Kagi Ji (LUC)");
    this.KagiJiButton.MouseClick += new MouseEventHandler(this.KagiJiToggleClick);
    this.HolyMrButton.Image = (Image) Resources.HolyMrOff;
    this.HolyMrButton.Location = new Point(599, 50);
    this.HolyMrButton.Name = "HolyMrButton";
    this.HolyMrButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.HolyMrButton.TabIndex = 62;
    this.HolyMrButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.HolyMrButton, "Holy Mr (FAI)");
    this.HolyMrButton.MouseClick += new MouseEventHandler(this.HolyMrToggleClick);
    this.GrenUtButton.Image = (Image) Resources.GrenUtOff;
    this.GrenUtButton.Location = new Point(562, 50);
    this.GrenUtButton.Name = "GrenUtButton";
    this.GrenUtButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.GrenUtButton.TabIndex = 61;
    this.GrenUtButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.GrenUtButton, "Gren Ut (DEF)");
    this.GrenUtButton.MouseClick += new MouseEventHandler(this.GrenUtToggleClick);
    this.ChoiErButton.Image = (Image) Resources.ChoiErOff;
    this.ChoiErButton.Location = new Point(636, 13);
    this.ChoiErButton.Name = "ChoiErButton";
    this.ChoiErButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.ChoiErButton.TabIndex = 60;
    this.ChoiErButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.ChoiErButton, "Choi Er (RES)");
    this.ChoiErButton.MouseClick += new MouseEventHandler(this.ChoiErToggleClick);
    this.BldiIaButton.Image = (Image) Resources.BldiIaOff;
    this.BldiIaButton.Location = new Point(599, 13);
    this.BldiIaButton.Name = "BldiIaButton";
    this.BldiIaButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.BldiIaButton.TabIndex = 59;
    this.BldiIaButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.BldiIaButton, "Bldi Ia (VIT)");
    this.BldiIaButton.MouseClick += new MouseEventHandler(this.BldiIaToggleClick);
    this.AxysAlButton.Image = (Image) Resources.AxysAlOff;
    this.AxysAlButton.Location = new Point(562, 13);
    this.AxysAlButton.Name = "AxysAlButton";
    this.AxysAlButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.AxysAlButton.TabIndex = 58;
    this.AxysAlButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.AxysAlButton, "Axys Al (STR)");
    this.AxysAlButton.Click += new EventHandler(this.AxysAlButton_Click);
    this.AxysAlButton.MouseClick += new MouseEventHandler(this.AxysAlToggleClick);
    this.AllLEButton.Image = (Image) Resources.AllOff;
    this.AllLEButton.Location = new Point(636, 124);
    this.AllLEButton.Name = "AllLEButton";
    this.AllLEButton.Size = new Size(31 /*0x1F*/, 31 /*0x1F*/);
    this.AllLEButton.TabIndex = 206;
    this.AllLEButton.TabStop = false;
    this.Tooltip.SetToolTip((Control) this.AllLEButton, "Azur Zo (GUI)");
    this.AllLEButton.Click += new EventHandler(this.AllLEButton_Click);
    this.EvadeLabel.AutoSize = true;
    this.EvadeLabel.Location = new Point(562, 189);
    this.EvadeLabel.Name = "EvadeLabel";
    this.EvadeLabel.Size = new Size(59, 13);
    this.EvadeLabel.TabIndex = 91;
    this.EvadeLabel.Text = "Evade 0+0";
    this.Tooltip.SetToolTip((Control) this.EvadeLabel, "Click to add Base Evade");
    this.EvadeLabel.Click += new EventHandler(this.EvadePlus_Click);
    this.EvadeLabel.MouseLeave += new EventHandler(this.EvadeMouseLeave);
    this.EvadeLabel.MouseHover += new EventHandler(this.EvadeMouseHover);
    this.CritEvadeLabel.AutoSize = true;
    this.CritEvadeLabel.Location = new Point(562, 203);
    this.CritEvadeLabel.Name = "CritEvadeLabel";
    this.CritEvadeLabel.Size = new Size(65, 13);
    this.CritEvadeLabel.TabIndex = 92;
    this.CritEvadeLabel.Text = "Crit Evade 0";
    this.Tooltip.SetToolTip((Control) this.CritEvadeLabel, "Click to add Crit Evade");
    this.CritEvadeLabel.Click += new EventHandler(this.CEvadePlus_Click);
    this.CritEvadeLabel.MouseLeave += new EventHandler(this.CritEvadeLabel_MouseLeave);
    this.CritEvadeLabel.MouseHover += new EventHandler(this.CritEvadeLabel_MouseHover);
    this.VersionLabel.AutoSize = true;
    this.VersionLabel.Location = new Point(78, 11);
    this.VersionLabel.Name = "VersionLabel";
    this.VersionLabel.Size = new Size(71, 13);
    this.VersionLabel.TabIndex = 67;
    this.VersionLabel.Text = "Version Label";
    this.CustomStrengthBox.Location = new Point(208 /*0xD0*/, 184);
    this.CustomStrengthBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomStrengthBox.Name = "CustomStrengthBox";
    this.CustomStrengthBox.Size = new Size(54, 20);
    this.CustomStrengthBox.TabIndex = 69;
    this.CustomStrengthBox.ValueChanged += new EventHandler(this.CustomStrengthBox_ValueChanged);
    this.CustomWillBox.Location = new Point(208 /*0xD0*/, 208 /*0xD0*/);
    this.CustomWillBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomWillBox.Name = "CustomWillBox";
    this.CustomWillBox.Size = new Size(54, 20);
    this.CustomWillBox.TabIndex = 70;
    this.CustomWillBox.ValueChanged += new EventHandler(this.CustomWillBox_ValueChanged);
    this.CustomSkillBox.Location = new Point(208 /*0xD0*/, 230);
    this.CustomSkillBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomSkillBox.Name = "CustomSkillBox";
    this.CustomSkillBox.Size = new Size(54, 20);
    this.CustomSkillBox.TabIndex = 71;
    this.CustomSkillBox.ValueChanged += new EventHandler(this.CustomSkillBox_ValueChanged);
    this.CustomCelerityBox.Location = new Point(208 /*0xD0*/, (int) byte.MaxValue);
    this.CustomCelerityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomCelerityBox.Name = "CustomCelerityBox";
    this.CustomCelerityBox.Size = new Size(54, 20);
    this.CustomCelerityBox.TabIndex = 72;
    this.CustomCelerityBox.ValueChanged += new EventHandler(this.CustomCelerityBox_ValueChanged);
    this.CustomDefenseBox.Location = new Point(208 /*0xD0*/, 278);
    this.CustomDefenseBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomDefenseBox.Name = "CustomDefenseBox";
    this.CustomDefenseBox.Size = new Size(54, 20);
    this.CustomDefenseBox.TabIndex = 73;
    this.CustomDefenseBox.ValueChanged += new EventHandler(this.CustomDefenseBox_ValueChanged);
    this.CustomResistanceBox.Location = new Point(208 /*0xD0*/, 301);
    this.CustomResistanceBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomResistanceBox.Name = "CustomResistanceBox";
    this.CustomResistanceBox.Size = new Size(54, 20);
    this.CustomResistanceBox.TabIndex = 74;
    this.CustomResistanceBox.ValueChanged += new EventHandler(this.CustomResistanceBox_ValueChanged);
    this.CustomVitalityBox.Location = new Point(208 /*0xD0*/, 323);
    this.CustomVitalityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomVitalityBox.Name = "CustomVitalityBox";
    this.CustomVitalityBox.Size = new Size(54, 20);
    this.CustomVitalityBox.TabIndex = 75;
    this.CustomVitalityBox.ValueChanged += new EventHandler(this.CustomVitalityBox_ValueChanged);
    this.CustomFaithBox.Location = new Point(208 /*0xD0*/, 345);
    this.CustomFaithBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomFaithBox.Name = "CustomFaithBox";
    this.CustomFaithBox.Size = new Size(54, 20);
    this.CustomFaithBox.TabIndex = 76;
    this.CustomFaithBox.ValueChanged += new EventHandler(this.CustomFaithBox_ValueChanged);
    this.CustomLuckBox.Location = new Point(208 /*0xD0*/, 368);
    this.CustomLuckBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomLuckBox.Name = "CustomLuckBox";
    this.CustomLuckBox.Size = new Size(54, 20);
    this.CustomLuckBox.TabIndex = 77;
    this.CustomLuckBox.ValueChanged += new EventHandler(this.CustomLuckBox_ValueChanged);
    this.CustomGuileBox.Location = new Point(208 /*0xD0*/, 391);
    this.CustomGuileBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomGuileBox.Name = "CustomGuileBox";
    this.CustomGuileBox.Size = new Size(54, 20);
    this.CustomGuileBox.TabIndex = 78;
    this.CustomGuileBox.ValueChanged += new EventHandler(this.CustomGuileBox_ValueChanged);
    this.CustomSanctityBox.Location = new Point(208 /*0xD0*/, 414);
    this.CustomSanctityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomSanctityBox.Name = "CustomSanctityBox";
    this.CustomSanctityBox.Size = new Size(54, 20);
    this.CustomSanctityBox.TabIndex = 79;
    this.CustomSanctityBox.ValueChanged += new EventHandler(this.CustomSanctityBox_ValueChanged);
    this.CustomAptitudeBox.Location = new Point(208 /*0xD0*/, 436);
    this.CustomAptitudeBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomAptitudeBox.Name = "CustomAptitudeBox";
    this.CustomAptitudeBox.Size = new Size(54, 20);
    this.CustomAptitudeBox.TabIndex = 80 /*0x50*/;
    this.CustomAptitudeBox.ValueChanged += new EventHandler(this.CustomAptitudeBox_ValueChanged);
    this.CustomLabel.AutoSize = true;
    this.CustomLabel.Location = new Point(194, 168);
    this.CustomLabel.Name = "CustomLabel";
    this.CustomLabel.Size = new Size(87, 13);
    this.CustomLabel.TabIndex = 81;
    this.CustomLabel.Text = "Custom Modifiers";
    this.HPLabel.AutoSize = true;
    this.HPLabel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.HPLabel.ForeColor = Color.Red;
    this.HPLabel.Location = new Point(137, 68);
    this.HPLabel.Name = "HPLabel";
    this.HPLabel.Size = new Size(54, 15);
    this.HPLabel.TabIndex = 83;
    this.HPLabel.Text = "HP: 0/0";
    this.MPLabel.AutoSize = true;
    this.MPLabel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.MPLabel.ForeColor = Color.CornflowerBlue;
    this.MPLabel.Location = new Point(137, 86);
    this.MPLabel.Name = "MPLabel";
    this.MPLabel.Size = new Size(52, 15);
    this.MPLabel.TabIndex = 84;
    this.MPLabel.Text = "FP: 0/0";
    this.DebugDRButton.Enabled = false;
    this.DebugDRButton.Location = new Point(685, 37);
    this.DebugDRButton.Name = "DebugDRButton";
    this.DebugDRButton.Size = new Size(75, 23);
    this.DebugDRButton.TabIndex = 88;
    this.DebugDRButton.Text = "DebugDR";
    this.DebugDRButton.UseVisualStyleBackColor = true;
    this.DebugDRButton.Visible = false;
    this.DebugDRButton.Click += new EventHandler(this.DebugDRButton_Click);
    this.PhysDefLabel.AutoSize = true;
    this.PhysDefLabel.Location = new Point(562, 163);
    this.PhysDefLabel.Name = "PhysDefLabel";
    this.PhysDefLabel.Size = new Size(50, 13);
    this.PhysDefLabel.TabIndex = 89;
    this.PhysDefLabel.Text = "Phys. 0%";
    this.MagDefLabel.AutoSize = true;
    this.MagDefLabel.Location = new Point(562, 176 /*0xB0*/);
    this.MagDefLabel.Name = "MagDefLabel";
    this.MagDefLabel.Size = new Size(68, 13);
    this.MagDefLabel.TabIndex = 90;
    this.MagDefLabel.Text = "Mag. Def 0%";
    this.StatusInflictLabel.AutoSize = true;
    this.StatusInflictLabel.Location = new Point(562, 216);
    this.StatusInflictLabel.Name = "StatusInflictLabel";
    this.StatusInflictLabel.Size = new Size(82, 13);
    this.StatusInflictLabel.TabIndex = 93;
    this.StatusInflictLabel.Text = "Status Inflict 0%";
    this.StatusResistLabel.AutoSize = true;
    this.StatusResistLabel.Location = new Point(562, 230);
    this.StatusResistLabel.Name = "StatusResistLabel";
    this.StatusResistLabel.Size = new Size(86, 13);
    this.StatusResistLabel.TabIndex = 94;
    this.StatusResistLabel.Text = "Status Resist 0%";
    this.FlankingLabel.AutoSize = true;
    this.FlankingLabel.Location = new Point(562, 243);
    this.FlankingLabel.Name = "FlankingLabel";
    this.FlankingLabel.Size = new Size(56, 13);
    this.FlankingLabel.TabIndex = 95;
    this.FlankingLabel.Text = "Flanking 0";
    this.SkillPoolLabel.AutoSize = true;
    this.SkillPoolLabel.Location = new Point(562, 273);
    this.SkillPoolLabel.Name = "SkillPoolLabel";
    this.SkillPoolLabel.Size = new Size(65, 13);
    this.SkillPoolLabel.TabIndex = 96 /*0x60*/;
    this.SkillPoolLabel.Text = "Skill Pool 11";
    this.EncumbranceLabel.AutoSize = true;
    this.EncumbranceLabel.Location = new Point(562, 312);
    this.EncumbranceLabel.Name = "EncumbranceLabel";
    this.EncumbranceLabel.Size = new Size(93, 13);
    this.EncumbranceLabel.TabIndex = 97;
    this.EncumbranceLabel.Text = "Encumbrance 0/5";
    this.BattleWeightLabel.AutoSize = true;
    this.BattleWeightLabel.Location = new Point(562, 299);
    this.BattleWeightLabel.Name = "BattleWeightLabel";
    this.BattleWeightLabel.Size = new Size(45, 13);
    this.BattleWeightLabel.TabIndex = 98;
    this.BattleWeightLabel.Text = "BW 0/5";
    this.WeaponButton.FlatAppearance.BorderColor = Color.Black;
    this.WeaponButton.Location = new Point(563, 328);
    this.WeaponButton.Name = "WeaponButton";
    this.WeaponButton.Size = new Size(95, 69);
    this.WeaponButton.TabIndex = 99;
    this.WeaponButton.Text = "Weapon Calculations";
    this.WeaponButton.UseVisualStyleBackColor = true;
    this.WeaponButton.Click += new EventHandler(this.WeaponButton_Click);
    this.BaseLabel.AutoSize = true;
    this.BaseLabel.Location = new Point(290, 168);
    this.BaseLabel.Name = "BaseLabel";
    this.BaseLabel.Size = new Size(76, 13);
    this.BaseLabel.TabIndex = 115;
    this.BaseLabel.Text = "Base Modifiers";
    this.CustomBaseAptitudeBox.Location = new Point(304, 436);
    this.CustomBaseAptitudeBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseAptitudeBox.Name = "CustomBaseAptitudeBox";
    this.CustomBaseAptitudeBox.Size = new Size(54, 20);
    this.CustomBaseAptitudeBox.TabIndex = 114;
    this.CustomBaseAptitudeBox.ValueChanged += new EventHandler(this.CustomBaseAptitudeBox_ValueChanged);
    this.CustomBaseSanctityBox.Location = new Point(304, 414);
    this.CustomBaseSanctityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseSanctityBox.Name = "CustomBaseSanctityBox";
    this.CustomBaseSanctityBox.Size = new Size(54, 20);
    this.CustomBaseSanctityBox.TabIndex = 113;
    this.CustomBaseSanctityBox.ValueChanged += new EventHandler(this.CustomBaseSanctityBox_ValueChanged);
    this.CustomBaseGuileBox.Location = new Point(304, 391);
    this.CustomBaseGuileBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseGuileBox.Name = "CustomBaseGuileBox";
    this.CustomBaseGuileBox.Size = new Size(54, 20);
    this.CustomBaseGuileBox.TabIndex = 112 /*0x70*/;
    this.CustomBaseGuileBox.ValueChanged += new EventHandler(this.CustomBaseGuileBox_ValueChanged);
    this.CustomBaseLuckBox.Location = new Point(304, 368);
    this.CustomBaseLuckBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseLuckBox.Name = "CustomBaseLuckBox";
    this.CustomBaseLuckBox.Size = new Size(54, 20);
    this.CustomBaseLuckBox.TabIndex = 111;
    this.CustomBaseLuckBox.ValueChanged += new EventHandler(this.CustomBaseLuckBox_ValueChanged);
    this.CustomBaseFaithBox.Location = new Point(304, 345);
    this.CustomBaseFaithBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseFaithBox.Name = "CustomBaseFaithBox";
    this.CustomBaseFaithBox.Size = new Size(54, 20);
    this.CustomBaseFaithBox.TabIndex = 110;
    this.CustomBaseFaithBox.ValueChanged += new EventHandler(this.CustomBaseFaithBox_ValueChanged);
    this.CustomBaseVitalityBox.Location = new Point(304, 323);
    this.CustomBaseVitalityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseVitalityBox.Name = "CustomBaseVitalityBox";
    this.CustomBaseVitalityBox.Size = new Size(54, 20);
    this.CustomBaseVitalityBox.TabIndex = 109;
    this.CustomBaseVitalityBox.ValueChanged += new EventHandler(this.CustomBaseVitalityBox_ValueChanged);
    this.CustomBaseResistanceBox.Location = new Point(304, 301);
    this.CustomBaseResistanceBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseResistanceBox.Name = "CustomBaseResistanceBox";
    this.CustomBaseResistanceBox.Size = new Size(54, 20);
    this.CustomBaseResistanceBox.TabIndex = 108;
    this.CustomBaseResistanceBox.ValueChanged += new EventHandler(this.CustomBaseResistanceBox_ValueChanged);
    this.CustomBaseDefenseBox.Location = new Point(304, 278);
    this.CustomBaseDefenseBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseDefenseBox.Name = "CustomBaseDefenseBox";
    this.CustomBaseDefenseBox.Size = new Size(54, 20);
    this.CustomBaseDefenseBox.TabIndex = 107;
    this.CustomBaseDefenseBox.ValueChanged += new EventHandler(this.CustomBaseDefenseBox_ValueChanged);
    this.CustomBaseCelerityBox.Location = new Point(304, (int) byte.MaxValue);
    this.CustomBaseCelerityBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseCelerityBox.Name = "CustomBaseCelerityBox";
    this.CustomBaseCelerityBox.Size = new Size(54, 20);
    this.CustomBaseCelerityBox.TabIndex = 106;
    this.CustomBaseCelerityBox.ValueChanged += new EventHandler(this.CustomBaseCelerityBox_ValueChanged);
    this.CustomBaseSkillBox.Location = new Point(304, 230);
    this.CustomBaseSkillBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseSkillBox.Name = "CustomBaseSkillBox";
    this.CustomBaseSkillBox.Size = new Size(54, 20);
    this.CustomBaseSkillBox.TabIndex = 105;
    this.CustomBaseSkillBox.ValueChanged += new EventHandler(this.CustomBaseSkillBox_ValueChanged);
    this.CustomBaseWillBox.Location = new Point(304, 208 /*0xD0*/);
    this.CustomBaseWillBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseWillBox.Name = "CustomBaseWillBox";
    this.CustomBaseWillBox.Size = new Size(54, 20);
    this.CustomBaseWillBox.TabIndex = 104;
    this.CustomBaseWillBox.ValueChanged += new EventHandler(this.CustomBaseWillBox_ValueChanged);
    this.CustomBaseStrengthBox.Location = new Point(304, 184);
    this.CustomBaseStrengthBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomBaseStrengthBox.Name = "CustomBaseStrengthBox";
    this.CustomBaseStrengthBox.Size = new Size(54, 20);
    this.CustomBaseStrengthBox.TabIndex = 103;
    this.CustomBaseStrengthBox.ValueChanged += new EventHandler(this.CustomBaseStrengthBox_ValueChanged);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(438, 54);
    this.label7.Name = "label7";
    this.label7.Size = new Size(63 /*0x3F*/, 13);
    this.label7.TabIndex = 116;
    this.label7.Text = "Custom HP:";
    this.CustomHPBox.Location = new Point(502, 52);
    this.CustomHPBox.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.CustomHPBox.Minimum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      int.MinValue
    });
    this.CustomHPBox.Name = "CustomHPBox";
    this.CustomHPBox.Size = new Size(54, 20);
    this.CustomHPBox.TabIndex = 117;
    this.CustomHPBox.ValueChanged += new EventHandler(this.CustomHPBox_ValueChanged);
    this.CustomMPBox.Location = new Point(502, 78);
    this.CustomMPBox.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.CustomMPBox.Minimum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      int.MinValue
    });
    this.CustomMPBox.Name = "CustomMPBox";
    this.CustomMPBox.Size = new Size(54, 20);
    this.CustomMPBox.TabIndex = 119;
    this.CustomMPBox.ValueChanged += new EventHandler(this.CustomMPBox_ValueChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(440, 78);
    this.label8.Name = "label8";
    this.label8.Size = new Size(61, 13);
    this.label8.TabIndex = 118;
    this.label8.Text = "Custom FP:";
    this.GiantGeneCheckBox.AutoSize = true;
    this.GiantGeneCheckBox.BackColor = SystemColors.Control;
    this.GiantGeneCheckBox.FlatAppearance.BorderColor = Color.Black;
    this.GiantGeneCheckBox.FlatAppearance.CheckedBackColor = Color.Black;
    this.GiantGeneCheckBox.Location = new Point(476, 101);
    this.GiantGeneCheckBox.Name = "GiantGeneCheckBox";
    this.GiantGeneCheckBox.RightToLeft = RightToLeft.Yes;
    this.GiantGeneCheckBox.Size = new Size(80 /*0x50*/, 17);
    this.GiantGeneCheckBox.TabIndex = 120;
    this.GiantGeneCheckBox.Text = "Giant Gene";
    this.GiantGeneCheckBox.UseVisualStyleBackColor = false;
    this.GiantGeneCheckBox.CheckStateChanged += new EventHandler(this.GiantGeneCheckBox_CheckStateChanged);
    this.ElemATKLabel.AutoSize = true;
    this.ElemATKLabel.Location = new Point(401, 168);
    this.ElemATKLabel.Name = "ElemATKLabel";
    this.ElemATKLabel.Size = new Size(51, 13);
    this.ElemATKLabel.TabIndex = 122;
    this.ElemATKLabel.Text = "ElemATK";
    this.SoundATKLabel.AutoSize = true;
    this.SoundATKLabel.Location = new Point(413, 427);
    this.SoundATKLabel.Name = "SoundATKLabel";
    this.SoundATKLabel.Size = new Size(13, 13);
    this.SoundATKLabel.TabIndex = 133;
    this.SoundATKLabel.Text = "0";
    this.AcidATKLabel.AutoSize = true;
    this.AcidATKLabel.Location = new Point(413, 404);
    this.AcidATKLabel.Name = "AcidATKLabel";
    this.AcidATKLabel.Size = new Size(13, 13);
    this.AcidATKLabel.TabIndex = 132;
    this.AcidATKLabel.Text = "0";
    this.LightningATKLabel.AutoSize = true;
    this.LightningATKLabel.Location = new Point(413, 379);
    this.LightningATKLabel.Name = "LightningATKLabel";
    this.LightningATKLabel.Size = new Size(13, 13);
    this.LightningATKLabel.TabIndex = 131;
    this.LightningATKLabel.Text = "0";
    this.LightATKLabel.AutoSize = true;
    this.LightATKLabel.Location = new Point(413, 355);
    this.LightATKLabel.Name = "LightATKLabel";
    this.LightATKLabel.Size = new Size(13, 13);
    this.LightATKLabel.TabIndex = 130;
    this.LightATKLabel.Text = "0";
    this.WaterATKLabel.AutoSize = true;
    this.WaterATKLabel.Location = new Point(413, 332);
    this.WaterATKLabel.Name = "WaterATKLabel";
    this.WaterATKLabel.Size = new Size(13, 13);
    this.WaterATKLabel.TabIndex = 129;
    this.WaterATKLabel.Text = "0";
    this.DarkATKLabel.AutoSize = true;
    this.DarkATKLabel.Location = new Point(413, 308);
    this.DarkATKLabel.Name = "DarkATKLabel";
    this.DarkATKLabel.Size = new Size(13, 13);
    this.DarkATKLabel.TabIndex = 128 /*0x80*/;
    this.DarkATKLabel.Text = "0";
    this.EarthATKLabel.AutoSize = true;
    this.EarthATKLabel.Location = new Point(413, 285);
    this.EarthATKLabel.Name = "EarthATKLabel";
    this.EarthATKLabel.Size = new Size(13, 13);
    this.EarthATKLabel.TabIndex = (int) sbyte.MaxValue;
    this.EarthATKLabel.Text = "0";
    this.WindATKLabel.AutoSize = true;
    this.WindATKLabel.Location = new Point(413, 260);
    this.WindATKLabel.Name = "WindATKLabel";
    this.WindATKLabel.Size = new Size(13, 13);
    this.WindATKLabel.TabIndex = 126;
    this.WindATKLabel.Text = "0";
    this.IceATKLabel.AutoSize = true;
    this.IceATKLabel.Location = new Point(413, 236);
    this.IceATKLabel.Name = "IceATKLabel";
    this.IceATKLabel.Size = new Size(13, 13);
    this.IceATKLabel.TabIndex = 125;
    this.IceATKLabel.Text = "0";
    this.FireATKLabel.AutoSize = true;
    this.FireATKLabel.BackColor = SystemColors.Control;
    this.FireATKLabel.ForeColor = SystemColors.ControlText;
    this.FireATKLabel.Location = new Point(413, 190);
    this.FireATKLabel.Name = "FireATKLabel";
    this.FireATKLabel.Size = new Size(13, 13);
    this.FireATKLabel.TabIndex = 123;
    this.FireATKLabel.Text = "0";
    this.PrintButton.Location = new Point(81, 28);
    this.PrintButton.Name = "PrintButton";
    this.PrintButton.Size = new Size(75, 22);
    this.PrintButton.TabIndex = 136;
    this.PrintButton.Text = "Print";
    this.PrintButton.UseVisualStyleBackColor = true;
    this.PrintButton.Click += new EventHandler(this.PrintButton_Click);
    this.DragonKingBox.Location = new Point(444, 100);
    this.DragonKingBox.Maximum = new Decimal(new int[4]
    {
      3,
      0,
      0,
      0
    });
    this.DragonKingBox.Name = "DragonKingBox";
    this.DragonKingBox.Size = new Size(32 /*0x20*/, 20);
    this.DragonKingBox.TabIndex = 137;
    this.DragonKingBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.DragonKingLabel.AutoSize = true;
    this.DragonKingLabel.Location = new Point(337, 103);
    this.DragonKingLabel.Name = "DragonKingLabel";
    this.DragonKingLabel.Size = new Size(101, 13);
    this.DragonKingLabel.TabIndex = 138;
    this.DragonKingLabel.Text = "Dragon King Pieces";
    this.SoundRESLabel.AutoSize = true;
    this.SoundRESLabel.Location = new Point(485, 427);
    this.SoundRESLabel.Name = "SoundRESLabel";
    this.SoundRESLabel.Size = new Size(13, 13);
    this.SoundRESLabel.TabIndex = 151;
    this.SoundRESLabel.Text = "0";
    this.AcidRESLabel.AutoSize = true;
    this.AcidRESLabel.Location = new Point(485, 404);
    this.AcidRESLabel.Name = "AcidRESLabel";
    this.AcidRESLabel.Size = new Size(13, 13);
    this.AcidRESLabel.TabIndex = 150;
    this.AcidRESLabel.Text = "0";
    this.LightningRESLabel.AutoSize = true;
    this.LightningRESLabel.Location = new Point(485, 379);
    this.LightningRESLabel.Name = "LightningRESLabel";
    this.LightningRESLabel.Size = new Size(13, 13);
    this.LightningRESLabel.TabIndex = 149;
    this.LightningRESLabel.Text = "0";
    this.LightRESLabel.AutoSize = true;
    this.LightRESLabel.Location = new Point(485, 355);
    this.LightRESLabel.Name = "LightRESLabel";
    this.LightRESLabel.Size = new Size(13, 13);
    this.LightRESLabel.TabIndex = 148;
    this.LightRESLabel.Text = "0";
    this.WaterRESLabel.AutoSize = true;
    this.WaterRESLabel.Location = new Point(485, 332);
    this.WaterRESLabel.Name = "WaterRESLabel";
    this.WaterRESLabel.Size = new Size(13, 13);
    this.WaterRESLabel.TabIndex = 147;
    this.WaterRESLabel.Text = "0";
    this.DarkRESLabel.AutoSize = true;
    this.DarkRESLabel.Location = new Point(485, 308);
    this.DarkRESLabel.Name = "DarkRESLabel";
    this.DarkRESLabel.Size = new Size(13, 13);
    this.DarkRESLabel.TabIndex = 146;
    this.DarkRESLabel.Text = "0";
    this.EarthRESLabel.AutoSize = true;
    this.EarthRESLabel.Location = new Point(485, 285);
    this.EarthRESLabel.Name = "EarthRESLabel";
    this.EarthRESLabel.Size = new Size(13, 13);
    this.EarthRESLabel.TabIndex = 145;
    this.EarthRESLabel.Text = "0";
    this.WindRESLabel.AutoSize = true;
    this.WindRESLabel.Location = new Point(485, 260);
    this.WindRESLabel.Name = "WindRESLabel";
    this.WindRESLabel.Size = new Size(13, 13);
    this.WindRESLabel.TabIndex = 144 /*0x90*/;
    this.WindRESLabel.Text = "0";
    this.IceRESLabel.AutoSize = true;
    this.IceRESLabel.Location = new Point(485, 236);
    this.IceRESLabel.Name = "IceRESLabel";
    this.IceRESLabel.Size = new Size(13, 13);
    this.IceRESLabel.TabIndex = 143;
    this.IceRESLabel.Text = "0";
    this.FireRESLabel.AutoSize = true;
    this.FireRESLabel.Location = new Point(485, 190);
    this.FireRESLabel.Name = "FireRESLabel";
    this.FireRESLabel.Size = new Size(13, 13);
    this.FireRESLabel.TabIndex = 142;
    this.FireRESLabel.Text = "0";
    this.label17.AutoSize = true;
    this.label17.Location = new Point(485, 168);
    this.label17.Name = "label17";
    this.label17.Size = new Size(52, 13);
    this.label17.TabIndex = 152;
    this.label17.Text = "ElemRES";
    this.StampsButton.FlatAppearance.BorderColor = Color.Black;
    this.StampsButton.Location = new Point(563, 422);
    this.StampsButton.Name = "StampsButton";
    this.StampsButton.Size = new Size(95, 23);
    this.StampsButton.TabIndex = 153;
    this.StampsButton.Text = "Stamps";
    this.StampsButton.UseVisualStyleBackColor = true;
    this.StampsButton.Click += new EventHandler(this.StampsButton_Click);
    this.CustomSoundATKBox.Location = new Point(437, 425);
    this.CustomSoundATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomSoundATKBox.Name = "CustomSoundATKBox";
    this.CustomSoundATKBox.Size = new Size(38, 20);
    this.CustomSoundATKBox.TabIndex = 164;
    this.CustomSoundATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomAcidATKBox.Location = new Point(437, 401);
    this.CustomAcidATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomAcidATKBox.Name = "CustomAcidATKBox";
    this.CustomAcidATKBox.Size = new Size(38, 20);
    this.CustomAcidATKBox.TabIndex = 163;
    this.CustomAcidATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomLightningATKBox.Location = new Point(437, 377);
    this.CustomLightningATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomLightningATKBox.Name = "CustomLightningATKBox";
    this.CustomLightningATKBox.Size = new Size(38, 20);
    this.CustomLightningATKBox.TabIndex = 162;
    this.CustomLightningATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomLightATKBox.Location = new Point(437, 353);
    this.CustomLightATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomLightATKBox.Name = "CustomLightATKBox";
    this.CustomLightATKBox.Size = new Size(38, 20);
    this.CustomLightATKBox.TabIndex = 161;
    this.CustomLightATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomWaterATKBox.Location = new Point(437, 330);
    this.CustomWaterATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomWaterATKBox.Name = "CustomWaterATKBox";
    this.CustomWaterATKBox.Size = new Size(38, 20);
    this.CustomWaterATKBox.TabIndex = 160 /*0xA0*/;
    this.CustomWaterATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomDarkATKBox.Location = new Point(437, 306);
    this.CustomDarkATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomDarkATKBox.Name = "CustomDarkATKBox";
    this.CustomDarkATKBox.Size = new Size(38, 20);
    this.CustomDarkATKBox.TabIndex = 159;
    this.CustomDarkATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomEarthATKBox.Location = new Point(437, 283);
    this.CustomEarthATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomEarthATKBox.Name = "CustomEarthATKBox";
    this.CustomEarthATKBox.Size = new Size(38, 20);
    this.CustomEarthATKBox.TabIndex = 158;
    this.CustomEarthATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomWindATKBox.Location = new Point(437, 258);
    this.CustomWindATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomWindATKBox.Name = "CustomWindATKBox";
    this.CustomWindATKBox.Size = new Size(38, 20);
    this.CustomWindATKBox.TabIndex = 157;
    this.CustomWindATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomIceATKBox.Location = new Point(437, 234);
    this.CustomIceATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomIceATKBox.Name = "CustomIceATKBox";
    this.CustomIceATKBox.Size = new Size(38, 20);
    this.CustomIceATKBox.TabIndex = 156;
    this.CustomIceATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomFireATKBox.Location = new Point(437, 188);
    this.CustomFireATKBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomFireATKBox.Name = "CustomFireATKBox";
    this.CustomFireATKBox.Size = new Size(38, 20);
    this.CustomFireATKBox.TabIndex = 154;
    this.CustomFireATKBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomSoundRESBox.Location = new Point(522, 424);
    this.CustomSoundRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomSoundRESBox.Name = "CustomSoundRESBox";
    this.CustomSoundRESBox.Size = new Size(38, 20);
    this.CustomSoundRESBox.TabIndex = 174;
    this.CustomSoundRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomAcidRESBox.Location = new Point(522, 400);
    this.CustomAcidRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomAcidRESBox.Name = "CustomAcidRESBox";
    this.CustomAcidRESBox.Size = new Size(38, 20);
    this.CustomAcidRESBox.TabIndex = 173;
    this.CustomAcidRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomLightningRESBox.Location = new Point(522, 376);
    this.CustomLightningRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomLightningRESBox.Name = "CustomLightningRESBox";
    this.CustomLightningRESBox.Size = new Size(38, 20);
    this.CustomLightningRESBox.TabIndex = 172;
    this.CustomLightningRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomLightRESBox.Location = new Point(522, 352);
    this.CustomLightRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomLightRESBox.Name = "CustomLightRESBox";
    this.CustomLightRESBox.Size = new Size(38, 20);
    this.CustomLightRESBox.TabIndex = 171;
    this.CustomLightRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomWaterRESBox.Location = new Point(522, 329);
    this.CustomWaterRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomWaterRESBox.Name = "CustomWaterRESBox";
    this.CustomWaterRESBox.Size = new Size(38, 20);
    this.CustomWaterRESBox.TabIndex = 170;
    this.CustomWaterRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomDarkRESBox.Location = new Point(522, 305);
    this.CustomDarkRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomDarkRESBox.Name = "CustomDarkRESBox";
    this.CustomDarkRESBox.Size = new Size(38, 20);
    this.CustomDarkRESBox.TabIndex = 169;
    this.CustomDarkRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomEarthRESBox.Location = new Point(522, 282);
    this.CustomEarthRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomEarthRESBox.Name = "CustomEarthRESBox";
    this.CustomEarthRESBox.Size = new Size(38, 20);
    this.CustomEarthRESBox.TabIndex = 168;
    this.CustomEarthRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomWindRESBox.Location = new Point(522, 257);
    this.CustomWindRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomWindRESBox.Name = "CustomWindRESBox";
    this.CustomWindRESBox.Size = new Size(38, 20);
    this.CustomWindRESBox.TabIndex = 167;
    this.CustomWindRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomIceRESBox.Location = new Point(522, 233);
    this.CustomIceRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomIceRESBox.Name = "CustomIceRESBox";
    this.CustomIceRESBox.Size = new Size(38, 20);
    this.CustomIceRESBox.TabIndex = 166;
    this.CustomIceRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.CustomFireRESBox.Location = new Point(522, 188);
    this.CustomFireRESBox.Minimum = new Decimal(new int[4]
    {
      100,
      0,
      0,
      int.MinValue
    });
    this.CustomFireRESBox.Name = "CustomFireRESBox";
    this.CustomFireRESBox.Size = new Size(38, 20);
    this.CustomFireRESBox.TabIndex = 165;
    this.CustomFireRESBox.ValueChanged += new EventHandler(this.DragonKingBox_ValueChanged);
    this.label4.AutoSize = true;
    this.label4.Location = new Point(471, 10);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 13);
    this.label4.TabIndex = 175;
    this.label4.Text = "HP%";
    this.HPPercent.Location = new Point(502, 5);
    this.HPPercent.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.HPPercent.Name = "HPPercent";
    this.HPPercent.Size = new Size(54, 20);
    this.HPPercent.TabIndex = 176 /*0xB0*/;
    this.HPPercent.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.HPPercent.ValueChanged += new EventHandler(this.HPPercent_ValueChanged);
    this.EnduranceBox.AutoSize = true;
    this.EnduranceBox.Location = new Point(478, 133);
    this.EnduranceBox.Name = "EnduranceBox";
    this.EnduranceBox.RightToLeft = RightToLeft.Yes;
    this.EnduranceBox.Size = new Size(78, 17);
    this.EnduranceBox.TabIndex = 177;
    this.EnduranceBox.Text = "Endurance";
    this.EnduranceBox.UseVisualStyleBackColor = true;
    this.EnduranceBox.Visible = false;
    this.EnduranceBox.CheckedChanged += new EventHandler(this.EnduranceBox_CheckedChanged);
    this.ReductionButton.FlatAppearance.BorderColor = Color.Black;
    this.ReductionButton.Location = new Point(563, 399);
    this.ReductionButton.Name = "ReductionButton";
    this.ReductionButton.Size = new Size(95, 23);
    this.ReductionButton.TabIndex = 178;
    this.ReductionButton.Text = "Reduction";
    this.ReductionButton.UseVisualStyleBackColor = true;
    this.ReductionButton.Click += new EventHandler(this.ReductionButton_Click);
    this.RisingNumeric.Location = new Point(480, 452);
    this.RisingNumeric.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.RisingNumeric.Name = "RisingNumeric";
    this.RisingNumeric.Size = new Size(32 /*0x20*/, 20);
    this.RisingNumeric.TabIndex = 180;
    this.RisingNumeric.Visible = false;
    this.RisingNumeric.ValueChanged += new EventHandler(this.RisingNumeric_ValueChanged);
    this.RisingLabel.AutoSize = true;
    this.RisingLabel.Location = new Point(413, 454);
    this.RisingLabel.Name = "RisingLabel";
    this.RisingLabel.Size = new Size(67, 13);
    this.RisingLabel.TabIndex = 181;
    this.RisingLabel.Text = "Rising Game";
    this.RisingLabel.Visible = false;
    this.TotalHPPercent.Location = new Point(502, 28);
    this.TotalHPPercent.Maximum = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.TotalHPPercent.Name = "TotalHPPercent";
    this.TotalHPPercent.Size = new Size(54, 20);
    this.TotalHPPercent.TabIndex = 184;
    this.TotalHPPercent.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.TotalHPPercent.ValueChanged += new EventHandler(this.TotalHPPercent_ValueChanged);
    this.label6.AutoSize = true;
    this.label6.Location = new Point(444, 31 /*0x1F*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(57, 13);
    this.label6.TabIndex = 183;
    this.label6.Text = "Total HP%";
    this.InitativeLabel.AutoSize = true;
    this.InitativeLabel.Location = new Point(562, 286);
    this.InitativeLabel.Name = "InitativeLabel";
    this.InitativeLabel.Size = new Size(53, 13);
    this.InitativeLabel.TabIndex = 185;
    this.InitativeLabel.Text = "Initative 0";
    this.LuminaryBox.AutoSize = true;
    this.LuminaryBox.Location = new Point(437, 214);
    this.LuminaryBox.Name = "LuminaryBox";
    this.LuminaryBox.Size = new Size(109, 17);
    this.LuminaryBox.TabIndex = 186;
    this.LuminaryBox.Text = "Luminary Element";
    this.LuminaryBox.UseVisualStyleBackColor = true;
    this.LuminaryBox.CheckedChanged += new EventHandler(this.LuminaryBox_CheckedChanged);
    this.Fortitude.AutoSize = true;
    this.Fortitude.Location = new Point(489, 149);
    this.Fortitude.Name = "Fortitude";
    this.Fortitude.RightToLeft = RightToLeft.Yes;
    this.Fortitude.Size = new Size(67, 17);
    this.Fortitude.TabIndex = 189;
    this.Fortitude.Text = "Fortitude";
    this.Fortitude.UseVisualStyleBackColor = true;
    this.Fortitude.Visible = false;
    this.Fortitude.CheckedChanged += new EventHandler(this.Fortitude_CheckedChanged);
    this.PainTolLabel.AutoSize = true;
    this.PainTolLabel.Location = new Point(359, 143);
    this.PainTolLabel.Name = "PainTolLabel";
    this.PainTolLabel.Size = new Size(79, 13);
    this.PainTolLabel.TabIndex = 191;
    this.PainTolLabel.Text = "Pain Tolerance";
    this.PainTolLabel.Visible = false;
    this.PainTol.Location = new Point(444, 141);
    this.PainTol.Maximum = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.PainTol.Name = "PainTol";
    this.PainTol.Size = new Size(32 /*0x20*/, 20);
    this.PainTol.TabIndex = 190;
    this.PainTol.Visible = false;
    this.PainTol.ValueChanged += new EventHandler(this.PainTol_ValueChanged);
    this.Warwalk.AutoSize = true;
    this.Warwalk.Location = new Point(488, 117);
    this.Warwalk.Name = "Warwalk";
    this.Warwalk.RightToLeft = RightToLeft.Yes;
    this.Warwalk.Size = new Size(68, 17);
    this.Warwalk.TabIndex = 192 /*0xC0*/;
    this.Warwalk.Text = "Warwalk";
    this.Warwalk.UseVisualStyleBackColor = true;
    this.Warwalk.CheckedChanged += new EventHandler(this.Warwalk_CheckedChanged);
    this.Youkai.AutoSize = true;
    this.Youkai.Location = new Point(562, 259);
    this.Youkai.Name = "Youkai";
    this.Youkai.Size = new Size(73, 13);
    this.Youkai.TabIndex = 193;
    this.Youkai.Text = "Youkai Pool 5";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(117, 112 /*0x70*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(54, 13);
    this.label2.TabIndex = 196;
    this.label2.Text = "Sub Class";
    this.SubClassBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.SubClassBox.FormattingEnabled = true;
    this.SubClassBox.Items.AddRange(new object[48 /*0x30*/]
    {
      (object) "Soldier",
      (object) "Black Knight",
      (object) "Tactician",
      (object) "Demon Hunter",
      (object) "Solblader",
      (object) "",
      (object) "Mage",
      (object) "Evoker",
      (object) "Hexer",
      (object) "Rune Magician",
      (object) "Ruler",
      (object) "",
      (object) "Archer",
      (object) "Arbalest",
      (object) "Magic Gunner",
      (object) "Ranger",
      (object) "",
      (object) "Curate",
      (object) "Lantern Bearer",
      (object) "Priest",
      (object) "Aquamancer",
      (object) "Druid",
      (object) "",
      (object) "Duelist",
      (object) "Ghost",
      (object) "Kensei",
      (object) "Firebird",
      (object) "",
      (object) "Martial Artist",
      (object) "Monk",
      (object) "Verglas",
      (object) "Boxer",
      (object) "Shinobi",
      (object) "",
      (object) "Rogue",
      (object) "Engineer",
      (object) "Void Assassin",
      (object) "Spellthief",
      (object) "",
      (object) "Summoner",
      (object) "Grand Summoner",
      (object) "Bonder",
      (object) "Shapeshifter",
      (object) "",
      (object) "Bard",
      (object) "Performer",
      (object) "Dancer",
      (object) "Dark Bard"
    });
    this.SubClassBox.Location = new Point(120, 126);
    this.SubClassBox.Name = "SubClassBox";
    this.SubClassBox.Size = new Size(109, 21);
    this.SubClassBox.TabIndex = 197;
    this.SubClassBox.Tag = (object) "";
    this.SubClassBox.SelectedIndexChanged += new EventHandler(this.SubClassBox_SelectedIndexChanged);
    this.SanguineCrestBox.AutoSize = true;
    this.SanguineCrestBox.Location = new Point(167, 11);
    this.SanguineCrestBox.Name = "SanguineCrestBox";
    this.SanguineCrestBox.Size = new Size(98, 17);
    this.SanguineCrestBox.TabIndex = 198;
    this.SanguineCrestBox.Text = "Sanguine Crest";
    this.SanguineCrestBox.UseVisualStyleBackColor = true;
    this.SanguineCrestBox.Visible = false;
    this.SanguineCrestBox.CheckedChanged += new EventHandler(this.SanguineCrestBox_CheckedChanged_1);
    this.Essence.AutoSize = true;
    this.Essence.Location = new Point(164, 33);
    this.Essence.Name = "Essence";
    this.Essence.Size = new Size(72, 13);
    this.Essence.TabIndex = 188;
    this.Essence.Text = "Essence: 100";
    this.Essence.Visible = false;
    this.GrimalkinI.AutoSize = true;
    this.GrimalkinI.Location = new Point(167, 11);
    this.GrimalkinI.Name = "GrimalkinI";
    this.GrimalkinI.Size = new Size(106, 17);
    this.GrimalkinI.TabIndex = 194;
    this.GrimalkinI.Text = "Grimalkin Instinct";
    this.GrimalkinI.UseVisualStyleBackColor = true;
    this.GrimalkinI.Visible = false;
    this.GrimalkinI.CheckedChanged += new EventHandler(this.GrimalkinI_CheckedChanged);
    this.MainClassPassive.AutoSize = true;
    this.MainClassPassive.Location = new Point(304, 54);
    this.MainClassPassive.Name = "MainClassPassive";
    this.MainClassPassive.Size = new Size(98, 13);
    this.MainClassPassive.TabIndex = 200;
    this.MainClassPassive.Text = "Main Class Passive";
    this.MainClassNum.Location = new Point(403, 52);
    this.MainClassNum.Maximum = new Decimal(new int[4]);
    this.MainClassNum.Name = "MainClassNum";
    this.MainClassNum.Size = new Size(32 /*0x20*/, 20);
    this.MainClassNum.TabIndex = 199;
    this.MainClassNum.ValueChanged += new EventHandler(this.MainClassNum_ValueChanged);
    this.SubClassPassive.AutoSize = true;
    this.SubClassPassive.Location = new Point(308, 80 /*0x50*/);
    this.SubClassPassive.Name = "SubClassPassive";
    this.SubClassPassive.Size = new Size(94, 13);
    this.SubClassPassive.TabIndex = 202;
    this.SubClassPassive.Text = "Sub Class Passive";
    this.SubClassNum.Location = new Point(403, 77);
    this.SubClassNum.Maximum = new Decimal(new int[4]);
    this.SubClassNum.Name = "SubClassNum";
    this.SubClassNum.Size = new Size(32 /*0x20*/, 20);
    this.SubClassNum.TabIndex = 201;
    this.SubClassNum.ValueChanged += new EventHandler(this.SubClassNum_ValueChanged);
    this.FoodBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.FoodBox.Font = new Font("Microsoft Sans Serif", 8.25f);
    this.FoodBox.FormattingEnabled = true;
    this.FoodBox.Items.AddRange(new object[17]
    {
      (object) "=  +VIT  =",
      (object) "Salad",
      (object) "=  +SKI  =",
      (object) "Potato & Carrot",
      (object) "=  +STR/WIL  =",
      (object) "Fugu",
      (object) "Sushi",
      (object) "=  +CEL  =",
      (object) "Pumpkin Lollipop",
      (object) "Redpop",
      (object) "Cocky",
      (object) "Kat Knip",
      (object) "Androbar",
      (object) "Chocolate Bar",
      (object) "Sweet Bites",
      (object) "=  +MOV  =",
      (object) "Custard"
    });
    this.FoodBox.Location = new Point(230, 126);
    this.FoodBox.Name = "FoodBox";
    this.FoodBox.Size = new Size(89, 21);
    this.FoodBox.TabIndex = 204;
    this.FoodBox.Tag = (object) "";
    this.FoodBox.SelectedIndexChanged += new EventHandler(this.FoodBox_SelectedIndexChanged);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(227, 112 /*0x70*/);
    this.label10.Name = "label10";
    this.label10.Size = new Size(31 /*0x1F*/, 13);
    this.label10.TabIndex = 205;
    this.label10.Text = "Food";
    this.AstrologyButton.BackgroundImage = (Image) Resources.NoSign;
    this.AstrologyButton.Location = new Point(11, 13);
    this.AstrologyButton.Name = "AstrologyButton";
    this.AstrologyButton.Size = new Size(52, 52);
    this.AstrologyButton.TabIndex = 121;
    this.AstrologyButton.UseVisualStyleBackColor = true;
    this.AstrologyButton.Click += new EventHandler(this.AstrologyButton_Click);
    this.AptitudeMinus.BackgroundImage = (Image) componentResourceManager.GetObject("AptitudeMinus.BackgroundImage");
    this.AptitudeMinus.BackgroundImageLayout = ImageLayout.Center;
    this.AptitudeMinus.FlatAppearance.BorderSize = 0;
    this.AptitudeMinus.FlatStyle = FlatStyle.Flat;
    this.AptitudeMinus.Location = new Point(162, 436);
    this.AptitudeMinus.Name = "AptitudeMinus";
    this.AptitudeMinus.Size = new Size(26, 26);
    this.AptitudeMinus.TabIndex = 53;
    this.AptitudeMinus.UseVisualStyleBackColor = true;
    this.AptitudeMinus.Click += new EventHandler(this.AptitudeMinus_Click);
    this.SanctityMinus.BackgroundImage = (Image) componentResourceManager.GetObject("SanctityMinus.BackgroundImage");
    this.SanctityMinus.BackgroundImageLayout = ImageLayout.Center;
    this.SanctityMinus.FlatAppearance.BorderSize = 0;
    this.SanctityMinus.FlatStyle = FlatStyle.Flat;
    this.SanctityMinus.Location = new Point(162, 414);
    this.SanctityMinus.Name = "SanctityMinus";
    this.SanctityMinus.Size = new Size(26, 26);
    this.SanctityMinus.TabIndex = 52;
    this.SanctityMinus.UseVisualStyleBackColor = true;
    this.SanctityMinus.Click += new EventHandler(this.SanctityMinus_Click);
    this.GuileMinus.BackgroundImage = (Image) componentResourceManager.GetObject("GuileMinus.BackgroundImage");
    this.GuileMinus.BackgroundImageLayout = ImageLayout.Center;
    this.GuileMinus.FlatAppearance.BorderSize = 0;
    this.GuileMinus.FlatStyle = FlatStyle.Flat;
    this.GuileMinus.Location = new Point(162, 391);
    this.GuileMinus.Name = "GuileMinus";
    this.GuileMinus.Size = new Size(26, 26);
    this.GuileMinus.TabIndex = 51;
    this.GuileMinus.UseVisualStyleBackColor = true;
    this.GuileMinus.Click += new EventHandler(this.GuileMinus_Click);
    this.LuckMinus.BackgroundImage = (Image) componentResourceManager.GetObject("LuckMinus.BackgroundImage");
    this.LuckMinus.BackgroundImageLayout = ImageLayout.Center;
    this.LuckMinus.FlatAppearance.BorderSize = 0;
    this.LuckMinus.FlatStyle = FlatStyle.Flat;
    this.LuckMinus.Location = new Point(162, 368);
    this.LuckMinus.Name = "LuckMinus";
    this.LuckMinus.Size = new Size(26, 26);
    this.LuckMinus.TabIndex = 50;
    this.LuckMinus.UseVisualStyleBackColor = true;
    this.LuckMinus.Click += new EventHandler(this.LuckMinus_Click);
    this.FaithMinus.BackgroundImage = (Image) componentResourceManager.GetObject("FaithMinus.BackgroundImage");
    this.FaithMinus.BackgroundImageLayout = ImageLayout.Center;
    this.FaithMinus.FlatAppearance.BorderSize = 0;
    this.FaithMinus.FlatStyle = FlatStyle.Flat;
    this.FaithMinus.Location = new Point(162, 345);
    this.FaithMinus.Name = "FaithMinus";
    this.FaithMinus.Size = new Size(26, 26);
    this.FaithMinus.TabIndex = 49;
    this.FaithMinus.UseVisualStyleBackColor = true;
    this.FaithMinus.Click += new EventHandler(this.FaithMinus_Click);
    this.VitalityMinus.BackgroundImage = (Image) componentResourceManager.GetObject("VitalityMinus.BackgroundImage");
    this.VitalityMinus.BackgroundImageLayout = ImageLayout.Center;
    this.VitalityMinus.FlatAppearance.BorderSize = 0;
    this.VitalityMinus.FlatStyle = FlatStyle.Flat;
    this.VitalityMinus.Location = new Point(162, 323);
    this.VitalityMinus.Name = "VitalityMinus";
    this.VitalityMinus.Size = new Size(26, 26);
    this.VitalityMinus.TabIndex = 48 /*0x30*/;
    this.VitalityMinus.UseVisualStyleBackColor = true;
    this.VitalityMinus.Click += new EventHandler(this.VitalityMinus_Click);
    this.ResistanceMinus.BackgroundImage = (Image) componentResourceManager.GetObject("ResistanceMinus.BackgroundImage");
    this.ResistanceMinus.BackgroundImageLayout = ImageLayout.Center;
    this.ResistanceMinus.FlatAppearance.BorderSize = 0;
    this.ResistanceMinus.FlatStyle = FlatStyle.Flat;
    this.ResistanceMinus.Location = new Point(162, 301);
    this.ResistanceMinus.Name = "ResistanceMinus";
    this.ResistanceMinus.Size = new Size(26, 26);
    this.ResistanceMinus.TabIndex = 47;
    this.ResistanceMinus.UseVisualStyleBackColor = true;
    this.ResistanceMinus.Click += new EventHandler(this.ResistanceMinus_Click);
    this.DefenseMinus.BackgroundImage = (Image) componentResourceManager.GetObject("DefenseMinus.BackgroundImage");
    this.DefenseMinus.BackgroundImageLayout = ImageLayout.Center;
    this.DefenseMinus.FlatAppearance.BorderSize = 0;
    this.DefenseMinus.FlatStyle = FlatStyle.Flat;
    this.DefenseMinus.Location = new Point(162, 278);
    this.DefenseMinus.Name = "DefenseMinus";
    this.DefenseMinus.Size = new Size(26, 26);
    this.DefenseMinus.TabIndex = 46;
    this.DefenseMinus.UseVisualStyleBackColor = true;
    this.DefenseMinus.Click += new EventHandler(this.DefenseMinus_Click);
    this.CelerityMinus.BackgroundImage = (Image) componentResourceManager.GetObject("CelerityMinus.BackgroundImage");
    this.CelerityMinus.BackgroundImageLayout = ImageLayout.Center;
    this.CelerityMinus.FlatAppearance.BorderSize = 0;
    this.CelerityMinus.FlatStyle = FlatStyle.Flat;
    this.CelerityMinus.Location = new Point(162, (int) byte.MaxValue);
    this.CelerityMinus.Name = "CelerityMinus";
    this.CelerityMinus.Size = new Size(26, 26);
    this.CelerityMinus.TabIndex = 45;
    this.CelerityMinus.UseVisualStyleBackColor = true;
    this.CelerityMinus.Click += new EventHandler(this.CelerityMinus_Click);
    this.SkillMinus.BackgroundImage = (Image) componentResourceManager.GetObject("SkillMinus.BackgroundImage");
    this.SkillMinus.BackgroundImageLayout = ImageLayout.Center;
    this.SkillMinus.FlatAppearance.BorderColor = SystemColors.Control;
    this.SkillMinus.FlatAppearance.BorderSize = 0;
    this.SkillMinus.FlatStyle = FlatStyle.Flat;
    this.SkillMinus.Location = new Point(162, 230);
    this.SkillMinus.Name = "SkillMinus";
    this.SkillMinus.Size = new Size(26, 26);
    this.SkillMinus.TabIndex = 44;
    this.SkillMinus.UseVisualStyleBackColor = true;
    this.SkillMinus.Click += new EventHandler(this.SkillMinus_Click);
    this.WillMinus.BackgroundImage = (Image) componentResourceManager.GetObject("WillMinus.BackgroundImage");
    this.WillMinus.BackgroundImageLayout = ImageLayout.Center;
    this.WillMinus.FlatAppearance.BorderColor = SystemColors.Control;
    this.WillMinus.FlatAppearance.BorderSize = 0;
    this.WillMinus.FlatStyle = FlatStyle.Flat;
    this.WillMinus.Location = new Point(162, 208 /*0xD0*/);
    this.WillMinus.Name = "WillMinus";
    this.WillMinus.Size = new Size(26, 26);
    this.WillMinus.TabIndex = 43;
    this.WillMinus.UseVisualStyleBackColor = true;
    this.WillMinus.Click += new EventHandler(this.WillMinus_Click);
    this.StrengthMinus.BackgroundImage = (Image) componentResourceManager.GetObject("StrengthMinus.BackgroundImage");
    this.StrengthMinus.BackgroundImageLayout = ImageLayout.Center;
    this.StrengthMinus.FlatAppearance.BorderColor = SystemColors.Control;
    this.StrengthMinus.FlatAppearance.BorderSize = 0;
    this.StrengthMinus.FlatStyle = FlatStyle.Flat;
    this.StrengthMinus.Location = new Point(162, 184);
    this.StrengthMinus.Name = "StrengthMinus";
    this.StrengthMinus.Size = new Size(26, 26);
    this.StrengthMinus.TabIndex = 42;
    this.StrengthMinus.UseVisualStyleBackColor = true;
    this.StrengthMinus.Click += new EventHandler(this.StrengthMinus_Click);
    this.AptitudePlus.BackgroundImage = (Image) Resources.plus;
    this.AptitudePlus.BackgroundImageLayout = ImageLayout.Center;
    this.AptitudePlus.FlatAppearance.BorderSize = 0;
    this.AptitudePlus.FlatStyle = FlatStyle.Flat;
    this.AptitudePlus.Location = new Point(130, 436);
    this.AptitudePlus.Name = "AptitudePlus";
    this.AptitudePlus.Size = new Size(26, 26);
    this.AptitudePlus.TabIndex = 41;
    this.AptitudePlus.UseVisualStyleBackColor = true;
    this.AptitudePlus.Click += new EventHandler(this.AptitudePlus_Click);
    this.SanctityPlus.BackgroundImage = (Image) Resources.plus;
    this.SanctityPlus.BackgroundImageLayout = ImageLayout.Center;
    this.SanctityPlus.FlatAppearance.BorderSize = 0;
    this.SanctityPlus.FlatStyle = FlatStyle.Flat;
    this.SanctityPlus.Location = new Point(130, 414);
    this.SanctityPlus.Name = "SanctityPlus";
    this.SanctityPlus.Size = new Size(26, 26);
    this.SanctityPlus.TabIndex = 40;
    this.SanctityPlus.UseVisualStyleBackColor = true;
    this.SanctityPlus.Click += new EventHandler(this.SanctityPlus_Click);
    this.GuilePlus.BackgroundImage = (Image) Resources.plus;
    this.GuilePlus.BackgroundImageLayout = ImageLayout.Center;
    this.GuilePlus.FlatAppearance.BorderSize = 0;
    this.GuilePlus.FlatStyle = FlatStyle.Flat;
    this.GuilePlus.Location = new Point(130, 391);
    this.GuilePlus.Name = "GuilePlus";
    this.GuilePlus.Size = new Size(26, 26);
    this.GuilePlus.TabIndex = 39;
    this.GuilePlus.UseVisualStyleBackColor = true;
    this.GuilePlus.Click += new EventHandler(this.GuilePlus_Click);
    this.LuckPlus.BackgroundImage = (Image) Resources.plus;
    this.LuckPlus.BackgroundImageLayout = ImageLayout.Center;
    this.LuckPlus.FlatAppearance.BorderSize = 0;
    this.LuckPlus.FlatStyle = FlatStyle.Flat;
    this.LuckPlus.Location = new Point(130, 368);
    this.LuckPlus.Name = "LuckPlus";
    this.LuckPlus.Size = new Size(26, 26);
    this.LuckPlus.TabIndex = 38;
    this.LuckPlus.UseVisualStyleBackColor = true;
    this.LuckPlus.Click += new EventHandler(this.LuckPlus_Click);
    this.FaithPlus.BackgroundImageLayout = ImageLayout.Center;
    this.FaithPlus.FlatAppearance.BorderSize = 0;
    this.FaithPlus.FlatStyle = FlatStyle.Flat;
    this.FaithPlus.Image = (Image) Resources.plus;
    this.FaithPlus.Location = new Point(130, 345);
    this.FaithPlus.Name = "FaithPlus";
    this.FaithPlus.Size = new Size(26, 26);
    this.FaithPlus.TabIndex = 37;
    this.FaithPlus.UseVisualStyleBackColor = true;
    this.FaithPlus.Click += new EventHandler(this.FaithPlus_Click);
    this.VitalityPlus.BackgroundImage = (Image) Resources.plus;
    this.VitalityPlus.BackgroundImageLayout = ImageLayout.Center;
    this.VitalityPlus.FlatAppearance.BorderSize = 0;
    this.VitalityPlus.FlatStyle = FlatStyle.Flat;
    this.VitalityPlus.Location = new Point(130, 323);
    this.VitalityPlus.Name = "VitalityPlus";
    this.VitalityPlus.Size = new Size(26, 26);
    this.VitalityPlus.TabIndex = 36;
    this.VitalityPlus.UseVisualStyleBackColor = true;
    this.VitalityPlus.Click += new EventHandler(this.VitalityPlus_Click);
    this.ResistancePlus.BackgroundImage = (Image) Resources.plus;
    this.ResistancePlus.BackgroundImageLayout = ImageLayout.Center;
    this.ResistancePlus.FlatAppearance.BorderSize = 0;
    this.ResistancePlus.FlatStyle = FlatStyle.Flat;
    this.ResistancePlus.Location = new Point(130, 301);
    this.ResistancePlus.Name = "ResistancePlus";
    this.ResistancePlus.Size = new Size(26, 26);
    this.ResistancePlus.TabIndex = 35;
    this.ResistancePlus.UseVisualStyleBackColor = true;
    this.ResistancePlus.Click += new EventHandler(this.ResistancePlus_Click);
    this.DefensePlus.BackgroundImage = (Image) Resources.plus;
    this.DefensePlus.BackgroundImageLayout = ImageLayout.Center;
    this.DefensePlus.FlatAppearance.BorderColor = SystemColors.Control;
    this.DefensePlus.FlatAppearance.BorderSize = 0;
    this.DefensePlus.FlatStyle = FlatStyle.Flat;
    this.DefensePlus.Location = new Point(130, 278);
    this.DefensePlus.Name = "DefensePlus";
    this.DefensePlus.Size = new Size(26, 26);
    this.DefensePlus.TabIndex = 34;
    this.DefensePlus.UseVisualStyleBackColor = true;
    this.DefensePlus.Click += new EventHandler(this.DefensePlus_Click);
    this.CelerityPlus.BackgroundImage = (Image) Resources.plus;
    this.CelerityPlus.BackgroundImageLayout = ImageLayout.Center;
    this.CelerityPlus.FlatAppearance.BorderColor = SystemColors.Control;
    this.CelerityPlus.FlatAppearance.BorderSize = 0;
    this.CelerityPlus.FlatStyle = FlatStyle.Flat;
    this.CelerityPlus.Location = new Point(130, (int) byte.MaxValue);
    this.CelerityPlus.Name = "CelerityPlus";
    this.CelerityPlus.Size = new Size(26, 26);
    this.CelerityPlus.TabIndex = 33;
    this.CelerityPlus.UseVisualStyleBackColor = true;
    this.CelerityPlus.Click += new EventHandler(this.CelerityPlus_Click);
    this.SkillPlus.BackgroundImage = (Image) Resources.plus;
    this.SkillPlus.BackgroundImageLayout = ImageLayout.Center;
    this.SkillPlus.FlatAppearance.BorderColor = SystemColors.Control;
    this.SkillPlus.FlatAppearance.BorderSize = 0;
    this.SkillPlus.FlatStyle = FlatStyle.Flat;
    this.SkillPlus.Location = new Point(130, 230);
    this.SkillPlus.Name = "SkillPlus";
    this.SkillPlus.Size = new Size(26, 26);
    this.SkillPlus.TabIndex = 32 /*0x20*/;
    this.SkillPlus.UseVisualStyleBackColor = true;
    this.SkillPlus.Click += new EventHandler(this.SkillPlus_Click);
    this.WillPlus.BackgroundImage = (Image) Resources.plus;
    this.WillPlus.BackgroundImageLayout = ImageLayout.Center;
    this.WillPlus.FlatAppearance.BorderColor = SystemColors.Control;
    this.WillPlus.FlatAppearance.BorderSize = 0;
    this.WillPlus.FlatStyle = FlatStyle.Flat;
    this.WillPlus.Location = new Point(130, 208 /*0xD0*/);
    this.WillPlus.Name = "WillPlus";
    this.WillPlus.Size = new Size(26, 26);
    this.WillPlus.TabIndex = 31 /*0x1F*/;
    this.WillPlus.UseVisualStyleBackColor = true;
    this.WillPlus.Click += new EventHandler(this.WillPlus_Click);
    this.StrengthPlus.BackgroundImage = (Image) Resources.plus;
    this.StrengthPlus.BackgroundImageLayout = ImageLayout.Center;
    this.StrengthPlus.FlatAppearance.BorderColor = SystemColors.Control;
    this.StrengthPlus.FlatAppearance.BorderSize = 0;
    this.StrengthPlus.FlatStyle = FlatStyle.Flat;
    this.StrengthPlus.Location = new Point(130, 184);
    this.StrengthPlus.Name = "StrengthPlus";
    this.StrengthPlus.Size = new Size(26, 26);
    this.StrengthPlus.TabIndex = 28;
    this.StrengthPlus.UseVisualStyleBackColor = true;
    this.StrengthPlus.Click += new EventHandler(this.StrengthPlus_Click);
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(372, 179);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(54, 304);
    this.pictureBox1.TabIndex = 134;
    this.pictureBox1.TabStop = false;
    this.KorvaraFP.Location = new Point(403, 25);
    this.KorvaraFP.Maximum = new Decimal(new int[4]
    {
      45,
      0,
      0,
      0
    });
    this.KorvaraFP.Name = "KorvaraFP";
    this.KorvaraFP.Size = new Size(32 /*0x20*/, 20);
    this.KorvaraFP.TabIndex = 210;
    this.KorvaraFP.ValueChanged += new EventHandler(this.KorvaraFP_ValueChanged);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(351, 29);
    this.label3.Name = "label3";
    this.label3.Size = new Size(51, 13);
    this.label3.TabIndex = 209;
    this.label3.Text = "FP Shard";
    this.KorvaraHP.Location = new Point(403, 2);
    this.KorvaraHP.Maximum = new Decimal(new int[4]
    {
      45,
      0,
      0,
      0
    });
    this.KorvaraHP.Name = "KorvaraHP";
    this.KorvaraHP.Size = new Size(32 /*0x20*/, 20);
    this.KorvaraHP.TabIndex = 208 /*0xD0*/;
    this.KorvaraHP.ValueChanged += new EventHandler(this.KorvaraHP_ValueChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(349, 7);
    this.label11.Name = "label11";
    this.label11.Size = new Size(53, 13);
    this.label11.TabIndex = 207;
    this.label11.Text = "HP Shard";
    this.DateLabel.AutoSize = true;
    this.DateLabel.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.DateLabel.Location = new Point(12, 460);
    this.DateLabel.Name = "DateLabel";
    this.DateLabel.Size = new Size(49, 12);
    this.DateLabel.TabIndex = 211;
    this.DateLabel.Text = "Date Label";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(326, 123);
    this.label9.Name = "label9";
    this.label9.Size = new Size(112 /*0x70*/, 13);
    this.label9.TabIndex = 213;
    this.label9.Text = "Dragon Queen Pieces";
    this.DragonQueenBox.Location = new Point(444, 120);
    this.DragonQueenBox.Maximum = new Decimal(new int[4]
    {
      3,
      0,
      0,
      0
    });
    this.DragonQueenBox.Name = "DragonQueenBox";
    this.DragonQueenBox.Size = new Size(32 /*0x20*/, 20);
    this.DragonQueenBox.TabIndex = 212;
    this.DragonQueenBox.ValueChanged += new EventHandler(this.DragonQueenBox_ValueChanged);
    this.button1.Font = new Font("Microsoft Sans Serif", 6.25f);
    this.button1.Location = new Point(625, 291);
    this.button1.Name = "button1";
    this.button1.Size = new Size(33, 18);
    this.button1.TabIndex = 214;
    this.button1.Text = "Dork Mode";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.HistoryListBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.HistoryListBox.Font = new Font("Microsoft Sans Serif", 7.25f);
    this.HistoryListBox.FormattingEnabled = true;
    this.HistoryListBox.Items.AddRange(new object[20]
    {
      (object) "History",
      (object) "Warrior (STR++, SKI+)",
      (object) "Hero (STR++, LUC+)",
      (object) "Magician (WIL++, CEL+)",
      (object) "Spellblade (WIL++, STR+)",
      (object) "Assassin (SKI++, LUC+)",
      (object) "Myrmidon (SKI++, CEL+)",
      (object) "Fencer (CEL++, DEF+)",
      (object) "Thief (CEL++, LUC+)",
      (object) "Ward (DEF++, RES+)",
      (object) "Shaman (DEF++, WIL+)",
      (object) "Ghost (RES++, CEL+)",
      (object) "Witchhunter(RES++, STR +)",
      (object) "Marauder (VIT++, LUC+)",
      (object) "Knight (VIT++, DEF+)",
      (object) "Faithful (FAI++, RES+)",
      (object) "Priest (FAI++, WIL+)",
      (object) "Survivor(LUC++, VIT +)",
      (object) "Gambler (LUC++, STR+)",
      (object) "None"
    });
    this.HistoryListBox.Location = new Point(522, 451);
    this.HistoryListBox.Name = "HistoryListBox";
    this.HistoryListBox.Size = new Size(143, 21);
    this.HistoryListBox.TabIndex = 215;
    this.HistoryListBox.SelectedIndexChanged += new EventHandler(this.HistoryListBox_SelectedIndexChanged);
    this.EquipBTN.FlatAppearance.BorderColor = Color.Black;
    this.EquipBTN.Location = new Point(636, 156);
    this.EquipBTN.Name = "EquipBTN";
    this.EquipBTN.Size = new Size(95, 27);
    this.EquipBTN.TabIndex = 216;
    this.EquipBTN.Text = "Equipment";
    this.EquipBTN.UseVisualStyleBackColor = true;
    this.EquipBTN.Visible = false;
    this.SubraceBox.DropDownStyle = ComboBoxStyle.DropDownList;
    this.SubraceBox.Font = new Font("Microsoft Sans Serif", 7.25f);
    this.SubraceBox.FormattingEnabled = true;
    this.SubraceBox.Items.AddRange(new object[8]
    {
      (object) "Subrace",
      (object) "Avian",
      (object) "Fairy",
      (object) "Beast",
      (object) "Mystic",
      (object) "Dragon",
      (object) "Night",
      (object) "Plant"
    });
    this.SubraceBox.Location = new Point(69, 57);
    this.SubraceBox.Name = "SubraceBox";
    this.SubraceBox.Size = new Size(62, 21);
    this.SubraceBox.TabIndex = 217;
    this.SubraceBox.Visible = false;
    this.SubraceBox.SelectedIndexChanged += new EventHandler(this.SubraceBox_SelectedIndexChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.ClientSize = new Size(675, 477);
    this.Controls.Add((Control) this.SubraceBox);
    this.Controls.Add((Control) this.EquipBTN);
    this.Controls.Add((Control) this.HistoryListBox);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.DragonQueenBox);
    this.Controls.Add((Control) this.DateLabel);
    this.Controls.Add((Control) this.KorvaraFP);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.KorvaraHP);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.AllLEButton);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.FoodBox);
    this.Controls.Add((Control) this.SubClassPassive);
    this.Controls.Add((Control) this.SubClassNum);
    this.Controls.Add((Control) this.MainClassPassive);
    this.Controls.Add((Control) this.MainClassNum);
    this.Controls.Add((Control) this.SanguineCrestBox);
    this.Controls.Add((Control) this.SubClassBox);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.Youkai);
    this.Controls.Add((Control) this.Warwalk);
    this.Controls.Add((Control) this.PainTolLabel);
    this.Controls.Add((Control) this.PainTol);
    this.Controls.Add((Control) this.Fortitude);
    this.Controls.Add((Control) this.Essence);
    this.Controls.Add((Control) this.LuminaryBox);
    this.Controls.Add((Control) this.InitativeLabel);
    this.Controls.Add((Control) this.TotalHPPercent);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.RisingLabel);
    this.Controls.Add((Control) this.RisingNumeric);
    this.Controls.Add((Control) this.ReductionButton);
    this.Controls.Add((Control) this.EnduranceBox);
    this.Controls.Add((Control) this.HPPercent);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.CustomSoundRESBox);
    this.Controls.Add((Control) this.CustomAcidRESBox);
    this.Controls.Add((Control) this.CustomLightningRESBox);
    this.Controls.Add((Control) this.CustomLightRESBox);
    this.Controls.Add((Control) this.CustomWaterRESBox);
    this.Controls.Add((Control) this.CustomDarkRESBox);
    this.Controls.Add((Control) this.CustomEarthRESBox);
    this.Controls.Add((Control) this.CustomWindRESBox);
    this.Controls.Add((Control) this.CustomIceRESBox);
    this.Controls.Add((Control) this.CustomFireRESBox);
    this.Controls.Add((Control) this.CustomSoundATKBox);
    this.Controls.Add((Control) this.CustomAcidATKBox);
    this.Controls.Add((Control) this.CustomLightningATKBox);
    this.Controls.Add((Control) this.CustomLightATKBox);
    this.Controls.Add((Control) this.CustomWaterATKBox);
    this.Controls.Add((Control) this.CustomDarkATKBox);
    this.Controls.Add((Control) this.CustomEarthATKBox);
    this.Controls.Add((Control) this.CustomWindATKBox);
    this.Controls.Add((Control) this.CustomIceATKBox);
    this.Controls.Add((Control) this.CustomFireATKBox);
    this.Controls.Add((Control) this.StampsButton);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.SoundRESLabel);
    this.Controls.Add((Control) this.AcidRESLabel);
    this.Controls.Add((Control) this.LightningRESLabel);
    this.Controls.Add((Control) this.LightRESLabel);
    this.Controls.Add((Control) this.WaterRESLabel);
    this.Controls.Add((Control) this.DarkRESLabel);
    this.Controls.Add((Control) this.EarthRESLabel);
    this.Controls.Add((Control) this.WindRESLabel);
    this.Controls.Add((Control) this.IceRESLabel);
    this.Controls.Add((Control) this.FireRESLabel);
    this.Controls.Add((Control) this.DragonKingLabel);
    this.Controls.Add((Control) this.DragonKingBox);
    this.Controls.Add((Control) this.PrintButton);
    this.Controls.Add((Control) this.SoundATKLabel);
    this.Controls.Add((Control) this.AcidATKLabel);
    this.Controls.Add((Control) this.LightningATKLabel);
    this.Controls.Add((Control) this.LightATKLabel);
    this.Controls.Add((Control) this.WaterATKLabel);
    this.Controls.Add((Control) this.DarkATKLabel);
    this.Controls.Add((Control) this.EarthATKLabel);
    this.Controls.Add((Control) this.WindATKLabel);
    this.Controls.Add((Control) this.IceATKLabel);
    this.Controls.Add((Control) this.FireATKLabel);
    this.Controls.Add((Control) this.ElemATKLabel);
    this.Controls.Add((Control) this.AstrologyButton);
    this.Controls.Add((Control) this.GiantGeneCheckBox);
    this.Controls.Add((Control) this.CustomMPBox);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.CustomHPBox);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.BaseLabel);
    this.Controls.Add((Control) this.CustomBaseAptitudeBox);
    this.Controls.Add((Control) this.CustomBaseSanctityBox);
    this.Controls.Add((Control) this.CustomBaseGuileBox);
    this.Controls.Add((Control) this.CustomBaseLuckBox);
    this.Controls.Add((Control) this.CustomBaseFaithBox);
    this.Controls.Add((Control) this.CustomBaseVitalityBox);
    this.Controls.Add((Control) this.CustomBaseResistanceBox);
    this.Controls.Add((Control) this.CustomBaseDefenseBox);
    this.Controls.Add((Control) this.CustomBaseCelerityBox);
    this.Controls.Add((Control) this.CustomBaseSkillBox);
    this.Controls.Add((Control) this.CustomBaseWillBox);
    this.Controls.Add((Control) this.CustomBaseStrengthBox);
    this.Controls.Add((Control) this.AkurZoButton);
    this.Controls.Add((Control) this.LunaCuButton);
    this.Controls.Add((Control) this.BattleWeightLabel);
    this.Controls.Add((Control) this.EncumbranceLabel);
    this.Controls.Add((Control) this.SkillPoolLabel);
    this.Controls.Add((Control) this.FlankingLabel);
    this.Controls.Add((Control) this.StatusResistLabel);
    this.Controls.Add((Control) this.StatusInflictLabel);
    this.Controls.Add((Control) this.CritEvadeLabel);
    this.Controls.Add((Control) this.EvadeLabel);
    this.Controls.Add((Control) this.MagDefLabel);
    this.Controls.Add((Control) this.PhysDefLabel);
    this.Controls.Add((Control) this.DebugDRButton);
    this.Controls.Add((Control) this.MPLabel);
    this.Controls.Add((Control) this.HPLabel);
    this.Controls.Add((Control) this.CustomLabel);
    this.Controls.Add((Control) this.CustomAptitudeBox);
    this.Controls.Add((Control) this.CustomSanctityBox);
    this.Controls.Add((Control) this.CustomGuileBox);
    this.Controls.Add((Control) this.CustomLuckBox);
    this.Controls.Add((Control) this.CustomFaithBox);
    this.Controls.Add((Control) this.CustomVitalityBox);
    this.Controls.Add((Control) this.CustomResistanceBox);
    this.Controls.Add((Control) this.CustomDefenseBox);
    this.Controls.Add((Control) this.CustomCelerityBox);
    this.Controls.Add((Control) this.CustomSkillBox);
    this.Controls.Add((Control) this.CustomWillBox);
    this.Controls.Add((Control) this.CustomStrengthBox);
    this.Controls.Add((Control) this.VersionLabel);
    this.Controls.Add((Control) this.ZeroGyButton);
    this.Controls.Add((Control) this.RabeUrButton);
    this.Controls.Add((Control) this.KashIcButton);
    this.Controls.Add((Control) this.KagiJiButton);
    this.Controls.Add((Control) this.HolyMrButton);
    this.Controls.Add((Control) this.GrenUtButton);
    this.Controls.Add((Control) this.ChoiErButton);
    this.Controls.Add((Control) this.BldiIaButton);
    this.Controls.Add((Control) this.AxysAlButton);
    this.Controls.Add((Control) this.ResetButton);
    this.Controls.Add((Control) this.AptitudeMinus);
    this.Controls.Add((Control) this.SanctityMinus);
    this.Controls.Add((Control) this.GuileMinus);
    this.Controls.Add((Control) this.LuckMinus);
    this.Controls.Add((Control) this.FaithMinus);
    this.Controls.Add((Control) this.VitalityMinus);
    this.Controls.Add((Control) this.ResistanceMinus);
    this.Controls.Add((Control) this.DefenseMinus);
    this.Controls.Add((Control) this.CelerityMinus);
    this.Controls.Add((Control) this.SkillMinus);
    this.Controls.Add((Control) this.WillMinus);
    this.Controls.Add((Control) this.StrengthMinus);
    this.Controls.Add((Control) this.AptitudePlus);
    this.Controls.Add((Control) this.SanctityPlus);
    this.Controls.Add((Control) this.GuilePlus);
    this.Controls.Add((Control) this.LuckPlus);
    this.Controls.Add((Control) this.FaithPlus);
    this.Controls.Add((Control) this.VitalityPlus);
    this.Controls.Add((Control) this.ResistancePlus);
    this.Controls.Add((Control) this.DefensePlus);
    this.Controls.Add((Control) this.CelerityPlus);
    this.Controls.Add((Control) this.SkillPlus);
    this.Controls.Add((Control) this.WillPlus);
    this.Controls.Add((Control) this.RaceLabel);
    this.Controls.Add((Control) this.ClassLabel);
    this.Controls.Add((Control) this.StrengthPlus);
    this.Controls.Add((Control) this.ClassBox);
    this.Controls.Add((Control) this.RaceBox);
    this.Controls.Add((Control) this.TotalPointsLabel);
    this.Controls.Add((Control) this.AptitudeLabel);
    this.Controls.Add((Control) this.SanctityLabel);
    this.Controls.Add((Control) this.GuileLabel);
    this.Controls.Add((Control) this.LuckLabel);
    this.Controls.Add((Control) this.FaithLabel);
    this.Controls.Add((Control) this.VitalityLabel);
    this.Controls.Add((Control) this.ResistanceLabel);
    this.Controls.Add((Control) this.DefenseLabel);
    this.Controls.Add((Control) this.CelerityLabel);
    this.Controls.Add((Control) this.SkillLabel);
    this.Controls.Add((Control) this.WillLabel);
    this.Controls.Add((Control) this.StrengthLabel);
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
    this.Controls.Add((Control) this.WeaponButton);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.GrimalkinI);
    this.ForeColor = SystemColors.ControlText;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (MainWindow);
    this.Text = "SL2 Reckoning Calculator";
    this.Load += new EventHandler(this.MainWindow_Load);
    ((ISupportInitialize) this.AkurZoButton).EndInit();
    ((ISupportInitialize) this.LunaCuButton).EndInit();
    ((ISupportInitialize) this.ZeroGyButton).EndInit();
    ((ISupportInitialize) this.RabeUrButton).EndInit();
    ((ISupportInitialize) this.KashIcButton).EndInit();
    ((ISupportInitialize) this.KagiJiButton).EndInit();
    ((ISupportInitialize) this.HolyMrButton).EndInit();
    ((ISupportInitialize) this.GrenUtButton).EndInit();
    ((ISupportInitialize) this.ChoiErButton).EndInit();
    ((ISupportInitialize) this.BldiIaButton).EndInit();
    ((ISupportInitialize) this.AxysAlButton).EndInit();
    ((ISupportInitialize) this.AllLEButton).EndInit();
    this.CustomStrengthBox.EndInit();
    this.CustomWillBox.EndInit();
    this.CustomSkillBox.EndInit();
    this.CustomCelerityBox.EndInit();
    this.CustomDefenseBox.EndInit();
    this.CustomResistanceBox.EndInit();
    this.CustomVitalityBox.EndInit();
    this.CustomFaithBox.EndInit();
    this.CustomLuckBox.EndInit();
    this.CustomGuileBox.EndInit();
    this.CustomSanctityBox.EndInit();
    this.CustomAptitudeBox.EndInit();
    this.CustomBaseAptitudeBox.EndInit();
    this.CustomBaseSanctityBox.EndInit();
    this.CustomBaseGuileBox.EndInit();
    this.CustomBaseLuckBox.EndInit();
    this.CustomBaseFaithBox.EndInit();
    this.CustomBaseVitalityBox.EndInit();
    this.CustomBaseResistanceBox.EndInit();
    this.CustomBaseDefenseBox.EndInit();
    this.CustomBaseCelerityBox.EndInit();
    this.CustomBaseSkillBox.EndInit();
    this.CustomBaseWillBox.EndInit();
    this.CustomBaseStrengthBox.EndInit();
    this.CustomHPBox.EndInit();
    this.CustomMPBox.EndInit();
    this.DragonKingBox.EndInit();
    this.CustomSoundATKBox.EndInit();
    this.CustomAcidATKBox.EndInit();
    this.CustomLightningATKBox.EndInit();
    this.CustomLightATKBox.EndInit();
    this.CustomWaterATKBox.EndInit();
    this.CustomDarkATKBox.EndInit();
    this.CustomEarthATKBox.EndInit();
    this.CustomWindATKBox.EndInit();
    this.CustomIceATKBox.EndInit();
    this.CustomFireATKBox.EndInit();
    this.CustomSoundRESBox.EndInit();
    this.CustomAcidRESBox.EndInit();
    this.CustomLightningRESBox.EndInit();
    this.CustomLightRESBox.EndInit();
    this.CustomWaterRESBox.EndInit();
    this.CustomDarkRESBox.EndInit();
    this.CustomEarthRESBox.EndInit();
    this.CustomWindRESBox.EndInit();
    this.CustomIceRESBox.EndInit();
    this.CustomFireRESBox.EndInit();
    this.HPPercent.EndInit();
    this.RisingNumeric.EndInit();
    this.TotalHPPercent.EndInit();
    this.PainTol.EndInit();
    this.MainClassNum.EndInit();
    this.SubClassNum.EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.KorvaraFP.EndInit();
    this.KorvaraHP.EndInit();
    this.DragonQueenBox.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
