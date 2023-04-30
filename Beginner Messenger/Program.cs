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
                console.writeline("please make a choice ");
                console.writeline("a. save a message ");
                console.writeline("b. retrieve a message ");
                console.writeline("c. delete a message");
                console.writeline("d. exit ");
                string reply = console.readline().tolower();

                if (reply == "a")
                {
                    if (index >= messages.length)
                    {
                        console.writeline("your messages are full");
                    }
                    else if (index < messages.length)
                    {
                        console.writeline("please leave a message ");
                        messages[index] = console.readline();
                        console.writeline("your message number is: " + index);
                        index = index + 1;
                    }
                }
                else if (reply == "b")

                {
                    console.writeline("please give a message number ");
                    int id = convert.toint32(console.readline());
                    if (id > index)
                    {
                        console.writeline("your message doesn't exists");
                    }
                    else
                    {
                        console.writeline(messages[id]);
                    }
                }

                else if (reply == "c")
                {
                    console.writeline("what is the number of the message you would like to delete?");
                    int id = convert.toint32(console.readline());
                    messages[id] = "this message doesn't exist";
                    console.writeline("your message has been deleted");
                }

                else if (reply == "d")
                {
                    on = 0;
                }

            }
        }
    }
}
