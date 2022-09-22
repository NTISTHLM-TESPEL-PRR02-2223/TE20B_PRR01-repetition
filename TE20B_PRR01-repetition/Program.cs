// x variabler, datatyper
// x Input, output
// x if-satser
// x loopar
// x listor/arrayer
// x metoder med parametrar & returnering

static string AskYesNo(string question)
{
  Console.WriteLine(question);

  string answer = Console.ReadLine();
  
  return answer;
}


string a = AskYesNo("Are you sure?");




// string d = "Daytime";

// static void SayHello(int antal)
// {
//   while (antal > 0)
//   {
//     Console.WriteLine("HELLO");
//     antal--;
//   }

//   // SayHello();
// }

// int t = 74;

// SayHello(t);
// Console.WriteLine(s);

Console.ReadLine();



Console.WriteLine("Micke är bäst");

string name = Console.ReadLine();

Random generator = new();

int hp = generator.Next(100);




List<string> names = new() { "Micke", "Martin", "Lena" };

List<int> enemyHp = new() { 200, 200, 200 };

CheckEnemyLife(enemyHp);

Console.ReadLine();



int hitpoints = 10;

// bool isAlive = hitpoints > 0;

while (hitpoints > 0)
{
  Console.WriteLine("Alive!");

  hitpoints--;
}







Console.WriteLine("Hej");

// hitpoints = 15;

// Console.WriteLine(int.MaxValue);
// Console.WriteLine(short.MaxValue);
// Console.WriteLine(long.MaxValue);

// int, string, List, bool, arrayer


Console.ReadLine();

static void CheckEnemyLife(List<int> hpList)
{
  for (int i = 0; i < hpList.Count; i++)
  {
    if (hpList[i] > 0)
    {
      Console.WriteLine($"Fiende nummer {i} lever");
    }
  }
}