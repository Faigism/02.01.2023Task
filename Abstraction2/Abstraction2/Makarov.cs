using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    internal class Makarov :Gun, Igun,Ifireable
    {
        public Makarov(int capacity):base(capacity)
        {

        }
        int _currentmagazine;
        int _magazinecapacity;
        public int MagazineCapacity
        {
            get => _magazinecapacity;
        }
        public int CurrentMagazine
        {
            get=> _currentmagazine;
            set => _currentmagazine = value;
        }
        
        public void Fire()
        {
            if (_currentmagazine > 0)
                _currentmagazine--;
        }

        public void ReloadMagazine()
        {
            _currentmagazine = _magazinecapacity;
        }
    }
}
