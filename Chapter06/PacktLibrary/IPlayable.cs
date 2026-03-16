using System;
using System.Collections.Generic;
using System.Text;

namespace PacktLibrary
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop() // default interface implementation
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}
