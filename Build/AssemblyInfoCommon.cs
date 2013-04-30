﻿// <copyright>
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// The following assembly information is common to all * Tools for Visual Studio assemblies.
// If you get compiler errors CS0579, "Duplicate '<attributename>' attribute", check your 
// Properties\AssemblyInfo.cs file and remove any lines duplicating the ones below.
// (See also AssemblyVersion.cs in this same directory.)
[assembly: AssemblyCompany("Microsoft")]
#if NODEJS_TOOLS
[assembly: AssemblyProduct("Node.js Tools for Visual Studio")]
#else
[assembly: AssemblyProduct("Python Tools for Visual Studio")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
#endif