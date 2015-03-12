using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RectangleWcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RectangleService" in both code and config file together.
    public class RectangleService : IRectangleService
    {
        public  RectangleService(string points)
        {
            x1 = Convert.ToInt16(points.Split(',')[0]);
            y1 = Convert.ToInt16(points.Split(',')[1]);
            x2 = Convert.ToInt16(points.Split(',')[2]);
            y2 = Convert.ToInt16(points.Split(',')[3]);
        }

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        void IRectangleService.RectangleService(string points)
        {
            throw new NotImplementedException();
        }
    }
}
