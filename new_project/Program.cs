bool z = false;
if(z==true){
    //this doesnt work im stupid????? jesper is clever
/*
    float r1 = 1;
    float r2 = 3;
    float r3 = 5;
    float area1 = 2 * (float) 3.14 * r1;
    float area2 = 2 * (float) 3.14 * r2;
    float area3 = 2 * (float) 3.14 * r3;
    
    Console.WriteLine("The area of a circle with radius 1, is: "+area1);
    Console.WriteLine("The area of a circle with radius 3, is: "+area2);
    Console.WriteLine("The area of a circle with radius 5, is: "+area3);
*/
    Console.WriteLine("Hello, World!");
    
    int side = 2;
    
    int area = side * side;
    
    int triple_area = 3 * area;
    
    Console.WriteLine("side = " + side);
    
    Console.WriteLine("area = " + area);
    
    Console.WriteLine("triple the area = " + triple_area);

    double d = 2.40;
    
    int i = (int) ((double) d + 0.5);
    
    Console.WriteLine(i);    
    
    int counter = 5;
    
    counter = counter + 1;
    
    counter++;
    
    counter--;
    
    Console.WriteLine(counter);
    Console.WriteLine(++counter);
    Console.WriteLine(counter++);
    
    short a = 32767;
    
    a += 1;
    
    Console.WriteLine(a);
    
    int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
    int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
    int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
    int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
    int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
    int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
    float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
    float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
    float avg = (male_avg + female_avg) / 2;
    float diff = male_avg - female_avg;
    Console.WriteLine("Average lifespan of a male computer scientist: " + male_avg);
    Console.Write("Average lifespan of a female computer scientist: ");
    Console.WriteLine(female_avg);
    Console.Write("Average lifespan of a computer scientist: ");
    Console.WriteLine(avg);
    Console.Write("Males live this much longer than females: ");
    Console.WriteLine(diff);
    
    float T_c = 20;
    float T_f = 32 + (float)5/9*T_c;
    
    Console.WriteLine("Temperature of 20 degrees celsius converted to fahrenheit, is: "+T_f);
}
//}else{
/*int i2 = 42;
long l = 56;
float f = 3.14159F;
double d2 = 3.14159 * 10;
Console.WriteLine("\nl = {1,40} \nf = {2} \nd = {3,10:0.000000}", i2, l, f, d2);//}
*/
/*
float r1 = 1;
float r2 = 3;
float r3 = 5;
float area1 = 2 * (float) 3.14 * r1;
float area2 = 2 * (float) 3.14 * r2;
float area3 = 2 * (float) 3.14 * r3;

//Console.WriteLine("The area of a circle with radius 1, is: "+area1);
//Console.WriteLine("The area of a circle with radius 3, is: "+area2);
//Console.WriteLine("The area of a circle with radius 5, is: "+area3);
Console.WriteLine("\nA1 = {0:0.000} \nA2 = {1:0.000} \nA3 = {2:0.000}", area1, area2, area3);
*/

/*
int input = 38;
Console.WriteLine("Input is "+input);
if (input%3!=0){
    Console.WriteLine("input is odd. Let me fix that for you ...");
    input += 1;
}
Console.WriteLine("Input is "+input);

/*
int balance =-10002;
if (balance>=0) 
Console.WriteLine("You have "+balance+" in the bank"); 
else Console.WriteLine("You owe the bank "+(-1*balance));
if (balance <= 0)
    Console.WriteLine("Eat the rich!\n");
else Console.WriteLine("Started from the bottom now we here!\n");
*/

/*
int g=1;
int j=2;
int k=3;

if (g < j){
    Console.WriteLine("C");}
    else if (g > k){
        Console.WriteLine("A");
    }
 else {
    Console.WriteLine("B");
}
*/

char direction = 'N';
switch (direction) {
    case 'N':
        Console.WriteLine("Going north ...");
        break;
    case 'S':
        Console.WriteLine("Going south ...");
        break;
    case 'E':
        Console.WriteLine("Going east ...");
        break;
    case 'W':
        Console.WriteLine("Going west ...");
        break;
    default:
        Console.WriteLine("I don't understand ?!?");
        break;
}
