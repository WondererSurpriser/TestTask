using AreaSolution;

double area1 = Area.AreaResult(12);
Console.WriteLine($"{area1} square centimeters");
double[] sides = {8,6,9};
double area2 = Area.AreaResult(sides);
if (area2 == 0)
 {
    throw new Exception("triangle is not exist"); //Also we can handle it by cw
 }
else 
    Console.WriteLine($"{area2} square centimeters");
bool checkTriangle = Area.IsTriangleRight(sides);
if (checkTriangle)
    Console.WriteLine("Triangle is right");


//Also I want to write SQL requsest from another task right here:
//
// SELECT Products.ProdName , Categories.CatName FROM Products
//LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
//LEFT JOIN Categories ON Categories.Id = ProductCategories.CategoryId;