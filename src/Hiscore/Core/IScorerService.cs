// <copyright file="IScorerService.cs" company="Luke Parker">
// Copyright (c) Luke Parker. All rights reserved.
// </copyright>

namespace LPSoft.Hiscore.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using LPSoft.Hiscore.Core.ViewModels;

    /// <summary>
    /// Service for submitting and getting scores.
    /// </summary>
    public interface IScorerService
    {
        /// <summary>
        /// Gets the scores in the database.
        /// </summary>
        /// <returns>Returns a task which has a <see cref="List{T}"/> of <see cref="ScoreItem"/>.</returns>
        Task<List<ScoreItem>> GetAsync();
    }
}
