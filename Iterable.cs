using System;

namespace Metodologías
{
    public interface Iterable
    {
        void primero();
        void siguiente();
        bool fin();
        Iterable actual();
    }
}