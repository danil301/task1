using task1;

Calc_Square calc_Square = new Calc_Square();

Console.WriteLine(calc_Square.Circle(1));  //вывод площади круга
Console.WriteLine(calc_Square.Triangle(2, 2, 1)); //вывод площади треугольника
Console.WriteLine(calc_Square.Sqare_CompileTime(new float[] { 1 })); //определит фигуру и выдаст её площадь
Console.WriteLine(calc_Square.Sqare_CompileTime(new float[] { 3, 4, 5 }));

