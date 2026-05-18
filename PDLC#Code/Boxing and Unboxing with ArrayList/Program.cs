//Boxing 
//Primitive type (int, bool, double) → object এ Convert
int num = 12; //int(stack e thake)
object obj = num;//Boxing --> int ke object e vorlam(Heap e gelo)
Console.WriteLine("Boxing: "+obj);

//Unboxing
//object → Abar ager type e firiye ana
object obj1 = 45;
int num1 = (int)obj1;
Console.WriteLine("Unboxing: "+num1);
