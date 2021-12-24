﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IInMemItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAysnc(Item item);
        Task DeleteItemAsync(Guid id);

    }


}