using GestaoRHConsole.Models;

namespace GestaoRHConsole.DAL
{
    class SingletonContext
    {
        private static Context _context;

        public static Context GetInstance()
        {
            if (_context == null)
            {
                _context = new Context();
            }
            return _context;
        }
    }
}
