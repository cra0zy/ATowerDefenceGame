using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ATowerDefenceGame
{
    static class InputManager
    {
        public static KeyboardState KeyState;
        public static KeyboardState PrevKeyState;

        public static void Update()
        {
            PrevKeyState = KeyState;
            KeyState = Keyboard.GetState();
        }

        public static bool KeyPressed(Keys key)
        {
            return PrevKeyState.IsKeyUp(key) && KeyState.IsKeyDown(key);
        }
    }
}