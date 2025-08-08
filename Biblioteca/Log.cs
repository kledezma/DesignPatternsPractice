namespace Herramientas
{   
    //SINGLETON 
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        //Truquito para proteger la instancia en caso de tener dos hilos.
        private static object _lock = new object();
        public static Log GetInstance(string path) 
        {
            // Si un hilo esta trabajando la instancia, el lock bloquea el acceso a un nuevo hilo, quedando en espera.
            lock (_lock)
            {
                if( _instance == null)
                {
                    _instance = new Log(path);
                }
            }
            return _instance;
        }
        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}
