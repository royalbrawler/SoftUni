using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exam
{
    class Program
    {
        static string r = string.Empty;
        static string w = string.Empty;

        static void Main(string[] args)
        {

            //foreach (var item in fortunes)
            //{
            //    File.AppendAllText("output.txt", item + Environment.NewLine);
            //}
            var authorlist = new List<string>();
            var filteredAuthorList = authorlist.Distinct();
            var quotelist = new List<string>();
            var filteredquoteList = quotelist.Distinct().Where(q => q.Length > 50);

            for (int i = 1; i < 1207; i++)
            {
                GetQuote(i);
                if (w == "")
                    quotelist.Add(r);

                //if (!r.Equals(""))
                //{

                //    //File.AppendAllText("output.txt", $"quotes.add(new Quotes(\"{r}\", \"{w}\"));" + Environment.NewLine);
                //    //File.AppendAllText("output.txt", $"{r} === {w}" + Environment.NewLine);
                //}
            }
            int counter = 0;
            string google = "http://google.com/search?q=";
            foreach (var item in filteredquoteList)
            {
                Console.WriteLine(filteredquoteList.Count());
                counter++;
                Console.WriteLine(item);
                Console.WriteLine(counter);
                var asd = Console.ReadLine();
                if (asd == "asd")
                {
                    System.Diagnostics.Process.Start(google + item);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    continue;
                }
                Console.Clear();
            }
            //File.WriteAllLines("authorList.txt", filteredAuthorList);

        }
        public static void GetQuote(int input)
        {
            switch (input)
            {
                case 1:
                    r = "Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment.";
                    w = "Buddha";
                    break;
                case 2:
                    r = "Health is the greatest gift, contentment the greatest wealth, faithfulness the best relationship.";
                    w = "Buddha";
                    break;
                case 3:
                    r = "What goes up must come down.";
                    w = "Isaac Newton";
                    break;
                case 4:
                    r = "The secret of getting ahead is getting started.";
                    w = "Mark Twain";
                    break;
                case 5:
                    r = "It's not the size of the dog in the fight, it's the size of the fight in the dog.";
                    w = "Mark Twain";
                    break;
                case 6:
                    r = "Love all, trust a few, do wrong to none.";
                    w = "William Shakespeare";
                    break;
                case 7:
                    r = "Better three hours too soon than a minute too late.";
                    w = "William Shakespeare";
                    break;
                case 8:
                    r = "Keep love in your heart. A life without it is like a sunless garden when the flowers are dead.";
                    w = "Oscar Wilde";
                    break;
                case 9:
                    r = "I have the simplest tastes. I am always satisfied with the best.";
                    w = "Oscar Wilde";
                    break;
                case 10:
                    r = "True friends stab you in the front.";
                    w = "Oscar Wilde";
                    break;
                case 11:
                    r = "The greatest wealth is to live content with little.";
                    w = "Plato";
                    break;
                case 12:
                    r = "He was a wise man who invented beer.";
                    w = "Plato";
                    break;
                case 13:
                    r = "One great use of words is to hide our thoughts.";
                    w = "Voltaire";
                    break;
                case 14:
                    r = "Illusion is the first of all pleasures.";
                    w = "Voltaire";
                    break;
                case 15:
                    r = "We are rarely proud when we are alone.";
                    w = "Voltaire";
                    break;
                case 16:
                    r = "He who seeks will find.";
                    w = "Sophocles";
                    break;
                case 17:
                    r = "The secret of getting ahead is getting started.";
                    w = "Mark Twain";
                    break;
                case 18:
                    r = "Never quit!";
                    w = "";
                    break;
                case 19:
                    r = "It is hard to fail, but it is worse never to have tried to succeed.";
                    w = "Theodore Roosevelt";
                    break;
                case 20:
                    r = "To make the cart go, you must grease the wheels.";
                    w = "";
                    break;
                case 21:
                    r = "By failing to prepare, you are preparing to fail.";
                    w = "Benjamin Franklin";
                    break;
                case 22:
                    r = "Make two grins grow where there was only a grouch before.";
                    w = "Elbert Hubbard";
                    break;
                case 23:
                    r = "Next year, you'll wish you had started today!";
                    w = "";
                    break;
                case 24:
                    r = "There is yet time enough for you to take a different path.";
                    w = "";
                    break;
                case 25:
                    r = "Keep true to the dreams of your youth.";
                    w = "Friedrich Schiller";
                    break;
                case 26:
                    r = "Go confidently in the direction of your dreams.";
                    w = "Henry David Thoreau";
                    break;
                case 27:
                    r = "Be patient, in time even an egg will walk.";
                    w = "";
                    break;
                case 28:
                    r = "A pleasant surprise is waiting for you.";
                    w = "";
                    break;
                case 29:
                    r = "May you have a great luck.";
                    w = "";
                    break;
                case 30:
                    r = "Soon life will be more interesting.";
                    w = "";
                    break;
                case 31:
                    r = "As the purse is emptied the heart is filled.";
                    w = "Victor Hugo";
                    break;
                case 32:
                    r = "A false step is made by standing still.";
                    w = "";
                    break;
                case 33:
                    r = "Don't just spend time, invest it.";
                    w = "";
                    break;
                case 34:
                    r = "Keep your plans secret for now.";
                    w = "";
                    break;
                case 35:
                    r = "What worries you, masters you.";
                    w = "John Locke";
                    break;
                case 36:
                    r = "Tomorrow, take a moment to do something just for yourself.";
                    w = "";
                    break;
                case 37:
                    r = "People decide a whole lot about you when they first meet you.";
                    w = "";
                    break;
                case 38:
                    r = "Accept what comes to you each day.";
                    w = "";
                    break;
                case 39:
                    r = "You're never too old to start something new.";
                    w = "";
                    break;
                case 40:
                    r = "Your passions sweep you away.";
                    w = "";
                    break;
                case 41:
                    r = "Excuses are easy to be made, and hard to sell.";
                    w = "";
                    break;
                case 42:
                    r = "The eyes believe themselves, the ears believe other people.";
                    w = "";
                    break;
                case 43:
                    r = "You will go places.";
                    w = "";
                    break;
                case 44:
                    r = "Greatest pleasure in life is doing what other people say you cannot do.";
                    w = "Walter Bagehot";
                    break;
                case 45:
                    r = "If you wait for perfect conditions, you'll never get anything done.";
                    w = "";
                    break;
                case 46:
                    r = "A man is never too old to learn.";
                    w = "Chinese proverb";
                    break;
                case 47:
                    r = "A straight foot is not afraid of a crooked shoe.";
                    w = "Chinese proverb";
                    break;
                case 48:
                    r = "All things are difficult before they are easy.";
                    w = "Chinese proverb";
                    break;
                case 49:
                    r = "Opportunity knocks at the door only once.";
                    w = "Chinese proverb";
                    break;
                case 50:
                    r = "Some are happy, some have worries. Or one man's disaster is another man's delight.";
                    w = "Chinese proverb";
                    break;
                case 51:
                    r = "It seems to be a law of nature, inflexible and inexorable, that those who will not risk cannot win.";
                    w = "John Paul Jones";
                    break;
                case 52:
                    r = "Either I will find a way, or I will make one.";
                    w = "Philip Sidney";
                    break;
                case 53:
                    r = "Believe you can and you're halfway there.";
                    w = "Theodore Roosevelt";
                    break;
                case 54:
                    r = "It's not what you look at that matters, it's what you see.";
                    w = "Henry David Thoreau";
                    break;
                case 55:
                    r = "The only true wisdom is in knowing you know nothing.";
                    w = "Socrates";
                    break;
                case 56:
                    r = "Life is not a problem to be solved, but a reality to be experienced.";
                    w = "Soren Kierkegaard";
                    break;
                case 57:
                    r = "Don't let anyone tell you how to live.";
                    w = "";
                    break;
                case 58:
                    r = "This world is but a canvas to our imagination.";
                    w = "Henry David Thoreau";
                    break;
                case 59:
                    r = "You can't let fear paralyze you.";
                    w = "";
                    break;
                case 60:
                    r = "Don't let your dreams just be dreams.";
                    w = "";
                    break;
                case 61:
                    r = "Keep your plans secret for now.";
                    w = "";
                    break;
                case 62:
                    r = "Believing is doing.";
                    w = "";
                    break;
                case 63:
                    r = "You are one of the people who \"goes places in life.\"";
                    w = "";
                    break;
                case 64:
                    r = "It's always good to be underestimated.";
                    w = "";
                    break;
                case 65:
                    r = "Eat something you never tried before.";
                    w = "";
                    break;
                case 66:
                    r = "I have a dream...Time to go to bed.";
                    w = "";
                    break;
                case 67:
                    r = "Today is the tomorrow you worried about yesterday.";
                    w = "";
                    break;
                case 68:
                    r = "Perhaps you've been focusing too much on that one thing.";
                    w = "";
                    break;
                case 69:
                    r = "One may be humble out of pride.";
                    w = "Michel de Montaigne";
                    break;
                case 70:
                    r = "Learning is pleasurable but doing is the height of enjoyment.";
                    w = "Novalis";
                    break;
                case 71:
                    r = "First feelings are always the most natural.";
                    w = "Louis XIV";
                    break;
                case 72:
                    r = "The journey of a thousand miles begins with one step.";
                    w = "Lao Tzu";
                    break;
                case 73:
                    r = "Do not go where the path may lead, go instead where there is no path and leave a trail.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 74:
                    r = "The art of being wise is the art of knowing what to overlook.";
                    w = "William James";
                    break;
                case 75:
                    r = "A day of worry is more exhausting than a week of work.";
                    w = "John Lubbock";
                    break;
                case 76:
                    r = "Not knowing anything is the sweetest life.";
                    w = "Sophocles";
                    break;
                case 77:
                    r = "A man growing old becomes a child again.";
                    w = "Sophocles";
                    break;
                case 78:
                    r = "The course of true love never did run smooth.";
                    w = "William Shakespeare";
                    break;
                case 79:
                    r = "Arriving at one goal is the starting point to another.";
                    w = "";
                    break;
                case 80:
                    r = "Your life around you will change only when you allow what's going on inside of you to change.";
                    w = "";
                    break;
                case 81:
                    r = "Impossible is a word to be found only in the dictionary of fools.";
                    w = "Napoleon Bonaparte";
                    break;
                case 82:
                    r = "Rules and models destroy genius and art.";
                    w = "William Hazlitt";
                    break;
                case 83:
                    r = "The past, the present and the future are really one: they are today.";
                    w = "Harriet Beecher Stowe";
                    break;
                case 84:
                    r = "It's only embarrassing if you're embarrassed.";
                    w = "";
                    break;
                case 85:
                    r = "Put the data you have uncovered to beneficial use.";
                    w = "";
                    break;
                case 86:
                    r = "Life is hidden, adventure can be found.";
                    w = "";
                    break;
                case 87:
                    r = "When in Rome, do as the Romans";
                    w = "Japanese proverb";
                    break;
                case 88:
                    r = "He who knows, does not speak. He who speaks, does not know.";
                    w = "Lao Tzu";
                    break;
                case 89:
                    r = "Water surges only to overflow.";
                    w = "Chinese proverb";
                    break;
                case 90:
                    r = "It is better to travel ten thousand miles than to read ten thousand books.";
                    w = "Chinese proverb";
                    break;
                case 91:
                    r = "Quiet thoughts mend the body.";
                    w = "Chinese proverb";
                    break;
                case 92:
                    r = "Where ignorance is bliss, it's folly to be wise.";
                    w = "Thomas Gray";
                    break;
                case 93:
                    r = "Beware of little expenses: a small leak will sink a great ship.";
                    w = "Benjamin Franklin";
                    break;
                case 94:
                    r = "Opportunities slide away like clouds.";
                    w = "Muhammad";
                    break;
                case 95:
                    r = "All men who have achieved great things have been great dreamers.";
                    w = "Orison Swett Marden";
                    break;
                case 96:
                    r = "Believe that life is worth living and your belief will help create the fact.";
                    w = "William James";
                    break;
                case 97:
                    r = "Every day brings new choices.";
                    w = "";
                    break;
                case 98:
                    r = "A bad peace is even worse than war.";
                    w = "Tacitus";
                    break;
                case 99:
                    r = "Trust in dreams, for in them is hidden the gate to eternity.";
                    w = "Khalil Gibran";
                    break;
                case 100:
                    r = "Your focus determines your reality.";
                    w = "";
                    break;
                case 101:
                    r = "I am not embarrassed to tell you that I believe in miracles.";
                    w = "";
                    break;
                case 102:
                    r = "Pessimism leads to weakness, optimism to power.";
                    w = "William James";
                    break;
                case 103:
                    r = "It does not matter how slowly you go as long as you do not stop.";
                    w = "Confucius";
                    break;
                case 104:
                    r = "Everything has beauty, but not everyone sees it.";
                    w = "Confucius";
                    break;
                case 105:
                    r = "Study the past, if you would divine the future.";
                    w = "Confucius";
                    break;
                case 106:
                    r = "Life is really simple, but we insist on making it complicated.";
                    w = "Confucius";
                    break;
                case 107:
                    r = "Better a diamond with a flaw than a pebble without.";
                    w = "Confucius";
                    break;
                case 108:
                    r = "I make the most of all that comes and the least of all that goes.";
                    w = "Sara Teasdale";
                    break;
                case 109:
                    r = "If there is no struggle, there is no progress.";
                    w = "Frederick Douglass";
                    break;
                case 110:
                    r = "Believe that life is worth living and your belief will help create the fact.";
                    w = "William James";
                    break;
                case 111:
                    r = "Age is a case of mind over matter. If you don't mind, it don't matter.";
                    w = "Mark Twain";
                    break;
                case 112:
                    r = "On earth there is no heaven, but there are pieces of it.";
                    w = "Jules Renard";
                    break;
                case 113:
                    r = "Time is what we want most, but what we use worst.";
                    w = "William Penn";
                    break;
                case 114:
                    r = "Now is the time to try something new.";
                    w = "";
                    break;
                case 115:
                    r = "He who has a why to live can bear almost any how.";
                    w = "Friedrich Nietzsche";
                    break;
                case 116:
                    r = "Lost time is never found again.";
                    w = "Benjamin Franklin";
                    break;
                case 117:
                    r = "Wisdom begins in wonder.";
                    w = "Socrates";
                    break;
                case 118:
                    r = "Every moment of light and dark is a miracle.";
                    w = "Walt Whitman";
                    break;
                case 119:
                    r = "Remember when life's path is steep to keep your mind even.";
                    w = "Horace";
                    break;
                case 120:
                    r = "Who seeks shall find.";
                    w = "Sophocles";
                    break;
                case 121:
                    r = "There is no wealth but life.";
                    w = "John Ruskin";
                    break;
                case 122:
                    r = "Character is power.";
                    w = "";
                    break;
                case 123:
                    r = "Often one finds one's destiny just where one hides to avoid it.";
                    w = "Chinese Proverb";
                    break;
                case 124:
                    r = "Everyone eats and drinks; yet only few appreciate the taste of food.";
                    w = "Chinese Proverb";
                    break;
                case 125:
                    r = "If you always give, you will always have.";
                    w = "Chinese Proverb";
                    break;
                case 126:
                    r = "Make happy those who are near, and those who are far will come.";
                    w = "Chinese Proverb";
                    break;
                case 127:
                    r = "He who sacrifices his conscience to ambition burns a picture to obtain the ashes.";
                    w = "Chinese Proverb";
                    break;
                case 128:
                    r = "When you are content to be simply yourself and don’t compare or compete, everybody will respect you.";
                    w = "Chinese Proverb";
                    break;
                case 129:
                    r = "Do not anxiously hope for that which is not yet come; do not vainly regret what is already past.";
                    w = "Chinese Proverb";
                    break;
                case 130:
                    r = "Failure is not falling down but refusing to get up.";
                    w = "Chinese Proverb";
                    break;
                case 131:
                    r = "If you are patient in one moment of anger, you will escape a hundred days of sorrow.";
                    w = "Chinese Proverb";
                    break;
                case 132:
                    r = "To talk much and arrive nowhere is the same as climbing a tree to catch a fish.";
                    w = "Chinese Proverb";
                    break;
                case 133:
                    r = "If you walk on snow you cannot hide your footprints.";
                    w = "Chinese Proverb";
                    break;
                case 134:
                    r = "Knowing is not as good as loving; loving is not as good as enjoying.";
                    w = "Chinese Proverb";
                    break;
                case 135:
                    r = "A bad word whispered will echo a hundred times.";
                    w = "Chinese Proverb";
                    break;
                case 136:
                    r = "One happiness scatters a thousand sorrows.";
                    w = "Chinese Proverb";
                    break;
                case 137:
                    r = "It is the beautiful bird that gets caged.";
                    w = "Chinese Proverb";
                    break;
                case 138:
                    r = "Life is finite, while knowledge is infinite.";
                    w = "Chinese Proverb";
                    break;
                case 139:
                    r = "When your horse is on the brink of a precipice it is too late to pull the reins.";
                    w = "Chinese Proverb";
                    break;
                case 140:
                    r = "Of a good beginning cometh a good end.";
                    w = "Chinese Proverb";
                    break;
                case 141:
                    r = "If you do not change direction, you may end up where you are heading.";
                    w = "Lao Tzu";
                    break;
                case 142:
                    r = "The man who removes a mountain begins by carrying away small stones.";
                    w = "Confucius";
                    break;
                case 143:
                    r = "He who asks is a fool for five minutes, but he who does not ask remains a fool forever.";
                    w = "Mark Twain";
                    break;
                case 144:
                    r = "It is later than you think.";
                    w = "";
                    break;
                case 145:
                    r = "Save water, drink wine";
                    w = "";
                    break;
                case 146:
                    r = "Wake up to your own power.";
                    w = "";
                    break;
                case 147:
                    r = "Pray to god, but row towards shore.";
                    w = "";
                    break;
                case 148:
                    r = "Hitch your wagon to a star.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 149:
                    r = "Knowledge comes, but wisdom lingers.";
                    w = "Alfred Lord Tennyson";
                    break;
                case 150:
                    r = "If you still speak about it, you still care about it.";
                    w = "";
                    break;
                case 151:
                    r = "Great deeds are usually wrought at great risks.";
                    w = "Herodotus";
                    break;
                case 152:
                    r = "The backbone of surprise is fusing speed with secrecy.";
                    w = "Carl von Clausewitz";
                    break;
                case 153:
                    r = "The things that we love tell us what we are.";
                    w = "Thomas Aquinas";
                    break;
                case 154:
                    r = "What ends on hope does not end at all.";
                    w = "";
                    break;
                case 155:
                    r = "The cure for grief is movement.";
                    w = "";
                    break;
                case 156:
                    r = "None of the secrets of success will work unless you do.";
                    w = "";
                    break;
                case 157:
                    r = "Isn't there something else you should be working on right now?";
                    w = "";
                    break;
                case 158:
                    r = "Conquer your fears or they will conquer you.";
                    w = "";
                    break;
                case 159:
                    r = "What ever your goal is in life, embrace it visualize it, and for it will be yours.";
                    w = "";
                    break;
                case 160:
                    r = "Use your instincts now.";
                    w = "";
                    break;
                case 161:
                    r = "Hard words break no bones, fine words butter no parsnips.";
                    w = "";
                    break;
                case 162:
                    r = "You cannot love life until you live the life you love.";
                    w = "";
                    break;
                case 163:
                    r = "Be nice to people on your way up because you'll meet them on your way down.";
                    w = "Wilson Mizner";
                    break;
                case 164:
                    r = "Aren't you glad you just had a great meal?";
                    w = "";
                    break;
                case 165:
                    r = "Your emotional nature is strong and sensitive.";
                    w = "";
                    break;
                case 166:
                    r = "The greatest risk is not taking one.";
                    w = "";
                    break;
                case 167:
                    r = "Joys are often the shadows, cast by sorrows.";
                    w = "";
                    break;
                case 168:
                    r = "Land is always in the mind of the flying birds.";
                    w = "";
                    break;
                case 169:
                    r = "Simplicity and clearity should be the theme in your dress.";
                    w = "";
                    break;
                case 170:
                    r = "Your dream will come true when you least expect it";
                    w = "";
                    break;
                case 171:
                    r = "Every decision is a gamble.";
                    w = "";
                    break;
                case 172:
                    r = "The mind, once stretched by a new idea, never returns to its original dimensions.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 173:
                    r = "Yesterday you said tommorow.";
                    w = "";
                    break;
                case 174:
                    r = "Some cause happiness wherever they go; others whenever they go.";
                    w = "Oscar Wilde";
                    break;
                case 175:
                    r = "Courage is knowing what not to fear.";
                    w = "Plato";
                    break;
                case 176:
                    r = "When you arise in the morning, think of what a precious privilege it is to be alive - to breathe, to think, to enjoy, to love.";
                    w = "Marcus Aurelius";
                    break;
                case 177:
                    r = "The art of living is more like wrestling than dancing.";
                    w = "Marcus Aurelius";
                    break;
                case 178:
                    r = "Very little is needed to make a happy life; it is all within yourself, in your way of thinking.";
                    w = "Marcus Aurelius";
                    break;
                case 179:
                    r = "Everything we hear is an opinion, not a fact. Everything we see is a perspective, not the truth.";
                    w = "Marcus Aurelius";
                    break;
                case 180:
                    r = "He who lives in harmony with himself lives in harmony with the universe.";
                    w = "Marcus Aurelius";
                    break;
                case 181:
                    r = "Do not take life too seriously. You will never get out of it alive.";
                    w = "Elbert Hubbard";
                    break;
                case 182:
                    r = "Time is the most valuable thing a man can spend.";
                    w = "Theophrastus";
                    break;
                case 183:
                    r = "Time and tide wait for no man.";
                    w = "Geoffrey Chaucer";
                    break;
                case 184:
                    r = "Patience and time do more than strength or passion.";
                    w = "Jean de La Fontaine";
                    break;
                case 185:
                    r = "Always do what you are afraid to do.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 186:
                    r = "I celebrate myself, and sing myself.";
                    w = "Walt Whitman";
                    break;
                case 187:
                    r = "Start by doing what's necessary; then do what's possible; and suddenly you are doing the impossible.";
                    w = "Francis of Assisi";
                    break;
                case 188:
                    r = "The crying cat catches nothing.";
                    w = "";
                    break;
                case 189:
                    r = "Our life always expresses the result of our dominant thoughts.";
                    w = "Soren Kierkegaard";
                    break;
                case 190:
                    r = "You have a curious smile and a mysterious nature.";
                    w = "";
                    break;
                case 191:
                    r = "A thrilling time is in your immediate future.";
                    w = "";
                    break;
                case 192:
                    r = "He who laughs at himself never runs out of things to laugh at.";
                    w = "Epictetus";
                    break;
                case 193:
                    r = "Love always and deeply.";
                    w = "";
                    break;
                case 194:
                    r = "You will be forced to face fear, but if you do not run, fear will be afraid of you.";
                    w = "";
                    break;
                case 195:
                    r = "Things are never quite the way they seem.";
                    w = "";
                    break;
                case 196:
                    r = "Do not seek so much to find the answer as much as to understand the question better.";
                    w = "";
                    break;
                case 197:
                    r = "The beginning of wisdom is to desire it.";
                    w = "Solomon Ibn Gabirol";
                    break;
                case 198:
                    r = "Do what inspires you.";
                    w = "";
                    break;
                case 199:
                    r = "The first wealth is health.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 200:
                    r = "Many of life's failures are people who did not realize how close they were to success when they gave up.";
                    w = "Thomas A. Edison";
                    break;
                case 201:
                    r = "Countless as the sands of the sea are human passions.";
                    w = "Nikolai Gogol";
                    break;
                case 202:
                    r = "The opportunity is often lost by deliberating.";
                    w = "Publilius Syrus";
                    break;
                case 203:
                    r = "Illusion is the first of all pleasures.";
                    w = "Voltaire";
                    break;
                case 204:
                    r = "How people treat you is their karma; how you react is yours.";
                    w = "";
                    break;
                case 205:
                    r = "The beginning is the most important part of the work.";
                    w = "Plato";
                    break;
                case 206:
                    r = "We are twice armed if we fight with faith.";
                    w = "Plato";
                    break;
                case 207:
                    r = "A good decision is based on knowledge and not on numbers.";
                    w = "Plato";
                    break;
                case 208:
                    r = "You can discover more about a person in an hour of play than in a year of conversation.";
                    w = "Plato";
                    break;
                case 209:
                    r = "We love life, not because we are used to living but because we are used to loving.";
                    w = "Friedrich Nietzsche";
                    break;
                case 210:
                    r = "Thoughts are the shadows of our feelings - always darker, emptier and simpler.";
                    w = "Friedrich Nietzsche";
                    break;
                case 211:
                    r = "To live is to suffer, to survive is to find some meaning in the suffering.";
                    w = "Friedrich Nietzsche";
                    break;
                case 212:
                    r = "You have your way. I have my way. As for the right way, the correct way, and the only way, it does not exist.";
                    w = "Friedrich Nietzsche";
                    break;
                case 213:
                    r = "The best weapon against an enemy is another enemy.";
                    w = "Friedrich Nietzsche";
                    break;
                case 214:
                    r = "It is always consoling to think of suicide: in that way one gets through many a bad night.";
                    w = "Friedrich Nietzsche";
                    break;
                case 215:
                    r = "There are various eyes. Even the Sphinx has eyes: and as a result there are various truths, and as a result there is no truth.";
                    w = "Friedrich Nietzsche";
                    break;
                case 216:
                    r = "There is always some madness in love. But there is also always some reason in madness.";
                    w = "Friedrich Nietzsche";
                    break;
                case 217:
                    r = "It is impossible to suffer without making someone pay for it; every complaint already contains revenge.";
                    w = "Friedrich Nietzsche";
                    break;
                case 218:
                    r = "When you look into an abyss, the abyss also looks into you.";
                    w = "Friedrich Nietzsche";
                    break;
                case 219:
                    r = "Whenever I climb I am followed by a dog called 'Ego'.";
                    w = "Friedrich Nietzsche";
                    break;
                case 220:
                    r = "Success has always been a great liar.";
                    w = "Friedrich Nietzsche";
                    break;
                case 221:
                    r = "Our vanity is hardest to wound precisely when our pride has just been wounded.";
                    w = "Friedrich Nietzsche";
                    break;
                case 222:
                    r = "Of all that is written, I love only what a person has written with his own blood.";
                    w = "Friedrich Nietzsche";
                    break;
                case 223:
                    r = "Beware the fury of a patient man.";
                    w = "John Dryden";
                    break;
                case 224:
                    r = "";
                    w = "";
                    break;
                case 225:
                    r = "A pair of powerful spectacles has sometimes sufficed to cure a person in love.";
                    w = "Friedrich Nietzsche";
                    break;
                case 226:
                    r = "Admiration for a quality or an art can be so strong that it deters us from striving to possess it.";
                    w = "Friedrich Nietzsche";
                    break;
                case 227:
                    r = "We have art in order not to die of the truth.";
                    w = "Friedrich Nietzsche";
                    break;
                case 228:
                    r = "The future influences the present just as much as the past.";
                    w = "Friedrich Nietzsche";
                    break;
                case 229:
                    r = "Regarding life, the wisest men of all ages have judged alike: it is worthless.";
                    w = "Friedrich Nietzsche";
                    break;
                case 230:
                    r = "God is a thought who makes crooked all that is straight.";
                    w = "Friedrich Nietzsche";
                    break;
                case 231:
                    r = "A well adjusted person is one who makes the same mistake twice without getting nervous.";
                    w = "Friedrich Nietzsche";
                    break;
                case 232:
                    r = "Faith: not wanting to know what is true.";
                    w = "Friedrich Nietzsche";
                    break;
                case 233:
                    r = "There is more wisdom in your body than in your deepest philosophy.";
                    w = "Friedrich Nietzsche";
                    break;
                case 234:
                    r = "Nothing is easy to the unwilling.";
                    w = "Thomas Fuller";
                    break;
                case 235:
                    r = "Seek not greatness, but seek truth and you will find both.";
                    w = "Horace Mann";
                    break;
                case 236:
                    r = "Apparently there is nothing that cannot happen today.";
                    w = "Mark Twain";
                    break;
                case 237:
                    r = "Our patience will achieve more than our force.";
                    w = "Edmund Burke";
                    break;
                case 238:
                    r = "I dream of painting and then I paint my dream.";
                    w = "Vincent Van Gogh";
                    break;
                case 239:
                    r = "Memory always obeys the commands of the heart.";
                    w = "Antoine Rivarol";
                    break;
                case 240:
                    r = "One should die proudly when it is no longer possible to live proudly.";
                    w = "Friedrich Nietzsche";
                    break;
                case 241:
                    r = "You may delay, but time will not.";
                    w = "Benjamin Franklin";
                    break;
                case 242:
                    r = "You have power over your mind - not outside events. Realize this, and you will find strength.";
                    w = "Marcus Aurelius";
                    break;
                case 243:
                    r = "Faith consists in believing when it is beyond the power of reason to believe.";
                    w = "Voltaire";
                    break;
                case 244:
                    r = "Time brings all things to pass.";
                    w = "Aeschylus";
                    break;
                case 245:
                    r = "Silence is a source of great strength.";
                    w = "Lao Tzu";
                    break;
                case 246:
                    r = "Mastering others is strength. Mastering yourself is true power.";
                    w = "Lao Tzu";
                    break;
                case 247:
                    r = "To the mind that is still, the whole universe surrenders.";
                    w = "Lao Tzu";
                    break;
                case 248:
                    r = "Nature does not hurry, yet everything is accomplished.";
                    w = "Lao Tzu";
                    break;
                case 249:
                    r = "Kindness in words creates confidence. Kindness in thinking creates profoundness. Kindness in giving creates love.";
                    w = "Lao Tzu";
                    break;
                case 250:
                    r = "Music in the soul can be heard by the universe.";
                    w = "Lao Tzu";
                    break;
                case 251:
                    r = "The key to growth is the introduction of higher dimensions of consciousness into our awareness.";
                    w = "Lao Tzu";
                    break;
                case 252:
                    r = "I have just three things to teach: simplicity, patience, compassion. These three are your greatest treasures.";
                    w = "Lao Tzu";
                    break;
                case 253:
                    r = "He who knows others is wise. He who knows himself is enlightened.";
                    w = "Lao Tzu";
                    break;
                case 254:
                    r = "Anticipate the difficult by managing the easy.";
                    w = "Lao Tzu";
                    break;
                case 255:
                    r = "He who does not trust enough, Will not be trusted.";
                    w = "Lao Tzu";
                    break;
                case 256:
                    r = "When I let go of what I am, I become what I might be.";
                    w = "Lao Tzu";
                    break;
                case 257:
                    r = "Great acts are made up of small deeds.";
                    w = "Lao Tzu";
                    break;
                case 258:
                    r = "He who is contented is rich.";
                    w = "Lao Tzu";
                    break;
                case 259:
                    r = "Those who have knowledge, don't predict. Those who predict, don't have knowledge.";
                    w = "Lao Tzu";
                    break;
                case 260:
                    r = "From the errors of others, a wise man corrects his own.";
                    w = "Publilius Syrus";
                    break;
                case 261:
                    r = "Do not wait for your ship to come in, swim out to it.";
                    w = "";
                    break;
                case 262:
                    r = "You will step on the soil of many countries.";
                    w = "";
                    break;
                case 263:
                    r = "The world may be your oyster, but it doesn't mean you'll get its pearl.";
                    w = "";
                    break;
                case 264:
                    r = "Strong and bitter words indicate a weak cause.";
                    w = "Victor Hugo";
                    break;
                case 265:
                    r = "To think of shadows is a serious thing.";
                    w = "Victor Hugo";
                    break;
                case 266:
                    r = "He alone, who owns the youth, gains the future.";
                    w = "Adolf Hitler";
                    break;
                case 267:
                    r = "Great liars are also great magicians.";
                    w = "Adolf Hitler";
                    break;
                case 268:
                    r = "It is not truth that matters, but victory.";
                    w = "Adolf Hitler";
                    break;
                case 269:
                    r = "I am not afraid of an army of lions led by a sheep; I am afraid of an army of sheep led by a lion.";
                    w = "Alexander the Great";
                    break;
                case 270:
                    r = "Early to bed and early to rise makes a man healthy, wealthy and wise.";
                    w = "Benjamin Franklin";
                    break;
                case 271:
                    r = "We have all the light we need, we just need to put it in practice.";
                    w = "Albert Pike";
                    break;
                case 272:
                    r = "Wheresoever you go, go with all your heart.";
                    w = "Confucius";
                    break;
                case 273:
                    r = "Our greatest glory is not in never falling, but in rising every time we fall.";
                    w = "Confucius";
                    break;
                case 274:
                    r = "When it is obvious that the goals cannot be reached, don't adjust the goals, adjust the action steps.";
                    w = "Confucius";
                    break;
                case 275:
                    r = "Learn as though you would never be able to master it; hold it as though you would be in fear of losing it.";
                    w = "Confucius";
                    break;
                case 276:
                    r = "Before you embark on a journey of revenge, dig two graves.";
                    w = "Confucius";
                    break;
                case 277:
                    r = "Respect yourself and others will respect you.";
                    w = "Confucius";
                    break;
                case 278:
                    r = "I hear and I forget. I see and I remember. I do and I understand.";
                    w = "Confucius";
                    break;
                case 279:
                    r = "The superior man thinks always of virtue; the common man thinks of comfort.";
                    w = "Confucius";
                    break;
                case 280:
                    r = "The more man meditates upon good thoughts, the better will be his world and the world at large.";
                    w = "Confucius";
                    break;
                case 281:
                    r = "Study the past, if you would divine the future.";
                    w = "Confucius";
                    break;
                case 282:
                    r = "Never give a sword to a man who can't dance.";
                    w = "Confucius";
                    break;
                case 283:
                    r = "To be wronged is nothing unless you continue to remember it.";
                    w = "Confucius";
                    break;
                case 284:
                    r = "If we don't know life, how can we know death?";
                    w = "Confucius";
                    break;
                case 285:
                    r = "To go beyond is as wrong as to fall short.";
                    w = "Confucius";
                    break;
                case 286:
                    r = "Silence is a true friend who never betrays.";
                    w = "Confucius";
                    break;
                case 287:
                    r = "Ability will never catch up with the demand for it.";
                    w = "Confucius";
                    break;
                case 288:
                    r = "Learning without thought is labor lost; thought without learning is perilous.";
                    w = "Confucius";
                    break;
                case 289:
                    r = "The mind is everything. What you think you become.";
                    w = "Buddha";
                    break;
                case 290:
                    r = "It is better to travel well than to arrive.";
                    w = "Buddha";
                    break;
                case 291:
                    r = "A man growing old becomes a child again.";
                    w = "Sophocles";
                    break;
                case 292:
                    r = "Being deeply loved by someone gives you strength, while loving someone deeply gives you courage. ";
                    w = "Lao Tzu";
                    break;
                case 293:
                    r = "Luck exists in the leftovers.";
                    w = "Japanese proverb";
                    break;
                case 294:
                    r = "There are only two forces that unite men - fear and interest.";
                    w = "Napoleon Bonaparte";
                    break;
                case 295:
                    r = "Imagination rules the world.";
                    w = "Napoleon Bonaparte";
                    break;
                case 296:
                    r = "Courage is like love; it must have hope for nourishment.";
                    w = "Napoleon Bonaparte";
                    break;
                case 297:
                    r = "Never interrupt your enemy when he is making a mistake.";
                    w = "Napoleon Bonaparte";
                    break;
                case 298:
                    r = "Life is largely a matter of expectation.";
                    w = "Horace";
                    break;
                case 299:
                    r = "Beware the barrenness of a busy life.";
                    w = "Socrates";
                    break;
                case 300:
                    r = "Be as you wish to seem.";
                    w = "Socrates";
                    break;
                case 301:
                    r = "God always strives together with those who strive.";
                    w = "Aeschylus";
                    break;
                case 302:
                    r = "If you know the enemy and know yourself you need not fear the results of a hundred battles.";
                    w = "Sun Tzu";
                    break;
                case 303:
                    r = "The supreme art of war is to subdue the enemy without fighting.";
                    w = "Sun Tzu";
                    break;
                case 304:
                    r = "He who knows when he can fight and when he cannot, will be victorious.";
                    w = "Sun Tzu";
                    break;
                case 305:
                    r = "If you are far from the enemy, make him believe you are near.";
                    w = "Sun Tzu";
                    break;
                case 306:
                    r = "Three things cannot be long hidden: the sun, the moon, and the truth.";
                    w = "Buddha";
                    break;
                case 307:
                    r = "No one saves us but ourselves. No one can and no one may. We ourselves must walk the path.";
                    w = "Buddha";
                    break;
                case 308:
                    r = "Better than a thousand hollow words, is one word that brings peace.";
                    w = "Buddha";
                    break;
                case 309:
                    r = "To keep the body in good health is a duty... otherwise we shall not be able to keep our mind strong and clear.";
                    w = "Buddha";
                    break;
                case 310:
                    r = "We know what we are, but know not what we may be.";
                    w = "William Shakespeare";
                    break;
                case 311:
                    r = "Love all, trust a few, do wrong to none.";
                    w = "William Shakespeare";
                    break;
                case 312:
                    r = "There is nothing either good or bad but thinking makes it so.";
                    w = "William Shakespeare";
                    break;
                case 313:
                    r = "There's a way to do it better - find it.";
                    w = "Thomas A. Edison";
                    break;
                case 314:
                    r = "I have not failed. I've just found 10,000 ways that won't work.";
                    w = "Thomas A. Edison";
                    break;
                case 315:
                    r = "To invent, you need a good imagination and a pile of junk.";
                    w = "Thomas A. Edison";
                    break;
                case 316:
                    r = "Just because something doesn't do what you planned it to do doesn't mean it's useless.";
                    w = "Thomas A. Edison";
                    break;
                case 317:
                    r = "There are no secrets that time does not reveal.";
                    w = "Jean Racine";
                    break;
                case 318:
                    r = "Hope in reality is the worst of all evils because it prolongs the torments of man.";
                    w = "Friedrich Nietzsche";
                    break;
                case 319:
                    r = "Three can keep a secret if two of them are dead";
                    w = "Benjamin Franklin";
                    break;
                case 320:
                    r = "What would life be if we had no courage to attempt anything?";
                    w = "Vincent Van Gogh";
                    break;
                case 321:
                    r = "A compliment is something like a kiss through a veil.";
                    w = "Victor Hugo";
                    break;
                case 322:
                    r = "The more you burp, the less you fart.";
                    w = "";
                    break;
                case 323:
                    r = "It's a poor sort of memory that only works backwards.";
                    w = "Lewis Carroll";
                    break;
                case 324:
                    r = "We are no longer happy as soon as we wish to be happier.";
                    w = "Walter Savage Landor";
                    break;
                case 325:
                    r = "Studying is like climbing a mountain.";
                    w = "Chinese proverb";
                    break;
                case 326:
                    r = "As a man sows, so shall he reap.";
                    w = "Chinese proverb";
                    break;
                case 327:
                    r = "Dripping water pierces a stone; a saw made of rope cuts through wood.";
                    w = "Chinese proverb";
                    break;
                case 328:
                    r = "It takes more than one cold day for a river to freeze three feet deep.";
                    w = "Chinese proverb";
                    break;
                case 329:
                    r = "Nothing is too deceitful in war";
                    w = "Chinese proverb";
                    break;
                case 330:
                    r = "A bad workman always blames his tools.";
                    w = "Chinese proverb";
                    break;
                case 331:
                    r = "Look before you leap.";
                    w = "Chinese proverb";
                    break;
                case 332:
                    r = "The goal of all life is death.";
                    w = "Sigmund Freud";
                    break;
                case 333:
                    r = "Time spent with cats is never wasted.";
                    w = "Sigmund Freud";
                    break;
                case 334:
                    r = "The mind is like an iceberg, it floats with one-seventh of its bulk above water.";
                    w = "Sigmund Freud";
                    break;
                case 335:
                    r = "Being entirely honest with oneself is a good exercise.";
                    w = "Sigmund Freud";
                    break;
                case 336:
                    r = "Don't judge each day by the harvest you reap but by the seeds that you plant.";
                    w = "Robert Louis Stevenson";
                    break;
                case 337:
                    r = "You never know where a dream will lead you.";
                    w = "";
                    break;
                case 338:
                    r = "Peace comes from within. Do not seek it without.";
                    w = "Buddha";
                    break;
                case 339:
                    r = "Is there anyone so wise as to learn by the experience of others?";
                    w = "Voltaire";
                    break;
                case 340:
                    r = "You never know what is enough unless you know what is more than enough.";
                    w = "William Blake";
                    break;
                case 341:
                    r = "The length of a man's outspread arms is equal to his height.";
                    w = "Leonardo da Vinci";
                    break;
                case 342:
                    r = "It's easier to resist at the beginning than at the end.";
                    w = "Leonardo da Vinci";
                    break;
                case 343:
                    r = "He who is fixed to a star does not change his mind.";
                    w = "Leonardo da Vinci";
                    break;
                case 344:
                    r = "Art is never finished, only abandoned.";
                    w = "Leonardo da Vinci";
                    break;
                case 345:
                    r = "Time stays long enough for anyone who will use it.";
                    w = "Leonardo da Vinci";
                    break;
                case 346:
                    r = "Simplicity is the ultimate sophistication.";
                    w = "Leonardo da Vinci";
                    break;
                case 347:
                    r = "It had long since come to my attention that people of accomplishment rarely sat back and let things happen to them. They went out and happened to things.";
                    w = "Leonardo da Vinci";
                    break;
                case 348:
                    r = "You can have no dominion greater or less than that over yourself.";
                    w = "Leonardo da Vinci";
                    break;
                case 349:
                    r = "There is no pleasure in having nothing to do; the fun is having lots to do and not doing it.";
                    w = "Andrew Jackson";
                    break;
                case 350:
                    r = "Do you wish people to think well of you? Don't speak well of yourself.";
                    w = "Blaise Pascal";
                    break;
                case 351:
                    r = "Every new concept first comes to the mind in a judgment.";
                    w = "Charles Sanders Peirce";
                    break;
                case 352:
                    r = "We choose our joys and sorrows long before we experience them.";
                    w = "Khalil Gibran";
                    break;
                case 353:
                    r = "Learning never exhausts the mind.";
                    w = "Leonardo da Vinci";
                    break;
                case 354:
                    r = "No artist tolerates reality.";
                    w = "Friedrich Nietzsche";
                    break;
                case 355:
                    r = "We love life, not because we are used to living but because we are used to loving.";
                    w = "Friedrich Nietzsche";
                    break;
                case 356:
                    r = "Wherever you live, you come to love it. ";
                    w = "Japanese proverb";
                    break;
                case 357:
                    r = "Don't count your chickens before they've hatched.";
                    w = "Japanese proverb";
                    break;
                case 358:
                    r = "Fall down seven times, stand up eight.";
                    w = "Japanese proverb";
                    break;
                case 359:
                    r = "You are not required to set yourself on fire to keep other people warm.";
                    w = "";
                    break;
                case 360:
                    r = "";
                    w = "";
                    break;
                case 361:
                    r = "What are you going to do today, you Mighty Warrior?";
                    w = "";
                    break;
                case 362:
                    r = "Give a man a gun and he'll rob a bank. Give a man a bank and he'll rob the world.";
                    w = "";
                    break;
                case 363:
                    r = "Thoughts are the shadows of our feelings - always darker, emptier and simpler.";
                    w = "Friedrich Nietzsche";
                    break;
                case 364:
                    r = "Fortune and love favor the brave.";
                    w = "Ovid";
                    break;
                case 365:
                    r = "Someone once told me the definition of Hell: The last day you have on earth, the person you became will meet the person you could have become.";
                    w = "Anonymous";
                    break;
                case 366:
                    r = "Because of a great love, one is courageous.";
                    w = "Lao Tzu";
                    break;
                case 367:
                    r = "The greatest way to live with honor in this world is to be what we pretend to be.";
                    w = "Socrates";
                    break;
                case 368:
                    r = "All truly great thoughts are conceived by walking.";
                    w = "Friedrich Nietzsche";
                    break;
                case 369:
                    r = "I still live, I still think: I still have to live, for I still have to think.";
                    w = "Friedrich Nietzsche";
                    break;
                case 370:
                    r = "It's not what happens to you, but how you react to it that matters.";
                    w = "Epictetus";
                    break;
                case 371:
                    r = "I came, I saw, I conquered.";
                    w = "Julius Caesar";
                    break;
                case 372:
                    r = "A smooth sea, never made a skilled sailor.";
                    w = "";
                    break;
                case 373:
                    r = "If it doesn't challenge you, it doesn't change you.";
                    w = "";
                    break;
                case 374:
                    r = "Don't stay in bed, unless you can make money in bed.";
                    w = "";
                    break;
                case 375:
                    r = "Life has its own hidden forces which you can only discover by living.";
                    w = "Soren Kierkegaard";
                    break;
                case 376:
                    r = "Nurture your mind with great thoughts. To believe in the heroic makes heroes.";
                    w = "Benjamin Disraeli";
                    break;
                case 377:
                    r = "Peace comes from within. Do not seek it without.";
                    w = "Buddha";
                    break;
                case 378:
                    r = "Eat something you never tried before.";
                    w = "";
                    break;
                case 379:
                    r = "Listen to yourself more often";
                    w = "";
                    break;
                case 380:
                    r = "Pick a path with heart.";
                    w = "";
                    break;
                case 381:
                    r = "Man is least himself when he talks in his own person. Give him a mask, and he will tell you the truth.";
                    w = "Oscar Wilde";
                    break;
                case 382:
                    r = "Vision without action is a daydream. Action without vision is a nightmare";
                    w = "Japanese proverb";
                    break;
                case 383:
                    r = "Good words are like a string of pearls.";
                    w = "Chinese Proverb";
                    break;
                case 384:
                    r = "Even a fool, when he holdeth his peace, is counted wise.";
                    w = "Chinese Proverb";
                    break;
                case 385:
                    r = "Excess property - unnecessary care.";
                    w = "Chinese Proverb";
                    break;
                case 386:
                    r = "With those who are silent , be alert.";
                    w = "Chinese Proverb";
                    break;
                case 387:
                    r = "Do everything you can, and leave the rest to fate.";
                    w = "Chinese Proverb";
                    break;
                case 388:
                    r = "Actions speak louder than words.";
                    w = "Chinese Proverb";
                    break;
                case 389:
                    r = "The artist who aims at perfection in everything achieves it in nothing.";
                    w = "Eugene Delacroix";
                    break;
                case 390:
                    r = "The only way to enjoy anything in this life is to earn it first.";
                    w = "";
                    break;
                case 391:
                    r = "I do bad things, but I do them well. MEOW!";
                    w = "";
                    break;
                case 392:
                    r = "As people are walking all the time, in the same spot, a path appears.";
                    w = "John Locke";
                    break;
                case 393:
                    r = "";
                    w = "";
                    break;
                case 394:
                    r = "You don't get harmony when everybody sings the same note.";
                    w = "";
                    break;
                case 395:
                    r = "Do what you want, when you want, and you will be rewarded";
                    w = "";
                    break;
                case 396:
                    r = "The project on your mind will soon gain momentum";
                    w = "";
                    break;
                case 397:
                    r = "Love will lead the way";
                    w = "";
                    break;
                case 398:
                    r = "Someday everything will all make perfect sense";
                    w = "";
                    break;
                case 399:
                    r = "A clear conscience is usually the sign of a bad memory.";
                    w = "";
                    break;
                case 400:
                    r = "The race is not always to the swift, but to those who keep on running.";
                    w = "";
                    break;
                case 401:
                    r = "If you eat a box of fortune cookies, anything is possible.";
                    w = "";
                    break;
                case 402:
                    r = "Listen to yourself more often";
                    w = "";
                    break;
                case 403:
                    r = "The joyful energy of the day will have a positive affect on you.";
                    w = "";
                    break;
                case 404:
                    r = "You will soon embark on a business venture.";
                    w = "";
                    break;
                case 405:
                    r = "The cooler you think you are the dumber you look";
                    w = "";
                    break;
                case 406:
                    r = "Being happy is not always being perfect.";
                    w = "";
                    break;
                case 407:
                    r = "It is better to have a hen tomorrow than an egg today.";
                    w = "Chinese proverb";
                    break;
                case 408:
                    r = "Old dreams never die they just get filed away.";
                    w = "";
                    break;
                case 409:
                    r = "YOUR FAILURES WILL LEAD YOU TO YOUR SUCCESS.";
                    w = "";
                    break;
                case 410:
                    r = "Things may come to those who wait, but only the things left by those who hustle.";
                    w = "";
                    break;
                case 411:
                    r = "Fear is just excitement in need of an attitude adjustment.";
                    w = "";
                    break;
                case 412:
                    r = "It's about time you asked that special someone on a date.";
                    w = "";
                    break;
                case 413:
                    r = "See the light at the end of the tunnel.";
                    w = "";
                    break;
                case 414:
                    r = "The gambler is like the fisherman both have beginners luck.";
                    w = "";
                    break;
                case 415:
                    r = "A great pleasure in life is doing what others say you can't.";
                    w = "";
                    break;
                case 416:
                    r = "Your dynamic eyes have attracted a secret admirer.";
                    w = "";
                    break;
                case 417:
                    r = "Treasure what you have.";
                    w = "";
                    break;
                case 418:
                    r = "Absence sharpens love, presence strengthens it.";
                    w = "Thomas Fuller";
                    break;
                case 419:
                    r = "Care and diligence bring luck.";
                    w = "Thomas Fuller";
                    break;
                case 420:
                    r = "One that would have the fruit must climb the tree.";
                    w = "Thomas Fuller";
                    break;
                case 421:
                    r = "Without music, life would be a mistake.";
                    w = "Friedrich Nietzsche";
                    break;
                case 422:
                    r = "Lions pretend to be hurt by the bites of their young to encourage them";
                    w = "";
                    break;
                case 423:
                    r = "That which does not kill us makes us stronger.";
                    w = "Friedrich Nietzsche";
                    break;
                case 424:
                    r = "There cannot be a God because if there were one, I could not believe that I was not He.";
                    w = "Friedrich Nietzsche";
                    break;
                case 425:
                    r = "Anything that can go wrong, will go wrong.";
                    w = "Murphy's law";
                    break;
                case 426:
                    r = "";
                    w = "";
                    break;
                case 427:
                    r = "";
                    w = "";
                    break;
                case 428:
                    r = "";
                    w = "";
                    break;
                case 429:
                    r = "";
                    w = "";
                    break;
                case 430:
                    r = "";
                    w = "";
                    break;
                case 431:
                    r = "";
                    w = "";
                    break;
                case 432:
                    r = "";
                    w = "";
                    break;
                case 433:
                    r = "";
                    w = "";
                    break;
                case 434:
                    r = "";
                    w = "";
                    break;
                case 435:
                    r = "";
                    w = "";
                    break;
                case 436:
                    r = "";
                    w = "";
                    break;
                case 437:
                    r = "";
                    w = "";
                    break;
                case 438:
                    r = "Absence sharpens love, presence strengthens it.";
                    w = "Thomas Fuller";
                    break;
                case 439:
                    r = "Health is not valued till sickness comes.";
                    w = "Thomas Fuller";
                    break;
                case 440:
                    r = "When angry count to ten before you speak. If very angry, count to one hundred.";
                    w = "Thomas Jefferson";
                    break;
                case 441:
                    r = "I cannot believe in a God who wants to be praised all the time.";
                    w = "Friedrich Nietzsche";
                    break;
                case 442:
                    r = "If you label your fear or give it a name,it becomes easier to control.";
                    w = "";
                    break;
                case 443:
                    r = "every portrait that is painted with feeling is a portrait of the artist, not of the sitter.";
                    w = "Oscar Wilde";
                    break;
                case 444:
                    r = "If you only do what you can do, you will never be more than you are now.";
                    w = "";
                    break;
                case 445:
                    r = "What makes you, you?";
                    w = "";
                    break;
                case 446:
                    r = "If you're not failing every now and then, you are not aiming high enough.";
                    w = "";
                    break;
                case 447:
                    r = "Magic is believing in yourself, if you can do that, you can make anything happen.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 448:
                    r = "In the end we only regret the chances we didnt take.";
                    w = "";
                    break;
                case 449:
                    r = "Ambition is the last refuge of the failure.";
                    w = "Oscar Wilde";
                    break;
                case 450:
                    r = "If nobody hates you, you're doing something wrong.";
                    w = "";
                    break;
                case 451:
                    r = "Always do what you are afraid to do.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 452:
                    r = "Write it on your heart that every day is the best day in the year.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 453:
                    r = "The greatest deception men suffer is from their own opinions.";
                    w = "Leonardo da Vinci";
                    break;
                case 454:
                    r = "Every single choice you have ever made in your life has brought you to this exact moment, reading this exact sentence.";
                    w = "";
                    break;
                case 455:
                    r = "Ability is nothing without opportunity.";
                    w = "Napoleon Bonaparte";
                    break;
                case 456:
                    r = "What light is to the eyes - what air is to the lungs - what love is to the heart, liberty is to the soul of man.";
                    w = "Robert Green Ingersoll";
                    break;
                case 457:
                    r = "IN THE END… We only regret the chances we didn’t take, the relationships we were afraid to have,and the decisions we waited too long to make.";
                    w = "Lewis Carroll";
                    break;
                case 458:
                    r = "Where there's a will, there's a way.";
                    w = "";
                    break;
                case 459:
                    r = "I can live for two months on a good compliment.";
                    w = "Mark Twain";
                    break;
                case 460:
                    r = "Great things are done by a series of small things brought together.";
                    w = "Vincent Van Gogh";
                    break;
                case 461:
                    r = "To every action there is always opposed an equal reaction.";
                    w = "Isaac Newton";
                    break;
                case 462:
                    r = "We cannot teach people anything; we can only help them discover it within themselves.";
                    w = "Galileo Galilei";
                    break;
                case 463:
                    r = "Quick decisions are unsafe decisions.";
                    w = "Sophocles";
                    break;
                case 464:
                    r = "The doors of wisdom are never shut.";
                    w = "Benjamin Franklin";
                    break;
                case 465:
                    r = "Be afraid! And then do it anyway!";
                    w = "";
                    break;
                case 466:
                    r = "A well-aimed spear is worth three.";
                    w = "";
                    break;
                case 467:
                    r = "Sit back and go with the flow.";
                    w = "";
                    break;
                case 468:
                    r = "Let us act on what we have, since we have not what we wish.";
                    w = "John Henry Newman";
                    break;
                case 469:
                    r = "To live is to change, and to be perfect is to have changed often.";
                    w = "John Henry Newman";
                    break;
                case 470:
                    r = "We can believe what we choose. We are answerable for what we choose to believe.";
                    w = "John Henry Newman";
                    break;
                case 471:
                    r = "All life is an experiment. The more experiments you make the better.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 472:
                    r = "To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 473:
                    r = "What lies behind you and what lies in front of you, pales in comparison to what lies inside of you.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 474:
                    r = "Never lose an opportunity of seeing anything beautiful, for beauty is God's handwriting.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 475:
                    r = "Once you make a decision, the universe conspires to make it happen.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 476:
                    r = "All you need in this life is ignorance and confidence, and then success is sure.";
                    w = "Mark Twain";
                    break;
                case 477:
                    r = "Age is an issue of mind over matter. If you don't mind, it doesn't matter.";
                    w = "Mark Twain";
                    break;
                case 478:
                    r = "Give a man a mask and he will show his true face.";
                    w = "Oscar Wilde";
                    break;
                case 479:
                    r = "Art is the most intense mode of individualism that the world has known.";
                    w = "Oscar Wilde";
                    break;
                case 480:
                    r = "Always forgive your enemies - nothing annoys them so much.";
                    w = "Oscar Wilde";
                    break;
                case 481:
                    r = "I put all my genius into my life; I put only my talent into my works.";
                    w = "Oscar Wilde";
                    break;
                case 482:
                    r = "A man who does not think for himself does not think at all.";
                    w = "Oscar Wilde";
                    break;
                case 483:
                    r = "Everything popular is wrong.";
                    w = "Oscar Wilde";
                    break;
                case 484:
                    r = "No great artist ever sees things as they really are. If he did, he would cease to be an artist.";
                    w = "Oscar Wilde";
                    break;
                case 485:
                    r = "An idea that is not dangerous is unworthy of being called an idea at all.";
                    w = "Oscar Wilde";
                    break;
                case 486:
                    r = "It is the spectator, and not life, that art really mirrors.";
                    w = "Oscar Wilde";
                    break;
                case 487:
                    r = "Fashion is a form of ugliness so intolerable that we have to alter it every six months.";
                    w = "Oscar Wilde";
                    break;
                case 488:
                    r = "I want my food dead. Not sick, not dying, dead.";
                    w = "Oscar Wilde";
                    break;
                case 489:
                    r = "You may delay, but time will not.";
                    w = "Benjamin Franklin";
                    break;
                case 490:
                    r = "In this world nothing can be said to be certain, except death and taxes.";
                    w = "Benjamin Franklin";
                    break;
                case 491:
                    r = "Energy and persistence conquer all things.";
                    w = "Benjamin Franklin";
                    break;
                case 492:
                    r = "Mine is better than ours.";
                    w = "Benjamin Franklin";
                    break;
                case 493:
                    r = "Three can keep a secret, if two of them are dead. ";
                    w = "Benjamin Franklin";
                    break;
                case 494:
                    r = "When you're finished changing, you're finished.";
                    w = "Benjamin Franklin";
                    break;
                case 495:
                    r = "Rather go to bed with out dinner than to rise in debt.";
                    w = "Benjamin Franklin";
                    break;
                case 496:
                    r = "God helps those who help themselves.";
                    w = "Benjamin Franklin";
                    break;
                case 497:
                    r = "When in doubt, don't.";
                    w = "Benjamin Franklin";
                    break;
                case 498:
                    r = "Take time for all things: great haste makes great waste.";
                    w = "Benjamin Franklin";
                    break;
                case 499:
                    r = "In wine there is wisdom, in beer there is Freedom, in water there is bacteria.";
                    w = "Benjamin Franklin";
                    break;
                case 500:
                    r = "To live is the rarest thing in the world. Most people exist, that is all.";
                    w = "Oscar Wilde";
                    break;
                case 501:
                    r = "The truth is rarely pure and never simple.";
                    w = "Oscar Wilde";
                    break;
                case 502:
                    r = "You can never be overdressed or overeducated.";
                    w = "Oscar Wilde";
                    break;
                case 503:
                    r = "Most people are other people. Their thoughts are someone else's opinions, their lives a mimicry, their passions a quotation.";
                    w = "Oscar Wilde";
                    break;
                case 504:
                    r = "Never love anyone who treats you like you're ordinary.";
                    w = "Oscar Wilde";
                    break;
                case 505:
                    r = "Anyone who lives within their means suffers from a lack of imagination.";
                    w = "Oscar Wilde";
                    break;
                case 506:
                    r = "You don't love someone for their looks, or their clothes, or for their fancy car, but because they sing a song only you can hear.";
                    w = "Oscar Wilde";
                    break;
                case 507:
                    r = "To define is to limit.";
                    w = "Oscar Wilde";
                    break;
                case 508:
                    r = "For every minute you are angry you lose sixty seconds of happiness.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 509:
                    r = "I dream my painting and I paint my dream.";
                    w = "Vincent van Gogh";
                    break;
                case 510:
                    r = "Be clearly aware of the stars and infinity on high. Then life seems almost enchanted after all.";
                    w = "Vincent van Gogh";
                    break;
                case 511:
                    r = "I don't know anything with certainty, but seeing the stars makes me dream.";
                    w = "Vincent van Gogh";
                    break;
                case 512:
                    r = "If you hear a voice within you say you cannot paint, then by all means paint and that voice will be silenced.";
                    w = "Vincent van Gogh";
                    break;
                case 513:
                    r = "Suspicion always haunts the guilty mind.";
                    w = "William Shakespeare";
                    break;
                case 514:
                    r = "There is nothing either good or bad, but thinking makes it so.";
                    w = "William Shakespeare";
                    break;
                case 515:
                    r = "We know what we are, but not what we may be.";
                    w = "William Shakespeare";
                    break;
                case 516:
                    r = "Don't waste your love on somebody, who doesn't value it.";
                    w = "William Shakespeare";
                    break;
                case 517:
                    r = "Life grants nothing to us mortals without hard work.";
                    w = "Horace";
                    break;
                case 518:
                    r = "Mix a little foolishness with your serious plans. It is lovely to be silly at the right moment.";
                    w = "Horace";
                    break;
                case 519:
                    r = "Remember when life's path is steep to keep your mind even.";
                    w = "Horace";
                    break;
                case 520:
                    r = "Seize the day, and put the least possible trust in tomorrow.";
                    w = "Horace";
                    break;
                case 521:
                    r = "Nothing's beautiful from every point of view.";
                    w = "Horace";
                    break;
                case 522:
                    r = "It is the mark of an educated mind to be able to entertain a thought without accepting it.";
                    w = "Aristotle";
                    break;
                case 523:
                    r = "Holding onto anger is like drinking poison and expecting the other person to die.";
                    w = "Buddha";
                    break;
                case 524:
                    r = "Positive anything is better than negative nothing.";
                    w = "Elbert Hubbard";
                    break;
                case 525:
                    r = "The best preparation for good work tomorrow is to do good work today.";
                    w = "Elbert Hubbard";
                    break;
                case 526:
                    r = "In order to have friends, you must first be one.";
                    w = "Elbert Hubbard";
                    break;
                case 527:
                    r = "The supernatural is the natural not yet understood.";
                    w = "Elbert Hubbard";
                    break;
                case 528:
                    r = "Little minds are interested in the extraordinary; great minds in the commonplace.";
                    w = "Elbert Hubbard";
                    break;
                case 529:
                    r = "Every man is a damn fool for at least five minutes every day; wisdom consists in not exceeding the limit.";
                    w = "Elbert Hubbard";
                    break;
                case 530:
                    r = "To avoid criticism, do nothing, say nothing, and be nothing.";
                    w = "Aristotle";
                    break;
                case 531:
                    r = "Art is not a thing; it is a way.";
                    w = "Elbert Hubbard";
                    break;
                case 532:
                    r = "He has achieved success who has worked well, laughed often, and loved much.";
                    w = "Elbert Hubbard";
                    break;
                case 533:
                    r = "Live truth instead of professing it.";
                    w = "Elbert Hubbard";
                    break;
                case 534:
                    r = "There is no failure except in no longer trying.";
                    w = "Elbert Hubbard";
                    break;
                case 535:
                    r = "We are punished by our sins, not for them.";
                    w = "Elbert Hubbard";
                    break;
                case 536:
                    r = "You will not be punished for your anger, you will be punished by your anger.";
                    w = "Buddha";
                    break;
                case 537:
                    r = "What we think, we become.";
                    w = "Buddha";
                    break;
                case 538:
                    r = "Work out your own salvation. Do not depend on others.";
                    w = "Buddha";
                    break;
                case 539:
                    r = "Those who are free of resentful thoughts surely find peace.";
                    w = "Buddha";
                    break;
                case 540:
                    r = "Love is composed of a single soul inhabiting two bodies.";
                    w = "Aristotle";
                    break;
                case 541:
                    r = "The roots of education are bitter, but the fruit is sweet.";
                    w = "Aristotle";
                    break;
                case 542:
                    r = "Happiness depends upon ourselves.";
                    w = "Aristotle";
                    break;
                case 543:
                    r = "A friend to all is a friend to none.";
                    w = "Aristotle";
                    break;
                case 544:
                    r = "Pleasure in the job puts perfection in the work.";
                    w = "Aristotle";
                    break;
                case 545:
                    r = "There is no great genius without some touch of madness.";
                    w = "Aristotle";
                    break;
                case 546:
                    r = "Hope is a waking dream.";
                    w = "Aristotle";
                    break;
                case 547:
                    r = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.";
                    w = "Aristotle";
                    break;
                case 548:
                    r = "We make war that we may live in peace.";
                    w = "Aristotle";
                    break;
                case 549:
                    r = "Well begun is half done.";
                    w = "Aristotle";
                    break;
                case 550:
                    r = "The secret to humor is surprise.";
                    w = "Aristotle";
                    break;
                case 551:
                    r = "It is not living that matters, but living rightly.";
                    w = "Socrates";
                    break;
                case 552:
                    r = "Let him that would move the world first move himself.";
                    w = "Socrates";
                    break;
                case 553:
                    r = "No act of kindness, no matter how small, is ever wasted.";
                    w = "Aesop";
                    break;
                case 554:
                    r = "The level of our success is limited only by our imagination.";
                    w = "Aesop";
                    break;
                case 555:
                    r = "Plodding wins the race.";
                    w = "Aesop";
                    break;
                case 556:
                    r = "Do not count your chickens before they are hatched.";
                    w = "Aesop";
                    break;
                case 557:
                    r = "Better be wise by the misfortunes of others than by your own.";
                    w = "Aesop";
                    break;
                case 558:
                    r = "It is thrifty to prepare today for the wants of tomorrow.";
                    w = "Aesop";
                    break;
                case 559:
                    r = "Every truth has two sides; it is as well to look at both, before we commit ourselves to either.";
                    w = "Aesop";
                    break;
                case 560:
                    r = "The little reed, bending to the force of the wind, soon stood upright again when the storm had passed over.";
                    w = "Aesop";
                    break;
                case 561:
                    r = "A crust eaten in peace is better than a banquet partaken in anxiety.";
                    w = "Aesop";
                    break;
                case 562:
                    r = "Appearances are often deceiving.";
                    w = "Aesop";
                    break;
                case 563:
                    r = "After all is said and done, more is said than done.";
                    w = "Aesop";
                    break;
                case 564:
                    r = "Destroy the seed of evil, or it will grow up to your ruin.";
                    w = "Aesop";
                    break;
                case 565:
                    r = "Injuries may be forgiven, but not forgotten.";
                    w = "Aesop";
                    break;
                case 566:
                    r = "Adventure is worthwhile.";
                    w = "Aesop";
                    break;
                case 567:
                    r = "The unhappy derive comfort from the misfortunes of others.";
                    w = "Aesop";
                    break;
                case 568:
                    r = "Please all, and you will please none.";
                    w = "Aesop";
                    break;
                case 569:
                    r = "United we stand, divided we fall.";
                    w = "Aesop";
                    break;
                case 570:
                    r = "Persuasion is often more effectual than force.";
                    w = "Aesop";
                    break;
                case 571:
                    r = "Never trust the advice of a man in difficulties.";
                    w = "Aesop";
                    break;
                case 572:
                    r = "It is not only fine feathers that make fine birds.";
                    w = "Aesop";
                    break;
                case 573:
                    r = "It is easy to be brave from a safe distance.";
                    w = "Aesop";
                    break;
                case 574:
                    r = "We would often be sorry if our wishes were gratified.";
                    w = "Aesop";
                    break;
                case 575:
                    r = "Slow but steady wins the race.";
                    w = "Aesop";
                    break;
                case 576:
                    r = "We often give our enemies the means for our own destruction.";
                    w = "Aesop";
                    break;
                case 577:
                    r = "It is with our passions as it is with fire and water, they are good servants, but bad masters.";
                    w = "Aesop";
                    break;
                case 578:
                    r = "The gods help them that help themselves.";
                    w = "Aesop";
                    break;
                case 579:
                    r = "If you allow men to use you for your own purposes, they will use you for theirs.";
                    w = "Aesop";
                    break;
                case 580:
                    r = "In order to attain the impossible, one must attempt the absurd.";
                    w = "Miguel de Cervantes";
                    break;
                case 581:
                    r = "The knowledge of yourself will preserve you from vanity.";
                    w = "Miguel de Cervantes";
                    break;
                case 582:
                    r = "Our greatest foes, and whom we must chiefly combat, are within.";
                    w = "Miguel de Cervantes";
                    break;
                case 583:
                    r = "Laziness never arrived at the attainment of a good wish.";
                    w = "Miguel de Cervantes";
                    break;
                case 584:
                    r = "To be prepared is half the victory.";
                    w = "Miguel de Cervantes";
                    break;
                case 585:
                    r = "Never stand begging for that which you have the power to earn.";
                    w = "Miguel de Cervantes";
                    break;
                case 586:
                    r = "Those who'll play with cats must expect to be scratched.";
                    w = "Miguel de Cervantes";
                    break;
                case 587:
                    r = "God bears with the wicked, but not forever.";
                    w = "Miguel de Cervantes";
                    break;
                case 588:
                    r = "Good actions ennoble us, and we are the sons of our deeds.";
                    w = "Miguel de Cervantes";
                    break;
                case 589:
                    r = "Man appoints, and God disappoints.";
                    w = "Miguel de Cervantes";
                    break;
                case 590:
                    r = "Fair and softly goes far.";
                    w = "Miguel de Cervantes";
                    break;
                case 591:
                    r = "Man is free at the moment he wishes to be.";
                    w = "Voltaire";
                    break;
                case 592:
                    r = "God gave us the gift of life; it is up to us to give ourselves the gift of living well.";
                    w = "Voltaire";
                    break;
                case 593:
                    r = "Every man is guilty of all the good he did not do.";
                    w = "Voltaire";
                    break;
                case 594:
                    r = "Judge a man by his questions rather than his answers.";
                    w = "Voltaire";
                    break;
                case 595:
                    r = "The secret of being a bore... is to tell everything.";
                    w = "Voltaire";
                    break;
                case 596:
                    r = "Perfection is attained by slow degrees; it requires the hand of time.";
                    w = "Voltaire";
                    break;
                case 597:
                    r = "Everything's fine today, that is our illusion.";
                    w = "Voltaire";
                    break;
                case 598:
                    r = "We never live; we are always in the expectation of living.";
                    w = "Voltaire";
                    break;
                case 599:
                    r = "The best is the enemy of the good.";
                    w = "Voltaire";
                    break;
                case 600:
                    r = "It is not enough to conquer; one must learn to seduce.";
                    w = "Voltaire";
                    break;
                case 601:
                    r = "No problem can withstand the assault of sustained thinking.";
                    w = "Voltaire";
                    break;
                case 602:
                    r = "He who has not the spirit of this age, has all the misery of it.";
                    w = "Voltaire";
                    break;
                case 603:
                    r = "Weakness on both sides is, as we know, the motto of all quarrels.";
                    w = "Voltaire";
                    break;
                case 604:
                    r = "The more we do, the more we can do.";
                    w = "William Hazlitt";
                    break;
                case 605:
                    r = "Those who are at war with others are not at peace with themselves.";
                    w = "William Hazlitt";
                    break;
                case 606:
                    r = "Reflection makes men cowards.";
                    w = "William Hazlitt";
                    break;
                case 607:
                    r = "Everything is in motion. Everything flows. Everything is vibrating.";
                    w = "William Hazlitt";
                    break;
                case 608:
                    r = "No one ever approaches perfection except by stealth, and unknown to themselves.";
                    w = "William Hazlitt";
                    break;
                case 609:
                    r = "He who undervalues himself is justly undervalued by others.";
                    w = "William Hazlitt";
                    break;
                case 610:
                    r = "Prejudice is the child of ignorance.";
                    w = "William Hazlitt";
                    break;
                case 611:
                    r = "As is our confidence, so is our capacity.";
                    w = "William Hazlitt";
                    break;
                case 612:
                    r = "Poetry is all that is worth remembering in life.";
                    w = "William Hazlitt";
                    break;
                case 613:
                    r = "Great thoughts reduced to practice become great acts.";
                    w = "William Hazlitt";
                    break;
                case 614:
                    r = "If you think you can win, you can win. Faith is necessary to victory.";
                    w = "William Hazlitt";
                    break;
                case 615:
                    r = "We must be doing something to be happy.";
                    w = "William Hazlitt";
                    break;
                case 616:
                    r = "Those who can command themselves command others.";
                    w = "William Hazlitt";
                    break;
                case 617:
                    r = "Genius, like humanity, rusts for want of use.";
                    w = "William Hazlitt";
                    break;
                case 618:
                    r = "No young man ever thinks he shall die.";
                    w = "William Hazlitt";
                    break;
                case 619:
                    r = "Beauty in things exists in the mind which contemplates them.";
                    w = "David Hume";
                    break;
                case 620:
                    r = "Speak low, if you speak love.";
                    w = "William Shakespeare";
                    break;
                case 621:
                    r = "I must be cruel, only to be kind.";
                    w = "William Shakespeare";
                    break;
                case 622:
                    r = "Wisely, and slow. They stumble that run fast.";
                    w = "William Shakespeare";
                    break;
                case 623:
                    r = "Such as we are made of, such we be.";
                    w = "William Shakespeare";
                    break;
                case 624:
                    r = "To do a great right do a little wrong.";
                    w = "William Shakespeare";
                    break;
                case 625:
                    r = "Books are for people who wish they were somewhere else.";
                    w = "Mark Twain";
                    break;
                case 626:
                    r = "The secret to getting ahead is getting started.";
                    w = "Mark Twain";
                    break;
                case 627:
                    r = "The worst loneliness is to not be comfortable with yourself.";
                    w = "Mark Twain";
                    break;
                case 628:
                    r = "History doesn't repeat itself, but it does rhyme.";
                    w = "Mark Twain";
                    break;
                case 629:
                    r = "Out of all the things I have lost, I miss my mind the most.";
                    w = "Mark Twain";
                    break;
                case 630:
                    r = "Any emotion, if it is sincere, is involuntary.";
                    w = "Mark Twain";
                    break;
                case 631:
                    r = "Never argue with stupid people, they will drag you down to their level and then beat you with experience.";
                    w = "Mark Twain";
                    break;
                case 632:
                    r = "Reality can be beaten with enough imagination.";
                    w = "Mark Twain";
                    break;
                case 633:
                    r = "Get your facts first, then you can distort them as you please.";
                    w = "Mark Twain";
                    break;
                case 634:
                    r = "It is better to keep your mouth closed and let people think you are a fool than to open it and remove all doubt.";
                    w = "Mark Twain";
                    break;
                case 635:
                    r = "";
                    w = "";
                    break;
                case 636:
                    r = "Stop the Earth, I am getting off.";
                    w = "";
                    break;
                case 637:
                    r = "There is nothing impossible to him who will try.";
                    w = "Alexander the Great";
                    break;
                case 638:
                    r = "Anyone can hold the helm when the sea is calm.";
                    w = "Publilius Syrus";
                    break;
                case 639:
                    r = "Leap, and the net will appear.";
                    w = "John Burroughs";
                    break;
                case 640:
                    r = "What are you losing passion in?";
                    w = "";
                    break;
                case 641:
                    r = "A kiss makes the heart young again and wipes out the years.";
                    w = "Rupert Brooke";
                    break;
                case 642:
                    r = "The years teach much which the days never know.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 643:
                    r = "Love is energy of life.";
                    w = "Robert Browning";
                    break;
                case 644:
                    r = "A minute's success pays the failure of years.";
                    w = "Robert Browning";
                    break;
                case 645:
                    r = "The best time to plant a tree is twenty years ago. But the second best time is now";
                    w = "Chinese proverb";
                    break;
                case 646:
                    r = "Give a man a fish and you feed him for a day; teach a man to fish and you feed him for a lifetime.";
                    w = "Chinese proverb";
                    break;
                case 647:
                    r = "Man who waits for roast duck to fly into mouth must wait a very, very long time.";
                    w = "Chinese proverb";
                    break;
                case 648:
                    r = "Talk does not cook rice.";
                    w = "Chinese proverb";
                    break;
                case 649:
                    r = "If you must play, decide on three things at the start: the rules of the game, the stakes, and the quitting time.";
                    w = "Chinese proverb";
                    break;
                case 650:
                    r = "A single conversation across the table with a wise man is worth a month's study of books.";
                    w = "Chinese proverb";
                    break;
                case 651:
                    r = "Those who play the game do not see it as clearly as those who watch.";
                    w = "Chinese proverb";
                    break;
                case 652:
                    r = "A day of sorrow is longer than a month of joy.";
                    w = "Chinese proverb";
                    break;
                case 653:
                    r = "Learning is a treasure that will follow its owner everywhere.";
                    w = "Chinese proverb";
                    break;
                case 654:
                    r = "Teachers open the door, but you must enter by yourself.";
                    w = "Chinese proverb";
                    break;
                case 655:
                    r = "To talk goodness is not good… Only to do it is.";
                    w = "Chinese proverb";
                    break;
                case 656:
                    r = "Time heals everything.";
                    w = "";
                    break;
                case 657:
                    r = "What is once well done is done forever.";
                    w = "Henry David Thoreau";
                    break;
                case 658:
                    r = "Keep your eyes on the stars, and your feet on the ground.";
                    w = "Theodore Roosevelt";
                    break;
                case 659:
                    r = "With self-discipline most anything is possible.";
                    w = "Theodore Roosevelt";
                    break;
                case 660:
                    r = "Speak softly and carry a big stick; you will go far.";
                    w = "Theodore Roosevelt";
                    break;
                case 661:
                    r = "";
                    w = "";
                    break;
                case 662:
                    r = "Do what you can, with what you have, where you are.";
                    w = "Theodore Roosevelt";
                    break;
                case 663:
                    r = "The power of imagination makes us infinite.";
                    w = "John Muir";
                    break;
                case 664:
                    r = "In every walk with nature one receives far more than he seeks.";
                    w = "John Muir";
                    break;
                case 665:
                    r = "Women, can't live with them, can't live without them.";
                    w = "Desiderius Erasmus";
                    break;
                case 666:
                    r = "Prevention is better than cure.";
                    w = "Desiderius Erasmus";
                    break;
                case 667:
                    r = "In the kingdom of the blind, the one-eyed man is king.";
                    w = "Desiderius Erasmus";
                    break;
                case 668:
                    r = "To know nothing is the happiest life.";
                    w = "Desiderius Erasmus";
                    break;
                case 669:
                    r = "War is delightful to those who have had no experience of it.";
                    w = "Desiderius Erasmus";
                    break;
                case 670:
                    r = "Don't be afraid to give up the good to go for the great.";
                    w = "John D. Rockefeller";
                    break;
                case 671:
                    r = "I would rather earn 1% off a 100 people's efforts than 100% of my own efforts.";
                    w = "John D. Rockefeller";
                    break;
                case 672:
                    r = "And know that I am with you always; yes, to the end of time.";
                    w = "Jesus Christ";
                    break;
                case 673:
                    r = "Blessed are the merciful, for they will be shown mercy.";
                    w = "Jesus Christ";
                    break;
                case 674:
                    r = "Do not let your hearts be troubled. Trust in God; trust also in me.";
                    w = "Jesus Christ";
                    break;
                case 675:
                    r = "Life is the flower for which love is the honey.";
                    w = "Victor Hugo";
                    break;
                case 676:
                    r = "When a woman is talking to you, listen to what she says with her eyes.";
                    w = "Victor Hugo";
                    break;
                case 677:
                    r = "To love beauty is to see light.";
                    w = "Victor Hugo";
                    break;
                case 678:
                    r = "Concision in style, precision in thought, decision in life.";
                    w = "Victor Hugo";
                    break;
                case 679:
                    r = "Short as life is, we make it still shorter by the careless waste of time.";
                    w = "Victor Hugo";
                    break;
                case 680:
                    r = "One believes others will do what he will do to himself.";
                    w = "Victor Hugo";
                    break;
                case 681:
                    r = "Wisdom is a sacred communion.";
                    w = "Victor Hugo";
                    break;
                case 682:
                    r = "A person often meets his destiny on the road he took to avoid it.";
                    w = "Jean de La Fontaine";
                    break;
                case 683:
                    r = "By the work one knows the workman.";
                    w = "Jean de La Fontaine";
                    break;
                case 684:
                    r = "There is no road of flowers leading to glory.";
                    w = "Jean de La Fontaine";
                    break;
                case 685:
                    r = "Everyone calls himself a friend, but only a fool relies on it; nothing is commoner than the name, nothing rarer than the thing.";
                    w = "Jean de La Fontaine";
                    break;
                case 686:
                    r = "People who make no noise are dangerous.";
                    w = "Jean de La Fontaine";
                    break;
                case 687:
                    r = "The strongest passion is fear.";
                    w = "Jean de La Fontaine";
                    break;
                case 688:
                    r = "Abused patience turns to fury.";
                    w = "Thomas Fuller";
                    break;
                case 689:
                    r = "If money didn't exist, would you still chase the same dream?";
                    w = "";
                    break;
                case 690:
                    r = "Never be satisfied, and always push yourself. Do the things people say cannot be done.";
                    w = "";
                    break;
                case 691:
                    r = "Do not waste the present with the past, which has no future.";
                    w = "";
                    break;
                case 692:
                    r = "In the end, it's not the years in your life that count. It's the life in your years.";
                    w = "Abraham Lincoln";
                    break;
                case 693:
                    r = "Give me six hours to chop down a tree and I will spend the first four sharpening the axe.";
                    w = "Abraham Lincoln";
                    break;
                case 694:
                    r = "I'm a slow walker, but I never walk back.";
                    w = "Abraham Lincoln";
                    break;
                case 695:
                    r = "Comparison is the thief of joy.";
                    w = "";
                    break;
                case 696:
                    r = "If you hesitate between me and another person, don't choose me";
                    w = "";
                    break;
                case 697:
                    r = "Words are but pictures of our thoughts.";
                    w = "John Dryden";
                    break;
                case 698:
                    r = "Stop saying I wish, start saying I will";
                    w = "";
                    break;
                case 699:
                    r = "Its all about which way you look.";
                    w = "";
                    break;
                case 700:
                    r = "You need a miracle.";
                    w = "";
                    break;
                case 701:
                    r = "When was the last time you did something for the first time?";
                    w = "";
                    break;
                case 702:
                    r = "Live each day as if you will live forever.";
                    w = "";
                    break;
                case 703:
                    r = "Walking is man's best medicine.";
                    w = "Hippocrates";
                    break;
                case 704:
                    r = "Healing is a matter of time, but it is sometimes also a mater of opportunity.";
                    w = "Hippocrates";
                    break;
                case 705:
                    r = "Don't make time for someone who doesn't make time for you.";
                    w = "";
                    break;
                case 706:
                    r = "It's never too late to start over. If you weren't happy with yesterday, try something different today. Don't stay stuck. Do better.";
                    w = "";
                    break;
                case 707:
                    r = "No-one dances if they dont know whos singing.";
                    w = "";
                    break;
                case 708:
                    r = "When the wagon flips, roads plenty.";
                    w = "Bulgarian proverb";
                    break;
                case 709:
                    r = "What would I do if this was my last day on earth?";
                    w = "";
                    break;
                case 710:
                    r = "Don't take life so seriously. It isn't permanent.";
                    w = "";
                    break;
                case 711:
                    r = "Put all your eggs in one basket and then watch that basket.";
                    w = "Mark Twain";
                    break;
                case 712:
                    r = "Old ways won't open new doors.";
                    w = "";
                    break;
                case 713:
                    r = "No one's really keeping track of how many times you screw up!";
                    w = "";
                    break;
                case 714:
                    r = "Don't wait until you've reached your goal to be proud of yourself. Be proud of yourself every step of the way.";
                    w = "";
                    break;
                case 715:
                    r = "Patience is key, a wait short or long will have its reward.";
                    w = "";
                    break;
                case 716:
                    r = "Pray as though everything depended on God. Work as though everything depended on you.";
                    w = "Saint Augustine";
                    break;
                case 717:
                    r = "The world is a book, and those who do not travel read only a page.";
                    w = "Saint Augustine";
                    break;
                case 718:
                    r = "Faith is to believe what you do not see; the reward of this faith is to see what you believe.";
                    w = "Saint Augustine";
                    break;
                case 719:
                    r = "To live is to change, and to be perfect is to have changed often.";
                    w = "John Henry Newman";
                    break;
                case 720:
                    r = "Give me six hours to chop down a tree and I will spend the first four sharpening the axe.";
                    w = "Abraham Lincoln";
                    break;
                case 721:
                    r = "In the end, it's not the years in your life that count. It's the life in your years.";
                    w = "Abraham Lincoln";
                    break;
                case 722:
                    r = "Be sure you put your feet in the right place, then stand firm.";
                    w = "Abraham Lincoln";
                    break;
                case 723:
                    r = "Whatever you are, be a good one. ";
                    w = "Abraham Lincoln";
                    break;
                case 724:
                    r = "No bird soars too high if he soars with his own wings.";
                    w = "William Blake";
                    break;
                case 725:
                    r = "Great things are done when men and mountains meet.";
                    w = "William Blake";
                    break;
                case 726:
                    r = "You never know what is enough unless you know what is more than enough.";
                    w = "William Blake";
                    break;
                case 727:
                    r = "What is now proved was once only imagined.";
                    w = "William Blake";
                    break;
                case 728:
                    r = "The road of excess leads to the palace of wisdom.";
                    w = "William Blake";
                    break;
                case 729:
                    r = "If you don't know where you are going, any road will get you there.";
                    w = "Lewis Carroll";
                    break;
                case 730:
                    r = "If you want a thing done well, do it yourself.";
                    w = "Napoleon Bonaparte";
                    break;
                case 731:
                    r = "Rule your mind or it will rule you.";
                    w = "Horace";
                    break;
                case 732:
                    r = "He who feared that he would not succeed sat still.";
                    w = "Horace";
                    break;
                case 733:
                    r = "Even as we speak, time speeds swiftly away.";
                    w = "Horace";
                    break;
                case 734:
                    r = "He will always be a slave who does not know how to live upon a little.";
                    w = "Horace";
                    break;
                case 735:
                    r = "What we read with pleasure we read again with pleasure.";
                    w = "Horace";
                    break;
                case 736:
                    r = "Subdue your passion or it will subdue you.";
                    w = "Horace";
                    break;
                case 737:
                    r = "Remember when life's path is steep to keep your mind even.";
                    w = "Horace";
                    break;
                case 738:
                    r = "If you wish people to weep, you must weep first.";
                    w = "Horace";
                    break;
                case 739:
                    r = "I am always doing what I cannot do yet, in order to learn how to do it.";
                    w = "Vincent van Gogh";
                    break;
                case 740:
                    r = "We never understand how little we need in this world until we know the loss of it.";
                    w = "James M. Barrie";
                    break;
                case 741:
                    r = "An artist cannot fail; it is a success to be one.";
                    w = "Charles Horton Cooley";
                    break;
                case 742:
                    r = "I am not what I think I am, and I am not what you think I am. I am what I think you think I am.";
                    w = "Charles Horton Cooley";
                    break;
                case 743:
                    r = "Opportunity is missed by most people because it is dressed in overalls and looks like work.";
                    w = "Thomas A. Edison";
                    break;
                case 744:
                    r = "Our greatest weakness lies in giving up. The most certain way to succeed is always to try just one more time.";
                    w = "Thomas A. Edison";
                    break;
                case 745:
                    r = "There is far more opportunity than there is ability.";
                    w = "Thomas A. Edison";
                    break;
                case 746:
                    r = "If you want to be loved, be lovable.";
                    w = "Ovid";
                    break;
                case 747:
                    r = "Anger cannot be dishonest.";
                    w = "Marcus Aurelius";
                    break;
                case 748:
                    r = "Quit while you're ahead. All the best gamblers do.";
                    w = "Baltasar Gracian";
                    break;
                case 749:
                    r = "When desire dies, fear is born.";
                    w = "Baltasar Gracian";
                    break;
                case 750:
                    r = "Love is the beauty of the soul.";
                    w = "Saint Augustine";
                    break;
                case 751:
                    r = "Clothes make the man. Naked people have little or no influence on society.";
                    w = "Mark Twain";
                    break;
                case 752:
                    r = "Name the greatest of all inventors. Accident.";
                    w = "Mark Twain";
                    break;
                case 753:
                    r = "All you need in this life is ignorance and confidence; then success is sure.";
                    w = "Mark Twain";
                    break;
                case 754:
                    r = "Reality can be beaten with enough imagination.";
                    w = "Mark Twain";
                    break;
                case 755:
                    r = "I've had a lot of worries in my life, most of which never happened.";
                    w = "Mark Twain";
                    break;
                case 756:
                    r = "A half-truth is the most cowardly of lies.";
                    w = "Mark Twain";
                    break;
                case 757:
                    r = "Worrying is like paying a debt you don't owe.";
                    w = "Mark Twain";
                    break;
                case 758:
                    r = "A successful book is not made of what is in it, but what is left out of it.";
                    w = "Mark Twain";
                    break;
                case 759:
                    r = "The lack of money is the root of all evil.";
                    w = "Mark Twain";
                    break;
                case 760:
                    r = "Comparison is the death of joy.";
                    w = "Mark Twain";
                    break;
                case 761:
                    r = "The older I get, the more clearly I remember things that never happened.";
                    w = "Mark Twain";
                    break;
                case 762:
                    r = "It's easy to make friends, but hard to get rid of them.";
                    w = "Mark Twain";
                    break;
                case 763:
                    r = "Age is an issue of mind over matter. If you don’t mind, it doesn’t matter.";
                    w = "Mark Twain";
                    break;
                case 764:
                    r = "";
                    w = "";
                    break;
                case 765:
                    r = "";
                    w = "";
                    break;
                case 766:
                    r = "";
                    w = "";
                    break;
                case 767:
                    r = "";
                    w = "";
                    break;
                case 768:
                    r = "";
                    w = "";
                    break;
                case 769:
                    r = "";
                    w = "";
                    break;
                case 770:
                    r = "A bad beginning makes a bad ending.";
                    w = "Chinese proverb";
                    break;
                case 771:
                    r = "Pain is a powerful motivator.";
                    w = "";
                    break;
                case 772:
                    r = "Rather fail with honor than succeed by fraud.";
                    w = "Sophocles";
                    break;
                case 773:
                    r = "There is no success without hardship.";
                    w = "Sophocles";
                    break;
                case 774:
                    r = "Best to live lightly, unthinkingly.";
                    w = "Sophocles";
                    break;
                case 775:
                    r = "Always desire to learn something useful.";
                    w = "Sophocles";
                    break;
                case 776:
                    r = "There is no greater evil than anarchy.";
                    w = "Sophocles";
                    break;
                case 777:
                    r = "A word does not frighten the man who, in acting, feels no fear.";
                    w = "Sophocles";
                    break;
                case 778:
                    r = "Much wisdom often goes with fewest words.";
                    w = "Sophocles";
                    break;
                case 779:
                    r = "Wisdom is the supreme part of happiness.";
                    w = "Sophocles";
                    break;
                case 780:
                    r = "Much speech is one thing, well-timed speech is another.";
                    w = "Sophocles";
                    break;
                case 781:
                    r = "Hide nothing, for time, which sees all and hears all, exposes all.";
                    w = "Sophocles";
                    break;
                case 782:
                    r = "Success is dependent on effort.";
                    w = "Sophocles";
                    break;
                case 783:
                    r = "To him who is in fear everything rustles.";
                    w = "Sophocles";
                    break;
                case 784:
                    r = "Old age and the passage of time teach all things.";
                    w = "Sophocles";
                    break;
                case 785:
                    r = "Isn't it the sweetest mockery to mock our enemies?";
                    w = "Sophocles";
                    break;
                case 786:
                    r = "A human being is only breath and shadow.";
                    w = "Sophocles";
                    break;
                case 787:
                    r = "No enemy is worse than bad advice.";
                    w = "Sophocles";
                    break;
                case 788:
                    r = "Not all things are to be discovered; many are better concealed.";
                    w = "Sophocles";
                    break;
                case 789:
                    r = "Fortune cannot aid those who do nothing.";
                    w = "Sophocles";
                    break;
                case 790:
                    r = "Silence is an ornament for women.";
                    w = "Sophocles";
                    break;
                case 791:
                    r = "Better not to exist than live basely.";
                    w = "Sophocles";
                    break;
                case 792:
                    r = "Evil counsel travels fast.";
                    w = "Sophocles";
                    break;
                case 793:
                    r = "I put my heart and my soul into my work, and have lost my mind in the process.";
                    w = "Vincent Van Gogh";
                    break;
                case 794:
                    r = "For my part I know nothing with any certainty, but the sight of the stars makes me dream.";
                    w = "Vincent Van Gogh";
                    break;
                case 795:
                    r = "I often think that the night is more alive and more richly colored than the day.";
                    w = "Vincent Van Gogh";
                    break;
                case 796:
                    r = "If you hear a voice within you say 'you cannot paint,' then by all means paint, and that voice will be silenced.";
                    w = "Vincent Van Gogh";
                    break;
                case 797:
                    r = "The way to know life is to love many things.";
                    w = "Vincent Van Gogh";
                    break;
                case 798:
                    r = "One must work and dare if one really wants to live.";
                    w = "Vincent Van Gogh";
                    break;
                case 799:
                    r = "Conscience is a man's compass.";
                    w = "Vincent Van Gogh";
                    break;
                case 800:
                    r = "Patience is bitter, but its fruit is sweet.";
                    w = "Jean-Jacques Rousseau";
                    break;
                case 801:
                    r = "I go to nature to be soothed and healed, and to have my senses put in order.";
                    w = "John Burroughs";
                    break;
                case 802:
                    r = "Know thy self, know thy enemy. A thousand battles, a thousand victories.";
                    w = "Sun Tzu";
                    break;
                case 803:
                    r = "Man was born to be rich, or inevitably to grow rich, through the use of his faculties.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 804:
                    r = "A man only learns in two ways, one by reading, and the other by association with smarter people.";
                    w = "Will Rogers";
                    break;
                case 805:
                    r = "Fortune and love befriend the bold.";
                    w = "Ovid";
                    break;
                case 806:
                    r = "Happy people have no history";
                    w = "Leo Tolstoy";
                    break;
                case 807:
                    r = "A bird in the hand is worth than two in the bush.";
                    w = "Chinese proverb";
                    break;
                case 808:
                    r = "A candle lights others and consumes itself.";
                    w = "Chinese proverb";
                    break;
                case 809:
                    r = "A man can do no more than he can.";
                    w = "Chinese proverb";
                    break;
                case 810:
                    r = "A friend in need is a friend indeed.";
                    w = "Chinese proverb";
                    break;
                case 811:
                    r = "He knows most who speaks least.";
                    w = "Chinese proverb";
                    break;
                case 812:
                    r = "When you are in Rome, do as the Romans do.";
                    w = "Chinese proverb";
                    break;
                case 813:
                    r = "A good fame is better than a good face.";
                    w = "Chinese proverb";
                    break;
                case 814:
                    r = "A smile can erase a million worries.";
                    w = "Chinese proverb";
                    break;
                case 815:
                    r = "Disaster emanates from a careless talk.";
                    w = "Chinese proverb";
                    break;
                case 816:
                    r = "The early bird catches the worm.";
                    w = "Chinese proverb";
                    break;
                case 817:
                    r = "No pains, no gains.";
                    w = "Chinese proverb";
                    break;
                case 818:
                    r = "Never try to prove what nobody doubts.";
                    w = "Chinese proverb";
                    break;
                case 819:
                    r = "Take things as they come.";
                    w = "Chinese proverb";
                    break;
                case 820:
                    r = "A single spark can start a prairie fire.";
                    w = "Chinese proverb";
                    break;
                case 821:
                    r = "Learn from past mistakes to avoid future ones.";
                    w = "Chinese proverb";
                    break;
                case 822:
                    r = "What's done cannot be undone.";
                    w = "Chinese proverb";
                    break;
                case 823:
                    r = "It is hard to please everyone.";
                    w = "Chinese proverb";
                    break;
                case 824:
                    r = "Every step leaves its print; work steadily and make solid progress.";
                    w = "Chinese proverb";
                    break;
                case 825:
                    r = "One radish, one hole. Each has his own task, and nobody is dispensable.";
                    w = "Chinese proverb";
                    break;
                case 826:
                    r = "A day’s planning is done in the morning.";
                    w = "Chinese proverb";
                    break;
                case 827:
                    r = "Do well and have well.";
                    w = "Chinese proverb";
                    break;
                case 828:
                    r = "When a mute person eats dumplings, he knows how many he has eaten, even though he cannot speak.";
                    w = "Chinese proverb";
                    break;
                case 829:
                    r = "A person leaves a reputation, bad or good, behind wherever he works or stays.";
                    w = "Chinese proverb";
                    break;
                case 830:
                    r = "A word spoken can never be taken back.";
                    w = "Chinese proverb";
                    break;
                case 831:
                    r = "Silence is true wisdom's best reply.";
                    w = "Euripides";
                    break;
                case 832:
                    r = "Great works are performed not by strength but by perseverance.";
                    w = "Samuel Johnson";
                    break;
                case 833:
                    r = "The difficulty in life is the choice.";
                    w = "George A. Moore";
                    break;
                case 834:
                    r = "Be kind, for everyone you meet is fighting a harder battle.";
                    w = "Plato";
                    break;
                case 835:
                    r = "A wise man should have money in his head, but not in his heart.";
                    w = "Jonathan Swift";
                    break;
                case 836:
                    r = "The strong man is strongest when alone.";
                    w = "Friedrich Schiller";
                    break;
                case 837:
                    r = "Eternity: a moment standing still for ever.";
                    w = "James Montgomery";
                    break;
                case 838:
                    r = "All the forces in the world are not so powerful as an idea whose time has come.";
                    w = "Victor Hugo";
                    break;
                case 839:
                    r = "To love another person is to see the face of God.";
                    w = "Victor Hugo";
                    break;
                case 840:
                    r = "Habit is the nursery of errors.";
                    w = "Victor Hugo";
                    break;
                case 841:
                    r = "It is by suffering that human beings become angels.";
                    w = "Victor Hugo";
                    break;
                case 842:
                    r = "Pain is as diverse as man. One suffers as one can.";
                    w = "Victor Hugo";
                    break;
                case 843:
                    r = "People do not lack strength; they lack will.";
                    w = "Victor Hugo";
                    break;
                case 844:
                    r = "What you seek, seeks you.";
                    w = "";
                    break;
                case 845:
                    r = "Don't cling to a mistake just because you spent a lot of time making it.";
                    w = "";
                    break;
                case 846:
                    r = "Your best days are yet to come.";
                    w = "";
                    break;
                case 847:
                    r = "";
                    w = "";
                    break;
                case 848:
                    r = "";
                    w = "";
                    break;
                case 849:
                    r = "You only live once!";
                    w = "";
                    break;
                case 850:
                    r = "The soul seeks comprany.";
                    w = "";
                    break;
                case 851:
                    r = "If the doors of perception were cleansed everything would appear to man as it is, Infinite.";
                    w = "William Blake";
                    break;
                case 852:
                    r = "Before you diagnose yourself with depression or low self-esteem, make sure that you’re not surrounded by fools.";
                    w = "Sigmund Freud";
                    break;
                case 853:
                    r = "The scope of one’s personality is defined by the magnitude of that problem which is capable of driving a person out of his wits.";
                    w = "Sigmund Freud";
                    break;
                case 854:
                    r = "Everything that you do in bed is perfectly and absolutely acceptable. If only both sides enjoyed it.";
                    w = "Sigmund Freud";
                    break;
                case 855:
                    r = "A complete absence of sex is the only thing which can be properly considered sexual deviance. Everything else is just a matter of taste.";
                    w = "Sigmund Freud";
                    break;
                case 856:
                    r = "At that moment when a person starts to seriously ponder the meaning and value of life, you can consider him a madman.";
                    w = "Sigmund Freud";
                    break;
                case 857:
                    r = "The first person to throw an insult instead of a stone was the founder of civilisation.";
                    w = "Sigmund Freud";
                    break;
                case 858:
                    r = "Ideal, eternal love, purged of all hatred, exists only between the addict and his drug.";
                    w = "Sigmund Freud";
                    break;
                case 859:
                    r = "The more perfect a person is on the outside, the more demons they have on the inside.";
                    w = "Sigmund Freud";
                    break;
                case 860:
                    r = "When people criticise me, I know how to defend myself. But I’m powerless in the face of praise.";
                    w = "Sigmund Freud";
                    break;
                case 861:
                    r = "We are never so vulnerable as when we love, and never so hopelessly unhappy as when we lose the object of our love.";
                    w = "Sigmund Freud";
                    break;
                case 862:
                    r = "The first indication of stupidity is a complete lack of shame.";
                    w = "Sigmund Freud";
                    break;
                case 863:
                    r = "People are more moral than they think, and much more amoral than they imagine.";
                    w = "Sigmund Freud";
                    break;
                case 864:
                    r = "A large part of what is real within us is not comprehended; and that which is comprehended is not real.";
                    w = "Sigmund Freud";
                    break;
                case 865:
                    r = "I don't care that they stole my idea.. I care that they don't have any of their own";
                    w = "Nikola Tesla";
                    break;
                case 866:
                    r = "In order for the light to shine so brightly, the darkness must be present.";
                    w = "Francis Bacon";
                    break;
                case 867:
                    r = "The worst men often give the best advice.";
                    w = "Francis Bacon";
                    break;
                case 868:
                    r = "Friends are thieves of time.";
                    w = "Francis Bacon";
                    break;
                case 869:
                    r = "Money is a great servant but a bad master.";
                    w = "Francis Bacon";
                    break;
                case 870:
                    r = "If a man will begin with certainties, he shall end in doubts; but if he will be content to begin with doubts, he shall end in certainties.";
                    w = "Francis Bacon";
                    break;
                case 871:
                    r = "Hope is a good breakfast, but it is a bad supper.";
                    w = "Francis Bacon";
                    break;
                case 872:
                    r = "A wise man will make more opportunities than he finds.";
                    w = "Francis Bacon";
                    break;
                case 873:
                    r = "Wonder is the seed of knowledge.";
                    w = "Francis Bacon";
                    break;
                case 874:
                    r = "The job of the artist is always to deepen the mystery.";
                    w = "Francis Bacon";
                    break;
                case 875:
                    r = "The less people speak of their greatness, the more we think of it.";
                    w = "Francis Bacon";
                    break;
                case 876:
                    r = "Correction does much, but encouragement does more.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 877:
                    r = "While we are postponing, life speeds by.";
                    w = "Lucius Annaeus Seneca";
                    break;
                case 878:
                    r = "The doer alone learneth.";
                    w = "Friedrich Nietzsche";
                    break;
                case 879:
                    r = "A loving heart is the beginning of all knowledge.";
                    w = "Thomas Carlyle";
                    break;
                case 880:
                    r = "Our happiness depends on wisdom all the way.";
                    w = "Sophocles";
                    break;
                case 881:
                    r = "Learning to trust is one of life's most difficult tasks.";
                    w = "Isaac Watts";
                    break;
                case 882:
                    r = "It is in men as in soils where sometimes there is a vein of gold which the owner knows not.";
                    w = "Jonathan Swift";
                    break;
                case 883:
                    r = "For success, attitude is equally as important as ability.";
                    w = "Walter Scott";
                    break;
                case 884:
                    r = "Without a struggle, there can be no progress.";
                    w = "Frederick Douglass";
                    break;
                case 885:
                    r = "";
                    w = "";
                    break;
                case 886:
                    r = "Be not a slave of words.";
                    w = "Thomas Carlyle";
                    break;
                case 887:
                    r = "It is not length of life, but depth of life.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 888:
                    r = "Beauty without expression is boring.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 889:
                    r = "What then is freedom? The power to live as one wishes.";
                    w = "Marcus Tullius Cicero";
                    break;
                case 890:
                    r = "To rule is easy, to govern difficult.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 891:
                    r = "Never find fault with the absent.";
                    w = "Alexander Pope";
                    break;
                case 892:
                    r = "A quiet mind cureth all.";
                    w = "Robert Burton";
                    break;
                case 893:
                    r = "Golf is a good walk spoiled.";
                    w = "Mark Twain";
                    break;
                case 894:
                    r = "Knowing is not enough; we must apply. Willing is not enough; we must do.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 895:
                    r = "The world is full of magic things, patiently waiting for our senses to grow sharper.";
                    w = "William Butler Yeats";
                    break;
                case 896:
                    r = "Life is a long preparation for something that never happens.";
                    w = "William Butler Yeats";
                    break;
                case 897:
                    r = "There is another world, but it is in this one.";
                    w = "William Butler Yeats";
                    break;
                case 898:
                    r = "In dreams begin responsibilities.";
                    w = "William Butler Yeats";
                    break;
                case 899:
                    r = "Do not wait to strike till the iron is hot; but make it hot by striking.";
                    w = "William Butler Yeats";
                    break;
                case 900:
                    r = "One loyal friend is worth ten thousand relatives.";
                    w = "Euripides";
                    break;
                case 901:
                    r = "The greatest remedy for anger is delay.";
                    w = "Lucius Annaeus Seneca";
                    break;
                case 902:
                    r = "True happiness is... to enjoy the present, without anxious dependence upon the future.";
                    w = "Lucius Annaeus Seneca";
                    break;
                case 903:
                    r = "If one does not know to which port one is sailing, no wind is favorable.";
                    w = "Lucius Annaeus Seneca";
                    break;
                case 904:
                    r = "It is a rough road that leads to the heights of greatness.";
                    w = "Lucius Annaeus Seneca";
                    break;
                case 905:
                    r = "Nothing is a waste of time if you use the experience wisely.";
                    w = "Auguste Rodin";
                    break;
                case 906:
                    r = "To begin, begin.";
                    w = "William Wordsworth";
                    break;
                case 907:
                    r = "All the gold which is under or upon the earth is not enough to give in exchange for virtue.";
                    w = "Plato";
                    break;
                case 908:
                    r = "Never cut what you can untie.";
                    w = "Joseph Joubert";
                    break;
                case 909:
                    r = "We have two ears and one mouth so that we can listen twice as much as we speak.";
                    w = "Epictetus";
                    break;
                case 910:
                    r = "Time is the fairest and toughest judge.";
                    w = "Edgar Quinet";
                    break;
                case 911:
                    r = "The excellence of a gift lies in its appropriateness rather than in its value.";
                    w = "Charles Dudley Warner";
                    break;
                case 912:
                    r = "Those who don't know history are destined to repeat it.";
                    w = "Edmund Burke";
                    break;
                case 913:
                    r = "The only thing necessary for the triumph of evil is for good men to do nothing.";
                    w = "Edmund Burke";
                    break;
                case 914:
                    r = "Our patience will achieve more than our force.";
                    w = "Edmund Burke";
                    break;
                case 915:
                    r = "Good order is the foundation of all things.";
                    w = "Edmund Burke";
                    break;
                case 916:
                    r = "Why does the eye see a thing more clearly in dreams than the imagination when awake?";
                    w = "Leonardo da Vinci";
                    break;
                case 917:
                    r = "The actions of men are the best interpreters of their thoughts.";
                    w = "James Joyce";
                    break;
                case 918:
                    r = "The eyes are the window to your soul.";
                    w = "William Shakespeare";
                    break;
                case 919:
                    r = "Your future is created by what you do today, not tomorrow.";
                    w = "";
                    break;
                case 920:
                    r = "The poor, the unsuccessful, the unhappy, the unhealthy are the ones who use the word tomorrow the most.";
                    w = "";
                    break;
                case 921:
                    r = "";
                    w = "";
                    break;
                case 922:
                    r = "Do today what you want for your tomorrows.";
                    w = "";
                    break;
                case 923:
                    r = "Tomorrows only exist in the minds of dreamers and losers.";
                    w = "";
                    break;
                case 924:
                    r = "The only difference between a rich person and poor person is how they use their time.";
                    w = "";
                    break;
                case 925:
                    r = "Who will you fall asleep with, tonight?";
                    w = "";
                    break;
                case 926:
                    r = "I dwell in possibility.";
                    w = "Emily Dickinson";
                    break;
                case 927:
                    r = "It's better to be a warrior in a garden than a gardener in a war.";
                    w = "Chinese proverb";
                    break;
                case 928:
                    r = "It is the simple things in life you have to find happiness in.";
                    w = "";
                    break;
                case 929:
                    r = "So close, yet so far away.";
                    w = "";
                    break;
                case 930:
                    r = "Have you purchased anything life-changing recently?";
                    w = "";
                    break;
                case 931:
                    r = "If you want to know how rich you are, find out how many things you have that money can't buy.";
                    w = "";
                    break;
                case 932:
                    r = "Man must rise above the Earth, to the top of the clouds and beyond, for only thus will he fully understand the world in which he lives.";
                    w = "Socrates";
                    break;
                case 933:
                    r = "Don't chase money, chase happiness.";
                    w = "";
                    break;
                case 934:
                    r = "Life is like a glass of juice, it is all about how you make it.";
                    w = "";
                    break;
                case 935:
                    r = "If you want to know where your heart is, look where your mind goes when it wanders!";
                    w = "";
                    break;
                case 936:
                    r = "You don’t know when to quit.";
                    w = "";
                    break;
                case 937:
                    r = "That feeling when you don't even know what you're feeling";
                    w = "";
                    break;
                case 938:
                    r = "If you don’t make a step forward, you will always be in the same place.";
                    w = "";
                    break;
                case 939:
                    r = "Lead by example.";
                    w = "";
                    break;
                case 940:
                    r = "What is done in love, is done well.";
                    w = "Vincent Van Gogh";
                    break;
                case 941:
                    r = "Nothing ventured, nothing gained.";
                    w = "";
                    break;
                case 942:
                    r = "The only easy day... was yesterday.";
                    w = "";
                    break;
                case 943:
                    r = "Nothing lasts forever.";
                    w = "";
                    break;
                case 944:
                    r = "When you are two people at the same time, one of them is bound to trip the other.";
                    w = "";
                    break;
                case 945:
                    r = "Announcing your plans makes you less motivated to accomplish them.";
                    w = "";
                    break;
                case 946:
                    r = "Someone's opinion of you, does not have to become your reality.";
                    w = "";
                    break;
                case 947:
                    r = "A single tree cannot make a forest.";
                    w = "";
                    break;
                case 948:
                    r = "Happiness is achieved when you stop waiting for it and make the most of the moment you're in right now.";
                    w = "";
                    break;
                case 949:
                    r = "I hope something great happens to you today.";
                    w = "";
                    break;
                case 950:
                    r = "A habit cannot be tossed out the window; it must be coaxed down the stairs a step at a time.";
                    w = "Mark Twain";
                    break;
                case 951:
                    r = "Keep away from people who try to belittle your ambitions. Small people always do that, but the really great make you feel that you, too, can become great.";
                    w = "Mark Twain";
                    break;
                case 952:
                    r = "A lie can travel half way around the world while the truth is putting on its shoes.";
                    w = "Mark Twain";
                    break;
                case 953:
                    r = "To succeed in life, you need two things: ignorance and confidence.";
                    w = "Mark Twain";
                    break;
                case 954:
                    r = "I've lived through some terrible things in my life, some of which actually happened.";
                    w = "Mark Twain";
                    break;
                case 955:
                    r = "Never put off till tomorrow what you can do the day after tomorrow just as well.";
                    w = "Mark Twain";
                    break;
                case 956:
                    r = "The man who carries a cat by the tail learns something that can be learned in no other way.";
                    w = "Mark Twain";
                    break;
                case 957:
                    r = "The worst loneliness is to not be comfortable with yourself.";
                    w = "Mark Twain";
                    break;
                case 958:
                    r = "The antidote for fifty enemies is one friend.";
                    w = "Aristotle";
                    break;
                case 959:
                    r = "Keep your friends close and your enemies closer.";
                    w = "";
                    break;
                case 960:
                    r = "There's always a third way!";
                    w = "";
                    break;
                case 961:
                    r = "There are all kinds of love in this world but never the same love twice.";
                    w = "F. Scott Fitzgerald";
                    break;
                case 962:
                    r = "I suppose sometimes life can scare you back into living.";
                    w = "";
                    break;
                case 963:
                    r = "It's hard changing your life.";
                    w = "";
                    break;
                case 964:
                    r = "Rough times don’t come to stay, they come to pass.";
                    w = "";
                    break;
                case 965:
                    r = "Work on your dreams.";
                    w = "";
                    break;
                case 966:
                    r = "Oh hey, I'm just here waiting for a miracle to happen. How about you?";
                    w = "";
                    break;
                case 967:
                    r = "Everything will come your way";
                    w = "";
                    break;
                case 968:
                    r = "Freedom is having nothing.";
                    w = "";
                    break;
                case 969:
                    r = "Fear of death is what keeps us alive.";
                    w = "";
                    break;
                case 970:
                    r = "Honest feelings and bad timing make the most painful combination.";
                    w = "";
                    break;
                case 971:
                    r = "Gambling is the devils game.";
                    w = "";
                    break;
                case 972:
                    r = "And those who were seen dancing were thought to be insane by those who could not hear the music.";
                    w = "Friedrich Nietzsche";
                    break;
                case 973:
                    r = "should have, would have ... didn’t";
                    w = "";
                    break;
                case 974:
                    r = "Our greatest glory is not in never falling, but in getting up every time we do.";
                    w = "Confucius";
                    break;
                case 975:
                    r = "He who learns but does not think, is lost. He who thinks but does not learn is in great danger.";
                    w = "Confucius";
                    break;
                case 976:
                    r = "He that would perfect his work must first sharpen his tools.";
                    w = "Confucius";
                    break;
                case 977:
                    r = "If you look into your own heart, and you find nothing wrong there, what is there to worry about? What is there to fear?";
                    w = "Confucius";
                    break;
                case 978:
                    r = "By three methods we may learn wisdom: First, by reflection, which is noblest; Second, by imitation, which is easiest; and third by experience, which is the bitterest.";
                    w = "Confucius";
                    break;
                case 979:
                    r = "If you make a mistake and do not correct it, this is called a mistake.";
                    w = "Confucius";
                    break;
                case 980:
                    r = "The man who moves a mountain begins by carrying away small stones.";
                    w = "Confucius";
                    break;
                case 981:
                    r = "Study the past if you would define the future.";
                    w = "Confucius";
                    break;
                case 982:
                    r = "To be wronged is nothing, unless you continue to remember it.";
                    w = "Confucius";
                    break;
                case 983:
                    r = "You cannot open a book without learning something.";
                    w = "Confucius";
                    break;
                case 984:
                    r = "Attack the evil that is within yourself, rather than attacking the evil that is in others.";
                    w = "Confucius";
                    break;
                case 985:
                    r = "The man who asks a question is a fool for a minute, the man who does not ask is a fool for life.";
                    w = "Confucius";
                    break;
                case 986:
                    r = "The gem cannot be polished without friction, nor man perfected without trials.";
                    w = "Confucius";
                    break;
                case 987:
                    r = "Forget injuries, never forget kindnesses.";
                    w = "Confucius";
                    break;
                case 988:
                    r = "A lion chased me up a tree, and I greatly enjoyed the view from the top.";
                    w = "Confucius";
                    break;
                case 989:
                    r = "Your best is yet to come.";
                    w = "";
                    break;
                case 990:
                    r = "Life is for living.";
                    w = "";
                    break;
                case 991:
                    r = "What I am looking for is a blessing not in disguise.";
                    w = "Jerome K. Jerome";
                    break;
                case 992:
                    r = "You need a little bit of insanity to do great things.";
                    w = "";
                    break;
                case 993:
                    r = "If they spit at you behind your back, it means you're ahead of them.";
                    w = "";
                    break;
                case 994:
                    r = "Man begins to worry because he worries that he has nothing to worry about.";
                    w = "Buddha";
                    break;
                case 995:
                    r = "Never regret a day in your life: good days give happiness, bad days give experience, worst days give lessons, and best days give memories.";
                    w = "";
                    break;
                case 996:
                    r = "Live your dream.";
                    w = "";
                    break;
                case 997:
                    r = "Most of the problems in your life are due to two reasons: you act without thinking, or think without acting.";
                    w = "";
                    break;
                case 998:
                    r = "People tend to value memories more than actual people. Sometimes you miss the memories, not the actual person.";
                    w = "";
                    break;
                case 999:
                    r = "Almost every successful person begins with two beliefs: the future can be better than the present and I have the power to make it so.";
                    w = "";
                    break;
                case 1000:
                    r = "Your hardest times often lead to the greatest moments of your life. Keep the faith. It will all be worth it in the end.";
                    w = "";
                    break;
                case 1001:
                    r = "Don’t be afraid of death, be afraid of an unlived life.";
                    w = "";
                    break;
                case 1002:
                    r = "When you’re right, no one remembers. When you’re wrong, no one forgets.";
                    w = "";
                    break;
                case 1003:
                    r = "The price of inaction is far greater than the cost of making a mistake.";
                    w = "Meister Eckhart";
                    break;
                case 1004:
                    r = "Don’t let yourself be controlled by three things: people, money, or past experiences.";
                    w = "";
                    break;
                case 1005:
                    r = "They always come back. Especially when you've moved on.";
                    w = "";
                    break;
                case 1006:
                    r = "Don't settle.";
                    w = "";
                    break;
                case 1007:
                    r = "There are decades where nothing happens; and there are weeks where decades happen.";
                    w = "Vladimir Ilyich Lenin";
                    break;
                case 1008:
                    r = "The experimenter who does not know what he is looking for will not understand what he finds.";
                    w = "Claude Bernard";
                    break;
                case 1009:
                    r = "It is what we know already that often prevents us from learning.";
                    w = "Claude Bernard";
                    break;
                case 1010:
                    r = "Man can learn nothing except by going from the known to the unknown.";
                    w = "Claude Bernard";
                    break;
                case 1011:
                    r = "Joy is not in things; it is in us.";
                    w = "Richard Wagner";
                    break;
                case 1012:
                    r = "Imagination creates reality.";
                    w = "Richard Wagner";
                    break;
                case 1013:
                    r = "Once you eliminate the impossible, whatever remains, no matter how improbable, must be the truth.";
                    w = "Arthur Conan Doyle";
                    break;
                case 1014:
                    r = "Each day provides its own gifts.";
                    w = "Marcus Aurelius";
                    break;
                case 1015:
                    r = "Our life is what our thoughts make it.";
                    w = "Marcus Aurelius";
                    break;
                case 1016:
                    r = "When we try to pick out anything by itself, we find it hitched to everything else in the universe.";
                    w = "John Muir";
                    break;
                case 1017:
                    r = "Evil is whatever distracts.";
                    w = "Franz Kafka";
                    break;
                case 1018:
                    r = "Dreams must be heeded and accepted. For a great many of them come true.";
                    w = "Paracelsus";
                    break;
                case 1019:
                    r = "Poison is in everything, and no thing is without poison. The dosage makes it either a poison or a remedy. ";
                    w = "Paracelsus";
                    break;
                case 1020:
                    r = "Travel makes a wise man better, and a fool worse.";
                    w = "Thomas Fuller";
                    break;
                case 1021:
                    r = "Choose a wife rather by your ear than your eye.";
                    w = "Thomas Fuller";
                    break;
                case 1022:
                    r = "Great hopes make great men.";
                    w = "Thomas Fuller";
                    break;
                case 1023:
                    r = "We are born crying, live complaining, and die disappointed.";
                    w = "Thomas Fuller";
                    break;
                case 1024:
                    r = "There is more pleasure in loving than in being beloved.";
                    w = "Thomas Fuller";
                    break;
                case 1025:
                    r = "If you have one true friend you have more than your share.";
                    w = "Thomas Fuller";
                    break;
                case 1026:
                    r = "One cannot think well, love well, sleep well, if one has not dined well.";
                    w = "Virginia Woolf";
                    break;
                case 1027:
                    r = "First appearance deceives many.";
                    w = "Ovid";
                    break;
                case 1028:
                    r = "Genius is the ability to renew one's emotions in daily experience.";
                    w = "Paul Cezanne";
                    break;
                case 1029:
                    r = "The world doesn't understand me and I don't understand the world, that's why I've withdrawn from it.";
                    w = "Paul Cezanne";
                    break;
                case 1030:
                    r = "Calmness is the cradle of power.";
                    w = "Josiah Gilbert Holland";
                    break;
                case 1031:
                    r = "God gives every bird its food, but He does not throw it into its nest.";
                    w = "Josiah Gilbert Holland";
                    break;
                case 1032:
                    r = "If it were not for hopes, the heart would break.";
                    w = "Thomas Fuller";
                    break;
                case 1033:
                    r = "Compliments cost nothing, yet many pay dear for them.";
                    w = "Thomas Fuller";
                    break;
                case 1034:
                    r = "Despair gives courage to a coward.";
                    w = "Thomas Fuller";
                    break;
                case 1035:
                    r = "The devil lies brooding in the miser's chest";
                    w = "Thomas Fuller";
                    break;
                case 1036:
                    r = "Be happy with what you have and are, be generous with both, and you won't have to hunt for happiness.";
                    w = "William E. Gladstone";
                    break;
                case 1037:
                    r = "Sex and sleep alone make me conscious that I am mortal.";
                    w = "Alexander the Great";
                    break;
                case 1038:
                    r = "When we give someone our time, we actually give a portion of our life that we will never take back.";
                    w = "Alexander the Great";
                    break;
                case 1039:
                    r = "I am indebted to my father for living, but to my teacher for living well.";
                    w = "Alexander the Great";
                    break;
                case 1040:
                    r = "The true secret of happiness lies in taking a genuine interest in all the details of daily life.";
                    w = "William Morris";
                    break;
                case 1041:
                    r = "Have nothing in your house that you do not know to be useful, or believe to be beautiful.";
                    w = "William Morris";
                    break;
                case 1042:
                    r = "Slow and steady wins the race.";
                    w = "";
                    break;
                case 1043:
                    r = "Adopt the pace of nature: her secret is patience.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 1044:
                    r = "Doubt whom you will, but never yourself.";
                    w = "Christian Nestell Bovee";
                    break;
                case 1045:
                    r = "Life is a long lesson in humility.";
                    w = "James M. Barrie";
                    break;
                case 1046:
                    r = "Men fail much oftener from want of perseverance than from want of talent.";
                    w = "William Cobbett";
                    break;
                case 1047:
                    r = "Please your eye and plague your heart. ";
                    w = "William Cobbett";
                    break;
                case 1048:
                    r = "Happiness, or misery, is in the mind. It is the mind that lives. ";
                    w = "William Cobbett";
                    break;
                case 1049:
                    r = "A penny saved is a penny earned.";
                    w = "Benjamin Franklin";
                    break;
                case 1050:
                    r = "A place for everything, everything in its place.";
                    w = "Benjamin Franklin";
                    break;
                case 1051:
                    r = "Well done is better than well said.";
                    w = "Benjamin Franklin";
                    break;
                case 1052:
                    r = "Even if you're on the right track, you'll get run over if you just sit there.";
                    w = "Will Rogers";
                    break;
                case 1053:
                    r = "Everything is funny, as long as it's happening to somebody else.";
                    w = "Will Rogers";
                    break;
                case 1054:
                    r = "Do the best you can, and don't take life too serious.";
                    w = "Will Rogers";
                    break;
                case 1055:
                    r = "";
                    w = "";
                    break;
                case 1056:
                    r = "My motto is: Contented with little, yet wishing for more.";
                    w = "Charles Lamb";
                    break;
                case 1057:
                    r = "Let us live for the beauty of our own reality.";
                    w = "Charles Lamb";
                    break;
                case 1058:
                    r = "Lose an hour in the morning, and you will spend all day looking for it.";
                    w = "Richard Whately";
                    break;
                case 1059:
                    r = "Take time to deliberate; but when the time for action arrives, stop thinking and go in.";
                    w = "Andrew Jackson";
                    break;
                case 1060:
                    r = "No man ever steps in the same river twice, for it's not the same river and he's not the same man.";
                    w = "Heraclitus";
                    break;
                case 1061:
                    r = "There is nothing permanent except change. ";
                    w = "Heraclitus";
                    break;
                case 1062:
                    r = "Big results require big ambitions.";
                    w = "Heraclitus";
                    break;
                case 1063:
                    r = "Combine the extremes, and you will have the true center.";
                    w = "Karl Wilhelm Friedrich Schlegel";
                    break;
                case 1064:
                    r = "Learn to... be what you are, and learn to resign with a good grace all that you are not.";
                    w = "Henri Frederic Amiel";
                    break;
                case 1065:
                    r = "Most people have never learned that one of the main aims in life is to enjoy it.";
                    w = "Samuel Butler";
                    break;
                case 1066:
                    r = "It is better to have loved and lost than never to have lost at all.";
                    w = "Samuel Butler";
                    break;
                case 1067:
                    r = "Man lives by imagination.";
                    w = "Havelock Ellis";
                    break;
                case 1068:
                    r = "Genius is one percent inspiration and ninety-nine percent perspiration.";
                    w = "Thomas A. Edison";
                    break;
                case 1069:
                    r = "A friend in power is a friend lost.";
                    w = "Henry Adams";
                    break;
                case 1070:
                    r = "Harmony makes small things grow, lack of it makes great things decay.";
                    w = "Sallust";
                    break;
                case 1071:
                    r = "Fortune favors the prepared mind.";
                    w = "Louis Pasteur";
                    break;
                case 1072:
                    r = "Dreams will get you nowhere, a good kick in the pants will take you a long way.";
                    w = "Baltasar Gracian";
                    break;
                case 1073:
                    r = "Lord, grant that I might not so much seek to be loved as to love.";
                    w = "Francis of Assisi";
                    break;
                case 1074:
                    r = "Nobody made a greater mistake than he who did nothing because he could do only a little.";
                    w = "Edmund Burke";
                    break;
                case 1075:
                    r = "Defeat is not the worst of failures. Not to have tried is the true failure.";
                    w = "George Edward Woodberry";
                    break;
                case 1076:
                    r = "The secret of getting things done is to act!";
                    w = "Dante Alighieri";
                    break;
                case 1077:
                    r = "The past always looks better than it was. It's only pleasant because it isn't here.";
                    w = "Finley Peter Dunne";
                    break;
                case 1078:
                    r = "The more we do, the more we can do.";
                    w = "William Hazlitt";
                    break;
                case 1079:
                    r = "Fear makes us feel our humanity.";
                    w = "Benjamin Disraeli";
                    break;
                case 1080:
                    r = "The hardest thing is to take less when you can get more.";
                    w = "Kin Hubbard";
                    break;
                case 1081:
                    r = "Patience is the support of weakness; impatience the ruin of strength.";
                    w = "Charles Caleb Colton";
                    break;
                case 1082:
                    r = "Read in order to live.";
                    w = "Gustave Flaubert";
                    break;
                case 1083:
                    r = "Who sows virtue reaps honor.";
                    w = "Leonardo da Vinci";
                    break;
                case 1084:
                    r = "To forget oneself is to be happy.";
                    w = "Robert Louis Stevenson";
                    break;
                case 1085:
                    r = "A wise man never loses anything, if he has himself.";
                    w = "Michel de Montaigne";
                    break;
                case 1086:
                    r = "Absence - that common cure of love.";
                    w = "Lord Byron";
                    break;
                case 1087:
                    r = "The things that we love tell us what we are.";
                    w = "Thomas Aquinas";
                    break;
                case 1088:
                    r = "Nothing is worth more than this day.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 1089:
                    r = "Our life always expresses the result of our dominant thoughts.";
                    w = "Soren Kierkegaard";
                    break;
                case 1090:
                    r = "There is little success where there is little laughter.";
                    w = "Andrew Carnegie";
                    break;
                case 1091:
                    r = "'Tis better to have loved and lost than never to have loved at all.";
                    w = "Alfred Lord Tennyson";
                    break;
                case 1092:
                    r = "If you look for perfection, you'll never be content.";
                    w = "Leo Tolstoy";
                    break;
                case 1093:
                    r = "If you want to be happy, be.";
                    w = "Leo Tolstoy";
                    break;
                case 1094:
                    r = "Everything you’ve ever wanted is on the other side of fear.";
                    w = "George Addair";
                    break;
                case 1095:
                    r = "You always admire what you really don't understand.";
                    w = "Blaise Pascal";
                    break;
                case 1096:
                    r = "Act as if what you do makes a difference. It does.";
                    w = "William James";
                    break;
                case 1097:
                    r = "The greatest weapon against stress is our ability to choose one thought over another.";
                    w = "William James";
                    break;
                case 1098:
                    r = "There is no disguise which can hide love for long where it exists, or simulate it where it does not.";
                    w = "Francois de La Rochefoucauld";
                    break;
                case 1099:
                    r = "On earth there is no heaven, but there are pieces of it.";
                    w = "Jules Renard";
                    break;
                case 1100:
                    r = "Who, being loved, is poor?";
                    w = "Oscar Wilde";
                    break;
                case 1101:
                    r = "When you go in search of honey you must expect to be stung by bees.";
                    w = "Joseph Joubert";
                    break;
                case 1102:
                    r = "Think in the morning. Act in the noon. Eat in the evening. Sleep in the night.";
                    w = "William Blake";
                    break;
                case 1103:
                    r = "Well-ordered self-love is right and natural.";
                    w = "Thomas Aquinas";
                    break;
                case 1104:
                    r = "what is done in love is well done.";
                    w = "Vincent Van Gogh";
                    break;
                case 1105:
                    r = "The sadness will last forever.";
                    w = "Vincent Van Gogh";
                    break;
                case 1106:
                    r = "The fishermen know that the sea is dangerous and the storm terrible, but they have never found these dangers sufficient reason for remaining ashore.";
                    w = "Vincent Van Gogh";
                    break;
                case 1107:
                    r = "I am seeking, I am striving, I am in it with all my heart.";
                    w = "Vincent Van Gogh";
                    break;
                case 1108:
                    r = "Be clearly aware of the stars and infinity on high. Then life seems almost enchanted after all.";
                    w = "Vincent Van Gogh";
                    break;
                case 1109:
                    r = "Always hope but never expect.";
                    w = "";
                    break;
                case 1110:
                    r = "When looking back doesn’t interest you anymore, you’re doing something right.";
                    w = "";
                    break;
                case 1111:
                    r = "There are no facts, only interpretations.";
                    w = "Friedrich Nietzsche";
                    break;
                case 1112:
                    r = "You weren't born to just pay bills and die.";
                    w = "";
                    break;
                case 1113:
                    r = "You never knew exactly how much space you occupied in people's lives.";
                    w = "F. Scott Fitzgerald";
                    break;
                case 1114:
                    r = "The loneliest moment in someone’s life is when they are watching their whole world fall apart, and all they can do is stare blankly.";
                    w = "F. Scott Fitzgerald";
                    break;
                case 1115:
                    r = "The fool doth think he is wise, but the wise man knows himself to be a fool.";
                    w = "William Shakespeare";
                    break;
                case 1116:
                    r = "The fault, dear Brutus, is not in our stars, but in ourselves.";
                    w = "William Shakespeare";
                    break;
                case 1117:
                    r = "Hell is empty and all the devils are here.";
                    w = "William Shakespeare";
                    break;
                case 1118:
                    r = "If I were to kiss you then go to hell, I would. So then I can brag with the devils I saw heaven without ever entering it.";
                    w = "William Shakespeare";
                    break;
                case 1119:
                    r = "I like this place and could willingly waste my time in it.";
                    w = "William Shakespeare";
                    break;
                case 1120:
                    r = "Stars, hide your fires; Let not light see my black and deep desires.";
                    w = "William Shakespeare";
                    break;
                case 1121:
                    r = "Though this be madness, yet there is method in't.";
                    w = "William Shakespeare";
                    break;
                case 1122:
                    r = "To weep is to make less the depth of grief.";
                    w = "William Shakespeare";
                    break;
                case 1123:
                    r = "Expectation is the root of all heartache.";
                    w = "William Shakespeare";
                    break;
                case 1124:
                    r = "Listen to many, speak to a few.";
                    w = "William Shakespeare";
                    break;
                case 1125:
                    r = "In time we hate that which we often fear.";
                    w = "William Shakespeare";
                    break;
                case 1126:
                    r = "What's done cannot be undone.";
                    w = "William Shakespeare";
                    break;
                case 1127:
                    r = "Wisely and slow; they stumble that run fast.";
                    w = "William Shakespeare";
                    break;
                case 1128:
                    r = "What's past is prologue.";
                    w = "William Shakespeare";
                    break;
                case 1129:
                    r = "Some are born great, others achieve greatness.";
                    w = "William Shakespeare";
                    break;
                case 1130:
                    r = "Love is a smoke made with the fume of sighs.";
                    w = "William Shakespeare";
                    break;
                case 1131:
                    r = "Be great in act, as you have been in thought.";
                    w = "William Shakespeare";
                    break;
                case 1132:
                    r = "For she had eyes and chose me.";
                    w = "William Shakespeare";
                    break;
                case 1133:
                    r = "Exit, pursued by a bear.";
                    w = "William Shakespeare";
                    break;
                case 1134:
                    r = "Don't think, just do.";
                    w = "Horace";
                    break;
                case 1135:
                    r = "You can't cross the sea merely by standing and staring at the water.";
                    w = "Rabindranath Tagore";
                    break;
                case 1136:
                    r = "Always bear in mind that your own resolution to succeed is more important than any other.";
                    w = "Abraham Lincoln";
                    break;
                case 1137:
                    r = "There are no strangers here; Only friends you haven't yet met.";
                    w = "William Butler Yeats";
                    break;
                case 1138:
                    r = "One never notices what has been done; one can only see what remains to be done.";
                    w = "Marie Curie";
                    break;
                case 1139:
                    r = "Modesty is the conscience of the body.";
                    w = "Honore de Balzac";
                    break;
                case 1140:
                    r = "The heart has its reasons of which reason knows nothing.";
                    w = "Blaise Pascal";
                    break;
                case 1141:
                    r = "A great man is always willing to be little.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 1142:
                    r = "I am not afraid of storms for I am learning how to sail my ship.";
                    w = "Louisa May Alcott";
                    break;
                case 1143:
                    r = "God gave us the gift of life; it is up to us to give ourselves the gift of living well.";
                    w = "Voltaire";
                    break;
                case 1144:
                    r = "The only normal people are the ones you don't know very well.";
                    w = "Alfred Adler";
                    break;
                case 1145:
                    r = "Blessed are they who see beautiful things in humble places where other people see nothing.";
                    w = "Camille Pissarro";
                    break;
                case 1146:
                    r = "It is absurd to look for perfection.";
                    w = "Camille Pissarro";
                    break;
                case 1147:
                    r = "All mankind love a lover.";
                    w = "Ralph Waldo Emerson";
                    break;
                case 1148:
                    r = "Fake it utill you become it";
                    w = "";
                    break;
                case 1149:
                    r = "Trust the vibes you get, energy doesn’t lie.";
                    w = "";
                    break;
                case 1150:
                    r = "It is not only fine feathers that make fine birds.";
                    w = "Aesop";
                    break;
                case 1151:
                    r = "Not on one strand are all life's jewels strung.";
                    w = "William Morris";
                    break;
                case 1152:
                    r = "";
                    w = "";
                    break;
                case 1153:
                    r = "Work is a necessary evil to be avoided.";
                    w = "Mark Twain";
                    break;
                case 1154:
                    r = "Don't think, just do.";
                    w = "Horace";
                    break;
                case 1155:
                    r = "If it excites you and scares you at the same time, it might be a good thing to try.";
                    w = "";
                    break;
                case 1156:
                    r = "Don't let people know too much about you.";
                    w = "";
                    break;
                case 1157:
                    r = "The sun is new each day.";
                    w = "Heraclitus";
                    break;
                case 1158:
                    r = "Where the senses fail us, reason must step in.";
                    w = "Galileo Galilei";
                    break;
                case 1159:
                    r = "And yet it moves.";
                    w = "Galileo Galilei";
                    break;
                case 1160:
                    r = "I have never met a man so ignorant that I couldn't learn something from him.";
                    w = "Galileo Galilei";
                    break;
                case 1161:
                    r = "All grand thoughts come from the heart.";
                    w = "Luc de Clapiers";
                    break;
                case 1162:
                    r = "If the highest aim of a captain were to preserve his ship, he would keep it in port forever.";
                    w = "Thomas Aquinas";
                    break;
                case 1163:
                    r = "Sorrow can be alleviated by good sleep, a bath and a glass of wine. ";
                    w = "Thomas Aquinas";
                    break;
                case 1164:
                    r = "Kindness is the language which the deaf can hear and the blind can see.";
                    w = "Mark Twain";
                    break;
                case 1165:
                    r = "To one who has faith, no explanation is necessary. To one without faith, no explanation is possible.";
                    w = "Thomas Aquinas";
                    break;
                case 1166:
                    r = "Mistakes are proof that you are trying.";
                    w = "";
                    break;
                case 1167:
                    r = "Where words fail, music speaks.";
                    w = "Hans Christian Andersen";
                    break;
                case 1168:
                    r = "A year changes you a lot.";
                    w = "";
                    break;
                case 1169:
                    r = "He who throws dirt is loosing ground.";
                    w = "";
                    break;
                case 1170:
                    r = "Good luck is result of good planning.";
                    w = "";
                    break;
                case 1171:
                    r = "A metaphor could save your life.";
                    w = "";
                    break;
                case 1172:
                    r = "Put your mind into planning today. Look into the future.";
                    w = "";
                    break;
                case 1173:
                    r = "Never complain and never explain.";
                    w = "Benjamin Disraeli";
                    break;
                case 1174:
                    r = "Whosoever is delighted in solitude is either a wild beast or a god.";
                    w = "Aristotle";
                    break;
                case 1175:
                    r = "Breathe in peace, breathe out love.";
                    w = "";
                    break;
                case 1176:
                    r = "Silence is the mother of truth.";
                    w = "Benjamin Disraeli";
                    break;
                case 1177:
                    r = "The secret of success is constancy to purpose.";
                    w = "Benjamin Disraeli";
                    break;
                case 1178:
                    r = "Little things affect little minds.";
                    w = "Benjamin Disraeli";
                    break;
                case 1179:
                    r = "I am prepared for the worst, but hope for the best.";
                    w = "Benjamin Disraeli";
                    break;
                case 1180:
                    r = "Change is inevitable. Change is constant.";
                    w = "Benjamin Disraeli";
                    break;
                case 1181:
                    r = "Never apologize for showing feeling. When you do so, you apologize for the truth.";
                    w = "Benjamin Disraeli";
                    break;
                case 1182:
                    r = "Collect moments not things.";
                    w = "";
                    break;
                case 1183:
                    r = "Everything you want is on the other side of fear.";
                    w = "";
                    break;
                case 1184:
                    r = "People don't notice whether it's winter or summer when they're happy.";
                    w = "Anton Chekhov";
                    break;
                case 1185:
                    r = "Of all lies, art is the least untrue.";
                    w = "Gustave Flaubert";
                    break;
                case 1186:
                    r = "The soul that sees beauty may sometimes walk alone.";
                    w = "Johann Wolfgang von Goethe";
                    break;
                case 1187:
                    r = "At the touch of love everyone becomes a poet.";
                    w = "Plato";
                    break;
                case 1188:
                    r = "Change in all things is sweet.";
                    w = "Aristotle";
                    break;
                case 1189:
                    r = "There are no rules of architecture for a castle in the clouds.";
                    w = "Gilbert K. Chesterton";
                    break;
                case 1190:
                    r = "If your hate could be turned into electricity, it would light up the whole world.";
                    w = "Nikola Tesla";
                    break;
                case 1191:
                    r = "Be alone, that is the secret of invention; be alone, that is when ideas are born.";
                    w = "Nikola Tesla";
                    break;
                case 1192:
                    r = "I do not think you can name many great inventions that have been made by married men.";
                    w = "Nikola Tesla";
                    break;
                case 1193:
                    r = "One must be sane to think clearly, but one can think deeply and be quite insane.";
                    w = "Nikola Tesla";
                    break;
                case 1194:
                    r = "If you only knew the magnificence of the 3, 6 and 9, then you would have the key to the universe.";
                    w = "Nikola Tesla";
                    break;
                case 1195:
                    r = "You cannot believe in God until you believe in yourself.";
                    w = "Swami Vivekananda";
                    break;
                case 1196:
                    r = "Saying nothing... sometimes says the most.";
                    w = "Emily Dickinson";
                    break;
                case 1197:
                    r = "Look back, and smile on perils past.";
                    w = "Walter Scott";
                    break;
                case 1198:
                    r = "Nearly all men can stand adversity, but if you want to test a man's character, give him power.";
                    w = "Abraham Lincoln";
                    break;
                case 1199:
                    r = "All happiness depends on courage and work.";
                    w = "Honore de Balzac";
                    break;
                case 1200:
                    r = "The greatest pleasure of life is love.";
                    w = "Euripides";
                    break;
                case 1201:
                    r = "Even a stopped clock is right twice a day.";
                    w = "Marie von Ebner-Eschenbach";
                    break;
                case 1202:
                    r = "Where thou art, that is home.";
                    w = "Emily Dickinson";
                    break;
                case 1203:
                    r = "Measure what is measurable, and make measurable what is not so.";
                    w = "Galileo Galilei";
                    break;
                case 1204:
                    r = "Experience is one thing you can't get for nothing.";
                    w = "Oscar Wilde";
                    break;
                case 1205:
                    r = "The purpose of all wars, is peace.";
                    w = "Saint Augustine";
                    break;
                case 1206:
                    r = "You broke my cookie!";
                    w = "";
                    break;
                case 1207:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1208:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1209:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1210:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1211:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1212:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1213:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1214:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1215:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1216:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1217:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1218:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1219:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1220:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1221:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1222:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1223:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1224:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1225:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1226:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1227:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1228:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1229:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1230:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1231:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1232:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1233:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1234:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1235:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1236:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1237:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1238:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1239:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1240:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1241:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1242:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1243:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1244:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1245:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1246:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1247:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1248:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1249:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1250:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1251:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1252:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1253:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1254:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1255:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1256:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1257:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1258:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1259:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1260:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1261:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1262:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1263:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1264:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1265:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1266:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1267:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1268:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1269:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1270:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1271:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1272:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1273:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1274:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1275:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1276:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1277:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1278:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1279:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1280:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1281:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1282:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1283:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1284:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1285:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1286:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1287:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1288:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1289:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1290:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1291:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1292:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1293:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1294:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1295:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1296:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1297:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1298:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1299:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1300:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1301:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1302:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1303:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1304:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1305:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1306:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1307:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1308:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1309:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1310:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1311:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1312:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1313:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1314:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1315:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1316:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1317:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1318:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1319:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1320:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1321:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1322:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1323:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1324:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1325:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1326:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1327:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1328:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1329:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1330:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1331:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1332:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1333:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1334:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1335:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1336:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1337:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1338:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1339:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1340:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1341:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1342:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1343:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1344:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1345:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1346:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1347:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1348:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1349:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1350:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1351:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1352:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1353:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1354:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1355:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1356:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1357:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1358:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
                case 1359:
                    r = "asdasdasd";
                    w = "asdasdasd";
                    break;
            }
        }
    }
}

