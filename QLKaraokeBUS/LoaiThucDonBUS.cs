using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKaraokeDAO;
using QLKaraokeDTO;

namespace QLKaraokeBUS
{
   public class LoaiThucDonBUS
    {
       public List<LoaiThucDonDTO> dsAllLoaiPhong()
       {
           LoaiThucDonDAO d = new LoaiThucDonDAO();
           return d.dsLoaiThucDon();
       }
    }
}
