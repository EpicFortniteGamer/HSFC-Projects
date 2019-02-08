using System;

namespace HalloweenHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declerring variables
            int weapon_int = -1;
            String weapon;
            String Equip = "";

            //Declering array for monsters
            String[] monsters;
            monsters = new String[4];

            //Lives system
            int life = 1;

            //Asking for the players name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            //Writing out the weapon choices
            Console.WriteLine("Quick! Something is lurking in the shadows " + userName + ". Choose a weapon to defend yourslef with!");

            //Ignoring inputs that aren't integers
            bool check = false;
            while (check == false)
            {
                Console.WriteLine(@"
                1 - The Silver Bullet
                2 - The Wooden Stake
                3 - The Almighty Priest
                0 - You choose not to arm yourself
                                    ");
                weapon = Console.ReadLine();
                if (int.TryParse(weapon, out weapon_int))
                {
                    check = true;
                }
            }

            //Multiple if statements, finding out which weapon the user has chosen
            if (weapon_int == 1)
            {
                Equip = "Silver Bullet";
                Console.WriteLine("You have chosen to load the " + Equip + " into your gun.");
            }

            if (weapon_int == 2)
            {
                Equip = "Wooden Stake";
                Console.WriteLine("You have chosen to use the " + Equip + ".");
            }

            if (weapon_int == 3)
            {
                Equip = "Priest";
                Console.WriteLine("You have chosen the " + Equip + ".");
            }

            if (weapon_int == 0)
            {
                Console.WriteLine("You have decided not to arm yourself.");
            }

            //Creating the monsters for array
            monsters[0] = "Vampire";
            monsters[1] = "Werewolf";
            monsters[2] = "Ghost";

            //Generate a random monster
            Random rnd = new Random();
            int Mon = rnd.Next(0, 2);


            Console.WriteLine("The figure gets closer to you, until you can tell it is a " + monsters[Mon] + ".");

            //If the player chooses no weapon, 
            if (weapon_int == 0)
            {
                Console.WriteLine("You are left defenceless!");
                life = 0;
                string Nothing = Console.ReadLine();
                Console.WriteLine(@"
You are left in the alleyway; alone, with a cold feeling on your chest. 
These are your last few moments in this world. You feel no pain anymore.
It feels good. Your life flashes infront of your eyes. Every single 
moment - joyful or not - you relive again. but within a split second,
it is over. You remember the last words you said to your parents were
'I hate you' and you are hit with an instant feeling of regret.
You want your mum to know how much you love her, but you will never
speak to her again. Instant regret of everything you were ever too
scared to say or do -l ike asking out that girl you really liked
back in high school. Well little do you know she was waiting for
you to do so, but you took too long, and she had moved on' says your
guardian angel. Or when you were planning on proposing to your current
girlfriend and start a family, but wanted to wait, and now you will 
never talk to her again. You won't tell her how much you love her. And
nothing. Silence. You don't feel anything. You are free. There is 
nothing holding onto you, except the eternal feeling of guilt and 
disappointment that you will always carry around you. You are being
lowered into your casket, everyone you have ever loved, and that has
loved you, is crying, all because of a stupid mistake you made at such 
a young age. They miss you. They need you. But you can't go back.
You are dead, and nothing that you have ever done will matter. You are
but a memory in peoples minds, soon to be forgotten. And the universe 
carries on as it did with you. Nothing has changed. The biogger picture
will always stay the same. You were never anything more than just 
a puzzle piece in a bigger frame.");
            }

            //Vampire instance
            else if (Mon == 0)
            {
                if (weapon_int == 2)
                {
                    Console.WriteLine("You overpower the " + monsters[Mon] + " with your " + Equip);
                }
                else
                {
                    Console.WriteLine("You attack the " + monsters[Mon] + " but your " + Equip + " is ineffective!");
                    life = 0;
                    string Nothing = Console.ReadLine();
                    Console.WriteLine(@"
You are left in the alleyway; alone, with a cold feeling on your chest. 
These are your last few moments in this world. You feel no pain anymore.
It feels good. Your life flashes infront of your eyes. Every single 
moment - joyful or not - you relive again. but within a split second,
it is over. You remember the last words you said to your parents were
'I hate you' and you are hit with an instant feeling of regret.
You want your mum to know how much you love her, but you will never
speak to her again. Instant regret of everything you were ever too
scared to say or do -l ike asking out that girl you really liked
back in high school. Well little do you know she was waiting for
you to do so, but you took too long, and she had moved on' says your
guardian angel. Or when you were planning on proposing to your current
girlfriend and start a family, but wanted to wait, and now you will 
never talk to her again. You won't tell her how much you love her. And
nothing. Silence. You don't feel anything. You are free. There is 
nothing holding onto you, except the eternal feeling of guilt and 
disappointment that you will always carry around you. You are being
lowered into your casket, everyone you have ever loved, and that has
loved you, is crying, all because of a stupid mistake you made at such 
a young age. They miss you. They need you. But you can't go back.
You are dead, and nothing that you have ever done will matter. You are
but a memory in peoples minds, soon to be forgotten. And the universe 
carries on as it did with you. Nothing has changed. The biogger picture
will always stay the same. You were never anything more than just 
a puzzle piece in a bigger frame.");
                }
            }

            //Werewolf instance
            else if (Mon == 1)
            {
                if (weapon_int == 1)
                {
                    Console.WriteLine("You overpower the " + monsters[Mon] + " with your " + Equip);
                }
                else
                {
                    Console.WriteLine("You attack the " + monsters[Mon] + " but your " + Equip + " is ineffective!");
                    life = 0;
                    string Nothing = Console.ReadLine();
                    Console.WriteLine(@"
You are left in the alleyway; alone, with a cold feeling on your chest. 
These are your last few moments in this world. You feel no pain anymore.
It feels good. Your life flashes infront of your eyes. Every single 
moment - joyful or not - you relive again. but within a split second,
it is over. You remember the last words you said to your parents were
'I hate you' and you are hit with an instant feeling of regret.
You want your mum to know how much you love her, but you will never
speak to her again. Instant regret of everything you were ever too
scared to say or do -l ike asking out that girl you really liked
back in high school. Well little do you know she was waiting for
you to do so, but you took too long, and she had moved on' says your
guardian angel. Or when you were planning on proposing to your current
girlfriend and start a family, but wanted to wait, and now you will 
never talk to her again. You won't tell her how much you love her. And
nothing. Silence. You don't feel anything. You are free. There is 
nothing holding onto you, except the eternal feeling of guilt and 
disappointment that you will always carry around you. You are being
lowered into your casket, everyone you have ever loved, and that has
loved you, is crying, all because of a stupid mistake you made at such 
a young age. They miss you. They need you. But you can't go back.
You are dead, and nothing that you have ever done will matter. You are
but a memory in peoples minds, soon to be forgotten. And the universe 
carries on as it did with you. Nothing has changed. The biogger picture
will always stay the same. You were never anything more than just 
a puzzle piece in a bigger frame.");
                }


            }
            //Ghost instance
            else if (Mon == 2)
            {
                if (weapon_int == 3)
                {
                    Console.WriteLine("You overpower the " + monsters[Mon] + " with your " + Equip);
                }
                else
                {
                    Console.WriteLine("You attack the " + monsters[Mon] + " but your " + Equip + " is ineffective!");
                    life = 0;
                    Console.WriteLine(@"
You are left in the alleyway; alone, with a cold feeling on your chest. 
These are your last few moments in this world. You feel no pain anymore.
It feels good. Your life flashes infront of your eyes. Every single 
moment - joyful or not - you relive again. but within a split second,
it is over. You remember the last words you said to your parents were
'I hate you' and you are hit with an instant feeling of regret.
You want your mum to know how much you love her, but you will never
speak to her again. Instant regret of everything you were ever too
scared to say or do -l ike asking out that girl you really liked
back in high school. Well little do you know she was waiting for
you to do so, but you took too long, and she had moved on' says your
guardian angel. Or when you were planning on proposing to your current
girlfriend and start a family, but wanted to wait, and now you will 
never talk to her again. You won't tell her how much you love her. And
nothing. Silence. You don't feel anything. You are free. There is 
nothing holding onto you, except the eternal feeling of guilt and 
disappointment that you will always carry around you. You are being
lowered into your casket, everyone you have ever loved, and that has
loved you, is crying, all because of a stupid mistake you made at such 
a young age. They miss you. They need you. But you can't go back.
You are dead, and nothing that you have ever done will matter. You are
but a memory in peoples minds, soon to be forgotten. And the universe 
carries on as it did with you. Nothing has changed. The biogger picture
will always stay the same. You were never anything more than just 
a puzzle piece in a bigger frame.");
                }
            }

            Console.Read();
        }
    }
}