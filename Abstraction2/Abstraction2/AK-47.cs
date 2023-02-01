using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    internal class AK_47 :Gun, Igun,Ifireable
    {
        public AK_47(int capacity):base(capacity)
        {

        }
        int _currentcapacity;
        int _magazinecapacity;
        public int MagazineCapacity
        {
            get => _magazinecapacity;
        }

        public int CurrentMagazine
        {
            get => _currentcapacity;
            set
            {
                if(_magazinecapacity>=value)
                    _currentcapacity= value;
            }
        }

        public void Fire()
        {
            if (_currentcapacity > 1)
                _currentcapacity -= 2;
        }

        public void ReloadMagazine()
        {
            _currentcapacity = _magazinecapacity;
        }
    }
}
