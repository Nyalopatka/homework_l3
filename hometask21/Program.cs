double DistanceAB(int x1,int y1, int z1,int x2,int y2,int z2)
{
    int deltaX = x1 - x2;
    int deltaY = y1 - y2;
    int deltaZ = z1 - z2;
    double distAB =  Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}
Console.Write("введите 'x' координату точки 'A': ");
int x1Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 'y' координату точки 'A': ");
int y1Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 'z' координату точки 'A': ");
int z1Coord = Convert.ToInt32(Console.ReadLine());

Console.Write("введите 'x' координату точки 'B': ");
int x2Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 'y' координату точки 'B': ");
int y2Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 'z' координату точки 'B': ");
int z2Coord = Convert.ToInt32(Console.ReadLine());


double distanceAB = DistanceAB(x1Coord,y1Coord,z1Coord,x2Coord,y2Coord,z2Coord);
Console.WriteLine($"дистанция между точками 'A' и 'B' {distanceAB} ");


