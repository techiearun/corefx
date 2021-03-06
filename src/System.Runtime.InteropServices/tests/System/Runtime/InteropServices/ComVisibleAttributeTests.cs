// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Linq;
using System.Reflection;
using Xunit;

namespace System.Runtime.InteropServices.Tests
{
    [ComVisible(true)]
    public class ComVisibleAttributeTests
    {
        [Fact]
        public void Exists()
        {
            var type = typeof(ComVisibleAttributeTests);
            var attr = type.GetCustomAttributes(typeof(ComVisibleAttribute), false).OfType<ComVisibleAttribute>().SingleOrDefault();
            Assert.NotNull(attr);
            Assert.Equal(true, attr.Value);
        }
    }
}
