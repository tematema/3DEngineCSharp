﻿using System.Collections.Generic;

namespace OBJViewer
{
    class Polygon // Triangle (faces, грани)
    {
        public Vertex[] tri = new Vertex[3];

        public Polygon(List<Vertex> points, int a, int b, int c)
        {
            tri[0] = points[a-1]; // указатели на вершины
            tri[1] = points[b-1];
            tri[2] = points[c-1];
        }
    }
}