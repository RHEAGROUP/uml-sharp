﻿// -------------------------------------------------------------------------------------------------
// <copyright file="MultiplicityElement.cs" company="RHEA System S.A.">
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
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Values;

    /// <summary>
    /// A multiplicity is a definition of an inclusive interval of non-negative integers beginning with a lower bound and ending with a (possibly infinite) upper bound. A MultiplicityElement embeds this information to specify the allowable cardinalities for an instantiation of the Element.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false)]
    public interface MultiplicityElement : Element
    {
        /// <summary>
        /// For a multivalued multiplicity, this attribute specifies whether the values in an instantiation of this <see cref="MultiplicityElement"/> are sequentially ordered.
        /// </summary>
        bool IsOrdered { get; set; }

        /// <summary>
        /// For a multivalued multiplicity, this attributes specifies whether the values in an instantiation of this <see cref="MultiplicityElement"/> are unique.
        /// </summary>
        bool IsUnique { get; set; }

        /// <summary>
        /// The lower bound of the multiplicity interval.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        int Lower();

        /// <summary>
        /// The specification of the lower bound for this multiplicity.
        /// </summary>
        /// <remarks>
        /// Subsets <see cref="Element.OwnedElement"/>
        /// </remarks>
        OwnerList<ValueSpecification> LowerValue { get; set; }

        /// <summary>
        /// The upper bound of the multiplicity interval.
        /// </summary>
        /// <remarks>
        /// Derived property.
        /// </remarks>
        string Upper();
        
        /// <summary>
        /// The specification of the upper bound for this multiplicity.
        /// </summary>
        /// <remarks>
        /// Subsets <see cref="Element.OwnedElement"/>
        /// </remarks>
        OwnerList<ValueSpecification> UperValue { get; set; }
    }
}