using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace BallGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Sprite playerSprite;
        const int MAX_MISSILES = 5, MAX_ENEMIES = 3;
        Sprite[] missileSprites = new Sprite[MAX_MISSILES];
        Sprite[] enemySprites = new Sprite[MAX_ENEMIES];
        Vector2 screenSize;
        Texture2D playerTexture, enemyTexture, missileTexture;
        KeyboardState previousKeyboardState = Keyboard.GetState();
        bool isGameOver = false;
        Random random = new Random();
        SpriteFont font;
        int score = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            screenSize = new Vector2(graphics.GraphicsDevice.Viewport.Width, graphics.GraphicsDevice.Viewport.Height);
            playerTexture = Content.Load<Texture2D>("player");
            enemyTexture = Content.Load<Texture2D>("enemy");
            missileTexture = Content.Load<Texture2D>("missile");

            playerSprite = new Sprite(playerTexture, new Vector2(300, 400));
            playerSprite.size.Y = 140;
            for (int i = 0; i < MAX_MISSILES; i++)
            {
                missileSprites[i] = new Sprite(missileTexture, new Vector2(0, 0));
                missileSprites[i].isAlive = false;
            }
            for (int i = 0; i < MAX_ENEMIES; i++)
            {
                enemySprites[i] = new Sprite(enemyTexture, randomEnemyXY());
                enemySprites[i].velocity = new Vector2(random.Next(-5, 5), random.Next(-5, 5));
                enemySprites[i].isAlive = false;
            }

            font = Content.Load<SpriteFont>("SpriteFont");
            base.LoadContent();
        }

        public Vector2 randomEnemyXY() 
        {
           int enemyX = random.Next(0, (int) (screenSize.X-100) );
           int enemyY = random.Next(0);
           return new Vector2(enemyX, enemyY);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            if (isGameOver) return;
#if !XBOX
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))  playerSprite.velocity = new Vector2(-5, 0);
            if (keyboardState.IsKeyDown(Keys.Right)) playerSprite.velocity = new Vector2(5, 0);
            if (keyboardState.IsKeyDown(Keys.Up)) playerSprite.velocity = new Vector2(0, -5);
            if (keyboardState.IsKeyDown(Keys.Down)) playerSprite.velocity = new Vector2(0, 5);
            if (keyboardState.IsKeyDown(Keys.Space) && previousKeyboardState.IsKeyUp(Keys.Space))
            {
                float x = playerSprite.position.X + playerTexture.Width/2 - missileTexture.Width/2;
                float y = playerSprite.position.Y;
                fireMissile(x, y);
            }
            previousKeyboardState = keyboardState;
#endif
            Rectangle playerRect = new Rectangle((int)playerSprite.position.X + 20, (int)playerSprite.position.Y + 20,
                                                 playerTexture.Width-40, playerTexture.Height/2);
            foreach (Sprite enemy in enemySprites) 
            {
                if (!enemy.isAlive)
                {
                    enemy.isAlive = true;
                    enemy.position = randomEnemyXY();
                }

                enemy.Move(screenSize);
                Rectangle enemyRect = new Rectangle((int) enemy.position.X+20, (int) enemy.position.Y+20, 
                                                    enemyTexture.Width-40, enemyTexture.Height-40);
                if (enemyRect.Intersects(playerRect))
                    isGameOver = true;

                foreach (Sprite missile in missileSprites)
                {
                    if (missile.isInside(screenSize))
                        missile.Move(screenSize);
                    else
                        missile.isAlive = false;

                    if (missile.isAlive)
                    {
                        Rectangle missileRect = new Rectangle((int) missile.position.X, (int) missile.position.Y, 
                                                              missileTexture.Width, missileTexture.Height);
                        if (missileRect.Intersects(enemyRect))
                        {
                            enemy.isAlive = false;
                            score ++;
                        }
                    }
                }
            }
            
            playerSprite.Move(screenSize);

            base.Update(gameTime);
        }

        public void fireMissile(float x, float y)
        {
            foreach (Sprite missile in missileSprites)
            {
                if (!missile.isAlive)
                {
                    missile.isAlive = true;
                    missile.position = new Vector2(x, y);
                    missile.velocity = new Vector2(0, -5);
                    return;
                }
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteBlendMode.AlphaBlend);
            playerSprite.draw(spriteBatch);
            foreach (Sprite enemy in enemySprites)
                enemy.draw(spriteBatch);
            foreach (Sprite missile in missileSprites)
            {
                if (missile.isAlive)
                    missile.draw(spriteBatch);
            }
            spriteBatch.DrawString(font, String.Format("Score:{0}", score), new Vector2(10, 10), Color.Black);
            if (isGameOver)
                spriteBatch.DrawString(font, "Game Over!", new Vector2(screenSize.X / 2, screenSize.Y / 2), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
