﻿using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories.PluginInterfaces
{
    /**
     * public interface IPluginInterface
     * 
     * Create the abstraction to allow plugins to be written later
     */
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);

        Task<bool> ExistsAsync(Inventory inventory);

        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        
        Task<Inventory> GetInventoryByIdAsync(int inventoryId);


        Task UpdateInventoryAsync(Inventory inventory);


    }
}