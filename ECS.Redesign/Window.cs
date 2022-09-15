using System;
namespace ECS.Legacy
{
    public class Window : IWindow
    {
        public string Open() => "Window is open";
        public string Close() => "Window is closed";
    }
}