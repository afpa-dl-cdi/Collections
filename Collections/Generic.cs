namespace Collections
{
    class Generic <T>
    {
        private int _index = 0;
        const int TAILLEPARDEFAUT = 100;
        private T[] _data; 

        /// <summary>
        /// Constructeur général qui prend la taille par défaut
        /// </summary>
        public Generic()
        {
            _data = new T[TAILLEPARDEFAUT]; // use 'T' as the data type
        }

        /// <summary>
        ///  Constructeur permettant de redéfinir la taille du tableau 
        /// </summary>
        /// <param name="taille">Taille du tableau</param>
        public Generic( int taille)
        {
            _data = new T[taille];
        }

        /// <summary>
        /// Ajoute un élément
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            _data[_index++] = item;
        }

        /// <summary>
        /// Récupère un élément
        /// </summary>
        /// <returns></returns>
        public T Get(int position)
        {
            return _data[position];
        }


    }
}