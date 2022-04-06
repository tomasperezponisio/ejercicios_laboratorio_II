﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        // Atributos privados
        private int x;
        private int y;
        
        // Constructor
        public Punto(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        // Getters
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
    }


}
