using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palladino.src
{
    class LevelBuilder
    {
        /// <summary>
        /// Number of brick
        /// </summary>
        private static readonly int BRICK_NUMBER_Y = 6;
        private static readonly int BRICK_NUMBER_X = 10;

        //build the map between bricks in the board and coordinates
        private readonly Dictionary<GameObjectEmpty, KeyValuePair<int, int>> builderGrid = new Dictionary<GameObjectEmpty, KeyValuePair<int, int>>();
        //build the map between bricks in the show and in the grid and coordinates
        private Dictionary<KeyValuePair<int, int>, KeyValuePair<GameObjectEmpty, BrickBasic>> gameGrid = new Dictionary<KeyValuePair<int, int>, KeyValuePair<GameObjectEmpty, BrickBasic>>();

        private static readonly int BUILDERBRICKDIMY = 1;
        private static readonly int BUILDERBRICK_DIMX = 1;
        private static readonly int GAMEBRICK_DIMY = 1;
        private static readonly int GAMEBRICK_DIMX = 1;

        private string levelName;
        private BackgroundTexture background;
        private PersonalSounds music;
        private BallTexture ball;
        private PaddleTexture paddle;

        public LevelBuilder()
        {
            int currentXpos = 0;
            for (int i = 0; i < BRICK_NUMBER_X; i++)
            {
                int currentYpos = 0;
                for (int j = 0; j < BRICK_NUMBER_Y; j++)
                {
                    KeyValuePair<int, int> coordinates = new KeyValuePair<int, int>(i, j);
                    GameObjectEmpty objectEmpty = new GameObjectEmpty(new Position(currentXpos, currentYpos), BUILDERBRICKDIMY, BUILDERBRICK_DIMX);
                    builderGrid.Add(objectEmpty, coordinates);
                    currentYpos += BUILDERBRICKDIMY;
                }
                currentXpos += BUILDERBRICK_DIMX;
            }
            currentXpos = 0;
            for (int i = 0; i < BRICK_NUMBER_X; i++)
            {
                int currentYpos = 0;
                for (int j = 0; j < BRICK_NUMBER_Y; j++)
                {
                    KeyValuePair<int, int> coordinates = new KeyValuePair<int, int>(i, j);
                    GameObjectEmpty objectEmpty = new GameObjectEmpty(new Position(currentXpos, currentYpos), BUILDERBRICKDIMY, BUILDERBRICK_DIMX);
                    gameGrid.Add(coordinates, new KeyValuePair<GameObjectEmpty, BrickBasic>(objectEmpty, null));
                    currentYpos += GAMEBRICK_DIMY;
                }
                currentXpos += GAMEBRICK_DIMX;
            }
        }

        /// <summary>
        /// select a brick in a grid and put it in.
        /// </summary>
        /// <param name="x"> position x</param>
        /// <param name="y"> position y</param>
        /// <param name="state">state of brick</param>
        /// <param name="durability">durability of brick</param>
        /// <returns>value if brick was insert correctly</returns>
        public KeyValuePair<GameObjectEmpty, Boolean> brickSelected(double x, double y, BrickStatus state, int durability)
        {
            KeyValuePair<GameObjectEmpty, Boolean> retState = new KeyValuePair<GameObjectEmpty, bool>(new GameObjectEmpty(new Position(0, 0), 0, 0), false);
            foreach (GameObjectEmpty objectEmpty in builderGrid.Keys)
            {
                if (x > objectEmpty.GetPos().GetX() && x <= objectEmpty.GetPos().GetX() + objectEmpty.GetWidth() && y > objectEmpty.GetPos().GetY()
                        && y <= objectEmpty.GetPos().GetY() + objectEmpty.GetHeight())
                {
                    KeyValuePair<int, int> brickSelected = builderGrid[objectEmpty];
                    if (this.gameGrid[brickSelected].Value != null)
                    {
                        KeyValuePair<GameObjectEmpty, BrickBasic> temp = new KeyValuePair<GameObjectEmpty, BrickBasic>(gameGrid[brickSelected].Key, null);
                        gameGrid[brickSelected] = temp;

                        retState = new KeyValuePair<GameObjectEmpty, bool>(objectEmpty, false);
                    }
                    else
                    {
                        string selectedTexture;
                        if (state.Equals(BrickStatus.dropPowerup))
                        {
                            selectedTexture = BrickBasic.GetDefaultPowerupTexturePath();
                        }
                        else if (state.Equals(BrickStatus.notDestructible))
                        {
                            selectedTexture = BrickBasic.GetTextureNotDestructible();
                        }
                        else
                        {
                            selectedTexture = BrickBasic.GetDefaultBrickTexturePath();
                        }

                        GameObjectEmpty gameObjectEmpty = gameGrid[brickSelected].Key;
                        BrickBasic brick = new BrickBasic(new Position(gameObjectEmpty.GetPos().GetX(), gameObjectEmpty.GetPos().GetY()),
                                                          this.gameGrid[brickSelected].Key.GetHeight(),
                                                          this.gameGrid[brickSelected].Key.GetWidth(),
                                                          state,
                                                          durability,
                                                          selectedTexture);
                        KeyValuePair<GameObjectEmpty, BrickBasic>  temp = new KeyValuePair<GameObjectEmpty, BrickBasic>(gameGrid[brickSelected].Key, brick);
                        gameGrid[brickSelected] = temp;
                        retState = new KeyValuePair<GameObjectEmpty, bool>(objectEmpty, true);
                    }
                }
            }
            return retState;
        }

        /// <summary>
        /// Set name of level
        /// </summary>
        /// <param name="levelName">name of new level</param>
        public void setLevelName(string levelName)
        {
            this.levelName = levelName;
        }

        /// <summary>
        /// Set background of level
        /// </summary>
        /// <param name="path">path of background</param>
        /// <param name="theme">name of background</param>
        public void SetBackGround(string path, string theme)
        {
            background = new BackgroundTexture(path, theme);
        }

        /// <summary>
        /// Set music of level
        /// </summary>
        /// <param name="path">path of music</param>
        /// <param name="theme">name of music</param>
        public void SetMusic(string path, string theme)
        {
            music = new PersonalSounds(path, theme);
        }

        /// <summary>
        /// Set ball of level
        /// </summary>
        /// <param name="path">path of ball</param>
        /// <param name="theme">name of ball</param>
        public void SetBall(string path, string theme)
        {
            ball = new BallTexture(path, theme);
        }

        /// <summary>
        /// Set paddle of level
        /// </summary>
        /// <param name="path">path of paddle</param>
        /// <param name="theme">name of paddle</param>
        public void setPaddle(string path, string theme)
        {
            paddle = new PaddleTexture(path, theme);
        }

        /// <summary>
        /// Build the level.
        /// </summary>
        /// <returns>level built</returns>
        public Level Build()
        {
            ISet<BrickBasic> levelBrick = new HashSet<BrickBasic>();
            foreach (var elem in this.gameGrid.Values)
            {
                if(gameGrid.Values != null)
                {
                    var temp = gameGrid.Values.ToHashSet();
                    levelBrick = temp.Where(c => c.Value != null).Select(c => c.Value).ToHashSet();
                }
            }
            return new Level(levelName, levelBrick, music, background, ball, paddle);
        }
    }
}
