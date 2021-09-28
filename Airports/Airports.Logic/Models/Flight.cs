﻿using System;

namespace Airports.Logic.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public string Number { get; set; }
        public int SegmentId { get; set; }
        public Segment Segment { get; set; }
    }
}
