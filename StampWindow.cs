// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.StampWindow
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

public class StampWindow : Form
{
  private MainWindow MainForm;
  private int Vit1;
  private int Vit2;
  private int Vit3;
  private int Fai1;
  private int Fai2;
  private int Str1;
  private int Wil1;
  private int Ski1;
  private int Cel1;
  private int Water1;
  private int Earth1;
  private int Light1;
  private int Dark1;
  private IContainer components;
  private PictureBox Vit1Box;
  private PictureBox Vit2Box;
  private PictureBox Vit3Box;
  private PictureBox Fai1Box;
  private PictureBox Fai2Box;
  private PictureBox Str1Box;
  private PictureBox Wil1Box;
  private PictureBox Cel1Box;
  private PictureBox Ski1Box;
  private PictureBox Water1Box;
  private PictureBox Earth1Box;
  private PictureBox Light1Box;
  private PictureBox Dark1Box;
  private ToolTip ToolTip;

  public StampWindow(MainWindow that)
  {
    this.MainForm = that;
    this.InitializeComponent();
    this.ToolTip.SetToolTip((Control) this.Vit1Box, "Hikari's Silver Halo - +1 VIT");
    this.ToolTip.SetToolTip((Control) this.Vit2Box, "Hikari's Gold Halo - +1 VIT");
    this.ToolTip.SetToolTip((Control) this.Vit3Box, "Body Stamp - +1 VIT");
    this.ToolTip.SetToolTip((Control) this.Fai1Box, "Hikari's Silver Mercana Sign - +1 FAI");
    this.ToolTip.SetToolTip((Control) this.Fai2Box, "Hikari's Gold Mercana Sign - +1 FAI");
    this.ToolTip.SetToolTip((Control) this.Str1Box, "Power Stamp - +1 STR");
    this.ToolTip.SetToolTip((Control) this.Wil1Box, "Peace of Mind Stamp - +1 WIL");
    this.ToolTip.SetToolTip((Control) this.Ski1Box, "Shael's Stamp of Pathfinding - +1 SKI");
    this.ToolTip.SetToolTip((Control) this.Cel1Box, "Kitty Stamp - +1 CEL");
    this.ToolTip.SetToolTip((Control) this.Water1Box, "Alex's Fishing Stamp - +1% Water Resist");
    this.ToolTip.SetToolTip((Control) this.Earth1Box, "Shifting Sands - +1% Earth Resist");
    this.ToolTip.SetToolTip((Control) this.Light1Box, "Ashe's Holy Light - +1% Light Resist");
    this.ToolTip.SetToolTip((Control) this.Dark1Box, "Black Beast Slayer - +1% Dark Resist");
  }

  public void Initialize()
  {
    this.Vit1 = 0;
    this.Vit2 = 0;
    this.Vit3 = 0;
    this.Fai1 = 0;
    this.Fai2 = 0;
    this.Str1 = 0;
    this.Wil1 = 0;
    this.Ski1 = 0;
    this.Cel1 = 0;
    this.Water1 = 0;
    this.Earth1 = 0;
    this.Light1 = 0;
    this.Dark1 = 0;
    this.Vit1Box.Image = (Image) Resources.vit1;
    this.Vit2Box.Image = (Image) Resources.vit2;
    this.Vit3Box.Image = (Image) Resources.vit3;
    this.Fai1Box.Image = (Image) Resources.fai1;
    this.Fai2Box.Image = (Image) Resources.fai2;
    this.Str1Box.Image = (Image) Resources.str1;
    this.Wil1Box.Image = (Image) Resources.wil1;
    this.Ski1Box.Image = (Image) Resources.ski1;
    this.Cel1Box.Image = (Image) Resources.cel1;
    this.Water1Box.Image = (Image) Resources.water1;
    this.Earth1Box.Image = (Image) Resources.earth1;
    this.Light1Box.Image = (Image) Resources.light1;
    this.Dark1Box.Image = (Image) Resources.dark1;
    this.MainForm.StampStats();
  }

  public int Vit() => this.Vit1 + this.Vit2 + this.Vit3;

  public int Fai() => this.Fai1 + this.Fai2;

  public int Str() => this.Str1;

  public int Wil() => this.Wil1;

  public int Ski() => this.Ski1;

  public int Cel() => this.Cel1;

  public int Water() => this.Water1;

  public int Earth() => this.Earth1;

  public int Light() => this.Light1;

  public int Dark() => this.Dark1;

  private void Vit1Box_Click(object sender, EventArgs e)
  {
    if (this.Vit1 == 0)
    {
      this.Vit1Box.Image = (Image) Resources.vit1green;
      this.Vit1 = 1;
    }
    else
    {
      this.Vit1Box.Image = (Image) Resources.vit1;
      this.Vit1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Vit2Box_Click(object sender, EventArgs e)
  {
    if (this.Vit2 == 0)
    {
      this.Vit2Box.Image = (Image) Resources.vit2green;
      this.Vit2 = 1;
    }
    else
    {
      this.Vit2Box.Image = (Image) Resources.vit2;
      this.Vit2 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Vit3Box_Click(object sender, EventArgs e)
  {
    if (this.Vit3 == 0)
    {
      this.Vit3Box.Image = (Image) Resources.vit3green;
      this.Vit3 = 1;
    }
    else
    {
      this.Vit3Box.Image = (Image) Resources.vit3;
      this.Vit3 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Fai1Box_Click(object sender, EventArgs e)
  {
    if (this.Fai1 == 0)
    {
      this.Fai1Box.Image = (Image) Resources.fai1green;
      this.Fai1 = 1;
    }
    else
    {
      this.Fai1Box.Image = (Image) Resources.fai1;
      this.Fai1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Fai2Box_Click(object sender, EventArgs e)
  {
    if (this.Fai2 == 0)
    {
      this.Fai2Box.Image = (Image) Resources.fai2green;
      this.Fai2 = 1;
    }
    else
    {
      this.Fai2Box.Image = (Image) Resources.fai2;
      this.Fai2 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Str1Box_Click(object sender, EventArgs e)
  {
    if (this.Str1 == 0)
    {
      this.Str1Box.Image = (Image) Resources.str1green;
      this.Str1 = 1;
    }
    else
    {
      this.Str1Box.Image = (Image) Resources.str1;
      this.Str1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Wil1Box_Click(object sender, EventArgs e)
  {
    if (this.Wil1 == 0)
    {
      this.Wil1Box.Image = (Image) Resources.wil1green;
      this.Wil1 = 1;
    }
    else
    {
      this.Wil1Box.Image = (Image) Resources.wil1;
      this.Wil1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Ski1Box_Click(object sender, EventArgs e)
  {
    if (this.Ski1 == 0)
    {
      this.Ski1Box.Image = (Image) Resources.ski1green;
      this.Ski1 = 1;
    }
    else
    {
      this.Ski1Box.Image = (Image) Resources.ski1;
      this.Ski1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Cel1Box_Click(object sender, EventArgs e)
  {
    if (this.Cel1 == 0)
    {
      this.Cel1Box.Image = (Image) Resources.cel1green;
      this.Cel1 = 1;
    }
    else
    {
      this.Cel1Box.Image = (Image) Resources.cel1;
      this.Cel1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Water1Box_Click(object sender, EventArgs e)
  {
    if (this.Water1 == 0)
    {
      this.Water1Box.Image = (Image) Resources.water1green;
      this.Water1 = 1;
    }
    else
    {
      this.Water1Box.Image = (Image) Resources.water1;
      this.Water1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Earth1Box_Click(object sender, EventArgs e)
  {
    if (this.Earth1 == 0)
    {
      this.Earth1Box.Image = (Image) Resources.earth1green;
      this.Earth1 = 1;
    }
    else
    {
      this.Earth1Box.Image = (Image) Resources.earth1;
      this.Earth1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Light1Box_Click(object sender, EventArgs e)
  {
    if (this.Light1 == 0)
    {
      this.Light1Box.Image = (Image) Resources.light1green;
      this.Light1 = 1;
    }
    else
    {
      this.Light1Box.Image = (Image) Resources.light1;
      this.Light1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void Dark1Box_Click(object sender, EventArgs e)
  {
    if (this.Dark1 == 0)
    {
      this.Dark1Box.Image = (Image) Resources.dark1green;
      this.Dark1 = 1;
    }
    else
    {
      this.Dark1Box.Image = (Image) Resources.dark1;
      this.Dark1 = 0;
    }
    this.MainForm.StampStats();
  }

  private void StampWindow_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.Visible = false;
    e.Cancel = true;
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
    this.Vit1Box = new PictureBox();
    this.Vit2Box = new PictureBox();
    this.Vit3Box = new PictureBox();
    this.Fai1Box = new PictureBox();
    this.Fai2Box = new PictureBox();
    this.Str1Box = new PictureBox();
    this.Wil1Box = new PictureBox();
    this.Cel1Box = new PictureBox();
    this.Ski1Box = new PictureBox();
    this.Water1Box = new PictureBox();
    this.Earth1Box = new PictureBox();
    this.Light1Box = new PictureBox();
    this.Dark1Box = new PictureBox();
    this.ToolTip = new ToolTip(this.components);
    ((ISupportInitialize) this.Vit1Box).BeginInit();
    ((ISupportInitialize) this.Vit2Box).BeginInit();
    ((ISupportInitialize) this.Vit3Box).BeginInit();
    ((ISupportInitialize) this.Fai1Box).BeginInit();
    ((ISupportInitialize) this.Fai2Box).BeginInit();
    ((ISupportInitialize) this.Str1Box).BeginInit();
    ((ISupportInitialize) this.Wil1Box).BeginInit();
    ((ISupportInitialize) this.Cel1Box).BeginInit();
    ((ISupportInitialize) this.Ski1Box).BeginInit();
    ((ISupportInitialize) this.Water1Box).BeginInit();
    ((ISupportInitialize) this.Earth1Box).BeginInit();
    ((ISupportInitialize) this.Light1Box).BeginInit();
    ((ISupportInitialize) this.Dark1Box).BeginInit();
    this.SuspendLayout();
    this.Vit1Box.Image = (Image) Resources.vit1;
    this.Vit1Box.Location = new Point(2, 3);
    this.Vit1Box.Name = "Vit1Box";
    this.Vit1Box.Size = new Size(26, 28);
    this.Vit1Box.TabIndex = 59;
    this.Vit1Box.TabStop = false;
    this.Vit1Box.Click += new EventHandler(this.Vit1Box_Click);
    this.Vit2Box.Image = (Image) Resources.vit2;
    this.Vit2Box.Location = new Point(34, 3);
    this.Vit2Box.Name = "Vit2Box";
    this.Vit2Box.Size = new Size(26, 28);
    this.Vit2Box.TabIndex = 60;
    this.Vit2Box.TabStop = false;
    this.Vit2Box.Click += new EventHandler(this.Vit2Box_Click);
    this.Vit3Box.Image = (Image) Resources.vit3;
    this.Vit3Box.Location = new Point(66, 3);
    this.Vit3Box.Name = "Vit3Box";
    this.Vit3Box.Size = new Size(26, 28);
    this.Vit3Box.TabIndex = 61;
    this.Vit3Box.TabStop = false;
    this.Vit3Box.Click += new EventHandler(this.Vit3Box_Click);
    this.Fai1Box.Image = (Image) Resources.fai1;
    this.Fai1Box.Location = new Point(3, 35);
    this.Fai1Box.Name = "Fai1Box";
    this.Fai1Box.Size = new Size(26, 28);
    this.Fai1Box.TabIndex = 62;
    this.Fai1Box.TabStop = false;
    this.Fai1Box.Click += new EventHandler(this.Fai1Box_Click);
    this.Fai2Box.Image = (Image) Resources.fai2;
    this.Fai2Box.Location = new Point(35, 35);
    this.Fai2Box.Name = "Fai2Box";
    this.Fai2Box.Size = new Size(26, 28);
    this.Fai2Box.TabIndex = 63 /*0x3F*/;
    this.Fai2Box.TabStop = false;
    this.Fai2Box.Click += new EventHandler(this.Fai2Box_Click);
    this.Str1Box.Image = (Image) Resources.str1;
    this.Str1Box.Location = new Point(131, 3);
    this.Str1Box.Name = "Str1Box";
    this.Str1Box.Size = new Size(26, 28);
    this.Str1Box.TabIndex = 64 /*0x40*/;
    this.Str1Box.TabStop = false;
    this.Str1Box.Click += new EventHandler(this.Str1Box_Click);
    this.Wil1Box.Image = (Image) Resources.wil1;
    this.Wil1Box.Location = new Point(99, 35);
    this.Wil1Box.Name = "Wil1Box";
    this.Wil1Box.Size = new Size(26, 28);
    this.Wil1Box.TabIndex = 65;
    this.Wil1Box.TabStop = false;
    this.Wil1Box.Click += new EventHandler(this.Wil1Box_Click);
    this.Cel1Box.Image = (Image) Resources.cel1;
    this.Cel1Box.Location = new Point(131, 65);
    this.Cel1Box.Name = "Cel1Box";
    this.Cel1Box.Size = new Size(26, 28);
    this.Cel1Box.TabIndex = 66;
    this.Cel1Box.TabStop = false;
    this.Cel1Box.Click += new EventHandler(this.Cel1Box_Click);
    this.Ski1Box.Image = (Image) Resources.ski1;
    this.Ski1Box.Location = new Point(163, 35);
    this.Ski1Box.Name = "Ski1Box";
    this.Ski1Box.Size = new Size(26, 28);
    this.Ski1Box.TabIndex = 67;
    this.Ski1Box.TabStop = false;
    this.Ski1Box.Click += new EventHandler(this.Ski1Box_Click);
    this.Water1Box.Image = (Image) Resources.water1;
    this.Water1Box.Location = new Point(3, 98);
    this.Water1Box.Name = "Water1Box";
    this.Water1Box.Size = new Size(26, 28);
    this.Water1Box.TabIndex = 68;
    this.Water1Box.TabStop = false;
    this.Water1Box.Click += new EventHandler(this.Water1Box_Click);
    this.Earth1Box.Image = (Image) Resources.earth1;
    this.Earth1Box.Location = new Point(35, 98);
    this.Earth1Box.Name = "Earth1Box";
    this.Earth1Box.Size = new Size(26, 28);
    this.Earth1Box.TabIndex = 69;
    this.Earth1Box.TabStop = false;
    this.Earth1Box.Click += new EventHandler(this.Earth1Box_Click);
    this.Light1Box.Image = (Image) Resources.light1;
    this.Light1Box.Location = new Point(67, 98);
    this.Light1Box.Name = "Light1Box";
    this.Light1Box.Size = new Size(26, 28);
    this.Light1Box.TabIndex = 70;
    this.Light1Box.TabStop = false;
    this.Light1Box.Click += new EventHandler(this.Light1Box_Click);
    this.Dark1Box.Image = (Image) Resources.dark1;
    this.Dark1Box.Location = new Point(99, 98);
    this.Dark1Box.Name = "Dark1Box";
    this.Dark1Box.Size = new Size(26, 28);
    this.Dark1Box.TabIndex = 71;
    this.Dark1Box.TabStop = false;
    this.Dark1Box.Click += new EventHandler(this.Dark1Box_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) Resources.stamps2;
    this.ClientSize = new Size(197, 128 /*0x80*/);
    this.Controls.Add((Control) this.Dark1Box);
    this.Controls.Add((Control) this.Light1Box);
    this.Controls.Add((Control) this.Earth1Box);
    this.Controls.Add((Control) this.Water1Box);
    this.Controls.Add((Control) this.Ski1Box);
    this.Controls.Add((Control) this.Cel1Box);
    this.Controls.Add((Control) this.Wil1Box);
    this.Controls.Add((Control) this.Str1Box);
    this.Controls.Add((Control) this.Fai2Box);
    this.Controls.Add((Control) this.Fai1Box);
    this.Controls.Add((Control) this.Vit3Box);
    this.Controls.Add((Control) this.Vit2Box);
    this.Controls.Add((Control) this.Vit1Box);
    this.Name = nameof (StampWindow);
    this.Text = nameof (StampWindow);
    this.FormClosing += new FormClosingEventHandler(this.StampWindow_FormClosing);
    ((ISupportInitialize) this.Vit1Box).EndInit();
    ((ISupportInitialize) this.Vit2Box).EndInit();
    ((ISupportInitialize) this.Vit3Box).EndInit();
    ((ISupportInitialize) this.Fai1Box).EndInit();
    ((ISupportInitialize) this.Fai2Box).EndInit();
    ((ISupportInitialize) this.Str1Box).EndInit();
    ((ISupportInitialize) this.Wil1Box).EndInit();
    ((ISupportInitialize) this.Cel1Box).EndInit();
    ((ISupportInitialize) this.Ski1Box).EndInit();
    ((ISupportInitialize) this.Water1Box).EndInit();
    ((ISupportInitialize) this.Earth1Box).EndInit();
    ((ISupportInitialize) this.Light1Box).EndInit();
    ((ISupportInitialize) this.Dark1Box).EndInit();
    this.ResumeLayout(false);
  }
}
