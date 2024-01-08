using System;

namespace madLibs {
    class Program { 
    public static void Main(string[] args){
            

            Console.WriteLine("Mad Libs console game");
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to Mad Libs console game!");

            // 2. Ask the player to enter a verb
            Console.Write("Please Enter a verb: ");
            String verb = Console.ReadLine();

            // 3. Ask the player to enter a verb ending in 'ing'
            Console.Write("Please Enter a verb ending in 'ing': ");
            String verbIng = Console.ReadLine();

            // 4. Ask the player to enter a noun
            Console.Write("Please Enter a noun: ");
            String noun = Console.ReadLine();

            // 5. Ask the player to enter an adjective
            Console.Write("Please Enter an adjective: ");
            String adjective = Console.ReadLine();

            // 6. Ask the player to enter an occupation
            Console.Write("Please Enter an occupation: ");
            String occupation = Console.ReadLine();

            // 7. Ask the player to enter an animal
            Console.Write("Please Enter an animal: ");
            String animal = Console.ReadLine();

            // 8. Ask the player to enter an adjective
            Console.Write("Please Enter an adjective: ");
            String adjective2 = Console.ReadLine();

            // 9. Ask the player to enter a verb ending in 'ing'
            Console.Write("Please Enter a verb ending in 'ing': ");
            String verbIng2 = Console.ReadLine();

            // 10. Ask the player to enter a noun
            Console.Write("Please Enter a noun: ");
            String noun2 = Console.ReadLine();

            //11. Ask the player to enter a noun
            Console.Write("Please Enter a noun: ");
            String noun3 = Console.ReadLine();

            // The quotes below have been written as a group of Strings joined together by + signs.
            // The story contains placeholders, indicated by [** **] which you need to replace with
            // the values entered by the player.
            // Note the \n characters represent newlines that move the following text onto the next line
            String story = "\n Hello world! Welcome to " + verb + "'s wacky and wild " + verbIng + " emporium! Here you'll find \n" +
                "everything you never knew you wanted, like this crazy rare " + adjective + noun + ", or even \n" +
                "this " + animal + " shaped " + noun2 + "! \n" +
                "But don't just take my word for it, our reviews speak for themselves!  \n\n"
                + noun3 + ", " + occupation + "- \n" +
                "'Yup. Their wacky and wild things really make my day " + adjective2 + ".' \n\n" +
                "You heard it here folks! Don't stand around " + verbIng2 + "! Come on down to \n"
                + verb + "'s wacky and wild " + verbIng + " emporium and find your deal today!";

            // 11. Print the quotes to the console to display the Mad Lib!
            Console.WriteLine(story);
    }
}
}