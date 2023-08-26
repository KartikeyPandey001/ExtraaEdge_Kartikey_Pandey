﻿using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Service
{
    public interface IMobileService
    {
        IEnumerable<Mobile> GetAllMobile();
        Mobile GetMobileById(int id);
        int AddMobile(Mobile mob);
        int UpdateMobile(Mobile mob);
        int DeleteMobile(int id);
    }
}
