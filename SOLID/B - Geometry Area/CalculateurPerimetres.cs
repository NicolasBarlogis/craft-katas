using System.Collections.Generic;

namespace SOLID.B___Geometry_Area
{
    public class CalculateurPerimetres
    {
        public double SommePerimetres(IList<IFigure> figures)
        {
            var area = 0d;
            foreach (var figure in figures)
            {
                switch (figure)
                {
                    case Rectangle figureRectangle:
                    {
                        var rectangle = figureRectangle;
                        area += (rectangle.Largeur + rectangle.Longueur) * 2;
                        break;
                    }
                    case Triangle figureTriangle:
                    {
                        var triangle = figureTriangle;
                        area += triangle.Base + triangle.Cote2 + triangle.Cote3;
                        break;
                    }
                }
            }

            return area;
        }
    }
}