﻿// -------------------------------------------------------------------------------------------------
// <copyright file="CommunicationPath.cs" company="RHEA System S.A.">
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

namespace Implementation.Deployments
{
    using Uml.CommonStructure;

    /// <summary>
    /// A communication path is an association between two deployment targets, through which they are able to exchange signals and messages.
    /// </summary>
    internal class CommunicationPath : Implementation.CommonStructure.Element //, Uml.Deployments.CommunicationPath
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CommunicationPath"/>
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the <see cref="CommunicationPath"/>
        /// </param>        
        public CommunicationPath(string id) : base(id)
        {
        }
    }
}