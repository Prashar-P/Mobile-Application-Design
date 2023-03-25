using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artistic.Model
{
    public record Item
    (
        string Name,
        ImageSource ProductImage,
        string Description,
        string Artist,
        DateTime UploadTime
   );


        
}
