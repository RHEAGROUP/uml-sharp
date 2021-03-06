﻿// -------------------------------------------------------------------------------------------------
// <copyright file="TemplateBinding.cs" company="RHEA System S.A.">
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
    using Uml.Classification;

    /// <summary>
    /// A <see cref="TemplateBinding"/> is a <see cref="DirectedRelationship"/> between a <see cref="TemplateableElement"/> and a template. A <see cref="TemplateBinding"/> specifies the <see cref="TemplateParameterSubstitution"/>s of actual parameters for the formal parameters of the template.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface TemplateBinding : DirectedRelationship
    {
        /// <summary>
        /// The <see cref="TemplateableElement"/> that is bound by this <see cref="TemplateBinding"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Source|Element.Owner", RedefinedProperty = "")]
        TemplateableElement BoundElement { get; set; }

        /// <summary>
        /// The <see cref="TemplateParameterSubstitution"/>s owned by this <see cref="TemplateBinding"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement", RedefinedProperty = "")]
        OwnerList<TemplateParameterSubstitution>  ParameterSubstitution { get; set; }

        /// <summary>
        /// The <see cref="TemplateSignature"/> for the template that is the target of this <see cref="TemplateBinding"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Target", RedefinedProperty = "")]
        TemplateSignature Signature { get; set; }
    }
}