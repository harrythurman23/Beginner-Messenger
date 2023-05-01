using System;

namespace Beginner_Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
          //please make a choice: a.enter message b.retrieve message c.quit
          //"your message id is"

          string[] messages = new string[100];
            int index = 0;
            int on = 1;
            while (on == 1)
            {
                Console.WriteLine("please make a choice ");
                Console.WriteLine("a. save a message ");
                Console.WriteLine("b. retrieve a message ");
                Console.WriteLine("c. delete a message");
                Console.WriteLine("d. exit ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "a")
                {
                    if (index >= messages.Length)
                    {
                        Console.WriteLine("your messages are full");
                    }
                    else if (index < messages.Length)
                    {
                        Console.WriteLine("please leave a message ");
                        messages[index] = Console.ReadLine();
                        Console.WriteLine("your message number is: " + index);
                        index = index + 1;
                    }
                }
                else if (reply == "b")

                {
                    Console.WriteLine("please give a message number ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id > index)
                    {
                        Console.WriteLine("your message doesn't exists");
                    }
                    else
                    {
                        Console.WriteLine(messages[id]);
                    }
                }

                else if (reply == "c")
                {
                    Console.WriteLine("what is the number of the message you would like to delete?");
                    int id = Convert.ToInt32(Console.ReadLine());
                    messages[id] = "this message doesn't exist";
                    Console.WriteLine("your message has been deleted");
                }

                else if (reply == "d")
                {
                    on = 0;
                }

            }
        }
    }
}
