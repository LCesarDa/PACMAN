﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN
{
    public class Coins
    {
        public static byte[,] coin0 = new byte[,]
       {
          { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
          { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
          { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,3,3,3,3,3,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,3,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
          { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
       };

        public static byte[,] coin1 = new byte[,]
       {
          { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,3,3,3,3,3,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,1,3,1,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {2,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,2},
          {2,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,2},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
       };
        public static byte[,] coin2 = new byte[,]
       {
          { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
          { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
          { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,3,3,3,3,3,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,1,3,1,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,1},
          { 1,1,0,0,0,2,0,0,0,0,0,0,1,0,0,0,0,0,0,2,0,0,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 2,0,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,0,2},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,1,1},
          { 1,1,0,0,0,2,0,0,0,0,0,0,1,0,0,0,0,0,0,2,0,0,0,1,1},
          { 1,1,0,0,0,1,0,0,0,0,0,0,2,0,0,0,0,0,0,1,0,0,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,0,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,1,1},
          { 1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1},
          { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
          { 1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
          { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
       };
    }
}
