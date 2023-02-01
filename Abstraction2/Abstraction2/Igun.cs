using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    internal interface Igun
    {
        int MagazineCapacity { get;}
        int CurrentMagazine { get; set; }

        void ReloadMagazine();
    }
}
