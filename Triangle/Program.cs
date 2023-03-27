// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

double SideLength(int x1, int y1, int x2, int y2)
{
    double l = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
    return l;
}    
Console.Clear();
int x1=0, y1=0;
int x2=0, y2=3;
int x3=3, y3=0;

double p = (SideLength(x1,y1,x2,y2)+SideLength(x1,y1,x3,y3)+SideLength(x2,y2,x3,y3))/2;
double s = Math.Sqrt(p*(p - SideLength(x1,y1,x2,y2))*(p - SideLength(x1,y1,x3,y3))*(p - SideLength(x2,y2,x3,y3)));
Console.WriteLine($"Площадь треугольника равна {Math.Round(s, 2)}");

// Так и не понял зачем тут функции. Помоему проще было бы вот так:
// double l1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
// double l2 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y3 - y1, 2));
// double l3 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y3 - y2, 2));
// double p = (l1+l2+l3)/2;
// double s = Math.Sqrt(p*(p-l1)*(p-l2)*(p-l3));