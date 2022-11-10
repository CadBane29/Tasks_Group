Console.Clear();
int ax = 1;
int ay = 1;
int bx = 1;
int by = 2;
int cx = 1;
int cy = 3;
int count = 0;
while (count<10)
{
     Console.SetCursorPosition(ax+count, ay);
     Console.ForegroundColor = ConsoleColor.White;
     Console.WriteLine("+");
     Console.SetCursorPosition(bx+count, by);
     Console.ForegroundColor = 
ConsoleColor.Blue
;
     Console.WriteLine("+");
     Console.SetCursorPosition(cx+count, cy);
     Console.ForegroundColor = 
ConsoleColor.Red
;
     Console.WriteLine("+");
     count++;
} 