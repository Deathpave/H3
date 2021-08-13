using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;

namespace Vittighedsmaskinen.DontLook
{
    public static class Jokes
    {
        //public static Joke Dad1 = new Joke(Category.DadJokes, "Hvorfor skulle skyen i skole?\n– Fordi den skulle lære at regne", Language.Dansk);
        //public static Joke Dad2 = new Joke(Category.DadJokes, "Hvor meget vejer du?\n– 85 kilo med briller\n– Hvad vejer du så uden ?\n– Det ved jeg ikke\n– Det kan jeg ikke se", Language.Dansk);
        // public static Joke Dad3 = new Joke(Category.DadJokes, "Hvad er det mindst talte sprog i verden?\n– Tegnsprog", Language.Dansk);
        //  public static Joke Dad4 = new Joke(Category.DadJokes, "Hvad fik den lille kannibaldreng, som kom for sent til aftensmaden\n– En kold skulder", Language.Dansk);
        // public static Joke Dad5 = new Joke(Category.DadJokes, "Hvad kalder man en fuld frø?\n– en sprit tusse", Language.Dansk);


        //public static Joke Knock1 = new Joke(Category.KnockKnockJokes, "Banke banke på\nHvem der ?\\-Finn\nFinn hvem ?\n-Find selv af det.", Language.Dansk);
        //  public static Joke Knock2 = new Joke(Category.KnockKnockJokes, "Banke banke på Tinder\nHvem der ?\n-Kanye\nKanye hvem ?\n-Kanye komme op i dig", Language.Dansk);
        //  public static Joke Knock3 = new Joke(Category.KnockKnockJokes, "Banke Banke på Allah\nHvem der ?\n-Allah\nAllah hvem ?\n-Allah I wanna say is they don't really care about us", Language.Dansk);
        //  public static Joke Knock4 = new Joke(Category.KnockKnockJokes, "Banke-banke-på Hitler\nHvem der ?\n-Hitler\nHitler hvem ?\n-Hitler road Jack and don't you come back no more, no more, no more, no more", Language.Dansk);
        // public static Joke Knock5 = new Joke(Category.KnockKnockJokes, "Banke banke på Ivan\nHvem der ?\n-Ivan\nIvan hvem ?\n-I vanvittige torskehoveder.", Language.Dansk);


        // public static Joke BadJoke1 = new Joke(Category.BadJokes, "Hvad kalder man røvhullet på et egern?\n– En nødudgang", Language.Dansk);
        // public static Joke BadJoke2 = new Joke(Category.BadJokes, "Hvordan får man en fisk til at grine?\n– Man putter den i kildevand", Language.Dansk);
        // public static Joke BadJoke3 = new Joke(Category.BadJokes, "Alle børnene løb over marken\n– Undtagen Bo, han blev voldtaget af en ko", Language.Dansk);
        //    public static Joke BadJoke4 = new Joke(Category.BadJokes, "Jesper: Jeg fandt en falsk 100 kr seddel idag\nMaria: Hvordan kunne du se den var falsk ?\nJesper : Der var 3 nuller i stedet for 2 så jeg skyndte mig at rive den over!", Language.Dansk);
        // public static Joke BadJoke5 = new Joke(Category.BadJokes, "", Language.Dansk);

        public static List<Joke> GetDaJokes()
        {
            List<Joke> jokes = new List<Joke>()
            {
                new Joke(){Category = Category.DadJokes, Text="Hvorfor skulle skyen i skole?\n– Fordi den skulle lære at regne" , Language= Language.Dansk},
                new Joke(){Category= Category.DadJokes, Text="Hvor meget vejer du?\n– 85 kilo med briller\n– Hvad vejer du så uden ?\n– Det ved jeg ikke\n– Det kan jeg ikke se" , Language= Language.Dansk},
                new Joke(){Category=Category.DadJokes , Text="Hvad er det mindst talte sprog i verden?\n– Tegnsprog" , Language=Language.Dansk},
                new Joke(){Category=Category.DadJokes , Text="Hvad fik den lille kannibaldreng, som kom for sent til aftensmaden\n– En kold skulder" , Language= Language.Dansk},
                new Joke(){Category=Category.DadJokes , Text="Hvad kalder man en fuld frø?\n– en sprit tusse" , Language=Language.Dansk},

                new Joke(){Category=Category.KnockKnockJokes , Text="Banke banke på\nHvem der ?\\-Finn\nFinn hvem ?\n-Find selv af det." , Language=Language.Dansk},
                new Joke(){Category=Category.KnockKnockJokes , Text="Banke banke på Tinder\nHvem der ?\n-Kanye\nKanye hvem ?\n-Kanye komme op i dig" , Language=Language.Dansk},
                new Joke(){Category=Category.KnockKnockJokes , Text="Banke Banke på Allah\nHvem der ?\n-Allah\nAllah hvem ?\n-Allah I wanna say is they don't really care about us" , Language=Language.Dansk},
                new Joke(){Category= Category.KnockKnockJokes, Text= "Banke-banke-på Hitler\nHvem der ?\n-Hitler\nHitler hvem ?\n-Hitler road Jack and don't you come back no more, no more, no more, no more", Language= Language.Dansk},
                new Joke(){Category= Category.KnockKnockJokes, Text= "Banke banke på Ivan\nHvem der ?\n-Ivan\nIvan hvem ?\n-I vanvittige torskehoveder.", Language= Language.Dansk},

                new Joke(){Category= Category.BadJokes, Text= "Hvad kalder man røvhullet på et egern?\n– En nødudgang", Language= Language.Dansk},
                new Joke(){Category= Category.BadJokes, Text= "Hvordan får man en fisk til at grine?\n– Man putter den i kildevand", Language= Language.Dansk},
                new Joke(){Category= Category.BadJokes, Text= "Alle børnene løb over marken\n– Undtagen Bo, han blev voldtaget af en ko", Language= Language.Dansk},
                new Joke(){Category= Category.BadJokes, Text= "Jesper: Jeg fandt en falsk 100 kr seddel idag\nMaria: Hvordan kunne du se den var falsk ?\nJesper : Der var 3 nuller i stedet for 2 så jeg skyndte mig at rive den over!", Language= Language.Dansk},

        };
            return jokes;
        }

        public static List<Joke> GetEnJokes()
        {
            List<Joke> jokes = new List<Joke>()
            {
                new Joke(){Category= Category.DadJokes , Language = Language.English, Text = "I'm afraid for the calendar. Its days are numbered."},
                new Joke(){Category= Category.DadJokes, Language = Language.English, Text = "How do you follow Will Smith in the snow? "+ "You follow the fresh prints."},
                new Joke(){Category= Category.DadJokes, Language = Language.English, Text = "Have you heard about the chocolate record player? It sounds pretty sweet."},
                new Joke(){Category= Category.DadJokes, Language = Language.English, Text = "What did Baby Corn say to Mama Corn? "+ "Where's Pop Corn?"},
                new Joke(){Category= Category.DadJokes, Language = Language.English, Text = "I don't trust stairs. They're always up to something."},

                new Joke(){Category= Category.KnockKnockJokes, Language = Language.English, Text = "Knock, Knock\nWho’s there?\nNobel.\nNobel who?\nNobel…that’s why I knocked!"},
                new Joke(){Category= Category.KnockKnockJokes, Language = Language.English, Text = "Knock, knock.\nWho’s there?\nTank.\nTank who?\nYou’re welcome."},
                new Joke(){Category= Category.KnockKnockJokes, Language = Language.English, Text = "Knock, knock.\nWho’s there?\nHoney bee.\nHoney bee who?\nHoney bee a dear and get that for me please!"},
                new Joke(){Category= Category.KnockKnockJokes, Language = Language.English, Text = "Knock, knock.\nWho’s there?\nHawaii.\nHawaii who?\nI’m good. Hawaii you?"},
                new Joke(){Category= Category.KnockKnockJokes, Language = Language.English, Text = "Knock, knock.\nWho’s there?\nLeaf.\nLeaf who?\nLeaf me alone!"}
            };
            return jokes;
        }

        public static List<Joke> GetDirtyJokes()
        {
            List<Joke> jokes = new List<Joke>()
            {
                new Joke(){Category= Category.DirtyJokes , Language = Language.English, Text = @"""Give it to me! Give it to me!"" she yelled. ""I''m so wet, give it to me now!"" She could scream all she wanted, but I was keeping the umbrella."},
                new Joke(){Category= Category.DirtyJokes , Language = Language.English, Text = "My neighbor has been mad at his wife for sunbathing nude. I personally am on the fence."},
                new Joke(){Category= Category.DirtyJokes , Language = Language.English, Text = "What comes after 69? Mouthwash."},
                new Joke(){Category= Category.DirtyJokes , Language = Language.English, Text = "What's the difference between your penis and a bonus check? Someone's always willing to blow your bonus."},
                new Joke(){Category= Category.DirtyJokes , Language = Language.English, Text = @"A family's driving behind a garbage truck when a dildo flies out and thumps against the windshield. Embarrassed, and trying to spare her young son's innocence, the mother turns around and says, ""Don't worry, dear. That was just an insect."" ""Wow,"" the boy replies. ""I'm surprised it could get off the ground with a cock like that!"""}
            };
            return jokes;
        }
    }
}