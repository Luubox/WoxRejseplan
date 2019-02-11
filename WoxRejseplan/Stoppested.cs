using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoxRejseplan
{
    public class Stoppested
    {
        private int _stopId;
        private string _stopName;
        private int _stopCoordX;
        private int _stopCoordY;

        public int StopId { get => _stopId; set => _stopId = value; }
        public string StopName { get => _stopName; set => _stopName = value; }
        public int StopCoordX { get => _stopCoordX; set => _stopCoordX = value; }
        public int StopCoordY { get => _stopCoordY; set => _stopCoordY = value; }

        public Stoppested(int stopId, string stopName, int stopCoordX, int stopCoordY)
        {
            _stopId = stopId;
            _stopName = stopName;
            _stopCoordX = stopCoordX;
            _stopCoordY = stopCoordY;
        }
    }
}
