// <copyright file="SqlScoringService.cs" company="Luke Parker">
// Copyright (c) Luke Parker. All rights reserved.
// </copyright>

namespace LPSoft.Hiscore.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using LPSoft.Hiscore.Core.ViewModels;

    /// <summary>
    /// Sql Implementatio of the <see cref="IScorerService"/>.
    /// </summary>
    public sealed class SqlScoringService : IScorerService
    {
        /// <inheritdoc/>
        public Task<List<ScoreItem>> GetAsync()
        {
            return Task.FromResult(new List<ScoreItem>());
        }
    }
}
