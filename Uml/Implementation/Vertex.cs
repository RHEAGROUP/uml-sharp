﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Vertex.cs" company="RHEA System S.A.">
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

namespace Implementation.StateMachines
{
    using Uml.CommonStructure;

    /// <summary>
    /// A Vertex is an abstraction of a node in a StateMachine graph. It can be the source or destination of any number of Transitions.
    /// </summary>
    internal class Vertex : Element, Uml.StateMachines.Vertex
    {
    }
}