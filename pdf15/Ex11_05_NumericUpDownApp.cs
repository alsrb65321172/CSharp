using
System;
using
System.Windows.Forms
namespace
Ex11_05_NumericUpDownApp
{
public
partial class Form1 : Form
{
public
Form1
{
InitializeComponent
}
private
void numericUpDown1_ValueChanged( object sender, EventArgs e)
{
decimal
d = numericUpDown1.Value;
label1.Text =
"Log "+ d + " =
textBox1.Text = System.Math.Log10((
double ) ToString
label2.Text = d +
"*""*"+d + " =
textBox2.Text =
System.Math.Pow double )d, ToString
label3.Text =
"√""√"+ d + " =
textBox3.Text =
System.Math.Sqrt double ) ToString
}
}
}