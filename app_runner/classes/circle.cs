using I_O = System.Console;
using math = System.Math;

class Point{
    public double x{
        get; set;
    }
    public double y{
        get; set;
    }
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString(){
        return "(" + this.x + "," + this.y + ")";
    }
    public bool are_same(Point p){
        return this.x == p.x && this.y == p.y;
    }
}
class Cricle{
    public Point center{
        get; set;
    }
    public double radios{
        get; set;
    }
    
    public Cricle(double radios, Point center)
    {
        this.center = center;
        this.radios = radios;
    }
    public override string ToString(){
        return "Center: " + this.center + ",radios: " + this.radios + ".";
    }
    
    public double area(){
        return math.PI*math.Pow(this.radios,2);
    }
    
    public double parameter(){
        return math.PI*this.radios*2;
    }
    public bool are_same(Cricle c){
        return this.radios == c.radios && this.center.are_same(c.center);
    }
    public void move(double dx,double dy){
        this.center.x += dx;
        this.center.y += dy;
    }
    public void scale_cricle(double k){
        this.radios *= k;
    }
    
}
class circle_prasnter {
  public static void presenter() {
    Cricle c = new Cricle(3,new Point(-8,6));
    Cricle c2 = new Cricle(12,new Point(-3,5));
    
    I_O.WriteLine("ii:");
    I_O.WriteLine("first cricle area: {0}",c.area());
    I_O.WriteLine("first cricle parameter: {0}",c.parameter());
    
    I_O.WriteLine("second cricle area: {0}",c2.area());
    I_O.WriteLine("second cricle parameter: {0}",c2.parameter());
    
    I_O.WriteLine("iii:");
    c.move(2,3);
    c.scale_cricle(2);
    I_O.WriteLine("new first cricle: {0}",c);
    
    I_O.WriteLine("iv:");
    c2.move(-3,4);
    c2.scale_cricle(0.5);
    I_O.WriteLine("new second cricle: {0}",c2);

    I_O.WriteLine("v:");
    I_O.WriteLine("those cricles are the same: {0}",c.are_same(c2));
  }
}