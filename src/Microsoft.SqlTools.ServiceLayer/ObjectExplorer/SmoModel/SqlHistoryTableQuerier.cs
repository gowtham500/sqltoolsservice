﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlServer.Management.Smo;

namespace Microsoft.SqlTools.ServiceLayer.ObjectExplorer.SmoModel
{
    /// <summary>
    /// Filters the history tables to only return ones related to the parent table
    /// </summary>
    internal partial class SqlHistoryTableQuerier : SmoQuerier
    {
        protected override bool PassesFinalFilters(SqlSmoObject parent, SqlSmoObject smoObject)
        {
            Table parentTable = parent as Table;
            Table historyTable = smoObject as Table;

            return (parentTable.HistoryTableID == historyTable.ID);
        }
    }
}
