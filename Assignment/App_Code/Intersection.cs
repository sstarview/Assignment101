using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Intersection
/// </summary>
public class Intersection 
{
  public bool IsIntersecting(MyRectangle rec1, MyRectangle rec2)
  {
    if (rec1.XValue + rec1.WidthValue > rec2.XValue || rec2.XValue + rec2.WidthValue > rec1.XValue ||
        rec1.YValue + rec1.HeightValue > rec2.YValue || rec2.YValue + rec2.HeightValue > rec1.YValue)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}