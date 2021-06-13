using
System;
using
System.Drawing
using
System.Windows.Forms
namespace
Ex10_09_KeyEventApp
{
public
partial class Form1 : Form
{
public
Form1
{
InitializeComponent
}
public
int xPt , yPt
public
static readonly int MOVE = 10;
private
void button1_KeyUp( object sender, KeyEventArgs e)
{
this
.xPt = this .button1.Location.
this
.yPt = this .button1.Location.
switch
e.KeyCode
{
case
Keys.Left
xPt
--= MOVE; break
case
Keys.Right
xPt
+= MOVE; break
case
Keys.Up
yPt
--= MOVE; break
case
Keys.Down
yPt
+= MOVE; break
}
this
.button1.Text = e.KeyCode.ToString
this
.button1.Location = new Point( xPt , yPt
}
}
}