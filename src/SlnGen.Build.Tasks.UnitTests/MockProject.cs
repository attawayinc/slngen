﻿// Copyright (c) Jeff Kluge. All rights reserved.
//
// Licensed under the MIT license.

using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using System.Collections.Generic;

namespace SlnGen.Build.Tasks.UnitTests
{
    internal static class MockProject
    {
        public static Project Create(string fullPath, IDictionary<string, string> globalProperties)
        {
            ProjectRootElement rootElement = ProjectRootElement.Create(fullPath);

            Project project = new Project(globalProperties: globalProperties, toolsVersion: null, projectCollection: ProjectCollection.GlobalProjectCollection, xml: rootElement);

            return project;
        }
    }
}