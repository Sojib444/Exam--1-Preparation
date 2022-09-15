using DemoLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebLibrary.BusinessObject
{
    public class BStudent:IBStudent
    {
        public string? BName { get; set; }
        public string? BAddress { get; set; }
        public string? BEmail { get; set; }
        public DateTime BDateTime { get; set; }
        public double BCGPA { get; set; }

        public void SetProperCGpa()
        {
            if(BCGPA<3)
            {
                BCGPA = 3;
            }
        }
    }
}
