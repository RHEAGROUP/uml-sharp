﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ExpansionNode.cs" company="RHEA System S.A.">
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

namespace Implementation.Actions
{
    using Uml.CommonStructure;

    /// <summary>
    /// An <see cref="ExpansionNode"/> is an <see cref="ObjectNode"/> used to indicate a collection input or output for an <see cref="ExpansionRegion"/>. A collection input of an <see cref="ExpansionRegion"/> contains a collection that is broken into its individual elements inside the region, whose content is executed once per element. A collection output of an <see cref="ExpansionRegion"/> combines individual elements produced by the execution of the region into a collection for use outside the region.
    /// </summary>
    internal class ExpansionNode : Implementation.CommonStructure.Element //, Uml.Actions.ExpansionNode
    {
        public ExpansionNode(string id) : base(id)
        {
        }
    }
}