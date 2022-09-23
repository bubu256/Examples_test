int a = 1;
int b = 2;
int c = 5;
int d = 7;
int e = 3;

int max = a;

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.WriteLine(max);