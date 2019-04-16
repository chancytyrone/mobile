﻿using System;
using System.Globalization;

namespace Bit.Core.Abstractions
{
    public interface II18nService
    {
        CultureInfo Culture { get; set; }
        StringComparer StringComparer { get; }
        string T(string id, string p1, string p2, string p3);
        string Translate(string id, string p1, string p2, string p3);
    }
}