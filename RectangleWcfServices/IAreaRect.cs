using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RectangleWcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAreaRect" in both code and config file together.
    [ServiceContract]
    public interface IAreaRect
    {
        [OperationContract]
        int CalculateArea(RectangleService rect);

        [OperationContract]
        bool CheckRectanleIntrasection(RectangleService rect1,RectangleService rect2);
    }
}
