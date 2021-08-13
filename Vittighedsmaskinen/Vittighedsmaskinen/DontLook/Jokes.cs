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

        public static List<Joke> GetAllJokes()
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
    }
}