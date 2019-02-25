﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PackageableElement.cs" company="RHEA System S.A.">
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
//   along with Foobar.  If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Implementation.CommonStructure
{
    using Uml.CommonStructure;

    /// <summary>
    /// A <see cref="PackageableElement"/> is a <see cref="NamedElement"/> that may be owned directly by a <see cref="Package"/>. A <see cref="PackageableElement"/> is also able to serve as the parameteredElement of a <see cref="TemplateParameter"/>.
    /// </summary>
    internal class PackageableElement : Element, Uml.CommonStructure.PackageableElement
    {
    }
}
