﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;

namespace MvvmCross.Forms.Views.Base
{
    public interface IMvxEventSourcePage : IMvxEventSourceElement
    {
        event EventHandler AppearingCalled;

        event EventHandler DisappearingCalled;
    }
}
