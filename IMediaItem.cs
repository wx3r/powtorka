using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorka
{
    public interface IMediaItem
    {
        public string Title { get; }
        public string Author { get; }

        public void DisplayInfo();
    }

}