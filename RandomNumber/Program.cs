Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

int myRandomNum = rnd.Next(0, 11); 
Console.WriteLine($"My random number is: {myRandomNum}");

for(int i = 0;i < 3; i++)
{
    int myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum  + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"randomSum total: {randomSum}");


