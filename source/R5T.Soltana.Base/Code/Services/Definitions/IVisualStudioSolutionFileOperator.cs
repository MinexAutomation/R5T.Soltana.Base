﻿using System;
using System.Collections.Generic;

using R5T.Cambridge.Types;


namespace R5T.Soltana
{
    /// <summary>
    /// A service for operating on (in-memory) <see cref="SolutionFile"/> instances.
    /// </summary>
    /// <remarks>
    /// Throughout, a solution file path is required to turn relative paths in the solution file into absolute project file paths.
    /// </remarks>
    public interface IVisualStudioSolutionFileOperator
    {
        SolutionFile CreateNew();

        void AddProjectFile(SolutionFile solutionFile, string solutionFilePath, string projectFilePath);

        void RemoveProjectFile(SolutionFile solutionFile, string solutionFilePath, string projectFilePath);

        /// <summary>
        /// Lists project file paths in the solution.
        /// </summary>
        IEnumerable<string> ListProjectFiles(SolutionFile solutionFile, string solutionFilePath);
    }
}