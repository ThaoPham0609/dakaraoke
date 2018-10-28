using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLKaraokeDTO;
using QLKaraokeDAO;

namespace QLKaraokeBUS
{
    public class PhongBUS
    {
        public List<PhongDTO> dsAllTruyen()
        {
            PhongDAO ds = new PhongDAO();
            return ds.dsPhong();
        }
    }
}
