namespace GeometryLibrary
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }

    public class Triangle
    {
        public double SideA {get; set;}
        public double SideB {get; set;}
        public double SideC {get; set;}
        public double AngleA {get; set;}
        public double AngleB {get; set;}
        public double AngleC {get; set;}
        public bool IsSides {get; set;} = false;
        public bool IsAngles {get; set;} = false;
        public bool IsSAS {get; set;} = false;
        public bool IsSSA {get; set;} = false;
        public bool IsASA {get; set;} = false;

        public Triangle(double angle_a, double angle_b, double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.IsSides = true;
            this.IsAngles = false;
            this.IsSAS = false;
            this.IsSSA = false;
            this.IsASA = false;
        }

        public Triangle(double angleA, double angleB, double angleC, double sideA, bool isSAS = true)
        {
            this.AngleA = angleA;
            this.AngleB = angleB;
            this.AngleC = angleC;
            this.SideA = sideA;
            this.IsSides = false;
            this.IsAngles = false;
            this.IsSAS = isSAS;
            this.IsSSA = false;
            this.IsASA = false;
        }

        public Triangle(double angleA, double angleB, double sideA, double sideB, bool isSAS = false,
            bool isSSA = true)
        {
            this.AngleA = angleA;
            this.AngleB = angleB;
            this.SideA = sideA;
            this.SideB = sideB;
            this.IsSides = false;
            this.IsAngles = false;
            this.IsSAS = isSAS;
            this.IsSSA = isSSA;
            this.IsASA = false;
        }

        public Triangle(double angleA, double sideA, double sideB, double sideC, bool isSAS = false,
            bool isSSA = false, bool isASA = true)
        {
            this.AngleA = angleA;
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.IsSides = false;
            this.IsAngles = false;
            this.IsSAS = isSAS;
            this.IsSSA = isSSA;
            this.IsASA = isASA;
        }

        public double GetArea()
        {
            if (this.IsSides)
            {
                double s = (this.SideA + this.SideB + this.SideC) / 2;
                return Math.Sqrt(s * (s - this.SideA) * (s - this.SideB) * (s - this.SideC));
            }
            else if (this.IsSAS)
            {
                double s = (this.SideA + this.SideB + this.SideC) / 2;
                return Math.Sqrt(s * (s - this.SideA) * (s - this.SideB) * (s - this.SideC));
            }
            else if (this.IsSSA)
            {
                double sin_angleA = Math.Sin(this.AngleA);
                double sin_angleB = Math.Sin(this.AngleB);
                double sin_angleC = Math.Sin(this.AngleC);
                double s = (2 * sin_angleA * sin_angleB * sin_angleC) / (sin_angleA + sin_angleB + sin_angleC);
                return 0.5 * this.SideA * this.SideB * s;
            }
            else if (this.IsASA)
            {
                double sin_angleA = Math.Sin(this.AngleA);
                double s = (0.5 * (this.SideB + this.SideC - this.SideA) * sin_angleA);
                return s;
            }
            else
                throw new ArgumentException("Invalid arguments");
        }
        
        public bool IsRightTriangle()
        {
            if (this.IsSides)
            {
                if (Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2) == Math.Pow(this.SideC, 2))
                    return true;
                else if (Math.Pow(this.SideA, 2) + Math.Pow(this.SideC, 2) == Math.Pow(this.SideB, 2))
                    return true;
                else if (Math.Pow(this.SideB, 2) + Math.Pow(this.SideC, 2) == Math.Pow(this.SideA, 2))
                    return true;
                else
                    return false;
            }
            else if (this.IsSAS)
            {
                if (Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2) == Math.Pow(this.SideC, 2))
                    return true;
                else if (Math.Pow(this.SideA, 2) + Math.Pow(this.SideC, 2) == Math.Pow(this.SideB, 2))
                    return true;
                else if (Math.Pow(this.SideB, 2) + Math.Pow(this.SideC, 2) == Math.Pow(this.SideA, 2))
                    return true;
                else
                    return false;
            }
            else if (this.IsSSA)
            {
                if (this.AngleA == Math.PI/2 | this.AngleB == Math.PI/2 | this.AngleC == Math.PI/2)
                    return true;
                else
                    return false;
            }
            else if (this.IsASA)
            {
                if (this.AngleA == Math.PI/2 | this.AngleB == Math.PI/2 | this.AngleC == Math.PI/2)
                    return true;
                else
                    return false;
            }
            else
                throw new ArgumentException("Invalid arguments");
        }
    }
}
