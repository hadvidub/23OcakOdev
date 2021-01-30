using System;
using System.Collections.Generic;
using System.Text;

namespace _23OcakOdev
{
    class GameManager : IGame
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu hesabınıza eklendi",game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} oyunu hesabınızdan silindi",game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} oyunu hesabınızda güncellendi", game.GameName);
        }
    }
}
