using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BallGame
{
    class Sprite
    {
        public Texture2D texture;  // 2D 紋理圖
        public Vector2 position;   // 2D 紋理圖 的位置
        public Vector2 velocity = Vector2.Zero;   // 2D 紋理圖 的位移速度
        public Vector2 size;
        public bool isAlive = false;

        public Sprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            this.size.X = texture.Width;
            this.size.Y = texture.Height;
        }

        public bool isInside(Vector2 screenSize)
        {
            // 右緣 碰到 視窗右邊了
            if (position.X + texture.Width + velocity.X > screenSize.X)
                return false;

            // 下緣 碰到 視窗底邊了
            if (position.Y + texture.Height + velocity.Y > screenSize.Y)
                return false;

            // 左緣 碰到 視窗左邊了
            if (position.X + velocity.X < 0)
                return false;

            // 上緣 碰到 視窗上邊了
            if (position.Y + velocity.Y < 0)
                return false;
            return true;
        }

        // 移動
        public void Move(Vector2 screenSize)
        {
            // 右緣 碰到 視窗右邊了
            if (position.X + size.X + velocity.X > screenSize.X)
                velocity.X = -velocity.X;

            // 下緣 碰到 視窗底邊了
            if (position.Y + size.Y + velocity.Y > screenSize.Y)
                velocity.Y = -velocity.Y;

            // 左緣 碰到 視窗左邊了
            if (position.X + velocity.X < 0)
                velocity.X = -velocity.X;

            // 上緣 碰到 視窗上邊了
            if (position.Y + velocity.Y < 0)
                velocity.Y = -velocity.Y;

            position += velocity;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
