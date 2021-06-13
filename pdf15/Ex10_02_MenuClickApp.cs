using
System;
using
System.Windows.Forms
namespace
Ex10_02_MenuClickApp
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
void button1_Click( object sender, EventArgs e)
{
listBox1.Items.Clear();
}
private
void button2_Click( object sender, EventArgs e)
{
Application.Exit
}
private
void 새파일 ToolStripMenuItem_Click object sender, EventArgs e)
{
listBox1.Items.Add(((
ToolStripMenuItem )sender).
}
private
void 열기 ToolStripMenuItem_Click object sender, EventArgs e)
{
listBox1.Items.Add(((
ToolStripMenuItem )sender).
}
. . .
private
void 붙여넣기 ToolStripMenuItem_Click object sender, EventArgs e)
{
listBox1.Items.Add(((
ToolStripMenuItem )sender).
}
private
void 정보 ToolStripMenuItem_Click object sender, EventArgs e)
{
listBox1.Items.Add(((
ToolStripMenuItem )sender).
}
}
}