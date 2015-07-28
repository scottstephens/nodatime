// Copyright 2015 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.
using System;
using System.Reflection;

namespace NodaTime.Extensions
{
    /// <summary>
    /// Extensions for compatibility between the PCL and normal desktop framework around reflection.
    /// </summary>
    internal static class TypeExtensions
    {
        internal static Assembly GetAssembly(this Type type)
        {
#if PCL
            return type.GetTypeInfo().Assembly;
#else
            return type.Assembly;
#endif
        }
    }
}
