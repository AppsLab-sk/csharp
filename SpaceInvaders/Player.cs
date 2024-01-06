using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Player
    {
        private void Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            else if (e.KeyCode == Keys.Space && game && !fired)
            {
                Missile();
                fired = true;
            }
        }
        private void Released(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                fired = false;
            }
        }
        private void PlayerMove(object sender, EventArgs e)
        {
            if (moveLeft && Player.Location.X >= 0)
            {
                Player.Left--;
            }
            else if (moveRight && Player.Location.X <= limit)
            {
                Player.Left++;
            }
        }
    }
}
