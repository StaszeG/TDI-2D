using AutoMapper;
using SFML.Graphics;
using SFML.Window;
using TDI2D.Models;
using TDI2D.ServiceLayer.Models;

namespace TDI2D.Maps
{
    public class SfmlProfile : Profile
    {
        public SfmlProfile()
        {
            CreateMap<WindowSettings, RenderWindow>()
                .ConstructUsing(x => new RenderWindow(
                    new VideoMode(x.Width, x.Height), x.WindowTitle));

            CreateMap<WindowSettings, WindowSettingsModel>()
                .ReverseMap();
        }
    }
}
