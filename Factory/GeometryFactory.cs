using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IGeometryFactory
    {
        string Draw();
    }

    public class Pentgon : IGeometryFactory
    {
        public string Draw()
        {
            return "PentAgon";
        }
    }
    public class Hexagon : IGeometryFactory
    {
        public string Draw()
        {
            return "Hexagon";
        }
    }

    public class GeometryFactory
    {
        public static IGeometryFactory GetGeometry(string name)
        {
            IGeometryFactory geometryFactory = null;
            if (name.ToLower().Equals("pentgon"))
            {
                geometryFactory = new Pentgon();
            }
            else if (name.ToLower().Equals("hexagon"))
            {
                geometryFactory = new Hexagon();
            }
            else
            {
                Console.Write("Invalid Type" + name);
            }
            return geometryFactory;
        }
    }
}
