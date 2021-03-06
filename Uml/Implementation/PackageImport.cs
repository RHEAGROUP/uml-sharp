﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PackageImport.cs" company="RHEA System S.A.">
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

namespace Implementation.CommonStructure
{
    using System;
    using System.Collections.Generic;
    using Uml.CommonStructure;
    using Uml.Packages;    

    /// <summary>
    /// A <see cref="PackageImport"/> is a <see cref="Relationship"/> that imports all the non-private members of a <see cref="Package"/> into the Namespace owning the <see cref="PackageImport"/>, so that those <see cref="Element"/>s may be referred to by their unqualified names in the importingNamespace.
    /// </summary>
    internal class PackageImport : Implementation.CommonStructure.Element, Uml.CommonStructure.PackageImport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageImport"/> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the <see cref="PackageImport"/>
        /// </param>
        public PackageImport(string id) : base(id)
        {
        }

        /// <summary>
        /// Specifies the elements related by the <see cref="PackageImport"/>.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        public IEnumerable<Uml.CommonStructure.Element> RelatedElement()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Specifies the source Element(s) of the <see cref="PackageImport"/>.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        public IEnumerable<Uml.CommonStructure.Element> Source()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Specifies the target Element(s) of the <see cref="PackageImport"/>.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        public IEnumerable<Uml.CommonStructure.Element> Target()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Specifies the <see cref="Package"/> whose members are imported into a <see cref="Namespace"/>.
        /// </summary>
        /// <remarks>
        /// Subsets <see cref="DirectedRelationship.Target"/>
        /// </remarks>
        public Package ImportedPackage
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Specifies the <see cref="Namespace"/> that imports the members from a <see cref="Package"/>.
        /// </summary>
        /// <remarks>
        /// Subsets <see cref="DirectedRelationship.Source"/>
        /// </remarks>
        public Namespace ImportingNamespace
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Specifies the visibility of the imported <see cref="PackageableElement"/>s within the importingNamespace, i.e., whether imported <see cref="Element"/>s will in turn be visible to other <see cref="Namespace"/>s. If the <see cref="PackageImport"/> is public, the imported Elements will be visible outside the importingNamespace, while, if the <see cref="PackageImport"/> is private, they will not.
        /// </summary>
        public VisibilityKind Visibility { get; set; }
    }
}