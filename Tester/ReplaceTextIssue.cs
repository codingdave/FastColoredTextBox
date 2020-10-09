using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class ReplaceTextIssue : Form
    {
        private readonly Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        private readonly Style RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);

        public ReplaceTextIssue()
        {
            InitializeComponent();
            fctb.Text = @"0 Lorem
1 ipsum
2 dolor
3 sit
4 amet";
            //fctb.style
            fctb.TextChanged += Fctb_TextChanged;
            fctb.Range.SetStyle(GreenStyle);
        }

        private void Fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.SetStyle(RedStyle);
        }

        private void btGotToEnd_Click(object sender, EventArgs e)
        {
            var replaces = new List<ReplaceMultipleTextCommand.ReplaceRange>();
            for (int i = 0; i < 5; ++i)
            {
                replaces.Add(new ReplaceMultipleTextCommand.ReplaceRange() { ReplacedRange = new Range(fctb, 0, i, 2, i), ReplaceText = $"replaced line {i} " });
            }
            fctb.BeginUpdate();
            fctb.TextSource.Manager.ExecuteCommand(new ReplaceMultipleTextCommand(fctb.TextSource, replaces));
            fctb.EndUpdate();
        }
    }
}
