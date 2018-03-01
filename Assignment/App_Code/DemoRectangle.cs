using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Demo Class for testing purpose
/// </summary>
public class DemoRectangle
{
  private Point P;
  private int Width;
  private int Length;

  public DemoRectangle(int x, int y, int width, int length)
  {
    this.P = new Point(x, y);
    this.Width = width;
    this.Length = length;
  }

  public void DrawRectangle(Graphics myGraphics, Pen myPen)
  {

    Point p1 = this.P;
    Point p2 = new Point(p1.X + this.Width, p1.Y);
    Point p3 = new Point(p1.X + this.Width, p1.Y + this.Length);
    Point p4 = new Point(p1.X, p1.Y + this.Length);

    myGraphics.DrawLine(myPen, p1, p2);
    myGraphics.DrawLine(myPen, p2, p3);
    myGraphics.DrawLine(myPen, p3, p4);
    myGraphics.DrawLine(myPen, p4, p1);
  }
}