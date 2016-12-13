﻿using System;
using System.Collections.Generic;
using Hik.Communication.ScsServices.Service;

namespace TaxiDesktopClient
{
    [ScsService]
    public interface ITaxiService
    {
        int CreateOrder(string Name, string Phone, string StartAddress, string StartGeographicalLatitude, string StartGeographicalLongitude, string FinishAddress, string FinishGeographicalLatitude, string FinishGeographicalLongitude, List<string> Extra);
        decimal GetPrice(string StartAddress, string StartGeographicalLatitude, string StartGeographicalLongitude, string FinishAddress, string FinishGeographicalLatitude, string FinishGeographicalLongitude);
        string GetOperatorPhone();
        int GetOrderStatus(int OrderID);
        string GetDriverPhone(int OrderID);
        string GetDriverName(int OrderID);
        string GetDriverPosition(int OrderID);
        void AbortOrder(int OrderID);
    }
}
