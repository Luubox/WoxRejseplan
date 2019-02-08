using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoxRejseplan
{
    class Stoppested
    {
        private int _stoppestedId;
        private string _stoppestedName;
        private int _stoppestedCoordX;
        private int _stoppestedCoordY;

        public int StoppestedId { get => _stoppestedId; set => _stoppestedId = value; }
        public string StoppestedName { get => _stoppestedName; set => _stoppestedName = value; }
        public int StoppestedCoordX { get => _stoppestedCoordX; set => _stoppestedCoordX = value; }
        public int StoppestedCoordY { get => _stoppestedCoordY; set => _stoppestedCoordY = value; }

        public Stoppested(int stoppestedId, string stoppestedName, int stoppestedCoordX, int stoppestedCoordY)
        {
            _stoppestedId = stoppestedId;
            _stoppestedName = stoppestedName;
            _stoppestedCoordX = stoppestedCoordX;
            _stoppestedCoordY = stoppestedCoordY;
        }
    }
}
