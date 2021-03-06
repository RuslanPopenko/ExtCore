﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using ExtCore.Data.Models.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ExtCore.Data.EntityFramework.PostgreSql
{
  /// <summary>
  /// Implements the <see cref="IRepository">IRepository</see> interface and represents default repository behavior.
  /// </summary>
  public abstract class RepositoryBase<TEntity> : IRepository where TEntity : class, IEntity
  {
    protected StorageContext storageContext;
    protected DbSet<TEntity> dbSet;

    /// <summary>
    /// Sets the storage context that represents the PostgreSQL database to work with.
    /// </summary>
    /// <param name="storageContext">The storage context to set.</param>
    public void SetStorageContext(IStorageContext storageContext)
    {
      this.storageContext = storageContext as StorageContext;
      this.dbSet = this.storageContext.Set<TEntity>();
    }
  }
}