using System;

namespace randomCurseWordGenerator {
    class Program { 
    public static void Main(string[] args)
        {
            String one = "Aloof,Arrogant,Belligerent,Big-headed,Boastful,Bossy,Callous,Careless,Clingy,Confrontational,Cowardly,Cruel,Cynical,Defensive,Finicky,Foolish,Grumpy,Gullible,Hostile,Idle,Impolite,Inconsiderate,Indecisive,Irresponsible,Moody,Nasty,Overcritical,Overemotional,Patronizing,Pessimistic,Pompous,Self-centered,Silly,Sullen,Thoughtless,Touchy,Untidy,Vain,Weak-willed";

            String[] listOne = one.Split(',');           

            String two = "cabbage,shoe,half-chewed bubblegum,sock,honey,hair,snake,screw,lumber,crack,spider,baby,toothpaste,bottle,fuck,ass,wet bread,marble,ingrown hair,ant,fly,monkey,dog,loser,snail,rusty nail, rag;";

            String[] listTwo = two.Split(',');

            Random rnd = new Random();

            int num1 = rnd.Next(0, listOne.Length);
            int num2 = rnd.Next(0, listTwo.Length);

            Console.WriteLine("You are a " + listOne[num1] + " " + listTwo[num2] + ".");


        } 
    }
}