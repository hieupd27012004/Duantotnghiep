﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.ViewModel
{
    public class ThongKeTheoThoiGianViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ThongKeKhoangThoiGian> ThongKeKhoangThoiGian { get; set; }
    }
}
