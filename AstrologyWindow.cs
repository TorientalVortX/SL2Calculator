// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.AstrologyWindow
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

public class AstrologyWindow : Form
{
  private MainWindow MainForm;
  private IContainer components;
  private PictureBox UranusIcon;
  private PictureBox VenusIcon;
  private PictureBox NeptuneIcon;
  private PictureBox MercuryIcon;
  private PictureBox PlutoIcon;
  private PictureBox MarsIcon;
  private PictureBox JupiterIcon;
  private PictureBox SaturnIcon;
  private Button NoAstroButton;
  private ToolTip Tooltip;

  public AstrologyWindow(MainWindow that)
  {
    this.MainForm = that;
    this.InitializeComponent();
    this.Tooltip.SetToolTip((Control) this.MercuryIcon, "Mercury +1 SKI, +2 Ice ATK");
    this.Tooltip.SetToolTip((Control) this.VenusIcon, "Venus +1 DEF, +2 Earth ATK");
    this.Tooltip.SetToolTip((Control) this.MarsIcon, "Mars +1 STR, +2 Fire ATK");
    this.Tooltip.SetToolTip((Control) this.JupiterIcon, "Jupiter +1 LUC, +2 Lightning ATK");
    this.Tooltip.SetToolTip((Control) this.SaturnIcon, "Saturn +1 CEL, +2 Wind ATK");
    this.Tooltip.SetToolTip((Control) this.NeptuneIcon, "Neptune +1 VIT, +2 Water ATK");
    this.Tooltip.SetToolTip((Control) this.UranusIcon, "Uranus +1 FAI, +2 Light ATK");
    this.Tooltip.SetToolTip((Control) this.PlutoIcon, "Pluto +1 RES, +2 Dark ATK");
  }

  private void button1_Click(object sender, EventArgs e) => this.MainForm.SetNoSign();

  private void UranusIcon_Click(object sender, EventArgs e) => this.MainForm.SetUranus();

  private void VenusIcon_Click(object sender, EventArgs e) => this.MainForm.SetVenus();

  private void NeptuneIcon_Click(object sender, EventArgs e) => this.MainForm.SetNeptune();

  private void MercuryIcon_Click(object sender, EventArgs e) => this.MainForm.SetMercury();

  private void PlutoIcon_Click(object sender, EventArgs e) => this.MainForm.SetPluto();

  private void MarsIcon_Click(object sender, EventArgs e) => this.MainForm.SetMars();

  private void JupiterIcon_Click(object sender, EventArgs e) => this.MainForm.SetJupiter();

  private void SaturnIcon_Click(object sender, EventArgs e) => this.MainForm.SetSaturn();

  private void AstrologyWindow_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.MainForm.ClosedAstrologyWindow();
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
    this.UranusIcon = new PictureBox();
    this.VenusIcon = new PictureBox();
    this.NeptuneIcon = new PictureBox();
    this.MercuryIcon = new PictureBox();
    this.PlutoIcon = new PictureBox();
    this.MarsIcon = new PictureBox();
    this.JupiterIcon = new PictureBox();
    this.SaturnIcon = new PictureBox();
    this.NoAstroButton = new Button();
    this.Tooltip = new ToolTip(this.components);
    ((ISupportInitialize) this.UranusIcon).BeginInit();
    ((ISupportInitialize) this.VenusIcon).BeginInit();
    ((ISupportInitialize) this.NeptuneIcon).BeginInit();
    ((ISupportInitialize) this.MercuryIcon).BeginInit();
    ((ISupportInitialize) this.PlutoIcon).BeginInit();
    ((ISupportInitialize) this.MarsIcon).BeginInit();
    ((ISupportInitialize) this.JupiterIcon).BeginInit();
    ((ISupportInitialize) this.SaturnIcon).BeginInit();
    this.SuspendLayout();
    this.UranusIcon.BackColor = Color.Transparent;
    this.UranusIcon.BorderStyle = BorderStyle.FixedSingle;
    this.UranusIcon.Image = (Image) Resources.Uranus;
    this.UranusIcon.InitialImage = (Image) Resources.Uranus;
    this.UranusIcon.Location = new Point(128 /*0x80*/, 3);
    this.UranusIcon.Name = "UranusIcon";
    this.UranusIcon.Size = new Size(54, 55);
    this.UranusIcon.TabIndex = 0;
    this.UranusIcon.TabStop = false;
    this.UranusIcon.Click += new EventHandler(this.UranusIcon_Click);
    this.VenusIcon.BackColor = Color.Transparent;
    this.VenusIcon.BorderStyle = BorderStyle.FixedSingle;
    this.VenusIcon.Image = (Image) Resources.Venus;
    this.VenusIcon.InitialImage = (Image) Resources.Venus;
    this.VenusIcon.Location = new Point(65, 66);
    this.VenusIcon.Name = "VenusIcon";
    this.VenusIcon.Size = new Size(54, 55);
    this.VenusIcon.TabIndex = 1;
    this.VenusIcon.TabStop = false;
    this.VenusIcon.Click += new EventHandler(this.VenusIcon_Click);
    this.NeptuneIcon.BackColor = Color.Transparent;
    this.NeptuneIcon.BorderStyle = BorderStyle.FixedSingle;
    this.NeptuneIcon.Image = (Image) Resources.Neptune;
    this.NeptuneIcon.InitialImage = (Image) Resources.Neptune;
    this.NeptuneIcon.Location = new Point(3, 129);
    this.NeptuneIcon.Name = "NeptuneIcon";
    this.NeptuneIcon.Size = new Size(54, 55);
    this.NeptuneIcon.TabIndex = 2;
    this.NeptuneIcon.TabStop = false;
    this.NeptuneIcon.Click += new EventHandler(this.NeptuneIcon_Click);
    this.MercuryIcon.BackColor = Color.Transparent;
    this.MercuryIcon.BorderStyle = BorderStyle.FixedSingle;
    this.MercuryIcon.Image = (Image) Resources.Mercury;
    this.MercuryIcon.InitialImage = (Image) Resources.Mercury;
    this.MercuryIcon.Location = new Point(65, 195);
    this.MercuryIcon.Name = "MercuryIcon";
    this.MercuryIcon.Size = new Size(54, 55);
    this.MercuryIcon.TabIndex = 3;
    this.MercuryIcon.TabStop = false;
    this.MercuryIcon.Click += new EventHandler(this.MercuryIcon_Click);
    this.PlutoIcon.BackColor = Color.Transparent;
    this.PlutoIcon.BorderStyle = BorderStyle.FixedSingle;
    this.PlutoIcon.Image = (Image) Resources.Pluto;
    this.PlutoIcon.InitialImage = (Image) Resources.Pluto;
    this.PlutoIcon.Location = new Point(128 /*0x80*/, 256 /*0x0100*/);
    this.PlutoIcon.Name = "PlutoIcon";
    this.PlutoIcon.Size = new Size(54, 55);
    this.PlutoIcon.TabIndex = 4;
    this.PlutoIcon.TabStop = false;
    this.PlutoIcon.Click += new EventHandler(this.PlutoIcon_Click);
    this.MarsIcon.BackColor = Color.Transparent;
    this.MarsIcon.BorderStyle = BorderStyle.FixedSingle;
    this.MarsIcon.Image = (Image) Resources.Mars;
    this.MarsIcon.InitialImage = (Image) Resources.Mars;
    this.MarsIcon.Location = new Point(192 /*0xC0*/, 195);
    this.MarsIcon.Name = "MarsIcon";
    this.MarsIcon.Size = new Size(54, 55);
    this.MarsIcon.TabIndex = 5;
    this.MarsIcon.TabStop = false;
    this.MarsIcon.Click += new EventHandler(this.MarsIcon_Click);
    this.JupiterIcon.BackColor = Color.Transparent;
    this.JupiterIcon.BorderStyle = BorderStyle.FixedSingle;
    this.JupiterIcon.Image = (Image) Resources.Jupiter;
    this.JupiterIcon.InitialImage = (Image) Resources.Jupiter;
    this.JupiterIcon.Location = new Point(252, 129);
    this.JupiterIcon.Name = "JupiterIcon";
    this.JupiterIcon.Size = new Size(54, 55);
    this.JupiterIcon.TabIndex = 6;
    this.JupiterIcon.TabStop = false;
    this.JupiterIcon.Click += new EventHandler(this.JupiterIcon_Click);
    this.SaturnIcon.BackColor = Color.Transparent;
    this.SaturnIcon.BorderStyle = BorderStyle.FixedSingle;
    this.SaturnIcon.Image = (Image) Resources.Saturn;
    this.SaturnIcon.InitialImage = (Image) Resources.Saturn;
    this.SaturnIcon.Location = new Point(192 /*0xC0*/, 66);
    this.SaturnIcon.Name = "SaturnIcon";
    this.SaturnIcon.Size = new Size(54, 55);
    this.SaturnIcon.TabIndex = 7;
    this.SaturnIcon.TabStop = false;
    this.SaturnIcon.Click += new EventHandler(this.SaturnIcon_Click);
    this.NoAstroButton.Location = new Point(3, 270);
    this.NoAstroButton.Name = "NoAstroButton";
    this.NoAstroButton.Size = new Size(96 /*0x60*/, 41);
    this.NoAstroButton.TabIndex = 8;
    this.NoAstroButton.Text = "No stars for me, thanks.";
    this.NoAstroButton.UseVisualStyleBackColor = true;
    this.NoAstroButton.Click += new EventHandler(this.button1_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) Resources.Starsign;
    this.ClientSize = new Size(307, 313);
    this.Controls.Add((Control) this.NoAstroButton);
    this.Controls.Add((Control) this.SaturnIcon);
    this.Controls.Add((Control) this.JupiterIcon);
    this.Controls.Add((Control) this.MarsIcon);
    this.Controls.Add((Control) this.PlutoIcon);
    this.Controls.Add((Control) this.MercuryIcon);
    this.Controls.Add((Control) this.NeptuneIcon);
    this.Controls.Add((Control) this.VenusIcon);
    this.Controls.Add((Control) this.UranusIcon);
    this.MaximumSize = new Size(323, 352);
    this.MinimumSize = new Size(323, 352);
    this.Name = nameof (AstrologyWindow);
    this.Text = nameof (AstrologyWindow);
    this.FormClosing += new FormClosingEventHandler(this.AstrologyWindow_FormClosing);
    ((ISupportInitialize) this.UranusIcon).EndInit();
    ((ISupportInitialize) this.VenusIcon).EndInit();
    ((ISupportInitialize) this.NeptuneIcon).EndInit();
    ((ISupportInitialize) this.MercuryIcon).EndInit();
    ((ISupportInitialize) this.PlutoIcon).EndInit();
    ((ISupportInitialize) this.MarsIcon).EndInit();
    ((ISupportInitialize) this.JupiterIcon).EndInit();
    ((ISupportInitialize) this.SaturnIcon).EndInit();
    this.ResumeLayout(false);
  }
}
