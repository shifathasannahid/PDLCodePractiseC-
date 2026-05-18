//Boxing 
//Primitive type (int, bool, double) → object এ Convert
using System.Collections;

int num = 12; //int(stack e thake)
object obj = num;//Boxing --> int ke object e vorlam(Heap e gelo)
Console.WriteLine("Boxing: "+obj);

//Unboxing
//object → Abar ager type e firiye ana
object obj1 = 45;
int num1 = (int)obj1;
Console.WriteLine("Unboxing: "+num1);

//Boxing and Unboxing with ArrayList
ArrayList arrayList = new ArrayList();

//Boxing(int --> Obj)
arrayList.Add(10);
arrayList.Add(20.23);
arrayList.Add(true);

//Unboxing(obj --> int)

int x = (int)arrayList[0];
double d = (double)arrayList[1];
bool b = (bool)arrayList[2];

Console.WriteLine("1st Element: " + x);
Console.WriteLine("2nd Element: "+ d);
Console.WriteLine("3rd Element: " + b);
