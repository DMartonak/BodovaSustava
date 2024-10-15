namespace bodovysystem
{
    public struct Bod
    {
        // Constructor should match the struct name
        public Bod(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Properties for X and Y
        public double X { get; }
        public double Y { get; }

        public double vzdialenostBodov(Bod a, Bod b)
        {
            double vzdialenostX = Math.Abs(a.X - b.X);
            double vzdialenostY = Math.Abs(a.Y - b.Y);
            double x = Math.Sqrt((vzdialenostX*vzdialenostX)+(vzdialenostY*vzdialenostY));
            return x; 
        }
    }
    public struct Obdlznik
    {
        public Bod Bod1 { get; }
        public Bod Bod2 { get; }
        public Bod Bod3 { get; }
        public Bod Bod4 { get; }

        // Constructor with four Bod points
        public Obdlznik(Bod bod1, Bod bod2, Bod bod3, Bod bod4)
        {
            Bod1 = bod1;
            Bod2 = bod2;
            Bod3 = bod3;
            Bod4 = bod4;
        }

        public double obvodObdlznika(Obdlznik o) {
            double vzdialenostAB = Bod1.vzdialenostBodov(Bod1, Bod2);
            double vzdialenostBC = Bod1.vzdialenostBodov(Bod2, Bod3);
            return (vzdialenostAB+vzdialenostBC)*2;
        }

        public double plochaObdlznika(Obdlznik o) {
            double a = Bod1.vzdialenostBodov(Bod1, Bod2);
            double b = Bod1.vzdialenostBodov(Bod2, Bod3);
            return a*b;
        }

        public bool jeStvorec(Obdlznik o) {
            double vzdialenostAB = Bod1.vzdialenostBodov(Bod1, Bod2);
            double vzdialenostAD = Bod1.vzdialenostBodov(Bod1, Bod4);
            if (vzdialenostAB == vzdialenostAD) {
                return true;
            }
            return false;
        }

        public bool bodLeziVObdlzniku(Obdlznik o, Bod p) {
            if (o.Bod1.X <= p.X && o.Bod3.X >= p.X) {
                if (o.Bod1.Y <= p.Y && o.Bod3.Y >= p.Y) {
                    return true;
                }
            }
            return false;
        }

        Obdlznik zmenVelkostObdlznika(Obdlznik o, int x) {
            o.Bod2.X += x;
            o.Bod3.X += x;

            o.Bod3.Y += x;
            o.Bod4.Y += x;
        }

    }
}
