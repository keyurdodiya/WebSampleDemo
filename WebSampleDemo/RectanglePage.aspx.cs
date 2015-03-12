using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RectangleWcfServices;

namespace WebSampleDemo
{
    public partial class RectanglePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string inputString = string.Empty;
            string[] strArray = null;
            int i, j, count = 0;

            inputString = InputTextbox.Text;
            inputString = inputString.Replace("(","");
            strArray = inputString.Split(')');
            
            for(i=0;i<strArray.GetUpperBound(0);i++)
            {
                
                RectangleWcfServices.RectangleService rect1= new RectangleWcfServices.RectangleService(strArray[i]);
                AreaRect areaRect= new AreaRect();
                Label1.Text =Label1.Text+ "Area of Rectangle" + (i + 1) + "is " + areaRect.CalculateArea(rect1) +"</br>";
                for (j = 0; j < strArray.GetUpperBound(0); j++)
                {
                    if(i!=j)
                    {
                        RectangleWcfServices.RectangleService rect2 = new RectangleWcfServices.RectangleService(strArray[j]);
                        if(areaRect.CheckRectanleIntrasection(rect1,rect2))
                        {
                            count = count + 1;
                        }
                    }
                }
                Label1.Text = Label1.Text + "Number of Rectangles Intrsect with Rectangle  " + (i + 1) + " is " + count + "</br>";
                count = 0;
            }
        }

      }
}