﻿#region License
// Copyright 2013 David Meyer
// 
// This file is part of FluentTestCase.
// 
// FluentTestCase is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// FluentTestCase is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with FluentTestCase.  If not, see <http://www.gnu.org/licenses/>.
#endregion

namespace FluentTestCase
{
    public abstract class Act<T> : FluentTestCaseState<T> 
        where T : TestCase
    {
        internal Act()
        { }

        public abstract Acted<T> AsActed();
    }
}
