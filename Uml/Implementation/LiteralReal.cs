﻿// -------------------------------------------------------------------------------------------------
// <copyright file="LiteralReal.cs" company="RHEA System S.A.">
//   Copyright (c) 2018-2019 RHEA System S.A.
//
//   This file is part of uml-sharp
//
//   uml-sharp is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   uml-sharp is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with uml-sharp. If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Implementation.Values
{
    using Uml.CommonStructure;

    /// <summary>
    /// A LiteralReal is a specification of a Real value.
    /// </summary>
    internal class LiteralReal : Implementation.CommonStructure.Element //, Uml.Values.LiteralReal
    {
        public LiteralReal(string id) : base(id)
        {
        }
    }
}