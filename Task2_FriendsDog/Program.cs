internal class Program
{
    private static void Main(string[] args)
    {
        double count = 0;
        double distance = 10000;
        double firstFriendSpeed = 1;
        double secondFriendSpeed = 2;
        double dogSpeed = 5;
        double friend = 2;
        double time = 0;

        while (distance > 10)
        {
            if (friend == 1)
            {
                time = distance / (firstFriendSpeed + dogSpeed);
                friend = 2;
                //distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
                count = count + 1;

            }
            Console.WriteLine($"From second friend {count}");

            if (friend == 2)

            {
                time = distance / (secondFriendSpeed + dogSpeed);
                friend = 1;
                //distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
                count = count + 1;
                //Console.WriteLine(count);
            }
            Console.WriteLine($"From first friend {count}");
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;   
        }
        Console.WriteLine(count);
    }
}