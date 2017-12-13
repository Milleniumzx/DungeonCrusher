using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonCrusher
{
    class Tile
    {
        public Texture2D Texture;


        public Tile(Texture2D texture)
        {
            Texture = texture;
        }
    }
}
