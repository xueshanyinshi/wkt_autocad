using Autodesk.AutoCAD.DatabaseServices;
using GeoAPI.Geometries;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTForWKT
{
    public static class WKTForAutocad
    {
        public static Entity WKTToAutoCADGeometry(this string WKTStr)
        {
            WKTReader reader = new WKTReader();
            IGeometry geom = reader.Read(WKTStr);
            switch (geom.OgcGeometryType)
            {
                case OgcGeometryType.Point:
                    return FromPoint((IPoint)geometry, factory, setUserData);
                case OgcGeometryType.LineString:
                    return FromLineString((ILineString)geometry, factory, setUserData);
                case OgcGeometryType.Polygon:
                    return FromPolygon((IPolygon)geometry, factory, setUserData);
                case OgcGeometryType.MultiPoint:
                    return FromMultiPoint((IMultiPoint)geometry, factory, setUserData);
                case OgcGeometryType.MultiLineString:
                    return FromMultiLineString((IMultiLineString)geometry, factory, setUserData);
                case OgcGeometryType.MultiPolygon:
                    return FromMultiPolygon((IMultiPolygon)geometry, factory, setUserData);
                case OgcGeometryType.GeometryCollection:
                    return FromGeometryCollection((IGeometryCollection)geometry, factory, setUserData);
                default:
                    throw new ArgumentException();
            }

            return null;
        }

    }
}
