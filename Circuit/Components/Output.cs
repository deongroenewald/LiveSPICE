﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SyMath;

namespace Circuit
{
    [CategoryAttribute("IO")]
    [DisplayName("Output")]
    public class Output : PassiveTwoTerminal
    {
        public Output() { Name = "O1"; }

        public override void Analyze(ModifiedNodalAnalysis Mna)
        {
            i = Constant.Zero;
        }

        protected override void DrawSymbol(SymbolLayout Sym)
        {
            int y = 15;
            Sym.AddWire(Anode, new Coord(0, y));
            Sym.AddWire(Cathode, new Coord(0, -y));

            Sym.InBounds(new Coord(-10, 0), new Coord(10, 0));

            int w = 7;
            Sym.AddLine(EdgeType.Black, new Coord(-w, y), new Coord(w, y));
            Sym.DrawPositive(EdgeType.Black, new Coord(0, y - 4));
            Sym.AddLine(EdgeType.Black, new Coord(-w, -y), new Coord(w, -y));
            Sym.DrawNegative(EdgeType.Black, new Coord(0, -y + 4));

            Sym.DrawText(Name.ToString(), new Point(0, 0), Alignment.Center, Alignment.Center);
        }
    }
}

