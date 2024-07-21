using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
    public interface IRectangle :IShape
    {
      public  double Length { get; set;} 
      public  double Width { get; set; }
    }
}
