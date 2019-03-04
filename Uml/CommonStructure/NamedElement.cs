﻿// -------------------------------------------------------------------------------------------------
// <copyright file="NamedElement.cs" company="RHEA System S.A.">
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

namespace Uml.CommonStructure
{
    using System.Collections.Generic;
    using Uml.Assembler;
    using Uml.Values;

    /// <summary>
    /// A <see cref="NamedElement"/> is an <see cref="Element"/> in a model that may have a name. The name may be given directly and/or via the use of a <see cref="StringExpression"/>.
    /// </summary>
    public interface NamedElement : Element
    {
        /// <summary>
        /// Indicates the Dependencies that reference this <see cref="NamedElement"/> as a client.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        IEnumerable<Dependency> ClientDependency();

        /// <summary>
        /// The name of the <see cref="NamedElement"/>.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The <see cref="StringExpression"/> used to define the name of this <see cref="NamedElement"/>.
        /// </summary>
        /// <remarks>
        /// Subsets <see cref="Element.OwnedElement"/>.
        /// </remarks>
        OwnerList<StringExpression> NameExpression { get; set; }

        /// <summary>
        /// Specifies the <see cref="Namespace"/> that owns the <see cref="NamedElement"/>.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        Namespace Namespace();

        /// <summary>
        /// A name that allows the <see cref="NamedElement"/> to be identified within a hierarchy of nested <see cref="Namespace"/>s. It is constructed from the names of the containing <see cref="Namespace"/>s starting at the root of the hierarchy and ending with the name of the <see cref="NamedElement"/> itself.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        string QualifiedName();

        /// <summary>
        /// Determines whether and how the <see cref="NamedElement"/> is visible outside its owning <see cref="Namespace"/>.
        /// </summary>
        VisibilityKind Visibility { get; set; }
    }
}