using System;

namespace Metodolog�as
{
    public interface Iterable
    {
        void primero();
        void siguiente();
        bool fin();
        Iterable actual();
    }
}