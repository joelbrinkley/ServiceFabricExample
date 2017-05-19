using System;
using System.Threading.Tasks;

namespace Fortune
{
    public class FortuneTeller
    {
        private readonly ICrystalBall crystalBall;
        private readonly IFortuneRepository fortuneRepository;

        public FortuneTeller(ICrystalBall crystalBall, IFortuneRepository fortuneRepository)
        {
            this.crystalBall = crystalBall;
            this.fortuneRepository = fortuneRepository;
        }

        public async Task<Fortune> Tell()
        {
            var future = crystalBall.SeeTheFuture();
            var fortune = await fortuneRepository.GetAsync(future);
            return fortune;
        }
    }
}
