// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
//
// Theme Coloring Source: https://github.com/fsprojects/VisualFSharpPowerTools
//
// Copyright 2014 F# Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System.Windows.Media;

namespace SiliconStudio.Xenko.VisualStudio.Classifiers
{
    public struct ClassificationColor
    {
        public readonly Color? ForegroundColor;
        public readonly Color? BackgroundColor;

        public ClassificationColor(Color? foregroundColor = null, Color? backgroundColor = null)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
        }
    }
}