// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for(int i = 0; i < 10; i++){
    Console.WriteLine("i = " + i);
}

int x = 2;
string name = "Tom";
double pi = 3.1415;
bool yesno = false;

if(x == 2) Console.WriteLine("x = " + x.ToString());
Console.WriteLine(name.ToLower());
Console.WriteLine("pi = " + pi.ToString("N2"));
if(yesno) Console.WriteLine("true");
else Console.WriteLine("false");
