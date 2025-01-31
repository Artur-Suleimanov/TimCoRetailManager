﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class InventoryData : IInventoryData
    {
        private readonly ISqlDataAccess _sql;

        public InventoryData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<InventoryModel> GetInventory()
        {
            var output = _sql.LoadData<InventoryModel, dynamic>("spInventory_GetAll", new { }, "TRMData");

            return output;
        }

        public void SaveInventoryRecord(InventoryModel item)
        {
            _sql.SaveData("spInventory_Insert", item, "TRMData");
        }
    }
}
