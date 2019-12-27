﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Line : Coord
    {
        public override int X1 { get; set; }
        public override int X2 { get; set; }
        public override int Y1 { get; set; }
        public override int Y2 { get; set; }
        public EndObject firstEndObject;
        public EndObject lastEndObject;
        
        public Line(int x1, int y1, int x2, int y2, EndObject firstEndObject, EndObject lastEndObject)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            this.firstEndObject = firstEndObject;
            this.lastEndObject = lastEndObject;
        }
        protected override string showCoords()
        {
            return $"X1 = {X1}; Y1 = {Y1}\tX2 = {X2}; Y2 = {Y2}";
        }
        public string showLine()
        {
            return $"{showCoords()}\t {{{firstEndObject.getLineEnding()}; {lastEndObject.getLineEnding()}}}";
        }
    }
}
