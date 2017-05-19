using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fortune
{
    public class FortuneRepository : IFortuneRepository
    {
        private static Dictionary<int, Fortune> fortunes = new Dictionary<int, Fortune>();

        public FortuneRepository()
        {
            fortunes.Add(1, new Fortune("Two days from now, tomorrow will be yesterday"));
            fortunes.Add(2, new Fortune("You will find a thing. It may be important"));
            fortunes.Add(3, new Fortune("The best year-round temperature is a warm heart and a cool head"));
            fortunes.Add(4, new Fortune("Don’t panic"));
            fortunes.Add(5, new Fortune("He who dies with most toys, still dies"));
            fortunes.Add(6, new Fortune("This fortune no good. Try another"));
            fortunes.Add(7, new Fortune("You will read this and say “Geez! I could come up with better fortunes than that"));
            fortunes.Add(8, new Fortune("Don’t eat any Chinese food today or you’ll be sick"));
            fortunes.Add(9, new Fortune("You cannot love life until you live the life you love"));
            fortunes.Add(10, new Fortune("Never give up. You're not a failure if you don't give up"));
        }

        public Task<Fortune> GetAsync(int fortuneId)
        {
            var task = Task.Factory.StartNew<Fortune>(() => { return fortunes[fortuneId]; });
            return task;
        }
    }
}
