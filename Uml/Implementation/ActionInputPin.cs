﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ActionInputPin.cs" company="RHEA System S.A.">
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
    /// An ActionInputPin is a kind of InputPin that executes an Action to determine the values to input to another Action.
    /// </summary>
    internal class ActionInputPin : Implementation.CommonStructure.Element //, Uml.Actions.ActionInputPin
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ActionInputPin"/>
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the <see cref="ActionExecuActionInputPintionSpecification"/>
        /// </param>
        protected ActionInputPin(string id) : base(id)
        {
        }
    }
}
