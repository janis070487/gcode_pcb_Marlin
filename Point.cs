using System;

public class Point
{
	private double x;
	private double y;

	public double X
		{
	      get {  return x; }
		set {  x = value; }
		}
	public double Y
    {
		get {  return y; }
		set {  y = value; }
    }
	public Point()
	{
		x= 0;
		y= 0;
	}
	public int salidzinat(Point p)
    {
		return 1;
    }
}
