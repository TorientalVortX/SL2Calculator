// Decompiled with JetBrains decompiler
// Type: SL2_Reckoning_Calculator.Program
// Assembly: SL2 Reckoning Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA3BB676-BB0B-4853-B9BA-79F2857E373B
// Assembly location: C:\Users\chris\Downloads\SL2 Reckoning Calculator updated.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace SL2_Reckoning_Calculator;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new MainWindow());
  }
}
