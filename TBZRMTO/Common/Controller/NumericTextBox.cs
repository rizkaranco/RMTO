
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    //class NumericTextBox : TextBox
    //{
    //    public NumericTextBox()
    //    {
    //        TextChanged += textBox1_TextChanged;
    //    }
    //    public bool AllowNegative { get; set; }
    //    public int DigitsInGroup { get; set; }
    //    public int Flags { get; set; }
    //    public int MaxDecimalPlaces { get; set; }
    //    public int MaxWholeDigits { get; set; }
    //    public string Prefix { get; set; }
    //    //public double RangeMax { get; set; }
    //    //public double RangeMin { get; set; }
    //    public string NumericText { get { return Text; } set { Text = value; } }
    //    private void textBox1_TextChanged(object sender, EventArgs e)
    //    {
    //        Text = GetNumber(decPattern, Text);
    //        SelectionStart = Text.Length;
    //    }
    //    private string decPattern = @"(?<Number>^[0-9]*\.?[0-9]*)";
    //    //intPattern = "(?<Number>[0-9])",

    //    // currPattern = @"^\$?(?<Number>[0-9]*\.?[0-9]{0,2})";
    //    private string GetNumber(string RegexPattern, string SourceString, bool PosOnly = false)
    //    {
    //        string newNumber = string.Empty;
    //        if (!PosOnly)
    //            if (SourceString.StartsWith("-"))
    //                newNumber += "-";
    //        SourceString = SourceString.Replace("-", string.Empty);
    //        Regex r = new Regex(RegexPattern);
    //        Match m = r.Match(SourceString);
    //        while (m.Success)
    //        {
    //            newNumber += m.Groups["Number"].Value;
    //            m = m.NextMatch();
    //        }
    //        return newNumber;
    //    }
    //}
}
