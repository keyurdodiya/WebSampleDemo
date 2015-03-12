using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RectangleWcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AreaRect" in both code and config file together.
    public class AreaRect : IAreaRect
    {
        public int CalculateArea(RectangleWcfServices.RectangleService rect)
        {
            int length = Math.Abs(rect.x2 - rect.x1);
            int width = Math.Abs(rect.y2 - rect.y1);
            int area = length * width;
            return area;
        }
        public bool CheckRectanleIntrasection(RectangleWcfServices.RectangleService rect1, RectangleWcfServices.RectangleService rect2)
        {
            bool isCheck = false;
            try
            {
                if (rect1.x2 >= rect2.x1 && rect1.x1 <= rect2.x2 && rect1.y1 <= rect2.y2 && rect1.y2 >= rect2.y1)
                {
                    isCheck = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isCheck;
        }
    }
}
